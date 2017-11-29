using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginChooseEventPage : ContentPage
	{
		public LoginChooseEventPage ()
		{
			InitializeComponent ();

            //Hanzala

            EventPicker_LoginChooseEventPage.Items.Add("Event 1");
            EventPicker_LoginChooseEventPage.Items.Add("Event 2");
            EventPicker_LoginChooseEventPage.Items.Add("Event 3");
        }


        private void EventPicker_LoginChooseEventPage_OnSelectedIndexChanged(object sender, EventArgs e)
        {
             var name = EventPicker_LoginChooseEventPage.Items[EventPicker_LoginChooseEventPage.SelectedIndex];
            DisplayAlert(name , "Selected Event","OK");
        }
    }
}