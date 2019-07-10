using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace VPNStatusTray.Utils
{
    public static class Connections
    {
        public static bool IsConnected(string vpnName = "")
        {
            if (NetworkInterface.GetIsNetworkAvailable()) return false;
            //inspired in http://stackoverflow.com/questions/12227540/how-can-i-know-whether-a-vpn-connection-is-established-or-not

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface Interface in interfaces)
            {
                if (Interface.OperationalStatus == OperationalStatus.Up)
                {
                    if ((Interface.NetworkInterfaceType == NetworkInterfaceType.Ppp) && (Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback))
                    {
                        IPv4InterfaceStatistics statistics = Interface.GetIPv4Statistics();
                        if (Interface.Name == vpnName)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
