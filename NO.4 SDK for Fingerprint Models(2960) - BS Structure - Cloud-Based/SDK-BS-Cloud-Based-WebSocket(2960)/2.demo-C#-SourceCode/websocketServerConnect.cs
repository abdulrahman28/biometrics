using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

using log4net;
using SuperSocket;
using SuperSocket.SocketBase;
//using SuperWebSocket;
using SuperSocket.WebSocket;
using System.Windows.Forms;

using System.Xml;
using System.IO;
using SuperSocket.SocketBase.Config;
using System.Net;

namespace WebsocketWinformDemo_Standard
{
    public class websocketServerConnect
    {


        //4900 faceData:40000 byte
        //4900 fingerData:996 byte * 10
        int _maxRequestLength = 40000 + 996 * 10 + 2048;
        int _sendBufferSize = 40000 + 996 * 10 + 2048;
        int _receiveBufferSize = 40000 + 996 * 10 + 2048;


        CertificateConfig _certificate = new CertificateConfig
        {
            FilePath = Application.StartupPath + @"\0WXCertificate\wx.pfx",
            Password = "wx"
        };


        #region websocketServerConnect Attributes[属性]
        private bool _bool_SSL;
        /// <summary>
        /// 服务器加密状态
        /// server SSL use Status
        /// </summary>
        public bool Bool_SSL
        {
            get { return _bool_SSL; }
            set { _bool_SSL = value; }
        }


        private Int32 aaccid;
        /// <summary>
        /// websocket服务器,命令流水号，自加一
        /// websocket server ,Command stream number
        /// </summary>
        public Int32 AACCid
        {
            get { return aaccid; }
            set { aaccid = value; }
        }


        private bool _bool_status;
        /// <summary>
        /// websocket服务器启动状态
        /// websocket server start status
        /// </summary>
        public bool Bool_Status
        {
            get { return _bool_status; }
            set { _bool_status = value; }
        }

        private string _string_console;
        /// <summary>
        /// 控制台显示文本
        /// console text
        /// </summary>
        public string String_Console 
        {
            get { return _string_console; }
            set { _string_console = value; }
        }

        private string _string_receiveXML;
        /// <summary>
        /// 控制台显示接收文本
        /// Receive text
        /// </summary>
        public string String_ReceiveXML
        {
            get { return _string_receiveXML; }
            set { _string_receiveXML = value; }
        }

        private string _string_sendXML;
        /// <summary>
        /// 控制台显示文本
        /// Send text
        /// </summary>
        public string String_SendXML
        {
            get { return _string_sendXML; }
            set { _string_sendXML = value; }
        }
        
        #endregion


        #region websocketServerConnect Function[方法]

        #region supersoket config 说明
        /****************************************************************
        /**************************************************************
        /* name: 服务器实例的名称;
        /* serverType: 服务器实例的类型的完整名称;
        /* serverTypeName: 所选用的服务器类型在 serverTypes 节点的名字，配置节点 serverTypes 用于定义所有可用的服务器类型，我们将在后面再做详细介绍;
        /* ip: 服务器监听的ip地址。你可以设置具体的地址，也可以设置为下面的值 Any - 所有的IPv4地址 IPv6Any - 所有的IPv6地址
        /* port: 服务器监听的端口;
        /* listenBacklog: 监听队列的大小;
        /* mode: Socket服务器运行的模式, Tcp (默认) 或者 Udp;
        /* disabled: 服务器实例是否禁用了;
        /* startupOrder: 服务器实例启动顺序, bootstrap 将按照此值的顺序来启动多个服务器实例;
        /* sendTimeOut: 发送数据超时时间;
        /* sendingQueueSize: 发送队列最大长度, 默认值为5;
        /* maxConnectionNumber: 可允许连接的最大连接数;
        /* receiveBufferSize: 接收缓冲区大小;
        /* sendBufferSize: 发送缓冲区大小;
        /* syncSend: 是否启用同步发送模式, 默认值: false;
        /* logCommand: 是否记录命令执行的记录;
        /* logBasicSessionActivity: 是否记录session的基本活动，如连接和断开;
        /* clearIdleSession: true 或 false, 是否定时清空空闲会话，默认值是 false;
        /* clearIdleSessionInterval: 清空空闲会话的时间间隔, 默认值是120, 单位为秒;
        /* idleSessionTimeOut: 会话空闲超时时间; 当此会话空闲时间超过此值，同时clearIdleSession被配置成true时，此会话将会被关闭; 默认值为300，单位为秒;
        /* security: Empty, Tls, Ssl3. Socket服务器所采用的传输层加密协议，默认值为空;
        /* maxRequestLength: 最大允许的请求长度，默认值为1024;
        /* textEncoding: 文本的默认编码，默认值是 ASCII;
        /* defaultCulture: 此服务器实例的默认 thread culture, 只在.Net 4.5中可用而且在隔离级别为 'None' 时无效;
        /* disableSessionSnapshot: 是否禁用会话快照, 默认值为 false.
        /* sessionSnapshotInterval: 会话快照时间间隔, 默认值是 5, 单位为秒;
        /* keepAliveTime: 网络连接正常情况下的keep alive数据的发送间隔, 默认值为 600, 单位为秒;
        /* keepAliveInterval: Keep alive失败之后, keep alive探测包的发送间隔，默认值为 60, 单位为秒;
        */
        #endregion


        


