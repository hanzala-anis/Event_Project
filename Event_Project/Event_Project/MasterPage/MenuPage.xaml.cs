using Event_Project.AgendaSection;
using Event_Project.AttendeesSection;
using Event_Project.MyScheduleSection;
using Event_Project.SearchSection;
using Event_Project.SponsorsSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.MasterPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
        public ListView ListView { get { return listView; } }
        public MenuPage ()
		{
			InitializeComponent ();

            var masterPageItem = new List<MasterPageItems>();
            masterPageItem.Add(new MasterPageItems
            {
                Title="Sponsors",
                IconSource = "ic_supervisor_account_black_24dp.png",
                TargetType = typeof(SponsorsHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Attendees",
                IconSource = "ic_flag_black_24dp.png",
                TargetType = typeof(AttendeesHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Agenda",
                IconSource = "ic_favorite_black_24dp.png",
                TargetType = typeof(AgendaHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "My Agenda (link N/A)",
                IconSource = "ic_assignment_turned_in_black_24dp.png",
                TargetType = typeof(AgendaHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "MySchedule",
                IconSource = "ic_loyalty_black_24dp.png",
                TargetType = typeof(MyScheduleHome)
            });
            masterPageItem.Add(new MasterPageItems {
                Title = "Photos (link N/A)",
                IconSource = "ic_perm_media_black_24dp",
                TargetType= typeof(AttendeesHome)

            });

            masterPageItem.Add(new MasterPageItems
            {
                Title = "Scan QR Code (link N/A)",
                IconSource = "ic_crop_free_black_24dp",
                TargetType = typeof(AttendeesHome)

            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Map (link N/A)",
                IconSource = "ic_map_black_24dp",
                TargetType = typeof(AttendeesHome)

            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Search Screen",
                IconSource = "ic_search_black_24dp",
                TargetType = typeof(SearchHome)

            }); 


            listView.ItemsSource = masterPageItem;
		}
	}
}
