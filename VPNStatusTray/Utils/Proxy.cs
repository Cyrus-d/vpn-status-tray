using System;
using System.Net;
using System.Timers;

namespace VPNStatusTray.Utils
{
    public class Proxy
    {
        private static Timer aTimer;
        private Action _onChange;
        private bool isProxied = false;
        private bool preIsProxied = false;


        public void OnChange(Action onChange)
        {
            _onChange = onChange;
            aTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += ATimerOnElapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void ATimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            var proxy = WebRequest.GetSystemWebProxy();
            var testUrl = new Uri("http://" + Guid.NewGuid() + ".com");
            var proxyUrl = proxy.GetProxy(testUrl);

            isProxied = proxyUrl != testUrl;

            if (isProxied != preIsProxied)
            {
                preIsProxied = isProxied;
                _onChange();
            }

        }
    }
}