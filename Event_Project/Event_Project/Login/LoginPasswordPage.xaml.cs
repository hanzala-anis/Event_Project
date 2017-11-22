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
	public partial class LoginPasswordPage : ContentPage
	{
		public LoginPasswordPage ()
		{
			InitializeComponent ();
		}

        private async void btnPassword_LoginPasswordPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login.LoginChooseEventPage());
        }


        private async void FogetPasswordClick_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassword.ForgetPasswordEmailPage());
        }
    }
}