using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;
namespace WebsocketWinformDemo_Standard
{
    class API_03_GetAccessSetting
    {
        #region API_03_GetAccessSetting Attributes[属性]

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

        
        private string lockReleaseTime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string LockReleaseTime
        {
            get { return lockReleaseTime; }
            set { lockReleaseTime = value; }
        }

        private string verifyPassLockReleaseTime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string VerifyPassLockReleaseTime
        {
            get { return verifyPassLockReleaseTime; }
            set { verifyPassLockReleaseTime = value; }
        }

        private string passTime;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string PassTime
        {
            get { return passTime; }
            set { passTime = value; }
        }

        private string allWeek;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string AllWeek
        {
            get { return allWeek; }
            set { allWeek = value; }
        }

        private string startWeek;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string StartWeek
        {
            get { return startWeek; }
            set { startWeek = value; }
        }

        
        private string endWeek;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string EndWeek
        {
            get { return endWeek; }
            set { endWeek = value; }
        }

        private string doorOpenTimeout;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DoorOpenTimeout
        {
            get { return doorOpenTimeout; }
            set { doorOpenTimeout = value; }
        }

        private string doorSensorType;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DoorSensorType
        {
            get { return doorSensorType; }
            set { doorSensorType = value; }
        }

        private string duressAlarm;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string DuressAlarm
        {
            get { return duressAlarm; }
            set { duressAlarm = value; }
        }

        private string linkageAlarm;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string LinkageAlarm
        {
            get { return linkageAlarm; }
            set { linkageAlarm = value; }
        }

        private string tamperAlarm;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string TamperAlarm
        {
            get { return tamperAlarm; }
            set { tamperAlarm = value; }
        }

        private string blackListAlarm;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string BlackListAlarm
        {
            get { return blackListAlarm; }
            set { blackListAlarm = value; }
        }

        private string wgOutputFormat;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string WGOutputFormat
        {
            get { return wgOutputFormat; }
            set { wgOutputFormat = value; }
        }

        private string wgOutputContent;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string WGOutputContent
        {
            get { return wgOutputContent; }
            set { wgOutputContent = value; }
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

        #region API_03_GetAccessSetting XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetAccessSetting</Request>
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
        //<Response>GetAccessSetting</Response>
        //<LockReleaseTime>CustomOpen</LockReleaseTime>
        //<VerifyPassLockReleaseTime>5</VerifyPassLockReleaseTime>
        //<PassTime>00:00-23:59</PassTime>
        //<AllWeek>No</AllWeek>
        //<StartWeek>Sun</StartWeek>
        //<EndWeek>Sun</EndWeek>
        //<DoorOpenTimeout>20</DoorOpenTimeout>
        //<DoorSensorType>None</DoorSensorType>
        //<DuressAlarm>Yes</AntipassAlarm>
        //<LinkageAlarm>Yes</LinkageAlarm>
        //<TamperAlarm>Yes</TamperAlarm>
        //<BlackListAlarm>Yes</BlackListAlarm>
        //<WGOutputFormat>26</WGOutputFormat>
        //<WGOutputContent>UserID</WGOutputContent>
        //<Result>OK</Result>
        //</Message>
        ///***************************************



        /// <summary>
        /// 发送GetAccessSetting指令.
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
                          "<Request>GetAccessSetting</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "</Message>";
            return requestXMLMassage;

        }


        /// <summary>
        /// 解析返回的GetAccessSetting的数据，解析成功返回true
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

                if (response == "GetAccessSetting")
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
                        lockReleaseTime = doc.SelectSingleNode("/Message/LockReleaseTime").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        verifyPassLockReleaseTime = doc.SelectSingleNode("/Message/VerifyPassLockReleaseTime").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        passTime = doc.SelectSingleNode("/Message/PassTime").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        allWeek = doc.SelectSingleNode("/Message/AllWeek").InnerText;
                    }
                    catch (System.Exception) { }
                    
                    try
                    {
                        startWeek = doc.SelectSingleNode("/Message/StartWeek").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        endWeek = doc.SelectSingleNode("/Message/EndWeek").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        doorOpenTimeout = doc.SelectSingleNode("/Message/DoorOpenTimeout").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        doorSensorType = doc.SelectSingleNode("/Message/DoorSensorType").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        duressAlarm = doc.SelectSingleNode("/Message/DuressAlarm").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        linkageAlarm = doc.SelectSingleNode("/Message/LinkageAlarm").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        tamperAlarm = doc.SelectSingleNode("/Message/TamperAlarm").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        blackListAlarm = doc.SelectSingleNode("/Message/BlackListAlarm").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        wgOutputFormat = doc.SelectSingleNode("/Message/WGOutputFormat").InnerText;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        wgOutputContent = doc.SelectSingleNode("/Message/WGOutputContent").InnerText;
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
