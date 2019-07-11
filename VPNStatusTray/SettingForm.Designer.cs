namespace VPNStatusTray
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbIpgeolocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIpinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbipinfo = new System.Windows.Forms.RadioButton();
            this.rbipgeolocation = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlOriginCountry = new System.Windows.Forms.ComboBox();
            this.ddlVpnTargetCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VPN Target Country";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbIpgeolocation
            // 
            this.tbIpgeolocation.Location = new System.Drawing.Point(188, 88);
            this.tbIpgeolocation.Name = "tbIpgeolocation";
            this.tbIpgeolocation.Size = new System.Drawing.Size(173, 26);
            this.tbIpgeolocation.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ipgeolocation Token";
            // 
            // tbIpinfo
            // 
            this.tbIpinfo.Location = new System.Drawing.Point(188, 56);
            this.tbIpinfo.Name = "tbIpinfo";
            this.tbIpinfo.Size = new System.Drawing.Size(173, 26);
            this.tbIpinfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ipinfo Token";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "default";
            // 
            // rbipinfo
            // 
            this.rbipinfo.AutoSize = true;
            this.rbipinfo.Location = new System.Drawing.Point(379, 58);
            this.rbipinfo.Name = "rbipinfo";
            this.rbipinfo.Size = new System.Drawing.Size(21, 20);
            this.rbipinfo.TabIndex = 12;
            this.rbipinfo.TabStop = true;
            this.rbipinfo.UseVisualStyleBackColor = true;
            // 
            // rbipgeolocation
            // 
            this.rbipgeolocation.AutoSize = true;
            this.rbipgeolocation.Location = new System.Drawing.Point(379, 90);
            this.rbipgeolocation.Name = "rbipgeolocation";
            this.rbipgeolocation.Size = new System.Drawing.Size(21, 20);
            this.rbipgeolocation.TabIndex = 13;
            this.rbipgeolocation.TabStop = true;
            this.rbipgeolocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbipgeolocation.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 353);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Origin Country";
            // 
            // ddlOriginCountry
            // 
            this.ddlOriginCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOriginCountry.FormattingEnabled = true;
            this.ddlOriginCountry.Location = new System.Drawing.Point(189, 159);
            this.ddlOriginCountry.Name = "ddlOriginCountry";
            this.ddlOriginCountry.Size = new System.Drawing.Size(172, 28);
            this.ddlOriginCountry.TabIndex = 16;
            // 
            // ddlVpnTargetCountry
            // 
            this.ddlVpnTargetCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVpnTargetCountry.FormattingEnabled = true;
            this.ddlVpnTargetCountry.Location = new System.Drawing.Point(189, 193);
            this.ddlVpnTargetCountry.Name = "ddlVpnTargetCountry";
            this.ddlVpnTargetCountry.Size = new System.Drawing.Size(172, 28);
            this.ddlVpnTargetCountry.TabIndex = 17;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 350);
            this.Controls.Add(this.ddlVpnTargetCountry);
            this.Controls.Add(this.ddlOriginCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rbipgeolocation);
            this.Controls.Add(this.rbipinfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIpgeolocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIpinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbIpgeolocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIpinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbipinfo;
        private System.Windows.Forms.RadioButton rbipgeolocation;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlOriginCountry;
        private System.Windows.Forms.ComboBox ddlVpnTargetCountry;
    }
}