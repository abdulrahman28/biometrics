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

using System.Net;

using System.Threading;
using System.Threading.Tasks;


             /*********************************************************************/
             /* F500      :F500协议，TimeLog协议是通用M50/M60/M70平台                          */
             /* Standard  :标准协议，通用4900/4960/2960/5900/5928等新平台。       */
             /* MK3300    :MK3300,定义不支持的按键不显示                          */
             /*********************************************************************/

namespace WebsocketWinformDemo_Standard
{
    public partial class mainForm : Form
    {
        API_Standard stand_api =new API_Standard();
        websocketServerConnect ws_connect = new websocketServerConnect();
        WebSocketServer ws_server = new WebSocketServer();

        string _string_wsHead = null;
        string _string_wsIP = null;

        #region FormLoad
        public mainForm()
        {
            InitializeComponent();
            serverStatusImage_pbx.Visible = false;

            if (ws_connect.Bool_SSL)
            {
                _string_wsHead = "wss://";
                cbx_useSSL.Checked = true;
            }
            else
            {
                _string_wsHead = "ws://";
                cbx_useSSL.Checked = false;
            }

            //<----获取本机IP地址,设备云服务器地址填写此地址,ws://IP:port或者wss://IP:port
            string _string_hostname = Dns.GetHostName();
            IPAddress[] _ipAdd_list = Dns.GetHostEntry(_string_hostname).AddressList;
            foreach (IPAddress _ipAdd_Item in _ipAdd_list)
            {
                if (!_ipAdd_Item.IsIPv6LinkLocal && !_ipAdd_Item.IsIPv6Multicast && !_ipAdd_Item.IsIPv6SiteLocal)
                {
                    _string_wsIP = Convert.ToString(_ipAdd_Item);
                    IpAddress_lbl.Text = _string_wsHead + _string_wsIP + ":";
                    break;
                }
            }
            //----->

            //<---debug
            //deviceAPIOperationForm debugFrm = new deviceAPIOperationForm();
            //debugFrm.Show();
            //---->
        }
        private void deviceAPIOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ws_server.NewMessageReceived -= new SessionHandler<WebSocketSession, string>(Thread_NewMessage);

        }
        #endregion

