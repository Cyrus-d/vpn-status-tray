using System;
using VPNStatusTray.Models;
using VPNStatusTray.Utils;
using System.Windows.Forms;

namespace VPNStatusTray
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            var set = Settings.GetSetting();
            tbTargetCountry.Text = set.TargetCountry;
            tbTargetCity.Text = set.TargetCity;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Settings.SetSetting(new Setting()
            {
                TargetCity = tbTargetCity.Text,
                TargetCountry = tbTargetCountry.Text
            });
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
