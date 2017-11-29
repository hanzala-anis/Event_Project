using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.Attendees
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AttendeesCarouselPage : CarouselPage
    {
		public AttendeesCarouselPage ()
		{
			InitializeComponent ();
		}
	}
}
