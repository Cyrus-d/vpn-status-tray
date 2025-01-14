﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VPNStatusTray.Utils;

namespace VPNStatusTray.Models
{
    public class Setting
    {

        public string TargetCountry { get; set; }
        public string DefaultVPNInterface { get; set; }
        public string IpinfoToken { get; set; }
        public string IpgeolocationToken { get; set; }
        public string OriginCountry { get; set; }
        public GeolocationProvider DefaultGeolocationProvider { get; set; }

        public bool WebSocketEnabled { get; set; }
        public int WebSocketPort { get; set; }

    }
}
