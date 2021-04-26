using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerpeyHypeClient
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            #region Check_Everythings_OK
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.102:1235/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("isitUP").Result;
            if (response.IsSuccessStatusCode)
            {
                if ("YES!" == response.Content.ReadAsStringAsync().Result)
                {
                    this.Hide();
                    var a1 = new Form_Login();
                    a1.Show();
                    
                }
            }
            else
            {
                Debug.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();
            #endregion Check_Everythings_OK
        }
    }
}
