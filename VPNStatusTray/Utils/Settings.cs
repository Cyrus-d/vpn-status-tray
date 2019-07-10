
using Newtonsoft.Json;
using System;
using System.IO;
using VPNStatusTray.Models;

namespace VPNStatusTray.Utils
{
    public static class Settings
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
    }
}
