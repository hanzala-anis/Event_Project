using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.CoreClasses;

namespace Event_Project.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPasswordPage : ContentPage
	{
        string abc;
		public LoginPasswordPage (string Email)
		{
            abc = Email;
			InitializeComponent ();
		}

        private async void btnPassword_LoginPasswordPage_Clicked(object sender, EventArgs e)
        {
            string password = entPassword_LoginPasswordPage.Text;
            TestApp(abc, password);
            await Navigation.PushAsync(new Login.LoginChooseEventPage());
        }


        private async void FogetPasswordClick_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassword.ForgetPasswordEmailPage());
        }



        async void DoPostRequest()
        {
            /*HttpClient _client;
            _client = new HttpClient();

            var objPost = new J_Class
            {

                device_id = serialnum.ToString(),//serialnum.ToString(),
                lat = currentLocation != null ? currentLocation.Latitude : 0,
                longi = currentLocation != null ? currentLocation.Longitude : 0,

            };
            var jsonPost = JsonConvert.SerializeObject(objPost, Formatting.Indented);
            string URL = "http://rider.saltechsolution.com";
            //Uri urll = new Uri("http://rider.saltechsolution.com/api/postdata");
            _client.BaseAddress = new Uri(URL);

            /*Dictionary<string, string> data_post = new Dictionary<string, string>();
            data_post.Add("device_id", objPost.device_id);
            data_post.Add("lat", objPost.lat.ToString());
            data_post.Add("longi", objPost.longi.ToString());
            string s = string.Join(";", data_post.Select(x => x.Key + "=" + x.Value).ToArray());*/
            /*StringContent posted_data = new StringContent(jsonPost);
            var response = await _client.PostAsync("/api/postdata/", posted_data);
            string respo_string = await response.Content.ReadAsStringAsync();*/


            //using (WebClient client = new WebClient())
            //{
            //    var objPost = new Json_Class
            //    {

            //        device_id = serialnum.ToString(),//serialnum.ToString(),
            //        lat = currentLocation != null ? currentLocation.Latitude : 0,
            //        longi = currentLocation != null ? currentLocation.Longitude : 0,

            //    };
            //    string stuff;
            //    var postdataJson = JsonConvert.SerializeObject(objPost, Formatting.Indented);
            //    var values = new Dictionary<string, string>();
            //    values.Add("json", postdataJson);
            //    var content = new FormUrlEncodedContent(values);
            //    string url = "http://rider.saltechsolution.com/api/postdata";
            //    var responseObj = await client.PostAsync(url, content);
            //    var responseString = await responseObj.Content.ReadAsStringAsync();
            //    if (responseObj.IsSuccessStatusCode)
            //    {
            //        stuff = (string)JsonConvert.DeserializeObject(responseString);
            //    }
            //    else
            //    {
            //        stuff = "error";
            //    }
            //    //return responseStri

        }




            private void TestApp(string email, string password)
            {
                try
                {
                    //GET REQUEST
                    /*WebRequestMaker WebReq = new WebRequestMaker();
                    WebReq.Url = "http://192.168.1.7/WCFService/Service1.svc/GetData/sessionvalue123123/valueASD/";
                    WebReq.RequestDataType = SupportedDataTypes.String;
                    WebReq.ResponseDataType = SupportedDataTypes.String;
                    WebReq.WebMethod = SupportedWebMethods.GET;
                    WebReq.OnResponseRecived += WebReq_OnResponseRecived;
                    WebReq.MakeARequest();*/

                    //POST REQUEST
                    
                    WebRequestMaker WebReq = new WebRequestMaker();
                    WebReq.Url = "http://192.168.0.116/api/Auth/Login?email="+email+"&password="+password;
                    WebReq.DataToSent = "{\"Status\" : \"BadRequest\",\"Message\" : \"Message Sent\"}";
                    WebReq.RequestDataType = SupportedDataTypes.String;
                    WebReq.ResponseDataType = SupportedDataTypes.String;
                    WebReq.WebMethod = SupportedWebMethods.POST;
                    WebReq.OnResponseRecived += WebReq_OnResponseRecived;
                    WebReq.MakeARequest();
                }
                catch (Exception ex)
                {
                    CommonFunctions.ReportError(ex);
                }
            }

            private void WebReq_OnResponseRecived(object ResponseData)
            {
                try
                {
                    string resp = ResponseData.ToString();
                    CommonFunctions.WriteCustomLog(resp);
                }
                catch (Exception ex)
                {
                    CommonFunctions.ReportError(ex);
                }
            }





        




    }
}