        #region use SSL.按键事件，是否SSL加密。
        private void cbx_useSSL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_useSSL.Checked)
            {
                ws_connect.Bool_SSL = true;
                _string_wsHead = "wss://";
                IpAddress_lbl.Text = _string_wsHead + _string_wsIP + ":";
            }
            else
            {
                ws_connect.Bool_SSL = false;
                _string_wsHead = "ws://";
                IpAddress_lbl.Text = _string_wsHead + _string_wsIP + ":";
            }

        }
        #endregion

        #region start Server 按键事件，开始websocket服务器
        /// <summary>
        /// 启动服务器按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startServer_btn_Click(object sender, EventArgs e)
        {
            cbx_useSSL.Enabled = false;
            //operationMsg_lbl.Text = Step1.WebSocketServer_Start(ws_Server, serverPort_tbx.Text);
            operationMsg_lbl.Text = ws_connect. WebSocketServer_Start(ws_server, serverPort_tbx.Text);
            if (ws_connect.Bool_Status == true)
            {
                startServer_btn.Enabled = false;
                serverStatusImage_pbx.Visible = true;
            }
            //检测到新连接
            ws_server.NewSessionConnected += new SessionHandler<WebSocketSession>(Thread_NewSessionConnected);

            //监测到新数据
            ws_server.NewMessageReceived += new SessionHandler<WebSocketSession, string>(Thread_NewMessage);

            //监测到断开
            ws_server.SessionClosed += new SessionHandler<WebSocketSession, SuperSocket.SocketBase.CloseReason>(Thread_SessionClosed);
            
        }
        #endregion


        //<---------new devices connect.新设备连接，实时显示在线设备数量
        #region NewSessionConnected_Thread，新设备连接线程入口
        /// <summary>
        /// 新设备线程入口，线程设置并启动
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="message"></param>
        private void Thread_NewSessionConnected(WebSocketSession _ws_session)
        {
            Thread threadConsole = new Thread(new ThreadStart(Invoke_NewSessionConnected));
            threadConsole.IsBackground = true;
            threadConsole.Start();
        }
        #endregion

        #region 线程Function[方法]，有新的设备连接时，计数在线设备
        public delegate void delegate_NewSessionConnected();
        /// <summary>
        /// 新设备线程委托
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        private void Invoke_NewSessionConnected()//thread 
        {
            Invoke(new delegate_NewSessionConnected(Function_NewSessionConnected), null);
        }

        /// <summary>
        /// 新设备线程，线程内容操作，
        /// </summary>
        private void Function_NewSessionConnected()
        {
            onlineCount_lbl.Text = Convert.ToString(ws_server.SessionCount);
        }
        #endregion
        //----------->

        //<---------new massage.新数据接收和相应
        #region NewMessage_Thread，新数据线程入口
        private delegate void delegate_console();
        private delegate void delegate_registerDGV();
        private delegate void delegate_loginDGV();

        /// <summary>
        /// 新数据线程入口，线程设置并启动
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="_stringXML_receiveMessage"></param>
        private void Thread_NewMessage(WebSocketSession _ws_session, string _stringXML_receiveMessage)
        {
            ws_connect.ws_NewMessage_Receive(_ws_session, _stringXML_receiveMessage);//将接收到的数据拼接出来，用于3 func中显示。

            if (_stringXML_receiveMessage != null && _stringXML_receiveMessage != "")
            {
                #region 尝试解析接收的字符
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(_stringXML_receiveMessage);

                    #region register/login/CheckUserByDevice请求
                    try
                    {
                        string node_request = null;
                        node_request = doc.SelectSingleNode("/Message/Request").InnerText;
                        try
                        {
                            #region "Register"注册请求响应
                            if (node_request == "Register")//判断接收到的是注册请求
                            {
                                string registerSendMessage = null;
                                //demo只考虑result返回OK的情况。如果需要返回fail的，请调整函数bool参数.
                                registerSendMessage = stand_api.register.API_register(_ws_session, _stringXML_receiveMessage, true);//将收到的数据，进行解析，并组装成XML数据registerSendMessage
                                if (registerSendMessage != null)
                                {
                                    if (antoRegister_cbx.Checked)//判断是否需要回传给服务器注册
                                    {
                                        ws_connect.ws_NewMessage_Send(_ws_session, registerSendMessage); //回传给服务器，进行注册,并且回显在控制台上
                                        stand_api.register.RegisterDGV_Status = "true";
                                    }
                                    else
                                    {
                                        stand_api.register.RegisterDGV_Status = "false";
                                    }
                                    //<-----开启一个线程，将收到的数据显示在datagridview上
                                    Thread register_datagridview_threadConsole = new Thread(new ThreadStart(Invoke_registerDatagridview));
                                    register_datagridview_threadConsole.Start();
                                    //-------->
                                }
                            }
                            #endregion

                                #region "Login"登录请求响应
                            else if (node_request == "Login")
                            {
                                string loginSendMessage = null;
                                //demo只考虑result返回OK的情况。如果需要返回fail的，请调整函数bool参数.
                                loginSendMessage = stand_api.login.API_login(_ws_session, _stringXML_receiveMessage, true);//将收到的数据，进行解析，并组装成XML数据registerSendMessage
                                if (loginSendMessage != null)
                                {
                                    if (antoLogin_cbx.Checked)//判断是否需要回传给服务器注册
                                    {
                                        ws_connect.ws_NewMessage_Send(_ws_session, loginSendMessage); //回传给服务器，进行注册,并且回显在控制台上
                                        stand_api.login.LoginDGV_Status = "true";
                                    }
                                    else
                                    {
                                        stand_api.login.LoginDGV_Status = "false";
                                    }
                                    //<-----开启一个线程，将收到的数据显示在datagridview上
                                    Thread login_datagridview_threadConsole = new Thread(new ThreadStart(Invoke_loginDatagridview));
                                    login_datagridview_threadConsole.Start();
                                    //-------->
                                }
                            }
                            #endregion

                            #region "CheckUserByDevice"推送信息userID/Card/Password/QR
                            else if (node_request == "CheckUserByDevice")
                            {
                                string checkUserByDeviceSendMessage = null;
                                //demo只考虑result返回OK的情况。如果需要返回fail的，请调整函数bool参数.
                                checkUserByDeviceSendMessage = stand_api.checkUserByDevice.F_Response(_stringXML_receiveMessage, true);//将收到的数据，进行解析，并组装成XML数据registerSendMessage
                                if (checkUserByDeviceSendMessage != null)
                                {
                                    ws_connect.ws_NewMessage_Send(_ws_session, checkUserByDeviceSendMessage); //回传给服务器,并且回显在控制台上,对象化
                                }
                            }
                            #endregion

                            #region 不明信息
                            else
                            {
                                string XmessageX = "这是一个不明信息\r\n" + _stringXML_receiveMessage;
                                ws_connect.ws_NewMessage_Receive(_ws_session, XmessageX);
                            }
                            #endregion
                        }
                        catch 
                        {
                        }
                    }
                    catch (System.Exception) 
                    {
                    }
                    #endregion

                    #region TimeLog/AdminLog记录
                    try
                    {
                        string push_event0 = null;
                        push_event0 = doc.SelectSingleNode("/Message/Event").InnerText;
                        try
                        {

                            #region "TimeLog"考勤记录响应
                            if (push_event0 == "TimeLog" || push_event0 == "TimeLog_v2")
                            {
                                string timeLogSendMessage = null;

                                //if (tbx_FeedbackMsg.Text == "")
                                //{
                                //    stand_api.timelog.S_FeedbackMsg = null;
                                //}
                                //else
                                //{
                                //    feedback = null;
                                //}
                                stand_api.timelog.S_FeedbackMsg = tbx_FeedbackMsg.Text;//可以根据不同人员工号来返回不同的feedback。
                                timeLogSendMessage = stand_api.timelog.API_TimeLog_XML(_ws_session, _stringXML_receiveMessage, true);
                                ws_connect.ws_NewMessage_Send(_ws_session, timeLogSendMessage);
                               
                            }
                            #endregion

                            #region "AdminLog"管理记录响应
                            else if (push_event0 == "AdminLog" || push_event0 == "AdminLog_v2")
                            {
                                string adminLogSendMessage = null;
                                adminLogSendMessage = stand_api.adminlog.API_AdminLog_XML(_ws_session, _stringXML_receiveMessage, true);
                                ws_connect.ws_NewMessage_Send(_ws_session, adminLogSendMessage);
                            }
                            #endregion

                            #region 不明的其他推送信息
                            else
                            {
                                string XmessageX = "这是一个不明的其他推送信息/n/r" + _stringXML_receiveMessage;
                                ws_connect.ws_NewMessage_Receive(_ws_session, XmessageX);
                            }
                            #endregion
                        }
                        catch { }
                    }
                    catch (System.Exception) { }

                    #endregion

                    #region other API回复
                    //在deviceAPIOperationForm中判断
                    #endregion

                    #region 其他未定义的XML指令



                    #endregion
                }
                catch
                {
                    //其他解析不出XML的直接回显。
                    ws_connect.ws_NewMessage_Receive(_ws_session, _stringXML_receiveMessage);
                }
                #endregion
            }
            else
            {
                string XmessageX = "发送的是空的内容/n/r";
                ws_connect.ws_NewMessage_Receive(_ws_session, XmessageX);
            }
            Thread threadConsole = new Thread(new ThreadStart(Invoke_NewMessageConsole));
            threadConsole.IsBackground = true;
            threadConsole.Start(); 
        }

        #endregion

        #region 线程Function[方法]，新数据时，显示实时接收和发送在文本框内

        /// <summary>
        /// 新数据线程，安全线程委托
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        private void Invoke_NewMessageConsole()//thread 
        {
            try 
            { 
                Invoke(new delegate_console(Function_NewMessageConsole), null); 
            }
            catch 
            {
                ws_server.NewMessageReceived -= new SessionHandler<WebSocketSession, string>(Thread_NewMessage);
                //this.Close(); 
            }
        }
        
        /// <summary>
        /// 新数据线程，线程内容操作，控制台实时显示接发数据，2 func
        /// </summary>
        private void Function_NewMessageConsole()
        {
            if (!pauseDisplay_cbx.Checked)
            {
                if (consoleMsg_tbx.Text.Length >= consoleMsg_tbx.MaxLength)
                {
                    consoleMsg_tbx.Text = "超出文本框大小，清空重新监控\r\n";
                }
                consoleMsg_tbx.Text += ws_connect.String_Console;
                consoleMsg_tbx.Select(consoleMsg_tbx.Text.Length, 0);//移动到最后  
                consoleMsg_tbx.ScrollToCaret();//滚动到光标处 
            }

            //<-----------设备请求显示,
            if (stand_api.checkUserByDevice.Request == "CheckUserByDevice")
            {
                stand_api.checkUserByDevice.Request = "";
                

                FromDeviceRequetForm FromDeviceRequet = new FromDeviceRequetForm();
                FromDeviceRequet.UserCode = stand_api.checkUserByDevice.UserCode;
                FromDeviceRequet.CodeType = stand_api.checkUserByDevice.CodeType;
                FromDeviceRequet.Show();
            }
            //---------------------->
        }



        #endregion

        #region 线程Function[方法]，新注册请求时，register_datagridview新增行，添加到注册设备的列表。
        /// <summary>
        /// 新数据线程，安全线程，1 func
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        private void Invoke_registerDatagridview()//thread 
        {
            Invoke(new delegate_registerDGV(Function_registerDatagridview), null);
        }

        /// <summary>
        /// 新数据线程，线程内容操作，register_datagridview新增行，2 func
        /// </summary>
        private void Function_registerDatagridview()
        {
            int rowCount = Step2_register_datagridview.Rows.Count;
            int i = 0;
            
            if (rowCount > 0)
            {
                //遍历所有行,判断这个序列号是否已经存在了。
                foreach (DataGridViewRow c_row in Step2_register_datagridview.Rows)
                {
                    string DGV_sessionID = c_row.Cells[2].Value.ToString();//判断会话ID
                    if (stand_api.register.SessionID == DGV_sessionID)//需要判断这个是否已经显示了。如果是则不在遍历，直接返回退出。
                    {
                        c_row.Cells[4].Value = stand_api.register.RegisterDGV_Status;
                        return;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == rowCount)//全部遍历完成，说明都没有一样的，则加这个序列号设备。
                    {

                        //后续写入数据库，datagridview绑定数据库。查找是否已经写入的序列号直接和数据库比对。不和datagridview比对。
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell no = new DataGridViewTextBoxCell();
                        no.Value = rowCount + 1;
                        row.Cells.Add(no);

                        DataGridViewTextBoxCell sn = new DataGridViewTextBoxCell();
                        sn.Value = stand_api.register.DeviceSerialNo;
                        row.Cells.Add(sn);

                        DataGridViewTextBoxCell sessionID = new DataGridViewTextBoxCell();
                        sessionID.Value = stand_api.register.SessionID;
                        row.Cells.Add(sessionID);

                        DataGridViewTextBoxCell cloudID = new DataGridViewTextBoxCell();
                        cloudID.Value = stand_api.register.CloudId;
                        row.Cells.Add(cloudID);

                        DataGridViewCheckBoxCell regStatus = new DataGridViewCheckBoxCell();
                        regStatus.Value = stand_api.register.RegisterDGV_Status;
                        row.Cells.Add(regStatus);
                        
                        Step2_register_datagridview.Rows.Add(row);
                    }
                }
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell no = new DataGridViewTextBoxCell();
                no.Value = rowCount + 1;
                row.Cells.Add(no);

                DataGridViewTextBoxCell sn = new DataGridViewTextBoxCell();
                sn.Value = stand_api.register.DeviceSerialNo;
                row.Cells.Add(sn);

                DataGridViewTextBoxCell sessionID = new DataGridViewTextBoxCell();
                sessionID.Value = stand_api.register.SessionID;
                row.Cells.Add(sessionID);

                DataGridViewTextBoxCell cloudID = new DataGridViewTextBoxCell();
                cloudID.Value = stand_api.register.CloudId;
                row.Cells.Add(cloudID);

                DataGridViewCheckBoxCell regStatus = new DataGridViewCheckBoxCell();
                regStatus.Value = stand_api.register.RegisterDGV_Status;
                row.Cells.Add(regStatus);


                Step2_register_datagridview.Rows.Add(row);
            }

        }
        #endregion

        #region 线程Function[方法]，新登录请求时，login_datagridview新增行，添加到登录设备的列表。
        /// <summary>
        /// 新数据线程，安全线程，1 func
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        private void Invoke_loginDatagridview()//thread 
        {
            Invoke(new delegate_loginDGV(Function_loginDatagridview), null);
        }

        /// <summary>
        /// 新数据线程，线程内容操作，login_datagridview新增行，2 func
        /// </summary>
        private void Function_loginDatagridview()
        {
            int rowCount = Step3_login_datagridview.Rows.Count;
            int i = 0;

            if (rowCount > 0)
            {
                //遍历所有行,判断这个序列号是否已经存在了。
                foreach (DataGridViewRow c_row in Step3_login_datagridview.Rows)
                {
                    //string deviceSerialNo = c_row.Cells[1].Value.ToString();
                    string DGV_sessionID = c_row.Cells[2].Value.ToString();//判断会话ID
                    if (stand_api.login.SessionID == DGV_sessionID)//需要判断这个是否已经显示了。如果是则不在遍历，直接返回退出。
                    {
                        c_row.Cells[3].Value = stand_api.login.LoginDGV_Status;
                        return;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == rowCount)//全部遍历完成，说明都没有一样的，则加这个序列号设备。
                    {

                        //后续写入数据库，datagridview绑定数据库。查找是否已经写入的序列号直接和数据库比对。不和datagridview比对。
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell no = new DataGridViewTextBoxCell();
                        no.Value = rowCount + 1;
                        row.Cells.Add(no);
                        DataGridViewTextBoxCell sn = new DataGridViewTextBoxCell();
                        sn.Value = stand_api.login.DeviceSerialNo;
                        row.Cells.Add(sn);
                        DataGridViewTextBoxCell sessionID = new DataGridViewTextBoxCell();
                        sessionID.Value = stand_api.login.SessionID;
                        row.Cells.Add(sessionID);
                        DataGridViewCheckBoxCell loginStatus = new DataGridViewCheckBoxCell();
                        loginStatus.Value = stand_api.login.LoginDGV_Status;
                        row.Cells.Add(loginStatus);
                        DataGridViewButtonCell deviceOpen = new DataGridViewButtonCell();
                        deviceOpen.Value = "Open";
                        row.Cells.Add(deviceOpen);

                        Step3_login_datagridview.Rows.Add(row);
                    }
                }
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell no = new DataGridViewTextBoxCell();
                no.Value = rowCount + 1;
                row.Cells.Add(no);
                DataGridViewTextBoxCell sn = new DataGridViewTextBoxCell();
                sn.Value = stand_api.login.DeviceSerialNo;
                row.Cells.Add(sn);
                DataGridViewTextBoxCell sessionID = new DataGridViewTextBoxCell();
                sessionID.Value = stand_api.login.SessionID;
                row.Cells.Add(sessionID);
                DataGridViewCheckBoxCell loginStatus = new DataGridViewCheckBoxCell();
                loginStatus.Value = stand_api.login.LoginDGV_Status;
                row.Cells.Add(loginStatus);
                DataGridViewButtonCell deviceOpen = new DataGridViewButtonCell();
                deviceOpen.Value = "Open";
                row.Cells.Add(deviceOpen);

                Step3_login_datagridview.Rows.Add(row);
            }
        }
        #endregion
        //----------->

        //<----------close devices .断开设备，删除登录列表的设备，在线设备实时显示数量
        #region SessionClosed_Thread，断开设备线程入口
        public delegate void delegate_sessionClosed();

        /// <summary>
        /// 断开设备线程入口，线程设置并启动
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="_ws_closeServer"></param>
        private void Thread_SessionClosed(WebSocketSession _ws_session, SuperSocket.SocketBase.CloseReason _ws_closeServer)
        {
            stand_api.login.SessionID = _ws_session.SessionID;
            Thread threadConsole = new Thread(new ThreadStart(Invoke_sessionClosed));
            threadConsole.IsBackground = true;
            threadConsole.Start();
        }
        #endregion
        #region 线程Function[方法]，断开设备线程，线程内容操作，sessionClosed_thread_removeRow移除行
        /// <summary>
        /// 断开设备线程，安全线程，1 func
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        private void Invoke_sessionClosed()//thread 
        {
            Invoke(new delegate_sessionClosed(Function_sessionClosed), null);
        }

        /// <summary>
        /// 断开设备线程，线程内容操作，sessionClosed_thread_removeRow移除登录列表的行，2 func
        /// </summary>
        private void Function_sessionClosed()
        {
            //在线设备数
            onlineCount_lbl.Text = Convert.ToString(ws_server.SessionCount);

            int rowCount = Step3_login_datagridview.Rows.Count;
            int i = 0;

            if (rowCount > 0)
            {
                //遍历所有行,判断这个序列号是否已经存在了。
                foreach (DataGridViewRow c_row in Step3_login_datagridview.Rows)
                {
                    string DGV_sessionID = c_row.Cells[2].Value.ToString();//判断会话ID

                    if (stand_api.login.SessionID == DGV_sessionID)//需要判断这个是否已经显示了。如果是则不在遍历，直接返回退出。
                    {
                        Step3_login_datagridview.Rows.Remove(c_row);
                        string DGV_sn = c_row.Cells[1].Value.ToString();
                        MessageBox.Show("会话ID：" + DGV_sessionID + "\r\n序列号：" + DGV_sn + "\r\n\r\n        断开连接");
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

        #endregion
        //----------->

        #region 复选框事件，暂停/显示控制台文本显示内容
        /// <summary>
        /// 暂停/显示控制台文本显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseDisplay_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!pauseDisplay_cbx.Checked)
            {
                consoleMsg_tbx.Text += "\r\n" + "===========================================" + "\r\n";
                consoleMsg_tbx.Text += DateTime.Now + "      已开启显示" + "\r\n";
            }
            else
            {
                consoleMsg_tbx.Text += "\r\n" + "===========================================" + "\r\n";
                consoleMsg_tbx.Text += DateTime.Now + "      已暂停显示" + "\r\n";
            }

            consoleMsg_tbx.Focus();//获取焦点  
            consoleMsg_tbx.Select(consoleMsg_tbx.Text.Length, 0);//移动到最后  
            consoleMsg_tbx.ScrollToCaret();//滚动到光标处
        }

        #endregion

        #region 按键事件，清除控制台文本内容
        /// <summary>
        /// 清除控制台文本内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearConsole_btn_Click(object sender, EventArgs e)
        {
            //tb_Console_string = "";
            consoleMsg_tbx.Text = "";

            return;
        }
        #endregion

        #region 按键事件，进入操作对应登录列表中的设备。
        /// <summary>
        /// 进入操作对应登录列表中的设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Step3_login_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = Step3_login_datagridview.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow row = Step3_login_datagridview.Rows[e.RowIndex];
                    string _string_sessionID = row.Cells[2].Value.ToString();//判断会话ID
                    string _string_sn = row.Cells[1].Value.ToString();//判断会话ID
                    try 
                    {
                        foreach (WebSocketSession _ws_session in ws_server.GetAllSessions())
                        {
                            if (_ws_session.SessionID == _string_sessionID)
                            {
                                deviceAPIOperationForm APIform = new deviceAPIOperationForm();

                                APIform.Session = _ws_session;
                                APIform.Ws_Server = ws_server;
                                APIform.SerialNo = stand_api.login.DeviceSerialNo;
                                APIform.Text = "DeviceSerialNo:" + stand_api.login.DeviceSerialNo;
                                APIform.Show();

                                //column.Enabled = fales;
                            }
                        }
                    }
                    catch
                    {
                        Function_sessionClosed();
                    }
                }
            }
        }
        #endregion

    }
}
