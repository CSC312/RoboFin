using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboFin
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            bankingButton.Clicked += async (sender, e) => {

                await Navigation.PushAsync(new bankingPage());
            };
        }
    }
}
