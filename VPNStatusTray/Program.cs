using System;
using System.Windows.Forms;

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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Show the system tray icon.					
			using (ProcessIcon pi = new ProcessIcon())
			{
				pi.Init();

				// Make sure the application runs!
				Application.Run();
			}
		}
	}
}