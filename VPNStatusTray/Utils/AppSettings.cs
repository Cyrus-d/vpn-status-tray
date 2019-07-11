
using Newtonsoft.Json;
using System;
using System.IO;
using VPNStatusTray.Models;

namespace VPNStatusTray.Utils
{
    public static class AppSettings
    {
        private static readonly string path = "setting.json";
        public static Setting GetSetting()
        {
            if (!File.Exists(path)) return new Setting();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Setting>(json);
                return items;
            }
        }
        public static void SetSetting(Setting setting)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, setting);
            }
        }
        public static string ValidateSetting()
        {
            var sett = GetSetting();

            if (string.IsNullOrEmpty(sett.IpgeolocationToken) && string.IsNullOrEmpty(sett.IpinfoToken)) {
                return "Token has not been provided";
             };
            if (sett.DefaultGeolocationProvider == GeolocationProvider.ipinfo 
                && string.IsNullOrEmpty(sett.IpinfoToken))
            {
                return "Token has not been provided for default provider";
            };
            if (sett.DefaultGeolocationProvider == GeolocationProvider.ipgeolocation 
                && string.IsNullOrEmpty(sett.IpgeolocationToken))
            {
                return "Token has not been provided for default provider";
            };

            if(string.IsNullOrEmpty(sett.OriginCountry))
            {
                return "Enter Origin Country (country that blocks Internet)";
            }

            return null;
        }

        internal static bool IsValidSetting()
        {
            var message=ValidateSetting();
            return string.IsNullOrEmpty(message);
        }
    }
}
