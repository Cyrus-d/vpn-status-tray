using System.Collections.Generic;
using System.Globalization;

namespace VPNStatusTray.Utils
{
    public static class CountryList
    {
        static string[] cultureArr;
        public static object[] GetCountryList()
        {
            if (cultureArr != null) return cultureArr;

            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                // if (!culture.IsNeutralCulture) continue;

                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }

            cultureList.Sort();
            cultureArr = cultureList.ToArray();

            return cultureArr;
        }

        public static void SetCountryList()
        {
            GetCountryList();
        }
    }
}
