using Event_Project.Attendees.MasterPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.Attendees
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{

        // master page listview Variable
        public ListView ListView { get { return listview; } }
		public MenuPage ()
		{
			InitializeComponent ();

            // master page's table class
            var masterPageItems = new List<MasterPageItems>();
            masterPageItems.Add(new MasterPageItems {
                Title ="Sponsors",
                IconSource= "@drawable/ic_supervisor_account_black_24dp",
                TargetType = typeof(Sponsors)

            });
            masterPageItems.Add(new MasterPageItems
            {
                Title = "Attendees",
                IconSource = "@drawable/ic_flag_black_24dp",
                TargetType = typeof(Attendees.MasterPages.Attendees)

            });
            masterPageItems.Add(new MasterPageItems
            {
                Title = "Agenda",
                IconSource = "@drawable/ic_favorite_black_24dp",
                TargetType = typeof(Agenda)

            });
            masterPageItems.Add(new MasterPageItems
            {
                Title = "MySchedule",
                IconSource = "@drawable/ic_loyalty_black_24dp",
                TargetType = typeof(MySchedule)

            });
            // binding listview with master pages
            listview.ItemsSource = masterPageItems;


//Master Pages End----------------------------------
        }


        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Alert!", "Do you really want to exit?", "Yes","No");
                if (result) await this.Navigation.PopAsync();

            });
            return base.OnBackButtonPressed();
        }

    }
}
