using System;
using System.Diagnostics;
using System.Windows.Forms;
using VPNStatusTray.Properties;
using VPNStatusTray.Utils;

namespace VPNStatusTray
{
	/// <summary>
	/// 
	/// </summary>
	class ProcessIcon : IDisposable
	{
		/// <summary>
		/// The NotifyIcon object.
		/// </summary>
		NotifyIcon ni;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessIcon"/> class.
		/// </summary>
		public ProcessIcon()
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

            //if(Utils.Connections.IsConnected())
            ni.Icon = Resources.red;
			ni.Text = "not connected";
			ni.Visible = true;

			// Attach a context menu.
			ni.ContextMenuStrip = new ContextMenus().Create();

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