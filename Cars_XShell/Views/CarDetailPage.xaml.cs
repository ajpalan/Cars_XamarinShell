using System;
using System.Collections.Generic;
using System.Linq;
using Cars_XShell.Data;
using Cars_XShell.Models;
using Xamarin.Forms;

namespace Cars_XShell.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class CarDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadCarDetail(value);
            }
        }

        public CarDetailPage()
        {
            InitializeComponent();

        }

        private void LoadCarDetail(string name)
        {
            try
            {
                Car car = FordCarsData.FordCars.FirstOrDefault(x => x.CarName == name);
                BindingContext = car;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load car details.");
            }
        }
    }
}
