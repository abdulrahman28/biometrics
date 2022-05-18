using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace WebsocketWinformDemo_Standard
{
    class API_03_GetUserSampleInfo
    {
        #region API_03_GetUserAllInfo Attributes[属性]

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

        private string S_userCounts;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string S_UserCounts
        {
            get { return S_userCounts; }
            set { S_userCounts = value; }
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

        private string userCounts;
        /// <summary>
        /// XML字段,
        /// </summary>
        public string UserCounts
        {
            get { return userCounts; }
            set { userCounts = value; }
        }

        private string[,] userSampleInfo = new string[100,8];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[,] UserSampleInfo
        {
            get { return userSampleInfo; }
            set { userSampleInfo = value; }
        }


        private string[] userID = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string[] name = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }

        private string[] userSN = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] UserSN
        {
            get { return userSN; }
            set { userSN = value; }
        }

        private string[] privilege = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }

        private string[] depart = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Depart
        {
            get { return depart; }
            set { depart = value; }
        }


        private string[] card = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Card
        {
            get { return card; }
            set { card = value; }
        }

        private string[] pwd = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] PWD
        {
            get { return pwd; }
            set { pwd = value; }
        }

        private string[] fingers = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Fingers
        {
            get { return fingers; }
            set { fingers = value; }
        }

        private string[] face = new string[20];
        /// <summary>
        /// XML字段,
        /// </summary>
        public string[] Face
        {
            get { return face; }
            set { face = value; }
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

        #region API_03_GetUserSampleInfo XML解析Function[方法]
        /// **********************************
        //<?xml version="1.0"?>
        //<Message>
        //<Request>GetUserSampleInfo</Request>
        //<Ccid>xxxxxxxx</Ccid>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<Action_ext>show/xx</Action_ext>
        //<UserCounts>6</UserCounts>
        //<UserID>1,6,13,18,34,55</UserID>
        //</Message>

        //<?xml version="1.0"?>
        //<Message>
        //<TerminalType>PFS100</TerminalType>
        //<TerminalID>1</TerminalID>
        //<DeviceSerialNo>SN123456</DeviceSerialNo>
        //<Response>GetUserSampleInfo</Response>
        //<Actid>xxxxxxxx</Actid>
        //<Version>4900 v3.3.5</Version>
        //<Action_ext>show/xx</Action_ext>
        //<Time>2013-4-11-T11:28:54Z</Time>
        //<UserSampleInfo UserCounts=”6”> <!--UserCounts 参数为下发用户的个数，有可能小
        //于请求参数的个数 -->
        //<Info UserID=”1” Name=”ssF5” UserSN=”45SS” Privilege=”User” Depart=”0” Card=”0” PWD=”123456”
        //Fingers=”0” Face=”0” />
        //<Info UserID=”6” Name=”1D=5” UserSN=”QDY8” Privilege=”User” Depart=”0” Card=”0” PWD=”123456”
        //Fingers=”0” Face=”0” />
        //<Info UserID=”13” Name=”S-66” UserSN=”RG46” Privilege=”User” Depart=”0” Card=”0” PWD=”123456”
        //Fingers=”0” Face=”0” />
        //</UserSampleInfo>
        //<Result>OK/Fail</Result>
        //</Message>
        ///***************************************



        /// <summary>
        /// 发送API_03_GetUserSampleInfo指令.
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

            string[] UserIDarray = S_userID.Split(',');
            string strUserCounts = Convert.ToString(UserIDarray.Length);
            
            //<------解析工号文本框内的工号.
            //string[] uID = null;
            //Int32 y =0;
            //for (Int32 i = 0; i < UserIDarray.Length; i++)
            //{
            //    if(UserIDarray[i].Contains("-"))
            //    {
            //        string[] UserID_ = UserIDarray[i].Split('-');
            //        Int32 startID = Convert.ToInt32(UserID_[0]);
            //        Int32 endID = Convert.ToInt32(UserID_[1]);

            //        for (Int32 ii = 0; ii <= endID - startID; ii++)
            //        {
            //            uID[y] = UserID_[0] + ii;
            //            y++;
            //        }
            //    }
            //    else
            //    {
            //        uID[y] = UserIDarray[i];
            //        y++;
            //    }
            //}
            //------------------>
                requestXMLMassage = "<?xml version=\"1.0\"?>\r\n" +
                              "<Message>\r\n" +
                              "<Request>GetUserSampleInfo</Request>\r\n" +
                              "<Ccid>" + strCcid + "</Ccid>\r\n" +
                              "<Time>" + time + "</Time>\r\n" +
                              "<Action_ext>" + S_action_ext + "</Action_ext>\r\n" +
                              "<UserCounts>" + strUserCounts + "</UserCounts>\r\n" +
                              "<UserID>" + S_userID + "</UserID>\r\n" +
                              "</Message>";

            return requestXMLMassage;

        }
        

        /// <summary>
        /// 解析返回的GetUserSampleInfo的数据，解析成功返回true
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

                if (response == "GetUserSampleInfo")
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
                        var Counts = doc.GetElementsByTagName("UserSampleInfo")[0].Attributes;
                        userCounts = Counts.GetNamedItem("UserCounts").Value;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        //<----------
                        Int32 userCountsInt = Convert.ToInt32(userCounts);
                        for (int i = 0; i < userCountsInt; i++)
                        {
                            var UserInfo = doc.GetElementsByTagName("Info")[i].Attributes;

                            userSampleInfo[i,0] = UserInfo.GetNamedItem("UserID").Value;
                            userSampleInfo[i,1] = UserInfo.GetNamedItem("Name").Value;
                            userSampleInfo[i,2] = UserInfo.GetNamedItem("Privilege").Value;
                            userSampleInfo[i,3] = UserInfo.GetNamedItem("Depart").Value;
                            userSampleInfo[i,4] = UserInfo.GetNamedItem("Card").Value;
                            userSampleInfo[i,5] = UserInfo.GetNamedItem("PWD").Value;
                            userSampleInfo[i,6] = UserInfo.GetNamedItem("Fingers").Value;
                            userSampleInfo[i,7] = UserInfo.GetNamedItem("Face").Value;
                        }
                        //---------->
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
