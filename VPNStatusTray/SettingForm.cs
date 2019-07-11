using System;
using VPNStatusTray.Models;
using VPNStatusTray.Utils;
using System.Windows.Forms;

namespace VPNStatusTray
{
    public partial class SettingForm : Form
    {
        Setting currentSetting = null;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            ddlOriginCountry.Items.AddRange(CountryList.GetCountryList());
            ddlVpnTargetCountry.Items.AddRange(CountryList.GetCountryList());

            var set = AppSettings.GetSetting();
            tbIpgeolocation.Text = set.IpgeolocationToken;
            tbIpinfo.Text = set.IpinfoToken;
            ddlOriginCountry.SelectedIndex = ddlOriginCountry.FindStringExact(set.OriginCountry);
            ddlVpnTargetCountry.SelectedIndex = ddlVpnTargetCountry.FindStringExact(set.TargetCountry);
            rbipinfo.Checked = set.DefaultGeolocationProvider == GeolocationProvider.ipinfo;
            rbipgeolocation.Checked = set.DefaultGeolocationProvider == GeolocationProvider.ipgeolocation;
            currentSetting = set;
            lblError.Text = AppSettings.ValidateSetting();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AppSettings.SetSetting(new Setting()
            {
                TargetCountry = ddlVpnTargetCountry.Text,
                IpinfoToken = tbIpinfo.Text,
                IpgeolocationToken = tbIpgeolocation.Text,
                OriginCountry = ddlOriginCountry.Text,
                DefaultGeolocationProvider = rbipinfo.Checked ? GeolocationProvider.ipinfo : GeolocationProvider.ipgeolocation
            });
            lblError.Text = AppSettings.ValidateSetting();
            if (string.IsNullOrEmpty(lblError.Text))
            {
                VPNChecker.CheckStatus();
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AppSettings.SetSetting(currentSetting);
            Close();
        }
    }
}
