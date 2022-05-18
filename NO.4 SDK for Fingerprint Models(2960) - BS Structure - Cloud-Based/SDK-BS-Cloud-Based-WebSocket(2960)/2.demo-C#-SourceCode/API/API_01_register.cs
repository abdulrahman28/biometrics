using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using SuperSocket;
using SuperSocket.SocketBase;
//using SuperWebSocket;
using SuperSocket.WebSocket;
using System.Windows.Forms;

using System.Xml;
using System.IO;

using System.Threading;

namespace WebsocketWinformDemo_Standard
{
    class API_01_register
    {
        #region API_01_register Attributes[属性]

        private string _registerDGV_NO;
        /// <summary>
        /// 注册设备，datagritview编号
        /// </summary>
        public string RegisterDGV_NO
        {
            get { return _registerDGV_NO; }
            set { _registerDGV_NO = value; }
        }

        private string _registerDGV_Status;
        /// <summary>
        /// 注册设备，datagritview注册的状态，勾选则注册。
        /// </summary>
        public string RegisterDGV_Status
        {
            get { return _registerDGV_Status; }
            set { _registerDGV_Status = value; }
        }


        private string sessionID;
        /// <summary>
        /// 注册设备，会话ID
        /// </summary>
        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        private string request;
        /// <summary>
        /// XML，请求字段
        /// </summary>
        public string Request
        {
            get { return request; }
            set { request = value; }
        }

        private string rrid;
        /// <summary>
        /// XML，流水号字段
        /// </summary>
        public string Rrid
        {
            get { return rrid; }
            set { rrid = value; }
        }

        private string version;
        /// <summary>
        /// XML，固件版本字段
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
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

        private string cloudId;
        /// <summary>
        /// XML，云ID字段
        /// </summary>
        public string CloudId
        {
            get { return cloudId; }
            set { cloudId = value; }
        }

        #endregion

        #region API_01_register XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>Register</Request>//
        //<Rrid>0</Rrid>//
        //<Version>ZD4900 v2.0.180308</Version>//
        //<TerminalType>PFS100-FP</TerminalType>//
        //<HardwareVer>4900</HardwareVer>//
        //<ProductName>M70</ProductName>//
        //<DeviceSerialNo>sn123</DeviceSerialNo>//
        //<CloudId>cloudid12345678</CloudId>//
        //</Message>
        ///***************************************



        /// <summary>
        /// 解析websocket服务器发送Z注册请求的massage信息，并根据resultStatus确定是否允许注册
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        /// <param name="resultStatus"></param>
        public string API_register(WebSocketSession session, string ReceiveMessage, bool resultStatus)
        {
            string SendMessage = null;
            string result = "OK";
            if (ReceiveMessage!=null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ReceiveMessage);

                sessionID = session.SessionID;
                try
                {
                    request = doc.SelectSingleNode("/Message/Request").InnerText;
                }
                catch (System.Exception) { }

                
                if (request == "Register")
                {
                    
                    try
                    {
                        rrid = doc.SelectSingleNode("/Message/Rrid").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        version = doc.SelectSingleNode("/Message/Version").InnerText;
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
                        cloudId = doc.SelectSingleNode("/Message/CloudId").InnerText;
                        //cloudId = "这个是测试的哦----";
                    }
                    catch (System.Exception) { }

                    if (resultStatus == true)
                    {
                        result = "OK";
                        _registerDGV_Status = "true";
                    }
                    else
                    {
                        result = "Fail";
                        _registerDGV_Status = "false";
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


                    SendMessage = "<?xml version=\"1.0\"?>\r\n" +
                                  "<Message>\r\n" +
                                  "<Response>"+ request + "</Response>\r\n" +
                                  "<Actid>" + rrid + "</Actid>\r\n" +
                                  "<Time>" + time + "</Time>\r\n" +
                                  "<DeviceSerialNo>" + deviceSerialNo + "</DeviceSerialNo>\r\n" +
                                  "<Token>" + sessionID + "</Token>\r\n" +
                                  "<Result>" + result + "</Result>\r\n" +
                                  "</Message>";


                    return SendMessage;
                }
                else
                {
                    _registerDGV_Status = "false";
                    SendMessage = null;
                    return SendMessage;
                }
            }
            else
            {
                _registerDGV_Status = "false";
                SendMessage = null;
                return SendMessage;
            }
        }

        #endregion
    }
}
