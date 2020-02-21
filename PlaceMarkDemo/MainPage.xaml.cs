using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Xamarin.Essentials;
using System.Reflection;

namespace PlaceMarkDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<string> listOfCountryName = new List<string>();
        

        public MainPage()
        {
            string filePath = "countries.csv";
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{filePath}");
            using (var reader = new StreamReader(stream))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    listOfCountryName.Add(line);
                }
            }
            InitializeComponent();

            foreach (string countryName in listOfCountryName)
            {
                countryNamePicker.Items.Add(countryName);
            }
           
        }

        private async void mapButton_Clicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = countryNamePicker.SelectedIndex.ToString(),
                AdminArea = adminAreaEntry.Text,
                Thoroughfare = throughFareEntry.Text,
                Locality = localityEntry.Text
            };

            await Map.OpenAsync(placemark);
        }

        private async void mapDriving_Clicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = countryNamePicker.SelectedIndex.ToString(),
                AdminArea = adminAreaEntry.Text,
                Thoroughfare = throughFareEntry.Text,
                Locality = localityEntry.Text
            };

            await Map.OpenAsync(placemark, new MapLaunchOptions
            {
                Name = nameEntry.Text,
                NavigationMode = NavigationMode.Driving
            });
        }
        

        private async void mapWalking_Clicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = countryNamePicker.SelectedIndex.ToString(),
                AdminArea = adminAreaEntry.Text,
                Thoroughfare = throughFareEntry.Text,
                Locality = localityEntry.Text
            };

            await Map.OpenAsync(placemark, new MapLaunchOptions
            {
                Name = nameEntry.Text,
                NavigationMode = NavigationMode.Walking
            });
        }
    }
}

