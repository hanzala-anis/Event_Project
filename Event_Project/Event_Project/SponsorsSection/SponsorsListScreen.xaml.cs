﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.CoreClasses;

namespace Event_Project.SponsorsSection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public class Post
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
    public partial class SponsorsListScreen : ContentPage
	{
        private const string Url = "http://jsonplaceholder.typicode.com/photos";
        private ObservableCollection<Post> _posts;
        WebRequestMaker _webClient;
        public SponsorsListScreen ()
		{
			InitializeComponent ();
            SponsorsData();
            _webClient = new WebRequestMaker();
        }
        public async void SponsorsData()
        {
            try
            {
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
           // var posts = JsonConvert.DeserializeObject<List<Post>>(ResponseData.ToString());
           // _posts = new ObservableCollection<Post>(posts);
          //  sponsorsList.ItemsSource = _posts;
           // sponsorsList.IsPullToRefreshEnabled = true;
        }
        // navigate on Detail Page
        private void sortingByCountry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SponsorsDetail());

        }
    }
}
