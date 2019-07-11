using System;
using System.Linq;
using System.Windows.Forms;
using VPNStatusTray.Utils;

namespace VPNStatusTray
{
    /// <summary>
    /// 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //bypass "Culture ID 4096 (0x1000) is a neutral culture" error when loading setting form from context menu
            CountryList.SetCountryList();

            // Show the system tray icon.					
            using (VPNChecker pi = new VPNChecker())
            {
                pi.Init();

                // Make sure the application runs!
                Application.Run();
            }
        }
    }
}