using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPNStatusTray.Utils
{
    public static class Log
    {
        public static void WriteLog(string log)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToLongTimeString() + ": " + log + Environment.NewLine);
            File.AppendAllText(path, sb.ToString());
            sb.Clear();
        }
    }
}
