using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using VPNStatusTray.Properties;
using VPNStatusTray.Utils;


namespace VPNStatusTray
{
    /// <summary>
    /// 
    /// </summary>
    class Main : IDisposable
    {
        /// <summary>
        /// The NotifyIcon object.
        /// </summary>
        static NotifyIcon ni;



        private static bool _isConnected = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            // Instantiate the NotifyIcon object.
            ni = new NotifyIcon();
        }

        /// <summary>
        /// Displays the icon in the system tray.
        /// </summary>
        public void Init()
        {
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.red;
            ni.Text = "not connected";

            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(AddressChangedCallback);

            ni.Visible = true;

            ni.ContextMenuStrip = new ContextMenus().Create();

            if (!AppSettings.IsValidSetting())
            {
                new SettingForm().Show();
            }
            else
            {
                var sett = AppSettings.GetSetting();
                if (sett.WebSocketEnabled)
                    WebSocket.Start(sett.WebSocketPort);
            }
        }
        void AddressChangedCallback(object sender, EventArgs e)
        {
            CheckStatus();
        }

        public static void CheckStatus()
        {
            ni.Icon = Resources.red;
            ni.Text = "not connected";
            var sett = AppSettings.GetSetting();
            var status = VPNStatus.GetVPNStatus();
            WebSocket.Send((int)status);
            _isConnected = false;
            switch (status)
            {
                case VPNState.notConnected:
                ni.Icon = Resources.red;
                ni.Text = "not connected";
                break;
                case VPNState.connected:
                ni.Icon = Resources.warning;
                _isConnected = true;
                if (string.IsNullOrEmpty(sett.TargetCountry))
                    ni.Text = "connected";
                else
                    ni.Text = "not connected to target country (" + sett.TargetCountry + ")";
                break;
                case VPNState.connectedToTargetCountry:
                _isConnected = true;
                ni.Icon = Resources.green;
                ni.Text = "connected to " + sett.TargetCountry;
                break;
                default:
                ni.Icon = Resources.red;
                ni.Text = "not connected";
                break;
            }
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        /// <summary>
        /// Handles the MouseClick event of the ni control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var sett = AppSettings.GetSetting();
                if (string.IsNullOrEmpty(sett.DefaultVPNInterface))
                {
                    Process.Start("ms-settings:network-vpn");
                }
                else
                {
                    var vpnManager = new VPNManager(sett.DefaultVPNInterface);
                    if (_isConnected)
                    {
                        vpnManager.DisconnectAll();
                    }
                    else
                    {
                        vpnManager.Connect();
                    }
                }
            }
        }
    }
}