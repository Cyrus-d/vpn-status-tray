using System;
using System.Diagnostics;

namespace VPNStatusTray.Utils
{

    //    http://geekswithblogs.net/thibbard/archive/2007/01/22/CSharpCodeToMaintainVPNConnectionProgramatically.aspx
    /// <summary>
    /// Class to maintain connectivity to a specific VPN connection
    /// </summary>
    /// <history>
    ///     [Tim Hibbard]   01/24/2007  Created
    /// </history>
    public class VPNManager
    {
        public VPNManager(string VPNName)
        {
            _VPNConnectionName = VPNName;
        }
        #region --Const--
        /// <summary>
        /// Where the rasphone.exe lives
        /// </summary>
        private const string VPNPROCESS = "C:\\WINDOWS\\system32\\rasphone.exe";
        #endregion

        #region --Fields--
        /// <summary>
        /// Internal variable for VPNConnectionName
        /// </summary>
        private string _VPNConnectionName;
        /// <summary>
        /// Internal variable for IPToPing
        /// </summary>
        private string _IPToPing = "";
        /// <summary>
        /// Internal variable for IsConnected
        /// </summary>
        private readonly bool _isConnected = false;

        #endregion

        #region --Events--
        public delegate void PingingHandler();
        public delegate void ConnectingHandler();
        public delegate void DisconnectingHandler();
        public delegate void IdleHandler();
        public delegate void ConnectionStatusChangedHandler(bool Connected);

        /// <summary>
        /// Fires when validating connectivity
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public event PingingHandler Pinging;

        /// <summary>
        /// Fired when it is trying to connect to the VPN
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public event ConnectingHandler Connecting;

        /// <summary>
        /// Fired when it is trying to disconnect from the VPN
        /// </summary>
        public event DisconnectingHandler Disconnecting;

        /// <summary>
        /// Fired when it is done working for the moment
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public event IdleHandler Idle;

        /// <summary>
        /// Fired when the IsConnected Property changes
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public event ConnectionStatusChangedHandler ConnectionStatusChanged;

        /// <summary>
        /// Call to raise Pinging event
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        protected void OnPinging()
        {
            if (Pinging != null)
            {
                Pinging();
            }
        }

        /// <summary>
        /// Call to raise Connecting event
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        protected void OnConnecting()
        {
            if (Connecting != null)
            {
                Connecting();
            }
        }

        /// <summary>
        /// Call to raise Disconnecting event
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        protected void OnDisconnecting()
        {
            if (Disconnecting != null)
            {
                Disconnecting();
            }
        }

        /// <summary>
        /// Call to raise Idle event
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        protected void OnIdle()
        {
            if (Idle != null)
            {
                Idle();
            }
        }

        /// <summary>
        /// Call to raise ConnectionStatusChanged event
        /// </summary>
        /// <param name="Connected">If connected to network</param>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        protected void OnConnectionStatusChanged(bool Connected)
        {
            if (ConnectionStatusChanged != null)
            {
                ConnectionStatusChanged(Connected);
            }
        }

        #endregion

        #region --Properties--
        /// <summary>
        /// Returns if you are connected to the network
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public bool IsConnected
        {
            get { return _isConnected; }
        }

        /// <summary>
        /// IP to ping to validate connectivity
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public string IPToPing
        {
            get { return _IPToPing; }
            set { _IPToPing = value; }
        }

        /// <summary>
        /// Name of VPN connection as seen in network connections (not case sensitive)
        /// </summary>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public string VPNConnectionName
        {
            get { return _VPNConnectionName; }
            set { _VPNConnectionName = value; }
        }
        #endregion


        /// <summary>
        /// Shells the command to connect to the VPN
        /// </summary>
        /// <returns>True if connected</returns>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public bool Connect()
        {
            bool RV = false;
            try
            {
                OnConnecting();
                var cmd = new Process
                {
                    StartInfo =
                    {
                        FileName = VPNPROCESS,
                        Arguments = "-d \"" + _VPNConnectionName + "\"",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        ErrorDialog = true,
                        RedirectStandardError = true
                    }
                };
                cmd.Start();

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(5000);
                System.Windows.Forms.Application.DoEvents();

                RV = true;
                OnIdle();

            }
            catch (Exception Ex)
            {
                Debug.Assert(false, Ex.ToString());
            }
            return RV;
        }

        /// <summary>
        /// Shells the command to disconnect from the VPN connection
        /// </summary>
        /// <returns>True if successfully disconnected</returns>
        /// <history>
        ///     [Tim Hibbard]   01/24/2007  Created
        /// </history>
        public bool Disconnect()
        {

            return DisconnectByName(_VPNConnectionName);
        }

        public void DisconnectAll()
        {
            var connections = VPNConnections.GetConnections();
            foreach (var con in connections)
                DisconnectByName(con);
        }

        public bool DisconnectByName(string vpnConnectionName)
        {
            try
            {
                OnDisconnecting();
                var cmd = new Process
                {
                    StartInfo =
                    {
                        FileName = VPNPROCESS,
                        Arguments = "-h \"" + vpnConnectionName + "\"",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        ErrorDialog = true,
                        RedirectStandardError = true
                    }
                };
                cmd.Start();
                OnIdle();
                return true;
            }
            catch (Exception Ex)
            {
                Debug.Assert(false, Ex.ToString());
                return false;
            }
        }


    }
}

