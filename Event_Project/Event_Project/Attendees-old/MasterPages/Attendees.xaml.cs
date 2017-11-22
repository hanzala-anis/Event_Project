using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.Attendees.MasterPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Attendees : ContentPage
	{
		public Attendees ()
		{
			InitializeComponent ();
		}

        //protected override bool OnBackButtonPressed()
        //{
        //    Device.BeginInvokeOnMainThread(async () => {
        //        var result = await this.DisplayAlert("Alert!", "Do you really want to exit?", "Yes", "No");
        //        if (result) await this.Navigation.PopAsync();

        //    });
        //    return true;
        //}
    }
}
