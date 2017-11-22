using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.ForgetPassword
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgetPasswordNewPasswordPage : ContentPage
	{
		public ForgetPasswordNewPasswordPage ()
		{
			InitializeComponent ();
		}

        private async void btnConfirmPassword_ForgetPasswordNewPasswordPage_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Login.LoginEmailPage());
        }
    }
}