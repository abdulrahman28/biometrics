using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WebsocketWinformDemo_Standard
{
    class API_03_GetEthernetSetting
    {

        #region API_03_GetEthernetSetting Attributes[属性]

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

        private string macAddress;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }


        private string dhcp;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DHCP
        {
            get { return dhcp; }
            set { dhcp = value; }
        }

        private string ip;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        private string subnet;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Subnet
        {
            get { return subnet; }
            set { subnet = value; }
        }

        private string defaultGateway;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DefaultGateway
        {
            get { return defaultGateway; }
            set { defaultGateway = value; }
        }

        private string ip_from_dhcp;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string IP_from_dhcp
        {
            get { return ip_from_dhcp; }
            set { ip_from_dhcp = value; }
        }

        private string subnet_from_dhcp;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string Subnet_from_dhcp
        {
            get { return subnet_from_dhcp; }
            set { subnet_from_dhcp = value; }
        }

        private string defaultGateway_from_dhcp;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DefaultGateway_from_dhcp
        {
            get { return defaultGateway_from_dhcp; }
            set { defaultGateway_from_dhcp = value; }
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

        #region API_03_GetEthernetSetting XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetEthernetSetting</Request>
        //<Ccid>2</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show/xx<Action_ext>
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
        //<Response>GetEthernetSetting</Response>
        //<MacAddress>00:10:dd:01:08:81</MacAddress>
        //<DHCP>Yes</DHCP>
        //<IP>192.168.1.102</IP>
        //<Subnet>255.255.255.0</Subnet>
        //<DefaultGateway>192.168.1.1</DefaultGateway>
        //<IP_from_dhcp>192.168.1.15</IP_from_dhcp>
        //<Subnet_from_dhcp>255.255.255.0</Subnet_from_dhcp>
        //<DefaultGateway_from_dhcp>0.0.0.0</DefaultGateway_from_dhcp>
        //<Result>OK</Result>
        //</Message>
        ///***************************************



        /// <summary>
        /// 发送GetEthernetSetting指令.
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
                          "<Request>GetEthernetSetting</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "</Message>";
            return requestXMLMassage;

        }


        /// <summary>
        /// 解析返回的GetEthernetSetting的数据，解析成功返回true
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

                if (response == "GetEthernetSetting")
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
                        macAddress = doc.SelectSingleNode("/Message/MacAddress").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        dhcp = doc.SelectSingleNode("/Message/DHCP").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        ip = doc.SelectSingleNode("/Message/IP").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        subnet = doc.SelectSingleNode("/Message/Subnet").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        defaultGateway = doc.SelectSingleNode("/Message/DefaultGateway").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        ip_from_dhcp = doc.SelectSingleNode("/Message/IP_from_dhcp").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        subnet_from_dhcp = doc.SelectSingleNode("/Message/Subnet_from_dhcp").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        defaultGateway_from_dhcp = doc.SelectSingleNode("/Message/DefaultGateway_from_dhcp").InnerText;
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
