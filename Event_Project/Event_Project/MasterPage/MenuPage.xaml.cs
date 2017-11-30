using Event_Project.AgendaSection;
using Event_Project.AttendeesSection;
using Event_Project.MyScheduleSection;
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
                Iconsource="Icon.png",
                TargetType = typeof(SponsorsHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Attendees",
                Iconsource = "Icon.png",
                TargetType = typeof(AttendeesHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "Agenda",
                Iconsource = "Icon.png",
                TargetType = typeof(AgendaHome)
            });
            masterPageItem.Add(new MasterPageItems
            {
                Title = "MySchedule",
                Iconsource = "Icon.png",
                TargetType = typeof(MyScheduleHome)
            });
            listView.ItemsSource = masterPageItem;
		}
	}
}
