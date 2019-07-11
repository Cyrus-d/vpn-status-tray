using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Net;

namespace VPNStatusTray.Utils
{
    public enum GeolocationProvider
    {
        ipinfo,
        ipgeolocation
    }
    public static class Geolocation
    {
        public static RegionInfo GetGeolocation()
        {
            var sett = AppSettings.GetSetting();
            RegionInfo location;
            if (sett.DefaultGeolocationProvider == GeolocationProvider.ipinfo)
            {
                location = GetIpinfo();
                if (location == null && !string.IsNullOrEmpty(sett.IpgeolocationToken))
                {
                    location = GetIpgeolocation();
                }
            }
            else
            {
                location = GetIpgeolocation();
                if (location == null && !string.IsNullOrEmpty(sett.IpinfoToken))
                {
                    location = GetIpinfo();
                }
            }

            return location;
        }
        public static RegionInfo GetIpinfo()
        {
            var sett = AppSettings.GetSetting();
            return GetRegionInfo(GeolocationProvider.ipinfo,"https://ipinfo.io/?token=" + sett.IpinfoToken, "country");
        }
        public static RegionInfo GetIpgeolocation()
        {
            var sett = AppSettings.GetSetting();
            return GetRegionInfo(GeolocationProvider.ipgeolocation,"https://api.ipgeolocation.io/ipgeo?apiKey=" + sett.IpgeolocationToken, "country_code2");
        }
        private static RegionInfo GetRegionInfo(GeolocationProvider provider, string url, string field)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string info = client.DownloadString(url);
                    JObject data = JObject.Parse(info);
                    var country = (string)data[field];
                    if (country == null)
                    {
                        throw new Exception("Unable to get country code (" + provider + ")");
                    };
                    return new RegionInfo(country);
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message);
                return null;
            }
        }

    }
}
