using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading;
using System.Threading.Tasks;

using log4net;
using SuperSocket;
using SuperSocket.SocketBase;
//using SuperWebSocket;
using SuperSocket.WebSocket;
using System.Windows.Forms;

using System.Xml;
using System.IO;

namespace WebsocketWinformDemo_Standard
{
    class API_02_TimeLog
    {
        #region API_02_TimeLog Attributes[属性]

        private string _timelog_NO;
        /// <summary>
        /// Timelog，编号
        /// </summary>
        public string Timelog_NO
        {
            get { return _timelog_NO; }
            set { _timelog_NO = value; }
        }

        private string sessionID;
        /// <summary>
        /// 登录设备，会话ID
        /// </summary>
        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        private string S_feedbackMsg;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_FeedbackMsg
        {
            get { return S_feedbackMsg; }
            set { S_feedbackMsg = value; }
        }

        #region TimeLog XML字段
        private string rrid;
        /// <summary>
        /// XML，流水号字段
        /// </summary>
        public string Rrid
        {
            get { return rrid; }
            set { rrid = value; }
        }

        private string terminalType;
        /// <summary>
        /// XML，设备型号字段
        /// </summary>
        public string TerminalType
        {
            get { return terminalType; }
            set { terminalType = value; }
        }

        private string hardwareVer;
        /// <summary>
        /// XML，硬件版本字段
        /// </summary>
        public string HardwareVer
        {
            get { return hardwareVer; }
            set { hardwareVer = value; }
        }

        private Int32 terminalID;
        /// <summary>
        /// XML，设备型号ID字段
        /// </summary>
        public Int32 TerminalID
        {
            get { return terminalID; }
            set { terminalID = value; }
        }

        private string productName;
        /// <summary>
        /// XML，设备产品名称字段
        /// </summary>
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string deviceSerialNo;
        /// <summary>
        /// XML，设备序列号字段
        /// </summary>
        public string DeviceSerialNo
        {
            get { return deviceSerialNo; }
            set { deviceSerialNo = value; }
        }

        private string version;
        /// <summary>
        /// XML，流水号字段
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string push_event;
        /// <summary>
        /// XML，推送记录字段,TimeLog/AdminLog...
        /// </summary>
        public string Push_event
        {
            get { return push_event; }
            set { push_event = value; }
        }

        private Int32 logID;
        /// <summary>
        /// XML，记录ID字段,
        /// </summary>
        public Int32 LogID
        {
            get { return logID; }
            set { logID = value; }
        }

        private string stime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Time
        {
            get { return stime; }
            set { stime = value; }
        }

        private Int32 userID;
        /// <summary>
        /// XML，工号ID字段,
        /// </summary>
        public Int32 UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string action;
        /// <summary>
        /// XML，识别模式字段,
        /// </summary>
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private string attendStat;
        /// <summary>
        /// XML，考勤状态字段,
        /// </summary>
        public string AttendStat
        {
            get { return attendStat; }
            set { attendStat = value; }
        }

        private string apStat;
        /// <summary>
        /// XML，胁迫状态字段,
        /// </summary>
        public string APStat
        {
            get { return apStat; }
            set { apStat = value; }
        }

        private string jobCode;
        /// <summary>
        /// XML，打卡代码字段,
        /// </summary>
        public string JobCode
        {
            get { return jobCode; }
            set { jobCode = value; }
        }

        private string photo;
        /// <summary>
        /// XML，是否有照片字段,
        /// </summary>
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        private string transID;
        /// <summary>
        /// XML，是否有照片字段,F500专用
        /// </summary>
        public string TransID
        {
            get { return transID; }
            set { transID = value; }
        }

        private string logImage;
        /// <summary>
        /// XML，实时照片的数据，当Photo为Yes时有效,
        /// </summary>
        public string LogImage
        {
            get { return logImage; }
            set { logImage = value; }
        }

        
        #endregion
        #endregion

        #region API_02_TimeLog XML解析Function[方法]
        /// **********************************

        //<?xml version="1.0"?>
        //<Message>
        //<Rrid>2</Rrid>
        //<TerminalType>PFS100</TerminalType>
        //<HardwareVer>4900</HardwareVer>
        //<TerminalID>1</TerminalID>
        //<ProductName>WO491</ProductName>
        //<DeviceSerialNo>wb2018042802</DeviceSerialNo>
        //<Version>ZD4900 v2.0.180308</Version>
        //<Event>TimeLog</Event>
        //<LogID>1</LogID>
        //<Time>2018-05-09-T20:07:33Z</Time>
        //<UserID>1</UserID>
        //<Action>FP</Action>
        //<AttendStat></AttendStat>
        //<APStat>None</APStat>
        //<JobCode>0</JobCode>
        //<Photo>No</Photo>
        //<LogImage>Photo data in base64 encoding</LogImage>
        //</Message>
        ///***************************************



