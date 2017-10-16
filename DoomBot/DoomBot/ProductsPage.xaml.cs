using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoomBot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<Models.User>
            {
                //new Models.User { Name = "DoomBot", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                // new Models.User { Name = "Rover", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var products = e.SelectedItem as Models.User;
            await Navigation.PushAsync(new ProductsDetailPage(products));
            ListView.SelectedItem = null;
        }
    }
}