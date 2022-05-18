using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WebsocketWinformDemo_Standard
{
    class API_03_GetFirstGlog
    {
        #region API_03_GetFirstGlog Attributes[属性]

        private string requestXMLMassage;
        /// <summary>
        /// 请求的XML
        /// </summary>
        public string RequestXMLmassage
        {
            get { return requestXMLMassage; }
            set { requestXMLMassage = value; }
        }

        private string responseXMLMassage;
        /// <summary>
        /// 接收的XML
        /// </summary>
        public string ResponseXMLmassage
        {
            get { return responseXMLMassage; }
            set { responseXMLMassage = value; }
        }

        #region 请求命令xml字段，Attributes[属性]
        private string S_ccid;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_Ccid
        {
            get { return S_ccid; }
            set { S_ccid = value; }
        }

        private string S_action_ext;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_Action_ext
        {
            get { return S_action_ext; }
            set { S_action_ext = value; }
        }

        private string S_beginLogPos;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_BeginLogPos
        {
            get { return S_beginLogPos; }
            set { S_beginLogPos = value; }
        }

        private string S_userID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_UserID
        {
            get { return S_userID; }
            set { S_userID = value; }
        }

        private string S_startTime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_StartTime
        {
            get { return S_startTime; }
            set { S_startTime = value; }
        }

        private string S_endTime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_EndTime
        {
            get { return S_endTime; }
            set { S_endTime = value; }
        }
        #endregion

        #region 接收回复xml字段，Attributes[属性]

        private string actid;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Actid
        {
            get { return actid; }
            set { actid = value; }
        }

        private string terminalType;
        /// <summary>
        /// XML字段
        /// </summary>
        public string TerminalType
        {
            get { return terminalType; }
            set { terminalType = value; }
        }
        private string hardwareVer;
        /// <summary>
        /// XML字段
        /// </summary>
        public string HardwareVer
        {
            get { return hardwareVer; }
            set { hardwareVer = value; }
        }

        private string terminalID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string TerminalID
        {
            get { return terminalID; }
            set { terminalID = value; }
        }

        private string deviceSerialNo;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DeviceSerialNo
        {
            get { return deviceSerialNo; }
            set { deviceSerialNo = value; }
        }

        private string version;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string action_ext;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Action_ext
        {
            get { return action_ext; }
            set { action_ext = value; }
        }

        private string response;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Response
        {
            get { return response; }
            set { response = value; }
        }



        private string logID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string LogID
        {
            get { return logID; }
            set { logID = value; }
        }


        private string time;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }


        private string userID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string action;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private string attendStat;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string AttendStat
        {
            get { return attendStat; }
            set { attendStat = value; }
        }

        private string apStat;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string APStat
        {
            get { return apStat; }
            set { apStat = value; }
        }

        private string jobCode;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string JobCode
        {
            get { return jobCode; }
            set { jobCode = value; }
        }

        private string photo;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        private string logImage;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string LogImage
        {
            get { return logImage; }
            set { logImage = value; }
        }

        private string result;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        #endregion
        #endregion

        #region API_03_GetFirstGlog XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetFirstGlog</Request>
        //<Ccid>2</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show/xx<Action_ext>
        //<BeginLogPos>0</BeginLogPos>
        //<UserID>xxx</UserID >
        //<StartTime>2013-4-11-T11:28:54Z</StartTime>
        //<EndTime>2018-4-11-T11:28:54Z</EndTime>
        //</Message>

        //<?xml version="1.0"?>
        //<Message>
        //<Actid>2</Actid>
        //<TerminalType>PFS100</TerminalType>
        //<HardwareVer>4900</HardwareVer>
        //<TerminalID>1</TerminalID>
        //<DeviceSerialNo>wb2018042801</DeviceSerialNo>
        //<Version>ZD4900 v2.0.180308</Version>
        //<Action_ext>show/xx</Action_ext>
        //<Response>GetFirstGlog</Response>
        //<LogID>0</LogID>
        //<Time>2018-05-08-T19:39:43Z</Time>
        //<UserID>7</UserID>
        //<Action>FACE</Action>
        //<AttendStat></AttendStat>
        //<APStat>None</APStat>
        //<JobCode>0</JobCode>
        //<Photo>No</Photo>
        //<LogImage>Photo data in base64 encoding</LogImage>
        //<Result>OK</Result>
        //</Message>
        ///***************************************



        /// <summary>
        /// 发送GetFirstGlog指令.
        /// </summary>
        /// <param name="ccid"></param>
        /// <param name="action_ext"></param>
        /// <param name="userID"></param>
        public string F_Request()
        {
            string strCcid = Convert.ToString(S_ccid);

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


            requestXMLMassage = "<?xml version=\"1.0\"?>\r\n" +
                          "<Message>\r\n" +
                          "<Request>GetFirstGlog</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "<BeginLogPos>" + S_beginLogPos + "</BeginLogPos>\r\n" +
                          "<UserID>" + S_userID + "</UserID>\r\n" +
                          "<StartTime>" + S_startTime + "</StartTime>\r\n" +
                          "<EndTime>" + S_endTime + "</EndTime>\r\n" +
                          "</Message>";
            return requestXMLMassage;

        }

        /// <summary>
        /// 解析返回的GetFirstGlog的数据，解析成功返回true
        /// </summary>
        /// <param name="ResponseMessage"></param>
        /// <returns></returns>
        public bool F_Response(string ResponseMessage)
        {
            responseXMLMassage = ResponseMessage;

            if (ResponseMessage != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ResponseMessage);

                try
                {
                    response = doc.SelectSingleNode("/Message/Response").InnerText;
                }
                catch (System.Exception) { }

                if (response == "GetFirstGlog")
                {

                    #region 设备发回来的相同部分
                    try
                    {
                        actid = doc.SelectSingleNode("/Message/Actid").InnerText;
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
                        terminalID = doc.SelectSingleNode("/Message/TerminalID").InnerText;
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
                        action_ext = doc.SelectSingleNode("/Message/Action_ext").InnerText;
                    }
                    catch (System.Exception) { }


                    #endregion



                    try
                    {
                        logID = doc.SelectSingleNode("/Message/LogID").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        time = doc.SelectSingleNode("/Message/Time").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        userID = doc.SelectSingleNode("/Message/UserID").InnerText;
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
                        logImage = doc.SelectSingleNode("/Message/LogImage").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        result = doc.SelectSingleNode("/Message/Result").InnerText;
                    }
                    catch (System.Exception) { }



                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }


        }


        #endregion
    }
}
