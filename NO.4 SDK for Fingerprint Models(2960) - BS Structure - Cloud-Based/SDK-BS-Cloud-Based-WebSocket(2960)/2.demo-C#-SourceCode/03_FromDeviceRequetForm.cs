using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsocketWinformDemo_Standard
{
    public partial class FromDeviceRequetForm : Form
    {
        private string codeType;
        /// <summary>
        /// websocket服务器，
        /// </summary>
        public string CodeType
        {
            get { return codeType; }
            set { codeType = value; }
        }

        private string userCode;
        /// <summary>
        /// websocket服务器，
        /// </summary>
        public string UserCode
        {
            get { return userCode; }
            set { userCode = value; }
        }

        private bool _bool_isOpen;
        /// <summary>
        /// websocket服务器，
        /// </summary>
        public bool _Bool_isOpen
        {
            get { return _bool_isOpen; }
            set { _bool_isOpen = value; }
        }

        public FromDeviceRequetForm()
        {
            InitializeComponent();

        }

        private void FromDeviceRequetForm_Load(object sender, EventArgs e)
        {
            lbl_Code.Text = userCode;
            lbl_Type.Text = codeType;


        }

        


    }
}
