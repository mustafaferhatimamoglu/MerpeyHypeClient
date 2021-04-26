using System;
using System.Windows.Forms;

namespace MerpeyHypeClient
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, System.EventArgs e)
        {
            try
            {
                try
                {
                    var v1 = textEdit1.Text.Trim();
                    var v2 = textEdit2.Text.Trim();
                    var v3 = textEdit3.Text.Trim();
                    if (v1 == "") { MessageBox.Show(Label_MainUser.Text + " Boş olamaz"); return; }
                    else if (v2 == "") { MessageBox.Show(label_Username.Text + " Boş olamaz"); return; }
                    else if (v3 == "") { MessageBox.Show(label_Password.Text + " Boş olamaz"); return; }

                    Islems.Instance.LoginV0(v1,v2,v3);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Birşey yanlış gitti, Kapatılıyor...");
                throw;
            }
        }
    }
}