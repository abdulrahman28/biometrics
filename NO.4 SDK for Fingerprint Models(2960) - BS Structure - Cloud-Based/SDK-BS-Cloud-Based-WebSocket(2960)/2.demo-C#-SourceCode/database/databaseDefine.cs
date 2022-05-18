using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketWinformDemo_Standard
{
    class databaseDefine
    {
        /// <summary>
        /// 
        /// </summary>
        private string[] accessAction =
        {
            "Add",
            "Edit",
            "Delete"
        };
        public string[] AccessAction
        {
            get { return accessAction; }
            set { accessAction = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string[] week =
        {
            "Sun",
            "Mon",
            "Tues",
            "Wed",
            "Thur",
            "Fri",
            "Sat"
        };
        public string[] Week
        {
            get { return week; }
            set { week = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string[] doorSensorType =
        {
            "None",
            "NormallyClose",
            "NormallyOpen"
        };
        public string[] DoorSensorType
        {
            get { return doorSensorType; }
            set { doorSensorType = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private string[] lockReleaseTime =
        {
            "AlwayClose",
            "AlwayOpen",
            "Custom"
        };
        public string[] LockReleaseTime
        {
            get { return lockReleaseTime; }
            set { lockReleaseTime = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        private string[] wgOutputContent =
        {
            "UserID",
            "UserIDorCard"
        };
        public string[] WGOutputContent
        {
            get { return wgOutputContent; }
            set { wgOutputContent = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string[] wgOutputFormat =
        {
            "26",
            "34",
            "66"
        };
        public string[] WGOutputFormat
        {
            get { return wgOutputFormat; }
            set { wgOutputFormat = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] alarmStatus =
        {
            "None",
            "DoorNotClosed",
            "IllegalOpen",
            "Duress",
            "Tamper",
            "Linkage",
            "BlackList"
        };
        public string[] AlarmStatus
        {
            get { return alarmStatus; }
            set { alarmStatus = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string[] openClose =
        {
            "Close",
            "Open"
        };
        public string[] OpenClose
        {
            get { return openClose; }
            set { openClose = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private string[] yesNo =
        {
            "Yes",
            "No"
        };
        public string[] YesNo
        {
            get { return yesNo; }
            set { yesNo = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] attendanceRuleStatus =
        {
            "Duty On",
            "Duty Off",
            "Overtime On",
            "Overtime Off",
            "In",
            "Out"
        };
        public string[] AttendanceRuleStatus
        {
            get { return attendanceRuleStatus; }
            set { attendanceRuleStatus = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string[] restoreDevice  =
        {
            "RestoreFactory",
            "ReStart",
            "CancelWarning"
            
        };
        public string[] RestoreDevice 
        {
            get { return restoreDevice; }
            set { restoreDevice = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private string[] identifyMode =
        {
            "AnyWay",
            "Face",
            "FP",
            "Card",
            "PWD",
            "Face+FP",
            "Face+Card",
            "Face+PWD",
            "FP+Card",
            "FP+PWD",
            "Face+FP+Card",
            "Face+FP+PWD",
            "FP+Card+PWD",
            "Face+2ndIDCard"
        };
        public string[] IdentifyMode
        {
            get { return identifyMode; }
            set { identifyMode = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private Int32[] volume =
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        public Int32[] Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] language =
        {
            "English",
            "ChineseSimplified",
            "ChineseTraditional"
        };
        public string[] Language
        {
            get { return language; }
            set { language = value; }
        }
        
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] bellTimeCycle =
        {
            "EveryDay",
            "Sun",
            "Mon",
            "Tues",
            "Wed",
            "Thur",
            "Fri",
            "Sat"
        };
        public string[] BellTimeCycle
        {
            get { return bellTimeCycle; }
            set { bellTimeCycle = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        private string[] setUserType =
        {
            "Set",
            "Delete",
            "Edit"
        };

        public string[] SetUserType
        {
            get { return setUserType; }
            set { setUserType = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] remoteEnroll =
        {
            "RemoteEnrollFace",
            "RemoteEnrollFP",
            "RemoteEnrollCard"
        };

        public string[] RemoteEnroll
        {
            get { return remoteEnroll; }
            set { remoteEnroll = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private string[] privilege =
        {
            "User",
            "Register",
            "Manager",
            "Administrator"
        };
            
        public string[] Privilege 
        {
            get { return privilege; }
            set { privilege = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private Int32[] depart =
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
        };
        public Int32[] Depart
        {
            get { return depart; }
            set { depart = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Int32[] fingerNo =
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };

        public Int32[] FingerNo
        {
            get { return fingerNo; }
            set { fingerNo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Int32[] proxy =
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
        };
        public Int32[] Proxy
        {
            get { return proxy; }
            set { proxy = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Int32[] nameList =
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
        };
        public Int32[] NameList
        {
            get { return nameList; }
            set { nameList = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private string[] gender =
        {
            "男",
            "女"
        };

        public string[] Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string[] cameraType =
        {
            "VR",
            "IR"
        };

        public string[] CameraType
        {
            get { return cameraType; }
            set { cameraType = value; }
        }

    }
}
