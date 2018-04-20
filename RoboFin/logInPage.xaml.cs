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
                if(checkCredentials(usrname,pwd) == false){
                    errorLabel.Text = "Incorrect Username/Password Combination!";
                    errorLabel.IsVisible = true;
                }
                errorLabel.IsVisible = false;
                await Navigation.PushAsync(new HomePage());
            };

        }

        public bool checkCredentials(string username, string password){
            if(username != "a" && password != "a" ){
                return false;
            }
            return true;
        }
    }
}
