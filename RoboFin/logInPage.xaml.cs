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
                string usrname = usrnameField.Text;
                string pwd = pwdField.Text;
                if( usrname != "" && pwd != ""){
                    if (usrname != "a" && pwd != "a")
                    {
                        errorLabel.Text = "Incorrect Username/Password Combination!";
                        errorLabel.IsVisible = true;
                    }
                    else{
                        errorLabel.IsVisible = false;
                        await Navigation.PushAsync(new HomePage());
                    }

                }
            };

        }

    }
}
