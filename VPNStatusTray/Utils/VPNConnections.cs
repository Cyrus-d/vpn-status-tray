
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;


namespace VPNStatusTray.Utils
{
    public static class VPNConnections
    {
        public static string[] GetConnections()
        {
            var vpnList=new List<string>();
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) +
                          @"\Microsoft\Network\Connections\Pbk\rasphone.pbk";

            const string pattern = @"\[(.*?)\]";
            var matches = Regex.Matches(System.IO.File.ReadAllText(path), pattern);

            foreach (Match m in matches)
                vpnList.Add(m.Value.TrimStart('[').TrimEnd(']'));
            return vpnList.ToArray();
        }
    }
}
