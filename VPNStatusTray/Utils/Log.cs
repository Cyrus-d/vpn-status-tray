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
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToLongTimeString() + ": " + log + Environment.NewLine);
            File.AppendAllText("log.txt", sb.ToString());
            sb.Clear();
        }
    }
}
