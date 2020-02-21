using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NFLDemoApp
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

        private async void newYorkButton_Clicked(object sender, EventArgs e)
        {
           
                var location = new Location(40.8135, -74.0745);
                var options = new MapLaunchOptions { Name = "New York Giants" };

                await Map.OpenAsync(location, options);
        }

        private async void newEnglandPatriotsButton_Clicked(object sender, EventArgs e)
        {
            var location = new Location(42.0953765, -71.2656096);
            var options = new MapLaunchOptions { Name = "New England Patriots" };

            await Map.OpenAsync(location, options);
        }

        private async void chicagoBearsButton_Clicked(object sender, EventArgs e)
        {
            var location = new Location(41.8625332, -87.6167182);
            var options = new MapLaunchOptions { Name = "Chicago Bears" };

            await Map.OpenAsync(location, options);
        }
    }
}
