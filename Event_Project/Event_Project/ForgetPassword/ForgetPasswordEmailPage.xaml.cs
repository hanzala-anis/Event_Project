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
	public partial class ForgetPasswordEmailPage : ContentPage
	{
		public ForgetPasswordEmailPage ()
		{
			InitializeComponent ();
		}

        private async void btnEmail_ForgetPasswordEmailPage_Clicked(object sender, EventArgs e)
        {
         
            await Navigation.PushAsync(new ForgetPassword.ForgetPasswordConfirmationCodePage());
        }
    }
}