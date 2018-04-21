using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboFin
{
    public partial class bankingPage : ContentPage
    {
        public bankingPage()
        {
            InitializeComponent();

            learnMoreBtn.Clicked += async (sender, e) => {                  await Navigation.PushAsync(new LearningPage());             };

            optionBtn.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new BestOptionsPage());
            };
        }
    }
}
