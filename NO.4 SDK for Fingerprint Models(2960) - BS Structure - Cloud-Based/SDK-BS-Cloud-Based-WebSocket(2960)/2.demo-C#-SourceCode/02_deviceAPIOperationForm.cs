using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Xml;
using System.IO;
using log4net;
using SuperSocket;
using SuperSocket.SocketBase;
//using SuperWebSocket;
using SuperSocket.WebSocket;

using System.Threading;
using System.Threading.Tasks;


using System.Runtime.Serialization.Formatters.Binary;

namespace WebsocketWinformDemo_Standard
{
    public partial class deviceAPIOperationForm : Form
    {
        string action_ext = "DemoDebug";

        #region Instantiation[实例化]
        websocketServerConnect ws_connect = new websocketServerConnect();
        API_Standard stand_api = new API_Standard();
        databaseDefine DB_def = new databaseDefine();
        #endregion

        #region Attributes[属性]

        private string _serialNo;
        /// <summary>
        /// websocket服务器，
        /// </summary>
        public string SerialNo
        {
            get { return _serialNo; }
            set { _serialNo = value; }
        }

        private WebSocketSession _ws_session;
        /// <summary>
        /// 登录设备，会话
        /// </summary>
        public WebSocketSession Session
        {
            get { return _ws_session; }
            set { _ws_session = value; }
        }

        private WebSocketServer _ws_Server;
        /// <summary>
        /// websocket服务器，
        /// </summary>
        public WebSocketServer Ws_Server
        {
            get { return _ws_Server; }
            set { _ws_Server = value; }
        }


        private bool _bool_alreadyOpen;
        /// <summary>
        /// 窗体是否打开
        /// </summary>
        public bool Bool_AlreadyOpen
        {
            get { return _bool_alreadyOpen; }
            set { _bool_alreadyOpen = value; }
        }


        private string _string_receiveXML;
        /// <summary>
        /// 控制台显示文本
        /// </summary>
        public string String_ReceiveXML
        {
            get { return _string_receiveXML; }
            set { _string_receiveXML = value; }
        }

        private string _string_sendXML;
        /// <summary>
        /// 控制台显示文本
        /// </summary>
        public string String_SendXML
        {
            get { return _string_sendXML; }
            set { _string_sendXML = value; }
        }

        #endregion

        #region Function[方法]

        #region Form Function[窗体方法]
        /// <summary>
        /// 窗体初始化
        /// </summary>
        public deviceAPIOperationForm()
        {
            InitializeComponent();
            InitializeUserForm();
            btn_saveFaceData.Enabled = false;
            
            //not suport button.暂不支持的按键，不显示
            btn_SetUserQRcode.Visible = false;
            btn_GetUserQRcode.Visible = false;
#if(MK3300)
            btn_GetMobileNetSetting.Visible = false;
            btn_SetMobileNetSetting.Visible = false;
            btn_GetVPNServer.Visible = false;
            btn_SetVPNServer.Visible = false;
            btn_GetGPS.Visible = false;
            btn_SetGPS.Visible = false;
            btn_GetStreamingServer.Visible = false;
            btn_SetStreamingServer.Visible = false;
            btn_GetFirstAttLog.Visible = false;
            btn_GetNextAttLog.Visible = false;
            btn_GetAttendanceRule.Visible = false;
            btn_SetAttendanceRule.Visible = false;
#endif
            //btn_RemoteOpen.Visible = false;
            btn_SetAccessSettingSimple.Visible = false;
            btn_GetAccessSettingSimple.Visible = false;

            //<----IDCard of chinese
            //性别
            for (int i = 0; i < DB_def.Gender.Length; i++)
            {
                cobx_IDGender.Items.Add(DB_def.Gender[i]);
            }
            cobx_IDGender.SelectedIndex = 0;

            lbl_IDName.Visible = false;
            lbl_IDGender.Visible = false;
            lbl_IDNation.Visible = false;
            lbl_IDBirthday.Visible = false;
            lbl_IDAddress.Visible = false;
            lbl_IDUserID.Visible = false;
            lbl_IDAuthority.Visible = false;
            lbl_IDValidDate.Visible = false;
            tbx_IDName.Visible = false;
            cobx_IDGender.Visible = false;
            tbx_IDNation.Visible = false;
            tbx_IDBirthday.Visible = false;
            tbx_IDAddress.Visible = false;
            tbx_IDUserID.Visible = false;
            tbx_IDAuthority.Visible = false;
            tbx_IDValidDate.Visible = false;
            pbx_IDPhoto.Visible = false;
            btn_GetIdantifyCard.Visible = false;
            btn_SetIdantifyCard.Visible = false;
            //---->




            //获取下一个用户的信息的按键
            btn_GetNextSampleInfo.Visible = false;
            
            //设置用户的动作
            for (int i = 0; i < DB_def.SetUserType.Length; i++)
            {
                cobx_userType.Items.Add(DB_def.SetUserType[i]);
            }
            cobx_userType.SelectedIndex = 0;

            //级别
            for (int i = 0; i < DB_def.Privilege.Length; i++)
            {
                cobx_Privilege.Items.Add(DB_def.Privilege[i]);
            }
            cobx_Privilege.SelectedIndex = 0;
            //部门
            for (int i = 0; i < DB_def.Depart.Length; i++)
            {
                cobx_Depart_U.Items.Add(DB_def.Depart[i]);
            }
            cobx_Depart_U.SelectedIndex = 0;

            //部门,基本设置
            for (int i = 0; i < DB_def.Depart.Length; i++)
            {
                cobx_Depart_B.Items.Add(DB_def.Depart[i]);
            }
            cobx_Depart_B.SelectedIndex = 0;
            //指纹编号
            for (int i = 0; i < DB_def.FingerNo.Length; i++)
            {
                cobx_FingerNo.Items.Add(DB_def.FingerNo[i]);
            }
            cobx_FingerNo.SelectedIndex = 0;
            //远程注册
            for (int i = 0; i < DB_def.RemoteEnroll.Length; i++)
            {
                cobx_EnrollBackup.Items.Add(DB_def.RemoteEnroll[i]);
            }
            cobx_EnrollBackup.SelectedIndex = 0;

            //手动修改日期时间控件
            dtp_custTime.Format = DateTimePickerFormat.Custom;
            dtp_custTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_custTime.ShowUpDown = true;
            dtp_custTime.Value = DateTime.Now;

            //手动时间
            if (rbtn_custmTime.Checked)
            {
                rbtn_sysTime.Checked = false;
                dtp_custTime.Enabled = true;
            }
            //系统时间
            if (rbtn_sysTime.Checked)
            {
                rbtn_custmTime.Checked = false;
                dtp_custTime.Enabled = false;
            }

            //名单
            for (int i = 0; i < DB_def.NameList.Length; i++)
            {
                cobx_ListNo.Items.Add(DB_def.NameList[i]);
            }
            cobx_ListNo.SelectedIndex = 0;

            //识别代码
            for (int i = 0; i < DB_def.Proxy.Length; i++)
            {
                cobx_ProxyNo.Items.Add(DB_def.Proxy[i]);
            }
            cobx_ProxyNo.SelectedIndex = 0;
            //识别代码使能
            if (cbx_UseProxy.Checked)
            {
                cobx_ProxyNo.Enabled = true;
                tbx_ProxyName.Enabled = true;
            }
            else
            {
                cobx_ProxyNo.Enabled = false;
                tbx_ProxyName.Enabled = false;
            }
            //响铃时间datagridview
            string[] B;
            for (int i = 0; i < 24; i++)
            {
                B = new string[4];
                B = stand_api.getBellTime.Bell[i].Split(',');

                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = Convert.ToString(i);
                row.Cells.Add(id);
                DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                data.Value = B[0];//
                row.Cells.Add(data);
                DataGridViewCheckBoxCell use = new DataGridViewCheckBoxCell();
                if (B[1] == "use")
                {
                    use.Value = true;
                }
                else
                {
                    use.Value = false;
                }
                row.Cells.Add(use);
                DataGridViewComboBoxCell cycle = new DataGridViewComboBoxCell();
                for (int n = 0; n < DB_def.BellTimeCycle.Length; n++)
                {
                    cycle.Items.Add(DB_def.BellTimeCycle[n]);
                }
                cycle.Value = B[2];
                row.Cells.Add(cycle);
                DataGridViewTextBoxCell times = new DataGridViewTextBoxCell();
                times.Value = B[3];
                row.Cells.Add(times);

                dgv_BellSetting.Rows.Add(row);
            }

            //语言
            for (int i = 0; i < DB_def.Language.Length; i++)
            {
                cobx_Language.Items.Add(DB_def.Language[i]);
            }
            cobx_Language.SelectedIndex = 0;

            //声音
            for (int i = 0; i < DB_def.Volume.Length; i++)
            {
                cobx_Volume.Items.Add(DB_def.Volume[i]);
            }
            cobx_Volume.SelectedIndex = 6;

            //验证模式
            for (int i = 0; i < DB_def.CameraType.Length; i++)
            {
                cobx_Camera.Items.Add(DB_def.CameraType[i]);
            }
            cobx_Camera.SelectedIndex = 0;
            


            //验证模式
            for (int i = 0; i < DB_def.IdentifyMode.Length; i++)
            {
                cobx_IdentifyMode.Items.Add(DB_def.IdentifyMode[i]);
            }
            cobx_IdentifyMode.SelectedIndex = 0;

            //实时拍照
            cbx_RealTimePhoto.Checked = true;

            //恢复设备
            for (int i = 0; i < DB_def.RestoreDevice.Length; i++)
            {
                cobx_RestoreAction.Items.Add(DB_def.RestoreDevice[i]);
            }
            cobx_RestoreAction.SelectedIndex = 0;


            //重启时间控件
            dtp_RestartTime.Format = DateTimePickerFormat.Custom;
            dtp_RestartTime.CustomFormat = "HH:mm";
            dtp_RestartTime.ShowUpDown = true;


            //屏保
            cbx_ScreenSaver.Checked = true;

            //物理关机按键
            cbx_PowerKey.Checked = false;

            //启用GPS
            if (cbx_UseGPS.Checked)
            {
                cbx_GPSAlive.Enabled = true;
            }
            else
            {
                cbx_GPSAlive.Enabled = false;
            }

            //自定义采集记录

            rbtn_RealTimeLog.Checked = true;

            tbx_BeginLogPos.Visible = false;
            lbl_BeginLogPos.Visible = false;
            tbx_UserID_dataPage.Visible = false;
            lbl_UserID_dataPage.Visible = false;
            dtp_StartTime.Visible = false;
            lbl_StartTime.Visible = false;
            dtp_EndTime.Visible = false;
            lbl_EndTime.Visible = false;
            btn_GetFirstAttLog.Visible = false;
            btn_GetNextAttLog.Visible = false;
            btn_GetAttendanceLog.Visible = false;
            tbx_BeginLogPos.Visible = false;


            

            //考勤记录的开始时间控件
            dtp_StartTime.Format = DateTimePickerFormat.Custom;
            dtp_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_StartTime.ShowUpDown = true;
            dtp_StartTime.Value = Convert.ToDateTime("2018-01-01 00:00:00");

            //考勤记录的结束时间控件
            dtp_EndTime.Format = DateTimePickerFormat.Custom;
            dtp_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_EndTime.ShowUpDown = true;
            dtp_EndTime.Value = DateTime.Now;

            //考勤规则datagridview
            string[] ATT;

            for (int i = 0; i < 24; i++)
            {
                try
                {
                    ATT = new string[3];
                    ATT = stand_api.getAttendanceRule.TimeSection[i].Split(',');

                    DataGridViewRow row = new DataGridViewRow();
                    //第一列，编号
                    DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                    id.Value = Convert.ToString(i);
                    row.Cells.Add(id);

                    //第二列，开始时间
                    DataGridViewTextBoxCell startTime = new DataGridViewTextBoxCell();
                    startTime.Value = ATT[0];
                    row.Cells.Add(startTime);

                    //第三列，结束时间
                    DataGridViewTextBoxCell endTime = new DataGridViewTextBoxCell();
                    endTime.Value = ATT[1];
                    row.Cells.Add(endTime);

                    //第四列，状态
                    DataGridViewComboBoxCell status = new DataGridViewComboBoxCell();
                    for (int n = 0; n < DB_def.AttendanceRuleStatus.Length; n++)
                    {
                        status.Items.Add(DB_def.AttendanceRuleStatus[n]);
                    }
                    status.Value = ATT[2];
                    row.Cells.Add(status);

                    dgv_AttendanceRule.Rows.Add(row);
                }
                catch (System.Exception) { }

            }

            //锁驱动
            for (int i = 0; i < DB_def.YesNo.Length; i++)
            {
                cobx_LockReleaseStatus.Items.Add(DB_def.YesNo[i]);
            }
            cobx_LockReleaseStatus.SelectedIndex = 0;

            //门磁状态
            for (int i = 0; i < DB_def.OpenClose.Length; i++)
            {
                cobx_DoorSensoStatus.Items.Add(DB_def.OpenClose[i]);
            }
            cobx_DoorSensoStatus.SelectedIndex = 0;

            //报警状态
            for (int i = 0; i < DB_def.AlarmStatus.Length; i++)
            {
                cobx_AlarmStatus.Items.Add(DB_def.AlarmStatus[i]);
            }
            cobx_AlarmStatus.SelectedIndex = 0;

            //输出韦根格式
            for (int i = 0; i < DB_def.WGOutputFormat.Length; i++)
            {
                cobx_WGOutputFormat.Items.Add(DB_def.WGOutputFormat[i]);
            }
            cobx_WGOutputFormat.SelectedIndex = 0;

            //输出韦根内容
            for (int i = 0; i < DB_def.WGOutputContent.Length; i++)
            {
                cobx_WGOutputContent.Items.Add(DB_def.WGOutputContent[i]);
            }
            cobx_WGOutputContent.SelectedIndex = 0;

            //驱动时长模式
            for (int i = 0; i < DB_def.LockReleaseTime.Length; i++)
            {
                cobx_LockReleaseTime.Items.Add(DB_def.LockReleaseTime[i]);
            }
            cobx_LockReleaseTime.SelectedIndex = 0;

            //门磁模式
            for (int i = 0; i < DB_def.DoorSensorType.Length; i++)
            {
                cobx_DoorSensorType.Items.Add(DB_def.DoorSensorType[i]);
            }
            cobx_DoorSensorType.SelectedIndex = 0;

            //星期范围
            for (int i = 0; i < DB_def.Week.Length; i++)
            {
                cobx_startWeek.Items.Add(DB_def.Week[i]);
                cobx_endWeek.Items.Add(DB_def.Week[i]);
            }
            cobx_startWeek.SelectedIndex = 0;
            cobx_endWeek.SelectedIndex = 6;

            //是否全部星期
            if (cbx_AllWeek.Checked)
            {
                cobx_startWeek.Enabled = false;
                cobx_endWeek.Enabled = false;
            }
            else
            {
                cobx_startWeek.Enabled = true;
                cobx_endWeek.Enabled = true;
            }


            //通行时间范围的开始时间控件
            dtp_startPassTime.Format = DateTimePickerFormat.Custom;
            dtp_startPassTime.CustomFormat = "HH:mm";
            dtp_startPassTime.ShowUpDown = true;
            dtp_startPassTime.Value = Convert.ToDateTime("08:00");

            //通行时间范围的结束时间控件
            dtp_endPassTime.Format = DateTimePickerFormat.Custom;
            dtp_endPassTime.CustomFormat = "HH:mm";
            dtp_endPassTime.ShowUpDown = true;
            dtp_endPassTime.Value = Convert.ToDateTime("18:00");

            //设置门禁策略的动作
            for (int i = 0; i < DB_def.AccessAction.Length; i++)
            {
                cobx_AccessListAction.Items.Add(DB_def.AccessAction[i]);
            }
            cobx_AccessListAction.SelectedIndex = 0;
        }
        /// <summary>
        /// 打开窗体时，增加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deviceAPIOperationForm_Load(object sender, EventArgs e)
        {
            _ws_Server.NewMessageReceived += new SessionHandler<WebSocketSession, string>(Thread_NewMessageResponse);
        }
        /// <summary>
        /// 关闭窗体时，去掉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deviceAPIOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ws_Server.NewMessageReceived -= new SessionHandler<WebSocketSession, string>(Thread_NewMessageResponse);
        }
        #endregion

        #region Button Function[按键事件]

        #region Massage Send To Device.Button Function[右侧，手动发送XML和接收XML，按键]
        private void btn_SendToDevice_Click(object sender, EventArgs e)
        {
            ws_connect.ws_NewMessage_Send(_ws_session, tbx_MessageFormServer.Text);
        }
        #endregion

