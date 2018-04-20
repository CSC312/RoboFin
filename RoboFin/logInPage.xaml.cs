using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboFin
{
    public partial class logInPage : ContentPage
    {
        public logInPage()
        {
            InitializeComponent();

            logUserButton.Clicked += async (sender, e) => {

                await Navigation.PushAsync(new HomePage());
            };

        }
    }
}
