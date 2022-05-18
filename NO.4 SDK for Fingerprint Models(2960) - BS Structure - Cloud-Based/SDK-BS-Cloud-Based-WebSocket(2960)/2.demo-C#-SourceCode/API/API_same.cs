using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace WebsocketWinformDemo_Standard
{
    class API_same
    {

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


        public void API_same_Response(XmlDocument doc)
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

        }
    }
}
