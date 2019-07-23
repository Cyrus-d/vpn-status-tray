using VPNStatusTray.Utils;

namespace VPNStatusTray.Utils
{
    public enum VPNState
    {
        notConnected,
        connected,
        connectedToCountry
    }
    public static class VPNStatus
    {
        public static VPNState GetVPNStatus()
        {
            var sett = AppSettings.GetSetting();

            var isVPNInterfaceConnected = VPNInterface.IsConnected();
            if (!isVPNInterfaceConnected) return VPNState.notConnected;

            var location = Geolocation.GetGeolocation();

            if (location == null || location.EnglishName == sett.OriginCountry) return VPNState.notConnected;

            if (location.EnglishName == sett.TargetCountry) return VPNState.connectedToCountry;

            return VPNState.connected;
        }

    }
}
