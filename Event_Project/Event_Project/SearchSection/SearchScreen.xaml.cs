using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.CoreClasses;

namespace Event_Project.SearchSection
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
    public partial class SearchScreen : ContentPage
    {
        //  Label resultsLabel;
        // SearchBar searchBar;
        private const string Url = "http://jsonplaceholder.typicode.com/photos";
        private ObservableCollection<Post> _posts;
        WebRequestMaker _webClient;
        public SearchScreen()
        {
            InitializeComponent();
            searchData();
            _webClient = new WebRequestMaker();
            //resultsLabel = new Label
            //{
            //    Text = "Result will appear here.",
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    FontSize = 25
            //};
            //searchBar = new SearchBar
            //{
            //    Placeholder = "Enter search term",
            //    SearchCommand = new Command(() => { resultsLabel.Text = "Result: " + searchBar.Text + " is what you asked for."; })
            //};


            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Start,
            //    Children = {
            //        new Label {
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            Text = "SearchBar",
            //            FontSize = 50
            //        },
            //        searchBar,
            //        new ScrollView
            //        {
            //            Content = resultsLabel,
            //            VerticalOptions = LayoutOptions.FillAndExpand
            //        }
            //    },
            //    Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5)
            //};

        }

        public async void searchData()
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
            var posts = JsonConvert.DeserializeObject<List<Post>>(ResponseData.ToString());
            _posts = new ObservableCollection<Post>(posts);
            searchList.ItemsSource = _posts;

            ProgressLoader.IsVisible = false;
            searchList.IsPullToRefreshEnabled = true;
        }

        private void search_event_SearchButtonPressed(object sender, EventArgs e)
        {

            var keywords = search_event.Text;
            searchList.ItemsSource = _posts.Where(Title => Title.title.Contains(keywords));
        }
    }
}