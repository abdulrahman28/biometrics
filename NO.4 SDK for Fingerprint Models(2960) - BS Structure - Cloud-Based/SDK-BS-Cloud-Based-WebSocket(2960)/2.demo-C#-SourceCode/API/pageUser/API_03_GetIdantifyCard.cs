using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml;
using System.IO;

namespace WebsocketWinformDemo_Standard
{
    class API_03_GetIdantifyCard
    {

        #region API_03_GetIdantifyCard Attributes[属性]

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

        private string gender;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string nation;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }

        private string birthday;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string address;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string authority;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Authority
        {
            get { return authority; }
            set { authority = value; }
        }

        private string validDate;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string ValidDate
        {
            get { return validDate; }
            set { validDate = value; }
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


        private string fingersData;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string FingersData
        {
            get { return fingersData; }
            set { fingersData = value; }
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

        #region API_03_GetIdantifyCard XML指令和返回数据
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetIdantifyCard</Request>
        //<Ccid>2</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show</Action_ext>
        //<UserID>440102199901013214</UserID>
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
        //<Response>GetIdantifyCard</Response>
        //<UserID>440102199901013214</UserID>
        //<Name>张三</Name>
        //<Gender>男</Gender>
        //<Nation>汉</Nation>
        //<Birthday>1999-01-01</Birthday>
        //<Address>xx省xx市xx区xx街道xx楼xx号</Address>
        //<Authority>xx市xx区xx分局</Authority>
        //<ValidDate>2010.01.01-2020.01.01</ValidDate>
        //<Photo>Data</Photo>
        //<FingersData Fingers="2">
        //<Finger id="1">Data</Finger>
        //<Finger id="2">Data</Finger>
        //</FingersData>
        //<Result>OK</Result>
        //</Message>

        
        /// <summary>
        /// 发送GetIdantifyCard指令.
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
                          "<Request>GetIdantifyCard</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "<UserID>" + strUserID + "</UserID>\r\n" +
                          "</Message>";
            return requestXMLMassage;
        }

        /// <summary>
        /// 解析返回的GetUserAllInfo的数据，解析成功返回true
        /// </summary>
        /// <param name="ResponseMessage"></param>
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

                if (response == "GetIdantifyCard")
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
                        gender = doc.SelectSingleNode("/Message/Gender").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        nation = doc.SelectSingleNode("/Message/Nation").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        birthday = doc.SelectSingleNode("/Message/Birthday").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        address = doc.SelectSingleNode("/Message/Address").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        authority = doc.SelectSingleNode("/Message/Authority").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        validDate = doc.SelectSingleNode("/Message/ValidDate").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        photo = doc.SelectSingleNode("/Message/Photo").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        fingersData = doc.SelectSingleNode("/Message/FingersData").InnerText;
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