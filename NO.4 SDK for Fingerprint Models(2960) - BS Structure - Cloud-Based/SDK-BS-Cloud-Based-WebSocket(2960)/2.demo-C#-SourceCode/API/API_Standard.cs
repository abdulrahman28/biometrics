using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketWinformDemo_Standard
{
    class API_Standard
    {
        websocketServerConnect ws_connect = new websocketServerConnect();
        #region API 注册和登录
        //<-----API 注册和登录
        public API_01_register register = new API_01_register();
        public API_01_login login = new API_01_login();
        public API_03_CheckUserByDevice checkUserByDevice = new API_03_CheckUserByDevice();
        //------>
        #endregion

        #region API 实时记录推送
        //<-----API 实时记录推送
        public API_02_TimeLog timelog = new API_02_TimeLog();
        public API_02_AdminLog adminlog = new API_02_AdminLog();
        //------>
        #endregion

        #region API 用户管理页面
        //<-----API 用户管理
        public API_03_GetAllUserID getAllUserID = new API_03_GetAllUserID();
        public API_03_GetUserAllInfo getUserAllInfo = new API_03_GetUserAllInfo();
        public API_03_GetUserSampleInfo getUserSampleInfo = new API_03_GetUserSampleInfo();
        public API_03_GetUserData getUserData = new API_03_GetUserData();
        public API_03_SetUserData setUserData = new API_03_SetUserData();
        public API_03_GetUserPassword getUserPassword = new API_03_GetUserPassword();
        public API_03_GetUserCardNo getUserCardNo = new API_03_GetUserCardNo();
        public API_03_GetUserPhoto getUserPhoto = new API_03_GetUserPhoto();
        public API_03_SetUserPhoto setUserPhoto = new API_03_SetUserPhoto();
        public API_03_GetFingerData getFingerData = new API_03_GetFingerData();
        public API_03_SetFingerData setFingerData = new API_03_SetFingerData();
        public API_03_GetFaceData getFaceData = new API_03_GetFaceData();
        public API_03_SetFaceData setFaceData = new API_03_SetFaceData();
        public API_03_GetUserQRCode getUserQRCode = new API_03_GetUserQRCode();
        public API_03_RemoteEnroll remoteEnroll = new API_03_RemoteEnroll();
        public API_03_ExitRemoteEnroll exitRemoteEnroll = new API_03_ExitRemoteEnroll();
        public API_03_TakeOffManager takeOffManager = new API_03_TakeOffManager();
        public API_03_SetFaceDataByPicture setFaceDataByPicture = new API_03_SetFaceDataByPicture();
        public API_03_SetFingerDataByPicture setFingerDataByPicture = new API_03_SetFingerDataByPicture();

        public API_03_GetIdantifyCard getIdantifyCard = new API_03_GetIdantifyCard();
        public API_03_SetIdantifyCard setIdantifyCard = new API_03_SetIdantifyCard();
        //------>
        #endregion

        #region API 基本设置页面
        //<-----API 基本设置
        public API_03_EnableDevice enableDevice = new API_03_EnableDevice();
        public API_03_GetTime getTime = new API_03_GetTime();
        public API_03_SetTime setTime = new API_03_SetTime();
        public API_03_GetDepartment getDepartment = new API_03_GetDepartment();
        public API_03_SetDepartment setDepartment = new API_03_SetDepartment();

        public API_03_GetNameList getNameList = new API_03_GetNameList();//20181114,lwb,add
        public API_03_SetNameList setNameList = new API_03_SetNameList();//20181114,lwb,add

        public API_03_GetProxyName getProxyName = new API_03_GetProxyName();
        public API_03_SetProxyName setProxyName = new API_03_SetProxyName();
        public API_03_GetBellTime getBellTime = new API_03_GetBellTime();
        public API_03_SetBellTime setBellTime = new API_03_SetBellTime();

        //------>
        #endregion

        #region API 高级设置页面
        //<-----API 高级设置
        public API_03_TakePhoto takePhoto = new API_03_TakePhoto();
        public API_03_GetDeviceSetting getDeviceSetting = new API_03_GetDeviceSetting();
        public API_03_SetDeviceSetting setDeviceSetting = new API_03_SetDeviceSetting();
        public API_03_RestoreDevice restoreDevice = new API_03_RestoreDevice();
        public API_03_GetPowerSetting getPowerSetting = new API_03_GetPowerSetting();
        public API_03_SetPowerSetting setPowerSetting = new API_03_SetPowerSetting();
        public API_03_FirmwareUpgradeByCloud firmwareUpgradeByCloud = new API_03_FirmwareUpgradeByCloud();
        //------>
        #endregion

        #region API 网络管理页面
        //<-----API 网络管理页面
        public API_03_GetEthernetSetting getEthernetSetting = new API_03_GetEthernetSetting();
        public API_03_SetEthernetSetting setEthernetSetting = new API_03_SetEthernetSetting();
        public API_03_GetWifiSetting getWifiSetting = new API_03_GetWifiSetting();
        public API_03_SetWifiSetting setWifiSetting = new API_03_SetWifiSetting();
        public API_03_GetMobileNetSetting getMobileNetSetting = new API_03_GetMobileNetSetting();
        public API_03_SetMobileNetSetting setMobileNetSetting = new API_03_SetMobileNetSetting();
        public API_03_GetVPNServer getVPNServer = new API_03_GetVPNServer();
        public API_03_SetVPNServer setVPNServer = new API_03_SetVPNServer();
        public API_03_GetGPS getGPS = new API_03_GetGPS();
        public API_03_SetGPS setGPS = new API_03_SetGPS();
        public API_03_GetCloudServer getCloudServer = new API_03_GetCloudServer();
        public API_03_SetCloudServer setCloudServer = new API_03_SetCloudServer();
        public API_03_GetStreamingServer getStreamingServer = new API_03_GetStreamingServer();
        public API_03_SetStreamingServer setStreamingServer = new API_03_SetStreamingServer();
        public API_03_GetLocalServer getLocalServer = new API_03_GetLocalServer();
        public API_03_SetLocalServer setLocalServer = new API_03_SetLocalServer();
        //------> 
        #endregion

        #region API 数据管理页面
        //<-----API 数据管理页面
        public API_03_EmptyTimeLog emptyTimeLog = new API_03_EmptyTimeLog();
        public API_03_EmptyManageLog emptyManageLog = new API_03_EmptyManageLog();
        public API_03_EmptyUserEnrollmentData emptyUserEnrollmentData = new API_03_EmptyUserEnrollmentData();
        public API_03_EmptyAllData emptyAllData = new API_03_EmptyAllData();
        public API_03_GetLogSetting getLogSetting = new API_03_GetLogSetting();
        public API_03_SetLogSetting setLogSetting = new API_03_SetLogSetting();
        public API_03_GetFirstGlog getFirstGlog = new API_03_GetFirstGlog();
        public API_03_GetNextGlog getNextGlog = new API_03_GetNextGlog();
        public API_03_GetAttendanceLog getAttendanceLog = new API_03_GetAttendanceLog();
        //------> 
        #endregion

        #region API 考勤管理页面
        //<-----API 考勤管理页面
        public API_03_GetAttendanceRule getAttendanceRule = new API_03_GetAttendanceRule();
        public API_03_SetAttendanceRule setAttendanceRule = new API_03_SetAttendanceRule();
        //------> 
        #endregion

        #region API 门禁管理页面
        //<-----API 门禁管理页面
        public API_03_AccessStatus accessStatus = new API_03_AccessStatus();
        public API_03_GetAccessSetting getAccessSetting = new API_03_GetAccessSetting();
        public API_03_SetAccessSetting setAccessSetting = new API_03_SetAccessSetting();
        public API_03_GetAccessList getAccessList = new API_03_GetAccessList();
        public API_03_SetAccessList setAccessList = new API_03_SetAccessList();

        public API_03_RemoteOpen remoteOpen = new API_03_RemoteOpen();
        //------> 
        #endregion

        #region API 本机信息页面
        //<-----API 本机信息页面
        public API_03_GetStoreStatus getStoreStatus = new API_03_GetStoreStatus();
        public API_03_GetDeviceInfo getDeviceInfo = new API_03_GetDeviceInfo();
        //------> 
        #endregion
    }
}
