using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace WebsocketWinformDemo_Standard
{
    class API_03_GetUserData
    {
        #region API_03_GetUserData Attributes[属性]

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

        private string S_userID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_UserID
        {
            get { return S_userID; }
            set { S_userID = value; }
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

       

        


        private string userID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string name;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string userSN;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string UserSN
        {
            get { return userSN; }
            set { userSN = value; }
        }

        private string privilege;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }

        private string depart;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Depart
        {
            get { return depart; }
            set { depart = value; }
        }

        private string enabled;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        private string card;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Card
        {
            get { return card; }
            set { card = value; }
        }

        private string pwd;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string PWD
        {
            get { return pwd; }
            set { pwd = value; }
        }

        private string fingers;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Fingers
        {
            get { return fingers; }
            set { fingers = value; }
        }

        private string faceEnrolled;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string FaceEnrolled
        {
            get { return faceEnrolled; }
            set { faceEnrolled = value; }
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

        #region API_03_GetUserData XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetUserData</Request>
        //<Ccid>2</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show/xx</Action_ext>
        //<UserID>1</UserID>
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
        //<Response>GetUserData</Response>
        //<UserID>1</UserID>
        //<UserSN>455dfd54SDF</UserSN>
        //<Name></Name>
        //<Privilege>User</Privilege>
        //<Depart>0</Depart>
        //<Enabled>Yes</Enabled>
        //<Card>9499024</Card>
        //<PWD>1</PWD>
        //<Fingers>2</Fingers>
        //<FaceEnrolled>Yes</FaceEnrolled>
        //<Result>OK</Result>
        //</Message>
        ///***************************************



        /// <summary>
        /// 发送API_03_GetUserData指令.
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

            string strUserID = Convert.ToString(S_userID);


            requestXMLMassage = "<?xml version=\"1.0\"?>\r\n" +
                          "<Message>\r\n" +
                          "<Request>GetUserData</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "<UserID>" + strUserID + "</UserID>\r\n" +
                          "</Message>";
            return requestXMLMassage;

        }


        /// <summary>
        /// 解析返回的GetUserData的数据，解析成功返回true
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

                if (response == "GetUserData")
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
                        userID = doc.SelectSingleNode("/Message/UserID").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        name = doc.SelectSingleNode("/Message/Name").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        userSN = doc.SelectSingleNode("/Message/UserSN").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        privilege = doc.SelectSingleNode("/Message/Privilege").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        depart = doc.SelectSingleNode("/Message/Depart").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        enabled = doc.SelectSingleNode("/Message/Enabled").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        card = doc.SelectSingleNode("/Message/Card").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        pwd = doc.SelectSingleNode("/Message/PWD").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        fingers = doc.SelectSingleNode("/Message/Fingers").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        faceEnrolled = doc.SelectSingleNode("/Message/FaceEnrolled").InnerText;
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
