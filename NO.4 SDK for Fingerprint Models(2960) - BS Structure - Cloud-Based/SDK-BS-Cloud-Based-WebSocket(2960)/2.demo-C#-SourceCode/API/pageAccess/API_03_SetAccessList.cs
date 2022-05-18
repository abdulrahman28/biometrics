using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace WebsocketWinformDemo_Standard
{
    class API_03_SetAccessList
    {

        #region API_03_SetAccessList Attributes[属性]

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

        private string S_action;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_Action
        {
            get { return S_action; }
            set { S_action = value; }
        }

        private string S_accessListID;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_AccessListID
        {
            get { return S_accessListID; }
            set { S_accessListID = value; }
        }

        private string S_count;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_Count
        {
            get { return S_count; }
            set { S_count = value; }
        }

        private string[,] S_list = new string[50, 9];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[,] S_List
        {
            get { return S_list; }
            set { S_list = value; }
        }

        private Int32[] S_list_id = new Int32[50];
        /// <summary>
        /// XML字段,
        /// </summary>
        public Int32[] S_List_id
        {
            get { return S_list_id; }
            set { S_list_id = value; }
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

        #region API_03_SetAccessList XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>SetAccessList</Request>
        //<Ccid>2</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show/xx<Action_ext>
        //<Action>Add/Edit/Delete<Action>
        //<AccessListID>1<AccessListID>
        //<AccessList Count="2">
            //<List ID="1">
                //<Use>Yes</Use>
                //<AllDateTime>No</AllDateTime>
                //<StartDateTime>2000-01-01-T00:00M</StartDateTime>
                //<EndDateTime>2020-12-31-T23:59M</EndDateTime>
                //<AllWeek>Yes</AllWeek>
                //<StartWeek>Sun</StartWeek>
                //<EndWeek>Sun</EndWeek>
                //<Department>1</Department>
                //<Access>Yes</Access>
            //</List>
            //<List ID="2">
                //<Use>Yes</Use>
                //<AllDateTime>No</AllDateTime>
                //<StartDateTime>2000-01-01-T00:00M</StartDateTime>
                //<EndDateTime>2020-12-31-T23:59M</EndDateTime>
                //<AllWeek>Yes</AllWeek>
                //<StartWeek>Sun</StartWeek>
                //<EndWeek>Sun</EndWeek>
                //<Department>2</Department>
                //<Access>Yes</Access>
            //</List>
        //</AccessList>
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
        //<Response>SetAccessList</Response>
        //<Result>OK</Result>
        //</Message>
        ///***************************************


        /// <summary>
        /// 发送SetAccessList指令.
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

            Int32 i_count = Convert.ToInt32(S_count);
            string s_list = "";
            for (int i = 0; i < i_count; i++)
            {
                S_list_id[i] = i + 1;
                s_list += "<List ID=\"" + S_list_id[i] + "\">\r\n" +
                              "<Use>" + S_list[i,0] + "</Use>\r\n" +
                              "<Department>" + S_list[i,1] + "</Department>\r\n" +
                              "<Access>" + S_list[i,2] + "</Access>\r\n" +
                              "<AllWeek>" + S_list[i,3] + "</AllWeek>\r\n" +
                              "<StartWeek>" + S_list[i,4] + "</StartWeek>\r\n" +
                              "<EndWeek>" + S_list[i,5] + "</EndWeek>\r\n" +
                              "<AllDateTime>" + S_list[i,6] + "</AllDateTime>\r\n" +
                              "<StartDateTime>" + S_list[i,7] + "</StartDateTime>\r\n" +
                              "<EndDateTime>" + S_list[i,8] + "</EndDateTime>\r\n" +
                          "</List>\r\n";
            }

            requestXMLMassage = "<?xml version=\"1.0\"?>\r\n" +
                          "<Message>\r\n" +
                          "<Request>SetAccessList</Request>\r\n" +
                          "<Ccid>" + strCcid + "</Ccid>\r\n" +
                          "<Time>" + time + "</Time>\r\n" +
                          "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                          "<Action>" + S_action + "</Action>\r\n" +
                          "<AccessListID>" + S_accessListID + "</AccessListID>\r\n" +
                          "<AccessList Count=\"" + S_count + "\">" +
                          s_list +
                          "</AccessList>"+
                          "</Message>";

            return requestXMLMassage;

        }


        /// <summary>
        /// 解析返回的SetAccessList的数据，解析成功返回true
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

                if (response == "SetAccessList")
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
