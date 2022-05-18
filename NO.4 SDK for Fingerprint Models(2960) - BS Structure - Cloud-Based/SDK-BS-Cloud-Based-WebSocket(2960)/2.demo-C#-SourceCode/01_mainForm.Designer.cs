namespace WebsocketWinformDemo_Standard
{
    partial class mainForm
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
        /// 设计器支持所需的Function[方法] - 不要
        /// 使用代码编辑器修改此Function[方法]的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Step1_websocketServerConnect_gbx = new System.Windows.Forms.GroupBox();
            this.cbx_useSSL = new System.Windows.Forms.CheckBox();
            this.serverStatusImage_pbx = new System.Windows.Forms.PictureBox();
            this.startServer_btn = new System.Windows.Forms.Button();
            this.serverPort_tbx = new System.Windows.Forms.TextBox();
            this.IpAddress_lbl = new System.Windows.Forms.Label();
            this.Step2_API_register_gbx = new System.Windows.Forms.GroupBox();
            this.register_Note_lbl = new System.Windows.Forms.Label();
            this.Step2_register_datagridview = new System.Windows.Forms.DataGridView();
            this.RegisterDGV_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDGV_SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDGV_Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloudID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDGV_Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Step3_API_login_gbx = new System.Windows.Forms.GroupBox();
            this.Step3_login_datagridview = new System.Windows.Forms.DataGridView();
            this.LoginDGV_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDGV_SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDGV_Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDGV_Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoginDGV_Open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.operationMsg_lbl = new System.Windows.Forms.Label();
            this.Console_gbx = new System.Windows.Forms.GroupBox();
            this.tbx_FeedbackMsg = new System.Windows.Forms.TextBox();
            this.consoleMsg_tbx = new System.Windows.Forms.TextBox();
            this.clearConsole_btn = new System.Windows.Forms.Button();
            this.pauseDisplay_cbx = new System.Windows.Forms.CheckBox();
            this.antoRegister_cbx = new System.Windows.Forms.CheckBox();
            this.antoLogin_cbx = new System.Windows.Forms.CheckBox();
            this.online_lbl = new System.Windows.Forms.Label();
            this.onlineCount_lbl = new System.Windows.Forms.Label();
            this.lbl_FeedbackMsg = new System.Windows.Forms.Label();
            this.Step1_websocketServerConnect_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusImage_pbx)).BeginInit();
            this.Step2_API_register_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step2_register_datagridview)).BeginInit();
            this.Step3_API_login_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step3_login_datagridview)).BeginInit();
            this.Console_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Step1_websocketServerConnect_gbx
            // 
            this.Step1_websocketServerConnect_gbx.Controls.Add(this.cbx_useSSL);
            this.Step1_websocketServerConnect_gbx.Controls.Add(this.serverStatusImage_pbx);
            this.Step1_websocketServerConnect_gbx.Controls.Add(this.startServer_btn);
            this.Step1_websocketServerConnect_gbx.Controls.Add(this.serverPort_tbx);
            this.Step1_websocketServerConnect_gbx.Controls.Add(this.IpAddress_lbl);
            this.Step1_websocketServerConnect_gbx.Location = new System.Drawing.Point(12, 39);
            this.Step1_websocketServerConnect_gbx.Name = "Step1_websocketServerConnect_gbx";
            this.Step1_websocketServerConnect_gbx.Size = new System.Drawing.Size(377, 52);
            this.Step1_websocketServerConnect_gbx.TabIndex = 0;
            this.Step1_websocketServerConnect_gbx.TabStop = false;
            this.Step1_websocketServerConnect_gbx.Text = "Step1_websocketServerConnect";
            // 
            // cbx_useSSL
            // 
            this.cbx_useSSL.AutoSize = true;
            this.cbx_useSSL.Checked = true;
            this.cbx_useSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_useSSL.Location = new System.Drawing.Point(6, 22);
            this.cbx_useSSL.Name = "cbx_useSSL";
            this.cbx_useSSL.Size = new System.Drawing.Size(42, 16);
            this.cbx_useSSL.TabIndex = 9;
            this.cbx_useSSL.Text = "SSL";
            this.cbx_useSSL.UseVisualStyleBackColor = true;
            this.cbx_useSSL.CheckedChanged += new System.EventHandler(this.cbx_useSSL_CheckedChanged);
            // 
            // serverStatusImage_pbx
            // 
            this.serverStatusImage_pbx.Image = ((System.Drawing.Image)(resources.GetObject("serverStatusImage_pbx.Image")));
            this.serverStatusImage_pbx.Location = new System.Drawing.Point(311, 12);
            this.serverStatusImage_pbx.Name = "serverStatusImage_pbx";
            this.serverStatusImage_pbx.Size = new System.Drawing.Size(35, 34);
            this.serverStatusImage_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.serverStatusImage_pbx.TabIndex = 4;
            this.serverStatusImage_pbx.TabStop = false;
            // 
            // startServer_btn
            // 
            this.startServer_btn.BackColor = System.Drawing.SystemColors.Control;
            this.startServer_btn.Location = new System.Drawing.Point(238, 19);
            this.startServer_btn.Name = "startServer_btn";
            this.startServer_btn.Size = new System.Drawing.Size(63, 21);
            this.startServer_btn.TabIndex = 3;
            this.startServer_btn.Text = "Start";
            this.startServer_btn.UseVisualStyleBackColor = false;
            this.startServer_btn.Click += new System.EventHandler(this.startServer_btn_Click);
            // 
            // serverPort_tbx
            // 
            this.serverPort_tbx.Location = new System.Drawing.Point(184, 19);
            this.serverPort_tbx.Name = "serverPort_tbx";
            this.serverPort_tbx.Size = new System.Drawing.Size(47, 21);
            this.serverPort_tbx.TabIndex = 2;
            this.serverPort_tbx.Text = "2018";
            // 
            // IpAddress_lbl
            // 
            this.IpAddress_lbl.AutoSize = true;
            this.IpAddress_lbl.Location = new System.Drawing.Point(54, 23);
            this.IpAddress_lbl.Name = "IpAddress_lbl";
            this.IpAddress_lbl.Size = new System.Drawing.Size(0, 12);
            this.IpAddress_lbl.TabIndex = 1;
            // 
            // Step2_API_register_gbx
            // 
            this.Step2_API_register_gbx.Controls.Add(this.register_Note_lbl);
            this.Step2_API_register_gbx.Controls.Add(this.Step2_register_datagridview);
            this.Step2_API_register_gbx.Location = new System.Drawing.Point(12, 97);
            this.Step2_API_register_gbx.Name = "Step2_API_register_gbx";
            this.Step2_API_register_gbx.Size = new System.Drawing.Size(481, 185);
            this.Step2_API_register_gbx.TabIndex = 1;
            this.Step2_API_register_gbx.TabStop = false;
            this.Step2_API_register_gbx.Text = "Step2_API_register";
            // 
            // register_Note_lbl
            // 
            this.register_Note_lbl.AutoSize = true;
            this.register_Note_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.register_Note_lbl.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register_Note_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.register_Note_lbl.Location = new System.Drawing.Point(8, 157);
            this.register_Note_lbl.Name = "register_Note_lbl";
            this.register_Note_lbl.Size = new System.Drawing.Size(409, 20);
            this.register_Note_lbl.TabIndex = 1;
            this.register_Note_lbl.Text = "The device requests [Register] only once";
            // 
            // Step2_register_datagridview
            // 
            this.Step2_register_datagridview.AllowUserToAddRows = false;
            this.Step2_register_datagridview.AllowUserToDeleteRows = false;
            this.Step2_register_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Step2_register_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterDGV_No,
            this.RegisterDGV_SN,
            this.RegisterDGV_Session,
            this.CloudID,
            this.RegisterDGV_Status});
            this.Step2_register_datagridview.Location = new System.Drawing.Point(6, 20);
            this.Step2_register_datagridview.Name = "Step2_register_datagridview";
            this.Step2_register_datagridview.RowTemplate.Height = 23;
            this.Step2_register_datagridview.Size = new System.Drawing.Size(469, 159);
            this.Step2_register_datagridview.TabIndex = 0;
            // 
            // RegisterDGV_No
            // 
            this.RegisterDGV_No.HeaderText = "No";
            this.RegisterDGV_No.Name = "RegisterDGV_No";
            this.RegisterDGV_No.ReadOnly = true;
            this.RegisterDGV_No.Width = 40;
            // 
            // RegisterDGV_SN
            // 
            this.RegisterDGV_SN.HeaderText = "SerialNumber";
            this.RegisterDGV_SN.Name = "RegisterDGV_SN";
            this.RegisterDGV_SN.ReadOnly = true;
            this.RegisterDGV_SN.Width = 130;
            // 
            // RegisterDGV_Session
            // 
            this.RegisterDGV_Session.HeaderText = "SessionID";
            this.RegisterDGV_Session.Name = "RegisterDGV_Session";
            this.RegisterDGV_Session.ReadOnly = true;
            // 
            // CloudID
            // 
            this.CloudID.HeaderText = "CloudID";
            this.CloudID.Name = "CloudID";
            this.CloudID.ReadOnly = true;
            this.CloudID.Width = 90;
            // 
            // RegisterDGV_Status
            // 
            this.RegisterDGV_Status.HeaderText = "Status";
            this.RegisterDGV_Status.Name = "RegisterDGV_Status";
            this.RegisterDGV_Status.ReadOnly = true;
            this.RegisterDGV_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterDGV_Status.Width = 50;
            // 
            // Step3_API_login_gbx
            // 
            this.Step3_API_login_gbx.Controls.Add(this.Step3_login_datagridview);
            this.Step3_API_login_gbx.Location = new System.Drawing.Point(12, 288);
            this.Step3_API_login_gbx.Name = "Step3_API_login_gbx";
            this.Step3_API_login_gbx.Size = new System.Drawing.Size(481, 215);
            this.Step3_API_login_gbx.TabIndex = 2;
            this.Step3_API_login_gbx.TabStop = false;
            this.Step3_API_login_gbx.Text = "Step3_API_login";
            // 
            // Step3_login_datagridview
            // 
            this.Step3_login_datagridview.AllowUserToAddRows = false;
            this.Step3_login_datagridview.AllowUserToDeleteRows = false;
            this.Step3_login_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Step3_login_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginDGV_No,
            this.LoginDGV_SN,
            this.LoginDGV_Session,
            this.LoginDGV_Status,
            this.LoginDGV_Open});
            this.Step3_login_datagridview.Location = new System.Drawing.Point(9, 20);
            this.Step3_login_datagridview.Name = "Step3_login_datagridview";
            this.Step3_login_datagridview.RowTemplate.Height = 23;
            this.Step3_login_datagridview.Size = new System.Drawing.Size(466, 189);
            this.Step3_login_datagridview.TabIndex = 1;
            this.Step3_login_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Step3_login_datagridview_CellContentClick);
            // 
            // LoginDGV_No
            // 
            this.LoginDGV_No.HeaderText = "No";
            this.LoginDGV_No.Name = "LoginDGV_No";
            this.LoginDGV_No.ReadOnly = true;
            this.LoginDGV_No.Width = 40;
            // 
            // LoginDGV_SN
            // 
            this.LoginDGV_SN.HeaderText = "SerialNumber";
            this.LoginDGV_SN.Name = "LoginDGV_SN";
            this.LoginDGV_SN.ReadOnly = true;
            this.LoginDGV_SN.Width = 130;
            // 
            // LoginDGV_Session
            // 
            this.LoginDGV_Session.HeaderText = "SessionID";
            this.LoginDGV_Session.Name = "LoginDGV_Session";
            this.LoginDGV_Session.ReadOnly = true;
            this.LoginDGV_Session.Width = 140;
            // 
            // LoginDGV_Status
            // 
            this.LoginDGV_Status.HeaderText = "Status";
            this.LoginDGV_Status.Name = "LoginDGV_Status";
            this.LoginDGV_Status.ReadOnly = true;
            this.LoginDGV_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoginDGV_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LoginDGV_Status.Width = 50;
            // 
            // LoginDGV_Open
            // 
            this.LoginDGV_Open.HeaderText = "Open";
            this.LoginDGV_Open.Name = "LoginDGV_Open";
            this.LoginDGV_Open.Width = 40;
            // 
            // operationMsg_lbl
            // 
            this.operationMsg_lbl.AutoSize = true;
            this.operationMsg_lbl.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.operationMsg_lbl.Location = new System.Drawing.Point(26, 9);
            this.operationMsg_lbl.Name = "operationMsg_lbl";
            this.operationMsg_lbl.Size = new System.Drawing.Size(0, 27);
            this.operationMsg_lbl.TabIndex = 3;
            // 
            // Console_gbx
            // 
            this.Console_gbx.Controls.Add(this.lbl_FeedbackMsg);
            this.Console_gbx.Controls.Add(this.tbx_FeedbackMsg);
            this.Console_gbx.Controls.Add(this.consoleMsg_tbx);
            this.Console_gbx.Controls.Add(this.clearConsole_btn);
            this.Console_gbx.Controls.Add(this.pauseDisplay_cbx);
            this.Console_gbx.Location = new System.Drawing.Point(499, 9);
            this.Console_gbx.Name = "Console_gbx";
            this.Console_gbx.Size = new System.Drawing.Size(430, 494);
            this.Console_gbx.TabIndex = 4;
            this.Console_gbx.TabStop = false;
            this.Console_gbx.Text = "Console";
            // 
            // tbx_FeedbackMsg
            // 
            this.tbx_FeedbackMsg.Location = new System.Drawing.Point(8, 442);
            this.tbx_FeedbackMsg.Multiline = true;
            this.tbx_FeedbackMsg.Name = "tbx_FeedbackMsg";
            this.tbx_FeedbackMsg.Size = new System.Drawing.Size(416, 46);
            this.tbx_FeedbackMsg.TabIndex = 60;
            // 
            // consoleMsg_tbx
            // 
            this.consoleMsg_tbx.Location = new System.Drawing.Point(6, 41);
            this.consoleMsg_tbx.Multiline = true;
            this.consoleMsg_tbx.Name = "consoleMsg_tbx";
            this.consoleMsg_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleMsg_tbx.Size = new System.Drawing.Size(418, 377);
            this.consoleMsg_tbx.TabIndex = 2;
            // 
            // clearConsole_btn
            // 
            this.clearConsole_btn.Location = new System.Drawing.Point(349, 12);
            this.clearConsole_btn.Name = "clearConsole_btn";
            this.clearConsole_btn.Size = new System.Drawing.Size(75, 23);
            this.clearConsole_btn.TabIndex = 1;
            this.clearConsole_btn.Text = "clear";
            this.clearConsole_btn.UseVisualStyleBackColor = true;
            this.clearConsole_btn.Click += new System.EventHandler(this.clearConsole_btn_Click);
            // 
            // pauseDisplay_cbx
            // 
            this.pauseDisplay_cbx.AutoSize = true;
            this.pauseDisplay_cbx.Cursor = System.Windows.Forms.Cursors.Default;
            this.pauseDisplay_cbx.Location = new System.Drawing.Point(241, 16);
            this.pauseDisplay_cbx.Name = "pauseDisplay_cbx";
            this.pauseDisplay_cbx.Size = new System.Drawing.Size(102, 16);
            this.pauseDisplay_cbx.TabIndex = 0;
            this.pauseDisplay_cbx.Text = "pause display";
            this.pauseDisplay_cbx.UseVisualStyleBackColor = true;
            this.pauseDisplay_cbx.CheckedChanged += new System.EventHandler(this.pauseDisplay_cbx_CheckedChanged);
            // 
            // antoRegister_cbx
            // 
            this.antoRegister_cbx.AutoSize = true;
            this.antoRegister_cbx.Checked = true;
            this.antoRegister_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.antoRegister_cbx.Location = new System.Drawing.Point(403, 56);
            this.antoRegister_cbx.Name = "antoRegister_cbx";
            this.antoRegister_cbx.Size = new System.Drawing.Size(96, 16);
            this.antoRegister_cbx.TabIndex = 5;
            this.antoRegister_cbx.Text = "AntoRegister";
            this.antoRegister_cbx.UseVisualStyleBackColor = true;
            // 
            // antoLogin_cbx
            // 
            this.antoLogin_cbx.AutoSize = true;
            this.antoLogin_cbx.Checked = true;
            this.antoLogin_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.antoLogin_cbx.Location = new System.Drawing.Point(403, 78);
            this.antoLogin_cbx.Name = "antoLogin_cbx";
            this.antoLogin_cbx.Size = new System.Drawing.Size(78, 16);
            this.antoLogin_cbx.TabIndex = 6;
            this.antoLogin_cbx.Text = "AntoLogin";
            this.antoLogin_cbx.UseVisualStyleBackColor = true;
            // 
            // online_lbl
            // 
            this.online_lbl.AutoSize = true;
            this.online_lbl.Location = new System.Drawing.Point(401, 38);
            this.online_lbl.Name = "online_lbl";
            this.online_lbl.Size = new System.Drawing.Size(47, 12);
            this.online_lbl.TabIndex = 7;
            this.online_lbl.Text = "Online:";
            // 
            // onlineCount_lbl
            // 
            this.onlineCount_lbl.AutoSize = true;
            this.onlineCount_lbl.Location = new System.Drawing.Point(448, 38);
            this.onlineCount_lbl.Name = "onlineCount_lbl";
            this.onlineCount_lbl.Size = new System.Drawing.Size(11, 12);
            this.onlineCount_lbl.TabIndex = 8;
            this.onlineCount_lbl.Text = "0";
            // 
            // lbl_FeedbackMsg
            // 
            this.lbl_FeedbackMsg.AutoSize = true;
            this.lbl_FeedbackMsg.Location = new System.Drawing.Point(6, 427);
            this.lbl_FeedbackMsg.Name = "lbl_FeedbackMsg";
            this.lbl_FeedbackMsg.Size = new System.Drawing.Size(125, 12);
            this.lbl_FeedbackMsg.TabIndex = 61;
            this.lbl_FeedbackMsg.Text = "TimeLog FeedbackMsg:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 515);
            this.Controls.Add(this.onlineCount_lbl);
            this.Controls.Add(this.online_lbl);
            this.Controls.Add(this.antoLogin_cbx);
            this.Controls.Add(this.antoRegister_cbx);
            this.Controls.Add(this.Console_gbx);
            this.Controls.Add(this.operationMsg_lbl);
            this.Controls.Add(this.Step3_API_login_gbx);
            this.Controls.Add(this.Step2_API_register_gbx);
            this.Controls.Add(this.Step1_websocketServerConnect_gbx);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Step1_websocketServerConnect_gbx.ResumeLayout(false);
            this.Step1_websocketServerConnect_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusImage_pbx)).EndInit();
            this.Step2_API_register_gbx.ResumeLayout(false);
            this.Step2_API_register_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step2_register_datagridview)).EndInit();
            this.Step3_API_login_gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Step3_login_datagridview)).EndInit();
            this.Console_gbx.ResumeLayout(false);
            this.Console_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Step1_websocketServerConnect_gbx;
        private System.Windows.Forms.TextBox serverPort_tbx;
        private System.Windows.Forms.Label IpAddress_lbl;
        private System.Windows.Forms.GroupBox Step2_API_register_gbx;
        private System.Windows.Forms.DataGridView Step2_register_datagridview;
        private System.Windows.Forms.GroupBox Step3_API_login_gbx;
        private System.Windows.Forms.DataGridView Step3_login_datagridview;
        private System.Windows.Forms.Label operationMsg_lbl;
        private System.Windows.Forms.GroupBox Console_gbx;
        private System.Windows.Forms.Button clearConsole_btn;
        public System.Windows.Forms.CheckBox pauseDisplay_cbx;
        public System.Windows.Forms.TextBox consoleMsg_tbx;
        private System.Windows.Forms.CheckBox antoRegister_cbx;
        private System.Windows.Forms.CheckBox antoLogin_cbx;
        private System.Windows.Forms.Label online_lbl;
        private System.Windows.Forms.Label onlineCount_lbl;
        private System.Windows.Forms.Label register_Note_lbl;
        private System.Windows.Forms.Button startServer_btn;
        private System.Windows.Forms.CheckBox cbx_useSSL;
        private System.Windows.Forms.PictureBox serverStatusImage_pbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDGV_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDGV_SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDGV_Session;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LoginDGV_Status;
        private System.Windows.Forms.DataGridViewButtonColumn LoginDGV_Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDGV_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDGV_SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDGV_Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloudID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegisterDGV_Status;
        private System.Windows.Forms.TextBox tbx_FeedbackMsg;
        private System.Windows.Forms.Label lbl_FeedbackMsg;

    }
}

