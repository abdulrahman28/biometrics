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
    class API_01_login
    {
        #region API_01_login Attributes[属性]

        private string _loginDGV_NO;
        /// <summary>
        /// 登录设备，datagritview编号
        /// </summary>
        public string LoginDGV_NO
        {
            get { return _loginDGV_NO; }
            set { _loginDGV_NO = value; }
        }

        private string _loginDGV_Status;
        /// <summary>
        /// 登录设备，datagritview登录的状态，勾选则登录。
        /// </summary>
        public string LoginDGV_Status
        {
            get { return _loginDGV_Status; }
            set { _loginDGV_Status = value; }
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
        /// XML，流水号字段
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
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

        private string token;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string Token
        {
            get { return token; }
            set { token = value; }
        }
        #endregion

        #region API_01_login XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>Login</Request>
        //<Rrid>xxxxxxxx</Rrid>
        //<Version>4900 v3.3.5</Version>
        //<DeviceSerialNo>SN123456</DeviceSerialNo>
        //<Token>ee73fe2d-f765-7c13-bc8a-b584b0db5796</Token>
        //</Message>
        ///***************************************



        /// <summary>
        /// 解析websocket服务器发送登录请求的massage信息，并根据resultStatus确定是否允许注册
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        /// <param name="resultStatus"></param>
        public string API_login(WebSocketSession session, string ReceiveMessage, bool resultStatus)
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
                    request = doc.SelectSingleNode("/Message/Request").InnerText;
                }
                catch (System.Exception) { }


                if (request == "Login")
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
                        deviceSerialNo = doc.SelectSingleNode("/Message/DeviceSerialNo").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        token = doc.SelectSingleNode("/Message/Token").InnerText;
                    }
                    catch (System.Exception) { }


                    if (resultStatus == true)
                    {
                        result = "OK";
                        _loginDGV_Status = "true";
                    }
                    else
                    {
                        result = "Fail";
                        _loginDGV_Status = "false";
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
                                  "<Response>" + request + "</Response>\r\n" +
                                  "<Actid>" + rrid + "</Actid>\r\n" +
                                  "<Time>" + time + "</Time>\r\n" +
                                  "<DeviceSerialNo>" + deviceSerialNo + "</DeviceSerialNo>\r\n" +
                                  "<Result>" + result + "</Result>\r\n" +
                                  "</Message>";


                    return SendMessage;
                }
                else
                {
                    _loginDGV_Status = "false";
                    SendMessage = null;
                    return SendMessage;
                }
            }
            else
            {
                _loginDGV_Status = "false";
                SendMessage = null;
                return SendMessage;
            }
        }

        #endregion
    }
}
