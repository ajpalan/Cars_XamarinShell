using System;
using System.Collections.Generic;
using System.Linq;
using Cars_XShell.Models;
using Xamarin.Forms;

namespace Cars_XShell.Views
{
    public partial class FordPage : ContentPage
    {
        public FordPage()
        {
            InitializeComponent();
        }

        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            string carName = (e.CurrentSelection.FirstOrDefault() as Car).CarName;
            await Shell.Current.GoToAsync($"cardetails?name={carName}");

        }
    }
}
