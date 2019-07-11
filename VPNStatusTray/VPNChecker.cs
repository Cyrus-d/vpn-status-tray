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
    class VPNChecker : IDisposable
    {
        /// <summary>
        /// The NotifyIcon object.
        /// </summary>
        static  NotifyIcon ni;

        /// <summary>
        /// Initializes a new instance of the <see cref="VPNChecker"/> class.
        /// </summary>
        public VPNChecker()
        {
            // Instantiate the NotifyIcon object.
            ni = new NotifyIcon();
        }

        /// <summary>
        /// Displays the icon in the system tray.
        /// </summary>
        public void Init()
        {

            // Put the icon in the system tray and allow it react to mouse clicks.			
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);

            //NetworkChange.NetworkAvailabilityChanged +=
            //           new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(AddressChangedCallback);

            ni.Visible = true;

            // Attach a context menu.
            ni.ContextMenuStrip = new ContextMenus().Create();

            if (!AppSettings.IsValidSetting())
            {
                new SettingForm().Show();
            }
            else
            {
                CheckStatus();
            }
        }
         void AddressChangedCallback(object sender, EventArgs e)
        {
            CheckStatus();
        }
        //void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        //{
        //    CheckStatus();
        //}

        public static void CheckStatus()
        {
            ni.Icon = Resources.red;
            ni.Text = "not connected";
            var sett = AppSettings.GetSetting();
            var status = VPNStatus.GetVPNStatus();
            switch (status)
            {
                case VPNState.notConnected:
                    ni.Icon = Resources.red;
                    ni.Text = "not connected";
                    break;
                case VPNState.copnnected:
                    ni.Icon = Resources.warning;
                    if (string.IsNullOrEmpty(sett.TargetCountry))
                        ni.Text = "connected";
                    else
                        ni.Text = "not connected to target country (" + sett.TargetCountry + ")";
                    break;
                case VPNState.connectedToCountry:
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
            // Handle mouse button clicks.
            if (e.Button == MouseButtons.Left)
            {
                Process.Start("ms-settings:network-vpn");
            }
        }
    }
}