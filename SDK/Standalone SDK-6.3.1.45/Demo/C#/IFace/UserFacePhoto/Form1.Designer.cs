﻿namespace UserFacePhoto
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.txtMachineSN2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSendUserFacePhoto = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPhtoName = new System.Windows.Forms.ComboBox();
            this.btnGetUserFacePhotoNames = new System.Windows.Forms.Button();
            this.btnGetUserFacePhotoByName = new System.Windows.Forms.Button();
            this.btnGetUserFacePhotoCount = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 146);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 102);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 21);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.55.112";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(181, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnRsConnect);
            this.tabPage2.Controls.Add(this.txtMachineSN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbBaudRate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbPort);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232/485";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(183, 43);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(75, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(356, 10);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 21);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "MachineSN";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(206, 10);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 20);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "BaudRate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPort.Location = new System.Drawing.Point(71, 10);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 20);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.txtMachineSN2);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnUSBConnect);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(441, 76);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USBClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(233, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 10;
            this.label29.Text = "MachineSN";
            // 
            // txtMachineSN2
            // 
            this.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineSN2.Location = new System.Drawing.Point(294, 13);
            this.txtMachineSN2.Name = "txtMachineSN2";
            this.txtMachineSN2.Size = new System.Drawing.Size(27, 21);
            this.txtMachineSN2.TabIndex = 9;
            this.txtMachineSN2.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(120, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "Virtual USBClient";
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(183, 42);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(75, 23);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(150, 125);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(161, 12);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSendUserFacePhoto);
            this.groupBox1.Controls.Add(this.buttonSelect);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.pb_Photo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbPhtoName);
            this.groupBox1.Controls.Add(this.btnGetUserFacePhotoNames);
            this.groupBox1.Controls.Add(this.btnGetUserFacePhotoByName);
            this.groupBox1.Controls.Add(this.btnGetUserFacePhotoCount);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(9, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 441);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download or Clear ";
            // 
            // buttonSendUserFacePhoto
            // 
            this.buttonSendUserFacePhoto.Location = new System.Drawing.Point(45, 348);
            this.buttonSendUserFacePhoto.Name = "buttonSendUserFacePhoto";
            this.buttonSendUserFacePhoto.Size = new System.Drawing.Size(122, 22);
            this.buttonSendUserFacePhoto.TabIndex = 23;
            this.buttonSendUserFacePhoto.Text = "SendUserFacePhoto";
            this.buttonSendUserFacePhoto.UseVisualStyleBackColor = true;
            this.buttonSendUserFacePhoto.Click += new System.EventHandler(this.buttonSendUserFacePhoto_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(386, 312);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(37, 20);
            this.buttonSelect.TabIndex = 22;
            this.buttonSelect.Text = "Sel";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(44, 312);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(339, 21);
            this.textBoxFileName.TabIndex = 21;
            // 
            // pb_Photo
            // 
            this.pb_Photo.Location = new System.Drawing.Point(113, 20);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(240, 192);
            this.pb_Photo.TabIndex = 20;
            this.pb_Photo.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "PhtoName";
            // 
            // cbPhtoName
            // 
            this.cbPhtoName.FormattingEnabled = true;
            this.cbPhtoName.Location = new System.Drawing.Point(113, 228);
            this.cbPhtoName.Name = "cbPhtoName";
            this.cbPhtoName.Size = new System.Drawing.Size(121, 20);
            this.cbPhtoName.TabIndex = 18;
            // 
            // btnGetUserFacePhotoNames
            // 
            this.btnGetUserFacePhotoNames.Location = new System.Drawing.Point(44, 254);
            this.btnGetUserFacePhotoNames.Name = "btnGetUserFacePhotoNames";
            this.btnGetUserFacePhotoNames.Size = new System.Drawing.Size(151, 23);
            this.btnGetUserFacePhotoNames.TabIndex = 12;
            this.btnGetUserFacePhotoNames.Text = "GetUserFacePhotoNames";
            this.btnGetUserFacePhotoNames.UseVisualStyleBackColor = true;
            this.btnGetUserFacePhotoNames.Click += new System.EventHandler(this.btnGetUserFacePhotoNames_Click);
            // 
            // btnGetUserFacePhotoByName
            // 
            this.btnGetUserFacePhotoByName.Location = new System.Drawing.Point(44, 283);
            this.btnGetUserFacePhotoByName.Name = "btnGetUserFacePhotoByName";
            this.btnGetUserFacePhotoByName.Size = new System.Drawing.Size(151, 23);
            this.btnGetUserFacePhotoByName.TabIndex = 11;
            this.btnGetUserFacePhotoByName.Text = "GetUserFacePhotoByName";
            this.btnGetUserFacePhotoByName.UseVisualStyleBackColor = true;
            this.btnGetUserFacePhotoByName.Click += new System.EventHandler(this.btnGetUserFacePhotoByName_Click);
            // 
            // btnGetUserFacePhotoCount
            // 
            this.btnGetUserFacePhotoCount.Location = new System.Drawing.Point(201, 254);
            this.btnGetUserFacePhotoCount.Name = "btnGetUserFacePhotoCount";
            this.btnGetUserFacePhotoCount.Size = new System.Drawing.Size(140, 23);
            this.btnGetUserFacePhotoCount.TabIndex = 8;
            this.btnGetUserFacePhotoCount.Text = "GetUserFacePhotoCount";
            this.btnGetUserFacePhotoCount.UseVisualStyleBackColor = true;
            this.btnGetUserFacePhotoCount.Click += new System.EventHandler(this.btnGetUserFacePhotoCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtMachineSN2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPhtoName;
        private System.Windows.Forms.Button btnGetUserFacePhotoNames;
        private System.Windows.Forms.Button btnGetUserFacePhotoByName;
        private System.Windows.Forms.Button btnGetUserFacePhotoCount;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonSendUserFacePhoto;
    }
}

