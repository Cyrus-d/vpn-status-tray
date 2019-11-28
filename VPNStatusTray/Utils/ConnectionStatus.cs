using VPNStatusTray.Utils;

namespace VPNStatusTray.Utils
{
    public enum ConnectionState
    {
        notConnected,
        connected,
        connectedToTargetCountry
    }
    public static class ConnectionStatus
    {
        public static ConnectionState GetStatus()
        {
            var sett = AppSettings.GetSetting();

            var location = Geolocation.GetGeolocation();

            if (location == null || location.EnglishName == sett.OriginCountry) return ConnectionState.notConnected;

            if (location.EnglishName == sett.TargetCountry) return ConnectionState.connectedToTargetCountry;

            return ConnectionState.connected;
        }

    }
}
