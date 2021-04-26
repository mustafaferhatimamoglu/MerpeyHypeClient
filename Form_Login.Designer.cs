
namespace MerpeyHypeClient
{
    partial class Form_Login
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
            this.label_Password = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label_Username = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.Label_MainUser = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.button_Login = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Password
            // 
            this.label_Password.Location = new System.Drawing.Point(40, 81);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(22, 13);
            this.label_Password.TabIndex = 18;
            this.label_Password.Text = "Şifre";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(121, 78);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.PasswordChar = 'X';
            this.textEdit3.Size = new System.Drawing.Size(141, 20);
            this.textEdit3.TabIndex = 14;
            // 
            // label_Username
            // 
            this.label_Username.Location = new System.Drawing.Point(40, 55);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(53, 13);
            this.label_Username.TabIndex = 17;
            this.label_Username.Text = "Alt Kullanıcı";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(121, 52);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(141, 20);
            this.textEdit2.TabIndex = 13;
            // 
            // Label_MainUser
            // 
            this.Label_MainUser.Location = new System.Drawing.Point(40, 29);
            this.Label_MainUser.Name = "Label_MainUser";
            this.Label_MainUser.Size = new System.Drawing.Size(59, 13);
            this.Label_MainUser.TabIndex = 16;
            this.Label_MainUser.Text = "Ana Kullanıcı";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(121, 26);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(141, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(40, 104);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(222, 30);
            this.button_Login.TabIndex = 15;
            this.button_Login.Text = "Giriş";
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 154);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.Label_MainUser);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.button_Login);
            this.Name = "Form_Login";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_Password;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl label_Username;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl Label_MainUser;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton button_Login;
    }
}