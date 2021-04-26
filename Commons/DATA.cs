using DevExpress.XtraPrinting.Native.WebClientUIControl;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

public class Islems
{
    string url = "http://192.168.1.102:1235/";

    public Islems()
	{
	}
    public static Islems DB_Works;
    public static Islems Instance
    {
        get
        {
            if (DB_Works == null)
                DB_Works = new Islems();
            return DB_Works;
        }
    }
    public string LoginV0(string MainUser,string Username,string Password)
    {
        string response = "NULL";
        try
        {
            url += "api/v0/Login";
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("MainUser", MainUser);
                httpClient.DefaultRequestHeaders.Add("UserName", Username);
                httpClient.DefaultRequestHeaders.Add("Password", Password);
                var response2 = httpClient.GetStringAsync(new Uri(url)).Result;

                var json = response;
                //var json2 = JsonConverter.DeserializeObject<LoginParams>(response);
            }
            
        }
        catch (Exception ex )
        {

            //throw;
        }
        return response;

        //HttpClient client = new HttpClient();
        //client.BaseAddress = new Uri("http://192.168.1.102:1235/");
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //HttpResponseMessage response = client.GetAsync("isitUP").Result;
        //if (response.IsSuccessStatusCode)
        //{
        //    if ("YES!" == response.Content.ReadAsStringAsync().Result)
        //    {
        //        //this.Hide();
        //        //var a1 = new Form_Login();
        //        //a1.Show();

        //    }
        //}
        //else
        //{
        //    //Debug.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
        //}
        //client.Dispose();
        //return "asd123";

    }
}
