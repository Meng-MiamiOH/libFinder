using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace libFinder2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {
        public List<string> Items { get; set; }

        public Account()
        {
            InitializeComponent();

            Items = new List<string>
            {
                "Google",
                "Google2",
                "Miami Libaray"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item.ToString() == "Google")
            {
                Device.OpenUri(new Uri("https://www.google.com"));
                await DisplayAlert("Opening browser", "Going to https://www.google.com", "OK");
            }
            if (e.Item.ToString() == "Google2")
            {
                Device.OpenUri(new Uri("https://www.google.com"));
                await DisplayAlert("Opening browser", "Going to https://www.google.com", "OK");
            }
            if (e.Item.ToString() == "Miami Libaray")
            {
                Device.OpenUri(new Uri("https://www.lib.miamioh.edu/"));
                await DisplayAlert("Opening browser", "Going to https://www.lib.miamioh.edu", "OK");
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
