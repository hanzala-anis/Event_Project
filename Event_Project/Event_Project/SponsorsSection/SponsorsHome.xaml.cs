﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.SponsorsSection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SponsorsHome : ContentPage
	{
		public SponsorsHome ()
		{
			InitializeComponent ();
		}
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SponsorsCarouselPage());
        }
    }
}
