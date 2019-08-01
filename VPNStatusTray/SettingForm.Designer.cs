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
            this.ddlVPNList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbWebSocket = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VPN Target Country";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbIpgeolocation
            // 
            this.tbIpgeolocation.Location = new System.Drawing.Point(125, 57);
            this.tbIpgeolocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpgeolocation.Name = "tbIpgeolocation";
            this.tbIpgeolocation.Size = new System.Drawing.Size(244, 20);
            this.tbIpgeolocation.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ipgeolocation Token";
            // 
            // tbIpinfo
            // 
            this.tbIpinfo.Location = new System.Drawing.Point(125, 36);
            this.tbIpinfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpinfo.Name = "tbIpinfo";
            this.tbIpinfo.Size = new System.Drawing.Size(244, 20);
            this.tbIpinfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ipinfo Token";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "default";
            // 
            // rbipinfo
            // 
            this.rbipinfo.AutoSize = true;
            this.rbipinfo.Location = new System.Drawing.Point(394, 38);
            this.rbipinfo.Margin = new System.Windows.Forms.Padding(2);
            this.rbipinfo.Name = "rbipinfo";
            this.rbipinfo.Size = new System.Drawing.Size(14, 13);
            this.rbipinfo.TabIndex = 12;
            this.rbipinfo.TabStop = true;
            this.rbipinfo.UseVisualStyleBackColor = true;
            // 
            // rbipgeolocation
            // 
            this.rbipgeolocation.AutoSize = true;
            this.rbipgeolocation.Location = new System.Drawing.Point(394, 58);
            this.rbipgeolocation.Margin = new System.Windows.Forms.Padding(2);
            this.rbipgeolocation.Name = "rbipgeolocation";
            this.rbipgeolocation.Size = new System.Drawing.Size(14, 13);
            this.rbipgeolocation.TabIndex = 13;
            this.rbipgeolocation.TabStop = true;
            this.rbipgeolocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbipgeolocation.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 229);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Origin Country";
            // 
            // ddlOriginCountry
            // 
            this.ddlOriginCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOriginCountry.FormattingEnabled = true;
            this.ddlOriginCountry.Location = new System.Drawing.Point(126, 128);
            this.ddlOriginCountry.Margin = new System.Windows.Forms.Padding(2);
            this.ddlOriginCountry.Name = "ddlOriginCountry";
            this.ddlOriginCountry.Size = new System.Drawing.Size(243, 21);
            this.ddlOriginCountry.TabIndex = 16;
            // 
            // ddlVpnTargetCountry
            // 
            this.ddlVpnTargetCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVpnTargetCountry.FormattingEnabled = true;
            this.ddlVpnTargetCountry.Location = new System.Drawing.Point(126, 150);
            this.ddlVpnTargetCountry.Margin = new System.Windows.Forms.Padding(2);
            this.ddlVpnTargetCountry.Name = "ddlVpnTargetCountry";
            this.ddlVpnTargetCountry.Size = new System.Drawing.Size(243, 21);
            this.ddlVpnTargetCountry.TabIndex = 17;
            // 
            // ddlVPNList
            // 
            this.ddlVPNList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVPNList.FormattingEnabled = true;
            this.ddlVPNList.Location = new System.Drawing.Point(125, 92);
            this.ddlVPNList.Margin = new System.Windows.Forms.Padding(2);
            this.ddlVPNList.Name = "ddlVPNList";
            this.ddlVPNList.Size = new System.Drawing.Size(244, 21);
            this.ddlVPNList.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Default VPN Interface";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(125, 273);
            this.tbPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(244, 20);
            this.tbPort.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "WebSocket";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Will broadcast vpn status to other applications";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Enable";
            // 
            // cbWebSocket
            // 
            this.cbWebSocket.AutoSize = true;
            this.cbWebSocket.Location = new System.Drawing.Point(126, 254);
            this.cbWebSocket.Name = "cbWebSocket";
            this.cbWebSocket.Size = new System.Drawing.Size(15, 14);
            this.cbWebSocket.TabIndex = 25;
            this.cbWebSocket.UseVisualStyleBackColor = true;
            this.cbWebSocket.CheckedChanged += new System.EventHandler(this.CbWebSocket_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 362);
            this.Controls.Add(this.cbWebSocket);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlVPNList);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox ddlVPNList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbWebSocket;
    }
}