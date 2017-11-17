using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : CarouselPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        private void btnEmail_LoginPage_Clicked(object sender, EventArgs e)
        {

        }
    }
}