using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WebsocketWinformDemo_Standard
{
    class API_03_CheckUserByDevice
    {
        #region API_01_login Attributes[属性]

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

        private string request="";
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

        private string codeType;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string CodeType
        {
            get { return codeType; }
            set { codeType = value; }
        }

        private string userCode;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string UserCode
        {
            get { return userCode; }
            set { userCode = value; }
        }
        #endregion

        #region 返回xml字段，Attributes[属性]
        private string S_response;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_Response
        {
            get { return S_response; }
            set { S_response = value; }
        }

        private string S_actid;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_Actid
        {
            get { return S_actid; }
            set { S_actid = value; }
        }

        private string S_time;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_Time
        {
            get { return S_time; }
            set { S_time = value; }
        }

        private string S_deviceSerialNo;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_DeviceSerialNo
        {
            get { return S_deviceSerialNo; }
            set { S_deviceSerialNo = value; }
        }

        private string S_codeType;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_CodeType
        {
            get { return S_codeType; }
            set { S_codeType = value; }
        }

        private string S_userCode;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_UserCode
        {
            get { return S_userCode; }
            set { S_userCode = value; }
        }

        private string S_result;
        /// <summary>
        ///  XML，登录设备，会话ID
        /// </summary>
        public string S_Result
        {
            get { return S_result; }
            set { S_result = value; }
        }

        #endregion
        #endregion

        #region API_01_login XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>CheckUserByDevice</Request>
        //<Rrid>xxxxxxxx</Rrid>
        //<Version>4900 v3.3.5</Version>
        //<DeviceSerialNo>SN123456</DeviceSerialNo>
        //<CodeType>UserID/Password/Card/QR</CodeType>
        //<UserCode>345156</UserCode>
        //</Message>


        //<?xml version="1.0"?>
        //<Message>
        //<Response>CheckUserByDevice</Response>
        //<Actid>2</Actid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<DeviceSerialNo>SN123456<DeviceSerialNo>
        //<CodeType>UserID/Password/Card/QR</CodeType> <!--Code 的值类型 -->
        //<UserCode>345156</UserCode>
        //<Result>OK/Fail</Result>
        //</Message>
        ///***************************************
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="message"></param>
        /// <param name="resultStatus"></param>
        public string F_Response(string ReceiveMessage, bool resultStatus)
        {
            string SendMessage = null;
            string S_result = "OK";
            if (ReceiveMessage != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ReceiveMessage);

                try
                {
                    request = doc.SelectSingleNode("/Message/Request").InnerText;
                }
                catch (System.Exception) { }


                if (request == "CheckUserByDevice")
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
                        codeType = doc.SelectSingleNode("/Message/CodeType").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        userCode = doc.SelectSingleNode("/Message/UserCode").InnerText;
                    }
                    catch (System.Exception) { }


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
                                  "<Response>" + S_response + "</Response>\r\n" +
                                  "<Actid>" + S_actid + "</Actid>\r\n" +
                                  "<Time>" + S_time + "</Time>\r\n" +
                                  "<DeviceSerialNo>" + S_deviceSerialNo + "</DeviceSerialNo>\r\n" +
                                  "<CodeType>" + S_codeType + "</CodeType>\r\n" +
                                  "<UserCode>" + S_userCode + "</UserCode>\r\n" +
                                  "<Result>" + S_result + "</Result>\r\n" +
                                  "</Message>";

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
