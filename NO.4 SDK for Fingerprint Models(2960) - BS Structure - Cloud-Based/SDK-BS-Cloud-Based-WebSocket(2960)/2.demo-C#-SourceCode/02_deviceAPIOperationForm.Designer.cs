namespace WebsocketWinformDemo_Standard
{
    partial class deviceAPIOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deviceAPIOperationForm));
            this.btn_SendToDevice = new System.Windows.Forms.Button();
            this.tbx_MessageFormServer = new System.Windows.Forms.TextBox();
            this.page_Access = new System.Windows.Forms.TabPage();
            this.lbl_CloudID = new System.Windows.Forms.Label();
            this.tbt_CloudID = new System.Windows.Forms.TextBox();
            this.lbl_operatorID = new System.Windows.Forms.Label();
            this.tbx_operatorID = new System.Windows.Forms.TextBox();
            this.lbl_DeleteAccessListNo = new System.Windows.Forms.Label();
            this.cobx_AccessListAction = new System.Windows.Forms.ComboBox();
            this.tbx_DeleteAccessListNo = new System.Windows.Forms.TextBox();
            this.btn_AddAccessList = new System.Windows.Forms.Button();
            this.dgv_AccessList = new System.Windows.Forms.DataGridView();
            this.AccessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessDerp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccessPass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccessAllWeek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessStartWeek = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccessEndWeek = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccessAllTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.btn_SetAccessSettingSimple = new System.Windows.Forms.Button();
            this.btn_GetAccessSettingSimple = new System.Windows.Forms.Button();
            this.lbl_WGOutputContent = new System.Windows.Forms.Label();
            this.lbl_WGOutputFormat = new System.Windows.Forms.Label();
            this.lbl_DoorSensorType = new System.Windows.Forms.Label();
            this.lbl_DoorOpenTimeout = new System.Windows.Forms.Label();
            this.lbl_Week = new System.Windows.Forms.Label();
            this.lbl_PassTime = new System.Windows.Forms.Label();
            this.lbl_VerifyPassLockReleaseTime = new System.Windows.Forms.Label();
            this.lbl_LockReleaseTime = new System.Windows.Forms.Label();
            this.cobx_WGOutputContent = new System.Windows.Forms.ComboBox();
            this.cobx_WGOutputFormat = new System.Windows.Forms.ComboBox();
            this.cbx_BlackListAlarm = new System.Windows.Forms.CheckBox();
            this.cbx_TamperAlarm = new System.Windows.Forms.CheckBox();
            this.cbx_LinkageAlarm = new System.Windows.Forms.CheckBox();
            this.cbx_DuressAlarm = new System.Windows.Forms.CheckBox();
            this.cobx_DoorSensorType = new System.Windows.Forms.ComboBox();
            this.tbx_DoorOpenTimeout = new System.Windows.Forms.TextBox();
            this.cobx_endWeek = new System.Windows.Forms.ComboBox();
            this.cobx_startWeek = new System.Windows.Forms.ComboBox();
            this.cbx_AllWeek = new System.Windows.Forms.CheckBox();
            this.dtp_endPassTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_startPassTime = new System.Windows.Forms.DateTimePicker();
            this.tbx_VerifyPassLockReleaseTime = new System.Windows.Forms.TextBox();
            this.cobx_LockReleaseTime = new System.Windows.Forms.ComboBox();
            this.lbl_AlarmStatus = new System.Windows.Forms.Label();
            this.lbl_DoorSensoStatus = new System.Windows.Forms.Label();
            this.lbl_LockReleaseStatus = new System.Windows.Forms.Label();
            this.cobx_AlarmStatus = new System.Windows.Forms.ComboBox();
            this.cobx_DoorSensoStatus = new System.Windows.Forms.ComboBox();
            this.cobx_LockReleaseStatus = new System.Windows.Forms.ComboBox();
            this.btn_SetAccessList = new System.Windows.Forms.Button();
            this.btn_GetAccessList = new System.Windows.Forms.Button();
            this.btn_SetAccessSetting = new System.Windows.Forms.Button();
            this.btn_GetAccessSetting = new System.Windows.Forms.Button();
            this.btn_AccessStatus = new System.Windows.Forms.Button();
            this.btn_RemoteOpen = new System.Windows.Forms.Button();
            this.page_Att = new System.Windows.Forms.TabPage();
            this.dgv_AttendanceRule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_SetAttendanceRule = new System.Windows.Forms.Button();
            this.btn_GetAttendanceRule = new System.Windows.Forms.Button();
            this.page_Data = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BeginLogPos = new System.Windows.Forms.Label();
            this.tbx_BeginLogPos = new System.Windows.Forms.TextBox();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.lbl_UserID_dataPage = new System.Windows.Forms.Label();
            this.tbx_UserID_dataPage = new System.Windows.Forms.TextBox();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.pbx_realtimePhoto_Data = new System.Windows.Forms.PictureBox();
            this.rbtn_CustomLog = new System.Windows.Forms.RadioButton();
            this.rbtn_RealTimeLog = new System.Windows.Forms.RadioButton();
            this.lbl_ReVerifyTime = new System.Windows.Forms.Label();
            this.lbl_ManagerLogWarning = new System.Windows.Forms.Label();
            this.lbl_AttLogWarning = new System.Windows.Forms.Label();
            this.cbx_Compulsion = new System.Windows.Forms.CheckBox();
            this.tbx_ReVerifyTime = new System.Windows.Forms.TextBox();
            this.tbx_ManagerLogWarning = new System.Windows.Forms.TextBox();
            this.tbx_AttLogWarning = new System.Windows.Forms.TextBox();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dgv_AttandanceLog = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogAttendStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogAPStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogJobCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_GetLogSetting = new System.Windows.Forms.Button();
            this.btn_SetLogSetting = new System.Windows.Forms.Button();
            this.btn_GetNextAttLog = new System.Windows.Forms.Button();
            this.btn_GetFirstAttLog = new System.Windows.Forms.Button();
            this.btn_GetAttendanceLog = new System.Windows.Forms.Button();
            this.btn_EmptyAllData = new System.Windows.Forms.Button();
            this.btn_EmptyUserEnrollmentData = new System.Windows.Forms.Button();
            this.btn_EmptyManageLog = new System.Windows.Forms.Button();
            this.btn_EmptyTimeLog = new System.Windows.Forms.Button();
            this.page_Net = new System.Windows.Forms.TabPage();
            this.lbl_TerminalPort = new System.Windows.Forms.Label();
            this.lbl_TerminalPassword = new System.Windows.Forms.Label();
            this.lbl_TerminalID = new System.Windows.Forms.Label();
            this.lbl_StreamingAddress = new System.Windows.Forms.Label();
            this.lbl_CloudAddress = new System.Windows.Forms.Label();
            this.lbl_Latitude = new System.Windows.Forms.Label();
            this.lbl_Longitude = new System.Windows.Forms.Label();
            this.lbl_SatelliteCount = new System.Windows.Forms.Label();
            this.lbl_VPNPwd = new System.Windows.Forms.Label();
            this.lbl_VPNAddress = new System.Windows.Forms.Label();
            this.lbl_VPNAccount = new System.Windows.Forms.Label();
            this.lbl_WIFIpwd = new System.Windows.Forms.Label();
            this.lbl_SSID = new System.Windows.Forms.Label();
            this.lbl_DHCPGateway = new System.Windows.Forms.Label();
            this.lbl_DHCPSubnet = new System.Windows.Forms.Label();
            this.lbl_DHCPIP = new System.Windows.Forms.Label();
            this.lbl_NetGateway = new System.Windows.Forms.Label();
            this.lbl_NetSubnet = new System.Windows.Forms.Label();
            this.lbl_NetIP = new System.Windows.Forms.Label();
            this.tbx_TerminalPort = new System.Windows.Forms.TextBox();
            this.tbx_TerminalPassword = new System.Windows.Forms.TextBox();
            this.tbx_TerminalID_n = new System.Windows.Forms.TextBox();
            this.tbx_StreamingAddress = new System.Windows.Forms.TextBox();
            this.cbx_UseGPS = new System.Windows.Forms.CheckBox();
            this.tbx_SatelliteCount = new System.Windows.Forms.TextBox();
            this.tbx_Latitude = new System.Windows.Forms.TextBox();
            this.tbx_Longitude = new System.Windows.Forms.TextBox();
            this.cbx_GPSAlive = new System.Windows.Forms.CheckBox();
            this.lbl_VPNIP = new System.Windows.Forms.Label();
            this.tbx_VPNPwd = new System.Windows.Forms.TextBox();
            this.tbx_VPNAccount = new System.Windows.Forms.TextBox();
            this.tbx_VPNAddress = new System.Windows.Forms.TextBox();
            this.lbl_Operator = new System.Windows.Forms.Label();
            this.lbl_MobileIP = new System.Windows.Forms.Label();
            this.cbx_UseMobileNet = new System.Windows.Forms.CheckBox();
            this.tbx_Key = new System.Windows.Forms.TextBox();
            this.tbx_SSID = new System.Windows.Forms.TextBox();
            this.cbx_useWIFI = new System.Windows.Forms.CheckBox();
            this.tbx_DHCPGateway = new System.Windows.Forms.TextBox();
            this.tbx_DHCPSubnet = new System.Windows.Forms.TextBox();
            this.tbx_DHCPIP = new System.Windows.Forms.TextBox();
            this.tbx_NetGateway = new System.Windows.Forms.TextBox();
            this.tbx_NetSubnet = new System.Windows.Forms.TextBox();
            this.tbx_NetIP = new System.Windows.Forms.TextBox();
            this.lbl_MAC = new System.Windows.Forms.Label();
            this.cbx_DHCP = new System.Windows.Forms.CheckBox();
            this.btn_SetGPS = new System.Windows.Forms.Button();
            this.tbx_CloudAddress = new System.Windows.Forms.TextBox();
            this.btn_SetStreamingServer = new System.Windows.Forms.Button();
            this.btn_GetStreamingServer = new System.Windows.Forms.Button();
            this.btn_SetCloudServer = new System.Windows.Forms.Button();
            this.btn_GetCloudServer = new System.Windows.Forms.Button();
            this.btn_GetLocalServer = new System.Windows.Forms.Button();
            this.btn_SetLocalServer = new System.Windows.Forms.Button();
            this.btn_GetGPS = new System.Windows.Forms.Button();
            this.btn_SetVPNServer = new System.Windows.Forms.Button();
            this.btn_GetVPNServer = new System.Windows.Forms.Button();
            this.btn_SetMobileNetSetting = new System.Windows.Forms.Button();
            this.btn_GetMobileNetSetting = new System.Windows.Forms.Button();
            this.btn_SetWifiSetting = new System.Windows.Forms.Button();
            this.btn_GetWifiSetting = new System.Windows.Forms.Button();
            this.btn_SetEthernetSetting = new System.Windows.Forms.Button();
            this.btn_GetEthernetSetting = new System.Windows.Forms.Button();
            this.page_Advance = new System.Windows.Forms.TabPage();
            this.cbx_Restart = new System.Windows.Forms.CheckBox();
            this.lbl_SwipeIDCardCount = new System.Windows.Forms.Label();
            this.cbx_LivingMode = new System.Windows.Forms.CheckBox();
            this.tbx_SwipeIDCardCount = new System.Windows.Forms.TextBox();
            this.cbx_PowerKey = new System.Windows.Forms.CheckBox();
            this.cbx_ScreenSaver = new System.Windows.Forms.CheckBox();
            this.cbx_RealTimePhoto = new System.Windows.Forms.CheckBox();
            this.lbl_FirmwareAddress = new System.Windows.Forms.Label();
            this.lbl_SleepAfter = new System.Windows.Forms.Label();
            this.lbl_RestartTime = new System.Windows.Forms.Label();
            this.dtp_RestartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_RestoreAction = new System.Windows.Forms.Label();
            this.lbl_IdentifyMode = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.tbx_SleepAfter = new System.Windows.Forms.TextBox();
            this.tbx_FirmwareAddress = new System.Windows.Forms.TextBox();
            this.cobx_RestoreAction = new System.Windows.Forms.ComboBox();
            this.cobx_IdentifyMode = new System.Windows.Forms.ComboBox();
            this.cobx_Volume = new System.Windows.Forms.ComboBox();
            this.cobx_Language = new System.Windows.Forms.ComboBox();
            this.btn_FirmwareUpgradeByCloud = new System.Windows.Forms.Button();
            this.btn_RestoreDevice = new System.Windows.Forms.Button();
            this.btn_GetDeviceSetting = new System.Windows.Forms.Button();
            this.btn_SetDeviceSetting = new System.Windows.Forms.Button();
            this.btn_GetPowerSetting = new System.Windows.Forms.Button();
            this.btn_SetPowerSetting = new System.Windows.Forms.Button();
            this.page_Basic = new System.Windows.Forms.TabPage();
            this.lbl_NameListName = new System.Windows.Forms.Label();
            this.lbl_ListNo = new System.Windows.Forms.Label();
            this.tbx_NameListName = new System.Windows.Forms.TextBox();
            this.cobx_ListNo = new System.Windows.Forms.ComboBox();
            this.btn_GetNameList = new System.Windows.Forms.Button();
            this.btn_SetNameList = new System.Windows.Forms.Button();
            this.cobx_UTC = new System.Windows.Forms.ComboBox();
            this.cbx_UseProxy = new System.Windows.Forms.CheckBox();
            this.lbl_ProxyName = new System.Windows.Forms.Label();
            this.lbl_ProxyNo = new System.Windows.Forms.Label();
            this.lbl_DepartName = new System.Windows.Forms.Label();
            this.lbl_DeptNo = new System.Windows.Forms.Label();
            this.dtp_custTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_GetDeviceTime = new System.Windows.Forms.Label();
            this.lbl_EnableDevice = new System.Windows.Forms.Label();
            this.dgv_BellSetting = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cycle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtn_custmTime = new System.Windows.Forms.RadioButton();
            this.rbtn_sysTime = new System.Windows.Forms.RadioButton();
            this.tbx_DepartName = new System.Windows.Forms.TextBox();
            this.cobx_Depart_B = new System.Windows.Forms.ComboBox();
            this.tbx_ProxyName = new System.Windows.Forms.TextBox();
            this.cobx_ProxyNo = new System.Windows.Forms.ComboBox();
            this.btn_EnableDevice = new System.Windows.Forms.Button();
            this.btn_GetTime = new System.Windows.Forms.Button();
            this.btn_SetTime = new System.Windows.Forms.Button();
            this.btn_GetBellSetting = new System.Windows.Forms.Button();
            this.btn_SetBellSetting = new System.Windows.Forms.Button();
            this.btn_GetProxyName = new System.Windows.Forms.Button();
            this.btn_SetProxyName = new System.Windows.Forms.Button();
            this.btn_GetDepartment = new System.Windows.Forms.Button();
            this.btn_SetDepartment = new System.Windows.Forms.Button();
            this.page_User = new System.Windows.Forms.TabPage();
            this.btn_IdantifyCard = new System.Windows.Forms.Button();
            this.btn_SetUserSampleInfo = new System.Windows.Forms.Button();
            this.lbl_AllUserID = new System.Windows.Forms.Label();
            this.tbx_AllUserID = new System.Windows.Forms.TextBox();
            this.lbl_Set_Type = new System.Windows.Forms.Label();
            this.btn_GetAllUserID = new System.Windows.Forms.Button();
            this.tbx_antoSETcounts = new System.Windows.Forms.TextBox();
            this.btn_antoSET = new System.Windows.Forms.Button();
            this.btn_GetNextSampleInfo = new System.Windows.Forms.Button();
            this.cobx_userType = new System.Windows.Forms.ComboBox();
            this.btn_saveFaceData = new System.Windows.Forms.Button();
            this.lbl_QRCode = new System.Windows.Forms.Label();
            this.cobx_EnrollBackup = new System.Windows.Forms.ComboBox();
            this.lbl_FingerNo = new System.Windows.Forms.Label();
            this.cobx_FingerNo = new System.Windows.Forms.ComboBox();
            this.lbl_FaceData = new System.Windows.Forms.Label();
            this.lbl_FingerData = new System.Windows.Forms.Label();
            this.lbl_Fingers = new System.Windows.Forms.Label();
            this.lbl_PWD = new System.Windows.Forms.Label();
            this.lbl_Card = new System.Windows.Forms.Label();
            this.lbl_Depart = new System.Windows.Forms.Label();
            this.lbl_Privilege = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.pbx_UserQRCode = new System.Windows.Forms.PictureBox();
            this.cbx_Enabled = new System.Windows.Forms.CheckBox();
            this.pbx_UserPhoto = new System.Windows.Forms.PictureBox();
            this.cbx_FaceEnroll = new System.Windows.Forms.CheckBox();
            this.cobx_Depart_U = new System.Windows.Forms.ComboBox();
            this.cobx_Privilege = new System.Windows.Forms.ComboBox();
            this.dgv_FingerData = new System.Windows.Forms.DataGridView();
            this.FingerData_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FingerData_string = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Duress = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbx_FaceData = new System.Windows.Forms.TextBox();
            this.tbx_Fingers = new System.Windows.Forms.TextBox();
            this.tbx_PWD = new System.Windows.Forms.TextBox();
            this.tbx_Card = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_UserID = new System.Windows.Forms.TextBox();
            this.btn_GetUserQRcode = new System.Windows.Forms.Button();
            this.btn_SetUserQRcode = new System.Windows.Forms.Button();
            this.btn_TakeOffManager = new System.Windows.Forms.Button();
            this.btn_ExitRemoteEnroll = new System.Windows.Forms.Button();
            this.btn_RemoteEnroll = new System.Windows.Forms.Button();
            this.btn_SetUserFace = new System.Windows.Forms.Button();
            this.btn_GetUserFace = new System.Windows.Forms.Button();
            this.btn_SetUserFinger = new System.Windows.Forms.Button();
            this.btn_GetUserFinger = new System.Windows.Forms.Button();
            this.btn_SetUserPhoto = new System.Windows.Forms.Button();
            this.btn_GetUserPhoto = new System.Windows.Forms.Button();
            this.btn_GetUserCard = new System.Windows.Forms.Button();
            this.btn_GetUserPassword = new System.Windows.Forms.Button();
            this.btn_SetUserData = new System.Windows.Forms.Button();
            this.btn_GetUserData = new System.Windows.Forms.Button();
            this.btn_GetUserSampleInfo = new System.Windows.Forms.Button();
            this.btn_GetUserAllInfo = new System.Windows.Forms.Button();
            this.tbx_Response = new System.Windows.Forms.TextBox();
            this.tbx_Action_ext = new System.Windows.Forms.TextBox();
            this.tbx_Version = new System.Windows.Forms.TextBox();
            this.tbx_DeviceSerialNo = new System.Windows.Forms.TextBox();
            this.tbx_TerminalID = new System.Windows.Forms.TextBox();
            this.tbx_HardwareVer = new System.Windows.Forms.TextBox();
            this.tbx_TerminalType = new System.Windows.Forms.TextBox();
            this.tbx_Actid = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.TabControl();
            this.page_Info = new System.Windows.Forms.TabPage();
            this.lbl_HardwareVersion = new System.Windows.Forms.Label();
            this.lbl_FirmwareVersion = new System.Windows.Forms.Label();
            this.lbl_DeviceSerialNo = new System.Windows.Forms.Label();
            this.tbx_HardwareVer_info = new System.Windows.Forms.TextBox();
            this.tbx_FirmwareVersion_info = new System.Windows.Forms.TextBox();
            this.tbx_DeviceSerialNo_info = new System.Windows.Forms.TextBox();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ReleasedTime = new System.Windows.Forms.Label();
            this.tbx_Manufacturer = new System.Windows.Forms.TextBox();
            this.tbx_ProductName = new System.Windows.Forms.TextBox();
            this.tbx_ReleasedTime = new System.Windows.Forms.TextBox();
            this.lbl_PhotoLogCount = new System.Windows.Forms.Label();
            this.lbl_ManageLogCount = new System.Windows.Forms.Label();
            this.lbl_TimeLogCount = new System.Windows.Forms.Label();
            this.lbl_PwdCount = new System.Windows.Forms.Label();
            this.lbl_CardCount = new System.Windows.Forms.Label();
            this.lbl_FpCount = new System.Windows.Forms.Label();
            this.lbl_FaceCount = new System.Windows.Forms.Label();
            this.lbl_UserCount = new System.Windows.Forms.Label();
            this.lbl_ManagerCount = new System.Windows.Forms.Label();
            this.tbx_PhotoLogCount_s = new System.Windows.Forms.TextBox();
            this.tbx_PhotoLogCount_u = new System.Windows.Forms.TextBox();
            this.tbx_PhotoLogCount_t = new System.Windows.Forms.TextBox();
            this.tbx_ManageLogCount_s = new System.Windows.Forms.TextBox();
            this.tbx_ManageLogCount_u = new System.Windows.Forms.TextBox();
            this.tbx_ManageLogCount_t = new System.Windows.Forms.TextBox();
            this.tbx_TimeLogCount_s = new System.Windows.Forms.TextBox();
            this.tbx_TimeLogCount_u = new System.Windows.Forms.TextBox();
            this.tbx_TimeLogCount_t = new System.Windows.Forms.TextBox();
            this.tbx_PwdCount_u = new System.Windows.Forms.TextBox();
            this.tbx_PwdCount_t = new System.Windows.Forms.TextBox();
            this.tbx_CardCount_u = new System.Windows.Forms.TextBox();
            this.tbx_CardCount_t = new System.Windows.Forms.TextBox();
            this.tbx_FpCount_u = new System.Windows.Forms.TextBox();
            this.tbx_FpCount_t = new System.Windows.Forms.TextBox();
            this.tbx_FaceCount_u = new System.Windows.Forms.TextBox();
            this.tbx_FaceCount_t = new System.Windows.Forms.TextBox();
            this.tbx_UserCount_u = new System.Windows.Forms.TextBox();
            this.tbx_UserCount_t = new System.Windows.Forms.TextBox();
            this.tbx_ManagerCount_u = new System.Windows.Forms.TextBox();
            this.tbx_ManagerCount_t = new System.Windows.Forms.TextBox();
            this.lbl_TotalStore = new System.Windows.Forms.Label();
            this.lbl_UseStore = new System.Windows.Forms.Label();
            this.lbl_UnSendStore = new System.Windows.Forms.Label();
            this.btn_GetStoreStatus = new System.Windows.Forms.Button();
            this.btn_GetDeviceInfo = new System.Windows.Forms.Button();
            this.tbx_MessageFormDevice = new System.Windows.Forms.TextBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OFD_SelectUserPhoto = new System.Windows.Forms.OpenFileDialog();
            this.SFD_saveFingerData = new System.Windows.Forms.SaveFileDialog();
            this.OFD_SelectFingerData = new System.Windows.Forms.OpenFileDialog();
            this.btn_GetIdantifyCard = new System.Windows.Forms.Button();
            this.btn_SetIdantifyCard = new System.Windows.Forms.Button();
            this.lbl_IDValidDate = new System.Windows.Forms.Label();
            this.tbx_IDValidDate = new System.Windows.Forms.TextBox();
            this.lbl_IDAuthority = new System.Windows.Forms.Label();
            this.tbx_IDAuthority = new System.Windows.Forms.TextBox();
            this.pbx_IDPhoto = new System.Windows.Forms.PictureBox();
            this.lbl_IDAddress = new System.Windows.Forms.Label();
            this.lbl_IDBirthday = new System.Windows.Forms.Label();
            this.lbl_IDNation = new System.Windows.Forms.Label();
            this.lbl_IDGender = new System.Windows.Forms.Label();
            this.lbl_IDName = new System.Windows.Forms.Label();
            this.lbl_IDUserID = new System.Windows.Forms.Label();
            this.cobx_IDGender = new System.Windows.Forms.ComboBox();
            this.tbx_IDAddress = new System.Windows.Forms.TextBox();
            this.tbx_IDBirthday = new System.Windows.Forms.TextBox();
            this.tbx_IDNation = new System.Windows.Forms.TextBox();
            this.tbx_IDName = new System.Windows.Forms.TextBox();
            this.tbx_IDUserID = new System.Windows.Forms.TextBox();
            this.pbx_TakePhoto = new System.Windows.Forms.PictureBox();
            this.btn_TakePhoto = new System.Windows.Forms.Button();
            this.cobx_Camera = new System.Windows.Forms.ComboBox();
            this.page_Access.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccessList)).BeginInit();
            this.page_Att.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceRule)).BeginInit();
            this.page_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_realtimePhoto_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttandanceLog)).BeginInit();
            this.page_Net.SuspendLayout();
            this.page_Advance.SuspendLayout();
            this.page_Basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BellSetting)).BeginInit();
            this.page_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FingerData)).BeginInit();
            this.page.SuspendLayout();
            this.page_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_IDPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TakePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SendToDevice
            // 
            this.btn_SendToDevice.Location = new System.Drawing.Point(755, 265);
            this.btn_SendToDevice.Name = "btn_SendToDevice";
            this.btn_SendToDevice.Size = new System.Drawing.Size(75, 23);
            this.btn_SendToDevice.TabIndex = 1;
            this.btn_SendToDevice.Text = "send";
            this.btn_SendToDevice.UseVisualStyleBackColor = true;
            this.btn_SendToDevice.Click += new System.EventHandler(this.btn_SendToDevice_Click);
            // 
            // tbx_MessageFormServer
            // 
            this.tbx_MessageFormServer.Location = new System.Drawing.Point(565, 59);
            this.tbx_MessageFormServer.Multiline = true;
            this.tbx_MessageFormServer.Name = "tbx_MessageFormServer";
            this.tbx_MessageFormServer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_MessageFormServer.Size = new System.Drawing.Size(308, 200);
            this.tbx_MessageFormServer.TabIndex = 0;
            // 
            // page_Access
            // 
            this.page_Access.Controls.Add(this.lbl_CloudID);
            this.page_Access.Controls.Add(this.tbt_CloudID);
            this.page_Access.Controls.Add(this.lbl_operatorID);
            this.page_Access.Controls.Add(this.tbx_operatorID);
            this.page_Access.Controls.Add(this.lbl_DeleteAccessListNo);
            this.page_Access.Controls.Add(this.cobx_AccessListAction);
            this.page_Access.Controls.Add(this.tbx_DeleteAccessListNo);
            this.page_Access.Controls.Add(this.btn_AddAccessList);
            this.page_Access.Controls.Add(this.dgv_AccessList);
            this.page_Access.Controls.Add(this.label5);
            this.page_Access.Controls.Add(this.label4);
            this.page_Access.Controls.Add(this.lbl_end);
            this.page_Access.Controls.Add(this.lbl_start);
            this.page_Access.Controls.Add(this.btn_SetAccessSettingSimple);
            this.page_Access.Controls.Add(this.btn_GetAccessSettingSimple);
            this.page_Access.Controls.Add(this.lbl_WGOutputContent);
            this.page_Access.Controls.Add(this.lbl_WGOutputFormat);
            this.page_Access.Controls.Add(this.lbl_DoorSensorType);
            this.page_Access.Controls.Add(this.lbl_DoorOpenTimeout);
            this.page_Access.Controls.Add(this.lbl_Week);
            this.page_Access.Controls.Add(this.lbl_PassTime);
            this.page_Access.Controls.Add(this.lbl_VerifyPassLockReleaseTime);
            this.page_Access.Controls.Add(this.lbl_LockReleaseTime);
            this.page_Access.Controls.Add(this.cobx_WGOutputContent);
            this.page_Access.Controls.Add(this.cobx_WGOutputFormat);
            this.page_Access.Controls.Add(this.cbx_BlackListAlarm);
            this.page_Access.Controls.Add(this.cbx_TamperAlarm);
            this.page_Access.Controls.Add(this.cbx_LinkageAlarm);
            this.page_Access.Controls.Add(this.cbx_DuressAlarm);
            this.page_Access.Controls.Add(this.cobx_DoorSensorType);
            this.page_Access.Controls.Add(this.tbx_DoorOpenTimeout);
            this.page_Access.Controls.Add(this.cobx_endWeek);
            this.page_Access.Controls.Add(this.cobx_startWeek);
            this.page_Access.Controls.Add(this.cbx_AllWeek);
            this.page_Access.Controls.Add(this.dtp_endPassTime);
            this.page_Access.Controls.Add(this.dtp_startPassTime);
            this.page_Access.Controls.Add(this.tbx_VerifyPassLockReleaseTime);
            this.page_Access.Controls.Add(this.cobx_LockReleaseTime);
            this.page_Access.Controls.Add(this.lbl_AlarmStatus);
            this.page_Access.Controls.Add(this.lbl_DoorSensoStatus);
            this.page_Access.Controls.Add(this.lbl_LockReleaseStatus);
            this.page_Access.Controls.Add(this.cobx_AlarmStatus);
            this.page_Access.Controls.Add(this.cobx_DoorSensoStatus);
            this.page_Access.Controls.Add(this.cobx_LockReleaseStatus);
            this.page_Access.Controls.Add(this.btn_SetAccessList);
            this.page_Access.Controls.Add(this.btn_GetAccessList);
            this.page_Access.Controls.Add(this.btn_SetAccessSetting);
            this.page_Access.Controls.Add(this.btn_GetAccessSetting);
            this.page_Access.Controls.Add(this.btn_AccessStatus);
            this.page_Access.Controls.Add(this.btn_RemoteOpen);
            this.page_Access.Location = new System.Drawing.Point(4, 22);
            this.page_Access.Name = "page_Access";
            this.page_Access.Padding = new System.Windows.Forms.Padding(3);
            this.page_Access.Size = new System.Drawing.Size(533, 655);
            this.page_Access.TabIndex = 6;
            this.page_Access.Text = "Access";
            this.page_Access.UseVisualStyleBackColor = true;
            // 
            // lbl_CloudID
            // 
            this.lbl_CloudID.AutoSize = true;
            this.lbl_CloudID.Location = new System.Drawing.Point(384, 73);
            this.lbl_CloudID.Name = "lbl_CloudID";
            this.lbl_CloudID.Size = new System.Drawing.Size(53, 12);
            this.lbl_CloudID.TabIndex = 83;
            this.lbl_CloudID.Text = "CloudID:";
            // 
            // tbt_CloudID
            // 
            this.tbt_CloudID.Location = new System.Drawing.Point(443, 70);
            this.tbt_CloudID.Name = "tbt_CloudID";
            this.tbt_CloudID.Size = new System.Drawing.Size(79, 21);
            this.tbt_CloudID.TabIndex = 82;
            this.tbt_CloudID.Text = "0";
            // 
            // lbl_operatorID
            // 
            this.lbl_operatorID.AutoSize = true;
            this.lbl_operatorID.Location = new System.Drawing.Point(198, 70);
            this.lbl_operatorID.Name = "lbl_operatorID";
            this.lbl_operatorID.Size = new System.Drawing.Size(71, 12);
            this.lbl_operatorID.TabIndex = 81;
            this.lbl_operatorID.Text = "OperatorID:";
            // 
            // tbx_operatorID
            // 
            this.tbx_operatorID.Location = new System.Drawing.Point(275, 67);
            this.tbx_operatorID.Name = "tbx_operatorID";
            this.tbx_operatorID.Size = new System.Drawing.Size(79, 21);
            this.tbx_operatorID.TabIndex = 80;
            this.tbx_operatorID.Text = "0";
            // 
            // lbl_DeleteAccessListNo
            // 
            this.lbl_DeleteAccessListNo.AutoSize = true;
            this.lbl_DeleteAccessListNo.Location = new System.Drawing.Point(180, 399);
            this.lbl_DeleteAccessListNo.Name = "lbl_DeleteAccessListNo";
            this.lbl_DeleteAccessListNo.Size = new System.Drawing.Size(59, 12);
            this.lbl_DeleteAccessListNo.TabIndex = 79;
            this.lbl_DeleteAccessListNo.Text = "DeleteNo:";
            // 
            // cobx_AccessListAction
            // 
            this.cobx_AccessListAction.FormattingEnabled = true;
            this.cobx_AccessListAction.Location = new System.Drawing.Point(186, 365);
            this.cobx_AccessListAction.Name = "cobx_AccessListAction";
            this.cobx_AccessListAction.Size = new System.Drawing.Size(99, 20);
            this.cobx_AccessListAction.TabIndex = 77;
            // 
            // tbx_DeleteAccessListNo
            // 
            this.tbx_DeleteAccessListNo.Location = new System.Drawing.Point(244, 394);
            this.tbx_DeleteAccessListNo.Name = "tbx_DeleteAccessListNo";
            this.tbx_DeleteAccessListNo.Size = new System.Drawing.Size(41, 21);
            this.tbx_DeleteAccessListNo.TabIndex = 76;
            // 
            // btn_AddAccessList
            // 
            this.btn_AddAccessList.Location = new System.Drawing.Point(406, 394);
            this.btn_AddAccessList.Name = "btn_AddAccessList";
            this.btn_AddAccessList.Size = new System.Drawing.Size(116, 23);
            this.btn_AddAccessList.TabIndex = 75;
            this.btn_AddAccessList.Text = "AddAccessList";
            this.btn_AddAccessList.UseVisualStyleBackColor = true;
            this.btn_AddAccessList.Click += new System.EventHandler(this.btn_AddAccessList_Click);
            // 
            // dgv_AccessList
            // 
            this.dgv_AccessList.AllowUserToAddRows = false;
            this.dgv_AccessList.AllowUserToDeleteRows = false;
            this.dgv_AccessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessID,
            this.AccessUse,
            this.AccessDerp,
            this.AccessPass,
            this.AccessAllWeek,
            this.AccessStartWeek,
            this.AccessEndWeek,
            this.AccessAllTime,
            this.AccessStartTime,
            this.AccessEndTime});
            this.dgv_AccessList.Location = new System.Drawing.Point(6, 423);
            this.dgv_AccessList.Name = "dgv_AccessList";
            this.dgv_AccessList.RowTemplate.Height = 23;
            this.dgv_AccessList.Size = new System.Drawing.Size(516, 217);
            this.dgv_AccessList.TabIndex = 74;
            // 
            // AccessID
            // 
            this.AccessID.HeaderText = "编号";
            this.AccessID.Name = "AccessID";
            this.AccessID.Width = 40;
            // 
            // AccessUse
            // 
            this.AccessUse.HeaderText = "使用";
            this.AccessUse.Name = "AccessUse";
            this.AccessUse.Width = 40;
            // 
            // AccessDerp
            // 
            this.AccessDerp.HeaderText = "名单";
            this.AccessDerp.Name = "AccessDerp";
            this.AccessDerp.Width = 40;
            // 
            // AccessPass
            // 
            this.AccessPass.HeaderText = "通行";
            this.AccessPass.Name = "AccessPass";
            this.AccessPass.Width = 50;
            // 
            // AccessAllWeek
            // 
            this.AccessAllWeek.HeaderText = "星期永久";
            this.AccessAllWeek.Name = "AccessAllWeek";
            this.AccessAllWeek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessAllWeek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccessAllWeek.Width = 40;
            // 
            // AccessStartWeek
            // 
            this.AccessStartWeek.HeaderText = "开始星期";
            this.AccessStartWeek.Name = "AccessStartWeek";
            this.AccessStartWeek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessStartWeek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccessStartWeek.Width = 80;
            // 
            // AccessEndWeek
            // 
            this.AccessEndWeek.HeaderText = "结束星期";
            this.AccessEndWeek.Name = "AccessEndWeek";
            this.AccessEndWeek.Width = 80;
            // 
            // AccessAllTime
            // 
            this.AccessAllTime.HeaderText = "时段永久";
            this.AccessAllTime.Name = "AccessAllTime";
            this.AccessAllTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessAllTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccessAllTime.Width = 40;
            // 
            // AccessStartTime
            // 
            this.AccessStartTime.HeaderText = "开始时段";
            this.AccessStartTime.Name = "AccessStartTime";
            this.AccessStartTime.Width = 110;
            // 
            // AccessEndTime
            // 
            this.AccessEndTime.HeaderText = "结束时段";
            this.AccessEndTime.Name = "AccessEndTime";
            this.AccessEndTime.Width = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 73;
            this.label5.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 72;
            this.label4.Text = "--";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(422, 103);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(23, 12);
            this.lbl_end.TabIndex = 71;
            this.lbl_end.Text = "End";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(303, 103);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(35, 12);
            this.lbl_start.TabIndex = 70;
            this.lbl_start.Text = "Start";
            // 
            // btn_SetAccessSettingSimple
            // 
            this.btn_SetAccessSettingSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SetAccessSettingSimple.Location = new System.Drawing.Point(6, 233);
            this.btn_SetAccessSettingSimple.Name = "btn_SetAccessSettingSimple";
            this.btn_SetAccessSettingSimple.Size = new System.Drawing.Size(150, 23);
            this.btn_SetAccessSettingSimple.TabIndex = 69;
            this.btn_SetAccessSettingSimple.Text = "SetAccessSettingSimple";
            this.btn_SetAccessSettingSimple.UseVisualStyleBackColor = false;
            // 
            // btn_GetAccessSettingSimple
            // 
            this.btn_GetAccessSettingSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_GetAccessSettingSimple.Location = new System.Drawing.Point(6, 204);
            this.btn_GetAccessSettingSimple.Name = "btn_GetAccessSettingSimple";
            this.btn_GetAccessSettingSimple.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAccessSettingSimple.TabIndex = 68;
            this.btn_GetAccessSettingSimple.Text = "GetAccessSettingSimple";
            this.btn_GetAccessSettingSimple.UseVisualStyleBackColor = false;
            // 
            // lbl_WGOutputContent
            // 
            this.lbl_WGOutputContent.AutoSize = true;
            this.lbl_WGOutputContent.Location = new System.Drawing.Point(324, 233);
            this.lbl_WGOutputContent.Name = "lbl_WGOutputContent";
            this.lbl_WGOutputContent.Size = new System.Drawing.Size(101, 12);
            this.lbl_WGOutputContent.TabIndex = 67;
            this.lbl_WGOutputContent.Text = "WGOutputContent:";
            // 
            // lbl_WGOutputFormat
            // 
            this.lbl_WGOutputFormat.AutoSize = true;
            this.lbl_WGOutputFormat.Location = new System.Drawing.Point(174, 234);
            this.lbl_WGOutputFormat.Name = "lbl_WGOutputFormat";
            this.lbl_WGOutputFormat.Size = new System.Drawing.Size(95, 12);
            this.lbl_WGOutputFormat.TabIndex = 66;
            this.lbl_WGOutputFormat.Text = "WGOutputFormat:";
            // 
            // lbl_DoorSensorType
            // 
            this.lbl_DoorSensorType.AutoSize = true;
            this.lbl_DoorSensorType.Location = new System.Drawing.Point(330, 288);
            this.lbl_DoorSensorType.Name = "lbl_DoorSensorType";
            this.lbl_DoorSensorType.Size = new System.Drawing.Size(95, 12);
            this.lbl_DoorSensorType.TabIndex = 65;
            this.lbl_DoorSensorType.Text = "DoorSensorType:";
            // 
            // lbl_DoorOpenTimeout
            // 
            this.lbl_DoorOpenTimeout.AutoSize = true;
            this.lbl_DoorOpenTimeout.Location = new System.Drawing.Point(168, 316);
            this.lbl_DoorOpenTimeout.Name = "lbl_DoorOpenTimeout";
            this.lbl_DoorOpenTimeout.Size = new System.Drawing.Size(101, 12);
            this.lbl_DoorOpenTimeout.TabIndex = 64;
            this.lbl_DoorOpenTimeout.Text = "DoorOpenTimeout:";
            // 
            // lbl_Week
            // 
            this.lbl_Week.AutoSize = true;
            this.lbl_Week.Location = new System.Drawing.Point(263, 150);
            this.lbl_Week.Name = "lbl_Week";
            this.lbl_Week.Size = new System.Drawing.Size(35, 12);
            this.lbl_Week.TabIndex = 63;
            this.lbl_Week.Text = "Week:";
            // 
            // lbl_PassTime
            // 
            this.lbl_PassTime.AutoSize = true;
            this.lbl_PassTime.Location = new System.Drawing.Point(240, 120);
            this.lbl_PassTime.Name = "lbl_PassTime";
            this.lbl_PassTime.Size = new System.Drawing.Size(59, 12);
            this.lbl_PassTime.TabIndex = 62;
            this.lbl_PassTime.Text = "PassTime:";
            // 
            // lbl_VerifyPassLockReleaseTime
            // 
            this.lbl_VerifyPassLockReleaseTime.AutoSize = true;
            this.lbl_VerifyPassLockReleaseTime.Location = new System.Drawing.Point(108, 287);
            this.lbl_VerifyPassLockReleaseTime.Name = "lbl_VerifyPassLockReleaseTime";
            this.lbl_VerifyPassLockReleaseTime.Size = new System.Drawing.Size(161, 12);
            this.lbl_VerifyPassLockReleaseTime.TabIndex = 61;
            this.lbl_VerifyPassLockReleaseTime.Text = "VerifyPassLockReleaseTime:";
            // 
            // lbl_LockReleaseTime
            // 
            this.lbl_LockReleaseTime.AutoSize = true;
            this.lbl_LockReleaseTime.Location = new System.Drawing.Point(168, 262);
            this.lbl_LockReleaseTime.Name = "lbl_LockReleaseTime";
            this.lbl_LockReleaseTime.Size = new System.Drawing.Size(101, 12);
            this.lbl_LockReleaseTime.TabIndex = 60;
            this.lbl_LockReleaseTime.Text = "LockReleaseTime:";
            // 
            // cobx_WGOutputContent
            // 
            this.cobx_WGOutputContent.FormattingEnabled = true;
            this.cobx_WGOutputContent.Location = new System.Drawing.Point(431, 230);
            this.cobx_WGOutputContent.Name = "cobx_WGOutputContent";
            this.cobx_WGOutputContent.Size = new System.Drawing.Size(91, 20);
            this.cobx_WGOutputContent.TabIndex = 59;
            // 
            // cobx_WGOutputFormat
            // 
            this.cobx_WGOutputFormat.FormattingEnabled = true;
            this.cobx_WGOutputFormat.Location = new System.Drawing.Point(275, 231);
            this.cobx_WGOutputFormat.Name = "cobx_WGOutputFormat";
            this.cobx_WGOutputFormat.Size = new System.Drawing.Size(43, 20);
            this.cobx_WGOutputFormat.TabIndex = 58;
            // 
            // cbx_BlackListAlarm
            // 
            this.cbx_BlackListAlarm.AutoSize = true;
            this.cbx_BlackListAlarm.Location = new System.Drawing.Point(415, 174);
            this.cbx_BlackListAlarm.Name = "cbx_BlackListAlarm";
            this.cbx_BlackListAlarm.Size = new System.Drawing.Size(108, 16);
            this.cbx_BlackListAlarm.TabIndex = 57;
            this.cbx_BlackListAlarm.Text = "BlackListAlarm";
            this.cbx_BlackListAlarm.UseVisualStyleBackColor = true;
            // 
            // cbx_TamperAlarm
            // 
            this.cbx_TamperAlarm.AutoSize = true;
            this.cbx_TamperAlarm.Location = new System.Drawing.Point(192, 203);
            this.cbx_TamperAlarm.Name = "cbx_TamperAlarm";
            this.cbx_TamperAlarm.Size = new System.Drawing.Size(90, 16);
            this.cbx_TamperAlarm.TabIndex = 56;
            this.cbx_TamperAlarm.Text = "TamperAlarm";
            this.cbx_TamperAlarm.UseVisualStyleBackColor = true;
            // 
            // cbx_LinkageAlarm
            // 
            this.cbx_LinkageAlarm.AutoSize = true;
            this.cbx_LinkageAlarm.Location = new System.Drawing.Point(305, 174);
            this.cbx_LinkageAlarm.Name = "cbx_LinkageAlarm";
            this.cbx_LinkageAlarm.Size = new System.Drawing.Size(96, 16);
            this.cbx_LinkageAlarm.TabIndex = 55;
            this.cbx_LinkageAlarm.Text = "LinkageAlarm";
            this.cbx_LinkageAlarm.UseVisualStyleBackColor = true;
            // 
            // cbx_DuressAlarm
            // 
            this.cbx_DuressAlarm.AutoSize = true;
            this.cbx_DuressAlarm.Location = new System.Drawing.Point(192, 174);
            this.cbx_DuressAlarm.Name = "cbx_DuressAlarm";
            this.cbx_DuressAlarm.Size = new System.Drawing.Size(90, 16);
            this.cbx_DuressAlarm.TabIndex = 54;
            this.cbx_DuressAlarm.Text = "DuressAlarm";
            this.cbx_DuressAlarm.UseVisualStyleBackColor = true;
            // 
            // cobx_DoorSensorType
            // 
            this.cobx_DoorSensorType.FormattingEnabled = true;
            this.cobx_DoorSensorType.Location = new System.Drawing.Point(432, 283);
            this.cobx_DoorSensorType.Name = "cobx_DoorSensorType";
            this.cobx_DoorSensorType.Size = new System.Drawing.Size(90, 20);
            this.cobx_DoorSensorType.TabIndex = 53;
            // 
            // tbx_DoorOpenTimeout
            // 
            this.tbx_DoorOpenTimeout.Location = new System.Drawing.Point(275, 312);
            this.tbx_DoorOpenTimeout.Name = "tbx_DoorOpenTimeout";
            this.tbx_DoorOpenTimeout.Size = new System.Drawing.Size(43, 21);
            this.tbx_DoorOpenTimeout.TabIndex = 52;
            this.tbx_DoorOpenTimeout.Text = "20";
            // 
            // cobx_endWeek
            // 
            this.cobx_endWeek.FormattingEnabled = true;
            this.cobx_endWeek.Location = new System.Drawing.Point(423, 148);
            this.cobx_endWeek.Name = "cobx_endWeek";
            this.cobx_endWeek.Size = new System.Drawing.Size(100, 20);
            this.cobx_endWeek.TabIndex = 51;
            // 
            // cobx_startWeek
            // 
            this.cobx_startWeek.FormattingEnabled = true;
            this.cobx_startWeek.Location = new System.Drawing.Point(304, 147);
            this.cobx_startWeek.Name = "cobx_startWeek";
            this.cobx_startWeek.Size = new System.Drawing.Size(100, 20);
            this.cobx_startWeek.TabIndex = 50;
            // 
            // cbx_AllWeek
            // 
            this.cbx_AllWeek.AutoSize = true;
            this.cbx_AllWeek.Checked = true;
            this.cbx_AllWeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_AllWeek.Location = new System.Drawing.Point(192, 148);
            this.cbx_AllWeek.Name = "cbx_AllWeek";
            this.cbx_AllWeek.Size = new System.Drawing.Size(66, 16);
            this.cbx_AllWeek.TabIndex = 49;
            this.cbx_AllWeek.Text = "AllWeek";
            this.cbx_AllWeek.UseVisualStyleBackColor = true;
            this.cbx_AllWeek.CheckedChanged += new System.EventHandler(this.cbx_AllWeek_CheckedChanged);
            // 
            // dtp_endPassTime
            // 
            this.dtp_endPassTime.Location = new System.Drawing.Point(424, 118);
            this.dtp_endPassTime.Name = "dtp_endPassTime";
            this.dtp_endPassTime.Size = new System.Drawing.Size(99, 21);
            this.dtp_endPassTime.TabIndex = 48;
            // 
            // dtp_startPassTime
            // 
            this.dtp_startPassTime.Location = new System.Drawing.Point(305, 120);
            this.dtp_startPassTime.Name = "dtp_startPassTime";
            this.dtp_startPassTime.Size = new System.Drawing.Size(100, 21);
            this.dtp_startPassTime.TabIndex = 47;
            // 
            // tbx_VerifyPassLockReleaseTime
            // 
            this.tbx_VerifyPassLockReleaseTime.Location = new System.Drawing.Point(274, 285);
            this.tbx_VerifyPassLockReleaseTime.Name = "tbx_VerifyPassLockReleaseTime";
            this.tbx_VerifyPassLockReleaseTime.Size = new System.Drawing.Size(44, 21);
            this.tbx_VerifyPassLockReleaseTime.TabIndex = 46;
            this.tbx_VerifyPassLockReleaseTime.Text = "5";
            // 
            // cobx_LockReleaseTime
            // 
            this.cobx_LockReleaseTime.FormattingEnabled = true;
            this.cobx_LockReleaseTime.Location = new System.Drawing.Point(275, 257);
            this.cobx_LockReleaseTime.Name = "cobx_LockReleaseTime";
            this.cobx_LockReleaseTime.Size = new System.Drawing.Size(247, 20);
            this.cobx_LockReleaseTime.TabIndex = 45;
            // 
            // lbl_AlarmStatus
            // 
            this.lbl_AlarmStatus.AutoSize = true;
            this.lbl_AlarmStatus.Location = new System.Drawing.Point(360, 21);
            this.lbl_AlarmStatus.Name = "lbl_AlarmStatus";
            this.lbl_AlarmStatus.Size = new System.Drawing.Size(77, 12);
            this.lbl_AlarmStatus.TabIndex = 44;
            this.lbl_AlarmStatus.Text = "AlarmStatus:";
            // 
            // lbl_DoorSensoStatus
            // 
            this.lbl_DoorSensoStatus.AutoSize = true;
            this.lbl_DoorSensoStatus.Location = new System.Drawing.Point(168, 42);
            this.lbl_DoorSensoStatus.Name = "lbl_DoorSensoStatus";
            this.lbl_DoorSensoStatus.Size = new System.Drawing.Size(101, 12);
            this.lbl_DoorSensoStatus.TabIndex = 43;
            this.lbl_DoorSensoStatus.Text = "DoorSensoStatus:";
            // 
            // lbl_LockReleaseStatus
            // 
            this.lbl_LockReleaseStatus.AutoSize = true;
            this.lbl_LockReleaseStatus.Location = new System.Drawing.Point(156, 19);
            this.lbl_LockReleaseStatus.Name = "lbl_LockReleaseStatus";
            this.lbl_LockReleaseStatus.Size = new System.Drawing.Size(113, 12);
            this.lbl_LockReleaseStatus.TabIndex = 42;
            this.lbl_LockReleaseStatus.Text = "LockReleaseStatus:";
            // 
            // cobx_AlarmStatus
            // 
            this.cobx_AlarmStatus.FormattingEnabled = true;
            this.cobx_AlarmStatus.Location = new System.Drawing.Point(443, 16);
            this.cobx_AlarmStatus.Name = "cobx_AlarmStatus";
            this.cobx_AlarmStatus.Size = new System.Drawing.Size(79, 20);
            this.cobx_AlarmStatus.TabIndex = 41;
            // 
            // cobx_DoorSensoStatus
            // 
            this.cobx_DoorSensoStatus.FormattingEnabled = true;
            this.cobx_DoorSensoStatus.Location = new System.Drawing.Point(275, 39);
            this.cobx_DoorSensoStatus.Name = "cobx_DoorSensoStatus";
            this.cobx_DoorSensoStatus.Size = new System.Drawing.Size(79, 20);
            this.cobx_DoorSensoStatus.TabIndex = 40;
            // 
            // cobx_LockReleaseStatus
            // 
            this.cobx_LockReleaseStatus.FormattingEnabled = true;
            this.cobx_LockReleaseStatus.Location = new System.Drawing.Point(275, 16);
            this.cobx_LockReleaseStatus.Name = "cobx_LockReleaseStatus";
            this.cobx_LockReleaseStatus.Size = new System.Drawing.Size(79, 20);
            this.cobx_LockReleaseStatus.TabIndex = 39;
            // 
            // btn_SetAccessList
            // 
            this.btn_SetAccessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetAccessList.Location = new System.Drawing.Point(6, 394);
            this.btn_SetAccessList.Name = "btn_SetAccessList";
            this.btn_SetAccessList.Size = new System.Drawing.Size(150, 23);
            this.btn_SetAccessList.TabIndex = 38;
            this.btn_SetAccessList.Text = "SetAccessList";
            this.btn_SetAccessList.UseVisualStyleBackColor = false;
            this.btn_SetAccessList.Click += new System.EventHandler(this.btn_SetAccessList_Click);
            // 
            // btn_GetAccessList
            // 
            this.btn_GetAccessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetAccessList.Location = new System.Drawing.Point(6, 365);
            this.btn_GetAccessList.Name = "btn_GetAccessList";
            this.btn_GetAccessList.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAccessList.TabIndex = 37;
            this.btn_GetAccessList.Text = "GetAccessList";
            this.btn_GetAccessList.UseVisualStyleBackColor = false;
            this.btn_GetAccessList.Click += new System.EventHandler(this.btn_GetAccessList_Click);
            // 
            // btn_SetAccessSetting
            // 
            this.btn_SetAccessSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetAccessSetting.Location = new System.Drawing.Point(6, 135);
            this.btn_SetAccessSetting.Name = "btn_SetAccessSetting";
            this.btn_SetAccessSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetAccessSetting.TabIndex = 35;
            this.btn_SetAccessSetting.Text = "SetAccessSetting";
            this.btn_SetAccessSetting.UseVisualStyleBackColor = false;
            this.btn_SetAccessSetting.Click += new System.EventHandler(this.btn_SetAccessSetting_Click);
            // 
            // btn_GetAccessSetting
            // 
            this.btn_GetAccessSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetAccessSetting.Location = new System.Drawing.Point(6, 106);
            this.btn_GetAccessSetting.Name = "btn_GetAccessSetting";
            this.btn_GetAccessSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAccessSetting.TabIndex = 34;
            this.btn_GetAccessSetting.Text = "GetAccessSetting";
            this.btn_GetAccessSetting.UseVisualStyleBackColor = false;
            this.btn_GetAccessSetting.Click += new System.EventHandler(this.btn_GetAccessSetting_Click);
            // 
            // btn_AccessStatus
            // 
            this.btn_AccessStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AccessStatus.Location = new System.Drawing.Point(6, 16);
            this.btn_AccessStatus.Name = "btn_AccessStatus";
            this.btn_AccessStatus.Size = new System.Drawing.Size(150, 23);
            this.btn_AccessStatus.TabIndex = 33;
            this.btn_AccessStatus.Text = "AccessStatus";
            this.btn_AccessStatus.UseVisualStyleBackColor = false;
            this.btn_AccessStatus.Click += new System.EventHandler(this.btn_AccessStatus_Click);
            // 
            // btn_RemoteOpen
            // 
            this.btn_RemoteOpen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_RemoteOpen.Location = new System.Drawing.Point(6, 65);
            this.btn_RemoteOpen.Name = "btn_RemoteOpen";
            this.btn_RemoteOpen.Size = new System.Drawing.Size(150, 23);
            this.btn_RemoteOpen.TabIndex = 32;
            this.btn_RemoteOpen.Text = "RemoteOpen";
            this.btn_RemoteOpen.UseVisualStyleBackColor = false;
            this.btn_RemoteOpen.Click += new System.EventHandler(this.btn_RemoteOpen_Click);
            // 
            // page_Att
            // 
            this.page_Att.Controls.Add(this.dgv_AttendanceRule);
            this.page_Att.Controls.Add(this.btn_SetAttendanceRule);
            this.page_Att.Controls.Add(this.btn_GetAttendanceRule);
            this.page_Att.Location = new System.Drawing.Point(4, 22);
            this.page_Att.Name = "page_Att";
            this.page_Att.Padding = new System.Windows.Forms.Padding(3);
            this.page_Att.Size = new System.Drawing.Size(533, 655);
            this.page_Att.TabIndex = 5;
            this.page_Att.Text = "Attandance";
            this.page_Att.UseVisualStyleBackColor = true;
            // 
            // dgv_AttendanceRule
            // 
            this.dgv_AttendanceRule.AllowUserToAddRows = false;
            this.dgv_AttendanceRule.AllowUserToDeleteRows = false;
            this.dgv_AttendanceRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AttendanceRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.startTime,
            this.endTime,
            this.status});
            this.dgv_AttendanceRule.Location = new System.Drawing.Point(162, 16);
            this.dgv_AttendanceRule.Name = "dgv_AttendanceRule";
            this.dgv_AttendanceRule.RowTemplate.Height = 23;
            this.dgv_AttendanceRule.Size = new System.Drawing.Size(365, 302);
            this.dgv_AttendanceRule.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "StartTime";
            this.startTime.Name = "startTime";
            this.startTime.Width = 80;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "EndTime";
            this.endTime.Name = "endTime";
            this.endTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endTime.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_SetAttendanceRule
            // 
            this.btn_SetAttendanceRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetAttendanceRule.Location = new System.Drawing.Point(6, 45);
            this.btn_SetAttendanceRule.Name = "btn_SetAttendanceRule";
            this.btn_SetAttendanceRule.Size = new System.Drawing.Size(150, 23);
            this.btn_SetAttendanceRule.TabIndex = 32;
            this.btn_SetAttendanceRule.Text = "SetAttendanceRule";
            this.btn_SetAttendanceRule.UseVisualStyleBackColor = false;
            this.btn_SetAttendanceRule.Click += new System.EventHandler(this.btn_SetAttendanceRule_Click);
            // 
            // btn_GetAttendanceRule
            // 
            this.btn_GetAttendanceRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetAttendanceRule.Location = new System.Drawing.Point(6, 16);
            this.btn_GetAttendanceRule.Name = "btn_GetAttendanceRule";
            this.btn_GetAttendanceRule.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAttendanceRule.TabIndex = 31;
            this.btn_GetAttendanceRule.Text = "GetAttendanceRule";
            this.btn_GetAttendanceRule.UseVisualStyleBackColor = false;
            this.btn_GetAttendanceRule.Click += new System.EventHandler(this.btn_GetAttendanceRule_Click);
            // 
            // page_Data
            // 
            this.page_Data.Controls.Add(this.label1);
            this.page_Data.Controls.Add(this.lbl_BeginLogPos);
            this.page_Data.Controls.Add(this.tbx_BeginLogPos);
            this.page_Data.Controls.Add(this.lbl_EndTime);
            this.page_Data.Controls.Add(this.lbl_StartTime);
            this.page_Data.Controls.Add(this.lbl_UserID_dataPage);
            this.page_Data.Controls.Add(this.tbx_UserID_dataPage);
            this.page_Data.Controls.Add(this.dtp_StartTime);
            this.page_Data.Controls.Add(this.pbx_realtimePhoto_Data);
            this.page_Data.Controls.Add(this.rbtn_CustomLog);
            this.page_Data.Controls.Add(this.rbtn_RealTimeLog);
            this.page_Data.Controls.Add(this.lbl_ReVerifyTime);
            this.page_Data.Controls.Add(this.lbl_ManagerLogWarning);
            this.page_Data.Controls.Add(this.lbl_AttLogWarning);
            this.page_Data.Controls.Add(this.cbx_Compulsion);
            this.page_Data.Controls.Add(this.tbx_ReVerifyTime);
            this.page_Data.Controls.Add(this.tbx_ManagerLogWarning);
            this.page_Data.Controls.Add(this.tbx_AttLogWarning);
            this.page_Data.Controls.Add(this.dtp_EndTime);
            this.page_Data.Controls.Add(this.dgv_AttandanceLog);
            this.page_Data.Controls.Add(this.btn_GetLogSetting);
            this.page_Data.Controls.Add(this.btn_SetLogSetting);
            this.page_Data.Controls.Add(this.btn_GetNextAttLog);
            this.page_Data.Controls.Add(this.btn_GetFirstAttLog);
            this.page_Data.Controls.Add(this.btn_GetAttendanceLog);
            this.page_Data.Controls.Add(this.btn_EmptyAllData);
            this.page_Data.Controls.Add(this.btn_EmptyUserEnrollmentData);
            this.page_Data.Controls.Add(this.btn_EmptyManageLog);
            this.page_Data.Controls.Add(this.btn_EmptyTimeLog);
            this.page_Data.Location = new System.Drawing.Point(4, 22);
            this.page_Data.Name = "page_Data";
            this.page_Data.Padding = new System.Windows.Forms.Padding(3);
            this.page_Data.Size = new System.Drawing.Size(533, 655);
            this.page_Data.TabIndex = 4;
            this.page_Data.Text = "Data";
            this.page_Data.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "选择获取记录的模式：";
            // 
            // lbl_BeginLogPos
            // 
            this.lbl_BeginLogPos.AutoSize = true;
            this.lbl_BeginLogPos.Location = new System.Drawing.Point(367, 260);
            this.lbl_BeginLogPos.Name = "lbl_BeginLogPos";
            this.lbl_BeginLogPos.Size = new System.Drawing.Size(77, 12);
            this.lbl_BeginLogPos.TabIndex = 57;
            this.lbl_BeginLogPos.Text = "BeginLogPos:";
            // 
            // tbx_BeginLogPos
            // 
            this.tbx_BeginLogPos.Location = new System.Drawing.Point(450, 257);
            this.tbx_BeginLogPos.Name = "tbx_BeginLogPos";
            this.tbx_BeginLogPos.ReadOnly = true;
            this.tbx_BeginLogPos.Size = new System.Drawing.Size(77, 21);
            this.tbx_BeginLogPos.TabIndex = 56;
            this.tbx_BeginLogPos.Text = "0";
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Location = new System.Drawing.Point(224, 315);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(53, 12);
            this.lbl_EndTime.TabIndex = 53;
            this.lbl_EndTime.Text = "EndTime:";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Location = new System.Drawing.Point(212, 290);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(65, 12);
            this.lbl_StartTime.TabIndex = 52;
            this.lbl_StartTime.Text = "StartTime:";
            // 
            // lbl_UserID_dataPage
            // 
            this.lbl_UserID_dataPage.AutoSize = true;
            this.lbl_UserID_dataPage.Location = new System.Drawing.Point(230, 265);
            this.lbl_UserID_dataPage.Name = "lbl_UserID_dataPage";
            this.lbl_UserID_dataPage.Size = new System.Drawing.Size(47, 12);
            this.lbl_UserID_dataPage.TabIndex = 51;
            this.lbl_UserID_dataPage.Text = "UserID:";
            // 
            // tbx_UserID_dataPage
            // 
            this.tbx_UserID_dataPage.Location = new System.Drawing.Point(283, 257);
            this.tbx_UserID_dataPage.Name = "tbx_UserID_dataPage";
            this.tbx_UserID_dataPage.Size = new System.Drawing.Size(78, 21);
            this.tbx_UserID_dataPage.TabIndex = 43;
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.Location = new System.Drawing.Point(283, 284);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(174, 21);
            this.dtp_StartTime.TabIndex = 41;
            // 
            // pbx_realtimePhoto_Data
            // 
            this.pbx_realtimePhoto_Data.InitialImage = null;
            this.pbx_realtimePhoto_Data.Location = new System.Drawing.Point(408, 20);
            this.pbx_realtimePhoto_Data.Name = "pbx_realtimePhoto_Data";
            this.pbx_realtimePhoto_Data.Size = new System.Drawing.Size(110, 148);
            this.pbx_realtimePhoto_Data.TabIndex = 58;
            this.pbx_realtimePhoto_Data.TabStop = false;
            // 
            // rbtn_CustomLog
            // 
            this.rbtn_CustomLog.AutoSize = true;
            this.rbtn_CustomLog.Checked = true;
            this.rbtn_CustomLog.Location = new System.Drawing.Point(190, 233);
            this.rbtn_CustomLog.Name = "rbtn_CustomLog";
            this.rbtn_CustomLog.Size = new System.Drawing.Size(77, 16);
            this.rbtn_CustomLog.TabIndex = 55;
            this.rbtn_CustomLog.TabStop = true;
            this.rbtn_CustomLog.Text = "CustomLog";
            this.rbtn_CustomLog.UseVisualStyleBackColor = true;
            this.rbtn_CustomLog.CheckedChanged += new System.EventHandler(this.rbtn_CustomLog_CheckedChanged);
            // 
            // rbtn_RealTimeLog
            // 
            this.rbtn_RealTimeLog.AutoSize = true;
            this.rbtn_RealTimeLog.Location = new System.Drawing.Point(283, 233);
            this.rbtn_RealTimeLog.Name = "rbtn_RealTimeLog";
            this.rbtn_RealTimeLog.Size = new System.Drawing.Size(89, 16);
            this.rbtn_RealTimeLog.TabIndex = 54;
            this.rbtn_RealTimeLog.Text = "RealTimeLog";
            this.rbtn_RealTimeLog.UseVisualStyleBackColor = true;
            this.rbtn_RealTimeLog.CheckedChanged += new System.EventHandler(this.rbtn_RealTimeLog_CheckedChanged);
            // 
            // lbl_ReVerifyTime
            // 
            this.lbl_ReVerifyTime.AutoSize = true;
            this.lbl_ReVerifyTime.Location = new System.Drawing.Point(194, 172);
            this.lbl_ReVerifyTime.Name = "lbl_ReVerifyTime";
            this.lbl_ReVerifyTime.Size = new System.Drawing.Size(83, 12);
            this.lbl_ReVerifyTime.TabIndex = 50;
            this.lbl_ReVerifyTime.Text = "ReVerifyTime:";
            // 
            // lbl_ManagerLogWarning
            // 
            this.lbl_ManagerLogWarning.AutoSize = true;
            this.lbl_ManagerLogWarning.Location = new System.Drawing.Point(164, 149);
            this.lbl_ManagerLogWarning.Name = "lbl_ManagerLogWarning";
            this.lbl_ManagerLogWarning.Size = new System.Drawing.Size(113, 12);
            this.lbl_ManagerLogWarning.TabIndex = 49;
            this.lbl_ManagerLogWarning.Text = "ManagerLogWarning:";
            // 
            // lbl_AttLogWarning
            // 
            this.lbl_AttLogWarning.AutoSize = true;
            this.lbl_AttLogWarning.Location = new System.Drawing.Point(188, 124);
            this.lbl_AttLogWarning.Name = "lbl_AttLogWarning";
            this.lbl_AttLogWarning.Size = new System.Drawing.Size(89, 12);
            this.lbl_AttLogWarning.TabIndex = 48;
            this.lbl_AttLogWarning.Text = "AttLogWarning:";
            // 
            // cbx_Compulsion
            // 
            this.cbx_Compulsion.AutoSize = true;
            this.cbx_Compulsion.Location = new System.Drawing.Point(192, 20);
            this.cbx_Compulsion.Name = "cbx_Compulsion";
            this.cbx_Compulsion.Size = new System.Drawing.Size(84, 16);
            this.cbx_Compulsion.TabIndex = 47;
            this.cbx_Compulsion.Text = "Compulsion";
            this.cbx_Compulsion.UseVisualStyleBackColor = true;
            // 
            // tbx_ReVerifyTime
            // 
            this.tbx_ReVerifyTime.Location = new System.Drawing.Point(283, 171);
            this.tbx_ReVerifyTime.Name = "tbx_ReVerifyTime";
            this.tbx_ReVerifyTime.Size = new System.Drawing.Size(100, 21);
            this.tbx_ReVerifyTime.TabIndex = 46;
            // 
            // tbx_ManagerLogWarning
            // 
            this.tbx_ManagerLogWarning.Location = new System.Drawing.Point(283, 146);
            this.tbx_ManagerLogWarning.Name = "tbx_ManagerLogWarning";
            this.tbx_ManagerLogWarning.Size = new System.Drawing.Size(100, 21);
            this.tbx_ManagerLogWarning.TabIndex = 45;
            // 
            // tbx_AttLogWarning
            // 
            this.tbx_AttLogWarning.Location = new System.Drawing.Point(283, 118);
            this.tbx_AttLogWarning.Name = "tbx_AttLogWarning";
            this.tbx_AttLogWarning.Size = new System.Drawing.Size(100, 21);
            this.tbx_AttLogWarning.TabIndex = 44;
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.Location = new System.Drawing.Point(283, 312);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(174, 21);
            this.dtp_EndTime.TabIndex = 42;
            // 
            // dgv_AttandanceLog
            // 
            this.dgv_AttandanceLog.AllowUserToAddRows = false;
            this.dgv_AttandanceLog.AllowUserToDeleteRows = false;
            this.dgv_AttandanceLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AttandanceLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.LogTime,
            this.LogUserID,
            this.LogAction,
            this.LogAttendStat,
            this.LogAPStat,
            this.LogJobCode,
            this.LogPhoto});
            this.dgv_AttandanceLog.Location = new System.Drawing.Point(6, 342);
            this.dgv_AttandanceLog.Name = "dgv_AttandanceLog";
            this.dgv_AttandanceLog.ReadOnly = true;
            this.dgv_AttandanceLog.RowTemplate.Height = 23;
            this.dgv_AttandanceLog.Size = new System.Drawing.Size(521, 284);
            this.dgv_AttandanceLog.TabIndex = 40;
            // 
            // LogID
            // 
            this.LogID.HeaderText = "No";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            this.LogID.Width = 40;
            // 
            // LogTime
            // 
            this.LogTime.HeaderText = "Time";
            this.LogTime.Name = "LogTime";
            this.LogTime.ReadOnly = true;
            this.LogTime.Width = 90;
            // 
            // LogUserID
            // 
            this.LogUserID.HeaderText = "UserID";
            this.LogUserID.Name = "LogUserID";
            this.LogUserID.ReadOnly = true;
            this.LogUserID.Width = 60;
            // 
            // LogAction
            // 
            this.LogAction.HeaderText = "Action";
            this.LogAction.Name = "LogAction";
            this.LogAction.ReadOnly = true;
            this.LogAction.Width = 55;
            // 
            // LogAttendStat
            // 
            this.LogAttendStat.HeaderText = "AttendStat";
            this.LogAttendStat.Name = "LogAttendStat";
            this.LogAttendStat.ReadOnly = true;
            this.LogAttendStat.Width = 55;
            // 
            // LogAPStat
            // 
            this.LogAPStat.HeaderText = "APStat";
            this.LogAPStat.Name = "LogAPStat";
            this.LogAPStat.ReadOnly = true;
            this.LogAPStat.Width = 40;
            // 
            // LogJobCode
            // 
            this.LogJobCode.HeaderText = "JobCode";
            this.LogJobCode.Name = "LogJobCode";
            this.LogJobCode.ReadOnly = true;
            this.LogJobCode.Width = 40;
            // 
            // LogPhoto
            // 
            this.LogPhoto.HeaderText = "Photo";
            this.LogPhoto.Name = "LogPhoto";
            this.LogPhoto.ReadOnly = true;
            this.LogPhoto.Width = 80;
            // 
            // btn_GetLogSetting
            // 
            this.btn_GetLogSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetLogSetting.Location = new System.Drawing.Point(6, 140);
            this.btn_GetLogSetting.Name = "btn_GetLogSetting";
            this.btn_GetLogSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetLogSetting.TabIndex = 39;
            this.btn_GetLogSetting.Text = "GetLogSetting";
            this.btn_GetLogSetting.UseVisualStyleBackColor = false;
            this.btn_GetLogSetting.Click += new System.EventHandler(this.btn_GetLogSetting_Click);
            // 
            // btn_SetLogSetting
            // 
            this.btn_SetLogSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetLogSetting.Location = new System.Drawing.Point(6, 169);
            this.btn_SetLogSetting.Name = "btn_SetLogSetting";
            this.btn_SetLogSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetLogSetting.TabIndex = 37;
            this.btn_SetLogSetting.Text = "SetLogSetting";
            this.btn_SetLogSetting.UseVisualStyleBackColor = false;
            this.btn_SetLogSetting.Click += new System.EventHandler(this.btn_SetLogSetting_Click);
            // 
            // btn_GetNextAttLog
            // 
            this.btn_GetNextAttLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetNextAttLog.Location = new System.Drawing.Point(6, 284);
            this.btn_GetNextAttLog.Name = "btn_GetNextAttLog";
            this.btn_GetNextAttLog.Size = new System.Drawing.Size(150, 23);
            this.btn_GetNextAttLog.TabIndex = 36;
            this.btn_GetNextAttLog.Text = "GetNextAttLog";
            this.btn_GetNextAttLog.UseVisualStyleBackColor = false;
            this.btn_GetNextAttLog.Click += new System.EventHandler(this.btn_GetNextAttLog_Click);
            // 
            // btn_GetFirstAttLog
            // 
            this.btn_GetFirstAttLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetFirstAttLog.Location = new System.Drawing.Point(6, 255);
            this.btn_GetFirstAttLog.Name = "btn_GetFirstAttLog";
            this.btn_GetFirstAttLog.Size = new System.Drawing.Size(150, 23);
            this.btn_GetFirstAttLog.TabIndex = 35;
            this.btn_GetFirstAttLog.Text = "GetFirstAttLog";
            this.btn_GetFirstAttLog.UseVisualStyleBackColor = false;
            this.btn_GetFirstAttLog.Click += new System.EventHandler(this.btn_GetFirstAttLog_Click);
            // 
            // btn_GetAttendanceLog
            // 
            this.btn_GetAttendanceLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetAttendanceLog.Location = new System.Drawing.Point(6, 313);
            this.btn_GetAttendanceLog.Name = "btn_GetAttendanceLog";
            this.btn_GetAttendanceLog.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAttendanceLog.TabIndex = 34;
            this.btn_GetAttendanceLog.Text = "GetAttendanceLog";
            this.btn_GetAttendanceLog.UseVisualStyleBackColor = false;
            this.btn_GetAttendanceLog.Click += new System.EventHandler(this.btn_GetAttendanceLog_Click);
            // 
            // btn_EmptyAllData
            // 
            this.btn_EmptyAllData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EmptyAllData.Location = new System.Drawing.Point(6, 103);
            this.btn_EmptyAllData.Name = "btn_EmptyAllData";
            this.btn_EmptyAllData.Size = new System.Drawing.Size(150, 23);
            this.btn_EmptyAllData.TabIndex = 33;
            this.btn_EmptyAllData.Text = "EmptyAllData";
            this.btn_EmptyAllData.UseVisualStyleBackColor = false;
            this.btn_EmptyAllData.Click += new System.EventHandler(this.btn_EmptyAllData_Click);
            // 
            // btn_EmptyUserEnrollmentData
            // 
            this.btn_EmptyUserEnrollmentData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EmptyUserEnrollmentData.Location = new System.Drawing.Point(6, 74);
            this.btn_EmptyUserEnrollmentData.Name = "btn_EmptyUserEnrollmentData";
            this.btn_EmptyUserEnrollmentData.Size = new System.Drawing.Size(150, 23);
            this.btn_EmptyUserEnrollmentData.TabIndex = 32;
            this.btn_EmptyUserEnrollmentData.Text = "EmptyUserEnrollmentData";
            this.btn_EmptyUserEnrollmentData.UseVisualStyleBackColor = false;
            this.btn_EmptyUserEnrollmentData.Click += new System.EventHandler(this.btn_EmptyUserEnrollmentData_Click);
            // 
            // btn_EmptyManageLog
            // 
            this.btn_EmptyManageLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EmptyManageLog.Location = new System.Drawing.Point(6, 45);
            this.btn_EmptyManageLog.Name = "btn_EmptyManageLog";
            this.btn_EmptyManageLog.Size = new System.Drawing.Size(150, 23);
            this.btn_EmptyManageLog.TabIndex = 31;
            this.btn_EmptyManageLog.Text = "EmptyManageLog";
            this.btn_EmptyManageLog.UseVisualStyleBackColor = false;
            this.btn_EmptyManageLog.Click += new System.EventHandler(this.btn_EmptyManageLog_Click);
            // 
            // btn_EmptyTimeLog
            // 
            this.btn_EmptyTimeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EmptyTimeLog.Location = new System.Drawing.Point(6, 16);
            this.btn_EmptyTimeLog.Name = "btn_EmptyTimeLog";
            this.btn_EmptyTimeLog.Size = new System.Drawing.Size(150, 23);
            this.btn_EmptyTimeLog.TabIndex = 30;
            this.btn_EmptyTimeLog.Text = "EmptyTimeLog";
            this.btn_EmptyTimeLog.UseVisualStyleBackColor = false;
            this.btn_EmptyTimeLog.Click += new System.EventHandler(this.btn_EmptyTimeLog_Click);
            // 
            // page_Net
            // 
            this.page_Net.Controls.Add(this.lbl_TerminalPort);
            this.page_Net.Controls.Add(this.lbl_TerminalPassword);
            this.page_Net.Controls.Add(this.lbl_TerminalID);
            this.page_Net.Controls.Add(this.lbl_StreamingAddress);
            this.page_Net.Controls.Add(this.lbl_CloudAddress);
            this.page_Net.Controls.Add(this.lbl_Latitude);
            this.page_Net.Controls.Add(this.lbl_Longitude);
            this.page_Net.Controls.Add(this.lbl_SatelliteCount);
            this.page_Net.Controls.Add(this.lbl_VPNPwd);
            this.page_Net.Controls.Add(this.lbl_VPNAddress);
            this.page_Net.Controls.Add(this.lbl_VPNAccount);
            this.page_Net.Controls.Add(this.lbl_WIFIpwd);
            this.page_Net.Controls.Add(this.lbl_SSID);
            this.page_Net.Controls.Add(this.lbl_DHCPGateway);
            this.page_Net.Controls.Add(this.lbl_DHCPSubnet);
            this.page_Net.Controls.Add(this.lbl_DHCPIP);
            this.page_Net.Controls.Add(this.lbl_NetGateway);
            this.page_Net.Controls.Add(this.lbl_NetSubnet);
            this.page_Net.Controls.Add(this.lbl_NetIP);
            this.page_Net.Controls.Add(this.tbx_TerminalPort);
            this.page_Net.Controls.Add(this.tbx_TerminalPassword);
            this.page_Net.Controls.Add(this.tbx_TerminalID_n);
            this.page_Net.Controls.Add(this.tbx_StreamingAddress);
            this.page_Net.Controls.Add(this.cbx_UseGPS);
            this.page_Net.Controls.Add(this.tbx_SatelliteCount);
            this.page_Net.Controls.Add(this.tbx_Latitude);
            this.page_Net.Controls.Add(this.tbx_Longitude);
            this.page_Net.Controls.Add(this.cbx_GPSAlive);
            this.page_Net.Controls.Add(this.lbl_VPNIP);
            this.page_Net.Controls.Add(this.tbx_VPNPwd);
            this.page_Net.Controls.Add(this.tbx_VPNAccount);
            this.page_Net.Controls.Add(this.tbx_VPNAddress);
            this.page_Net.Controls.Add(this.lbl_Operator);
            this.page_Net.Controls.Add(this.lbl_MobileIP);
            this.page_Net.Controls.Add(this.cbx_UseMobileNet);
            this.page_Net.Controls.Add(this.tbx_Key);
            this.page_Net.Controls.Add(this.tbx_SSID);
            this.page_Net.Controls.Add(this.cbx_useWIFI);
            this.page_Net.Controls.Add(this.tbx_DHCPGateway);
            this.page_Net.Controls.Add(this.tbx_DHCPSubnet);
            this.page_Net.Controls.Add(this.tbx_DHCPIP);
            this.page_Net.Controls.Add(this.tbx_NetGateway);
            this.page_Net.Controls.Add(this.tbx_NetSubnet);
            this.page_Net.Controls.Add(this.tbx_NetIP);
            this.page_Net.Controls.Add(this.lbl_MAC);
            this.page_Net.Controls.Add(this.cbx_DHCP);
            this.page_Net.Controls.Add(this.btn_SetGPS);
            this.page_Net.Controls.Add(this.tbx_CloudAddress);
            this.page_Net.Controls.Add(this.btn_SetStreamingServer);
            this.page_Net.Controls.Add(this.btn_GetStreamingServer);
            this.page_Net.Controls.Add(this.btn_SetCloudServer);
            this.page_Net.Controls.Add(this.btn_GetCloudServer);
            this.page_Net.Controls.Add(this.btn_GetLocalServer);
            this.page_Net.Controls.Add(this.btn_SetLocalServer);
            this.page_Net.Controls.Add(this.btn_GetGPS);
            this.page_Net.Controls.Add(this.btn_SetVPNServer);
            this.page_Net.Controls.Add(this.btn_GetVPNServer);
            this.page_Net.Controls.Add(this.btn_SetMobileNetSetting);
            this.page_Net.Controls.Add(this.btn_GetMobileNetSetting);
            this.page_Net.Controls.Add(this.btn_SetWifiSetting);
            this.page_Net.Controls.Add(this.btn_GetWifiSetting);
            this.page_Net.Controls.Add(this.btn_SetEthernetSetting);
            this.page_Net.Controls.Add(this.btn_GetEthernetSetting);
            this.page_Net.Location = new System.Drawing.Point(4, 22);
            this.page_Net.Name = "page_Net";
            this.page_Net.Padding = new System.Windows.Forms.Padding(3);
            this.page_Net.Size = new System.Drawing.Size(533, 655);
            this.page_Net.TabIndex = 3;
            this.page_Net.Text = "Network";
            this.page_Net.UseVisualStyleBackColor = true;
            // 
            // lbl_TerminalPort
            // 
            this.lbl_TerminalPort.AutoSize = true;
            this.lbl_TerminalPort.Location = new System.Drawing.Point(178, 574);
            this.lbl_TerminalPort.Name = "lbl_TerminalPort";
            this.lbl_TerminalPort.Size = new System.Drawing.Size(83, 12);
            this.lbl_TerminalPort.TabIndex = 123;
            this.lbl_TerminalPort.Text = "TerminalPort:";
            // 
            // lbl_TerminalPassword
            // 
            this.lbl_TerminalPassword.AutoSize = true;
            this.lbl_TerminalPassword.Location = new System.Drawing.Point(370, 547);
            this.lbl_TerminalPassword.Name = "lbl_TerminalPassword";
            this.lbl_TerminalPassword.Size = new System.Drawing.Size(59, 12);
            this.lbl_TerminalPassword.TabIndex = 122;
            this.lbl_TerminalPassword.Text = "Password:";
            // 
            // lbl_TerminalID
            // 
            this.lbl_TerminalID.AutoSize = true;
            this.lbl_TerminalID.Location = new System.Drawing.Point(188, 547);
            this.lbl_TerminalID.Name = "lbl_TerminalID";
            this.lbl_TerminalID.Size = new System.Drawing.Size(71, 12);
            this.lbl_TerminalID.TabIndex = 121;
            this.lbl_TerminalID.Text = "TerminalID:";
            // 
            // lbl_StreamingAddress
            // 
            this.lbl_StreamingAddress.AutoSize = true;
            this.lbl_StreamingAddress.Location = new System.Drawing.Point(174, 513);
            this.lbl_StreamingAddress.Name = "lbl_StreamingAddress";
            this.lbl_StreamingAddress.Size = new System.Drawing.Size(53, 12);
            this.lbl_StreamingAddress.TabIndex = 120;
            this.lbl_StreamingAddress.Text = "Address:";
            // 
            // lbl_CloudAddress
            // 
            this.lbl_CloudAddress.AutoSize = true;
            this.lbl_CloudAddress.Location = new System.Drawing.Point(170, 451);
            this.lbl_CloudAddress.Name = "lbl_CloudAddress";
            this.lbl_CloudAddress.Size = new System.Drawing.Size(53, 12);
            this.lbl_CloudAddress.TabIndex = 119;
            this.lbl_CloudAddress.Text = "Address:";
            // 
            // lbl_Latitude
            // 
            this.lbl_Latitude.AutoSize = true;
            this.lbl_Latitude.Location = new System.Drawing.Point(352, 372);
            this.lbl_Latitude.Name = "lbl_Latitude";
            this.lbl_Latitude.Size = new System.Drawing.Size(59, 12);
            this.lbl_Latitude.TabIndex = 118;
            this.lbl_Latitude.Text = "Latitude:";
            // 
            // lbl_Longitude
            // 
            this.lbl_Longitude.AutoSize = true;
            this.lbl_Longitude.Location = new System.Drawing.Point(162, 372);
            this.lbl_Longitude.Name = "lbl_Longitude";
            this.lbl_Longitude.Size = new System.Drawing.Size(65, 12);
            this.lbl_Longitude.TabIndex = 117;
            this.lbl_Longitude.Text = "Longitude:";
            // 
            // lbl_SatelliteCount
            // 
            this.lbl_SatelliteCount.AutoSize = true;
            this.lbl_SatelliteCount.Location = new System.Drawing.Point(316, 345);
            this.lbl_SatelliteCount.Name = "lbl_SatelliteCount";
            this.lbl_SatelliteCount.Size = new System.Drawing.Size(95, 12);
            this.lbl_SatelliteCount.TabIndex = 116;
            this.lbl_SatelliteCount.Text = "SatelliteCount:";
            // 
            // lbl_VPNPwd
            // 
            this.lbl_VPNPwd.AutoSize = true;
            this.lbl_VPNPwd.Location = new System.Drawing.Point(168, 300);
            this.lbl_VPNPwd.Name = "lbl_VPNPwd";
            this.lbl_VPNPwd.Size = new System.Drawing.Size(59, 12);
            this.lbl_VPNPwd.TabIndex = 115;
            this.lbl_VPNPwd.Text = "Password:";
            // 
            // lbl_VPNAddress
            // 
            this.lbl_VPNAddress.AutoSize = true;
            this.lbl_VPNAddress.Location = new System.Drawing.Point(363, 266);
            this.lbl_VPNAddress.Name = "lbl_VPNAddress";
            this.lbl_VPNAddress.Size = new System.Drawing.Size(53, 12);
            this.lbl_VPNAddress.TabIndex = 114;
            this.lbl_VPNAddress.Text = "Address:";
            // 
            // lbl_VPNAccount
            // 
            this.lbl_VPNAccount.AutoSize = true;
            this.lbl_VPNAccount.Location = new System.Drawing.Point(170, 269);
            this.lbl_VPNAccount.Name = "lbl_VPNAccount";
            this.lbl_VPNAccount.Size = new System.Drawing.Size(53, 12);
            this.lbl_VPNAccount.TabIndex = 113;
            this.lbl_VPNAccount.Text = "Account:";
            // 
            // lbl_WIFIpwd
            // 
            this.lbl_WIFIpwd.AutoSize = true;
            this.lbl_WIFIpwd.Location = new System.Drawing.Point(385, 150);
            this.lbl_WIFIpwd.Name = "lbl_WIFIpwd";
            this.lbl_WIFIpwd.Size = new System.Drawing.Size(29, 12);
            this.lbl_WIFIpwd.TabIndex = 112;
            this.lbl_WIFIpwd.Text = "Key:";
            // 
            // lbl_SSID
            // 
            this.lbl_SSID.AutoSize = true;
            this.lbl_SSID.Location = new System.Drawing.Point(188, 150);
            this.lbl_SSID.Name = "lbl_SSID";
            this.lbl_SSID.Size = new System.Drawing.Size(35, 12);
            this.lbl_SSID.TabIndex = 111;
            this.lbl_SSID.Text = "SSID:";
            // 
            // lbl_DHCPGateway
            // 
            this.lbl_DHCPGateway.AutoSize = true;
            this.lbl_DHCPGateway.Location = new System.Drawing.Point(331, 101);
            this.lbl_DHCPGateway.Name = "lbl_DHCPGateway";
            this.lbl_DHCPGateway.Size = new System.Drawing.Size(83, 12);
            this.lbl_DHCPGateway.TabIndex = 110;
            this.lbl_DHCPGateway.Text = "DHCP Gateway:";
            // 
            // lbl_DHCPSubnet
            // 
            this.lbl_DHCPSubnet.AutoSize = true;
            this.lbl_DHCPSubnet.Location = new System.Drawing.Point(337, 73);
            this.lbl_DHCPSubnet.Name = "lbl_DHCPSubnet";
            this.lbl_DHCPSubnet.Size = new System.Drawing.Size(77, 12);
            this.lbl_DHCPSubnet.TabIndex = 109;
            this.lbl_DHCPSubnet.Text = "DHCP Subnet:";
            // 
            // lbl_DHCPIP
            // 
            this.lbl_DHCPIP.AutoSize = true;
            this.lbl_DHCPIP.Location = new System.Drawing.Point(361, 49);
            this.lbl_DHCPIP.Name = "lbl_DHCPIP";
            this.lbl_DHCPIP.Size = new System.Drawing.Size(53, 12);
            this.lbl_DHCPIP.TabIndex = 108;
            this.lbl_DHCPIP.Text = "DHCP IP:";
            // 
            // lbl_NetGateway
            // 
            this.lbl_NetGateway.AutoSize = true;
            this.lbl_NetGateway.Location = new System.Drawing.Point(170, 101);
            this.lbl_NetGateway.Name = "lbl_NetGateway";
            this.lbl_NetGateway.Size = new System.Drawing.Size(53, 12);
            this.lbl_NetGateway.TabIndex = 107;
            this.lbl_NetGateway.Text = "Gateway:";
            // 
            // lbl_NetSubnet
            // 
            this.lbl_NetSubnet.AutoSize = true;
            this.lbl_NetSubnet.Location = new System.Drawing.Point(182, 73);
            this.lbl_NetSubnet.Name = "lbl_NetSubnet";
            this.lbl_NetSubnet.Size = new System.Drawing.Size(47, 12);
            this.lbl_NetSubnet.TabIndex = 106;
            this.lbl_NetSubnet.Text = "Subnet:";
            // 
            // lbl_NetIP
            // 
            this.lbl_NetIP.AutoSize = true;
            this.lbl_NetIP.Location = new System.Drawing.Point(200, 47);
            this.lbl_NetIP.Name = "lbl_NetIP";
            this.lbl_NetIP.Size = new System.Drawing.Size(23, 12);
            this.lbl_NetIP.TabIndex = 105;
            this.lbl_NetIP.Text = "IP:";
            // 
            // tbx_TerminalPort
            // 
            this.tbx_TerminalPort.Location = new System.Drawing.Point(267, 571);
            this.tbx_TerminalPort.Name = "tbx_TerminalPort";
            this.tbx_TerminalPort.Size = new System.Drawing.Size(97, 21);
            this.tbx_TerminalPort.TabIndex = 104;
            this.tbx_TerminalPort.Text = "5505";
            // 
            // tbx_TerminalPassword
            // 
            this.tbx_TerminalPassword.Location = new System.Drawing.Point(435, 544);
            this.tbx_TerminalPassword.Name = "tbx_TerminalPassword";
            this.tbx_TerminalPassword.Size = new System.Drawing.Size(82, 21);
            this.tbx_TerminalPassword.TabIndex = 103;
            this.tbx_TerminalPassword.Text = "0";
            // 
            // tbx_TerminalID_n
            // 
            this.tbx_TerminalID_n.Location = new System.Drawing.Point(267, 544);
            this.tbx_TerminalID_n.Name = "tbx_TerminalID_n";
            this.tbx_TerminalID_n.Size = new System.Drawing.Size(97, 21);
            this.tbx_TerminalID_n.TabIndex = 102;
            this.tbx_TerminalID_n.Text = "1";
            // 
            // tbx_StreamingAddress
            // 
            this.tbx_StreamingAddress.Location = new System.Drawing.Point(229, 508);
            this.tbx_StreamingAddress.Name = "tbx_StreamingAddress";
            this.tbx_StreamingAddress.Size = new System.Drawing.Size(289, 21);
            this.tbx_StreamingAddress.TabIndex = 101;
            // 
            // cbx_UseGPS
            // 
            this.cbx_UseGPS.AutoSize = true;
            this.cbx_UseGPS.Location = new System.Drawing.Point(228, 325);
            this.cbx_UseGPS.Name = "cbx_UseGPS";
            this.cbx_UseGPS.Size = new System.Drawing.Size(66, 16);
            this.cbx_UseGPS.TabIndex = 100;
            this.cbx_UseGPS.Text = "USE GPS";
            this.cbx_UseGPS.UseVisualStyleBackColor = true;
            this.cbx_UseGPS.CheckedChanged += new System.EventHandler(this.cbx_UseGPS_CheckedChanged);
            // 
            // tbx_SatelliteCount
            // 
            this.tbx_SatelliteCount.Location = new System.Drawing.Point(417, 342);
            this.tbx_SatelliteCount.Name = "tbx_SatelliteCount";
            this.tbx_SatelliteCount.ReadOnly = true;
            this.tbx_SatelliteCount.Size = new System.Drawing.Size(100, 21);
            this.tbx_SatelliteCount.TabIndex = 99;
            // 
            // tbx_Latitude
            // 
            this.tbx_Latitude.Location = new System.Drawing.Point(417, 369);
            this.tbx_Latitude.Name = "tbx_Latitude";
            this.tbx_Latitude.ReadOnly = true;
            this.tbx_Latitude.Size = new System.Drawing.Size(100, 21);
            this.tbx_Latitude.TabIndex = 98;
            // 
            // tbx_Longitude
            // 
            this.tbx_Longitude.Location = new System.Drawing.Point(229, 369);
            this.tbx_Longitude.Name = "tbx_Longitude";
            this.tbx_Longitude.ReadOnly = true;
            this.tbx_Longitude.Size = new System.Drawing.Size(100, 21);
            this.tbx_Longitude.TabIndex = 97;
            // 
            // cbx_GPSAlive
            // 
            this.cbx_GPSAlive.AutoSize = true;
            this.cbx_GPSAlive.Location = new System.Drawing.Point(228, 347);
            this.cbx_GPSAlive.Name = "cbx_GPSAlive";
            this.cbx_GPSAlive.Size = new System.Drawing.Size(72, 16);
            this.cbx_GPSAlive.TabIndex = 96;
            this.cbx_GPSAlive.Text = "GPSAlive";
            this.cbx_GPSAlive.UseVisualStyleBackColor = true;
            // 
            // lbl_VPNIP
            // 
            this.lbl_VPNIP.AutoSize = true;
            this.lbl_VPNIP.Location = new System.Drawing.Point(415, 292);
            this.lbl_VPNIP.Name = "lbl_VPNIP";
            this.lbl_VPNIP.Size = new System.Drawing.Size(0, 12);
            this.lbl_VPNIP.TabIndex = 95;
            // 
            // tbx_VPNPwd
            // 
            this.tbx_VPNPwd.Location = new System.Drawing.Point(229, 292);
            this.tbx_VPNPwd.Name = "tbx_VPNPwd";
            this.tbx_VPNPwd.Size = new System.Drawing.Size(100, 21);
            this.tbx_VPNPwd.TabIndex = 94;
            // 
            // tbx_VPNAccount
            // 
            this.tbx_VPNAccount.Location = new System.Drawing.Point(229, 266);
            this.tbx_VPNAccount.Name = "tbx_VPNAccount";
            this.tbx_VPNAccount.Size = new System.Drawing.Size(100, 21);
            this.tbx_VPNAccount.TabIndex = 93;
            // 
            // tbx_VPNAddress
            // 
            this.tbx_VPNAddress.Location = new System.Drawing.Point(417, 264);
            this.tbx_VPNAddress.Name = "tbx_VPNAddress";
            this.tbx_VPNAddress.Size = new System.Drawing.Size(100, 21);
            this.tbx_VPNAddress.TabIndex = 92;
            // 
            // lbl_Operator
            // 
            this.lbl_Operator.AutoSize = true;
            this.lbl_Operator.Location = new System.Drawing.Point(379, 192);
            this.lbl_Operator.Name = "lbl_Operator";
            this.lbl_Operator.Size = new System.Drawing.Size(0, 12);
            this.lbl_Operator.TabIndex = 91;
            // 
            // lbl_MobileIP
            // 
            this.lbl_MobileIP.AutoSize = true;
            this.lbl_MobileIP.Location = new System.Drawing.Point(227, 217);
            this.lbl_MobileIP.Name = "lbl_MobileIP";
            this.lbl_MobileIP.Size = new System.Drawing.Size(0, 12);
            this.lbl_MobileIP.TabIndex = 90;
            // 
            // cbx_UseMobileNet
            // 
            this.cbx_UseMobileNet.AutoSize = true;
            this.cbx_UseMobileNet.Location = new System.Drawing.Point(229, 192);
            this.cbx_UseMobileNet.Name = "cbx_UseMobileNet";
            this.cbx_UseMobileNet.Size = new System.Drawing.Size(96, 16);
            this.cbx_UseMobileNet.TabIndex = 89;
            this.cbx_UseMobileNet.Text = "UseMobileNet";
            this.cbx_UseMobileNet.UseVisualStyleBackColor = true;
            // 
            // tbx_Key
            // 
            this.tbx_Key.Location = new System.Drawing.Point(417, 147);
            this.tbx_Key.Name = "tbx_Key";
            this.tbx_Key.Size = new System.Drawing.Size(100, 21);
            this.tbx_Key.TabIndex = 88;
            // 
            // tbx_SSID
            // 
            this.tbx_SSID.Location = new System.Drawing.Point(229, 147);
            this.tbx_SSID.Name = "tbx_SSID";
            this.tbx_SSID.Size = new System.Drawing.Size(100, 21);
            this.tbx_SSID.TabIndex = 87;
            // 
            // cbx_useWIFI
            // 
            this.cbx_useWIFI.AutoSize = true;
            this.cbx_useWIFI.Location = new System.Drawing.Point(228, 125);
            this.cbx_useWIFI.Name = "cbx_useWIFI";
            this.cbx_useWIFI.Size = new System.Drawing.Size(66, 16);
            this.cbx_useWIFI.TabIndex = 86;
            this.cbx_useWIFI.Text = "useWIFI";
            this.cbx_useWIFI.UseVisualStyleBackColor = true;
            // 
            // tbx_DHCPGateway
            // 
            this.tbx_DHCPGateway.Location = new System.Drawing.Point(417, 98);
            this.tbx_DHCPGateway.Name = "tbx_DHCPGateway";
            this.tbx_DHCPGateway.ReadOnly = true;
            this.tbx_DHCPGateway.Size = new System.Drawing.Size(100, 21);
            this.tbx_DHCPGateway.TabIndex = 85;
            this.tbx_DHCPGateway.Text = "0.0.0.0";
            // 
            // tbx_DHCPSubnet
            // 
            this.tbx_DHCPSubnet.Location = new System.Drawing.Point(417, 70);
            this.tbx_DHCPSubnet.Name = "tbx_DHCPSubnet";
            this.tbx_DHCPSubnet.ReadOnly = true;
            this.tbx_DHCPSubnet.Size = new System.Drawing.Size(100, 21);
            this.tbx_DHCPSubnet.TabIndex = 84;
            this.tbx_DHCPSubnet.Text = "0.0.0.0";
            // 
            // tbx_DHCPIP
            // 
            this.tbx_DHCPIP.Location = new System.Drawing.Point(417, 43);
            this.tbx_DHCPIP.Name = "tbx_DHCPIP";
            this.tbx_DHCPIP.ReadOnly = true;
            this.tbx_DHCPIP.Size = new System.Drawing.Size(100, 21);
            this.tbx_DHCPIP.TabIndex = 83;
            this.tbx_DHCPIP.Text = "0.0.0.0";
            // 
            // tbx_NetGateway
            // 
            this.tbx_NetGateway.Location = new System.Drawing.Point(229, 98);
            this.tbx_NetGateway.Name = "tbx_NetGateway";
            this.tbx_NetGateway.Size = new System.Drawing.Size(100, 21);
            this.tbx_NetGateway.TabIndex = 82;
            // 
            // tbx_NetSubnet
            // 
            this.tbx_NetSubnet.Location = new System.Drawing.Point(229, 70);
            this.tbx_NetSubnet.Name = "tbx_NetSubnet";
            this.tbx_NetSubnet.Size = new System.Drawing.Size(100, 21);
            this.tbx_NetSubnet.TabIndex = 81;
            // 
            // tbx_NetIP
            // 
            this.tbx_NetIP.Location = new System.Drawing.Point(229, 43);
            this.tbx_NetIP.Name = "tbx_NetIP";
            this.tbx_NetIP.Size = new System.Drawing.Size(100, 21);
            this.tbx_NetIP.TabIndex = 80;
            // 
            // lbl_MAC
            // 
            this.lbl_MAC.AutoSize = true;
            this.lbl_MAC.Location = new System.Drawing.Point(227, 21);
            this.lbl_MAC.Name = "lbl_MAC";
            this.lbl_MAC.Size = new System.Drawing.Size(0, 12);
            this.lbl_MAC.TabIndex = 79;
            // 
            // cbx_DHCP
            // 
            this.cbx_DHCP.AutoSize = true;
            this.cbx_DHCP.Location = new System.Drawing.Point(417, 23);
            this.cbx_DHCP.Name = "cbx_DHCP";
            this.cbx_DHCP.Size = new System.Drawing.Size(48, 16);
            this.cbx_DHCP.TabIndex = 78;
            this.cbx_DHCP.Text = "DHCP";
            this.cbx_DHCP.UseVisualStyleBackColor = true;
            // 
            // btn_SetGPS
            // 
            this.btn_SetGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetGPS.Location = new System.Drawing.Point(11, 376);
            this.btn_SetGPS.Name = "btn_SetGPS";
            this.btn_SetGPS.Size = new System.Drawing.Size(150, 23);
            this.btn_SetGPS.TabIndex = 77;
            this.btn_SetGPS.Text = "SetGPS";
            this.btn_SetGPS.UseVisualStyleBackColor = false;
            this.btn_SetGPS.Click += new System.EventHandler(this.btn_SetGPS_Click);
            // 
            // tbx_CloudAddress
            // 
            this.tbx_CloudAddress.Location = new System.Drawing.Point(229, 448);
            this.tbx_CloudAddress.Name = "tbx_CloudAddress";
            this.tbx_CloudAddress.Size = new System.Drawing.Size(289, 21);
            this.tbx_CloudAddress.TabIndex = 76;
            this.tbx_CloudAddress.Text = "wss://10.0.0.121:2018";
            // 
            // btn_SetStreamingServer
            // 
            this.btn_SetStreamingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetStreamingServer.Location = new System.Drawing.Point(11, 508);
            this.btn_SetStreamingServer.Name = "btn_SetStreamingServer";
            this.btn_SetStreamingServer.Size = new System.Drawing.Size(150, 23);
            this.btn_SetStreamingServer.TabIndex = 74;
            this.btn_SetStreamingServer.Text = "SetStreamingServer";
            this.btn_SetStreamingServer.UseVisualStyleBackColor = false;
            this.btn_SetStreamingServer.Click += new System.EventHandler(this.btn_SetStreamingServer_Click);
            // 
            // btn_GetStreamingServer
            // 
            this.btn_GetStreamingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetStreamingServer.Location = new System.Drawing.Point(11, 479);
            this.btn_GetStreamingServer.Name = "btn_GetStreamingServer";
            this.btn_GetStreamingServer.Size = new System.Drawing.Size(150, 23);
            this.btn_GetStreamingServer.TabIndex = 73;
            this.btn_GetStreamingServer.Text = "GetStreamingServer";
            this.btn_GetStreamingServer.UseVisualStyleBackColor = false;
            this.btn_GetStreamingServer.Click += new System.EventHandler(this.btn_GetStreamingServer_Click);
            // 
            // btn_SetCloudServer
            // 
            this.btn_SetCloudServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetCloudServer.Location = new System.Drawing.Point(11, 446);
            this.btn_SetCloudServer.Name = "btn_SetCloudServer";
            this.btn_SetCloudServer.Size = new System.Drawing.Size(150, 23);
            this.btn_SetCloudServer.TabIndex = 72;
            this.btn_SetCloudServer.Text = "SetCloudServer";
            this.btn_SetCloudServer.UseVisualStyleBackColor = false;
            this.btn_SetCloudServer.Click += new System.EventHandler(this.btn_SetCloudServer_Click);
            // 
            // btn_GetCloudServer
            // 
            this.btn_GetCloudServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetCloudServer.Location = new System.Drawing.Point(11, 417);
            this.btn_GetCloudServer.Name = "btn_GetCloudServer";
            this.btn_GetCloudServer.Size = new System.Drawing.Size(150, 23);
            this.btn_GetCloudServer.TabIndex = 71;
            this.btn_GetCloudServer.Text = "GetCloudServer";
            this.btn_GetCloudServer.UseVisualStyleBackColor = false;
            this.btn_GetCloudServer.Click += new System.EventHandler(this.btn_GetCloudServer_Click);
            // 
            // btn_GetLocalServer
            // 
            this.btn_GetLocalServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetLocalServer.Location = new System.Drawing.Point(11, 540);
            this.btn_GetLocalServer.Name = "btn_GetLocalServer";
            this.btn_GetLocalServer.Size = new System.Drawing.Size(150, 23);
            this.btn_GetLocalServer.TabIndex = 66;
            this.btn_GetLocalServer.Text = "GetLocalServer";
            this.btn_GetLocalServer.UseVisualStyleBackColor = false;
            this.btn_GetLocalServer.Click += new System.EventHandler(this.btn_GetLocalServer_Click);
            // 
            // btn_SetLocalServer
            // 
            this.btn_SetLocalServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetLocalServer.Location = new System.Drawing.Point(11, 569);
            this.btn_SetLocalServer.Name = "btn_SetLocalServer";
            this.btn_SetLocalServer.Size = new System.Drawing.Size(150, 23);
            this.btn_SetLocalServer.TabIndex = 65;
            this.btn_SetLocalServer.Text = "SetLocalServer";
            this.btn_SetLocalServer.UseVisualStyleBackColor = false;
            this.btn_SetLocalServer.Click += new System.EventHandler(this.btn_SetLocalServer_Click);
            // 
            // btn_GetGPS
            // 
            this.btn_GetGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetGPS.Location = new System.Drawing.Point(11, 347);
            this.btn_GetGPS.Name = "btn_GetGPS";
            this.btn_GetGPS.Size = new System.Drawing.Size(150, 23);
            this.btn_GetGPS.TabIndex = 60;
            this.btn_GetGPS.Text = "GetGPS";
            this.btn_GetGPS.UseVisualStyleBackColor = false;
            this.btn_GetGPS.Click += new System.EventHandler(this.btn_GetGPS_Click);
            // 
            // btn_SetVPNServer
            // 
            this.btn_SetVPNServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetVPNServer.Location = new System.Drawing.Point(11, 293);
            this.btn_SetVPNServer.Name = "btn_SetVPNServer";
            this.btn_SetVPNServer.Size = new System.Drawing.Size(150, 23);
            this.btn_SetVPNServer.TabIndex = 57;
            this.btn_SetVPNServer.Text = "SetVPNServer";
            this.btn_SetVPNServer.UseVisualStyleBackColor = false;
            this.btn_SetVPNServer.Click += new System.EventHandler(this.btn_SetVPNServer_Click);
            // 
            // btn_GetVPNServer
            // 
            this.btn_GetVPNServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetVPNServer.Location = new System.Drawing.Point(11, 264);
            this.btn_GetVPNServer.Name = "btn_GetVPNServer";
            this.btn_GetVPNServer.Size = new System.Drawing.Size(150, 23);
            this.btn_GetVPNServer.TabIndex = 56;
            this.btn_GetVPNServer.Text = "GetVPNServer";
            this.btn_GetVPNServer.UseVisualStyleBackColor = false;
            this.btn_GetVPNServer.Click += new System.EventHandler(this.btn_GetVPNServer_Click);
            // 
            // btn_SetMobileNetSetting
            // 
            this.btn_SetMobileNetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetMobileNetSetting.Location = new System.Drawing.Point(11, 221);
            this.btn_SetMobileNetSetting.Name = "btn_SetMobileNetSetting";
            this.btn_SetMobileNetSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetMobileNetSetting.TabIndex = 55;
            this.btn_SetMobileNetSetting.Text = "SetMobileNetSetting";
            this.btn_SetMobileNetSetting.UseVisualStyleBackColor = false;
            this.btn_SetMobileNetSetting.Click += new System.EventHandler(this.btn_SetMobileNetSetting_Click);
            // 
            // btn_GetMobileNetSetting
            // 
            this.btn_GetMobileNetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetMobileNetSetting.Location = new System.Drawing.Point(11, 192);
            this.btn_GetMobileNetSetting.Name = "btn_GetMobileNetSetting";
            this.btn_GetMobileNetSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetMobileNetSetting.TabIndex = 54;
            this.btn_GetMobileNetSetting.Text = "GetMobileNetSetting";
            this.btn_GetMobileNetSetting.UseVisualStyleBackColor = false;
            this.btn_GetMobileNetSetting.Click += new System.EventHandler(this.btn_GetMobileNetSetting_Click);
            // 
            // btn_SetWifiSetting
            // 
            this.btn_SetWifiSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetWifiSetting.Location = new System.Drawing.Point(11, 134);
            this.btn_SetWifiSetting.Name = "btn_SetWifiSetting";
            this.btn_SetWifiSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetWifiSetting.TabIndex = 53;
            this.btn_SetWifiSetting.Text = "SetWifiSetting";
            this.btn_SetWifiSetting.UseVisualStyleBackColor = false;
            this.btn_SetWifiSetting.Click += new System.EventHandler(this.btn_SetWifiSetting_Click);
            // 
            // btn_GetWifiSetting
            // 
            this.btn_GetWifiSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetWifiSetting.Location = new System.Drawing.Point(11, 105);
            this.btn_GetWifiSetting.Name = "btn_GetWifiSetting";
            this.btn_GetWifiSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetWifiSetting.TabIndex = 52;
            this.btn_GetWifiSetting.Text = "GetWifiSetting";
            this.btn_GetWifiSetting.UseVisualStyleBackColor = false;
            this.btn_GetWifiSetting.Click += new System.EventHandler(this.btn_GetWifiSetting_Click);
            // 
            // btn_SetEthernetSetting
            // 
            this.btn_SetEthernetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetEthernetSetting.Location = new System.Drawing.Point(11, 47);
            this.btn_SetEthernetSetting.Name = "btn_SetEthernetSetting";
            this.btn_SetEthernetSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetEthernetSetting.TabIndex = 51;
            this.btn_SetEthernetSetting.Text = "SetEthernetSetting";
            this.btn_SetEthernetSetting.UseVisualStyleBackColor = false;
            this.btn_SetEthernetSetting.Click += new System.EventHandler(this.btn_SetEthernetSetting_Click);
            // 
            // btn_GetEthernetSetting
            // 
            this.btn_GetEthernetSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetEthernetSetting.Location = new System.Drawing.Point(11, 18);
            this.btn_GetEthernetSetting.Name = "btn_GetEthernetSetting";
            this.btn_GetEthernetSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetEthernetSetting.TabIndex = 50;
            this.btn_GetEthernetSetting.Text = "GetEthernetSetting";
            this.btn_GetEthernetSetting.UseVisualStyleBackColor = false;
            this.btn_GetEthernetSetting.Click += new System.EventHandler(this.btn_GetEthernetSetting_Click);
            // 
            // page_Advance
            // 
            this.page_Advance.Controls.Add(this.cobx_Camera);
            this.page_Advance.Controls.Add(this.pbx_TakePhoto);
            this.page_Advance.Controls.Add(this.btn_TakePhoto);
            this.page_Advance.Controls.Add(this.cbx_Restart);
            this.page_Advance.Controls.Add(this.lbl_SwipeIDCardCount);
            this.page_Advance.Controls.Add(this.cbx_LivingMode);
            this.page_Advance.Controls.Add(this.tbx_SwipeIDCardCount);
            this.page_Advance.Controls.Add(this.cbx_PowerKey);
            this.page_Advance.Controls.Add(this.cbx_ScreenSaver);
            this.page_Advance.Controls.Add(this.cbx_RealTimePhoto);
            this.page_Advance.Controls.Add(this.lbl_FirmwareAddress);
            this.page_Advance.Controls.Add(this.lbl_SleepAfter);
            this.page_Advance.Controls.Add(this.lbl_RestartTime);
            this.page_Advance.Controls.Add(this.dtp_RestartTime);
            this.page_Advance.Controls.Add(this.lbl_RestoreAction);
            this.page_Advance.Controls.Add(this.lbl_IdentifyMode);
            this.page_Advance.Controls.Add(this.lbl_Volume);
            this.page_Advance.Controls.Add(this.lbl_Language);
            this.page_Advance.Controls.Add(this.tbx_SleepAfter);
            this.page_Advance.Controls.Add(this.tbx_FirmwareAddress);
            this.page_Advance.Controls.Add(this.cobx_RestoreAction);
            this.page_Advance.Controls.Add(this.cobx_IdentifyMode);
            this.page_Advance.Controls.Add(this.cobx_Volume);
            this.page_Advance.Controls.Add(this.cobx_Language);
            this.page_Advance.Controls.Add(this.btn_FirmwareUpgradeByCloud);
            this.page_Advance.Controls.Add(this.btn_RestoreDevice);
            this.page_Advance.Controls.Add(this.btn_GetDeviceSetting);
            this.page_Advance.Controls.Add(this.btn_SetDeviceSetting);
            this.page_Advance.Controls.Add(this.btn_GetPowerSetting);
            this.page_Advance.Controls.Add(this.btn_SetPowerSetting);
            this.page_Advance.Location = new System.Drawing.Point(4, 22);
            this.page_Advance.Name = "page_Advance";
            this.page_Advance.Padding = new System.Windows.Forms.Padding(3);
            this.page_Advance.Size = new System.Drawing.Size(533, 655);
            this.page_Advance.TabIndex = 2;
            this.page_Advance.Text = "Advance";
            this.page_Advance.UseVisualStyleBackColor = true;
            // 
            // cbx_Restart
            // 
            this.cbx_Restart.AutoSize = true;
            this.cbx_Restart.Location = new System.Drawing.Point(279, 254);
            this.cbx_Restart.Name = "cbx_Restart";
            this.cbx_Restart.Size = new System.Drawing.Size(66, 16);
            this.cbx_Restart.TabIndex = 60;
            this.cbx_Restart.Text = "Restart";
            this.cbx_Restart.UseVisualStyleBackColor = true;
            // 
            // lbl_SwipeIDCardCount
            // 
            this.lbl_SwipeIDCardCount.AutoSize = true;
            this.lbl_SwipeIDCardCount.Location = new System.Drawing.Point(166, 148);
            this.lbl_SwipeIDCardCount.Name = "lbl_SwipeIDCardCount";
            this.lbl_SwipeIDCardCount.Size = new System.Drawing.Size(107, 12);
            this.lbl_SwipeIDCardCount.TabIndex = 59;
            this.lbl_SwipeIDCardCount.Text = "SwipeIDCardCount:";
            // 
            // cbx_LivingMode
            // 
            this.cbx_LivingMode.AutoSize = true;
            this.cbx_LivingMode.Location = new System.Drawing.Point(279, 123);
            this.cbx_LivingMode.Name = "cbx_LivingMode";
            this.cbx_LivingMode.Size = new System.Drawing.Size(84, 16);
            this.cbx_LivingMode.TabIndex = 58;
            this.cbx_LivingMode.Text = "LivingMode";
            this.cbx_LivingMode.UseVisualStyleBackColor = true;
            // 
            // tbx_SwipeIDCardCount
            // 
            this.tbx_SwipeIDCardCount.Location = new System.Drawing.Point(279, 145);
            this.tbx_SwipeIDCardCount.Name = "tbx_SwipeIDCardCount";
            this.tbx_SwipeIDCardCount.Size = new System.Drawing.Size(155, 21);
            this.tbx_SwipeIDCardCount.TabIndex = 57;
            this.tbx_SwipeIDCardCount.Text = "3";
            // 
            // cbx_PowerKey
            // 
            this.cbx_PowerKey.AutoSize = true;
            this.cbx_PowerKey.Location = new System.Drawing.Point(279, 355);
            this.cbx_PowerKey.Name = "cbx_PowerKey";
            this.cbx_PowerKey.Size = new System.Drawing.Size(72, 16);
            this.cbx_PowerKey.TabIndex = 56;
            this.cbx_PowerKey.Text = "PowerKey";
            this.cbx_PowerKey.UseVisualStyleBackColor = true;
            // 
            // cbx_ScreenSaver
            // 
            this.cbx_ScreenSaver.AutoSize = true;
            this.cbx_ScreenSaver.Checked = true;
            this.cbx_ScreenSaver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_ScreenSaver.Location = new System.Drawing.Point(279, 333);
            this.cbx_ScreenSaver.Name = "cbx_ScreenSaver";
            this.cbx_ScreenSaver.Size = new System.Drawing.Size(90, 16);
            this.cbx_ScreenSaver.TabIndex = 55;
            this.cbx_ScreenSaver.Text = "ScreenSaver";
            this.cbx_ScreenSaver.UseVisualStyleBackColor = true;
            // 
            // cbx_RealTimePhoto
            // 
            this.cbx_RealTimePhoto.AutoSize = true;
            this.cbx_RealTimePhoto.Checked = true;
            this.cbx_RealTimePhoto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_RealTimePhoto.Location = new System.Drawing.Point(279, 101);
            this.cbx_RealTimePhoto.Name = "cbx_RealTimePhoto";
            this.cbx_RealTimePhoto.Size = new System.Drawing.Size(102, 16);
            this.cbx_RealTimePhoto.TabIndex = 54;
            this.cbx_RealTimePhoto.Text = "RealTimePhoto";
            this.cbx_RealTimePhoto.UseVisualStyleBackColor = true;
            // 
            // lbl_FirmwareAddress
            // 
            this.lbl_FirmwareAddress.AutoSize = true;
            this.lbl_FirmwareAddress.Location = new System.Drawing.Point(172, 409);
            this.lbl_FirmwareAddress.Name = "lbl_FirmwareAddress";
            this.lbl_FirmwareAddress.Size = new System.Drawing.Size(101, 12);
            this.lbl_FirmwareAddress.TabIndex = 53;
            this.lbl_FirmwareAddress.Text = "FirmwareAddress:";
            // 
            // lbl_SleepAfter
            // 
            this.lbl_SleepAfter.AutoSize = true;
            this.lbl_SleepAfter.Location = new System.Drawing.Point(203, 309);
            this.lbl_SleepAfter.Name = "lbl_SleepAfter";
            this.lbl_SleepAfter.Size = new System.Drawing.Size(71, 12);
            this.lbl_SleepAfter.TabIndex = 49;
            this.lbl_SleepAfter.Text = "SleepAfter:";
            // 
            // lbl_RestartTime
            // 
            this.lbl_RestartTime.AutoSize = true;
            this.lbl_RestartTime.Location = new System.Drawing.Point(197, 282);
            this.lbl_RestartTime.Name = "lbl_RestartTime";
            this.lbl_RestartTime.Size = new System.Drawing.Size(77, 12);
            this.lbl_RestartTime.TabIndex = 48;
            this.lbl_RestartTime.Text = "RestartTime:";
            // 
            // dtp_RestartTime
            // 
            this.dtp_RestartTime.Location = new System.Drawing.Point(279, 276);
            this.dtp_RestartTime.Name = "dtp_RestartTime";
            this.dtp_RestartTime.Size = new System.Drawing.Size(155, 21);
            this.dtp_RestartTime.TabIndex = 47;
            // 
            // lbl_RestoreAction
            // 
            this.lbl_RestoreAction.AutoSize = true;
            this.lbl_RestoreAction.Location = new System.Drawing.Point(184, 210);
            this.lbl_RestoreAction.Name = "lbl_RestoreAction";
            this.lbl_RestoreAction.Size = new System.Drawing.Size(89, 12);
            this.lbl_RestoreAction.TabIndex = 46;
            this.lbl_RestoreAction.Text = "RestoreAction:";
            // 
            // lbl_IdentifyMode
            // 
            this.lbl_IdentifyMode.AutoSize = true;
            this.lbl_IdentifyMode.Location = new System.Drawing.Point(191, 78);
            this.lbl_IdentifyMode.Name = "lbl_IdentifyMode";
            this.lbl_IdentifyMode.Size = new System.Drawing.Size(83, 12);
            this.lbl_IdentifyMode.TabIndex = 44;
            this.lbl_IdentifyMode.Text = "IdentifyMode:";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Location = new System.Drawing.Point(226, 56);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(47, 12);
            this.lbl_Volume.TabIndex = 43;
            this.lbl_Volume.Text = "Volume:";
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Location = new System.Drawing.Point(215, 27);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(59, 12);
            this.lbl_Language.TabIndex = 42;
            this.lbl_Language.Text = "Language:";
            // 
            // tbx_SleepAfter
            // 
            this.tbx_SleepAfter.Location = new System.Drawing.Point(279, 306);
            this.tbx_SleepAfter.Name = "tbx_SleepAfter";
            this.tbx_SleepAfter.Size = new System.Drawing.Size(155, 21);
            this.tbx_SleepAfter.TabIndex = 39;
            this.tbx_SleepAfter.Text = "1";
            // 
            // tbx_FirmwareAddress
            // 
            this.tbx_FirmwareAddress.Location = new System.Drawing.Point(279, 406);
            this.tbx_FirmwareAddress.Multiline = true;
            this.tbx_FirmwareAddress.Name = "tbx_FirmwareAddress";
            this.tbx_FirmwareAddress.Size = new System.Drawing.Size(248, 49);
            this.tbx_FirmwareAddress.TabIndex = 35;
            this.tbx_FirmwareAddress.Text = "http://download.sample.com/v2.01.bin";
            // 
            // cobx_RestoreAction
            // 
            this.cobx_RestoreAction.FormattingEnabled = true;
            this.cobx_RestoreAction.Location = new System.Drawing.Point(279, 207);
            this.cobx_RestoreAction.Name = "cobx_RestoreAction";
            this.cobx_RestoreAction.Size = new System.Drawing.Size(155, 20);
            this.cobx_RestoreAction.TabIndex = 34;
            // 
            // cobx_IdentifyMode
            // 
            this.cobx_IdentifyMode.FormattingEnabled = true;
            this.cobx_IdentifyMode.Location = new System.Drawing.Point(279, 75);
            this.cobx_IdentifyMode.Name = "cobx_IdentifyMode";
            this.cobx_IdentifyMode.Size = new System.Drawing.Size(155, 20);
            this.cobx_IdentifyMode.TabIndex = 32;
            // 
            // cobx_Volume
            // 
            this.cobx_Volume.FormattingEnabled = true;
            this.cobx_Volume.Location = new System.Drawing.Point(279, 49);
            this.cobx_Volume.Name = "cobx_Volume";
            this.cobx_Volume.Size = new System.Drawing.Size(155, 20);
            this.cobx_Volume.TabIndex = 31;
            // 
            // cobx_Language
            // 
            this.cobx_Language.FormattingEnabled = true;
            this.cobx_Language.Location = new System.Drawing.Point(279, 24);
            this.cobx_Language.Name = "cobx_Language";
            this.cobx_Language.Size = new System.Drawing.Size(155, 20);
            this.cobx_Language.TabIndex = 30;
            // 
            // btn_FirmwareUpgradeByCloud
            // 
            this.btn_FirmwareUpgradeByCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_FirmwareUpgradeByCloud.Location = new System.Drawing.Point(18, 404);
            this.btn_FirmwareUpgradeByCloud.Name = "btn_FirmwareUpgradeByCloud";
            this.btn_FirmwareUpgradeByCloud.Size = new System.Drawing.Size(150, 23);
            this.btn_FirmwareUpgradeByCloud.TabIndex = 26;
            this.btn_FirmwareUpgradeByCloud.Text = "FirmwareUpgradeByCloud";
            this.btn_FirmwareUpgradeByCloud.UseVisualStyleBackColor = false;
            this.btn_FirmwareUpgradeByCloud.Click += new System.EventHandler(this.btn_FirmwareUpgradeByCloud_Click);
            // 
            // btn_RestoreDevice
            // 
            this.btn_RestoreDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_RestoreDevice.Location = new System.Drawing.Point(18, 207);
            this.btn_RestoreDevice.Name = "btn_RestoreDevice";
            this.btn_RestoreDevice.Size = new System.Drawing.Size(150, 23);
            this.btn_RestoreDevice.TabIndex = 24;
            this.btn_RestoreDevice.Text = "RestoreDevice";
            this.btn_RestoreDevice.UseVisualStyleBackColor = false;
            this.btn_RestoreDevice.Click += new System.EventHandler(this.btn_RestoreDevice_Click);
            // 
            // btn_GetDeviceSetting
            // 
            this.btn_GetDeviceSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetDeviceSetting.Location = new System.Drawing.Point(18, 22);
            this.btn_GetDeviceSetting.Name = "btn_GetDeviceSetting";
            this.btn_GetDeviceSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetDeviceSetting.TabIndex = 23;
            this.btn_GetDeviceSetting.Text = "GetDeviceSetting";
            this.btn_GetDeviceSetting.UseVisualStyleBackColor = false;
            this.btn_GetDeviceSetting.Click += new System.EventHandler(this.btn_GetDeviceSetting_Click);
            // 
            // btn_SetDeviceSetting
            // 
            this.btn_SetDeviceSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetDeviceSetting.Location = new System.Drawing.Point(18, 51);
            this.btn_SetDeviceSetting.Name = "btn_SetDeviceSetting";
            this.btn_SetDeviceSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetDeviceSetting.TabIndex = 22;
            this.btn_SetDeviceSetting.Text = "SetDeviceSetting";
            this.btn_SetDeviceSetting.UseVisualStyleBackColor = false;
            this.btn_SetDeviceSetting.Click += new System.EventHandler(this.btn_SetDeviceSetting_Click);
            // 
            // btn_GetPowerSetting
            // 
            this.btn_GetPowerSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetPowerSetting.Location = new System.Drawing.Point(18, 275);
            this.btn_GetPowerSetting.Name = "btn_GetPowerSetting";
            this.btn_GetPowerSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetPowerSetting.TabIndex = 21;
            this.btn_GetPowerSetting.Text = "GetPowerSetting";
            this.btn_GetPowerSetting.UseVisualStyleBackColor = false;
            this.btn_GetPowerSetting.Click += new System.EventHandler(this.btn_GetPowerSetting_Click);
            // 
            // btn_SetPowerSetting
            // 
            this.btn_SetPowerSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetPowerSetting.Location = new System.Drawing.Point(18, 304);
            this.btn_SetPowerSetting.Name = "btn_SetPowerSetting";
            this.btn_SetPowerSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetPowerSetting.TabIndex = 20;
            this.btn_SetPowerSetting.Text = "SetPowerSetting";
            this.btn_SetPowerSetting.UseVisualStyleBackColor = false;
            this.btn_SetPowerSetting.Click += new System.EventHandler(this.btn_SetPowerSetting_Click);
            // 
            // page_Basic
            // 
            this.page_Basic.Controls.Add(this.lbl_NameListName);
            this.page_Basic.Controls.Add(this.lbl_ListNo);
            this.page_Basic.Controls.Add(this.tbx_NameListName);
            this.page_Basic.Controls.Add(this.cobx_ListNo);
            this.page_Basic.Controls.Add(this.btn_GetNameList);
            this.page_Basic.Controls.Add(this.btn_SetNameList);
            this.page_Basic.Controls.Add(this.cobx_UTC);
            this.page_Basic.Controls.Add(this.cbx_UseProxy);
            this.page_Basic.Controls.Add(this.lbl_ProxyName);
            this.page_Basic.Controls.Add(this.lbl_ProxyNo);
            this.page_Basic.Controls.Add(this.lbl_DepartName);
            this.page_Basic.Controls.Add(this.lbl_DeptNo);
            this.page_Basic.Controls.Add(this.dtp_custTime);
            this.page_Basic.Controls.Add(this.lbl_GetDeviceTime);
            this.page_Basic.Controls.Add(this.lbl_EnableDevice);
            this.page_Basic.Controls.Add(this.dgv_BellSetting);
            this.page_Basic.Controls.Add(this.rbtn_custmTime);
            this.page_Basic.Controls.Add(this.rbtn_sysTime);
            this.page_Basic.Controls.Add(this.tbx_DepartName);
            this.page_Basic.Controls.Add(this.cobx_Depart_B);
            this.page_Basic.Controls.Add(this.tbx_ProxyName);
            this.page_Basic.Controls.Add(this.cobx_ProxyNo);
            this.page_Basic.Controls.Add(this.btn_EnableDevice);
            this.page_Basic.Controls.Add(this.btn_GetTime);
            this.page_Basic.Controls.Add(this.btn_SetTime);
            this.page_Basic.Controls.Add(this.btn_GetBellSetting);
            this.page_Basic.Controls.Add(this.btn_SetBellSetting);
            this.page_Basic.Controls.Add(this.btn_GetProxyName);
            this.page_Basic.Controls.Add(this.btn_SetProxyName);
            this.page_Basic.Controls.Add(this.btn_GetDepartment);
            this.page_Basic.Controls.Add(this.btn_SetDepartment);
            this.page_Basic.Location = new System.Drawing.Point(4, 22);
            this.page_Basic.Name = "page_Basic";
            this.page_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.page_Basic.Size = new System.Drawing.Size(533, 655);
            this.page_Basic.TabIndex = 1;
            this.page_Basic.Text = "Basic";
            this.page_Basic.UseVisualStyleBackColor = true;
            // 
            // lbl_NameListName
            // 
            this.lbl_NameListName.AutoSize = true;
            this.lbl_NameListName.Location = new System.Drawing.Point(177, 231);
            this.lbl_NameListName.Name = "lbl_NameListName";
            this.lbl_NameListName.Size = new System.Drawing.Size(83, 12);
            this.lbl_NameListName.TabIndex = 60;
            this.lbl_NameListName.Text = "NameListName:";
            // 
            // lbl_ListNo
            // 
            this.lbl_ListNo.AutoSize = true;
            this.lbl_ListNo.Location = new System.Drawing.Point(212, 202);
            this.lbl_ListNo.Name = "lbl_ListNo";
            this.lbl_ListNo.Size = new System.Drawing.Size(47, 12);
            this.lbl_ListNo.TabIndex = 59;
            this.lbl_ListNo.Text = "ListNo:";
            // 
            // tbx_NameListName
            // 
            this.tbx_NameListName.Location = new System.Drawing.Point(265, 228);
            this.tbx_NameListName.Name = "tbx_NameListName";
            this.tbx_NameListName.Size = new System.Drawing.Size(176, 21);
            this.tbx_NameListName.TabIndex = 58;
            // 
            // cobx_ListNo
            // 
            this.cobx_ListNo.FormattingEnabled = true;
            this.cobx_ListNo.Location = new System.Drawing.Point(265, 194);
            this.cobx_ListNo.Name = "cobx_ListNo";
            this.cobx_ListNo.Size = new System.Drawing.Size(176, 20);
            this.cobx_ListNo.TabIndex = 57;
            // 
            // btn_GetNameList
            // 
            this.btn_GetNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetNameList.Location = new System.Drawing.Point(6, 197);
            this.btn_GetNameList.Name = "btn_GetNameList";
            this.btn_GetNameList.Size = new System.Drawing.Size(150, 23);
            this.btn_GetNameList.TabIndex = 55;
            this.btn_GetNameList.Text = "GetNameList";
            this.btn_GetNameList.UseVisualStyleBackColor = false;
            this.btn_GetNameList.Click += new System.EventHandler(this.btn_GetNameList_Click);
            // 
            // btn_SetNameList
            // 
            this.btn_SetNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetNameList.Location = new System.Drawing.Point(6, 226);
            this.btn_SetNameList.Name = "btn_SetNameList";
            this.btn_SetNameList.Size = new System.Drawing.Size(150, 23);
            this.btn_SetNameList.TabIndex = 56;
            this.btn_SetNameList.Text = "SetNameList";
            this.btn_SetNameList.UseVisualStyleBackColor = false;
            this.btn_SetNameList.Click += new System.EventHandler(this.btn_SetNameList_Click);
            // 
            // cobx_UTC
            // 
            this.cobx_UTC.FormattingEnabled = true;
            this.cobx_UTC.Location = new System.Drawing.Point(447, 83);
            this.cobx_UTC.Name = "cobx_UTC";
            this.cobx_UTC.Size = new System.Drawing.Size(70, 20);
            this.cobx_UTC.TabIndex = 54;
            // 
            // cbx_UseProxy
            // 
            this.cbx_UseProxy.AutoSize = true;
            this.cbx_UseProxy.Checked = true;
            this.cbx_UseProxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_UseProxy.Location = new System.Drawing.Point(447, 281);
            this.cbx_UseProxy.Name = "cbx_UseProxy";
            this.cbx_UseProxy.Size = new System.Drawing.Size(72, 16);
            this.cbx_UseProxy.TabIndex = 53;
            this.cbx_UseProxy.Text = "useProxy";
            this.cbx_UseProxy.UseVisualStyleBackColor = true;
            // 
            // lbl_ProxyName
            // 
            this.lbl_ProxyName.AutoSize = true;
            this.lbl_ProxyName.Location = new System.Drawing.Point(194, 308);
            this.lbl_ProxyName.Name = "lbl_ProxyName";
            this.lbl_ProxyName.Size = new System.Drawing.Size(65, 12);
            this.lbl_ProxyName.TabIndex = 52;
            this.lbl_ProxyName.Text = "ProxyName:";
            // 
            // lbl_ProxyNo
            // 
            this.lbl_ProxyNo.AutoSize = true;
            this.lbl_ProxyNo.Location = new System.Drawing.Point(206, 279);
            this.lbl_ProxyNo.Name = "lbl_ProxyNo";
            this.lbl_ProxyNo.Size = new System.Drawing.Size(53, 12);
            this.lbl_ProxyNo.TabIndex = 51;
            this.lbl_ProxyNo.Text = "ProxyNo:";
            // 
            // lbl_DepartName
            // 
            this.lbl_DepartName.AutoSize = true;
            this.lbl_DepartName.Location = new System.Drawing.Point(189, 157);
            this.lbl_DepartName.Name = "lbl_DepartName";
            this.lbl_DepartName.Size = new System.Drawing.Size(71, 12);
            this.lbl_DepartName.TabIndex = 50;
            this.lbl_DepartName.Text = "DepartName:";
            // 
            // lbl_DeptNo
            // 
            this.lbl_DeptNo.AutoSize = true;
            this.lbl_DeptNo.Location = new System.Drawing.Point(212, 128);
            this.lbl_DeptNo.Name = "lbl_DeptNo";
            this.lbl_DeptNo.Size = new System.Drawing.Size(47, 12);
            this.lbl_DeptNo.TabIndex = 49;
            this.lbl_DeptNo.Text = "DeptNo:";
            // 
            // dtp_custTime
            // 
            this.dtp_custTime.Location = new System.Drawing.Point(305, 83);
            this.dtp_custTime.Name = "dtp_custTime";
            this.dtp_custTime.Size = new System.Drawing.Size(136, 21);
            this.dtp_custTime.TabIndex = 38;
            this.dtp_custTime.Value = new System.DateTime(2018, 6, 1, 12, 29, 3, 0);
            // 
            // lbl_GetDeviceTime
            // 
            this.lbl_GetDeviceTime.AutoSize = true;
            this.lbl_GetDeviceTime.Location = new System.Drawing.Point(189, 58);
            this.lbl_GetDeviceTime.Name = "lbl_GetDeviceTime";
            this.lbl_GetDeviceTime.Size = new System.Drawing.Size(0, 12);
            this.lbl_GetDeviceTime.TabIndex = 37;
            // 
            // lbl_EnableDevice
            // 
            this.lbl_EnableDevice.AutoSize = true;
            this.lbl_EnableDevice.Location = new System.Drawing.Point(189, 32);
            this.lbl_EnableDevice.Name = "lbl_EnableDevice";
            this.lbl_EnableDevice.Size = new System.Drawing.Size(0, 12);
            this.lbl_EnableDevice.TabIndex = 36;
            // 
            // dgv_BellSetting
            // 
            this.dgv_BellSetting.AllowUserToAddRows = false;
            this.dgv_BellSetting.AllowUserToDeleteRows = false;
            this.dgv_BellSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BellSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Time,
            this.use,
            this.cycle,
            this.times});
            this.dgv_BellSetting.Location = new System.Drawing.Point(174, 341);
            this.dgv_BellSetting.Name = "dgv_BellSetting";
            this.dgv_BellSetting.RowTemplate.Height = 23;
            this.dgv_BellSetting.Size = new System.Drawing.Size(353, 302);
            this.dgv_BellSetting.TabIndex = 35;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 60;
            // 
            // use
            // 
            this.use.HeaderText = "Use";
            this.use.Name = "use";
            this.use.Width = 50;
            // 
            // cycle
            // 
            this.cycle.HeaderText = "Cycle";
            this.cycle.Name = "cycle";
            this.cycle.Width = 80;
            // 
            // times
            // 
            this.times.HeaderText = "Number";
            this.times.Name = "times";
            this.times.Width = 55;
            // 
            // rbtn_custmTime
            // 
            this.rbtn_custmTime.AutoSize = true;
            this.rbtn_custmTime.Location = new System.Drawing.Point(243, 86);
            this.rbtn_custmTime.Name = "rbtn_custmTime";
            this.rbtn_custmTime.Size = new System.Drawing.Size(65, 16);
            this.rbtn_custmTime.TabIndex = 33;
            this.rbtn_custmTime.Text = "custmer";
            this.rbtn_custmTime.UseVisualStyleBackColor = true;
            this.rbtn_custmTime.CheckedChanged += new System.EventHandler(this.rbtn_custmTime_CheckedChanged);
            // 
            // rbtn_sysTime
            // 
            this.rbtn_sysTime.AutoSize = true;
            this.rbtn_sysTime.Checked = true;
            this.rbtn_sysTime.Location = new System.Drawing.Point(187, 86);
            this.rbtn_sysTime.Name = "rbtn_sysTime";
            this.rbtn_sysTime.Size = new System.Drawing.Size(59, 16);
            this.rbtn_sysTime.TabIndex = 31;
            this.rbtn_sysTime.TabStop = true;
            this.rbtn_sysTime.Text = "system";
            this.rbtn_sysTime.UseVisualStyleBackColor = true;
            this.rbtn_sysTime.CheckedChanged += new System.EventHandler(this.rbtn_sysTime_CheckedChanged);
            // 
            // tbx_DepartName
            // 
            this.tbx_DepartName.Location = new System.Drawing.Point(265, 154);
            this.tbx_DepartName.Name = "tbx_DepartName";
            this.tbx_DepartName.Size = new System.Drawing.Size(176, 21);
            this.tbx_DepartName.TabIndex = 28;
            // 
            // cobx_Depart_B
            // 
            this.cobx_Depart_B.FormattingEnabled = true;
            this.cobx_Depart_B.Location = new System.Drawing.Point(265, 120);
            this.cobx_Depart_B.Name = "cobx_Depart_B";
            this.cobx_Depart_B.Size = new System.Drawing.Size(176, 20);
            this.cobx_Depart_B.TabIndex = 27;
            // 
            // tbx_ProxyName
            // 
            this.tbx_ProxyName.Location = new System.Drawing.Point(265, 305);
            this.tbx_ProxyName.Name = "tbx_ProxyName";
            this.tbx_ProxyName.Size = new System.Drawing.Size(176, 21);
            this.tbx_ProxyName.TabIndex = 26;
            // 
            // cobx_ProxyNo
            // 
            this.cobx_ProxyNo.FormattingEnabled = true;
            this.cobx_ProxyNo.Location = new System.Drawing.Point(265, 276);
            this.cobx_ProxyNo.Name = "cobx_ProxyNo";
            this.cobx_ProxyNo.Size = new System.Drawing.Size(176, 20);
            this.cobx_ProxyNo.TabIndex = 25;
            // 
            // btn_EnableDevice
            // 
            this.btn_EnableDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EnableDevice.Location = new System.Drawing.Point(6, 16);
            this.btn_EnableDevice.Name = "btn_EnableDevice";
            this.btn_EnableDevice.Size = new System.Drawing.Size(150, 23);
            this.btn_EnableDevice.TabIndex = 24;
            this.btn_EnableDevice.Text = "DisenableDevice";
            this.btn_EnableDevice.UseVisualStyleBackColor = false;
            this.btn_EnableDevice.Click += new System.EventHandler(this.btn_EnableDevice_Click);
            // 
            // btn_GetTime
            // 
            this.btn_GetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetTime.Location = new System.Drawing.Point(6, 52);
            this.btn_GetTime.Name = "btn_GetTime";
            this.btn_GetTime.Size = new System.Drawing.Size(150, 23);
            this.btn_GetTime.TabIndex = 23;
            this.btn_GetTime.Text = "GetTime";
            this.btn_GetTime.UseVisualStyleBackColor = false;
            this.btn_GetTime.Click += new System.EventHandler(this.btn_GetTime_Click);
            // 
            // btn_SetTime
            // 
            this.btn_SetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetTime.Location = new System.Drawing.Point(6, 83);
            this.btn_SetTime.Name = "btn_SetTime";
            this.btn_SetTime.Size = new System.Drawing.Size(150, 23);
            this.btn_SetTime.TabIndex = 22;
            this.btn_SetTime.Text = "SetTime";
            this.btn_SetTime.UseVisualStyleBackColor = false;
            this.btn_SetTime.Click += new System.EventHandler(this.btn_SetTime_Click);
            // 
            // btn_GetBellSetting
            // 
            this.btn_GetBellSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetBellSetting.Location = new System.Drawing.Point(6, 341);
            this.btn_GetBellSetting.Name = "btn_GetBellSetting";
            this.btn_GetBellSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_GetBellSetting.TabIndex = 21;
            this.btn_GetBellSetting.Text = "GetBellSetting";
            this.btn_GetBellSetting.UseVisualStyleBackColor = false;
            this.btn_GetBellSetting.Click += new System.EventHandler(this.btn_GetBellSetting_Click);
            // 
            // btn_SetBellSetting
            // 
            this.btn_SetBellSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetBellSetting.Location = new System.Drawing.Point(6, 370);
            this.btn_SetBellSetting.Name = "btn_SetBellSetting";
            this.btn_SetBellSetting.Size = new System.Drawing.Size(150, 23);
            this.btn_SetBellSetting.TabIndex = 20;
            this.btn_SetBellSetting.Text = "SetBellSetting";
            this.btn_SetBellSetting.UseVisualStyleBackColor = false;
            this.btn_SetBellSetting.Click += new System.EventHandler(this.btn_SetBellSetting_Click);
            // 
            // btn_GetProxyName
            // 
            this.btn_GetProxyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetProxyName.Location = new System.Drawing.Point(6, 274);
            this.btn_GetProxyName.Name = "btn_GetProxyName";
            this.btn_GetProxyName.Size = new System.Drawing.Size(150, 23);
            this.btn_GetProxyName.TabIndex = 17;
            this.btn_GetProxyName.Text = "GetProxyName";
            this.btn_GetProxyName.UseVisualStyleBackColor = false;
            this.btn_GetProxyName.Click += new System.EventHandler(this.btn_GetProxyName_Click);
            // 
            // btn_SetProxyName
            // 
            this.btn_SetProxyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetProxyName.Location = new System.Drawing.Point(6, 303);
            this.btn_SetProxyName.Name = "btn_SetProxyName";
            this.btn_SetProxyName.Size = new System.Drawing.Size(150, 23);
            this.btn_SetProxyName.TabIndex = 16;
            this.btn_SetProxyName.Text = "SetProxyName";
            this.btn_SetProxyName.UseVisualStyleBackColor = false;
            this.btn_SetProxyName.Click += new System.EventHandler(this.btn_SetProxyName_Click);
            // 
            // btn_GetDepartment
            // 
            this.btn_GetDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetDepartment.Location = new System.Drawing.Point(6, 123);
            this.btn_GetDepartment.Name = "btn_GetDepartment";
            this.btn_GetDepartment.Size = new System.Drawing.Size(150, 23);
            this.btn_GetDepartment.TabIndex = 14;
            this.btn_GetDepartment.Text = "GetDepartment";
            this.btn_GetDepartment.UseVisualStyleBackColor = false;
            this.btn_GetDepartment.Click += new System.EventHandler(this.btn_GetDepartment_Click);
            // 
            // btn_SetDepartment
            // 
            this.btn_SetDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetDepartment.Location = new System.Drawing.Point(6, 152);
            this.btn_SetDepartment.Name = "btn_SetDepartment";
            this.btn_SetDepartment.Size = new System.Drawing.Size(150, 23);
            this.btn_SetDepartment.TabIndex = 15;
            this.btn_SetDepartment.Text = "SetDepartment";
            this.btn_SetDepartment.UseVisualStyleBackColor = false;
            this.btn_SetDepartment.Click += new System.EventHandler(this.btn_SetDepartment_Click);
            // 
            // page_User
            // 
            this.page_User.Controls.Add(this.btn_IdantifyCard);
            this.page_User.Controls.Add(this.btn_SetUserSampleInfo);
            this.page_User.Controls.Add(this.lbl_AllUserID);
            this.page_User.Controls.Add(this.tbx_AllUserID);
            this.page_User.Controls.Add(this.lbl_Set_Type);
            this.page_User.Controls.Add(this.btn_GetAllUserID);
            this.page_User.Controls.Add(this.tbx_antoSETcounts);
            this.page_User.Controls.Add(this.btn_antoSET);
            this.page_User.Controls.Add(this.btn_GetNextSampleInfo);
            this.page_User.Controls.Add(this.cobx_userType);
            this.page_User.Controls.Add(this.btn_saveFaceData);
            this.page_User.Controls.Add(this.lbl_QRCode);
            this.page_User.Controls.Add(this.cobx_EnrollBackup);
            this.page_User.Controls.Add(this.lbl_FingerNo);
            this.page_User.Controls.Add(this.cobx_FingerNo);
            this.page_User.Controls.Add(this.lbl_FaceData);
            this.page_User.Controls.Add(this.lbl_FingerData);
            this.page_User.Controls.Add(this.lbl_Fingers);
            this.page_User.Controls.Add(this.lbl_PWD);
            this.page_User.Controls.Add(this.lbl_Card);
            this.page_User.Controls.Add(this.lbl_Depart);
            this.page_User.Controls.Add(this.lbl_Privilege);
            this.page_User.Controls.Add(this.lbl_Name);
            this.page_User.Controls.Add(this.lbl_UserID);
            this.page_User.Controls.Add(this.pbx_UserQRCode);
            this.page_User.Controls.Add(this.cbx_Enabled);
            this.page_User.Controls.Add(this.pbx_UserPhoto);
            this.page_User.Controls.Add(this.cbx_FaceEnroll);
            this.page_User.Controls.Add(this.cobx_Depart_U);
            this.page_User.Controls.Add(this.cobx_Privilege);
            this.page_User.Controls.Add(this.dgv_FingerData);
            this.page_User.Controls.Add(this.tbx_FaceData);
            this.page_User.Controls.Add(this.tbx_Fingers);
            this.page_User.Controls.Add(this.tbx_PWD);
            this.page_User.Controls.Add(this.tbx_Card);
            this.page_User.Controls.Add(this.tbx_Name);
            this.page_User.Controls.Add(this.tbx_UserID);
            this.page_User.Controls.Add(this.btn_GetUserQRcode);
            this.page_User.Controls.Add(this.btn_SetUserQRcode);
            this.page_User.Controls.Add(this.btn_TakeOffManager);
            this.page_User.Controls.Add(this.btn_ExitRemoteEnroll);
            this.page_User.Controls.Add(this.btn_RemoteEnroll);
            this.page_User.Controls.Add(this.btn_SetUserFace);
            this.page_User.Controls.Add(this.btn_GetUserFace);
            this.page_User.Controls.Add(this.btn_SetUserFinger);
            this.page_User.Controls.Add(this.btn_GetUserFinger);
            this.page_User.Controls.Add(this.btn_SetUserPhoto);
            this.page_User.Controls.Add(this.btn_GetUserPhoto);
            this.page_User.Controls.Add(this.btn_GetUserCard);
            this.page_User.Controls.Add(this.btn_GetUserPassword);
            this.page_User.Controls.Add(this.btn_SetUserData);
            this.page_User.Controls.Add(this.btn_GetUserData);
            this.page_User.Controls.Add(this.btn_GetUserSampleInfo);
            this.page_User.Controls.Add(this.btn_GetUserAllInfo);
            this.page_User.Location = new System.Drawing.Point(4, 22);
            this.page_User.Name = "page_User";
            this.page_User.Padding = new System.Windows.Forms.Padding(3);
            this.page_User.Size = new System.Drawing.Size(533, 655);
            this.page_User.TabIndex = 0;
            this.page_User.Text = "User";
            this.page_User.UseVisualStyleBackColor = true;
            // 
            // btn_IdantifyCard
            // 
            this.btn_IdantifyCard.Location = new System.Drawing.Point(393, 611);
            this.btn_IdantifyCard.Name = "btn_IdantifyCard";
            this.btn_IdantifyCard.Size = new System.Drawing.Size(134, 36);
            this.btn_IdantifyCard.TabIndex = 71;
            this.btn_IdantifyCard.Text = "Open the ID Card";
            this.btn_IdantifyCard.UseVisualStyleBackColor = true;
            this.btn_IdantifyCard.Click += new System.EventHandler(this.btn_IdantifyCard_Click);
            // 
            // btn_SetUserSampleInfo
            // 
            this.btn_SetUserSampleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetUserSampleInfo.Location = new System.Drawing.Point(6, 99);
            this.btn_SetUserSampleInfo.Name = "btn_SetUserSampleInfo";
            this.btn_SetUserSampleInfo.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserSampleInfo.TabIndex = 70;
            this.btn_SetUserSampleInfo.Text = "SetUserSampleInfo";
            this.btn_SetUserSampleInfo.UseVisualStyleBackColor = false;
            this.btn_SetUserSampleInfo.Click += new System.EventHandler(this.btn_SetUserSampleInfo_Click);
            // 
            // lbl_AllUserID
            // 
            this.lbl_AllUserID.AutoSize = true;
            this.lbl_AllUserID.Location = new System.Drawing.Point(176, 16);
            this.lbl_AllUserID.Name = "lbl_AllUserID";
            this.lbl_AllUserID.Size = new System.Drawing.Size(65, 12);
            this.lbl_AllUserID.TabIndex = 69;
            this.lbl_AllUserID.Text = "AllUserID:";
            // 
            // tbx_AllUserID
            // 
            this.tbx_AllUserID.Location = new System.Drawing.Point(241, 13);
            this.tbx_AllUserID.Name = "tbx_AllUserID";
            this.tbx_AllUserID.Size = new System.Drawing.Size(284, 21);
            this.tbx_AllUserID.TabIndex = 68;
            // 
            // lbl_Set_Type
            // 
            this.lbl_Set_Type.AutoSize = true;
            this.lbl_Set_Type.Location = new System.Drawing.Point(176, 48);
            this.lbl_Set_Type.Name = "lbl_Set_Type";
            this.lbl_Set_Type.Size = new System.Drawing.Size(59, 12);
            this.lbl_Set_Type.TabIndex = 67;
            this.lbl_Set_Type.Text = "Set_Type:";
            // 
            // btn_GetAllUserID
            // 
            this.btn_GetAllUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetAllUserID.Location = new System.Drawing.Point(6, 11);
            this.btn_GetAllUserID.Name = "btn_GetAllUserID";
            this.btn_GetAllUserID.Size = new System.Drawing.Size(150, 23);
            this.btn_GetAllUserID.TabIndex = 66;
            this.btn_GetAllUserID.Text = "GetAllUserID";
            this.btn_GetAllUserID.UseVisualStyleBackColor = false;
            this.btn_GetAllUserID.Click += new System.EventHandler(this.btn_GetAllUserID_Click);
            // 
            // tbx_antoSETcounts
            // 
            this.tbx_antoSETcounts.Location = new System.Drawing.Point(162, 613);
            this.tbx_antoSETcounts.Name = "tbx_antoSETcounts";
            this.tbx_antoSETcounts.Size = new System.Drawing.Size(113, 21);
            this.tbx_antoSETcounts.TabIndex = 65;
            this.tbx_antoSETcounts.Text = "100";
            // 
            // btn_antoSET
            // 
            this.btn_antoSET.Location = new System.Drawing.Point(6, 611);
            this.btn_antoSET.Name = "btn_antoSET";
            this.btn_antoSET.Size = new System.Drawing.Size(150, 23);
            this.btn_antoSET.TabIndex = 64;
            this.btn_antoSET.Text = "anto-SetUserData";
            this.btn_antoSET.UseVisualStyleBackColor = true;
            this.btn_antoSET.Click += new System.EventHandler(this.btn_antoSET_Click);
            // 
            // btn_GetNextSampleInfo
            // 
            this.btn_GetNextSampleInfo.Location = new System.Drawing.Point(241, 279);
            this.btn_GetNextSampleInfo.Name = "btn_GetNextSampleInfo";
            this.btn_GetNextSampleInfo.Size = new System.Drawing.Size(168, 23);
            this.btn_GetNextSampleInfo.TabIndex = 62;
            this.btn_GetNextSampleInfo.UseVisualStyleBackColor = true;
            this.btn_GetNextSampleInfo.Click += new System.EventHandler(this.btn_GetNextSampleInfo_Click);
            // 
            // cobx_userType
            // 
            this.cobx_userType.FormattingEnabled = true;
            this.cobx_userType.Location = new System.Drawing.Point(241, 45);
            this.cobx_userType.Name = "cobx_userType";
            this.cobx_userType.Size = new System.Drawing.Size(96, 20);
            this.cobx_userType.TabIndex = 61;
            // 
            // btn_saveFaceData
            // 
            this.btn_saveFaceData.Location = new System.Drawing.Point(172, 515);
            this.btn_saveFaceData.Name = "btn_saveFaceData";
            this.btn_saveFaceData.Size = new System.Drawing.Size(63, 23);
            this.btn_saveFaceData.TabIndex = 59;
            this.btn_saveFaceData.Text = "saveFace";
            this.btn_saveFaceData.UseVisualStyleBackColor = true;
            this.btn_saveFaceData.Click += new System.EventHandler(this.btn_saveFaceData_Click);
            // 
            // lbl_QRCode
            // 
            this.lbl_QRCode.AutoSize = true;
            this.lbl_QRCode.Location = new System.Drawing.Point(424, 250);
            this.lbl_QRCode.Name = "lbl_QRCode";
            this.lbl_QRCode.Size = new System.Drawing.Size(0, 12);
            this.lbl_QRCode.TabIndex = 58;
            // 
            // cobx_EnrollBackup
            // 
            this.cobx_EnrollBackup.FormattingEnabled = true;
            this.cobx_EnrollBackup.Location = new System.Drawing.Point(162, 575);
            this.cobx_EnrollBackup.Name = "cobx_EnrollBackup";
            this.cobx_EnrollBackup.Size = new System.Drawing.Size(113, 20);
            this.cobx_EnrollBackup.TabIndex = 57;
            // 
            // lbl_FingerNo
            // 
            this.lbl_FingerNo.AutoSize = true;
            this.lbl_FingerNo.Location = new System.Drawing.Point(176, 308);
            this.lbl_FingerNo.Name = "lbl_FingerNo";
            this.lbl_FingerNo.Size = new System.Drawing.Size(59, 12);
            this.lbl_FingerNo.TabIndex = 56;
            this.lbl_FingerNo.Text = "FingerNo:";
            // 
            // cobx_FingerNo
            // 
            this.cobx_FingerNo.FormattingEnabled = true;
            this.cobx_FingerNo.Location = new System.Drawing.Point(241, 305);
            this.cobx_FingerNo.Name = "cobx_FingerNo";
            this.cobx_FingerNo.Size = new System.Drawing.Size(168, 20);
            this.cobx_FingerNo.TabIndex = 55;
            // 
            // lbl_FaceData
            // 
            this.lbl_FaceData.AutoSize = true;
            this.lbl_FaceData.Location = new System.Drawing.Point(176, 499);
            this.lbl_FaceData.Name = "lbl_FaceData";
            this.lbl_FaceData.Size = new System.Drawing.Size(59, 12);
            this.lbl_FaceData.TabIndex = 54;
            this.lbl_FaceData.Text = "FaceData:";
            // 
            // lbl_FingerData
            // 
            this.lbl_FingerData.AutoSize = true;
            this.lbl_FingerData.Location = new System.Drawing.Point(164, 332);
            this.lbl_FingerData.Name = "lbl_FingerData";
            this.lbl_FingerData.Size = new System.Drawing.Size(71, 12);
            this.lbl_FingerData.TabIndex = 53;
            this.lbl_FingerData.Text = "FingerData:";
            // 
            // lbl_Fingers
            // 
            this.lbl_Fingers.AutoSize = true;
            this.lbl_Fingers.Location = new System.Drawing.Point(182, 239);
            this.lbl_Fingers.Name = "lbl_Fingers";
            this.lbl_Fingers.Size = new System.Drawing.Size(53, 12);
            this.lbl_Fingers.TabIndex = 52;
            this.lbl_Fingers.Text = "Fingers:";
            // 
            // lbl_PWD
            // 
            this.lbl_PWD.AutoSize = true;
            this.lbl_PWD.Location = new System.Drawing.Point(206, 212);
            this.lbl_PWD.Name = "lbl_PWD";
            this.lbl_PWD.Size = new System.Drawing.Size(29, 12);
            this.lbl_PWD.TabIndex = 51;
            this.lbl_PWD.Text = "PWD:";
            // 
            // lbl_Card
            // 
            this.lbl_Card.AutoSize = true;
            this.lbl_Card.Location = new System.Drawing.Point(200, 185);
            this.lbl_Card.Name = "lbl_Card";
            this.lbl_Card.Size = new System.Drawing.Size(35, 12);
            this.lbl_Card.TabIndex = 50;
            this.lbl_Card.Text = "Card:";
            // 
            // lbl_Depart
            // 
            this.lbl_Depart.AutoSize = true;
            this.lbl_Depart.Location = new System.Drawing.Point(188, 158);
            this.lbl_Depart.Name = "lbl_Depart";
            this.lbl_Depart.Size = new System.Drawing.Size(47, 12);
            this.lbl_Depart.TabIndex = 48;
            this.lbl_Depart.Text = "Depart:";
            // 
            // lbl_Privilege
            // 
            this.lbl_Privilege.AutoSize = true;
            this.lbl_Privilege.Location = new System.Drawing.Point(170, 133);
            this.lbl_Privilege.Name = "lbl_Privilege";
            this.lbl_Privilege.Size = new System.Drawing.Size(65, 12);
            this.lbl_Privilege.TabIndex = 47;
            this.lbl_Privilege.Text = "Privilege:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(200, 103);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 12);
            this.lbl_Name.TabIndex = 46;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(188, 73);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(47, 12);
            this.lbl_UserID.TabIndex = 45;
            this.lbl_UserID.Text = "UserID:";
            // 
            // pbx_UserQRCode
            // 
            this.pbx_UserQRCode.Location = new System.Drawing.Point(417, 203);
            this.pbx_UserQRCode.Name = "pbx_UserQRCode";
            this.pbx_UserQRCode.Size = new System.Drawing.Size(110, 110);
            this.pbx_UserQRCode.TabIndex = 44;
            this.pbx_UserQRCode.TabStop = false;
            // 
            // cbx_Enabled
            // 
            this.cbx_Enabled.AutoSize = true;
            this.cbx_Enabled.Location = new System.Drawing.Point(343, 49);
            this.cbx_Enabled.Name = "cbx_Enabled";
            this.cbx_Enabled.Size = new System.Drawing.Size(66, 16);
            this.cbx_Enabled.TabIndex = 32;
            this.cbx_Enabled.Text = "Enabled";
            this.cbx_Enabled.UseVisualStyleBackColor = true;
            // 
            // pbx_UserPhoto
            // 
            this.pbx_UserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_UserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbx_UserPhoto.Image")));
            this.pbx_UserPhoto.InitialImage = null;
            this.pbx_UserPhoto.Location = new System.Drawing.Point(417, 49);
            this.pbx_UserPhoto.Name = "pbx_UserPhoto";
            this.pbx_UserPhoto.Size = new System.Drawing.Size(110, 148);
            this.pbx_UserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_UserPhoto.TabIndex = 43;
            this.pbx_UserPhoto.TabStop = false;
            this.pbx_UserPhoto.Click += new System.EventHandler(this.pbx_UserPhoto_Click);
            // 
            // cbx_FaceEnroll
            // 
            this.cbx_FaceEnroll.AutoSize = true;
            this.cbx_FaceEnroll.Location = new System.Drawing.Point(241, 263);
            this.cbx_FaceEnroll.Name = "cbx_FaceEnroll";
            this.cbx_FaceEnroll.Size = new System.Drawing.Size(84, 16);
            this.cbx_FaceEnroll.TabIndex = 42;
            this.cbx_FaceEnroll.Text = "FaceEnroll";
            this.cbx_FaceEnroll.UseVisualStyleBackColor = true;
            // 
            // cobx_Depart_U
            // 
            this.cobx_Depart_U.FormattingEnabled = true;
            this.cobx_Depart_U.Location = new System.Drawing.Point(241, 155);
            this.cobx_Depart_U.Name = "cobx_Depart_U";
            this.cobx_Depart_U.Size = new System.Drawing.Size(168, 20);
            this.cobx_Depart_U.TabIndex = 41;
            // 
            // cobx_Privilege
            // 
            this.cobx_Privilege.FormattingEnabled = true;
            this.cobx_Privilege.Location = new System.Drawing.Point(241, 127);
            this.cobx_Privilege.Name = "cobx_Privilege";
            this.cobx_Privilege.Size = new System.Drawing.Size(168, 20);
            this.cobx_Privilege.TabIndex = 40;
            // 
            // dgv_FingerData
            // 
            this.dgv_FingerData.AllowUserToAddRows = false;
            this.dgv_FingerData.AllowUserToDeleteRows = false;
            this.dgv_FingerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FingerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FingerData_ID,
            this.FingerData_string,
            this.dgv_Duress,
            this.save});
            this.dgv_FingerData.Location = new System.Drawing.Point(241, 332);
            this.dgv_FingerData.Name = "dgv_FingerData";
            this.dgv_FingerData.ReadOnly = true;
            this.dgv_FingerData.RowTemplate.Height = 23;
            this.dgv_FingerData.Size = new System.Drawing.Size(284, 158);
            this.dgv_FingerData.TabIndex = 39;
            this.dgv_FingerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FingerData_CellContentClick);
            // 
            // FingerData_ID
            // 
            this.FingerData_ID.HeaderText = "ID";
            this.FingerData_ID.Name = "FingerData_ID";
            this.FingerData_ID.ReadOnly = true;
            this.FingerData_ID.Width = 40;
            // 
            // FingerData_string
            // 
            this.FingerData_string.HeaderText = "fingerData";
            this.FingerData_string.Name = "FingerData_string";
            this.FingerData_string.ReadOnly = true;
            this.FingerData_string.Width = 90;
            // 
            // dgv_Duress
            // 
            this.dgv_Duress.HeaderText = "Duress";
            this.dgv_Duress.Name = "dgv_Duress";
            this.dgv_Duress.ReadOnly = true;
            this.dgv_Duress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Duress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_Duress.Width = 50;
            // 
            // save
            // 
            this.save.HeaderText = "Save";
            this.save.Name = "save";
            this.save.ReadOnly = true;
            this.save.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.save.Width = 40;
            // 
            // tbx_FaceData
            // 
            this.tbx_FaceData.Location = new System.Drawing.Point(241, 496);
            this.tbx_FaceData.Multiline = true;
            this.tbx_FaceData.Name = "tbx_FaceData";
            this.tbx_FaceData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_FaceData.Size = new System.Drawing.Size(284, 71);
            this.tbx_FaceData.TabIndex = 38;
            // 
            // tbx_Fingers
            // 
            this.tbx_Fingers.Location = new System.Drawing.Point(241, 236);
            this.tbx_Fingers.Name = "tbx_Fingers";
            this.tbx_Fingers.Size = new System.Drawing.Size(168, 21);
            this.tbx_Fingers.TabIndex = 37;
            // 
            // tbx_PWD
            // 
            this.tbx_PWD.Location = new System.Drawing.Point(241, 209);
            this.tbx_PWD.Name = "tbx_PWD";
            this.tbx_PWD.Size = new System.Drawing.Size(168, 21);
            this.tbx_PWD.TabIndex = 34;
            // 
            // tbx_Card
            // 
            this.tbx_Card.Location = new System.Drawing.Point(241, 182);
            this.tbx_Card.Name = "tbx_Card";
            this.tbx_Card.Size = new System.Drawing.Size(168, 21);
            this.tbx_Card.TabIndex = 33;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(241, 100);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(168, 21);
            this.tbx_Name.TabIndex = 29;
            // 
            // tbx_UserID
            // 
            this.tbx_UserID.Location = new System.Drawing.Point(241, 72);
            this.tbx_UserID.Name = "tbx_UserID";
            this.tbx_UserID.Size = new System.Drawing.Size(168, 21);
            this.tbx_UserID.TabIndex = 20;
            this.tbx_UserID.Text = "1";
            // 
            // btn_GetUserQRcode
            // 
            this.btn_GetUserQRcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_GetUserQRcode.Location = new System.Drawing.Point(6, 420);
            this.btn_GetUserQRcode.Name = "btn_GetUserQRcode";
            this.btn_GetUserQRcode.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserQRcode.TabIndex = 19;
            this.btn_GetUserQRcode.Text = "GetUserQRcode";
            this.btn_GetUserQRcode.UseVisualStyleBackColor = false;
            this.btn_GetUserQRcode.Click += new System.EventHandler(this.btn_GetUserQRcode_Click);
            // 
            // btn_SetUserQRcode
            // 
            this.btn_SetUserQRcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_SetUserQRcode.Location = new System.Drawing.Point(6, 449);
            this.btn_SetUserQRcode.Name = "btn_SetUserQRcode";
            this.btn_SetUserQRcode.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserQRcode.TabIndex = 18;
            this.btn_SetUserQRcode.Text = "SetUserQRcode";
            this.btn_SetUserQRcode.UseVisualStyleBackColor = false;
            // 
            // btn_TakeOffManager
            // 
            this.btn_TakeOffManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TakeOffManager.Location = new System.Drawing.Point(6, 488);
            this.btn_TakeOffManager.Name = "btn_TakeOffManager";
            this.btn_TakeOffManager.Size = new System.Drawing.Size(150, 23);
            this.btn_TakeOffManager.TabIndex = 16;
            this.btn_TakeOffManager.Text = "TakeOffManager";
            this.btn_TakeOffManager.UseVisualStyleBackColor = false;
            this.btn_TakeOffManager.Click += new System.EventHandler(this.btn_TakeOffManager_Click);
            // 
            // btn_ExitRemoteEnroll
            // 
            this.btn_ExitRemoteEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ExitRemoteEnroll.Location = new System.Drawing.Point(6, 543);
            this.btn_ExitRemoteEnroll.Name = "btn_ExitRemoteEnroll";
            this.btn_ExitRemoteEnroll.Size = new System.Drawing.Size(150, 23);
            this.btn_ExitRemoteEnroll.TabIndex = 13;
            this.btn_ExitRemoteEnroll.Text = "ExitRemoteEnroll";
            this.btn_ExitRemoteEnroll.UseVisualStyleBackColor = false;
            this.btn_ExitRemoteEnroll.Click += new System.EventHandler(this.btn_ExitRemoteEnroll_Click);
            // 
            // btn_RemoteEnroll
            // 
            this.btn_RemoteEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_RemoteEnroll.Location = new System.Drawing.Point(6, 572);
            this.btn_RemoteEnroll.Name = "btn_RemoteEnroll";
            this.btn_RemoteEnroll.Size = new System.Drawing.Size(150, 23);
            this.btn_RemoteEnroll.TabIndex = 12;
            this.btn_RemoteEnroll.Text = "RemoteEnroll";
            this.btn_RemoteEnroll.UseVisualStyleBackColor = false;
            this.btn_RemoteEnroll.Click += new System.EventHandler(this.btn_RemoteEnroll_Click);
            // 
            // btn_SetUserFace
            // 
            this.btn_SetUserFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetUserFace.Location = new System.Drawing.Point(6, 391);
            this.btn_SetUserFace.Name = "btn_SetUserFace";
            this.btn_SetUserFace.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserFace.TabIndex = 11;
            this.btn_SetUserFace.Text = "SetUserFace";
            this.btn_SetUserFace.UseVisualStyleBackColor = false;
            this.btn_SetUserFace.Click += new System.EventHandler(this.btn_SetUserFace_Click);
            // 
            // btn_GetUserFace
            // 
            this.btn_GetUserFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserFace.Location = new System.Drawing.Point(6, 362);
            this.btn_GetUserFace.Name = "btn_GetUserFace";
            this.btn_GetUserFace.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserFace.TabIndex = 10;
            this.btn_GetUserFace.Text = "GetUserFace";
            this.btn_GetUserFace.UseVisualStyleBackColor = false;
            this.btn_GetUserFace.Click += new System.EventHandler(this.btn_GetUserFace_Click);
            // 
            // btn_SetUserFinger
            // 
            this.btn_SetUserFinger.BackColor = System.Drawing.Color.Yellow;
            this.btn_SetUserFinger.Location = new System.Drawing.Point(6, 333);
            this.btn_SetUserFinger.Name = "btn_SetUserFinger";
            this.btn_SetUserFinger.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserFinger.TabIndex = 9;
            this.btn_SetUserFinger.Text = "SetUserFinger";
            this.btn_SetUserFinger.UseVisualStyleBackColor = false;
            this.btn_SetUserFinger.Click += new System.EventHandler(this.btn_SetUserFinger_Click);
            // 
            // btn_GetUserFinger
            // 
            this.btn_GetUserFinger.BackColor = System.Drawing.Color.Yellow;
            this.btn_GetUserFinger.Location = new System.Drawing.Point(6, 304);
            this.btn_GetUserFinger.Name = "btn_GetUserFinger";
            this.btn_GetUserFinger.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserFinger.TabIndex = 8;
            this.btn_GetUserFinger.Text = "GetUserFinger";
            this.btn_GetUserFinger.UseVisualStyleBackColor = false;
            this.btn_GetUserFinger.Click += new System.EventHandler(this.btn_GetUserFinger_Click);
            // 
            // btn_SetUserPhoto
            // 
            this.btn_SetUserPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetUserPhoto.Location = new System.Drawing.Point(6, 275);
            this.btn_SetUserPhoto.Name = "btn_SetUserPhoto";
            this.btn_SetUserPhoto.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserPhoto.TabIndex = 7;
            this.btn_SetUserPhoto.Text = "SetUserPhoto";
            this.btn_SetUserPhoto.UseVisualStyleBackColor = false;
            this.btn_SetUserPhoto.Click += new System.EventHandler(this.btn_SetUserPhoto_Click);
            // 
            // btn_GetUserPhoto
            // 
            this.btn_GetUserPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserPhoto.Location = new System.Drawing.Point(6, 246);
            this.btn_GetUserPhoto.Name = "btn_GetUserPhoto";
            this.btn_GetUserPhoto.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserPhoto.TabIndex = 6;
            this.btn_GetUserPhoto.Text = "GetUserPhoto";
            this.btn_GetUserPhoto.UseVisualStyleBackColor = false;
            this.btn_GetUserPhoto.Click += new System.EventHandler(this.btn_GetUserPhoto_Click);
            // 
            // btn_GetUserCard
            // 
            this.btn_GetUserCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserCard.Location = new System.Drawing.Point(6, 217);
            this.btn_GetUserCard.Name = "btn_GetUserCard";
            this.btn_GetUserCard.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserCard.TabIndex = 5;
            this.btn_GetUserCard.Text = "GetUserCard";
            this.btn_GetUserCard.UseVisualStyleBackColor = false;
            this.btn_GetUserCard.Click += new System.EventHandler(this.btn_GetUserCard_Click);
            // 
            // btn_GetUserPassword
            // 
            this.btn_GetUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserPassword.Location = new System.Drawing.Point(6, 188);
            this.btn_GetUserPassword.Name = "btn_GetUserPassword";
            this.btn_GetUserPassword.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserPassword.TabIndex = 4;
            this.btn_GetUserPassword.Text = "GetUserPassword";
            this.btn_GetUserPassword.UseVisualStyleBackColor = false;
            this.btn_GetUserPassword.Click += new System.EventHandler(this.btn_GetUserPassword_Click);
            // 
            // btn_SetUserData
            // 
            this.btn_SetUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetUserData.Location = new System.Drawing.Point(6, 159);
            this.btn_SetUserData.Name = "btn_SetUserData";
            this.btn_SetUserData.Size = new System.Drawing.Size(150, 23);
            this.btn_SetUserData.TabIndex = 3;
            this.btn_SetUserData.Text = "SetUserData";
            this.btn_SetUserData.UseVisualStyleBackColor = false;
            this.btn_SetUserData.Click += new System.EventHandler(this.btn_SetUserData_Click);
            // 
            // btn_GetUserData
            // 
            this.btn_GetUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserData.Location = new System.Drawing.Point(6, 130);
            this.btn_GetUserData.Name = "btn_GetUserData";
            this.btn_GetUserData.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserData.TabIndex = 2;
            this.btn_GetUserData.Text = "GetUserData";
            this.btn_GetUserData.UseVisualStyleBackColor = false;
            this.btn_GetUserData.Click += new System.EventHandler(this.btn_GetUserData_Click);
            // 
            // btn_GetUserSampleInfo
            // 
            this.btn_GetUserSampleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserSampleInfo.Location = new System.Drawing.Point(6, 70);
            this.btn_GetUserSampleInfo.Name = "btn_GetUserSampleInfo";
            this.btn_GetUserSampleInfo.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserSampleInfo.TabIndex = 1;
            this.btn_GetUserSampleInfo.Text = "GetUserSampleInfo";
            this.btn_GetUserSampleInfo.UseVisualStyleBackColor = false;
            this.btn_GetUserSampleInfo.Click += new System.EventHandler(this.btn_GetUserSampleInfo_Click);
            // 
            // btn_GetUserAllInfo
            // 
            this.btn_GetUserAllInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetUserAllInfo.Location = new System.Drawing.Point(6, 41);
            this.btn_GetUserAllInfo.Name = "btn_GetUserAllInfo";
            this.btn_GetUserAllInfo.Size = new System.Drawing.Size(150, 23);
            this.btn_GetUserAllInfo.TabIndex = 0;
            this.btn_GetUserAllInfo.Text = "GetUserAllInfo";
            this.btn_GetUserAllInfo.UseVisualStyleBackColor = false;
            this.btn_GetUserAllInfo.Click += new System.EventHandler(this.btn_GetUserAllInfo_Click);
            // 
            // tbx_Response
            // 
            this.tbx_Response.Location = new System.Drawing.Point(559, 634);
            this.tbx_Response.Name = "tbx_Response";
            this.tbx_Response.Size = new System.Drawing.Size(98, 21);
            this.tbx_Response.TabIndex = 28;
            this.tbx_Response.Text = "Response";
            // 
            // tbx_Action_ext
            // 
            this.tbx_Action_ext.Location = new System.Drawing.Point(559, 690);
            this.tbx_Action_ext.Name = "tbx_Action_ext";
            this.tbx_Action_ext.Size = new System.Drawing.Size(98, 21);
            this.tbx_Action_ext.TabIndex = 27;
            this.tbx_Action_ext.Text = "Action_ext";
            // 
            // tbx_Version
            // 
            this.tbx_Version.Location = new System.Drawing.Point(775, 690);
            this.tbx_Version.Name = "tbx_Version";
            this.tbx_Version.Size = new System.Drawing.Size(98, 21);
            this.tbx_Version.TabIndex = 26;
            this.tbx_Version.Text = "Version";
            // 
            // tbx_DeviceSerialNo
            // 
            this.tbx_DeviceSerialNo.Location = new System.Drawing.Point(668, 634);
            this.tbx_DeviceSerialNo.Name = "tbx_DeviceSerialNo";
            this.tbx_DeviceSerialNo.Size = new System.Drawing.Size(205, 21);
            this.tbx_DeviceSerialNo.TabIndex = 25;
            this.tbx_DeviceSerialNo.Text = "DeviceSerialNo";
            // 
            // tbx_TerminalID
            // 
            this.tbx_TerminalID.Location = new System.Drawing.Point(667, 690);
            this.tbx_TerminalID.Name = "tbx_TerminalID";
            this.tbx_TerminalID.Size = new System.Drawing.Size(98, 21);
            this.tbx_TerminalID.TabIndex = 24;
            this.tbx_TerminalID.Text = "TerminalID";
            // 
            // tbx_HardwareVer
            // 
            this.tbx_HardwareVer.Location = new System.Drawing.Point(775, 661);
            this.tbx_HardwareVer.Name = "tbx_HardwareVer";
            this.tbx_HardwareVer.Size = new System.Drawing.Size(96, 21);
            this.tbx_HardwareVer.TabIndex = 23;
            this.tbx_HardwareVer.Text = "HardwareVer";
            // 
            // tbx_TerminalType
            // 
            this.tbx_TerminalType.Location = new System.Drawing.Point(667, 660);
            this.tbx_TerminalType.Name = "tbx_TerminalType";
            this.tbx_TerminalType.Size = new System.Drawing.Size(98, 21);
            this.tbx_TerminalType.TabIndex = 22;
            this.tbx_TerminalType.Text = "TerminalType";
            // 
            // tbx_Actid
            // 
            this.tbx_Actid.Location = new System.Drawing.Point(559, 661);
            this.tbx_Actid.Name = "tbx_Actid";
            this.tbx_Actid.Size = new System.Drawing.Size(98, 21);
            this.tbx_Actid.TabIndex = 21;
            this.tbx_Actid.Text = "Actid";
            // 
            // page
            // 
            this.page.Controls.Add(this.page_User);
            this.page.Controls.Add(this.page_Basic);
            this.page.Controls.Add(this.page_Advance);
            this.page.Controls.Add(this.page_Net);
            this.page.Controls.Add(this.page_Data);
            this.page.Controls.Add(this.page_Att);
            this.page.Controls.Add(this.page_Access);
            this.page.Controls.Add(this.page_Info);
            this.page.ItemSize = new System.Drawing.Size(60, 18);
            this.page.Location = new System.Drawing.Point(12, 37);
            this.page.Name = "page";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(541, 681);
            this.page.TabIndex = 1;
            // 
            // page_Info
            // 
            this.page_Info.Controls.Add(this.lbl_HardwareVersion);
            this.page_Info.Controls.Add(this.lbl_FirmwareVersion);
            this.page_Info.Controls.Add(this.lbl_DeviceSerialNo);
            this.page_Info.Controls.Add(this.tbx_HardwareVer_info);
            this.page_Info.Controls.Add(this.tbx_FirmwareVersion_info);
            this.page_Info.Controls.Add(this.tbx_DeviceSerialNo_info);
            this.page_Info.Controls.Add(this.lbl_Manufacturer);
            this.page_Info.Controls.Add(this.lbl_ProductName);
            this.page_Info.Controls.Add(this.lbl_ReleasedTime);
            this.page_Info.Controls.Add(this.tbx_Manufacturer);
            this.page_Info.Controls.Add(this.tbx_ProductName);
            this.page_Info.Controls.Add(this.tbx_ReleasedTime);
            this.page_Info.Controls.Add(this.lbl_PhotoLogCount);
            this.page_Info.Controls.Add(this.lbl_ManageLogCount);
            this.page_Info.Controls.Add(this.lbl_TimeLogCount);
            this.page_Info.Controls.Add(this.lbl_PwdCount);
            this.page_Info.Controls.Add(this.lbl_CardCount);
            this.page_Info.Controls.Add(this.lbl_FpCount);
            this.page_Info.Controls.Add(this.lbl_FaceCount);
            this.page_Info.Controls.Add(this.lbl_UserCount);
            this.page_Info.Controls.Add(this.lbl_ManagerCount);
            this.page_Info.Controls.Add(this.tbx_PhotoLogCount_s);
            this.page_Info.Controls.Add(this.tbx_PhotoLogCount_u);
            this.page_Info.Controls.Add(this.tbx_PhotoLogCount_t);
            this.page_Info.Controls.Add(this.tbx_ManageLogCount_s);
            this.page_Info.Controls.Add(this.tbx_ManageLogCount_u);
            this.page_Info.Controls.Add(this.tbx_ManageLogCount_t);
            this.page_Info.Controls.Add(this.tbx_TimeLogCount_s);
            this.page_Info.Controls.Add(this.tbx_TimeLogCount_u);
            this.page_Info.Controls.Add(this.tbx_TimeLogCount_t);
            this.page_Info.Controls.Add(this.tbx_PwdCount_u);
            this.page_Info.Controls.Add(this.tbx_PwdCount_t);
            this.page_Info.Controls.Add(this.tbx_CardCount_u);
            this.page_Info.Controls.Add(this.tbx_CardCount_t);
            this.page_Info.Controls.Add(this.tbx_FpCount_u);
            this.page_Info.Controls.Add(this.tbx_FpCount_t);
            this.page_Info.Controls.Add(this.tbx_FaceCount_u);
            this.page_Info.Controls.Add(this.tbx_FaceCount_t);
            this.page_Info.Controls.Add(this.tbx_UserCount_u);
            this.page_Info.Controls.Add(this.tbx_UserCount_t);
            this.page_Info.Controls.Add(this.tbx_ManagerCount_u);
            this.page_Info.Controls.Add(this.tbx_ManagerCount_t);
            this.page_Info.Controls.Add(this.lbl_TotalStore);
            this.page_Info.Controls.Add(this.lbl_UseStore);
            this.page_Info.Controls.Add(this.lbl_UnSendStore);
            this.page_Info.Controls.Add(this.btn_GetStoreStatus);
            this.page_Info.Controls.Add(this.btn_GetDeviceInfo);
            this.page_Info.Location = new System.Drawing.Point(4, 22);
            this.page_Info.Name = "page_Info";
            this.page_Info.Padding = new System.Windows.Forms.Padding(3);
            this.page_Info.Size = new System.Drawing.Size(533, 655);
            this.page_Info.TabIndex = 7;
            this.page_Info.Text = "Info";
            this.page_Info.UseVisualStyleBackColor = true;
            // 
            // lbl_HardwareVersion
            // 
            this.lbl_HardwareVersion.AutoSize = true;
            this.lbl_HardwareVersion.Location = new System.Drawing.Point(171, 489);
            this.lbl_HardwareVersion.Name = "lbl_HardwareVersion";
            this.lbl_HardwareVersion.Size = new System.Drawing.Size(101, 12);
            this.lbl_HardwareVersion.TabIndex = 85;
            this.lbl_HardwareVersion.Text = "HardwareVersion:";
            // 
            // lbl_FirmwareVersion
            // 
            this.lbl_FirmwareVersion.AutoSize = true;
            this.lbl_FirmwareVersion.Location = new System.Drawing.Point(171, 462);
            this.lbl_FirmwareVersion.Name = "lbl_FirmwareVersion";
            this.lbl_FirmwareVersion.Size = new System.Drawing.Size(101, 12);
            this.lbl_FirmwareVersion.TabIndex = 84;
            this.lbl_FirmwareVersion.Text = "FirmwareVersion:";
            // 
            // lbl_DeviceSerialNo
            // 
            this.lbl_DeviceSerialNo.AutoSize = true;
            this.lbl_DeviceSerialNo.Location = new System.Drawing.Point(177, 435);
            this.lbl_DeviceSerialNo.Name = "lbl_DeviceSerialNo";
            this.lbl_DeviceSerialNo.Size = new System.Drawing.Size(95, 12);
            this.lbl_DeviceSerialNo.TabIndex = 83;
            this.lbl_DeviceSerialNo.Text = "DeviceSerialNo:";
            // 
            // tbx_HardwareVer_info
            // 
            this.tbx_HardwareVer_info.Location = new System.Drawing.Point(278, 486);
            this.tbx_HardwareVer_info.Name = "tbx_HardwareVer_info";
            this.tbx_HardwareVer_info.Size = new System.Drawing.Size(144, 21);
            this.tbx_HardwareVer_info.TabIndex = 82;
            // 
            // tbx_FirmwareVersion_info
            // 
            this.tbx_FirmwareVersion_info.Location = new System.Drawing.Point(278, 459);
            this.tbx_FirmwareVersion_info.Name = "tbx_FirmwareVersion_info";
            this.tbx_FirmwareVersion_info.Size = new System.Drawing.Size(144, 21);
            this.tbx_FirmwareVersion_info.TabIndex = 81;
            // 
            // tbx_DeviceSerialNo_info
            // 
            this.tbx_DeviceSerialNo_info.Location = new System.Drawing.Point(278, 432);
            this.tbx_DeviceSerialNo_info.Name = "tbx_DeviceSerialNo_info";
            this.tbx_DeviceSerialNo_info.Size = new System.Drawing.Size(144, 21);
            this.tbx_DeviceSerialNo_info.TabIndex = 80;
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(189, 408);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(83, 12);
            this.lbl_Manufacturer.TabIndex = 79;
            this.lbl_Manufacturer.Text = "Manufacturer:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(195, 381);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(77, 12);
            this.lbl_ProductName.TabIndex = 78;
            this.lbl_ProductName.Text = "ProductName:";
            // 
            // lbl_ReleasedTime
            // 
            this.lbl_ReleasedTime.AutoSize = true;
            this.lbl_ReleasedTime.Location = new System.Drawing.Point(189, 352);
            this.lbl_ReleasedTime.Name = "lbl_ReleasedTime";
            this.lbl_ReleasedTime.Size = new System.Drawing.Size(83, 12);
            this.lbl_ReleasedTime.TabIndex = 77;
            this.lbl_ReleasedTime.Text = "ReleasedTime:";
            // 
            // tbx_Manufacturer
            // 
            this.tbx_Manufacturer.Location = new System.Drawing.Point(278, 405);
            this.tbx_Manufacturer.Name = "tbx_Manufacturer";
            this.tbx_Manufacturer.Size = new System.Drawing.Size(144, 21);
            this.tbx_Manufacturer.TabIndex = 76;
            // 
            // tbx_ProductName
            // 
            this.tbx_ProductName.Location = new System.Drawing.Point(278, 378);
            this.tbx_ProductName.Name = "tbx_ProductName";
            this.tbx_ProductName.Size = new System.Drawing.Size(144, 21);
            this.tbx_ProductName.TabIndex = 75;
            // 
            // tbx_ReleasedTime
            // 
            this.tbx_ReleasedTime.Location = new System.Drawing.Point(278, 349);
            this.tbx_ReleasedTime.Name = "tbx_ReleasedTime";
            this.tbx_ReleasedTime.Size = new System.Drawing.Size(144, 21);
            this.tbx_ReleasedTime.TabIndex = 74;
            // 
            // lbl_PhotoLogCount
            // 
            this.lbl_PhotoLogCount.AutoSize = true;
            this.lbl_PhotoLogCount.Location = new System.Drawing.Point(183, 268);
            this.lbl_PhotoLogCount.Name = "lbl_PhotoLogCount";
            this.lbl_PhotoLogCount.Size = new System.Drawing.Size(89, 12);
            this.lbl_PhotoLogCount.TabIndex = 73;
            this.lbl_PhotoLogCount.Text = "PhotoLogCount:";
            // 
            // lbl_ManageLogCount
            // 
            this.lbl_ManageLogCount.AutoSize = true;
            this.lbl_ManageLogCount.Location = new System.Drawing.Point(177, 244);
            this.lbl_ManageLogCount.Name = "lbl_ManageLogCount";
            this.lbl_ManageLogCount.Size = new System.Drawing.Size(95, 12);
            this.lbl_ManageLogCount.TabIndex = 72;
            this.lbl_ManageLogCount.Text = "ManageLogCount:";
            // 
            // lbl_TimeLogCount
            // 
            this.lbl_TimeLogCount.AutoSize = true;
            this.lbl_TimeLogCount.Location = new System.Drawing.Point(189, 217);
            this.lbl_TimeLogCount.Name = "lbl_TimeLogCount";
            this.lbl_TimeLogCount.Size = new System.Drawing.Size(83, 12);
            this.lbl_TimeLogCount.TabIndex = 71;
            this.lbl_TimeLogCount.Text = "TimeLogCount:";
            // 
            // lbl_PwdCount
            // 
            this.lbl_PwdCount.AutoSize = true;
            this.lbl_PwdCount.Location = new System.Drawing.Point(213, 188);
            this.lbl_PwdCount.Name = "lbl_PwdCount";
            this.lbl_PwdCount.Size = new System.Drawing.Size(59, 12);
            this.lbl_PwdCount.TabIndex = 70;
            this.lbl_PwdCount.Text = "PwdCount:";
            // 
            // lbl_CardCount
            // 
            this.lbl_CardCount.AutoSize = true;
            this.lbl_CardCount.Location = new System.Drawing.Point(207, 162);
            this.lbl_CardCount.Name = "lbl_CardCount";
            this.lbl_CardCount.Size = new System.Drawing.Size(65, 12);
            this.lbl_CardCount.TabIndex = 69;
            this.lbl_CardCount.Text = "CardCount:";
            // 
            // lbl_FpCount
            // 
            this.lbl_FpCount.AutoSize = true;
            this.lbl_FpCount.Location = new System.Drawing.Point(219, 135);
            this.lbl_FpCount.Name = "lbl_FpCount";
            this.lbl_FpCount.Size = new System.Drawing.Size(53, 12);
            this.lbl_FpCount.TabIndex = 68;
            this.lbl_FpCount.Text = "FpCount:";
            // 
            // lbl_FaceCount
            // 
            this.lbl_FaceCount.AutoSize = true;
            this.lbl_FaceCount.Location = new System.Drawing.Point(207, 105);
            this.lbl_FaceCount.Name = "lbl_FaceCount";
            this.lbl_FaceCount.Size = new System.Drawing.Size(65, 12);
            this.lbl_FaceCount.TabIndex = 67;
            this.lbl_FaceCount.Text = "FaceCount:";
            // 
            // lbl_UserCount
            // 
            this.lbl_UserCount.AutoSize = true;
            this.lbl_UserCount.Location = new System.Drawing.Point(207, 78);
            this.lbl_UserCount.Name = "lbl_UserCount";
            this.lbl_UserCount.Size = new System.Drawing.Size(65, 12);
            this.lbl_UserCount.TabIndex = 66;
            this.lbl_UserCount.Text = "UserCount:";
            // 
            // lbl_ManagerCount
            // 
            this.lbl_ManagerCount.AutoSize = true;
            this.lbl_ManagerCount.Location = new System.Drawing.Point(189, 52);
            this.lbl_ManagerCount.Name = "lbl_ManagerCount";
            this.lbl_ManagerCount.Size = new System.Drawing.Size(83, 12);
            this.lbl_ManagerCount.TabIndex = 65;
            this.lbl_ManagerCount.Text = "ManagerCount:";
            // 
            // tbx_PhotoLogCount_s
            // 
            this.tbx_PhotoLogCount_s.Location = new System.Drawing.Point(428, 268);
            this.tbx_PhotoLogCount_s.Name = "tbx_PhotoLogCount_s";
            this.tbx_PhotoLogCount_s.Size = new System.Drawing.Size(69, 21);
            this.tbx_PhotoLogCount_s.TabIndex = 64;
            // 
            // tbx_PhotoLogCount_u
            // 
            this.tbx_PhotoLogCount_u.Location = new System.Drawing.Point(353, 268);
            this.tbx_PhotoLogCount_u.Name = "tbx_PhotoLogCount_u";
            this.tbx_PhotoLogCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_PhotoLogCount_u.TabIndex = 63;
            // 
            // tbx_PhotoLogCount_t
            // 
            this.tbx_PhotoLogCount_t.Location = new System.Drawing.Point(278, 268);
            this.tbx_PhotoLogCount_t.Name = "tbx_PhotoLogCount_t";
            this.tbx_PhotoLogCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_PhotoLogCount_t.TabIndex = 62;
            // 
            // tbx_ManageLogCount_s
            // 
            this.tbx_ManageLogCount_s.Location = new System.Drawing.Point(428, 241);
            this.tbx_ManageLogCount_s.Name = "tbx_ManageLogCount_s";
            this.tbx_ManageLogCount_s.Size = new System.Drawing.Size(69, 21);
            this.tbx_ManageLogCount_s.TabIndex = 61;
            // 
            // tbx_ManageLogCount_u
            // 
            this.tbx_ManageLogCount_u.Location = new System.Drawing.Point(353, 241);
            this.tbx_ManageLogCount_u.Name = "tbx_ManageLogCount_u";
            this.tbx_ManageLogCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_ManageLogCount_u.TabIndex = 60;
            // 
            // tbx_ManageLogCount_t
            // 
            this.tbx_ManageLogCount_t.Location = new System.Drawing.Point(278, 241);
            this.tbx_ManageLogCount_t.Name = "tbx_ManageLogCount_t";
            this.tbx_ManageLogCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_ManageLogCount_t.TabIndex = 59;
            // 
            // tbx_TimeLogCount_s
            // 
            this.tbx_TimeLogCount_s.Location = new System.Drawing.Point(428, 214);
            this.tbx_TimeLogCount_s.Name = "tbx_TimeLogCount_s";
            this.tbx_TimeLogCount_s.Size = new System.Drawing.Size(69, 21);
            this.tbx_TimeLogCount_s.TabIndex = 58;
            // 
            // tbx_TimeLogCount_u
            // 
            this.tbx_TimeLogCount_u.Location = new System.Drawing.Point(353, 214);
            this.tbx_TimeLogCount_u.Name = "tbx_TimeLogCount_u";
            this.tbx_TimeLogCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_TimeLogCount_u.TabIndex = 57;
            // 
            // tbx_TimeLogCount_t
            // 
            this.tbx_TimeLogCount_t.Location = new System.Drawing.Point(278, 214);
            this.tbx_TimeLogCount_t.Name = "tbx_TimeLogCount_t";
            this.tbx_TimeLogCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_TimeLogCount_t.TabIndex = 56;
            // 
            // tbx_PwdCount_u
            // 
            this.tbx_PwdCount_u.Location = new System.Drawing.Point(353, 186);
            this.tbx_PwdCount_u.Name = "tbx_PwdCount_u";
            this.tbx_PwdCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_PwdCount_u.TabIndex = 54;
            // 
            // tbx_PwdCount_t
            // 
            this.tbx_PwdCount_t.Location = new System.Drawing.Point(278, 186);
            this.tbx_PwdCount_t.Name = "tbx_PwdCount_t";
            this.tbx_PwdCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_PwdCount_t.TabIndex = 53;
            // 
            // tbx_CardCount_u
            // 
            this.tbx_CardCount_u.Location = new System.Drawing.Point(353, 159);
            this.tbx_CardCount_u.Name = "tbx_CardCount_u";
            this.tbx_CardCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_CardCount_u.TabIndex = 51;
            // 
            // tbx_CardCount_t
            // 
            this.tbx_CardCount_t.Location = new System.Drawing.Point(278, 159);
            this.tbx_CardCount_t.Name = "tbx_CardCount_t";
            this.tbx_CardCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_CardCount_t.TabIndex = 50;
            // 
            // tbx_FpCount_u
            // 
            this.tbx_FpCount_u.Location = new System.Drawing.Point(353, 132);
            this.tbx_FpCount_u.Name = "tbx_FpCount_u";
            this.tbx_FpCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_FpCount_u.TabIndex = 48;
            // 
            // tbx_FpCount_t
            // 
            this.tbx_FpCount_t.Location = new System.Drawing.Point(278, 132);
            this.tbx_FpCount_t.Name = "tbx_FpCount_t";
            this.tbx_FpCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_FpCount_t.TabIndex = 47;
            // 
            // tbx_FaceCount_u
            // 
            this.tbx_FaceCount_u.Location = new System.Drawing.Point(353, 105);
            this.tbx_FaceCount_u.Name = "tbx_FaceCount_u";
            this.tbx_FaceCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_FaceCount_u.TabIndex = 45;
            // 
            // tbx_FaceCount_t
            // 
            this.tbx_FaceCount_t.Location = new System.Drawing.Point(278, 105);
            this.tbx_FaceCount_t.Name = "tbx_FaceCount_t";
            this.tbx_FaceCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_FaceCount_t.TabIndex = 44;
            // 
            // tbx_UserCount_u
            // 
            this.tbx_UserCount_u.Location = new System.Drawing.Point(353, 78);
            this.tbx_UserCount_u.Name = "tbx_UserCount_u";
            this.tbx_UserCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_UserCount_u.TabIndex = 42;
            // 
            // tbx_UserCount_t
            // 
            this.tbx_UserCount_t.Location = new System.Drawing.Point(278, 78);
            this.tbx_UserCount_t.Name = "tbx_UserCount_t";
            this.tbx_UserCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_UserCount_t.TabIndex = 41;
            // 
            // tbx_ManagerCount_u
            // 
            this.tbx_ManagerCount_u.Location = new System.Drawing.Point(353, 49);
            this.tbx_ManagerCount_u.Name = "tbx_ManagerCount_u";
            this.tbx_ManagerCount_u.Size = new System.Drawing.Size(69, 21);
            this.tbx_ManagerCount_u.TabIndex = 39;
            // 
            // tbx_ManagerCount_t
            // 
            this.tbx_ManagerCount_t.Location = new System.Drawing.Point(278, 49);
            this.tbx_ManagerCount_t.Name = "tbx_ManagerCount_t";
            this.tbx_ManagerCount_t.Size = new System.Drawing.Size(69, 21);
            this.tbx_ManagerCount_t.TabIndex = 38;
            // 
            // lbl_TotalStore
            // 
            this.lbl_TotalStore.AutoSize = true;
            this.lbl_TotalStore.Location = new System.Drawing.Point(282, 27);
            this.lbl_TotalStore.Name = "lbl_TotalStore";
            this.lbl_TotalStore.Size = new System.Drawing.Size(65, 12);
            this.lbl_TotalStore.TabIndex = 37;
            this.lbl_TotalStore.Text = "TotalStore";
            // 
            // lbl_UseStore
            // 
            this.lbl_UseStore.AutoSize = true;
            this.lbl_UseStore.Location = new System.Drawing.Point(353, 27);
            this.lbl_UseStore.Name = "lbl_UseStore";
            this.lbl_UseStore.Size = new System.Drawing.Size(53, 12);
            this.lbl_UseStore.TabIndex = 36;
            this.lbl_UseStore.Text = "UseStore";
            // 
            // lbl_UnSendStore
            // 
            this.lbl_UnSendStore.AutoSize = true;
            this.lbl_UnSendStore.Location = new System.Drawing.Point(426, 27);
            this.lbl_UnSendStore.Name = "lbl_UnSendStore";
            this.lbl_UnSendStore.Size = new System.Drawing.Size(71, 12);
            this.lbl_UnSendStore.TabIndex = 35;
            this.lbl_UnSendStore.Text = "UnSendStore";
            // 
            // btn_GetStoreStatus
            // 
            this.btn_GetStoreStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetStoreStatus.Location = new System.Drawing.Point(6, 16);
            this.btn_GetStoreStatus.Name = "btn_GetStoreStatus";
            this.btn_GetStoreStatus.Size = new System.Drawing.Size(150, 23);
            this.btn_GetStoreStatus.TabIndex = 34;
            this.btn_GetStoreStatus.Text = "GetStoreStatus";
            this.btn_GetStoreStatus.UseVisualStyleBackColor = false;
            this.btn_GetStoreStatus.Click += new System.EventHandler(this.btn_GetStoreStatus_Click);
            // 
            // btn_GetDeviceInfo
            // 
            this.btn_GetDeviceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetDeviceInfo.Location = new System.Drawing.Point(6, 347);
            this.btn_GetDeviceInfo.Name = "btn_GetDeviceInfo";
            this.btn_GetDeviceInfo.Size = new System.Drawing.Size(150, 23);
            this.btn_GetDeviceInfo.TabIndex = 33;
            this.btn_GetDeviceInfo.Text = "GetDeviceInfo";
            this.btn_GetDeviceInfo.UseVisualStyleBackColor = false;
            this.btn_GetDeviceInfo.Click += new System.EventHandler(this.btn_GetDeviceInfo_Click);
            // 
            // tbx_MessageFormDevice
            // 
            this.tbx_MessageFormDevice.Location = new System.Drawing.Point(565, 294);
            this.tbx_MessageFormDevice.Multiline = true;
            this.tbx_MessageFormDevice.Name = "tbx_MessageFormDevice";
            this.tbx_MessageFormDevice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_MessageFormDevice.Size = new System.Drawing.Size(308, 334);
            this.tbx_MessageFormDevice.TabIndex = 2;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_msg.Location = new System.Drawing.Point(12, 7);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 27);
            this.lbl_msg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "server：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "device：";
            // 
            // btn_GetIdantifyCard
            // 
            this.btn_GetIdantifyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GetIdantifyCard.Location = new System.Drawing.Point(967, 401);
            this.btn_GetIdantifyCard.Name = "btn_GetIdantifyCard";
            this.btn_GetIdantifyCard.Size = new System.Drawing.Size(143, 33);
            this.btn_GetIdantifyCard.TabIndex = 92;
            this.btn_GetIdantifyCard.Text = "GetIdantifyCard";
            this.btn_GetIdantifyCard.UseVisualStyleBackColor = false;
            this.btn_GetIdantifyCard.Click += new System.EventHandler(this.btn_GetIdantifyCard_Click);
            // 
            // btn_SetIdantifyCard
            // 
            this.btn_SetIdantifyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SetIdantifyCard.Location = new System.Drawing.Point(1141, 401);
            this.btn_SetIdantifyCard.Name = "btn_SetIdantifyCard";
            this.btn_SetIdantifyCard.Size = new System.Drawing.Size(143, 33);
            this.btn_SetIdantifyCard.TabIndex = 91;
            this.btn_SetIdantifyCard.Text = "SetIdantifyCard";
            this.btn_SetIdantifyCard.UseVisualStyleBackColor = false;
            this.btn_SetIdantifyCard.Click += new System.EventHandler(this.btn_SetIdantifyCard_Click);
            // 
            // lbl_IDValidDate
            // 
            this.lbl_IDValidDate.AutoSize = true;
            this.lbl_IDValidDate.Location = new System.Drawing.Point(902, 367);
            this.lbl_IDValidDate.Name = "lbl_IDValidDate";
            this.lbl_IDValidDate.Size = new System.Drawing.Size(59, 12);
            this.lbl_IDValidDate.TabIndex = 90;
            this.lbl_IDValidDate.Text = "有效期限:";
            // 
            // tbx_IDValidDate
            // 
            this.tbx_IDValidDate.Location = new System.Drawing.Point(967, 362);
            this.tbx_IDValidDate.Name = "tbx_IDValidDate";
            this.tbx_IDValidDate.Size = new System.Drawing.Size(305, 21);
            this.tbx_IDValidDate.TabIndex = 89;
            // 
            // lbl_IDAuthority
            // 
            this.lbl_IDAuthority.AutoSize = true;
            this.lbl_IDAuthority.Location = new System.Drawing.Point(902, 338);
            this.lbl_IDAuthority.Name = "lbl_IDAuthority";
            this.lbl_IDAuthority.Size = new System.Drawing.Size(59, 12);
            this.lbl_IDAuthority.TabIndex = 88;
            this.lbl_IDAuthority.Text = "签发机关:";
            // 
            // tbx_IDAuthority
            // 
            this.tbx_IDAuthority.Location = new System.Drawing.Point(967, 335);
            this.tbx_IDAuthority.Name = "tbx_IDAuthority";
            this.tbx_IDAuthority.Size = new System.Drawing.Size(305, 21);
            this.tbx_IDAuthority.TabIndex = 87;
            // 
            // pbx_IDPhoto
            // 
            this.pbx_IDPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_IDPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbx_IDPhoto.Image")));
            this.pbx_IDPhoto.InitialImage = null;
            this.pbx_IDPhoto.Location = new System.Drawing.Point(1162, 83);
            this.pbx_IDPhoto.Name = "pbx_IDPhoto";
            this.pbx_IDPhoto.Size = new System.Drawing.Size(110, 151);
            this.pbx_IDPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_IDPhoto.TabIndex = 86;
            this.pbx_IDPhoto.TabStop = false;
            // 
            // lbl_IDAddress
            // 
            this.lbl_IDAddress.AutoSize = true;
            this.lbl_IDAddress.Location = new System.Drawing.Point(926, 187);
            this.lbl_IDAddress.Name = "lbl_IDAddress";
            this.lbl_IDAddress.Size = new System.Drawing.Size(35, 12);
            this.lbl_IDAddress.TabIndex = 85;
            this.lbl_IDAddress.Text = "住址:";
            // 
            // lbl_IDBirthday
            // 
            this.lbl_IDBirthday.AutoSize = true;
            this.lbl_IDBirthday.Location = new System.Drawing.Point(926, 152);
            this.lbl_IDBirthday.Name = "lbl_IDBirthday";
            this.lbl_IDBirthday.Size = new System.Drawing.Size(35, 12);
            this.lbl_IDBirthday.TabIndex = 84;
            this.lbl_IDBirthday.Text = "出生:";
            // 
            // lbl_IDNation
            // 
            this.lbl_IDNation.AutoSize = true;
            this.lbl_IDNation.Location = new System.Drawing.Point(1051, 120);
            this.lbl_IDNation.Name = "lbl_IDNation";
            this.lbl_IDNation.Size = new System.Drawing.Size(35, 12);
            this.lbl_IDNation.TabIndex = 83;
            this.lbl_IDNation.Text = "民族:";
            // 
            // lbl_IDGender
            // 
            this.lbl_IDGender.AutoSize = true;
            this.lbl_IDGender.Location = new System.Drawing.Point(926, 119);
            this.lbl_IDGender.Name = "lbl_IDGender";
            this.lbl_IDGender.Size = new System.Drawing.Size(35, 12);
            this.lbl_IDGender.TabIndex = 82;
            this.lbl_IDGender.Text = "性别:";
            // 
            // lbl_IDName
            // 
            this.lbl_IDName.AutoSize = true;
            this.lbl_IDName.Location = new System.Drawing.Point(926, 86);
            this.lbl_IDName.Name = "lbl_IDName";
            this.lbl_IDName.Size = new System.Drawing.Size(35, 12);
            this.lbl_IDName.TabIndex = 81;
            this.lbl_IDName.Text = "姓名:";
            // 
            // lbl_IDUserID
            // 
            this.lbl_IDUserID.AutoSize = true;
            this.lbl_IDUserID.Location = new System.Drawing.Point(884, 262);
            this.lbl_IDUserID.Name = "lbl_IDUserID";
            this.lbl_IDUserID.Size = new System.Drawing.Size(83, 12);
            this.lbl_IDUserID.TabIndex = 80;
            this.lbl_IDUserID.Text = "公民身份号码:";
            // 
            // cobx_IDGender
            // 
            this.cobx_IDGender.FormattingEnabled = true;
            this.cobx_IDGender.Location = new System.Drawing.Point(967, 117);
            this.cobx_IDGender.Name = "cobx_IDGender";
            this.cobx_IDGender.Size = new System.Drawing.Size(65, 20);
            this.cobx_IDGender.TabIndex = 79;
            // 
            // tbx_IDAddress
            // 
            this.tbx_IDAddress.Location = new System.Drawing.Point(967, 184);
            this.tbx_IDAddress.Multiline = true;
            this.tbx_IDAddress.Name = "tbx_IDAddress";
            this.tbx_IDAddress.Size = new System.Drawing.Size(182, 50);
            this.tbx_IDAddress.TabIndex = 78;
            // 
            // tbx_IDBirthday
            // 
            this.tbx_IDBirthday.Location = new System.Drawing.Point(967, 149);
            this.tbx_IDBirthday.Name = "tbx_IDBirthday";
            this.tbx_IDBirthday.Size = new System.Drawing.Size(182, 21);
            this.tbx_IDBirthday.TabIndex = 77;
            // 
            // tbx_IDNation
            // 
            this.tbx_IDNation.Location = new System.Drawing.Point(1092, 116);
            this.tbx_IDNation.Name = "tbx_IDNation";
            this.tbx_IDNation.Size = new System.Drawing.Size(57, 21);
            this.tbx_IDNation.TabIndex = 76;
            // 
            // tbx_IDName
            // 
            this.tbx_IDName.Location = new System.Drawing.Point(967, 83);
            this.tbx_IDName.Name = "tbx_IDName";
            this.tbx_IDName.Size = new System.Drawing.Size(182, 21);
            this.tbx_IDName.TabIndex = 75;
            // 
            // tbx_IDUserID
            // 
            this.tbx_IDUserID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_IDUserID.Location = new System.Drawing.Point(967, 250);
            this.tbx_IDUserID.Name = "tbx_IDUserID";
            this.tbx_IDUserID.Size = new System.Drawing.Size(305, 33);
            this.tbx_IDUserID.TabIndex = 74;
            // 
            // pbx_TakePhoto
            // 
            this.pbx_TakePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_TakePhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbx_TakePhoto.Image")));
            this.pbx_TakePhoto.InitialImage = null;
            this.pbx_TakePhoto.Location = new System.Drawing.Point(176, 501);
            this.pbx_TakePhoto.Name = "pbx_TakePhoto";
            this.pbx_TakePhoto.Size = new System.Drawing.Size(110, 148);
            this.pbx_TakePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_TakePhoto.TabIndex = 94;
            this.pbx_TakePhoto.TabStop = false;
            // 
            // btn_TakePhoto
            // 
            this.btn_TakePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TakePhoto.Location = new System.Drawing.Point(18, 472);
            this.btn_TakePhoto.Name = "btn_TakePhoto";
            this.btn_TakePhoto.Size = new System.Drawing.Size(150, 23);
            this.btn_TakePhoto.TabIndex = 93;
            this.btn_TakePhoto.Text = "TakePhoto";
            this.btn_TakePhoto.UseVisualStyleBackColor = false;
            this.btn_TakePhoto.Click += new System.EventHandler(this.btn_TakePhoto_Click);
            // 
            // cobx_Camera
            // 
            this.cobx_Camera.FormattingEnabled = true;
            this.cobx_Camera.Location = new System.Drawing.Point(176, 475);
            this.cobx_Camera.Name = "cobx_Camera";
            this.cobx_Camera.Size = new System.Drawing.Size(110, 20);
            this.cobx_Camera.TabIndex = 95;
            // 
            // deviceAPIOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 720);
            this.Controls.Add(this.btn_GetIdantifyCard);
            this.Controls.Add(this.btn_SetIdantifyCard);
            this.Controls.Add(this.lbl_IDValidDate);
            this.Controls.Add(this.tbx_IDValidDate);
            this.Controls.Add(this.lbl_IDAuthority);
            this.Controls.Add(this.tbx_IDAuthority);
            this.Controls.Add(this.pbx_IDPhoto);
            this.Controls.Add(this.lbl_IDAddress);
            this.Controls.Add(this.lbl_IDBirthday);
            this.Controls.Add(this.lbl_IDNation);
            this.Controls.Add(this.lbl_IDGender);
            this.Controls.Add(this.lbl_IDName);
            this.Controls.Add(this.lbl_IDUserID);
            this.Controls.Add(this.cobx_IDGender);
            this.Controls.Add(this.tbx_IDAddress);
            this.Controls.Add(this.tbx_IDBirthday);
            this.Controls.Add(this.tbx_IDNation);
            this.Controls.Add(this.tbx_IDName);
            this.Controls.Add(this.tbx_IDUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.tbx_MessageFormDevice);
            this.Controls.Add(this.tbx_MessageFormServer);
            this.Controls.Add(this.btn_SendToDevice);
            this.Controls.Add(this.page);
            this.Controls.Add(this.tbx_Version);
            this.Controls.Add(this.tbx_Actid);
            this.Controls.Add(this.tbx_TerminalType);
            this.Controls.Add(this.tbx_HardwareVer);
            this.Controls.Add(this.tbx_TerminalID);
            this.Controls.Add(this.tbx_Response);
            this.Controls.Add(this.tbx_Action_ext);
            this.Controls.Add(this.tbx_DeviceSerialNo);
            this.Name = "deviceAPIOperationForm";
            this.Text = "deviceAPIOperationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.deviceAPIOperationForm_FormClosing);
            this.Load += new System.EventHandler(this.deviceAPIOperationForm_Load);
            this.page_Access.ResumeLayout(false);
            this.page_Access.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccessList)).EndInit();
            this.page_Att.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceRule)).EndInit();
            this.page_Data.ResumeLayout(false);
            this.page_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_realtimePhoto_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttandanceLog)).EndInit();
            this.page_Net.ResumeLayout(false);
            this.page_Net.PerformLayout();
            this.page_Advance.ResumeLayout(false);
            this.page_Advance.PerformLayout();
            this.page_Basic.ResumeLayout(false);
            this.page_Basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BellSetting)).EndInit();
            this.page_User.ResumeLayout(false);
            this.page_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FingerData)).EndInit();
            this.page.ResumeLayout(false);
            this.page_Info.ResumeLayout(false);
            this.page_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_IDPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TakePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendToDevice;
        private System.Windows.Forms.TextBox tbx_MessageFormServer;
        private System.Windows.Forms.TabPage page_Access;
        private System.Windows.Forms.TabPage page_Att;
        private System.Windows.Forms.TabPage page_Data;
        private System.Windows.Forms.TabPage page_Net;
        private System.Windows.Forms.TabPage page_Advance;
        private System.Windows.Forms.TabPage page_Basic;
        private System.Windows.Forms.Button btn_EnableDevice;
        private System.Windows.Forms.Button btn_GetTime;
        private System.Windows.Forms.Button btn_SetTime;
        private System.Windows.Forms.Button btn_GetBellSetting;
        private System.Windows.Forms.Button btn_SetBellSetting;
        private System.Windows.Forms.Button btn_GetProxyName;
        private System.Windows.Forms.Button btn_SetProxyName;
        private System.Windows.Forms.Button btn_GetDepartment;
        private System.Windows.Forms.Button btn_SetDepartment;
        private System.Windows.Forms.TabPage page_User;
        private System.Windows.Forms.Button btn_GetUserQRcode;
        private System.Windows.Forms.Button btn_SetUserQRcode;
        private System.Windows.Forms.Button btn_TakeOffManager;
        private System.Windows.Forms.Button btn_ExitRemoteEnroll;
        private System.Windows.Forms.Button btn_RemoteEnroll;
        private System.Windows.Forms.Button btn_SetUserFace;
        private System.Windows.Forms.Button btn_GetUserFace;
        private System.Windows.Forms.Button btn_SetUserFinger;
        private System.Windows.Forms.Button btn_GetUserFinger;
        private System.Windows.Forms.Button btn_SetUserPhoto;
        private System.Windows.Forms.Button btn_GetUserPhoto;
        private System.Windows.Forms.Button btn_GetUserCard;
        private System.Windows.Forms.Button btn_GetUserPassword;
        private System.Windows.Forms.Button btn_SetUserData;
        private System.Windows.Forms.Button btn_GetUserData;
        private System.Windows.Forms.Button btn_GetUserSampleInfo;
        private System.Windows.Forms.Button btn_GetUserAllInfo;
        private System.Windows.Forms.TabControl page;
        private System.Windows.Forms.TabPage page_Info;
        private System.Windows.Forms.Button btn_RemoteOpen;
        private System.Windows.Forms.Button btn_GetAttendanceRule;
        private System.Windows.Forms.Button btn_SetLogSetting;
        private System.Windows.Forms.Button btn_GetNextAttLog;
        private System.Windows.Forms.Button btn_GetFirstAttLog;
        private System.Windows.Forms.Button btn_GetAttendanceLog;
        private System.Windows.Forms.Button btn_EmptyAllData;
        private System.Windows.Forms.Button btn_EmptyUserEnrollmentData;
        private System.Windows.Forms.Button btn_EmptyManageLog;
        private System.Windows.Forms.Button btn_EmptyTimeLog;
        private System.Windows.Forms.Button btn_SetStreamingServer;
        private System.Windows.Forms.Button btn_GetStreamingServer;
        private System.Windows.Forms.Button btn_SetCloudServer;
        private System.Windows.Forms.Button btn_GetCloudServer;
        private System.Windows.Forms.Button btn_GetLocalServer;
        private System.Windows.Forms.Button btn_SetLocalServer;
        private System.Windows.Forms.Button btn_GetGPS;
        private System.Windows.Forms.Button btn_SetVPNServer;
        private System.Windows.Forms.Button btn_GetVPNServer;
        private System.Windows.Forms.Button btn_SetMobileNetSetting;
        private System.Windows.Forms.Button btn_GetMobileNetSetting;
        private System.Windows.Forms.Button btn_SetWifiSetting;
        private System.Windows.Forms.Button btn_GetWifiSetting;
        private System.Windows.Forms.Button btn_SetEthernetSetting;
        private System.Windows.Forms.Button btn_GetEthernetSetting;
        private System.Windows.Forms.Button btn_FirmwareUpgradeByCloud;
        private System.Windows.Forms.Button btn_RestoreDevice;
        private System.Windows.Forms.Button btn_GetDeviceSetting;
        private System.Windows.Forms.Button btn_SetDeviceSetting;
        private System.Windows.Forms.Button btn_GetPowerSetting;
        private System.Windows.Forms.Button btn_SetPowerSetting;
        public System.Windows.Forms.TextBox tbx_UserID;
        private System.Windows.Forms.TextBox tbx_MessageFormDevice;
        private System.Windows.Forms.Button btn_GetStoreStatus;
        private System.Windows.Forms.Button btn_SetAttendanceRule;
        private System.Windows.Forms.Button btn_GetLogSetting;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_FirmwareAddress;
        private System.Windows.Forms.ComboBox cobx_RestoreAction;
        private System.Windows.Forms.ComboBox cobx_IdentifyMode;
        private System.Windows.Forms.ComboBox cobx_Volume;
        private System.Windows.Forms.ComboBox cobx_Language;
        private System.Windows.Forms.TextBox tbx_CloudAddress;
        private System.Windows.Forms.RadioButton rbtn_custmTime;
        private System.Windows.Forms.RadioButton rbtn_sysTime;
        private System.Windows.Forms.TextBox tbx_DepartName;
        private System.Windows.Forms.ComboBox cobx_Depart_B;
        private System.Windows.Forms.TextBox tbx_ProxyName;
        private System.Windows.Forms.ComboBox cobx_ProxyNo;
        private System.Windows.Forms.DataGridView dgv_BellSetting;
        private System.Windows.Forms.Button btn_SetAccessSetting;
        private System.Windows.Forms.Button btn_GetAccessSetting;
        private System.Windows.Forms.Button btn_AccessStatus;
        private System.Windows.Forms.TextBox tbx_SleepAfter;
        private System.Windows.Forms.Label lbl_EnableDevice;
        private System.Windows.Forms.TextBox tbx_FaceData;
        private System.Windows.Forms.TextBox tbx_Fingers;
        private System.Windows.Forms.TextBox tbx_PWD;
        private System.Windows.Forms.TextBox tbx_Card;
        private System.Windows.Forms.CheckBox cbx_Enabled;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_Response;
        private System.Windows.Forms.TextBox tbx_Action_ext;
        private System.Windows.Forms.TextBox tbx_Version;
        private System.Windows.Forms.TextBox tbx_DeviceSerialNo;
        private System.Windows.Forms.TextBox tbx_TerminalID;
        private System.Windows.Forms.TextBox tbx_HardwareVer;
        private System.Windows.Forms.TextBox tbx_TerminalType;
        private System.Windows.Forms.TextBox tbx_Actid;
        private System.Windows.Forms.DataGridView dgv_FingerData;
        private System.Windows.Forms.ComboBox cobx_Depart_U;
        private System.Windows.Forms.ComboBox cobx_Privilege;
        private System.Windows.Forms.CheckBox cbx_FaceEnroll;
        private System.Windows.Forms.PictureBox pbx_UserPhoto;
        private System.Windows.Forms.PictureBox pbx_UserQRCode;
        private System.Windows.Forms.Label lbl_Fingers;
        private System.Windows.Forms.Label lbl_PWD;
        private System.Windows.Forms.Label lbl_Card;
        private System.Windows.Forms.Label lbl_Depart;
        private System.Windows.Forms.Label lbl_Privilege;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_FaceData;
        private System.Windows.Forms.Label lbl_FingerData;
        private System.Windows.Forms.Label lbl_FingerNo;
        private System.Windows.Forms.ComboBox cobx_FingerNo;
        private System.Windows.Forms.ComboBox cobx_EnrollBackup;
        private System.Windows.Forms.Label lbl_QRCode;
        private System.Windows.Forms.OpenFileDialog OFD_SelectUserPhoto;
        private System.Windows.Forms.SaveFileDialog SFD_saveFingerData;
        private System.Windows.Forms.Button btn_saveFaceData;
        private System.Windows.Forms.OpenFileDialog OFD_SelectFingerData;
        private System.Windows.Forms.ComboBox cobx_userType;
        private System.Windows.Forms.Label lbl_GetDeviceTime;
        private System.Windows.Forms.DateTimePicker dtp_custTime;
        private System.Windows.Forms.Label lbl_DepartName;
        private System.Windows.Forms.Label lbl_DeptNo;
        private System.Windows.Forms.Label lbl_ProxyName;
        private System.Windows.Forms.Label lbl_ProxyNo;
        private System.Windows.Forms.CheckBox cbx_UseProxy;
        private System.Windows.Forms.Label lbl_IdentifyMode;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label lbl_SleepAfter;
        private System.Windows.Forms.Label lbl_RestartTime;
        private System.Windows.Forms.DateTimePicker dtp_RestartTime;
        private System.Windows.Forms.Label lbl_RestoreAction;
        private System.Windows.Forms.Label lbl_FirmwareAddress;
        private System.Windows.Forms.CheckBox cbx_RealTimePhoto;
        private System.Windows.Forms.CheckBox cbx_PowerKey;
        private System.Windows.Forms.CheckBox cbx_ScreenSaver;
        private System.Windows.Forms.Button btn_SetGPS;
        private System.Windows.Forms.TextBox tbx_DHCPGateway;
        private System.Windows.Forms.TextBox tbx_DHCPSubnet;
        private System.Windows.Forms.TextBox tbx_DHCPIP;
        private System.Windows.Forms.TextBox tbx_NetGateway;
        private System.Windows.Forms.TextBox tbx_NetSubnet;
        private System.Windows.Forms.TextBox tbx_NetIP;
        private System.Windows.Forms.Label lbl_MAC;
        private System.Windows.Forms.CheckBox cbx_DHCP;
        private System.Windows.Forms.TextBox tbx_TerminalPort;
        private System.Windows.Forms.TextBox tbx_TerminalPassword;
        private System.Windows.Forms.TextBox tbx_TerminalID_n;
        private System.Windows.Forms.TextBox tbx_StreamingAddress;
        private System.Windows.Forms.CheckBox cbx_UseGPS;
        private System.Windows.Forms.TextBox tbx_SatelliteCount;
        private System.Windows.Forms.TextBox tbx_Latitude;
        private System.Windows.Forms.TextBox tbx_Longitude;
        private System.Windows.Forms.CheckBox cbx_GPSAlive;
        private System.Windows.Forms.Label lbl_VPNIP;
        private System.Windows.Forms.TextBox tbx_VPNPwd;
        private System.Windows.Forms.TextBox tbx_VPNAccount;
        private System.Windows.Forms.TextBox tbx_VPNAddress;
        private System.Windows.Forms.Label lbl_Operator;
        private System.Windows.Forms.Label lbl_MobileIP;
        private System.Windows.Forms.CheckBox cbx_UseMobileNet;
        private System.Windows.Forms.TextBox tbx_Key;
        private System.Windows.Forms.TextBox tbx_SSID;
        private System.Windows.Forms.CheckBox cbx_useWIFI;
        private System.Windows.Forms.DataGridView dgv_AttandanceLog;
        private System.Windows.Forms.Button btn_GetDeviceInfo;
        private System.Windows.Forms.TextBox tbx_ReVerifyTime;
        private System.Windows.Forms.TextBox tbx_ManagerLogWarning;
        private System.Windows.Forms.TextBox tbx_AttLogWarning;
        private System.Windows.Forms.TextBox tbx_UserID_dataPage;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label lbl_WIFIpwd;
        private System.Windows.Forms.Label lbl_SSID;
        private System.Windows.Forms.Label lbl_DHCPGateway;
        private System.Windows.Forms.Label lbl_DHCPSubnet;
        private System.Windows.Forms.Label lbl_DHCPIP;
        private System.Windows.Forms.Label lbl_NetGateway;
        private System.Windows.Forms.Label lbl_NetSubnet;
        private System.Windows.Forms.Label lbl_NetIP;
        private System.Windows.Forms.Label lbl_VPNPwd;
        private System.Windows.Forms.Label lbl_VPNAddress;
        private System.Windows.Forms.Label lbl_VPNAccount;
        private System.Windows.Forms.Label lbl_SatelliteCount;
        private System.Windows.Forms.Label lbl_StreamingAddress;
        private System.Windows.Forms.Label lbl_CloudAddress;
        private System.Windows.Forms.Label lbl_Latitude;
        private System.Windows.Forms.Label lbl_Longitude;
        private System.Windows.Forms.Label lbl_TerminalPort;
        private System.Windows.Forms.Label lbl_TerminalPassword;
        private System.Windows.Forms.Label lbl_TerminalID;
        private System.Windows.Forms.CheckBox cbx_Compulsion;
        private System.Windows.Forms.Label lbl_ReVerifyTime;
        private System.Windows.Forms.Label lbl_ManagerLogWarning;
        private System.Windows.Forms.Label lbl_AttLogWarning;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Label lbl_UserID_dataPage;
        private System.Windows.Forms.RadioButton rbtn_CustomLog;
        private System.Windows.Forms.RadioButton rbtn_RealTimeLog;
        private System.Windows.Forms.Label lbl_BeginLogPos;
        private System.Windows.Forms.TextBox tbx_BeginLogPos;
        private System.Windows.Forms.DataGridView dgv_AttendanceRule;
        private System.Windows.Forms.Button btn_SetAccessList;
        private System.Windows.Forms.Button btn_GetAccessList;
        private System.Windows.Forms.Label lbl_TotalStore;
        private System.Windows.Forms.Label lbl_UseStore;
        private System.Windows.Forms.Label lbl_UnSendStore;
        private System.Windows.Forms.Label lbl_PhotoLogCount;
        private System.Windows.Forms.Label lbl_ManageLogCount;
        private System.Windows.Forms.Label lbl_TimeLogCount;
        private System.Windows.Forms.Label lbl_PwdCount;
        private System.Windows.Forms.Label lbl_CardCount;
        private System.Windows.Forms.Label lbl_FpCount;
        private System.Windows.Forms.Label lbl_FaceCount;
        private System.Windows.Forms.Label lbl_UserCount;
        private System.Windows.Forms.Label lbl_ManagerCount;
        private System.Windows.Forms.TextBox tbx_PhotoLogCount_s;
        private System.Windows.Forms.TextBox tbx_PhotoLogCount_u;
        private System.Windows.Forms.TextBox tbx_PhotoLogCount_t;
        private System.Windows.Forms.TextBox tbx_ManageLogCount_s;
        private System.Windows.Forms.TextBox tbx_ManageLogCount_u;
        private System.Windows.Forms.TextBox tbx_ManageLogCount_t;
        private System.Windows.Forms.TextBox tbx_TimeLogCount_s;
        private System.Windows.Forms.TextBox tbx_TimeLogCount_u;
        private System.Windows.Forms.TextBox tbx_TimeLogCount_t;
        private System.Windows.Forms.TextBox tbx_PwdCount_u;
        private System.Windows.Forms.TextBox tbx_PwdCount_t;
        private System.Windows.Forms.TextBox tbx_CardCount_u;
        private System.Windows.Forms.TextBox tbx_CardCount_t;
        private System.Windows.Forms.TextBox tbx_FpCount_u;
        private System.Windows.Forms.TextBox tbx_FpCount_t;
        private System.Windows.Forms.TextBox tbx_FaceCount_u;
        private System.Windows.Forms.TextBox tbx_FaceCount_t;
        private System.Windows.Forms.TextBox tbx_UserCount_u;
        private System.Windows.Forms.TextBox tbx_UserCount_t;
        private System.Windows.Forms.TextBox tbx_ManagerCount_u;
        private System.Windows.Forms.TextBox tbx_ManagerCount_t;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ReleasedTime;
        private System.Windows.Forms.TextBox tbx_Manufacturer;
        private System.Windows.Forms.TextBox tbx_ProductName;
        private System.Windows.Forms.TextBox tbx_ReleasedTime;
        private System.Windows.Forms.Label lbl_HardwareVersion;
        private System.Windows.Forms.Label lbl_FirmwareVersion;
        private System.Windows.Forms.Label lbl_DeviceSerialNo;
        private System.Windows.Forms.TextBox tbx_HardwareVer_info;
        private System.Windows.Forms.TextBox tbx_FirmwareVersion_info;
        private System.Windows.Forms.TextBox tbx_DeviceSerialNo_info;
        private System.Windows.Forms.ComboBox cobx_LockReleaseStatus;
        private System.Windows.Forms.Label lbl_AlarmStatus;
        private System.Windows.Forms.Label lbl_DoorSensoStatus;
        private System.Windows.Forms.Label lbl_LockReleaseStatus;
        private System.Windows.Forms.ComboBox cobx_AlarmStatus;
        private System.Windows.Forms.ComboBox cobx_DoorSensoStatus;
        private System.Windows.Forms.ComboBox cobx_WGOutputContent;
        private System.Windows.Forms.ComboBox cobx_WGOutputFormat;
        private System.Windows.Forms.CheckBox cbx_BlackListAlarm;
        private System.Windows.Forms.CheckBox cbx_TamperAlarm;
        private System.Windows.Forms.CheckBox cbx_LinkageAlarm;
        private System.Windows.Forms.CheckBox cbx_DuressAlarm;
        private System.Windows.Forms.ComboBox cobx_DoorSensorType;
        private System.Windows.Forms.TextBox tbx_DoorOpenTimeout;
        private System.Windows.Forms.ComboBox cobx_endWeek;
        private System.Windows.Forms.ComboBox cobx_startWeek;
        private System.Windows.Forms.CheckBox cbx_AllWeek;
        private System.Windows.Forms.DateTimePicker dtp_endPassTime;
        private System.Windows.Forms.DateTimePicker dtp_startPassTime;
        private System.Windows.Forms.TextBox tbx_VerifyPassLockReleaseTime;
        private System.Windows.Forms.ComboBox cobx_LockReleaseTime;
        private System.Windows.Forms.Label lbl_LockReleaseTime;
        private System.Windows.Forms.Label lbl_PassTime;
        private System.Windows.Forms.Label lbl_VerifyPassLockReleaseTime;
        private System.Windows.Forms.Label lbl_WGOutputContent;
        private System.Windows.Forms.Label lbl_WGOutputFormat;
        private System.Windows.Forms.Label lbl_DoorSensorType;
        private System.Windows.Forms.Label lbl_DoorOpenTimeout;
        private System.Windows.Forms.Label lbl_Week;
        private System.Windows.Forms.Button btn_SetAccessSettingSimple;
        private System.Windows.Forms.Button btn_GetAccessSettingSimple;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_AccessList;
        private System.Windows.Forms.Button btn_AddAccessList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AccessUse;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccessDerp;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccessPass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AccessAllWeek;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccessStartWeek;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccessEndWeek;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AccessAllTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessEndTime;
        private System.Windows.Forms.ComboBox cobx_AccessListAction;
        private System.Windows.Forms.TextBox tbx_DeleteAccessListNo;
        private System.Windows.Forms.Label lbl_DeleteAccessListNo;
        private System.Windows.Forms.PictureBox pbx_realtimePhoto_Data;
        private System.Windows.Forms.Button btn_GetNextSampleInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FingerData_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FingerData_string;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Duress;
        private System.Windows.Forms.DataGridViewButtonColumn save;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn use;
        private System.Windows.Forms.DataGridViewComboBoxColumn cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn times;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogAttendStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogAPStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogJobCode;
        private System.Windows.Forms.DataGridViewImageColumn LogPhoto;
        private System.Windows.Forms.Button btn_antoSET;
        private System.Windows.Forms.TextBox tbx_antoSETcounts;
        private System.Windows.Forms.ComboBox cobx_UTC;
        private System.Windows.Forms.Button btn_GetAllUserID;
        private System.Windows.Forms.Label lbl_Set_Type;
        private System.Windows.Forms.Label lbl_AllUserID;
        public System.Windows.Forms.TextBox tbx_AllUserID;
        private System.Windows.Forms.Button btn_SetUserSampleInfo;
        private System.Windows.Forms.Label lbl_NameListName;
        private System.Windows.Forms.Label lbl_ListNo;
        private System.Windows.Forms.TextBox tbx_NameListName;
        private System.Windows.Forms.ComboBox cobx_ListNo;
        private System.Windows.Forms.Button btn_GetNameList;
        private System.Windows.Forms.Button btn_SetNameList;
        private System.Windows.Forms.Label lbl_SwipeIDCardCount;
        private System.Windows.Forms.CheckBox cbx_LivingMode;
        private System.Windows.Forms.TextBox tbx_SwipeIDCardCount;
        private System.Windows.Forms.CheckBox cbx_Restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_operatorID;
        private System.Windows.Forms.TextBox tbx_operatorID;
        private System.Windows.Forms.Label lbl_CloudID;
        private System.Windows.Forms.TextBox tbt_CloudID;
        private System.Windows.Forms.Button btn_IdantifyCard;
        private System.Windows.Forms.Button btn_GetIdantifyCard;
        private System.Windows.Forms.Button btn_SetIdantifyCard;
        private System.Windows.Forms.Label lbl_IDValidDate;
        public System.Windows.Forms.TextBox tbx_IDValidDate;
        private System.Windows.Forms.Label lbl_IDAuthority;
        public System.Windows.Forms.TextBox tbx_IDAuthority;
        private System.Windows.Forms.PictureBox pbx_IDPhoto;
        private System.Windows.Forms.Label lbl_IDAddress;
        private System.Windows.Forms.Label lbl_IDBirthday;
        private System.Windows.Forms.Label lbl_IDNation;
        private System.Windows.Forms.Label lbl_IDGender;
        private System.Windows.Forms.Label lbl_IDName;
        private System.Windows.Forms.Label lbl_IDUserID;
        private System.Windows.Forms.ComboBox cobx_IDGender;
        private System.Windows.Forms.TextBox tbx_IDAddress;
        private System.Windows.Forms.TextBox tbx_IDBirthday;
        private System.Windows.Forms.TextBox tbx_IDNation;
        private System.Windows.Forms.TextBox tbx_IDName;
        public System.Windows.Forms.TextBox tbx_IDUserID;
        private System.Windows.Forms.PictureBox pbx_TakePhoto;
        private System.Windows.Forms.Button btn_TakePhoto;
        private System.Windows.Forms.ComboBox cobx_Camera;


    }
}