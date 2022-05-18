namespace WebsocketWinformDemo_Standard
{
    partial class FromDeviceRequetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_UserCode = new System.Windows.Forms.Label();
            this.lbl_CodeType = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UserCode
            // 
            this.lbl_UserCode.AutoSize = true;
            this.lbl_UserCode.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserCode.Location = new System.Drawing.Point(29, 46);
            this.lbl_UserCode.Name = "lbl_UserCode";
            this.lbl_UserCode.Size = new System.Drawing.Size(65, 21);
            this.lbl_UserCode.TabIndex = 1;
            this.lbl_UserCode.Text = "Code:";
            // 
            // lbl_CodeType
            // 
            this.lbl_CodeType.AutoSize = true;
            this.lbl_CodeType.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CodeType.Location = new System.Drawing.Point(31, 78);
            this.lbl_CodeType.Name = "lbl_CodeType";
            this.lbl_CodeType.Size = new System.Drawing.Size(65, 21);
            this.lbl_CodeType.TabIndex = 2;
            this.lbl_CodeType.Text = "Type:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Type.Location = new System.Drawing.Point(102, 78);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(0, 21);
            this.lbl_Type.TabIndex = 4;
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Code.Location = new System.Drawing.Point(100, 46);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(0, 21);
            this.lbl_Code.TabIndex = 3;
            // 
            // FromDeviceRequetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 140);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.lbl_CodeType);
            this.Controls.Add(this.lbl_UserCode);
            this.Name = "FromDeviceRequetForm";
            this.Text = "_03_realtimePhotoForm";
            this.Load += new System.EventHandler(this.FromDeviceRequetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserCode;
        private System.Windows.Forms.Label lbl_CodeType;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Code;

    }
}