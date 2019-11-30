using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using VPNStatusTray.Properties;

namespace VPNStatusTray
{
    /// <summary>
    /// 
    /// </summary>
    class ContextMenus
    {
        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        bool isSettingLoaded = false;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            item = new ToolStripMenuItem();
            item.Text = "Settings";
            item.Click += new EventHandler(Setting_Click);
            item.Image = Resources.setting;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Logs";
            item.Click += new EventHandler(Logs_Click);
            item.Image = Resources.log;
            menu.Items.Add(item);

            //// Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            //// Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            item.Image = Resources.exit;
            menu.Items.Add(item);

            return menu;
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            if (File.Exists(path))
                Process.Start(path);
            else
                MessageBox.Show("No log file found.");
        }

        /// <summary>
        /// Handles the Click event of the About control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Setting_Click(object sender, EventArgs e)
        {
            if (!isSettingLoaded)
            {
                isSettingLoaded = true;
                new SettingForm().Show();
                isSettingLoaded = false;
            }
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }
    }
}