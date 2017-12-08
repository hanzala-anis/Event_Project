using Event_Project.SearchSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.AttendeesSection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AttendeesHome : ContentPage
	{
		public AttendeesHome ()
		{
			InitializeComponent ();
		}
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AttendeesCarouselPage());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SearchHome());
        }
    }
}
