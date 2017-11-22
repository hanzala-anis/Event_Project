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
	public partial class LoginEmailPage : ContentPage
	{
		public LoginEmailPage ()
		{
			InitializeComponent ();
		}


        private async void btnEmail_LoginEmailPage_Clicked(object sender, EventArgs e)
        {
          //  await Navigation.PushAsync(new LoginPasswordPage());
            await Navigation.PushAsync(new Login.LoginPasswordPage());
        }
    }
}