        #region User.Button Function[用户管理，按键]
        private void btn_GetAllUserID_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getAllUserID.S_Ccid = Convert.ToString(ccid);
                stand_api.getAllUserID.S_Action_ext = action_ext;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getAllUserID.F_Request());
                tbx_MessageFormServer.Text = stand_api.getAllUserID.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_antoSET_Click(object sender, EventArgs e)
        {
            if (tbx_antoSETcounts.Text != null)//循环下发用户的个数
            {
                int AACCid = ws_connect.AACCid - 1;
                tbx_Actid.Text = Convert.ToString(AACCid);
                for (int i = 0; i < Convert.ToInt32(tbx_antoSETcounts.Text); i++)//开始循环
                {
                    //if (Convert.ToInt32(tbx_Actid.Text) + 1 == ws_connect.AACCid)//判断下发流水号和接收的是否一致，是的话才下发下一条。
                    {
                        InitializeUserForm();
                        try
                        {
                            Int32 ccid = ws_connect.AACCid;
                            stand_api.setUserData.S_Type = Convert.ToString(cobx_userType.SelectedItem);

                            stand_api.setUserData.S_Ccid = Convert.ToString(ccid);
                            stand_api.setUserData.S_Action_ext = action_ext;
                            stand_api.setUserData.S_UserID = Convert.ToString(Convert.ToInt32(tbx_UserID.Text) + i);
                            stand_api.setUserData.S_Name = tbx_Name.Text + Convert.ToString(i);
                            stand_api.setUserData.S_UserSN = "";
                            stand_api.setUserData.S_Privilege = Convert.ToString(cobx_Privilege.SelectedItem);
                            stand_api.setUserData.S_Depart = Convert.ToString(cobx_Depart_U.SelectedItem);
                            if (cbx_Enabled.Checked == true)
                            {
                                stand_api.setUserData.S_Enabled = "Yes";
                            }
                            else
                            {
                                stand_api.setUserData.S_Enabled = "No";
                            }
                            stand_api.setUserData.S_Card = "";
                            stand_api.setUserData.S_PWD = tbx_PWD.Text + Convert.ToString(i);

                            ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setUserData.F_Request());
                            tbx_MessageFormServer.Text = stand_api.setUserData.RequestXMLmassage;
                        }
                        catch
                        {
                            lbl_msg.Text = "Please input the correct UserID";
                        }
                    }
                }
            }
        }

        private void btn_GetUserAllInfo_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserAllInfo.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserAllInfo.S_Action_ext = action_ext;
                stand_api.getUserAllInfo.S_UserID = tbx_UserID.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserAllInfo.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserAllInfo.RequestXMLmassage;
            }
            catch 
            { 
                lbl_msg.Text = "Please input the correct UserID"; 
            }
        }

        private void btn_GetUserSampleInfo_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserSampleInfo.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserSampleInfo.S_Action_ext = action_ext;
                stand_api.getUserSampleInfo.S_UserID = tbx_UserID.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserSampleInfo.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserSampleInfo.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_SetUserSampleInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("在server框中输入XML指令来测试", "提示！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tbx_MessageFormServer.Focus();
                string sampleT = "<?xml version=\"1.0\"?>\r\n" +
                                "<Message>\r\n" +
                                "<Request>SetUserSampleInfo</Request>\r\n" +
                                "<Ccid>2</Ccid>\r\n" +
                                "<Time>2013-4-11-T11:28:54Z</Time>\r\n" +
                                "<Action_ext>show</Action_ext>\r\n" +
                                "<UserSampleInfo UserCounts=\"1\">\r\n" +
                                "<Info UserID=\"1\" Name=\"张三\" Privilege=\"User\" Depart=\"0\" Card=\"9499024\" PWD=\"1\" Fingers=\"0\" Face=\"No\"/>\r\n" +
                                "</UserSampleInfo>\r\n" +
                                "</Message>";

                tbx_MessageFormServer.Text = sampleT;
                tbx_MessageFormServer.Select(tbx_MessageFormServer.Text.Length, 0);//移动到最后  
                tbx_MessageFormServer.ScrollToCaret();//滚动到光标处 
                
            }
            
        }

        Int32 s = 1;
        private void btn_GetNextSampleInfo_Click(object sender, EventArgs e)
        {
            Int32 c = Convert.ToInt32(stand_api.getUserSampleInfo.UserCounts);
            
            if (!(s+1 > c))
            {
                //工号
                tbx_UserID.Text = stand_api.getUserSampleInfo.UserSampleInfo[s, 0];
                //名字
                tbx_Name.Text = stand_api.getUserSampleInfo.UserSampleInfo[s, 1];
                //级别
                cobx_Privilege.SelectedItem = stand_api.getUserSampleInfo.UserSampleInfo[s, 2];
                //部门，名单
                cobx_Depart_U.SelectedIndex = Convert.ToInt32(stand_api.getUserSampleInfo.UserSampleInfo[s, 3]);

                //卡号
                tbx_Card.Text = stand_api.getUserSampleInfo.UserSampleInfo[s, 4];
                //密码
                tbx_PWD.Text = stand_api.getUserSampleInfo.UserSampleInfo[s, 5];
                //指纹注册总数
                tbx_Fingers.Text = stand_api.getUserSampleInfo.UserSampleInfo[s, 6];

                //是否注册了人脸
                if (stand_api.getUserSampleInfo.UserSampleInfo[s, 7] == "Yes")
                {
                    cbx_FaceEnroll.Checked = true;
                }
                else
                {
                    cbx_FaceEnroll.Checked = false;
                }

                btn_GetNextSampleInfo.Text = s+1 + "/" + stand_api.getUserSampleInfo.UserCounts + "     Click For Next";
                s++;
            }
            else
            {
                s = 0;
                btn_GetNextSampleInfo.Text = "At the end of the page,Click Again";
                
            }
            
        }

        private void btn_GetUserData_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserData.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserData.S_Action_ext = action_ext;
                stand_api.getUserData.S_UserID = tbx_UserID.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserData.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_SetUserData_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                stand_api.setUserData.S_Type = Convert.ToString(cobx_userType.SelectedItem);

                stand_api.setUserData.S_Ccid = Convert.ToString(ccid);
                stand_api.setUserData.S_Action_ext = action_ext;
                stand_api.setUserData.S_UserID = tbx_UserID.Text;
                stand_api.setUserData.S_Name = tbx_Name.Text;
                stand_api.setUserData.S_UserSN = "";
                stand_api.setUserData.S_Privilege = Convert.ToString(cobx_Privilege.SelectedItem) ;
                stand_api.setUserData.S_Depart = Convert.ToString(cobx_Depart_U.SelectedItem);
                if (cbx_Enabled.Checked == true)
                {
                    stand_api.setUserData.S_Enabled ="Yes";
                }
                else
                {
                    stand_api.setUserData.S_Enabled = "No";
                }
                stand_api.setUserData.S_Card = tbx_Card.Text;
                stand_api.setUserData.S_PWD = tbx_PWD.Text;
                
                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setUserData.F_Request());
                tbx_MessageFormServer.Text = stand_api.setUserData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserPassword_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserPassword.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserPassword.S_Action_ext = action_ext;
                stand_api.getUserPassword.S_UserID = tbx_UserID.Text;



                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserPassword.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserPassword.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserCard_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserCardNo.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserCardNo.S_Action_ext = action_ext;
                stand_api.getUserCardNo.S_UserID = tbx_UserID.Text;



                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserCardNo.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserCardNo.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserPhoto_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserPhoto.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserPhoto.S_Action_ext = action_ext;
                stand_api.getUserPhoto.S_UserID = tbx_UserID.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserPhoto.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserPhoto.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserFinger_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getFingerData.S_Ccid = Convert.ToString(ccid);
                stand_api.getFingerData.S_Action_ext = action_ext;
                stand_api.getFingerData.S_UserID = tbx_UserID.Text;
                stand_api.getFingerData.S_FingerNo = Convert.ToString(cobx_FingerNo.SelectedItem);


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getFingerData.F_Request());
                tbx_MessageFormServer.Text = stand_api.getFingerData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID or FingerNo";
            }
        }

        private void dgv_FingerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv_FingerData.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow row = dgv_FingerData.Rows[e.RowIndex];
                    string _string_fingerData = row.Cells[1].Value.ToString();

                    if (_string_fingerData != null || _string_fingerData != "")
                    {
                        try
                        {
                            SaveFileDialog saveFingerData = new SaveFileDialog();
                            saveFingerData.Filter = "FingerData|*.fp";
                            if (saveFingerData.ShowDialog() == DialogResult.OK)
                            {
                                StreamWriter sw = File.CreateText(saveFingerData.FileName);
                                sw.Write(_string_fingerData);
                                sw.Flush();
                                sw.Close();

                                MessageBox.Show("Save Success");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Save failure");
                        }
                    }
                    
                }
            }
        }

        private void btn_SetUserFinger_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                string _string_duplicationCheck = "Yes";
                string _string_Duress = "No";
                string _string_FingerData = null;
                OpenFileDialog selectFingerData = new OpenFileDialog();
                selectFingerData.Filter = "Select Finger Data|*.fp";
                if (selectFingerData.ShowDialog() == DialogResult.OK)
                {
                    string filePath = selectFingerData.FileName;
                    StreamReader sr = File.OpenText(filePath);
                    while (sr.EndOfStream != true)
                    {
                        _string_FingerData = sr.ReadLine();
                    }
                }
                stand_api.setFingerData.S_Ccid = Convert.ToString(ccid);
                stand_api.setFingerData.S_Action_ext = action_ext;
                stand_api.setFingerData.S_UserID = tbx_UserID.Text;
                stand_api.setFingerData.S_FingerNo = Convert.ToString(cobx_FingerNo.SelectedItem);
                stand_api.setFingerData.S_DuplicationCheck = _string_duplicationCheck;
                stand_api.setFingerData.S_Duress = _string_Duress;
                stand_api.setFingerData.S_FingerData = _string_FingerData;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setFingerData.F_Request());
                tbx_MessageFormServer.Text = stand_api.setFingerData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserFace_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getFaceData.S_Ccid = Convert.ToString(ccid);
                stand_api.getFaceData.S_Action_ext = action_ext;
                stand_api.getFaceData.S_UserID = tbx_UserID.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getFaceData.F_Request());
                tbx_MessageFormServer.Text = stand_api.getFaceData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_saveFaceData_Click(object sender, EventArgs e)
        {
            if (tbx_FaceData.Text != null || tbx_FaceData.Text != "")
            {
                SaveFileDialog saveFingerData = new SaveFileDialog();
                saveFingerData.Filter = "Face Data|*.face";
                if (saveFingerData.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(saveFingerData.FileName);
                    sw.Write(tbx_FaceData.Text);
                    sw.Flush();
                    sw.Close();

                    MessageBox.Show("Save Success");
                }
            }
            
        }

        private void btn_SetUserFace_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                string _string_duplicationCheck = "Yes";
                string _string_FaceData = null;
                OpenFileDialog selectFaceData = new OpenFileDialog();
                selectFaceData.Filter = "Select Faca Data|*.face";
                if (selectFaceData.ShowDialog() == DialogResult.OK)
                {
                    string filePath = selectFaceData.FileName;
                    StreamReader sr = File.OpenText(filePath);
                    while (sr.EndOfStream != true)
                    {
                        _string_FaceData = sr.ReadLine();
                    }
                }
                stand_api.setFaceData.S_Ccid = Convert.ToString(ccid);
                stand_api.setFaceData.S_Action_ext = action_ext;
                stand_api.setFaceData.S_UserID = tbx_UserID.Text;
                stand_api.setFaceData.S_DuplicationCheck = _string_duplicationCheck;
                stand_api.setFaceData.S_FaceData = _string_FaceData;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setFaceData.F_Request());
                tbx_MessageFormServer.Text = stand_api.setFaceData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_GetUserQRcode_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getUserQRCode.S_Ccid = Convert.ToString(ccid);
                stand_api.getUserQRCode.S_Action_ext = action_ext;
                stand_api.getUserQRCode.S_UserID = tbx_UserID.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getUserQRCode.F_Request());
                tbx_MessageFormServer.Text = stand_api.getUserQRCode.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }

        private void btn_RemoteEnroll_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.remoteEnroll.S_Ccid = Convert.ToString(ccid);
                stand_api.remoteEnroll.S_Action_ext = action_ext;
                stand_api.remoteEnroll.S_UserID = tbx_UserID.Text;
                stand_api.remoteEnroll.S_Backup = Convert.ToString(cobx_EnrollBackup.SelectedItem);
                stand_api.remoteEnroll.S_FingerNo = Convert.ToString(cobx_FingerNo.SelectedItem);

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.remoteEnroll.F_Request());
                tbx_MessageFormServer.Text = stand_api.remoteEnroll.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID or FingerNo";
            }
        }

        private void btn_ExitRemoteEnroll_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.exitRemoteEnroll.S_Ccid = Convert.ToString(ccid);
                stand_api.exitRemoteEnroll.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.exitRemoteEnroll.F_Request());
                tbx_MessageFormServer.Text = stand_api.exitRemoteEnroll.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_TakeOffManager_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.takeOffManager.S_Ccid = Convert.ToString(ccid);
                stand_api.takeOffManager.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.takeOffManager.F_Request());
                tbx_MessageFormServer.Text = stand_api.takeOffManager.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void pbx_UserPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectUserPhoto = new OpenFileDialog();
            selectUserPhoto.Filter = "Select User Photo|*.png;*.bmp;*.jpg";
            if (selectUserPhoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = selectUserPhoto.FileName;
                    FileStream fs = new FileStream(filePath, FileMode.Open);
                    Byte[] _byte_picture = new Byte[fs.Length];
                    BinaryReader br = new BinaryReader(fs);
                    _byte_picture = br.ReadBytes(Convert.ToInt32(fs.Length));

                    Image UserEnrollPhotoimg = null;
                    UserEnrollPhotoimg = Image.FromStream(new System.IO.MemoryStream(_byte_picture));
                    pbx_UserPhoto.Image = UserEnrollPhotoimg;
                }
                catch (Exception et)
                {
                    if (MessageBox.Show("info:" + et.ToString(), "提示！", MessageBoxButtons.OKCancel) == DialogResult.OK) 
                    {
                        MessageBox.Show("可关闭重启该窗体重新打开!");
                    }
                }
                
            }
        }

        private void btn_SetUserPhoto_Click(object sender, EventArgs e)
        {
            InitializeUserForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                //<-------------
                Bitmap bmp = new Bitmap(pbx_UserPhoto.Image);  
                MemoryStream ms = new MemoryStream();  
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);  
                byte[] arr = new byte[ms.Length];  
                ms.Position = 0;  
                ms.Read(arr, 0, (int)ms.Length);  
                ms.Close();  
                string base64 = Convert.ToBase64String(arr);
                //------------->

                stand_api.setUserPhoto.S_Ccid = Convert.ToString(ccid);
                stand_api.setUserPhoto.S_Action_ext = action_ext;
                stand_api.setUserPhoto.S_UserID = tbx_UserID.Text;
                stand_api.setUserPhoto.S_PhotoSize = Convert.ToString(base64.Length);
                stand_api.setUserPhoto.S_PhotoData = base64;

                //照片
                if (base64 != null)
                {
                    Byte[] photoByte = null;
                    Image realtimeimg = null;
                    photoByte = Convert.FromBase64String(base64);
                    realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                    //pbx_UserQRCode.Image = realtimeimg;
                }
                
                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setUserPhoto.F_Request());
                tbx_MessageFormServer.Text = stand_api.setUserPhoto.RequestXMLmassage;

            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }

            
        }

        private void btn_SetUserFaceByPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectUserPhoto = new OpenFileDialog();
            selectUserPhoto.Filter = "Select Enroll Face Photo|*.png;*.bmp;*.jpg";
            if (selectUserPhoto.ShowDialog() == DialogResult.OK)
            {
                string filePath = selectUserPhoto.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                Byte[] _byte_picture = new Byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                _byte_picture = br.ReadBytes(Convert.ToInt32(fs.Length));

                InitializeUserForm();
                try
                {
                    Int32 ccid = ws_connect.AACCid;

                    string base64 = Convert.ToBase64String(_byte_picture);

                    stand_api.setFaceDataByPicture.S_Ccid = Convert.ToString(ccid);
                    stand_api.setFaceDataByPicture.S_Action_ext = action_ext;
                    stand_api.setFaceDataByPicture.S_UserID = tbx_UserID.Text;
                    stand_api.setFaceDataByPicture.S_PictureSize = Convert.ToString(base64.Length);
                    stand_api.setFaceDataByPicture.S_PictureData = base64;

                    //照片
                    if (base64 != null)
                    {
                        Byte[] photoByte = null;
                        Image realtimeimg = null;
                        photoByte = Convert.FromBase64String(base64);
                        realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                        pbx_UserQRCode.Image = realtimeimg;
                    }

                    ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setFaceDataByPicture.F_Request());
                    tbx_MessageFormServer.Text = stand_api.setFaceDataByPicture.RequestXMLmassage;

                }
                catch
                {
                    lbl_msg.Text = "ooh...the command cannot send to devices!!";
                }


            }
        }

        private void btn_SetUserFingerByPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectUserPhoto = new OpenFileDialog();
            selectUserPhoto.Filter = "Select Enroll Finger Photo|*.png;*.bmp;*.jpg";
            if (selectUserPhoto.ShowDialog() == DialogResult.OK)
            {
                string filePath = selectUserPhoto.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                Byte[] _byte_picture = new Byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                _byte_picture = br.ReadBytes(Convert.ToInt32(fs.Length));

                InitializeUserForm();
                try
                {
                    Int32 ccid = ws_connect.AACCid;

                    string base64 = Convert.ToBase64String(_byte_picture);

                    stand_api.setFingerDataByPicture.S_Ccid = Convert.ToString(ccid);
                    stand_api.setFingerDataByPicture.S_Action_ext = action_ext;
                    stand_api.setFingerDataByPicture.S_UserID = tbx_UserID.Text;
                    stand_api.setFingerDataByPicture.S_FingerNo = Convert.ToString(cobx_FingerNo.SelectedItem);
                    stand_api.setFingerDataByPicture.S_PictureSize = Convert.ToString(base64.Length);
                    stand_api.setFingerDataByPicture.S_PictureData = base64;

                    //照片
                    if (base64 != null)
                    {
                        Byte[] photoByte = null;
                        Image realtimeimg = null;
                        photoByte = Convert.FromBase64String(base64);
                        realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                        pbx_UserQRCode.Image = realtimeimg;
                    }

                    ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setFingerDataByPicture.F_Request());
                    tbx_MessageFormServer.Text = stand_api.setFingerDataByPicture.RequestXMLmassage;

                }
                catch
                {
                    lbl_msg.Text = "ooh...the command cannot send to devices!!";
                }


            }
        }

        private void btn_IdantifyCard_Click(object sender, EventArgs e)
        {
            if (this.Width == 1350)
            {
                this.Width = 900;
                lbl_IDName.Visible = false;
                lbl_IDGender.Visible = false;
                lbl_IDNation.Visible = false;
                lbl_IDBirthday.Visible = false;
                lbl_IDAddress.Visible = false;
                lbl_IDUserID.Visible = false;
                lbl_IDAuthority.Visible = false;
                lbl_IDValidDate.Visible = false;
                tbx_IDName.Visible = false;
                cobx_IDGender.Visible = false;
                tbx_IDNation.Visible = false;
                tbx_IDBirthday.Visible = false;
                tbx_IDAddress.Visible = false;
                tbx_IDUserID.Visible = false;
                tbx_IDAuthority.Visible = false;
                tbx_IDValidDate.Visible = false;
                pbx_IDPhoto.Visible = false;
                btn_GetIdantifyCard.Visible = false;
                btn_SetIdantifyCard.Visible = false;
                //---->
                btn_IdantifyCard.Text = "Open the ID Card!";
            }
            else
            {
                btn_IdantifyCard.Text = "Close the ID Card!";

                lbl_IDName.Visible = true;
                lbl_IDGender.Visible = true;
                lbl_IDNation.Visible = true;
                lbl_IDBirthday.Visible = true;
                lbl_IDAddress.Visible = true;
                lbl_IDUserID.Visible = true;
                lbl_IDAuthority.Visible = true;
                lbl_IDValidDate.Visible = true;
                tbx_IDName.Visible = true;
                cobx_IDGender.Visible = true;
                tbx_IDNation.Visible = true;
                tbx_IDBirthday.Visible = true;
                tbx_IDAddress.Visible = true;
                tbx_IDUserID.Visible = true;
                tbx_IDAuthority.Visible = true;
                tbx_IDValidDate.Visible = true;
                pbx_IDPhoto.Visible = true;
                btn_GetIdantifyCard.Visible = true;
                btn_SetIdantifyCard.Visible = true;


                tbx_IDName.Text = "";
                tbx_IDNation.Text = "";
                tbx_IDBirthday.Text = "";
                tbx_IDAddress.Text = "";
                tbx_IDUserID.Text = "";
                tbx_IDAuthority.Text = "";
                tbx_IDValidDate.Text = "";

                this.Width = 1350;

            }

        }

        private void btn_GetIdantifyCard_Click(object sender, EventArgs e)
        {
            InitializeIDCardForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getIdantifyCard.S_Ccid = Convert.ToString(ccid);
                stand_api.getIdantifyCard.S_Action_ext = action_ext;
                stand_api.getIdantifyCard.S_UserID = tbx_IDUserID.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getIdantifyCard.F_Request());
                tbx_MessageFormServer.Text = stand_api.getIdantifyCard.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
                tbx_IDUserID.Focus();
            }
        }

        private void btn_SetIdantifyCard_Click(object sender, EventArgs e)
        {
            InitializeIDCardForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setIdantifyCard.S_Ccid = Convert.ToString(ccid);
                stand_api.setIdantifyCard.S_Action_ext = action_ext;

                stand_api.setIdantifyCard.S_Name = tbx_IDName.Text;
                stand_api.setIdantifyCard.S_Gender = Convert.ToString(cobx_IDGender.SelectedItem);
                stand_api.setIdantifyCard.S_Nation = tbx_IDNation.Text;
                stand_api.setIdantifyCard.S_Birthday = tbx_IDBirthday.Text;
                stand_api.setIdantifyCard.S_Address = tbx_IDAddress.Text;
                stand_api.setIdantifyCard.S_UserID = tbx_IDUserID.Text;
                stand_api.setIdantifyCard.S_Authority = tbx_IDAuthority.Text;
                stand_api.setIdantifyCard.S_ValidDate = tbx_IDValidDate.Text;

                //<-------------
                Bitmap bmp = new Bitmap(pbx_IDPhoto.Image);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                string base64 = Convert.ToBase64String(arr);
                //------------->
                stand_api.setIdantifyCard.S_Photo = base64;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setIdantifyCard.F_Request());
                tbx_MessageFormServer.Text = stand_api.setIdantifyCard.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }
        #endregion

        #region Basic.Button Function[基本设置，按键]
        private void btn_EnableDevice_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                string _string_enableORdisenable = null;
                if (btn_EnableDevice.Text == "EnableDevice")
                {
                    _string_enableORdisenable = "Yes";
                    btn_EnableDevice.Text = "DisenableDevice";
                    lbl_EnableDevice.Text = "Enable Device....";
                }
                else
                {
                    _string_enableORdisenable = "No";
                    btn_EnableDevice.Text = "EnableDevice";
                    lbl_EnableDevice.Text = "The Device has been locked and the device cannot operate!!";
                }


                stand_api.enableDevice.S_Ccid = Convert.ToString(ccid);
                stand_api.enableDevice.S_Action_ext = action_ext;
                stand_api.enableDevice.S_Enable = _string_enableORdisenable;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.enableDevice.F_Request());
                tbx_MessageFormServer.Text = stand_api.enableDevice.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetTime_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                
                stand_api.getTime.S_Ccid = Convert.ToString(ccid);
                stand_api.getTime.S_Action_ext = action_ext;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getTime.F_Request());
                tbx_MessageFormServer.Text = stand_api.getTime.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void rbtn_sysTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_sysTime.Checked)
            {
                rbtn_custmTime.Checked = false;
                dtp_custTime.Enabled = false;
            }
            
        }

        private void rbtn_custmTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_custmTime.Checked)
            {
                rbtn_sysTime.Checked = false;
                dtp_custTime.Enabled = true;
                dtp_custTime.Value = DateTime.Now;
            }
        }

        private void btn_SetTime_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setTime.S_Ccid = Convert.ToString(ccid);
                stand_api.setTime.S_Action_ext = action_ext;
                string time = null;
                DateTime dt ;
                if (rbtn_sysTime.Checked)
                {
                    dt = DateTime.Now;
                }
                else
                {
                    dt = dtp_custTime.Value;
                }

                string shortDate = dt.ToShortDateString().ToString();//2018-4-11
                string longTime = dt.ToLongTimeString().ToString();//11:28:54
                time = shortDate + "-T" + longTime + "Z"; 
                stand_api.setTime.S_Time = time;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setTime.F_Request());
                tbx_MessageFormServer.Text = stand_api.setTime.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetDepartment_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getDepartment.S_Ccid = Convert.ToString(ccid);
                stand_api.getDepartment.S_Action_ext = action_ext;
                stand_api.getDepartment.S_DeptNo = Convert.ToString(cobx_Depart_B.SelectedItem);

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getDepartment.F_Request());
                tbx_MessageFormServer.Text = stand_api.getDepartment.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }

        }

        private void btn_SetDepartment_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setDepartment.S_Ccid = Convert.ToString(ccid);
                stand_api.setDepartment.S_Action_ext = action_ext;
                stand_api.setDepartment.S_DeptNo = Convert.ToString(cobx_Depart_B.SelectedItem);
                stand_api.setDepartment.S_Data = tbx_DepartName.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setDepartment.F_Request());
                tbx_MessageFormServer.Text = stand_api.setDepartment.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetNameList_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getNameList.S_Ccid = Convert.ToString(ccid);
                stand_api.getNameList.S_Action_ext = action_ext;
                stand_api.getNameList.S_ListNo = Convert.ToString(cobx_ListNo.SelectedItem);

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getNameList.F_Request());
                tbx_MessageFormServer.Text = stand_api.getNameList.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }

        }

        private void btn_SetNameList_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setNameList.S_Ccid = Convert.ToString(ccid);
                stand_api.setNameList.S_Action_ext = action_ext;
                stand_api.setNameList.S_ListNo = Convert.ToString(cobx_ListNo.SelectedItem);
                stand_api.setNameList.S_Data = tbx_NameListName.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setNameList.F_Request());
                tbx_MessageFormServer.Text = stand_api.setNameList.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetProxyName_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getProxyName.S_Ccid = Convert.ToString(ccid);
                stand_api.getProxyName.S_Action_ext = action_ext;
                stand_api.getProxyName.S_ProxyNo = Convert.ToString(cobx_ProxyNo.SelectedItem);

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getProxyName.F_Request());
                tbx_MessageFormServer.Text = stand_api.getProxyName.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetProxyName_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setProxyName.S_Ccid = Convert.ToString(ccid);
                stand_api.setProxyName.S_Action_ext = action_ext;
                if (cbx_UseProxy.Checked)
                {
                    stand_api.setProxyName.S_Use = "Yes";
                    stand_api.setProxyName.S_DeptNo = Convert.ToString(cobx_ProxyNo.SelectedItem);
                    stand_api.setProxyName.S_Data = tbx_ProxyName.Text;
                }
                else
                {
                    stand_api.setProxyName.S_Use = "No";
                }
                

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setProxyName.F_Request());
                tbx_MessageFormServer.Text = stand_api.setProxyName.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetBellSetting_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getBellTime.S_Ccid = Convert.ToString(ccid);
                stand_api.getBellTime.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getBellTime.F_Request());
                tbx_MessageFormServer.Text = stand_api.getBellTime.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetBellSetting_Click(object sender, EventArgs e)
        {
            InitializeBasicForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setBellTime.S_Ccid = Convert.ToString(ccid);
                stand_api.setBellTime.S_Action_ext = action_ext;

                string t = null;
                string u = null;
                string c = null;
                string n = null;
                for (int i = 0; i < 24; i++)
                {
                    t = dgv_BellSetting.Rows[i].Cells[1].Value.ToString();
                    u = dgv_BellSetting.Rows[i].Cells[2].Value.ToString();
                    if (u == "True")
                    {
                        u = "use";
                    }
                    else
                    {
                        u = "no use";
                    }
                    c = dgv_BellSetting.Rows[i].Cells[3].Value.ToString();
                    n = dgv_BellSetting.Rows[i].Cells[4].Value.ToString();

                    stand_api.setBellTime.S_Bell[i] = t + "," + u + "," + c + "," + n;
                }   
                

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setBellTime.F_Request());
                tbx_MessageFormServer.Text = stand_api.setBellTime.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }
        #endregion

        #region Advance.Button Function[高级设置，按键]

        private void btn_TakePhoto_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.takePhoto.S_Ccid = Convert.ToString(ccid);
                stand_api.takePhoto.S_Action_ext = action_ext;
                stand_api.takePhoto.S_Camera = Convert.ToString(cobx_Camera.SelectedItem);


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.takePhoto.F_Request());
                tbx_MessageFormServer.Text = stand_api.takePhoto.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "Please input the correct UserID";
            }
        }
        
        
        private void btn_GetDeviceSetting_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getDeviceSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getDeviceSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getDeviceSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getDeviceSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetDeviceSetting_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();

            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setDeviceSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setDeviceSetting.S_Action_ext = action_ext;
                
                stand_api.setDeviceSetting.S_Language = Convert.ToString(cobx_Language.SelectedItem);
                stand_api.setDeviceSetting.S_Volume = Convert.ToString(cobx_Volume.SelectedItem);
                stand_api.setDeviceSetting.S_IdentifyMode = Convert.ToString(cobx_IdentifyMode.SelectedItem);
                if(cbx_RealTimePhoto.Checked)
                {
                    stand_api.setDeviceSetting.S_RealTimePhoto = "Yes";
                }
                else
                {
                    stand_api.setDeviceSetting.S_RealTimePhoto = "No";
                }

                if (cbx_LivingMode.Checked)
                {
                    stand_api.setDeviceSetting.S_LivingMode = "Yes";
                }
                else
                {
                    stand_api.setDeviceSetting.S_LivingMode = "No";
                }

                stand_api.setDeviceSetting.S_SwipeIDCardCount = tbx_SwipeIDCardCount.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setDeviceSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setDeviceSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_RestoreDevice_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.restoreDevice.S_Ccid = Convert.ToString(ccid);
                stand_api.restoreDevice.S_Action_ext = action_ext;
                stand_api.restoreDevice.S_Action = Convert.ToString(cobx_RestoreAction.SelectedItem);

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.restoreDevice.F_Request());
                tbx_MessageFormServer.Text = stand_api.restoreDevice.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetPowerSetting_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getPowerSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getPowerSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getPowerSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getPowerSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetPowerSetting_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setPowerSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setPowerSetting.S_Action_ext = action_ext;

                if (cbx_Restart.Checked)
                {
                    stand_api.setPowerSetting.S_Restart = "Yes";
                }
                else
                {
                    stand_api.setPowerSetting.S_Restart = "No";
                }

                DateTime dt = dtp_RestartTime.Value;
                string ShortTime = dtp_RestartTime.Value.ToShortTimeString().ToString();//11:28
                stand_api.setPowerSetting.S_RestartTime = ShortTime;

                stand_api.setPowerSetting.S_SleepAfter = tbx_SleepAfter.Text;
                if (cbx_ScreenSaver.Checked)
                {
                    stand_api.setPowerSetting.S_ScreenSaver = "Yes";
                }
                else
                {
                    stand_api.setPowerSetting.S_ScreenSaver = "No";
                }
                if (cbx_PowerKey.Checked)
                {
                    stand_api.setPowerSetting.S_PowerKey = "Yes";
                }
                else
                {
                    stand_api.setPowerSetting.S_PowerKey = "No";
                }
                

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setPowerSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setPowerSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_FirmwareUpgradeByCloud_Click(object sender, EventArgs e)
        {
            InitializeAdvancedForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.firmwareUpgradeByCloud.S_Ccid = Convert.ToString(ccid);
                stand_api.firmwareUpgradeByCloud.S_Action_ext = action_ext;
                stand_api.firmwareUpgradeByCloud.S_Data = tbx_FirmwareAddress.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.firmwareUpgradeByCloud.F_Request());
                tbx_MessageFormServer.Text = stand_api.firmwareUpgradeByCloud.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        #endregion

        #region Net.Button Function[网络管理，按键]
        private void btn_GetEthernetSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getEthernetSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getEthernetSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getEthernetSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getEthernetSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetEthernetSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setEthernetSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setEthernetSetting.S_Action_ext = action_ext;

                if (cbx_DHCP.Checked)
                {
                    stand_api.setEthernetSetting.S_DHCP = "Yes";
                }
                else
                {
                    stand_api.setEthernetSetting.S_DHCP = "No";
                }

                stand_api.setEthernetSetting.S_IP = tbx_NetIP.Text;
                stand_api.setEthernetSetting.S_Subnet = tbx_NetSubnet.Text;
                stand_api.setEthernetSetting.S_DefaultGateway = tbx_NetGateway.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setEthernetSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setEthernetSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetWifiSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getWifiSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getWifiSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getWifiSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getWifiSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetWifiSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setWifiSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setWifiSetting.S_Action_ext = action_ext;

                if (cbx_useWIFI.Checked)
                {
                    stand_api.setWifiSetting.S_Use = "Yes";
                }
                else
                {
                    stand_api.setWifiSetting.S_Use = "No";
                }

                stand_api.setWifiSetting.S_SSID = tbx_SSID.Text;
                stand_api.setWifiSetting.S_Key = tbx_Key.Text;


                if (cbx_DHCP.Checked)
                {
                    stand_api.setWifiSetting.S_DHCP = "Yes";
                }
                else
                {
                    stand_api.setWifiSetting.S_DHCP = "No";
                }

                stand_api.setWifiSetting.S_IP = tbx_NetIP.Text;
                stand_api.setWifiSetting.S_Subnet = tbx_NetSubnet.Text;
                stand_api.setWifiSetting.S_DefaultGateway = tbx_NetGateway.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setWifiSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setWifiSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetMobileNetSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getMobileNetSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getMobileNetSetting.S_Action_ext = action_ext;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getMobileNetSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getMobileNetSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetMobileNetSetting_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setMobileNetSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setMobileNetSetting.S_Action_ext = action_ext;

                if (cbx_UseMobileNet.Checked)
                {
                    stand_api.setMobileNetSetting.S_Use = "Yes";
                }
                else
                {
                    stand_api.setMobileNetSetting.S_Use = "No";
                }


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setMobileNetSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setMobileNetSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetVPNServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getVPNServer.S_Ccid = Convert.ToString(ccid);
                stand_api.getVPNServer.S_Action_ext = action_ext;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getVPNServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.getVPNServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetVPNServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setVPNServer.S_Ccid = Convert.ToString(ccid);
                stand_api.setVPNServer.S_Action_ext = action_ext;

                stand_api.setVPNServer.S_Account = tbx_VPNAccount.Text;
                stand_api.setVPNServer.S_VPNAddress = tbx_VPNAddress.Text;
                stand_api.setVPNServer.S_Password = tbx_VPNPwd.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setVPNServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.setVPNServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetGPS_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getGPS.S_Ccid = Convert.ToString(ccid);
                stand_api.getGPS.S_Action_ext = action_ext;
                if(cbx_GPSAlive.Checked)
                {
                    stand_api.getGPS.S_Alive = "Yes";
                }
                else
                {
                    stand_api.getGPS.S_Alive = "No";
                }
                

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getGPS.F_Request());
                tbx_MessageFormServer.Text = stand_api.getGPS.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetGPS_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setGPS.S_Ccid = Convert.ToString(ccid);
                stand_api.setGPS.S_Action_ext = action_ext;
                if (cbx_UseGPS.Checked)
                {
                    stand_api.setGPS.S_Use = "Yes";
                    if (cbx_GPSAlive.Checked)
                    {
                        stand_api.setGPS.S_Alive = "Yes";
                    }
                    else
                    {
                        stand_api.setGPS.S_Alive = "No";
                    }
                }
                else
                {
                    stand_api.setGPS.S_Use = "No";
                }

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setGPS.F_Request());
                tbx_MessageFormServer.Text = stand_api.setGPS.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void cbx_UseGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_UseGPS.Checked)
            {
                cbx_GPSAlive.Enabled = true;
            }
            else
            {
                cbx_GPSAlive.Enabled = false;
            } 
        }

        private void btn_GetCloudServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getCloudServer.S_Ccid = Convert.ToString(ccid);
                stand_api.getCloudServer.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getCloudServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.getCloudServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetCloudServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setCloudServer.S_Ccid = Convert.ToString(ccid);
                stand_api.setCloudServer.S_Action_ext = action_ext;

                stand_api.setCloudServer.S_WebsocketServer = tbx_CloudAddress.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setCloudServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.setCloudServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetStreamingServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getStreamingServer.S_Ccid = Convert.ToString(ccid);
                stand_api.getStreamingServer.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getStreamingServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.getStreamingServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetStreamingServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setStreamingServer.S_Ccid = Convert.ToString(ccid);
                stand_api.setStreamingServer.S_Action_ext = action_ext;

                stand_api.setStreamingServer.S_StreamingServer = tbx_StreamingAddress.Text;


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setStreamingServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.setStreamingServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetLocalServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getLocalServer.S_Ccid = Convert.ToString(ccid);
                stand_api.getLocalServer.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getLocalServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.getLocalServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetLocalServer_Click(object sender, EventArgs e)
        {
            InitializeNetForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setLocalServer.S_Ccid = Convert.ToString(ccid);
                stand_api.setLocalServer.S_Action_ext = action_ext;

                stand_api.setLocalServer.S_TerminalID = tbx_TerminalID_n.Text;
                stand_api.setLocalServer.S_TerminalPassword = tbx_TerminalPassword.Text;
                stand_api.setLocalServer.S_TerminalPort = tbx_TerminalPort.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setLocalServer.F_Request());
                tbx_MessageFormServer.Text = stand_api.setLocalServer.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        #endregion
        
        #region Data.Button Function[数据管理，按键]
        private void btn_EmptyTimeLog_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;
                
                stand_api.emptyTimeLog.S_Ccid = Convert.ToString(ccid);
                stand_api.emptyTimeLog.S_Action_ext = action_ext;
                if (cbx_Compulsion.Checked)
                {
                    stand_api.emptyTimeLog.S_Compulsion = "Yes";
                }
                else
                {
                    stand_api.emptyTimeLog.S_Compulsion = "No";
                }



                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.emptyTimeLog.F_Request());
                tbx_MessageFormServer.Text = stand_api.emptyTimeLog.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_EmptyManageLog_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.emptyManageLog.S_Ccid = Convert.ToString(ccid);
                stand_api.emptyManageLog.S_Action_ext = action_ext;
                if (cbx_Compulsion.Checked)
                {
                    stand_api.emptyManageLog.S_Compulsion = "Yes";
                }
                else
                {
                    stand_api.emptyManageLog.S_Compulsion = "No";
                }

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.emptyManageLog.F_Request());
                tbx_MessageFormServer.Text = stand_api.emptyManageLog.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_EmptyUserEnrollmentData_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.emptyUserEnrollmentData.S_Ccid = Convert.ToString(ccid);
                stand_api.emptyUserEnrollmentData.S_Action_ext = action_ext;



                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.emptyUserEnrollmentData.F_Request());
                tbx_MessageFormServer.Text = stand_api.emptyUserEnrollmentData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_EmptyAllData_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.emptyAllData.S_Ccid = Convert.ToString(ccid);
                stand_api.emptyAllData.S_Action_ext = action_ext;
                if (cbx_Compulsion.Checked)
                {
                    stand_api.emptyAllData.S_Compulsion = "Yes";
                }
                else
                {
                    stand_api.emptyAllData.S_Compulsion = "No";
                }

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.emptyAllData.F_Request());
                tbx_MessageFormServer.Text = stand_api.emptyAllData.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetLogSetting_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getLogSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getLogSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getLogSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getLogSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetLogSetting_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setLogSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setLogSetting.S_Action_ext = action_ext;

                stand_api.setLogSetting.S_AttLogWarning = tbx_AttLogWarning.Text;
                stand_api.setLogSetting.S_ManagerLogWarning = tbx_ManagerLogWarning.Text;
                stand_api.setLogSetting.S_ReVerifyTime = tbx_ReVerifyTime.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setLogSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setLogSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void rbtn_CustomLog_CheckedChanged(object sender, EventArgs e)
        {
            dgv_AttandanceLog.Rows.Clear();
            if (rbtn_CustomLog.Checked)
            {
                rbtn_RealTimeLog.Checked = false;

                tbx_BeginLogPos.Visible = true;
                lbl_BeginLogPos.Visible = true;
                tbx_UserID_dataPage.Visible = true;
                lbl_UserID_dataPage.Visible = true;
                dtp_StartTime.Visible = true;
                lbl_StartTime.Visible = true;
                dtp_EndTime.Visible = true;
                lbl_EndTime.Visible = true;
                btn_GetFirstAttLog.Visible = false;
                btn_GetNextAttLog.Visible = false;
                btn_GetAttendanceLog.Visible = true;

            }
            else
            {
                rbtn_RealTimeLog.Checked = true;

                tbx_BeginLogPos.Visible = false;
                lbl_BeginLogPos.Visible = false;
                tbx_UserID_dataPage.Visible = false;
                lbl_UserID_dataPage.Visible = false;
                dtp_StartTime.Visible = false;
                lbl_StartTime.Visible = false;
                dtp_EndTime.Visible = false;
                lbl_EndTime.Visible = false;
                btn_GetFirstAttLog.Visible = false;
                btn_GetNextAttLog.Visible = false;
                btn_GetAttendanceLog.Visible = false;

            }
        }

        private void rbtn_RealTimeLog_CheckedChanged(object sender, EventArgs e)
        {
            dgv_AttandanceLog.Rows.Clear();
            if (rbtn_RealTimeLog.Checked)
            {

                //MessageBox.Show("可直接验证后自动刷新纪录", "提示！", MessageBoxButtons.OKCancel);

                rbtn_RealTimeLog.Checked = true;

                tbx_BeginLogPos.Visible = false;
                lbl_BeginLogPos.Visible = false;
                tbx_UserID_dataPage.Visible = false;
                lbl_UserID_dataPage.Visible = false;
                dtp_StartTime.Visible = false;
                lbl_StartTime.Visible = false;
                dtp_EndTime.Visible = false;
                lbl_EndTime.Visible = false;
                btn_GetFirstAttLog.Visible = false;
                btn_GetNextAttLog.Visible = false;
                btn_GetAttendanceLog.Visible = false;

                
            }
            else
            {
                rbtn_RealTimeLog.Checked = false;

                tbx_BeginLogPos.Visible = true;
                lbl_BeginLogPos.Visible = true;
                tbx_UserID_dataPage.Visible = true;
                lbl_UserID_dataPage.Visible = false;
                dtp_StartTime.Visible = true;
                lbl_StartTime.Visible = true;
                dtp_EndTime.Visible = true;
                lbl_EndTime.Visible = true;
                btn_GetFirstAttLog.Visible = false;
                btn_GetNextAttLog.Visible = false;
                btn_GetAttendanceLog.Visible = true;


            }
        }

        private void btn_GetFirstAttLog_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getFirstGlog.S_Ccid = Convert.ToString(ccid);
                stand_api.getFirstGlog.S_Action_ext = action_ext;
                stand_api.getFirstGlog.S_BeginLogPos = tbx_BeginLogPos.Text;

                stand_api.getFirstGlog.S_UserID = tbx_UserID_dataPage.Text;

                DateTime s_dt;
                s_dt = dtp_StartTime.Value;
                string s_shortDate = s_dt.ToShortDateString().ToString();//2018-4-11
                string s_longTime = s_dt.ToLongTimeString().ToString();//11:28:54
                stand_api.getFirstGlog.S_StartTime = s_shortDate + "-T" + s_longTime + "Z";

                DateTime e_dt;
                e_dt = dtp_EndTime.Value;
                string e_shortDate = e_dt.ToShortDateString().ToString();//2018-4-11
                string e_longTime = e_dt.ToLongTimeString().ToString();//11:28:54
                stand_api.getFirstGlog.S_EndTime = e_shortDate + "-T" + e_longTime + "Z";


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getFirstGlog.F_Request());
                tbx_MessageFormServer.Text = stand_api.getFirstGlog.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetNextAttLog_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getNextGlog.S_Ccid = Convert.ToString(ccid);
                stand_api.getNextGlog.S_Action_ext = action_ext;
                stand_api.getNextGlog.S_BeginLogPos = tbx_BeginLogPos.Text;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getNextGlog.F_Request());
                tbx_MessageFormServer.Text = stand_api.getNextGlog.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetAttendanceLog_Click(object sender, EventArgs e)
        {
            InitializeDataForm();
            dgv_AttandanceLog.Rows.Clear();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getAttendanceLog.S_Ccid = Convert.ToString(ccid);
                stand_api.getAttendanceLog.S_Action_ext = action_ext;
                stand_api.getAttendanceLog.S_LogIDPos = tbx_BeginLogPos.Text;

                stand_api.getAttendanceLog.S_UserID = tbx_UserID_dataPage.Text;

                DateTime s_dt;
                s_dt = dtp_StartTime.Value;
                string s_shortDate = s_dt.ToShortDateString().ToString();//2018-4-11
                string s_longTime = s_dt.ToLongTimeString().ToString();//11:28:54
                stand_api.getAttendanceLog.S_StartTime = s_shortDate + "-T" + s_longTime + "Z";

                DateTime e_dt;
                e_dt = dtp_EndTime.Value;
                string e_shortDate = e_dt.ToShortDateString().ToString();//2018-4-11
                string e_longTime = e_dt.ToLongTimeString().ToString();//11:28:54
                stand_api.getAttendanceLog.S_EndTime = e_shortDate + "-T" + e_longTime + "Z";


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getAttendanceLog.F_Request());
                tbx_MessageFormServer.Text = stand_api.getAttendanceLog.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        

        #endregion

        #region Attandance.Button Function[考勤管理，按键]

        private void btn_GetAttendanceRule_Click(object sender, EventArgs e)
        {
            InitializeAttForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getAttendanceRule.S_Ccid = Convert.ToString(ccid);
                stand_api.getAttendanceRule.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getAttendanceRule.F_Request());
                tbx_MessageFormServer.Text = stand_api.getAttendanceRule.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetAttendanceRule_Click(object sender, EventArgs e)
        {
            InitializeAttForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setAttendanceRule.S_Ccid = Convert.ToString(ccid);
                stand_api.setAttendanceRule.S_Action_ext = action_ext;

                string st = null;
                string et = null;
                string status = null;
                for (int i = 0; i < 24; i++)
                {
                    st = dgv_AttendanceRule.Rows[i].Cells[1].Value.ToString();
                    et = dgv_AttendanceRule.Rows[i].Cells[2].Value.ToString();
                    status = dgv_AttendanceRule.Rows[i].Cells[3].Value.ToString();

                    stand_api.setAttendanceRule.S_TimeSection[i] = st + "," + et + "," + status;
                }   

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setAttendanceRule.F_Request());
                tbx_MessageFormServer.Text = stand_api.setAttendanceRule.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        #endregion

        #region Access.Button Function[门禁管理，按键]
        private void btn_AccessStatus_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.accessStatus.S_Ccid = Convert.ToString(ccid);
                stand_api.accessStatus.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.accessStatus.F_Request());
                tbx_MessageFormServer.Text = stand_api.accessStatus.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void cbx_AllWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_AllWeek.Checked)
            {
                cobx_startWeek.Enabled = false;
                cobx_endWeek.Enabled = false;
            }
            else
            {
                cobx_startWeek.Enabled = true;
                cobx_endWeek.Enabled = true;
            }
        }

        private void btn_GetAccessSetting_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getAccessSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.getAccessSetting.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getAccessSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.getAccessSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_SetAccessSetting_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setAccessSetting.S_Ccid = Convert.ToString(ccid);
                stand_api.setAccessSetting.S_Action_ext = action_ext;

                if (cbx_TamperAlarm.Checked)
                {
                    stand_api.setAccessSetting.S_TamperAlarm = "Yes";
                }
                else
                {
                    stand_api.setAccessSetting.S_TamperAlarm = "No";
                }

                stand_api.setAccessSetting.S_WGOutputFormat = Convert.ToString(cobx_WGOutputFormat.SelectedItem);
                stand_api.setAccessSetting.S_WGOutputContent = Convert.ToString(cobx_WGOutputContent.SelectedItem);
                stand_api.setAccessSetting.S_LockReleaseTime = Convert.ToString(cobx_LockReleaseTime.SelectedItem);
                stand_api.setAccessSetting.S_VerifyPassLockReleaseTime = tbx_VerifyPassLockReleaseTime.Text;
                stand_api.setAccessSetting.S_DoorSensorType = Convert.ToString(cobx_DoorSensorType.SelectedItem);
                stand_api.setAccessSetting.S_DoorOpenTimeout = tbx_DoorOpenTimeout.Text;

                DateTime st = dtp_startPassTime.Value;
                DateTime et = dtp_endPassTime.Value;
                string st_ShortTime = st.ToShortTimeString().ToString();//11:28
                string et_ShortTime = et.ToShortTimeString().ToString();//11:28
                stand_api.setAccessSetting.S_PassTime = st_ShortTime + "-" + et_ShortTime;

                if (cbx_AllWeek.Checked)
                {
                    stand_api.setAccessSetting.S_AllWeek = "Yes";
                }
                else
                {
                    stand_api.setAccessSetting.S_AllWeek = "No";
                }

                stand_api.setAccessSetting.S_StartWeek = Convert.ToString(cobx_startWeek.SelectedItem);
                stand_api.setAccessSetting.S_EndWeek = Convert.ToString(cobx_endWeek.SelectedItem);

                if (cbx_DuressAlarm.Checked)
                {
                    stand_api.setAccessSetting.S_DuressAlarm = "Yes";
                }
                else
                {
                    stand_api.setAccessSetting.S_DuressAlarm = "No";
                }

                if (cbx_LinkageAlarm.Checked)
                {
                    stand_api.setAccessSetting.S_LinkageAlarm = "Yes";
                }
                else
                {
                    stand_api.setAccessSetting.S_LinkageAlarm = "No";
                }

                if (cbx_BlackListAlarm.Checked)
                {
                    stand_api.setAccessSetting.S_BlackListAlarm = "Yes";
                }
                else
                {
                    stand_api.setAccessSetting.S_BlackListAlarm = "No";
                }

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setAccessSetting.F_Request());
                tbx_MessageFormServer.Text = stand_api.setAccessSetting.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetAccessList_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getAccessList.S_Ccid = Convert.ToString(ccid);
                stand_api.getAccessList.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getAccessList.F_Request());
                tbx_MessageFormServer.Text = stand_api.getAccessList.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_AddAccessList_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                //第一列，ID
                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = dgv_AccessList.RowCount + 1;
                row.Cells.Add(id);

                //第二列，使用
                DataGridViewCheckBoxCell use = new DataGridViewCheckBoxCell();
                use.Value = "true";
                row.Cells.Add(use);

                //第三列，部门或者名单
                DataGridViewComboBoxCell depart = new DataGridViewComboBoxCell();
                for (int n = 0; n < DB_def.Depart.Length; n++)
                {
                    depart.Items.Add(Convert.ToString(DB_def.Depart[n]));
                }
                depart.Value = "0";
                row.Cells.Add(depart);
                //第四列，通过权限
                DataGridViewComboBoxCell access = new DataGridViewComboBoxCell();
                for (int n = 0; n < DB_def.YesNo.Length; n++)
                {
                    access.Items.Add(DB_def.YesNo[n]);
                }
                access.Value = "Yes";
                row.Cells.Add(access);

                //第五列，星期永久
                DataGridViewCheckBoxCell allWeek = new DataGridViewCheckBoxCell();
                allWeek.Value = "true";
                row.Cells.Add(allWeek);

                //第五列，开始星期
                DataGridViewComboBoxCell startWeek = new DataGridViewComboBoxCell();
                for (int n = 0; n < DB_def.Week.Length; n++)
                {
                    startWeek.Items.Add(DB_def.Week[n]);
                }
                startWeek.Value = "Sun";
                row.Cells.Add(startWeek);

                //第六列，结束星期
                DataGridViewComboBoxCell endWeek = new DataGridViewComboBoxCell();
                for (int n = 0; n < DB_def.Week.Length; n++)
                {
                    endWeek.Items.Add(DB_def.Week[n]);
                }
                endWeek.Value = "Sun";
                row.Cells.Add(endWeek);

                //第七列，时段永久
                DataGridViewCheckBoxCell allTime = new DataGridViewCheckBoxCell();
                allTime.Value = "true";
                row.Cells.Add(allTime);

                //第八列，开始时段
                DataGridViewTextBoxCell startTime = new DataGridViewTextBoxCell();
                startTime.Value = "2000-01-01 00:00";
                row.Cells.Add(startTime);

                //第九列，结束时段
                DataGridViewTextBoxCell endTime = new DataGridViewTextBoxCell();
                endTime.Value = "2020-12-31 23:59";
                row.Cells.Add(endTime);

                dgv_AccessList.Rows.Add(row);
            }
            catch { }
        }

        private void btn_SetAccessList_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.setAccessList.S_Ccid = Convert.ToString(ccid);
                stand_api.setAccessList.S_Action_ext = action_ext;

                stand_api.setAccessList.S_Action = Convert.ToString(cobx_AccessListAction.SelectedItem);
                if (stand_api.setAccessList.S_Action == "Delete")
                {
                    stand_api.setAccessList.S_AccessListID = tbx_DeleteAccessListNo.Text;

                    int rowCount = dgv_AccessList.Rows.Count;
                    int i = 0;

                    if (rowCount > 0)
                    {
                        foreach (DataGridViewRow c_row in dgv_AccessList.Rows)
                        {
                            string accessListID = c_row.Cells[0].Value.ToString();//判断ID

                            if (stand_api.setAccessList.S_AccessListID == accessListID)
                            {
                                dgv_AccessList.Rows.Remove(c_row);
                                MessageBox.Show("Delete ListID：" + accessListID + "Access Rule,You need to click Button [SetAccessList] to update the device policy rules!");//你已经删除了门禁策略：1，需要点击设置更新设备策略规则
                            }
                            else
                            {
                                i++;
                            }

                            if (i == rowCount)//全部遍历完成，说明都没有一样的。
                            {
                                return;
                            }
                        }
                    }
                }
                else
                {
                    stand_api.setAccessList.S_Count = Convert.ToString(dgv_AccessList.RowCount);
                    for (int i = 0; i < dgv_AccessList.RowCount; i++)
                    {
                        stand_api.setAccessList.S_List_id[i] = Convert.ToInt32(dgv_AccessList.Rows[i].Cells[0].Value.ToString());
                        stand_api.setAccessList.S_List[i, 0] = dgv_AccessList.Rows[i].Cells[1].Value.ToString();
                        if (stand_api.setAccessList.S_List[i, 0] == "true")
                        {
                            stand_api.setAccessList.S_List[i, 0] = "Yes";
                        }
                        else
                        {
                            stand_api.setAccessList.S_List[i, 0] = "No";
                        }
                        stand_api.setAccessList.S_List[i, 1] = Convert.ToString(dgv_AccessList.Rows[i].Cells[2].Value);
                        stand_api.setAccessList.S_List[i, 2] = dgv_AccessList.Rows[i].Cells[3].Value.ToString();

                        stand_api.setAccessList.S_List[i, 3] = dgv_AccessList.Rows[i].Cells[4].Value.ToString();
                        if (stand_api.setAccessList.S_List[i, 3] == "true")
                        {
                            stand_api.setAccessList.S_List[i, 3] = "Yes";
                        }
                        else
                        {
                            stand_api.setAccessList.S_List[i, 3] = "No";
                        }

                        stand_api.setAccessList.S_List[i, 4] = dgv_AccessList.Rows[i].Cells[5].Value.ToString();
                        stand_api.setAccessList.S_List[i, 5] = dgv_AccessList.Rows[i].Cells[6].Value.ToString();

                        stand_api.setAccessList.S_List[i, 6] = dgv_AccessList.Rows[i].Cells[7].Value.ToString();
                        if (stand_api.setAccessList.S_List[i, 6] == "true")
                        {
                            stand_api.setAccessList.S_List[i, 6] = "Yes";
                        }
                        else
                        {
                            stand_api.setAccessList.S_List[i, 6] = "No";
                        }

                        stand_api.setAccessList.S_List[i, 7] = dgv_AccessList.Rows[i].Cells[8].Value.ToString();
                        stand_api.setAccessList.S_List[i, 8] = dgv_AccessList.Rows[i].Cells[9].Value.ToString();

                    }
                }
                


                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.setAccessList.F_Request());
                tbx_MessageFormServer.Text = stand_api.setAccessList.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_RemoteOpen_Click(object sender, EventArgs e)
        {
            InitializeAccessForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.remoteOpen.S_Ccid = Convert.ToString(ccid);
                stand_api.remoteOpen.S_Action_ext = action_ext;

                stand_api.remoteOpen.CloudID = tbt_CloudID.Text;//
                stand_api.remoteOpen.SerialNo = _serialNo;//
                stand_api.remoteOpen.UserID = tbx_operatorID.Text;//

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.remoteOpen.F_Request());
                tbx_MessageFormServer.Text = stand_api.remoteOpen.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }
        #endregion

        #region Info.Button Function[本机信息，按键]

        private void btn_GetStoreStatus_Click(object sender, EventArgs e)
        {
            InitializeInfoForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getStoreStatus.S_Ccid = Convert.ToString(ccid);
                stand_api.getStoreStatus.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getStoreStatus.F_Request());
                tbx_MessageFormServer.Text = stand_api.getStoreStatus.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        private void btn_GetDeviceInfo_Click(object sender, EventArgs e)
        {
            InitializeInfoForm();
            try
            {
                Int32 ccid = ws_connect.AACCid;

                stand_api.getDeviceInfo.S_Ccid = Convert.ToString(ccid);
                stand_api.getDeviceInfo.S_Action_ext = action_ext;

                ws_connect.ws_NewMessage_Send(_ws_session, stand_api.getDeviceInfo.F_Request());
                tbx_MessageFormServer.Text = stand_api.getDeviceInfo.RequestXMLmassage;
            }
            catch
            {
                lbl_msg.Text = "ooh...the command cannot send to devices!!";
            }
        }

        #endregion


        #endregion

        #region Receive Massage Dispaly[接收信息显示]
        string stringXML_ResponseNode = null;
        string push_event0 = null;
        private void Thread_NewMessageResponse(WebSocketSession Serversession, string _stringXML_receiveMessage)//thread 
        {
            if (_ws_session == Serversession)
            {
                #region Instantiation Attributes[XML解析到实体Attributes[属性]中]

                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(_stringXML_receiveMessage);

                    #region Instantiation Attributes[将API收到的XML解析到实体Attributes[属性]中]
                    try
                    {
                        stringXML_ResponseNode = doc.SelectSingleNode("/Message/Response").InnerText;

                        if (stringXML_ResponseNode != null)
                        {
                           _string_receiveXML = _stringXML_receiveMessage;
                           switch (stringXML_ResponseNode)
                           {
                               #region UserPage[用户管理页面]
                               case "GetAllUserID":
                                   {
                                       stand_api.getAllUserID.F_Response(_stringXML_receiveMessage); break;
                                   } 
                               case "GetUserAllInfo": 
                                    {
                                        stand_api.getUserAllInfo.F_Response(_stringXML_receiveMessage); break;
                                    } 
                                case "GetUserSampleInfo":
                                    {
                                        stand_api.getUserSampleInfo.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetUserData":
                                    {
                                        stand_api.getUserData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetUserData":
                                    {
                                        stand_api.setUserData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetUserPassword":
                                    {
                                        stand_api.getUserPassword.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetUserCardNo":
                                    {
                                        stand_api.getUserCardNo.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetUserPhoto":
                                    {
                                        stand_api.getUserPhoto.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetUserPhoto":
                                    {
                                        stand_api.setUserPhoto.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetFingerData":
                                    {
                                        stand_api.getFingerData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetFingerData":
                                    {
                                        stand_api.setFingerData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetFingerDataByPicture":
                                    {
                                        stand_api.setFingerDataByPicture.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetFaceData":
                                    {
                                        stand_api.getFaceData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetFaceData":
                                    {
                                        stand_api.setFaceData.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetFaceDataByPicture":
                                    {
                                        stand_api.setFaceDataByPicture.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetUserQRCode":
                                    {
                                        stand_api.getUserQRCode.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "RemoteEnroll":
                                    {
                                        stand_api.remoteEnroll.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "ExitRemoteEnroll":
                                    {
                                        stand_api.exitRemoteEnroll.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "TakeOffManager":
                                    {
                                        stand_api.takeOffManager.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "GetIdantifyCard":
                                    {
                                        stand_api.getIdantifyCard.F_Response(_stringXML_receiveMessage); break;
                                    }

                                case "SetIdantifyCard":
                                    {
                                        stand_api.setIdantifyCard.F_Response(_stringXML_receiveMessage); break;
                                    }
                                #endregion

                               #region BasicPage[基本设置页面]
                                case "EnableDevice":
                                {
                                    stand_api.enableDevice.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetTime":
                                {
                                    stand_api.getTime.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetTime":
                                {
                                    stand_api.setTime.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetDepartment":
                                {
                                    stand_api.getDepartment.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetDepartment":
                                {
                                    stand_api.setDepartment.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetNameList":
                                {
                                    stand_api.getNameList.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetNameList":
                                {
                                    stand_api.setNameList.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetProxyName":
                                {
                                    stand_api.getProxyName.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetProxyName":
                                {
                                    stand_api.setProxyName.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetBellTime":
                                {
                                    stand_api.getBellTime.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetBellTime":
                                {
                                    stand_api.setBellTime.F_Response(_stringXML_receiveMessage); break;
                                }
                                #endregion

                               #region AdvancePage[高级设置页面]
                                case "TakePhoto":
                                {
                                    stand_api.takePhoto.F_Response(_stringXML_receiveMessage); break;
                                }
                               
                               case "GetDeviceSetting":
                                {
                                    stand_api.getDeviceSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetDeviceSetting":
                                {
                                    stand_api.setDeviceSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "RestoreDevice":
                                {
                                    stand_api.restoreDevice.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetPowerSetting":
                                {
                                    stand_api.getPowerSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetPowerSetting":
                                {
                                    stand_api.setPowerSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "FirmwareUpgradeByCloud":
                                {
                                    stand_api.firmwareUpgradeByCloud.F_Response(_stringXML_receiveMessage); break;
                                }
                               #endregion

                               #region NetPage[网络管理页面]
                                case "GetEthernetSetting":
                                {
                                    stand_api.getEthernetSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetEthernetSetting":
                                {
                                    stand_api.setEthernetSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetWifiSetting":
                                {
                                    stand_api.getWifiSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetWifiSetting":
                                {
                                    stand_api.setWifiSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetMobileNetSetting":
                                {
                                    stand_api.getMobileNetSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetMobileNetSetting":
                                {
                                    stand_api.setMobileNetSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetVPNServer":
                                {
                                    stand_api.getVPNServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetVPNServer":
                                {
                                    stand_api.setVPNServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetGPS":
                                {
                                    stand_api.getGPS.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetGPS":
                                {
                                    stand_api.setGPS.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetCloudServer":
                                {
                                    stand_api.getCloudServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetCloudServer":
                                {
                                    stand_api.setCloudServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetStreamingServer":
                                {
                                    stand_api.getStreamingServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetStreamingServer":
                                {
                                    stand_api.setStreamingServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetLocalServer":
                                {
                                    stand_api.getLocalServer.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetLocalServer":
                                {
                                    stand_api.setLocalServer.F_Response(_stringXML_receiveMessage); break;
                                }
                                #endregion

                               #region DataPage[数据管理页面]
                                case "EmptyTimeLog":
                                {
                                    stand_api.emptyTimeLog.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "EmptyManageLog":
                                {
                                    stand_api.emptyManageLog.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "EmptyUserEnrollmentData":
                                {
                                    stand_api.emptyUserEnrollmentData.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "EmptyAllData":
                                {
                                    stand_api.emptyAllData.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetLogSetting":
                                {
                                    stand_api.getLogSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetLogSetting":
                                {
                                    stand_api.setLogSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetFirstGlog":
                                {
                                    stand_api.getFirstGlog.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetNextGlog":
                                {
                                    stand_api.getNextGlog.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetAttendanceLog":
                                {
                                    stand_api.getAttendanceLog.F_Response(_stringXML_receiveMessage); break;
                                    //if (stand_api.getAttendanceLog.F_Response(_stringXML_receiveMessage)) 
                                    //{
                                    //    _stringXML_receiveMessage = "";
                                    //}; break;
                                }
                               #endregion

                               #region AttancePage[考勤管理页面]
                                case "GetAttendanceRule":
                                {
                                    stand_api.getAttendanceRule.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetAttendanceRule":
                                {
                                    stand_api.setAttendanceRule.F_Response(_stringXML_receiveMessage); break;
                                }
                               #endregion

                               #region AccessPage[门禁管理页面]
                                case "AccessStatus":
                                {
                                    stand_api.accessStatus.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetAccessSetting":
                                {
                                    stand_api.getAccessSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetAccessSetting":
                                {
                                    stand_api.setAccessSetting.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetAccessList":
                                {
                                    stand_api.getAccessList.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "SetAccessList":
                                {
                                    stand_api.setAccessList.F_Response(_stringXML_receiveMessage); break;
                                }

                               #endregion

                               #region InfoPage[本机信息页面]
                                case "GetStoreStatus":
                                {
                                    stand_api.getStoreStatus.F_Response(_stringXML_receiveMessage); break;
                                }

                                case "GetDeviceInfo":
                                {
                                    stand_api.getDeviceInfo.F_Response(_stringXML_receiveMessage); break;
                                }
                               #endregion
                           }
                        }
                    }
                    catch { }
                    #endregion
                    #region realTiome log["TimeLog"考勤记录响应]
                    try
                    {
                        push_event0 = doc.SelectSingleNode("/Message/Event").InnerText;
                        stand_api.timelog.API_TimeLog_XML(Serversession, _stringXML_receiveMessage, true);
                    }
                    catch (System.Exception) { }
                    #endregion

                }
                catch
                {
                    //其他解析不出XML的直接回显。
                    MessageBox.Show("Oh...I don't know this XML,do you confirm that is correct Response form the device?/r/n");
                }
                Thread threadConsole = new Thread(new ThreadStart(Invoke_NewMessageResponse));
                threadConsole.Start();
                #endregion
            }
        }

        private delegate void delegate_NewMessageResponse();
        /// <summary>
        /// 安全线程
        /// </summary>
        private void Invoke_NewMessageResponse()//thread 
        {
            try
            {
                Invoke(new delegate_NewMessageResponse(Function_NewMessageResponse), null);
            }
            catch 
            {
                _ws_Server.NewMessageReceived -= new SessionHandler<WebSocketSession, string>(Thread_NewMessageResponse); 
                //this.Close();
            }
        }
        /// <summary>
        /// 线程Function[方法]，将接收到的信息进行显示在对应的窗体控件上
        /// </summary>
        public void Function_NewMessageResponse()
        {
            #region dispaly to tbx_MessageFormDevice[所有的反馈响应都显示在tbx_MessageFormDevice文本框中]
            tbx_MessageFormDevice.Text = _string_receiveXML;
            #endregion

            #region dispaly to form[将每个指令解析到的内容显示到窗体对应的位置上]

            switch (stringXML_ResponseNode)
            {
                
                #region UserPage[用户管理页面]

                #region "GetAllUserID"
                case "GetAllUserID":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getAllUserID.Actid;
                            tbx_TerminalType.Text = stand_api.getAllUserID.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getAllUserID.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getAllUserID.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getAllUserID.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getAllUserID.Version;
                            tbx_Action_ext.Text = stand_api.getAllUserID.Action_ext;
                            tbx_Response.Text = stand_api.getAllUserID.Response;
                            //--------->

                            //工号
                            tbx_AllUserID.Text = stand_api.getAllUserID.UserID;

                            lbl_msg.Text = "Result：" + stand_api.getAllUserID.Result;
                        }
                        catch { }
                        break;
                    }

                #endregion

                #region "GetUserAllInfo"
                case "GetUserAllInfo":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getUserAllInfo.Actid;
                            tbx_TerminalType.Text = stand_api.getUserAllInfo.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserAllInfo.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserAllInfo.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserAllInfo.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserAllInfo.Version;
                            tbx_Action_ext.Text = stand_api.getUserAllInfo.Action_ext;
                            tbx_Response.Text = stand_api.getUserAllInfo.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getUserAllInfo.UserID;
                            //名字
                            tbx_Name.Text = stand_api.getUserAllInfo.Name;
                            //级别
                            cobx_Privilege.SelectedItem = stand_api.getUserAllInfo.Privilege;
                            //部门，名单
                            cobx_Depart_U.SelectedIndex = Convert.ToInt32(stand_api.getUserAllInfo.Depart);
                            //用户使能与否
                            if (stand_api.getUserAllInfo.Enabled == "Yes")
                            {
                                cbx_Enabled.Checked = true;
                            }
                            else
                            {
                                cbx_Enabled.Checked = false;
                            }
                            //卡号
                            tbx_Card.Text = stand_api.getUserAllInfo.Card;
                            //密码
                            tbx_PWD.Text = stand_api.getUserAllInfo.PWD;
                            //指纹注册总数
                            tbx_Fingers.Text = stand_api.getUserAllInfo.Fingers;
                            //指纹注册数据
                            Int32 EnrollFingers = Convert.ToInt32(stand_api.getUserAllInfo.Fingers) ;
                            //dgv_FingerData.Rows.Clear();
                            if (EnrollFingers != 0 && EnrollFingers <=10)
                            {
                                for (int ii = 0; ii < EnrollFingers; ii++)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                    id.Value = stand_api.getUserAllInfo.IDs[ii];
                                    Int32 i = Convert.ToInt32(id.Value);
                                    row.Cells.Add(id);

                                    DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                                    data.Value = stand_api.getUserAllInfo.FingersData[i - 1];
                                    row.Cells.Add(data);

                                    DataGridViewCheckBoxCell duress = new DataGridViewCheckBoxCell();
                                    if (stand_api.getUserAllInfo.Duress[i - 1] == "Yes")
                                    {
                                        duress.Value = true;
                                    }
                                    else
                                    {
                                        duress.Value = false;
                                    }
                                    row.Cells.Add(duress);
                                    //<----点击保存
                                    DataGridViewButtonCell save = new DataGridViewButtonCell();
                                    save.Value = "save";
                                    row.Cells.Add(save);
                                    //---->
                                    dgv_FingerData.Rows.Add(row);
                                }
                            }
                            //人脸是否注册
                            if (stand_api.getUserAllInfo.FaceData == null || stand_api.getUserAllInfo.FaceData == "")
                            {
                                cbx_FaceEnroll.Checked = false;
                                btn_saveFaceData.Enabled = false;
                            }
                            else
                            {
                                cbx_FaceEnroll.Checked = true;
                                btn_saveFaceData.Enabled = true;
                            }
                            //人脸注册数据
                            tbx_FaceData.Text = stand_api.getUserAllInfo.FaceData;

                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetUserSampleInfo" 
                case "GetUserSampleInfo":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getUserSampleInfo.Actid;
                            tbx_TerminalType.Text = stand_api.getUserSampleInfo.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserSampleInfo.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserSampleInfo.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserSampleInfo.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserSampleInfo.Version;
                            tbx_Action_ext.Text = stand_api.getUserSampleInfo.Action_ext;
                            tbx_Response.Text = stand_api.getUserSampleInfo.Response;
                            //--------->
                            btn_GetNextSampleInfo.Visible = true;

                            //工号
                            tbx_UserID.Text = stand_api.getUserSampleInfo.UserSampleInfo[0, 0];
                            //名字
                            tbx_Name.Text = stand_api.getUserSampleInfo.UserSampleInfo[0, 1];
                            //级别
                            cobx_Privilege.SelectedItem = stand_api.getUserSampleInfo.UserSampleInfo[0, 2];
                            //部门，名单
                            cobx_Depart_U.SelectedIndex = Convert.ToInt32(stand_api.getUserSampleInfo.UserSampleInfo[0, 3]);
                        
                            //卡号
                            tbx_Card.Text = stand_api.getUserSampleInfo.UserSampleInfo[0, 4];
                            //密码
                            tbx_PWD.Text = stand_api.getUserSampleInfo.UserSampleInfo[0, 5];
                            //指纹注册总数
                            tbx_Fingers.Text = stand_api.getUserSampleInfo.UserSampleInfo[0, 6];

                            //是否注册了人脸
                            if (stand_api.getUserSampleInfo.UserSampleInfo[0, 7] == "Yes")
                            {
                                cbx_FaceEnroll.Checked = true;
                            }
                            else
                            {
                                cbx_FaceEnroll.Checked = false;
                            }

                            btn_GetNextSampleInfo.Text = "1/" + stand_api.getUserSampleInfo.UserCounts + "     Click For Next";
                            lbl_msg.Text = "Result：" + stand_api.getUserSampleInfo.Result;
                        }
                        catch { }
                        
                        break;
                    }

                #endregion

                #region "GetUserData"
                case "GetUserData":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getUserData.Actid;
                            tbx_TerminalType.Text = stand_api.getUserData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserData.Version;
                            tbx_Action_ext.Text = stand_api.getUserData.Action_ext;
                            tbx_Response.Text = stand_api.getUserData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getUserData.UserID;
                            //名字
                            tbx_Name.Text = stand_api.getUserData.Name;
                            //级别
                            cobx_Privilege.SelectedItem = stand_api.getUserData.Privilege;
                            //switch (stand_api.getUserData.Privilege)
                            //{
                            //    case "User": cobx_Privilege.SelectedIndex = 0; break;
                            //    case "Register": cobx_Privilege.SelectedIndex = 1; break;
                            //    case "Manager": cobx_Privilege.SelectedIndex = 2; break;
                            //    case "SuperManager": cobx_Privilege.SelectedIndex = 3; break;
                            //}
                            //部门，名单
                            cobx_Depart_U.SelectedIndex = Convert.ToInt32(stand_api.getUserData.Depart);
                            //用户使能与否
                            if (stand_api.getUserData.Enabled == "Yes")
                            {
                                cbx_Enabled.Checked = true;
                            }
                            else
                            {
                                cbx_Enabled.Checked = false;
                            }
                            //卡号
                            tbx_Card.Text = stand_api.getUserData.Card;
                            //密码
                            tbx_PWD.Text = stand_api.getUserData.PWD;
                            //指纹注册总数
                            tbx_Fingers.Text = stand_api.getUserData.Fingers;

                            //是否注册了人脸
                            if (stand_api.getUserData.FaceEnrolled == "Yes")
                            {
                                cbx_FaceEnroll.Checked = true;
                            }
                            else
                            {
                                cbx_FaceEnroll.Checked = false;
                            }

                        }
                        catch { }
                        break;
                    }

                #endregion

                #region "SetUserData"
                case "SetUserData":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.setUserData.Actid;
                            tbx_TerminalType.Text = stand_api.setUserData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setUserData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setUserData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setUserData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setUserData.Version;
                            tbx_Action_ext.Text = stand_api.setUserData.Action_ext;
                            tbx_Response.Text = stand_api.setUserData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setUserData.UserID;
                        }
                        catch { }
                        break;
                    }

                #endregion

                #region "GetUserPassword"
                case "GetUserPassword":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.getUserPassword.Actid;
                            tbx_TerminalType.Text = stand_api.getUserPassword.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserPassword.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserPassword.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserPassword.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserPassword.Version;
                            tbx_Action_ext.Text = stand_api.getUserPassword.Action_ext;
                            tbx_Response.Text = stand_api.getUserPassword.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getUserPassword.UserID;
                            //密码
                            tbx_PWD.Text = stand_api.getUserPassword.Password;
                        }
                        catch { } 
                        break;
                    }
                #endregion

                #region "GetUserCardNo"

                case "GetUserCardNo":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.getUserCardNo.Actid;
                            tbx_TerminalType.Text = stand_api.getUserCardNo.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserCardNo.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserCardNo.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserCardNo.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserCardNo.Version;
                            tbx_Action_ext.Text = stand_api.getUserCardNo.Action_ext;
                            tbx_Response.Text = stand_api.getUserCardNo.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getUserCardNo.UserID;
                            //卡号
                            tbx_Card.Text = stand_api.getUserCardNo.CardNo;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetUserPhoto"

                case "GetUserPhoto":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.getUserPhoto.Actid;
                            tbx_TerminalType.Text = stand_api.getUserPhoto.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getUserPhoto.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getUserPhoto.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getUserPhoto.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getUserPhoto.Version;
                            tbx_Action_ext.Text = stand_api.getUserPhoto.Action_ext;
                            tbx_Response.Text = stand_api.getUserPhoto.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getUserPhoto.UserID;
                            //照片
                            string _string_photoData = stand_api.getUserPhoto.PhotoData;
                            if (_string_photoData != null)
                            {
                                try
                                {
                                    Byte[] photoByte = null;
                                    Image realtimeimg = null;
                                    photoByte = Convert.FromBase64String(_string_photoData);
                                    realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                                    pbx_UserPhoto.Image = realtimeimg;
                                }
                                catch { }
                            
                            }
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetUserPhoto"

                case "SetUserPhoto":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.setUserPhoto.Actid;
                            tbx_TerminalType.Text = stand_api.setUserPhoto.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setUserPhoto.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setUserPhoto.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setUserPhoto.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setUserPhoto.Version;
                            tbx_Action_ext.Text = stand_api.setUserPhoto.Action_ext;
                            tbx_Response.Text = stand_api.setUserPhoto.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setUserPhoto.UserID;
                            lbl_msg.Text = "Result:" + stand_api.setUserPhoto.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion

                #region "GetFingerData"

                case "GetFingerData":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.getFingerData.Actid;
                            tbx_TerminalType.Text = stand_api.getFingerData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getFingerData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getFingerData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getFingerData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getFingerData.Version;
                            tbx_Action_ext.Text = stand_api.getFingerData.Action_ext;
                            tbx_Response.Text = stand_api.getFingerData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getFingerData.UserID;
                            //指纹编号
                            Int32 EnrollFingers = Convert.ToInt32(stand_api.getFingerData.FingerNo);
                            cobx_Depart_U.SelectedIndex = EnrollFingers;

                        
                            if (0 <= EnrollFingers && EnrollFingers <= 10)
                            {
                            
                                DataGridViewRow row = new DataGridViewRow();
                                //指纹编号
                                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                id.Value = stand_api.getFingerData.FingerNo;
                                row.Cells.Add(id);
                                //指纹数据
                                DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                                data.Value = stand_api.getFingerData.FingerData;
                                row.Cells.Add(data);
                                //胁迫报警
                                DataGridViewCheckBoxCell duress = new DataGridViewCheckBoxCell();
                                if (stand_api.getFingerData.Duress == "Yes")
                                {
                                    duress.Value = true;
                                }
                                else
                                {
                                    duress.Value = false;
                                }
                                row.Cells.Add(duress);
                                //保存
                                DataGridViewButtonCell save = new DataGridViewButtonCell();
                                save.Value = "save";
                                row.Cells.Add(save);

                                dgv_FingerData.Rows.Add(row);
                            }
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetFingerData"

                case "SetFingerData":
                    {

                        try 
                        { 
                            //<-------
                            tbx_Actid.Text = stand_api.setFingerData.Actid;
                            tbx_TerminalType.Text = stand_api.setFingerData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setFingerData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setFingerData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setFingerData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setFingerData.Version;
                            tbx_Action_ext.Text = stand_api.setFingerData.Action_ext;
                            tbx_Response.Text = stand_api.setFingerData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setFingerData.UserID;
                            //指纹编号
                            Int32 EnrollFingers = Convert.ToInt32(stand_api.setFingerData.FingerNo);
                            cobx_Depart_U.SelectedIndex = EnrollFingers;



                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetFingerDataByPicture"

                case "SetFingerDataByPicture":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.setFingerDataByPicture.Actid;
                            tbx_TerminalType.Text = stand_api.setFingerDataByPicture.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setFingerDataByPicture.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setFingerDataByPicture.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setFingerDataByPicture.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setFingerDataByPicture.Version;
                            tbx_Action_ext.Text = stand_api.setFingerDataByPicture.Action_ext;
                            tbx_Response.Text = stand_api.setFingerDataByPicture.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setFingerDataByPicture.UserID;
                            //指纹编号
                            Int32 EnrollFingers = Convert.ToInt32(stand_api.setFingerDataByPicture.FingerNo);
                            cobx_Depart_U.SelectedIndex = EnrollFingers;
                        }
                        catch { }

                        break;
                    }
                #endregion

                #region "GetFaceData"

                case "GetFaceData":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.getFaceData.Actid;
                            tbx_TerminalType.Text = stand_api.getFaceData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getFaceData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getFaceData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getFaceData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getFaceData.Version;
                            tbx_Action_ext.Text = stand_api.getFaceData.Action_ext;
                            tbx_Response.Text = stand_api.getFaceData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.getFaceData.UserID;
                            //人脸是否注册
                            if (stand_api.getFaceData.FaceEnrolled == "Yes")
                            {
                                cbx_FaceEnroll.Checked = true;
                                btn_saveFaceData.Enabled = true;
                                //人脸数据
                                tbx_FaceData.Text = stand_api.getFaceData.FaceData;
                            }
                            else
                            {
                                btn_saveFaceData.Enabled = false;
                                cbx_FaceEnroll.Checked = false;
                                tbx_FaceData.Text = "";
                            }
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetFaceData"

                case "SetFaceData":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setFaceData.Actid;
                            tbx_TerminalType.Text = stand_api.setFaceData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setFaceData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setFaceData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setFaceData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setFaceData.Version;
                            tbx_Action_ext.Text = stand_api.setFaceData.Action_ext;
                            tbx_Response.Text = stand_api.setFaceData.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setFaceData.UserID;
                        }
                        catch { }
                        break;
                    }
                #endregion


                #region "RemoteEnroll"
                case "RemoteEnroll":
                    {
                        try
                        {

                        
                            //<-------
                            tbx_Actid.Text = stand_api.remoteEnroll.Actid;
                            tbx_TerminalType.Text = stand_api.remoteEnroll.TerminalType;
                            tbx_HardwareVer.Text = stand_api.remoteEnroll.HardwareVer;
                            tbx_TerminalID.Text = stand_api.remoteEnroll.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.remoteEnroll.DeviceSerialNo;
                            tbx_Version.Text = stand_api.remoteEnroll.Version;
                            tbx_Action_ext.Text = stand_api.remoteEnroll.Action_ext;
                            tbx_Response.Text = stand_api.remoteEnroll.Response;
                            //--------->
                            lbl_msg.Text = "远程注册Result：" + stand_api.remoteEnroll.ResultCode;
                        }
                        catch { } 
                        break;
                    }
                #endregion

                #region "ExitRemoteEnroll"
                case "ExitRemoteEnroll":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.exitRemoteEnroll.Actid;
                            tbx_TerminalType.Text = stand_api.exitRemoteEnroll.TerminalType;
                            tbx_HardwareVer.Text = stand_api.exitRemoteEnroll.HardwareVer;
                            tbx_TerminalID.Text = stand_api.exitRemoteEnroll.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.exitRemoteEnroll.DeviceSerialNo;
                            tbx_Version.Text = stand_api.exitRemoteEnroll.Version;
                            tbx_Action_ext.Text = stand_api.exitRemoteEnroll.Action_ext;
                            tbx_Response.Text = stand_api.exitRemoteEnroll.Response;
                            //--------->
                            lbl_msg.Text = "远程注册Result：" + stand_api.exitRemoteEnroll.ResultCode;
                         }
                        catch { }
                        break;
                    }
                #endregion

                #region "TakeOffManager"
                case "TakeOffManager":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.takeOffManager.Actid;
                            tbx_TerminalType.Text = stand_api.takeOffManager.TerminalType;
                            tbx_HardwareVer.Text = stand_api.takeOffManager.HardwareVer;
                            tbx_TerminalID.Text = stand_api.takeOffManager.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.takeOffManager.DeviceSerialNo;
                            tbx_Version.Text = stand_api.takeOffManager.Version;
                            tbx_Action_ext.Text = stand_api.takeOffManager.Action_ext;
                            tbx_Response.Text = stand_api.takeOffManager.Response;
                            //--------->
                            lbl_msg.Text = "Result:" + stand_api.takeOffManager.Result;
                         }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetIdantifyCard"
                case "GetIdantifyCard":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getIdantifyCard.Actid;
                            tbx_TerminalType.Text = stand_api.getIdantifyCard.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getIdantifyCard.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getIdantifyCard.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getIdantifyCard.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getIdantifyCard.Version;
                            tbx_Action_ext.Text = stand_api.getIdantifyCard.Action_ext;
                            tbx_Response.Text = stand_api.getIdantifyCard.Response;
                            //--------->

                            tbx_IDName.Text = stand_api.getIdantifyCard.Name;
                            cobx_IDGender.SelectedItem = stand_api.getIdantifyCard.Gender;
                            tbx_IDNation.Text = stand_api.getIdantifyCard.Nation;
                            tbx_IDBirthday.Text = stand_api.getIdantifyCard.Birthday;
                            tbx_IDAddress.Text = stand_api.getIdantifyCard.Address;
                            tbx_IDUserID.Text = stand_api.getIdantifyCard.UserID;
                            tbx_IDAuthority.Text = stand_api.getIdantifyCard.Authority;
                            tbx_IDValidDate.Text = stand_api.getIdantifyCard.ValidDate;

                            string _string_photoData = stand_api.getIdantifyCard.Photo;
                            if (_string_photoData != null)
                            {
                                try
                                {
                                    Byte[] photoByte = null;
                                    Image realtimeimg = null;
                                    photoByte = Convert.FromBase64String(_string_photoData);
                                    realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                                    pbx_IDPhoto.Image = realtimeimg;
                                }
                                catch { }
                            
                            }


                            lbl_msg.Text = "Result:" + stand_api.getIdantifyCard.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetIdantifyCard"

                case "SetIdantifyCard":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setIdantifyCard.Actid;
                            tbx_TerminalType.Text = stand_api.setIdantifyCard.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setIdantifyCard.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setIdantifyCard.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setIdantifyCard.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setIdantifyCard.Version;
                            tbx_Action_ext.Text = stand_api.setIdantifyCard.Action_ext;
                            tbx_Response.Text = stand_api.setIdantifyCard.Response;
                            //--------->

                            //工号
                            tbx_UserID.Text = stand_api.setIdantifyCard.UserID;
                            lbl_msg.Text = "Result:" + stand_api.setIdantifyCard.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #endregion

                #region BasicPage[基本设置页面]

                #region "EnableDevice"
                case "EnableDevice":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.enableDevice.Actid;
                            tbx_TerminalType.Text = stand_api.enableDevice.TerminalType;
                            tbx_HardwareVer.Text = stand_api.enableDevice.HardwareVer;
                            tbx_TerminalID.Text = stand_api.enableDevice.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.enableDevice.DeviceSerialNo;
                            tbx_Version.Text = stand_api.enableDevice.Version;
                            tbx_Action_ext.Text = stand_api.enableDevice.Action_ext;
                            tbx_Response.Text = stand_api.enableDevice.Response;
                            //--------->
                            lbl_msg.Text = "Result:" + stand_api.enableDevice.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetTime"
                case "GetTime":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getTime.Actid;
                            tbx_TerminalType.Text = stand_api.getTime.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getTime.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getTime.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getTime.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getTime.Version;
                            tbx_Action_ext.Text = stand_api.getTime.Action_ext;
                            tbx_Response.Text = stand_api.getTime.Response;
                            //--------->
                            string T = stand_api.getTime.Time;
                            string U = stand_api.getTime.UTC;

                            string[] temp = T.Split('T');
                            string d = temp[0].Substring(0, temp[0].Length-1);
                            string t = temp[1].Substring(0, temp[1].Length-1);

                            if (U == null || U == "")
                            {
                                lbl_GetDeviceTime.Text = "Time:" + d + "  " + t;
                            }
                            else
                            {
                                lbl_GetDeviceTime.Text = "Time:" + d + "  " + t + "      UTC:" + U;
                            }

                            lbl_msg.Text = "Result:" + stand_api.getTime.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetTime"
                case "SetTime":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setTime.Actid;
                            tbx_TerminalType.Text = stand_api.setTime.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setTime.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setTime.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setTime.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setTime.Version;
                            tbx_Action_ext.Text = stand_api.setTime.Action_ext;
                            tbx_Response.Text = stand_api.setTime.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setTime.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetDepartment"
                case "GetDepartment":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getDepartment.Actid;
                            tbx_TerminalType.Text = stand_api.getDepartment.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getDepartment.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getDepartment.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getDepartment.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getDepartment.Version;
                            tbx_Action_ext.Text = stand_api.getDepartment.Action_ext;
                            tbx_Response.Text = stand_api.getDepartment.Response;
                            //--------->
                            cobx_Depart_B.SelectedIndex = Convert.ToInt32(stand_api.getDepartment.DeptNo);

                            tbx_DepartName.Text = stand_api.getDepartment.Name;
                            lbl_msg.Text = "Result:" + stand_api.getDepartment.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetDepartment"
                case "SetDepartment":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setDepartment.Actid;
                            tbx_TerminalType.Text = stand_api.setDepartment.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setDepartment.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setDepartment.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setDepartment.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setDepartment.Version;
                            tbx_Action_ext.Text = stand_api.setDepartment.Action_ext;
                            tbx_Response.Text = stand_api.setDepartment.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setDepartment.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetNameList"
                case "GetNameList":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getNameList.Actid;
                            tbx_TerminalType.Text = stand_api.getNameList.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getNameList.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getNameList.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getNameList.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getNameList.Version;
                            tbx_Action_ext.Text = stand_api.getNameList.Action_ext;
                            tbx_Response.Text = stand_api.getNameList.Response;
                            //--------->
                            cobx_ListNo.SelectedIndex = Convert.ToInt32(stand_api.getNameList.ListNo);

                            tbx_NameListName.Text = stand_api.getNameList.Name;
                            lbl_msg.Text = "Result:" + stand_api.getNameList.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetNameList"
                case "SetNameList":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setNameList.Actid;
                            tbx_TerminalType.Text = stand_api.setNameList.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setNameList.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setNameList.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setNameList.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setNameList.Version;
                            tbx_Action_ext.Text = stand_api.setNameList.Action_ext;
                            tbx_Response.Text = stand_api.setNameList.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setNameList.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetProxyName"
                case "GetProxyName":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getProxyName.Actid;
                            tbx_TerminalType.Text = stand_api.getProxyName.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getProxyName.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getProxyName.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getProxyName.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getProxyName.Version;
                            tbx_Action_ext.Text = stand_api.getProxyName.Action_ext;
                            tbx_Response.Text = stand_api.getProxyName.Response;
                            //--------->

                            if (stand_api.getProxyName.Use == "Yes")
                            {
                                cbx_UseProxy.Checked = true;
                            }
                            else
                            {
                                cbx_UseProxy.Checked = false;
                            }
                            cobx_ProxyNo.SelectedIndex = Convert.ToInt32(stand_api.getProxyName.DeptNo);
                            tbx_ProxyName.Text = stand_api.getProxyName.Name;
                            lbl_msg.Text = "Result:" + stand_api.getProxyName.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetProxyName"
                case "SetProxyName":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setProxyName.Actid;
                            tbx_TerminalType.Text = stand_api.setProxyName.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setProxyName.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setProxyName.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setProxyName.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setProxyName.Version;
                            tbx_Action_ext.Text = stand_api.setProxyName.Action_ext;
                            tbx_Response.Text = stand_api.setProxyName.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setProxyName.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetBellTime"
                case "GetBellTime":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getBellTime.Actid;
                            tbx_TerminalType.Text = stand_api.getBellTime.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getBellTime.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getBellTime.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getBellTime.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getBellTime.Version;
                            tbx_Action_ext.Text = stand_api.getBellTime.Action_ext;
                            tbx_Response.Text = stand_api.getBellTime.Response;
                            //--------->

                            dgv_BellSetting.Rows.Clear();
                            string[] B ;

                            for (int i = 0; i < 24; i++)
                            {
                                B = new string[4];
                                B = stand_api.getBellTime.Bell[i].Split(',');

                                DataGridViewRow row = new DataGridViewRow();
                                //第一列，编号
                                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                id.Value = Convert.ToString(i);
                                row.Cells.Add(id);

                                //第二列，时间
                                DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                                data.Value = B[0];//
                                row.Cells.Add(data);

                                //第三列，使用
                                DataGridViewCheckBoxCell use = new DataGridViewCheckBoxCell();
                                if (B[1] == "use")
                                {
                                    use.Value = true;
                                }
                                else
                                {
                                    use.Value = false;
                                }
                                row.Cells.Add(use);

                                //第四列，周期
                                DataGridViewComboBoxCell cycle = new DataGridViewComboBoxCell();
                                for (int n = 0; n < DB_def.BellTimeCycle.Length; n++)
                                {
                                    cycle.Items.Add(DB_def.BellTimeCycle[n]);
                                }
                                cycle.Value = B[2];
                                row.Cells.Add(cycle);

                                //第五列，次数
                                DataGridViewTextBoxCell times = new DataGridViewTextBoxCell();
                                times.Value = B[3];
                                row.Cells.Add(times);

                                dgv_BellSetting.Rows.Add(row);
                            
                            }


                            lbl_msg.Text = "Result:" + stand_api.getBellTime.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion

                #region "SetBellTime"
                case "SetBellTime":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setBellTime.Actid;
                            tbx_TerminalType.Text = stand_api.setBellTime.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setBellTime.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setBellTime.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setBellTime.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setBellTime.Version;
                            tbx_Action_ext.Text = stand_api.setBellTime.Action_ext;
                            tbx_Response.Text = stand_api.setBellTime.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setBellTime.Result;
                        
                        }
                        catch { }
                        break;
                    }
                #endregion

                #endregion

                #region AdvancePage[高级设置页面]

                #region "TakePhoto"

                case "TakePhoto":
                    {
                        try
                        {

                            //<-------
                            tbx_Actid.Text = stand_api.takePhoto.Actid;
                            tbx_TerminalType.Text = stand_api.takePhoto.TerminalType;
                            tbx_HardwareVer.Text = stand_api.takePhoto.HardwareVer;
                            tbx_TerminalID.Text = stand_api.takePhoto.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.takePhoto.DeviceSerialNo;
                            tbx_Version.Text = stand_api.takePhoto.Version;
                            tbx_Action_ext.Text = stand_api.takePhoto.Action_ext;
                            tbx_Response.Text = stand_api.takePhoto.Response;
                            //--------->

                            //照片类型
                            cobx_Camera.SelectedItem = stand_api.takePhoto.Camera;
                            //照片
                            string _string_photoData = stand_api.takePhoto.PhotoData;
                            if (_string_photoData != null)
                            {
                                try
                                {
                                    Byte[] photoByte = null;
                                    Image realtimeimg = null;
                                    photoByte = Convert.FromBase64String(_string_photoData);
                                    realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));
                                    pbx_TakePhoto.Image = realtimeimg;
                                }
                                catch { }
                            
                            }
                        }
                        catch { }
                        break;
                    }
                #endregion
                    

                #region "GetDeviceSetting"
                case "GetDeviceSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getDeviceSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getDeviceSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getDeviceSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getDeviceSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getDeviceSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getDeviceSetting.Version;
                            tbx_Action_ext.Text = stand_api.getDeviceSetting.Action_ext;
                            tbx_Response.Text = stand_api.getDeviceSetting.Response;
                            //--------->

                            cobx_Language.SelectedItem = stand_api.getDeviceSetting.Language;
                            cobx_Volume.SelectedIndex = Convert.ToInt32( stand_api.getDeviceSetting.Volume);
                            cobx_IdentifyMode.SelectedItem = stand_api.getDeviceSetting.IdentifyMode;

                            if (stand_api.getDeviceSetting.RealTimePhoto == "Yes")
                            {
                                cbx_RealTimePhoto.Checked = true;
                            }
                            else
                            {
                                cbx_RealTimePhoto.Checked = false;
                            }

                            if (stand_api.getDeviceSetting.LivingMode == "Yes")
                            {
                                cbx_LivingMode.Checked = true;
                            }
                            else
                            {
                                cbx_LivingMode.Checked = false;
                            }

                            tbx_SwipeIDCardCount.Text = stand_api.getDeviceSetting.SwipeIDCardCount;

                            lbl_msg.Text = "Result:" + stand_api.getDeviceSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetDeviceSetting"
                case "SetDeviceSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setDeviceSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setDeviceSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setDeviceSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setDeviceSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setDeviceSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setDeviceSetting.Version;
                            tbx_Action_ext.Text = stand_api.setDeviceSetting.Action_ext;
                            tbx_Response.Text = stand_api.setDeviceSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setDeviceSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "RestoreDevice"
                case "RestoreDevice":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.restoreDevice.Actid;
                            tbx_TerminalType.Text = stand_api.restoreDevice.TerminalType;
                            tbx_HardwareVer.Text = stand_api.restoreDevice.HardwareVer;
                            tbx_TerminalID.Text = stand_api.restoreDevice.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.restoreDevice.DeviceSerialNo;
                            tbx_Version.Text = stand_api.restoreDevice.Version;
                            tbx_Action_ext.Text = stand_api.restoreDevice.Action_ext;
                            tbx_Response.Text = stand_api.restoreDevice.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.restoreDevice.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetPowerSetting"
                case "GetPowerSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getPowerSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getPowerSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getPowerSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getPowerSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getPowerSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getPowerSetting.Version;
                            tbx_Action_ext.Text = stand_api.getPowerSetting.Action_ext;
                            tbx_Response.Text = stand_api.getPowerSetting.Response;
                            //--------->

                            if (stand_api.getPowerSetting.Restart == "Yes")
                            {
                                cbx_Restart.Checked = true;
                            }
                            else
                            {
                                cbx_Restart.Checked = false;
                            }

                            if (stand_api.getPowerSetting.RestartTime != null)
                            {
                                //dtp_RestartTime.Value = stand_api.getPowerSetting.RestartTime;
                                dtp_RestartTime.Value = Convert.ToDateTime(stand_api.getPowerSetting.RestartTime);
                            }

                            tbx_SleepAfter.Text = stand_api.getPowerSetting.SleepAfter;
                            if (stand_api.getPowerSetting.ScreenSaver == "Yes")
                            {
                                cbx_ScreenSaver.Checked = true;
                            }
                            else
                            {
                                cbx_ScreenSaver.Checked = false;
                            }
                            if (stand_api.getPowerSetting.PowerKey == "Yes")
                            {
                                cbx_PowerKey.Checked = true;
                            }
                            else
                            {
                                cbx_PowerKey.Checked = false;
                            }


                            lbl_msg.Text = "Result:" + stand_api.getPowerSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetPowerSetting"
                case "SetPowerSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setPowerSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setPowerSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setPowerSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setPowerSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setPowerSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setPowerSetting.Version;
                            tbx_Action_ext.Text = stand_api.setPowerSetting.Action_ext;
                            tbx_Response.Text = stand_api.setPowerSetting.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setPowerSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "FirmwareUpgradeByCloud"
                case "FirmwareUpgradeByCloud":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.firmwareUpgradeByCloud.Actid;
                            tbx_TerminalType.Text = stand_api.firmwareUpgradeByCloud.TerminalType;
                            tbx_HardwareVer.Text = stand_api.firmwareUpgradeByCloud.HardwareVer;
                            tbx_TerminalID.Text = stand_api.firmwareUpgradeByCloud.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.firmwareUpgradeByCloud.DeviceSerialNo;
                            tbx_Version.Text = stand_api.firmwareUpgradeByCloud.Version;
                            tbx_Action_ext.Text = stand_api.firmwareUpgradeByCloud.Action_ext;
                            tbx_Response.Text = stand_api.firmwareUpgradeByCloud.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.firmwareUpgradeByCloud.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion
                    
                #endregion

                #region NetPage[网络管理页面]

                #region "GetEthernetSetting"
                case "GetEthernetSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getEthernetSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getEthernetSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getEthernetSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getEthernetSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getEthernetSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getEthernetSetting.Version;
                            tbx_Action_ext.Text = stand_api.getEthernetSetting.Action_ext;
                            tbx_Response.Text = stand_api.getEthernetSetting.Response;
                            //--------->

                            lbl_MAC.Text = stand_api.getEthernetSetting.MacAddress;
                            tbx_NetIP.Text = stand_api.getEthernetSetting.IP;
                            tbx_NetSubnet.Text = stand_api.getEthernetSetting.Subnet;
                            tbx_NetGateway.Text = stand_api.getEthernetSetting.DefaultGateway;

                            if (stand_api.getEthernetSetting.DHCP == "Yes")
                            {
                                cbx_DHCP.Checked= true;
                                tbx_DHCPIP.Text = stand_api.getEthernetSetting.IP_from_dhcp;
                                tbx_DHCPSubnet.Text = stand_api.getEthernetSetting.Subnet_from_dhcp;
                                tbx_DHCPGateway.Text = stand_api.getEthernetSetting.DefaultGateway_from_dhcp;
                            }
                            else
                            {
                                tbx_DHCPIP.Enabled = false;
                                tbx_DHCPSubnet.Enabled = false;
                                tbx_DHCPGateway.Enabled = false;
                            }


                            lbl_msg.Text = "Result:" + stand_api.getEthernetSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetEthernetSetting"
                case "SetEthernetSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setEthernetSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setEthernetSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setEthernetSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setEthernetSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setEthernetSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setEthernetSetting.Version;
                            tbx_Action_ext.Text = stand_api.setEthernetSetting.Action_ext;
                            tbx_Response.Text = stand_api.setEthernetSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setEthernetSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetWifiSetting"
                case "GetWifiSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getWifiSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getWifiSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getWifiSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getWifiSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getWifiSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getWifiSetting.Version;
                            tbx_Action_ext.Text = stand_api.getWifiSetting.Action_ext;
                            tbx_Response.Text = stand_api.getWifiSetting.Response;
                            //--------->

                            if (stand_api.getWifiSetting.Use == "Yes")
                            {
                                cbx_useWIFI.Checked = true;
                            }
                            else
                            {
                                cbx_useWIFI.Checked = false;
                            }
                        
                            tbx_SSID.Text = stand_api.getWifiSetting.SSID;
                            tbx_Key.Text = stand_api.getWifiSetting.Key;

                            tbx_NetIP.Text = stand_api.getWifiSetting.IP;
                            tbx_NetSubnet.Text = stand_api.getWifiSetting.Subnet;
                            tbx_NetGateway.Text = stand_api.getWifiSetting.DefaultGateway;

                            if (stand_api.getWifiSetting.DHCP == "Yes")
                            {
                                cbx_DHCP.Checked= true;
                                tbx_DHCPIP.Text = stand_api.getWifiSetting.IP_from_dhcp;
                                tbx_DHCPSubnet.Text = stand_api.getWifiSetting.Subnet_from_dhcp;
                                tbx_DHCPGateway.Text = stand_api.getWifiSetting.DefaultGateway_from_dhcp;
                            }
                            else
                            {
                                tbx_DHCPIP.Enabled = false;
                                tbx_DHCPSubnet.Enabled = false;
                                tbx_DHCPGateway.Enabled = false;
                            }


                            lbl_msg.Text = "Result:" + stand_api.getWifiSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetWifiSetting"
                case "SetWifiSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setWifiSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setWifiSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setWifiSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setWifiSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setWifiSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setWifiSetting.Version;
                            tbx_Action_ext.Text = stand_api.setWifiSetting.Action_ext;
                            tbx_Response.Text = stand_api.setWifiSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setWifiSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetMobileNetSetting"
                case "GetMobileNetSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getMobileNetSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getMobileNetSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getMobileNetSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getMobileNetSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getMobileNetSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getMobileNetSetting.Version;
                            tbx_Action_ext.Text = stand_api.getMobileNetSetting.Action_ext;
                            tbx_Response.Text = stand_api.getMobileNetSetting.Response;
                            //--------->

                            if (stand_api.getMobileNetSetting.Use == "Yes")
                            {
                                cbx_useWIFI.Checked = true;
                            }
                            else
                            {
                                cbx_useWIFI.Checked = false;
                            }


                            lbl_MobileIP.Text = stand_api.getMobileNetSetting.IP;
                            lbl_Operator.Text = stand_api.getMobileNetSetting.Operator;

                            lbl_msg.Text = "Result:" + stand_api.getMobileNetSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetMobileNetSetting"
                case "SetMobileNetSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setMobileNetSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setMobileNetSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setMobileNetSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setMobileNetSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setMobileNetSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setMobileNetSetting.Version;
                            tbx_Action_ext.Text = stand_api.setMobileNetSetting.Action_ext;
                            tbx_Response.Text = stand_api.setMobileNetSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setMobileNetSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetVPNServer"
                case "GetVPNServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getVPNServer.Actid;
                            tbx_TerminalType.Text = stand_api.getVPNServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getVPNServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getVPNServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getVPNServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getVPNServer.Version;
                            tbx_Action_ext.Text = stand_api.getVPNServer.Action_ext;
                            tbx_Response.Text = stand_api.getVPNServer.Response;
                            //--------->



                            tbx_VPNAccount.Text = stand_api.getVPNServer.Account;
                            tbx_VPNAddress.Text = stand_api.getVPNServer.VPNAddress;
                            tbx_VPNPwd.Text = stand_api.getVPNServer.Password;

                            lbl_VPNIP.Text = stand_api.getVPNServer.IP;


                            lbl_msg.Text = "Result:" + stand_api.getVPNServer.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetVPNServer"
                case "SetVPNServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setVPNServer.Actid;
                            tbx_TerminalType.Text = stand_api.setVPNServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setVPNServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setVPNServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setVPNServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setVPNServer.Version;
                            tbx_Action_ext.Text = stand_api.setVPNServer.Action_ext;
                            tbx_Response.Text = stand_api.setVPNServer.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setVPNServer.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetGPS"
                case "GetGPS":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getGPS.Actid;
                            tbx_TerminalType.Text = stand_api.getGPS.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getGPS.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getGPS.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getGPS.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getGPS.Version;
                            tbx_Action_ext.Text = stand_api.getGPS.Action_ext;
                            tbx_Response.Text = stand_api.getGPS.Response;
                            //--------->


                            tbx_Longitude.Text = stand_api.getGPS.Longitude;
                            tbx_Latitude.Text = stand_api.getGPS.Latitude;
                            tbx_SatelliteCount.Text = stand_api.getGPS.SatelliteCount;

                            lbl_msg.Text = "Result:" + stand_api.getGPS.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetGPS"
                case "SetGPS":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setGPS.Actid;
                            tbx_TerminalType.Text = stand_api.setGPS.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setGPS.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setGPS.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setGPS.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setGPS.Version;
                            tbx_Action_ext.Text = stand_api.setGPS.Action_ext;
                            tbx_Response.Text = stand_api.setGPS.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setGPS.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetCloudServer"
                case "GetCloudServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getCloudServer.Actid;
                            tbx_TerminalType.Text = stand_api.getCloudServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getCloudServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getCloudServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getCloudServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getCloudServer.Version;
                            tbx_Action_ext.Text = stand_api.getCloudServer.Action_ext;
                            tbx_Response.Text = stand_api.getCloudServer.Response;
                            //--------->


                            tbx_CloudAddress.Text = stand_api.getCloudServer.WebsocketServer;

                            lbl_msg.Text = "Result:" + stand_api.getCloudServer.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetCloudServer"
                case "SetCloudServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setCloudServer.Actid;
                            tbx_TerminalType.Text = stand_api.setCloudServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setCloudServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setCloudServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setCloudServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setCloudServer.Version;
                            tbx_Action_ext.Text = stand_api.setCloudServer.Action_ext;
                            tbx_Response.Text = stand_api.setCloudServer.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setCloudServer.Result;
                            //<---
                            if (stand_api.setCloudServer.Result == "OK")
                            {
                                if (MessageBox.Show("设置成功后，需要重启才能启用", "提示！", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    try
                                    {
                                        Int32 ccid = ws_connect.AACCid;

                                        stand_api.restoreDevice.S_Ccid = Convert.ToString(ccid);
                                        stand_api.restoreDevice.S_Action_ext = action_ext;
                                        stand_api.restoreDevice.S_Action = "ReStart";

                                        ws_connect.ws_NewMessage_Send(_ws_session, stand_api.restoreDevice.F_Request());
                                        tbx_MessageFormServer.Text = stand_api.restoreDevice.RequestXMLmassage;
                                    }
                                    catch
                                    {
                                        lbl_msg.Text = "ooh...the command cannot send to devices!!";
                                    }
                                }
                            }
                            //--->
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetStreamingServer"
                case "GetStreamingServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getStreamingServer.Actid;
                            tbx_TerminalType.Text = stand_api.getStreamingServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getStreamingServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getStreamingServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getStreamingServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getStreamingServer.Version;
                            tbx_Action_ext.Text = stand_api.getStreamingServer.Action_ext;
                            tbx_Response.Text = stand_api.getStreamingServer.Response;
                            //--------->


                            tbx_StreamingAddress.Text = stand_api.getStreamingServer.StreamingServer;

                            lbl_msg.Text = "Result:" + stand_api.getStreamingServer.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetStreamingServer"
                case "SetStreamingServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setStreamingServer.Actid;
                            tbx_TerminalType.Text = stand_api.setStreamingServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setStreamingServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setStreamingServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setStreamingServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setStreamingServer.Version;
                            tbx_Action_ext.Text = stand_api.setStreamingServer.Action_ext;
                            tbx_Response.Text = stand_api.setStreamingServer.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setStreamingServer.Result;
                       }
                        catch { }
                         break;
                    }
                #endregion

                #region "GetLocalServer"
                case "GetLocalServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getLocalServer.Actid;
                            tbx_TerminalType.Text = stand_api.getLocalServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getLocalServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getLocalServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getLocalServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getLocalServer.Version;
                            tbx_Action_ext.Text = stand_api.getLocalServer.Action_ext;
                            tbx_Response.Text = stand_api.getLocalServer.Response;
                            //--------->

                            tbx_TerminalID_n.Text = stand_api.getLocalServer.TerminalID;
                            tbx_TerminalPassword.Text = stand_api.getLocalServer.TerminalPassword;
                            tbx_TerminalPort.Text = stand_api.getLocalServer.TerminalPort;

                            lbl_msg.Text = "Result:" + stand_api.getLocalServer.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetLocalServer"
                case "SetLocalServer":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setLocalServer.Actid;
                            tbx_TerminalType.Text = stand_api.setLocalServer.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setLocalServer.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setLocalServer.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setLocalServer.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setLocalServer.Version;
                            tbx_Action_ext.Text = stand_api.setLocalServer.Action_ext;
                            tbx_Response.Text = stand_api.setLocalServer.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setLocalServer.Result;
                       }
                        catch { }
                          break;
                    }
                #endregion
                #endregion

                #region DataPage[数据管理页面]

                #region "EmptyTimeLog"
                case "EmptyTimeLog":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.emptyTimeLog.Actid;
                            tbx_TerminalType.Text = stand_api.emptyTimeLog.TerminalType;
                            tbx_HardwareVer.Text = stand_api.emptyTimeLog.HardwareVer;
                            tbx_TerminalID.Text = stand_api.emptyTimeLog.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.emptyTimeLog.DeviceSerialNo;
                            tbx_Version.Text = stand_api.emptyTimeLog.Version;
                            tbx_Action_ext.Text = stand_api.emptyTimeLog.Action_ext;
                            tbx_Response.Text = stand_api.emptyTimeLog.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.emptyTimeLog.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "EmptyManageLog"
                case "EmptyManageLog":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.emptyManageLog.Actid;
                            tbx_TerminalType.Text = stand_api.emptyManageLog.TerminalType;
                            tbx_HardwareVer.Text = stand_api.emptyManageLog.HardwareVer;
                            tbx_TerminalID.Text = stand_api.emptyManageLog.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.emptyManageLog.DeviceSerialNo;
                            tbx_Version.Text = stand_api.emptyManageLog.Version;
                            tbx_Action_ext.Text = stand_api.emptyManageLog.Action_ext;
                            tbx_Response.Text = stand_api.emptyManageLog.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.emptyManageLog.Result;
                        }
                        catch { }
                          break;
                    }
                #endregion

                #region "EmptyUserEnrollmentData"
                case "EmptyUserEnrollmentData":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.emptyUserEnrollmentData.Actid;
                            tbx_TerminalType.Text = stand_api.emptyUserEnrollmentData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.emptyUserEnrollmentData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.emptyUserEnrollmentData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.emptyUserEnrollmentData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.emptyUserEnrollmentData.Version;
                            tbx_Action_ext.Text = stand_api.emptyUserEnrollmentData.Action_ext;
                            tbx_Response.Text = stand_api.emptyUserEnrollmentData.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.emptyUserEnrollmentData.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "EmptyAllData"
                case "EmptyAllData":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.emptyAllData.Actid;
                            tbx_TerminalType.Text = stand_api.emptyAllData.TerminalType;
                            tbx_HardwareVer.Text = stand_api.emptyAllData.HardwareVer;
                            tbx_TerminalID.Text = stand_api.emptyAllData.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.emptyAllData.DeviceSerialNo;
                            tbx_Version.Text = stand_api.emptyAllData.Version;
                            tbx_Action_ext.Text = stand_api.emptyAllData.Action_ext;
                            tbx_Response.Text = stand_api.emptyAllData.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.emptyAllData.Result;
                        }
                        catch { }
                          break;
                    }
                #endregion

                #region "GetLogSetting"
                case "GetLogSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getLogSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getLogSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getLogSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getLogSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getLogSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getLogSetting.Version;
                            tbx_Action_ext.Text = stand_api.getLogSetting.Action_ext;
                            tbx_Response.Text = stand_api.getLogSetting.Response;
                            //--------->
                            tbx_AttLogWarning.Text = stand_api.getLogSetting.AttLogWarning;
                            tbx_ManagerLogWarning.Text = stand_api.getLogSetting.ManagerLogWarning;
                            tbx_ReVerifyTime.Text = stand_api.getLogSetting.ReVerifyTime;

                            lbl_msg.Text = "Result:" + stand_api.getLogSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetLogSetting"
                case "SetLogSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setLogSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setLogSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setLogSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setLogSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setLogSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setLogSetting.Version;
                            tbx_Action_ext.Text = stand_api.setLogSetting.Action_ext;
                            tbx_Response.Text = stand_api.setLogSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setLogSetting.Result;
                        }
                        catch { }
                         break;
                    }
                #endregion

                #region "GetFirstGlog"
                case "GetFirstGlog":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getFirstGlog.Actid;
                            tbx_TerminalType.Text = stand_api.getFirstGlog.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getFirstGlog.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getFirstGlog.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getFirstGlog.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getFirstGlog.Version;
                            tbx_Action_ext.Text = stand_api.getFirstGlog.Action_ext;
                            tbx_Response.Text = stand_api.getFirstGlog.Response;
                            //--------->
                            if (stand_api.getFirstGlog.Result == "OK")
                            {
                                //tbx_BeginLogPos.Text = Convert.ToString(Convert.ToInt32(tbx_BeginLogPos.Text) + 1);
                                tbx_BeginLogPos.Text = "1";
                                try
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                    id.Value = stand_api.getFirstGlog.LogID;
                                    row.Cells.Add(id);

                                    string T = stand_api.getFirstGlog.Time;
                                    string[] temp = T.Split('T');
                                    string d = temp[0].Substring(0, temp[0].Length - 1);
                                    string t = temp[1].Substring(0, temp[1].Length - 1);
                                    DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                                    time.Value = d + " " + t;
                                    row.Cells.Add(time);

                                    DataGridViewTextBoxCell userID = new DataGridViewTextBoxCell();
                                    userID.Value = stand_api.getFirstGlog.UserID;
                                    row.Cells.Add(userID);

                                    DataGridViewTextBoxCell action = new DataGridViewTextBoxCell();
                                    action.Value = stand_api.getFirstGlog.Action;
                                    row.Cells.Add(action);

                                    DataGridViewTextBoxCell attendStat = new DataGridViewTextBoxCell();
                                    attendStat.Value = stand_api.getFirstGlog.AttendStat;
                                    row.Cells.Add(attendStat);

                                    DataGridViewTextBoxCell apStat = new DataGridViewTextBoxCell();
                                    apStat.Value = stand_api.getFirstGlog.APStat;
                                    row.Cells.Add(apStat);

                                    DataGridViewTextBoxCell jobCode = new DataGridViewTextBoxCell();
                                    jobCode.Value = stand_api.getFirstGlog.JobCode;
                                    row.Cells.Add(jobCode);

                                    if (stand_api.getFirstGlog.Photo == "Yes" && stand_api.getFirstGlog.LogImage != null && stand_api.getFirstGlog.LogImage != "")
                                    {
                                        try
                                        {
                                            Byte[] photoByte = null;
                                            Image realtimeimg = null;
                                            photoByte = Convert.FromBase64String(stand_api.getFirstGlog.LogImage);
                                            realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));

                                            DataGridViewImageCell logImage = new DataGridViewImageCell();
                                            logImage.Value = realtimeimg;
                                            row.Cells.Add(logImage);
                                        }
                                        catch { }
                                    }
                                    dgv_AttandanceLog.Rows.Add(row);
                                }

                                catch { }
                            }

                            lbl_msg.Text = "Result:" + stand_api.getFirstGlog.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetNextGlog"
                case "GetNextGlog":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getNextGlog.Actid;
                            tbx_TerminalType.Text = stand_api.getNextGlog.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getNextGlog.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getNextGlog.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getNextGlog.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getNextGlog.Version;
                            tbx_Action_ext.Text = stand_api.getNextGlog.Action_ext;
                            tbx_Response.Text = stand_api.getNextGlog.Response;
                            //--------->
                            if (stand_api.getNextGlog.Result == "OK")
                            {
                                tbx_BeginLogPos.Text = Convert.ToString(Convert.ToInt32(tbx_BeginLogPos.Text) + 1);
                                try
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                    id.Value = stand_api.getNextGlog.LogID;
                                    row.Cells.Add(id);

                                    string T = stand_api.getNextGlog.Time;
                                    string[] temp = T.Split('T');
                                    string d = temp[0].Substring(0, temp[0].Length - 1);
                                    string t = temp[1].Substring(0, temp[1].Length - 1);
                                    DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                                    time.Value = d + " " + t;
                                    row.Cells.Add(time);

                                    DataGridViewTextBoxCell userID = new DataGridViewTextBoxCell();
                                    userID.Value = stand_api.getNextGlog.UserID;
                                    row.Cells.Add(userID);

                                    DataGridViewTextBoxCell action = new DataGridViewTextBoxCell();
                                    action.Value = stand_api.getNextGlog.Action;
                                    row.Cells.Add(action);

                                    DataGridViewTextBoxCell attendStat = new DataGridViewTextBoxCell();
                                    attendStat.Value = stand_api.getNextGlog.AttendStat;
                                    row.Cells.Add(attendStat);

                                    DataGridViewTextBoxCell apStat = new DataGridViewTextBoxCell();
                                    apStat.Value = stand_api.getNextGlog.APStat;
                                    row.Cells.Add(apStat);

                                    DataGridViewTextBoxCell jobCode = new DataGridViewTextBoxCell();
                                    jobCode.Value = stand_api.getNextGlog.JobCode;
                                    row.Cells.Add(jobCode);

                                    if (stand_api.getNextGlog.Photo == "Yes" && stand_api.getNextGlog.LogImage != null && stand_api.getNextGlog.LogImage != "")
                                    {
                                        try
                                        {
                                            Byte[] photoByte = null;
                                            Image realtimeimg = null;
                                            photoByte = Convert.FromBase64String(stand_api.getNextGlog.LogImage);
                                            realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));

                                            DataGridViewImageCell logImage = new DataGridViewImageCell();
                                            logImage.Value = realtimeimg;
                                            row.Cells.Add(logImage);
                                        }
                                        catch { }
                                    }
                                    dgv_AttandanceLog.Rows.Add(row);
                                }

                                catch { }
                            }

                            lbl_msg.Text = "Result:" + stand_api.getNextGlog.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetAttendanceLog"
                case "GetAttendanceLog":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getAttendanceLog.Actid;
                            tbx_TerminalType.Text = stand_api.getAttendanceLog.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getAttendanceLog.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getAttendanceLog.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getAttendanceLog.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getAttendanceLog.Version;
                            tbx_Action_ext.Text = stand_api.getAttendanceLog.Action_ext;
                            tbx_Response.Text = stand_api.getAttendanceLog.Response;
                            //--------->
                            if (stand_api.getAttendanceLog.Result == "OK" && rbtn_CustomLog.Checked == true)
                            {
                                tbx_BeginLogPos.Text = stand_api.getAttendanceLog.Count;
                            
                                Int32 countInt = Convert.ToInt32(stand_api.getAttendanceLog.Count);
                                for (int i = 0; i < countInt; i++)
                                {
                                    //string[,] log  = new string[countInt,8];
                                    //log = stand_api.getAttendanceLog.Log;
                                    try
                                    {
                                        DataGridViewRow row = new DataGridViewRow();
                                        DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                        id.Value = stand_api.getAttendanceLog.Log[i, 0];
                                        row.Cells.Add(id);

                                        string T = stand_api.getAttendanceLog.Log[i, 1];
                                        string[] temp = T.Split('T');
                                        string d = temp[0].Substring(0, temp[0].Length - 1);
                                        string t = temp[1].Substring(0, temp[1].Length - 1);
                                        DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                                        time.Value = d + " " + t;
                                        row.Cells.Add(time);

                                        DataGridViewTextBoxCell userID = new DataGridViewTextBoxCell();
                                        userID.Value = stand_api.getAttendanceLog.Log[i, 2];
                                        row.Cells.Add(userID);

                                        DataGridViewTextBoxCell action = new DataGridViewTextBoxCell();
                                        action.Value = stand_api.getAttendanceLog.Log[i, 3];
                                        row.Cells.Add(action);

                                        DataGridViewTextBoxCell attendStat = new DataGridViewTextBoxCell();
                                        attendStat.Value = stand_api.getAttendanceLog.Log[i, 4];
                                        row.Cells.Add(attendStat);

                                        DataGridViewTextBoxCell apStat = new DataGridViewTextBoxCell();
                                        apStat.Value = stand_api.getAttendanceLog.Log[i, 5];
                                        row.Cells.Add(apStat);

                                        DataGridViewTextBoxCell jobCode = new DataGridViewTextBoxCell();
                                        jobCode.Value = stand_api.getAttendanceLog.Log[i, 6];
                                        row.Cells.Add(jobCode);

                                        Image m = null;
                                        if (stand_api.getAttendanceLog.Log[i, 7] == "Yes")
                                        {
                                            m = Image.FromFile(Application.StartupPath + @"\image\V.png");

                                        }
                                        else
                                        {
                                            m = Image.FromFile(Application.StartupPath + @"\image\X.png");
                                        }

                                        DataGridViewImageCell logImage = new DataGridViewImageCell();
                                        logImage.Value = m;
                                        row.Cells.Add(logImage);

                                        dgv_AttandanceLog.Rows.Add(row);
                                    }
                                    catch { }
                                }
                            
                            }

                            lbl_msg.Text = "Result:" + stand_api.getAttendanceLog.Result;
                    }
                    catch { }
                    break;
                    }
                #endregion

                #endregion

                #region AttandancePage[考勤管理页面]
                #region "GetAttendanceRule"
                case "GetAttendanceRule":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getAttendanceRule.Actid;
                            tbx_TerminalType.Text = stand_api.getAttendanceRule.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getAttendanceRule.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getAttendanceRule.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getAttendanceRule.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getAttendanceRule.Version;
                            tbx_Action_ext.Text = stand_api.getAttendanceRule.Action_ext;
                            tbx_Response.Text = stand_api.getAttendanceRule.Response;
                            //--------->

                            dgv_AttendanceRule.Rows.Clear();
                            string[] ATT;

                            for (int i = 0; i < 24; i++)
                            {
                                try
                                {
                                    ATT = new string[3];
                                    ATT = stand_api.getAttendanceRule.TimeSection[i].Split(',');

                                    DataGridViewRow row = new DataGridViewRow();
                                    //第一列，编号
                                    DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                    id.Value = Convert.ToString(i);
                                    row.Cells.Add(id);

                                    //第二列，开始时间
                                    DataGridViewTextBoxCell startTime = new DataGridViewTextBoxCell();
                                    startTime.Value = ATT[0];
                                    row.Cells.Add(startTime);

                                    //第三列，结束时间
                                    DataGridViewTextBoxCell endTime = new DataGridViewTextBoxCell();
                                    endTime.Value = ATT[1];
                                    row.Cells.Add(endTime);

                                    //第四列，状态
                                    DataGridViewComboBoxCell status = new DataGridViewComboBoxCell();
                                    for (int n = 0; n < DB_def.AttendanceRuleStatus.Length; n++)
                                    {
                                        status.Items.Add(DB_def.AttendanceRuleStatus[n]);
                                    }
                                    status.Value = ATT[2];
                                    row.Cells.Add(status);

                                    dgv_AttendanceRule.Rows.Add(row);
                                }
                                catch (System.Exception) { }
                            
                            }

                        }
                    catch { }
                    break;
                    }
                #endregion

                #region "SetAttendanceRule"
                case "SetAttendanceRule":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setAttendanceRule.Actid;
                            tbx_TerminalType.Text = stand_api.setAttendanceRule.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setAttendanceRule.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setAttendanceRule.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setAttendanceRule.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setAttendanceRule.Version;
                            tbx_Action_ext.Text = stand_api.setAttendanceRule.Action_ext;
                            tbx_Response.Text = stand_api.setAttendanceRule.Response;
                            //--------->

                            lbl_msg.Text = "Result:" + stand_api.setAttendanceRule.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion
                #endregion

                #region AccessPage[门禁管理页面]
                #region "AccessStatus"
                case "AccessStatus":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.accessStatus.Actid;
                            tbx_TerminalType.Text = stand_api.accessStatus.TerminalType;
                            tbx_HardwareVer.Text = stand_api.accessStatus.HardwareVer;
                            tbx_TerminalID.Text = stand_api.accessStatus.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.accessStatus.DeviceSerialNo;
                            tbx_Version.Text = stand_api.accessStatus.Version;
                            tbx_Action_ext.Text = stand_api.accessStatus.Action_ext;
                            tbx_Response.Text = stand_api.accessStatus.Response;
                            //--------->

                            cobx_LockReleaseStatus.SelectedItem = stand_api.accessStatus.LockReleaseStatus;
                            cobx_DoorSensoStatus.SelectedItem = stand_api.accessStatus.DoorSensoStatus;
                            cobx_AlarmStatus.SelectedItem = stand_api.accessStatus.AlarmStatus;

                            lbl_msg.Text = "Result:" + stand_api.accessStatus.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion

                #region "GetAccessSetting"
                case "GetAccessSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getAccessSetting.Actid;
                            tbx_TerminalType.Text = stand_api.getAccessSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getAccessSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getAccessSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getAccessSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getAccessSetting.Version;
                            tbx_Action_ext.Text = stand_api.getAccessSetting.Action_ext;
                            tbx_Response.Text = stand_api.getAccessSetting.Response;
                            //--------->
                            try
                            {
                                if (stand_api.getAccessSetting.TamperAlarm == "Yes")
                                {
                                    cbx_TamperAlarm.Checked = true;
                                }
                                else
                                {
                                    cbx_TamperAlarm.Checked = false;
                                }

                                cobx_WGOutputFormat.SelectedItem = stand_api.getAccessSetting.WGOutputFormat;
                                cobx_WGOutputContent.SelectedItem = stand_api.getAccessSetting.WGOutputContent;
                                cobx_LockReleaseTime.SelectedItem = stand_api.getAccessSetting.LockReleaseTime;
                                tbx_VerifyPassLockReleaseTime.Text = stand_api.getAccessSetting.VerifyPassLockReleaseTime;
                                tbx_DoorOpenTimeout.Text = stand_api.getAccessSetting.DoorOpenTimeout;
                                cobx_DoorSensorType.SelectedItem = stand_api.getAccessSetting.DoorSensorType;
                            
                                try
                                {
                                    string[] P = new string[2];
                                    P = stand_api.getAccessSetting.PassTime.Split('-');
                                    dtp_startPassTime.Value = Convert.ToDateTime(P[0]);
                                    dtp_endPassTime.Value = Convert.ToDateTime(P[1]);
                                }
                                catch { }
                            

                                if (stand_api.getAccessSetting.AllWeek == "Yes")
                                {
                                    cbx_AllWeek.Checked = true;
                                }
                                else
                                {
                                    cbx_AllWeek.Checked = false;
                                }

                                cobx_startWeek.SelectedItem = stand_api.getAccessSetting.StartWeek;
                                cobx_endWeek.SelectedItem = stand_api.getAccessSetting.EndWeek;

                                if (stand_api.getAccessSetting.DuressAlarm == "Yes")
                                {
                                    cbx_DuressAlarm.Checked = true;
                                }
                                else
                                {
                                    cbx_DuressAlarm.Checked = false;
                                }

                                if (stand_api.getAccessSetting.LinkageAlarm == "Yes")
                                {
                                    cbx_LinkageAlarm.Checked = true;
                                }
                                else
                                {
                                    cbx_LinkageAlarm.Checked = false;
                                }

                                if (stand_api.getAccessSetting.BlackListAlarm == "Yes")
                                {
                                    cbx_BlackListAlarm.Checked = true;
                                }
                                else
                                {
                                    cbx_BlackListAlarm.Checked = false;
                                }
                            }
                            catch { }
                        

                            lbl_msg.Text = "Result:" + stand_api.getAccessSetting.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "SetAccessSetting"
                case "SetAccessSetting":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setAccessSetting.Actid;
                            tbx_TerminalType.Text = stand_api.setAccessSetting.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setAccessSetting.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setAccessSetting.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setAccessSetting.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setAccessSetting.Version;
                            tbx_Action_ext.Text = stand_api.setAccessSetting.Action_ext;
                            tbx_Response.Text = stand_api.setAccessSetting.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setAccessSetting.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion 

                #region "GetAccessList"
                case "GetAccessList":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getAccessList.Actid;
                            tbx_TerminalType.Text = stand_api.getAccessList.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getAccessList.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getAccessList.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getAccessList.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getAccessList.Version;
                            tbx_Action_ext.Text = stand_api.getAccessList.Action_ext;
                            tbx_Response.Text = stand_api.getAccessList.Response;
                            //--------->

                            if (stand_api.getAccessList.Result == "OK")
                            {
                                Int32 countInt = Convert.ToInt32(stand_api.getAccessList.Count);
                                for (int i = 0; i < countInt; i++)
                                {
                                    try
                                    {
                                        DataGridViewRow row = new DataGridViewRow();
                                        //第一列，ID
                                        DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                                        id.Value = stand_api.getAccessList.List_id[i];
                                        row.Cells.Add(id);

                                        //第二列，使用
                                        DataGridViewCheckBoxCell use = new DataGridViewCheckBoxCell();
                                        if (stand_api.getAccessList.List[i, 0] == "Yse")
                                        {
                                            use.Value = "true";
                                        }
                                        else
                                        {
                                            use.Value = "false";
                                        }
                                        row.Cells.Add(use);

                                        //第三列，部门或者名单
                                        DataGridViewComboBoxCell depart = new DataGridViewComboBoxCell();
                                        for (int n = 0; n < DB_def.Depart.Length; n++)
                                        {
                                            depart.Items.Add(DB_def.Depart[n]);
                                        }
                                        depart.Value = Convert.ToInt32(stand_api.getAccessList.List[i, 1]);
                                        row.Cells.Add(depart);

                                        //第四列，通过权限
                                        DataGridViewComboBoxCell access = new DataGridViewComboBoxCell();
                                        for (int n = 0; n < DB_def.YesNo.Length; n++)
                                        {
                                            access.Items.Add(DB_def.YesNo[n]);
                                        }
                                        access.Value = stand_api.getAccessList.List[i, 2];
                                        row.Cells.Add(access);

                                        //第五列，星期永久
                                        DataGridViewCheckBoxCell allWeek = new DataGridViewCheckBoxCell();
                                        if (stand_api.getAccessList.List[i, 3] == "Yse")
                                        {
                                            allWeek.Value = "true";
                                        }
                                        else
                                        {
                                            allWeek.Value = "false";
                                        }
                                        row.Cells.Add(allWeek);

                                        //第五列，开始星期
                                        DataGridViewComboBoxCell startWeek = new DataGridViewComboBoxCell();
                                        for (int n = 0; n < DB_def.Week.Length; n++)
                                        {
                                            startWeek.Items.Add(DB_def.Week[n]);
                                        }
                                        startWeek.Value = stand_api.getAccessList.List[i, 4];
                                        row.Cells.Add(startWeek);

                                        //第六列，结束星期
                                        DataGridViewComboBoxCell endWeek = new DataGridViewComboBoxCell();
                                        for (int n = 0; n < DB_def.Week.Length; n++)
                                        {
                                            endWeek.Items.Add(DB_def.Week[n]);
                                        }
                                        endWeek.Value = stand_api.getAccessList.List[i, 5];
                                        row.Cells.Add(endWeek);

                                        //第七列，时段永久
                                        DataGridViewCheckBoxCell allTime = new DataGridViewCheckBoxCell();
                                        if (stand_api.getAccessList.List[i, 6] == "Yse")
                                        {
                                            allTime.Value = "true";
                                        }
                                        else
                                        {
                                            allTime.Value = "false";
                                        }
                                        row.Cells.Add(allTime);

                                        //第八列，开始时段
                                        string sT = stand_api.getAccessList.List[i, 7];
                                        string[] stemp = sT.Split('T');
                                        string sd = stemp[0].Substring(0, stemp[0].Length - 1);
                                        string st = stemp[1].Substring(0, stemp[1].Length - 1);
                                        DataGridViewTextBoxCell startTime = new DataGridViewTextBoxCell();
                                        startTime.Value = sd + " " + st;
                                        row.Cells.Add(startTime);

                                        //第九列，结束时段
                                        string eT = stand_api.getAccessList.List[i, 8];
                                        string[] etemp = eT.Split('T');
                                        string ed = etemp[0].Substring(0, etemp[0].Length - 1);
                                        string et = etemp[1].Substring(0, etemp[1].Length - 1);
                                        DataGridViewTextBoxCell endTime = new DataGridViewTextBoxCell();
                                        endTime.Value = ed + " " + et;
                                        row.Cells.Add(endTime);

                                        dgv_AccessList.Rows.Add(row);
                                    }
                                    catch { }
                                }

                            }


                            lbl_msg.Text = "Result:" + stand_api.getAccessList.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion 

                #region "SetAccessList"
                case "SetAccessList":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.setAccessList.Actid;
                            tbx_TerminalType.Text = stand_api.setAccessList.TerminalType;
                            tbx_HardwareVer.Text = stand_api.setAccessList.HardwareVer;
                            tbx_TerminalID.Text = stand_api.setAccessList.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.setAccessList.DeviceSerialNo;
                            tbx_Version.Text = stand_api.setAccessList.Version;
                            tbx_Action_ext.Text = stand_api.setAccessList.Action_ext;
                            tbx_Response.Text = stand_api.setAccessList.Response;
                            //--------->


                            lbl_msg.Text = "Result:" + stand_api.setAccessList.Result;
                        }
                        catch { } 
                        break;
                    }
                #endregion 
                #endregion

                #region InfoPage[本机信息页面]
                #region "GetStoreStatus"
                case "GetStoreStatus":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getStoreStatus.Actid;
                            tbx_TerminalType.Text = stand_api.getStoreStatus.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getStoreStatus.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getStoreStatus.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getStoreStatus.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getStoreStatus.Version;
                            tbx_Action_ext.Text = stand_api.getStoreStatus.Action_ext;
                            tbx_Response.Text = stand_api.getStoreStatus.Response;
                            //--------->
                        
                            try
                            {
                                string[] _ManagerCount = new string[2];
                                _ManagerCount = stand_api.getStoreStatus.ManagerCount.Split('-');
                                tbx_ManagerCount_u.Text = _ManagerCount[0]; 
                                tbx_ManagerCount_t.Text = _ManagerCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _UserCount = new string[2];
                                _UserCount = stand_api.getStoreStatus.UserCount.Split('-');
                                tbx_UserCount_u.Text = _UserCount[0]; 
                                tbx_UserCount_t.Text = _UserCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _FaceCount = new string[2];
                                _FaceCount = stand_api.getStoreStatus.FaceCount.Split('-');
                                tbx_FaceCount_u.Text = _FaceCount[0]; 
                                tbx_FaceCount_t.Text = _FaceCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _FpCount = new string[2];
                                _FpCount = stand_api.getStoreStatus.FpCount.Split('-');
                                tbx_FpCount_u.Text = _FpCount[0]; 
                                tbx_FpCount_t.Text = _FpCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _CardCount = new string[2];
                                _CardCount = stand_api.getStoreStatus.CardCount.Split('-');
                                tbx_CardCount_u.Text = _CardCount[0]; 
                                tbx_CardCount_t.Text = _CardCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _PwdCount = new string[2];
                                _PwdCount = stand_api.getStoreStatus.PwdCount.Split('-');
                                tbx_PwdCount_u.Text = _PwdCount[0]; 
                                tbx_PwdCount_t.Text = _PwdCount[1];
                            
                            }
                            catch { }

                            try
                            {
                                string[] _TimeLogCount = new string[3];
                                _TimeLogCount = stand_api.getStoreStatus.TimeLogCount.Split('-');
                                tbx_TimeLogCount_u.Text = _TimeLogCount[1];
                                tbx_TimeLogCount_t.Text = _TimeLogCount[2]; 
                                tbx_TimeLogCount_s.Text = _TimeLogCount[0]; 
                            
                            }
                            catch { }

                            try
                            {
                                string[] _ManageLogCount = new string[3];
                                _ManageLogCount = stand_api.getStoreStatus.ManageLogCount.Split('-');
                                tbx_ManageLogCount_u.Text = _ManageLogCount[1];
                                tbx_ManageLogCount_t.Text = _ManageLogCount[2];
                                tbx_ManageLogCount_s.Text = _ManageLogCount[0]; 
                            
                            }
                            catch { }

                            try
                            {
                                string[] _PhotoLogCount = new string[3];
                                _PhotoLogCount = stand_api.getStoreStatus.PhotoLogCount.Split('-');
                                tbx_PhotoLogCount_u.Text = _PhotoLogCount[1];
                                tbx_PhotoLogCount_t.Text = _PhotoLogCount[2];
                                tbx_PhotoLogCount_s.Text = _PhotoLogCount[0]; 
                            
                            }
                            catch { }

                            lbl_msg.Text = "Result:" + stand_api.getStoreStatus.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion

                #region "GetDeviceInfo"
                case "GetDeviceInfo":
                    {
                        try
                        {
                            //<-------
                            tbx_Actid.Text = stand_api.getDeviceInfo.Actid;
                            tbx_TerminalType.Text = stand_api.getDeviceInfo.TerminalType;
                            tbx_HardwareVer.Text = stand_api.getDeviceInfo.HardwareVer;
                            tbx_TerminalID.Text = stand_api.getDeviceInfo.TerminalID;
                            tbx_DeviceSerialNo.Text = stand_api.getDeviceInfo.DeviceSerialNo;
                            tbx_Version.Text = stand_api.getDeviceInfo.Version;
                            tbx_Action_ext.Text = stand_api.getDeviceInfo.Action_ext;
                            tbx_Response.Text = stand_api.getDeviceInfo.Response;
                            //--------->
                            tbx_ReleasedTime.Text = stand_api.getDeviceInfo.ReleasedTime;
                            tbx_ProductName.Text = stand_api.getDeviceInfo.ProductName;
                            tbx_Manufacturer.Text = stand_api.getDeviceInfo.Manufacturer;
                            tbx_DeviceSerialNo_info.Text = stand_api.getDeviceInfo.DeviceSerialNo;
                            tbx_FirmwareVersion_info.Text = stand_api.getDeviceInfo.Version;
                            tbx_HardwareVer_info.Text = stand_api.getDeviceInfo.HardwareVer;

                            lbl_msg.Text = "Result:" + stand_api.getDeviceInfo.Result;
                        }
                        catch { }
                        break;
                    }
                #endregion
                #endregion
                
            }
            stringXML_ResponseNode = "";
            
            #endregion

            #region RealTimeLog["TimeLog"考勤记录响应]
            if (rbtn_RealTimeLog.Checked)
            {
                try
                {
                    if (push_event0 == "TimeLog" || push_event0 == "TimeLog_v2" && rbtn_RealTimeLog.Checked == true)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                        id.Value = stand_api.timelog.LogID;
                        row.Cells.Add(id);

                        string T = stand_api.timelog.Time;
                        string[] temp = T.Split('T');
                        string d = temp[0].Substring(0, temp[0].Length-1);
                        string t = temp[1].Substring(0, temp[1].Length-1);
                        DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                        time.Value = d + " " + t;
                        row.Cells.Add(time);

                        DataGridViewTextBoxCell userID = new DataGridViewTextBoxCell();
                        userID.Value = stand_api.timelog.UserID;
                        row.Cells.Add(userID);

                        DataGridViewTextBoxCell action = new DataGridViewTextBoxCell();
                        action.Value = stand_api.timelog.Action;
                        row.Cells.Add(action);

                        DataGridViewTextBoxCell attendStat = new DataGridViewTextBoxCell();
                        attendStat.Value = stand_api.timelog.AttendStat;
                        row.Cells.Add(attendStat);

                        DataGridViewTextBoxCell apStat = new DataGridViewTextBoxCell();
                        apStat.Value = stand_api.timelog.APStat;
                        row.Cells.Add(apStat);

                        DataGridViewTextBoxCell jobCode = new DataGridViewTextBoxCell();
                        jobCode.Value = stand_api.timelog.JobCode;
                        row.Cells.Add(jobCode);

                        if (stand_api.timelog.Photo == "Yes" && stand_api.timelog.LogImage != null && stand_api.timelog.LogImage !="")
                        {
                            try
                            {
                                Byte[] photoByte = null;
                                Image realtimeimg = null;
                                photoByte = Convert.FromBase64String(stand_api.timelog.LogImage);
                                realtimeimg = Image.FromStream(new System.IO.MemoryStream(photoByte));

                                DataGridViewImageCell logImage = new DataGridViewImageCell();
                                logImage.Value = realtimeimg;
                                row.Cells.Add(logImage);

                                pbx_realtimePhoto_Data.Image = realtimeimg;
                            }
                            catch { }
                        }
                        else
                        {
                            Image m = Image.FromFile(Application.StartupPath + @"\image\X.png");

                            DataGridViewImageCell logImage = new DataGridViewImageCell();
                            logImage.Value = m;
                            row.Cells.Add(logImage);

                            pbx_realtimePhoto_Data.Image = m;
                        }

                        dgv_AttandanceLog.Rows.Add(row);
                    }
                }
                catch { }
            }
            #endregion
        }
        #endregion

        #region Initialize Form[清除初始化]

        #region 用户管理，清除初始化
        private void InitializeUserForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

            dgv_FingerData.Rows.Clear();

            btn_GetNextSampleInfo.Visible = false;
        }

        #endregion

        #region 基本设置，清除初始化
        private void InitializeBasicForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }
        #endregion

        #region 高级设置，清除初始化
        private void InitializeAdvancedForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }

        #endregion
        
        #region 网络管理，清除初始化
        private void InitializeNetForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }

        #endregion

        #region 数据管理，清除初始化
        private void InitializeDataForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }
        #endregion

        #region 考勤管理，清除初始化
        private void InitializeAttForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }
        #endregion

        #region 门禁管理，清除初始化
        private void InitializeAccessForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }
        #endregion

        #region 本机信息，清除初始化
        private void InitializeInfoForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";

        }
        #endregion

        #region 身份证，清除初始化
        private void InitializeIDCardForm()
        {
            lbl_msg.Text = "";
            tbx_MessageFormServer.Text = "";
            tbx_MessageFormDevice.Text = "";


        }

        #endregion

        #endregion

        #endregion

    }
}