        /// <summary>
        /// 启动websocket服务器
        /// </summary>
        /// <param name="_ws_server"></param>
        /// <param name="_string_port"></param>
        /// <returns name="_string_operationMsg"></returns>
        public string WebSocketServer_Start(WebSocketServer _ws_server, string _string_port)
        {
            string _string_operationMsg = "";
            _bool_status = false;
            if (_string_port.Length == 0)
            {
                _string_operationMsg = "please input Port!";
                return _string_operationMsg;
            }
            else
            {
                Int32 _int_port = Convert.ToInt32(_string_port);

                ServerConfig serverConfig = null;
                if (_bool_SSL) 
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    serverConfig = new ServerConfig
                    {
                        Security = "Tls",//Ssl3
                        Certificate = _certificate,
                        Port = _int_port,
                        MaxConnectionNumber = 50,
                        SyncSend = true,
                        MaxRequestLength = _maxRequestLength,
                        SendBufferSize = _sendBufferSize,
                        ReceiveBufferSize = _receiveBufferSize
                    };
                }
                else
                {
                    serverConfig = new ServerConfig
                    {
                        Port = _int_port,
                        MaxConnectionNumber = 50,
                        SyncSend = true,
                        MaxRequestLength = _maxRequestLength,
                        SendBufferSize = _sendBufferSize,
                        ReceiveBufferSize = _receiveBufferSize
                    };
                }

                if (!_ws_server.Setup(serverConfig))
                {
                    _string_operationMsg = "Failed to setup!";
                    return _string_operationMsg;
                }

                if (!_ws_server.Start())
                {
                    _string_operationMsg = "Failed to start!";
                    return _string_operationMsg;
                }
                _bool_status = true;
                _string_operationMsg = "The server started successfully";
                
                //每次成功都初始化流水号值，
                aaccid = 0;

                return _string_operationMsg;
            }
        }

        /// <summary>
        /// 停止websocket服务器
        /// </summary>
        /// <param name="_ws_server"></param>
        /// <returns name="_string_operationMsg"></returns>
        public string WebSocketServer_Stop(WebSocketServer _ws_server)
        {
            string _string_operationMsg = null;
            _ws_server.Stop();
            _string_operationMsg = "The server was stopped!!";
            return _string_operationMsg;

        }


        /// <summary>
        /// 新websocket设备连接
        /// </summary>
        /// <param name="_ws_session"></param>
        public void ws_NewSession_Connected(WebSocketSession _ws_session)
        {
            
        }

        

        /// <summary>
        /// websocket服务器监听接收的数据，session设备发过来的message
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="_stringXML_receiveMessage"></param>
        public void ws_NewMessage_Receive(WebSocketSession _ws_session, string _stringXML_receiveMessage)
        {
            _string_receiveXML = _stringXML_receiveMessage;
            
            //判断读取session对应的序列号
            {
                _string_console = "";
                _string_console += "\r\n" + ">>>>>=========================>>>>>>>>>>>>" + "\r\n";
                _string_console += DateTime.Now + "      Device -->> Server" + "\r\n";
                _string_console += _ws_session.SessionID + ":" + "\r\n";
                //_console_string += deviceSerialNo + ":" + "\r\n";
                _string_console += "............................................." + "\r\n";
                _string_console += _stringXML_receiveMessage + "\r\n" + "\r\n";

            }
        }


        /// <summary>
        /// session设备向websocket服务器发送massage信息
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="_stringXML_sendMessage"></param>
        public void ws_NewMessage_Send(WebSocketSession _ws_session, string _stringXML_sendMessage)
        {
            _string_sendXML = _stringXML_sendMessage;
            ++aaccid;
            //string SendMessage = null;
            if (_stringXML_sendMessage != null)
            {
                _ws_session.Send(_stringXML_sendMessage);//发回给服务器，并且返回数据回显在控制台

                //在控制台显示发送给服务器的内容
                _string_console += "\r\n" + "<<<<<<<<<<<<<<<=======================<<<<" + "\r\n";
                _string_console += DateTime.Now + "      Device <<-- Server" + "\r\n";
                _string_console += _ws_session.SessionID + ":" + "\r\n";
                //_console_string += deviceSerialNo + ":" + "\r\n";
                _string_console += "............................................." + "\r\n";
                _string_console += _stringXML_sendMessage + "\r\n" + "\r\n";
            }


        }

        /// <summary>
        /// 关闭指定session的websocket设备
        /// </summary>
        /// <param name="_ws_session"></param>
        /// <param name="_ws_closeServer"></param>
        public void ws_SessionClosed(WebSocketSession _ws_session, SuperSocket.SocketBase.CloseReason _ws_closeServer)
        {

        }


        /// <summary>
        /// 广播给所有设备
        /// </summary>
        /// <param name="_ws_server"></param>
        /// <param name="_stringXML_sendMessage"></param>
        public void ws_NewMessage_SendToAll(WebSocketServer _ws_server, string _stringXML_sendMessage)
        {
            foreach (WebSocketSession _ws_session in _ws_server.GetAllSessions())
            {
                ws_NewMessage_Send(_ws_session, _stringXML_sendMessage);
            }
        }

        #endregion
    }
}
