using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Event_Project.MasterPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterHomePage : MasterDetailPage
    {
		public MasterHomePage ()
		{
			InitializeComponent ();

            masterPage.ListView.ItemSelected += ListView_ItemSelected;

		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var items = e.SelectedItem as MasterPageItems;
            if (items != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(items.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
                
        }
    }
}