        /// <summary>
        /// 解析websocket服务器发送登录请求的massage信息，并根据resultStatus确定是否允许注册
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        /// <param name="resultStatus"></param>
        public string API_TimeLog_XML(WebSocketSession session, string ReceiveMessage, bool resultStatus)
        {
            string SendMessage = null;
            string result = "OK";
            if (ReceiveMessage != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ReceiveMessage);

                sessionID = session.SessionID;

                try
                {
                    push_event = doc.SelectSingleNode("/Message/Event").InnerText;
                }
                catch (System.Exception) { }


                if (push_event == "TimeLog" || push_event == "TimeLog_v2")
                {

                    try
                    {
                        rrid = doc.SelectSingleNode("/Message/Rrid").InnerText;
                    }
                    catch (System.Exception) { }


                    try
                    {
                        terminalType = doc.SelectSingleNode("/Message/TerminalType").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        hardwareVer = doc.SelectSingleNode("/Message/HardwareVer").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        terminalID = Convert.ToInt32(doc.SelectSingleNode("/Message/TerminalID").InnerText);
                    }
                    catch (System.Exception) { }

                    try
                    {
                        productName = doc.SelectSingleNode("/Message/ProductName").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        deviceSerialNo = doc.SelectSingleNode("/Message/DeviceSerialNo").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        version = doc.SelectSingleNode("/Message/Version").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        logID = Convert.ToInt32(doc.SelectSingleNode("/Message/LogID").InnerText);
                    }
                    catch (System.Exception) { }

                    try
                    {
                        stime = doc.SelectSingleNode("/Message/Time").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        userID = Convert.ToInt32(doc.SelectSingleNode("/Message/UserID").InnerText);
                    }
                    catch (System.Exception) { }

                    
                    try
                    {
                        action = doc.SelectSingleNode("/Message/Action").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        attendStat = doc.SelectSingleNode("/Message/AttendStat").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        apStat = doc.SelectSingleNode("/Message/APStat").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        jobCode = doc.SelectSingleNode("/Message/JobCode").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        photo = doc.SelectSingleNode("/Message/Photo").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        transID = doc.SelectSingleNode("/Message/TransID").InnerText;
                    }
                    catch (System.Exception) { }


                    if (photo == "Yes")
                    {
                        try
                        {
                            logImage = doc.SelectSingleNode("/Message/LogImage").InnerText;
                        }
                        catch (System.Exception) { }
                    }
                    else
                    {
                        logImage = null;
                    }


                    
                    if (resultStatus == true)
                    {
                        result = "OK";
                    }
                    else
                    {
                        result = "Fail";
                    }

                    //<Time>2018-4-11-T11:28:54Z</Time>
                    DateTime dt = DateTime.Now;
                    string Year = dt.Year.ToString();
                    string Month = dt.Month.ToString();
                    string Day = dt.Day.ToString();
                    string Hour = dt.Hour.ToString();
                    string Minute = dt.Minute.ToString();
                    string Second = dt.Second.ToString();

                    string DateTT = Year + "-" + Month + "-" + Day;//2018-4-11
                    string TimeTT = Hour + ":" + Minute + ":" + Second;//11:28:54

                    string time = DateTT + "-T" + TimeTT + "Z";//2013-4-11-T11:28:54Z

                    string feedback = null;
                    if (S_feedbackMsg == "" || S_feedbackMsg == null)
                    {
                        feedback = null; 
                    }
                    else
                    {
                        feedback = "<FeedbackMsg>" + S_feedbackMsg + "</FeedbackMsg>\r\n";
                    }


#if(F500)           //F500 XML
                    SendMessage = "<?xml version=\"1.0\"?>\r\n" +
                                  "<Message>\r\n" +
                                  "<Response>" + push_event + "</Response>\r\n" +
                                  "<TransID>" + TransID +"</TransID>\r\n" +
                                  "<Result>" + result + "</Result>\r\n" +
                                  "</Message>";
#endif
#if(Standard)       //standard XML
                    SendMessage = "<?xml version=\"1.0\"?>\r\n" +
                                  "<Message>\r\n" +
                                  "<Response>" + push_event + "</Response>\r\n" +
                                  "<Actid>" + rrid + "</Actid>\r\n" +
                                  "<Time>" + time + "</Time>\r\n" +
                                  feedback +
                                  //"<FeedbackMsg>" + S_feedbackMsg + "</FeedbackMsg>\r\n" +
                                  "<Result>" + result + "</Result>\r\n" +
                                  "</Message>";
#endif

                    return SendMessage;
                }
                else
                {
                    SendMessage = null;
                    return SendMessage;
                }
            }
            else
            {
                SendMessage = null;
                return SendMessage;
            }
        }

        #endregion
    }
}
