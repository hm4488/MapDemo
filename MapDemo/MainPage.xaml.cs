using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MapDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void mapButton_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(latitudeEntry.Text, out double latitude))
                return;
            if (!double.TryParse(longitudeEntry.Text, out double longitude))
                return;


            /*var location = new Location(latitude, longtitude);
            var options = new MapLaunchOptions {Name = nameEntry.Text};
            

            await Map.OpenAsync(location, options);*/

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = nameEntry.Text
            });
        }

        private async void mapDriving_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(latitudeEntry.Text, out double latitude))
                return;
            if (!double.TryParse(longitudeEntry.Text, out double longitude))
                return;


            /*var location = new Location(latitude, longtitude);
            var options = new MapLaunchOptions {Name = nameEntry.Text};
            

            await Map.OpenAsync(location, options);*/

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = nameEntry.Text,
                NavigationMode = NavigationMode.Driving
            }) ;
        }

        private async void mapWalking_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(latitudeEntry.Text, out double latitude))
                return;
            if (!double.TryParse(longitudeEntry.Text, out double longitude))
                return;


            /*var location = new Location(latitude, longtitude);
            var options = new MapLaunchOptions {Name = nameEntry.Text};
            

            await Map.OpenAsync(location, options);*/

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = nameEntry.Text,
                NavigationMode = NavigationMode.Walking
            });
        }
    }
}
