using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.CoreClasses;

namespace Event_Project.Attendees
{
	[XamlCompilation(XamlCompilationOptions.Compile)]


    // convert json to C# API Class 
    public class Post
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }


   

    public partial class AttendeesScreen : ContentPage
	{
        // URL call
        private const string Url = "http://jsonplaceholder.typicode.com/photos";
        //private WebClient _client;
        private ObservableCollection<Post> _posts;

        WebRequestMaker _webClient;


        

        public AttendeesScreen ()
		{
			InitializeComponent ();
            attendeesData();
            _webClient = new WebRequestMaker();



           
		}

        public async void attendeesData()
        {
            try
            {

                //const string Url = "http://jsonplaceholder.typicode.com/photos";
                //HttpClient _client;
                //ObservableCollection<Post> _post;

                //_client = new HttpClient();
                //var content = await _client.GetStringAsync(Url);

                //var posts = JsonConvert.DeserializeObject<List<Post>>(content);

                //_post = new ObservableCollection<Post>(posts);
                //attendeesList.ItemsSource = _post;

                //_client = new WebClient();
                //var content = _client.DownloadString(Url);
                //var posts = JsonConvert.DeserializeObject<List<Post>>(content);

                //_posts = new ObservableCollection<Post>(posts);
                //attendeesList.ItemsSource = _posts;

                _webClient = new WebRequestMaker();
                _webClient.Url = Url;
                _webClient.ResponseDataType = SupportedDataTypes.String;
                _webClient.WebMethod = SupportedWebMethods.GET;
                _webClient.MakeARequest();
                _webClient.OnResponseRecived += _webClient_OnResponseRecived;
            }

            catch (Exception ex)
            {
                throw ex;
            }




        }

        private void _webClient_OnResponseRecived(object ResponseData)
        {
            var posts = JsonConvert.DeserializeObject<List<Post>>(ResponseData.ToString());
            _posts = new ObservableCollection<Post>(posts);
            attendeesList.ItemsSource = _posts;
            attendeesList.IsPullToRefreshEnabled = true;
        }




        // navigate on Detail Page
        private void sortingByCountry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AttendeesDetails());

        }



    }
}
