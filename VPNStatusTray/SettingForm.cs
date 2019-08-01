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
            ddlVPNList.Items.AddRange(VPNConnections.GetConnections());

            var set = AppSettings.GetSetting();
            tbIpgeolocation.Text = set.IpgeolocationToken;
            tbIpinfo.Text = set.IpinfoToken;
            ddlOriginCountry.SelectedIndex = ddlOriginCountry.FindStringExact(set.OriginCountry);
            ddlVpnTargetCountry.SelectedIndex = ddlVpnTargetCountry.FindStringExact(set.TargetCountry);
            ddlVPNList.SelectedIndex = ddlVPNList.FindStringExact(set.DefaultVPNInterface);
            rbipinfo.Checked = set.DefaultGeolocationProvider == GeolocationProvider.ipinfo;
            rbipgeolocation.Checked = set.DefaultGeolocationProvider == GeolocationProvider.ipgeolocation;
            currentSetting = set;
            lblError.Text = AppSettings.ValidateSetting();
            cbWebSocket.Checked = set.WebSocketEnabled;
            tbPort.Text = set.WebSocketPort == 0 ? 8181.ToString() : set.WebSocketPort.ToString();
            tbPort.Enabled = set.WebSocketEnabled;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            var oldSett = AppSettings.GetSetting();

            var newSetting = new Setting()
            {
                TargetCountry = ddlVpnTargetCountry.Text,
                IpinfoToken = tbIpinfo.Text,
                IpgeolocationToken = tbIpgeolocation.Text,
                OriginCountry = ddlOriginCountry.Text,
                DefaultGeolocationProvider = rbipinfo.Checked ? GeolocationProvider.ipinfo : GeolocationProvider.ipgeolocation,
                DefaultVPNInterface = ddlVPNList.Text,
                WebSocketEnabled = cbWebSocket.Checked,
                WebSocketPort = Convert.ToInt32(tbPort.Text)
            };

            AppSettings.SetSetting(newSetting);
            lblError.Text = AppSettings.ValidateSetting();

            if (string.IsNullOrEmpty(lblError.Text))
            {
                if (newSetting.WebSocketEnabled && oldSett.WebSocketPort != newSetting.WebSocketPort)
                    WebSocket.ChangePort(newSetting.WebSocketPort);

                if (!newSetting.WebSocketEnabled) WebSocket.CloseAll();

                Main.CheckStatus();
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AppSettings.SetSetting(currentSetting);
            Close();
        }

        private void CbWebSocket_CheckedChanged(object sender, EventArgs e)
        {
            tbPort.Enabled = cbWebSocket.Checked;
        }
    }
}
