using Xamarin.Forms;

namespace RoboFin
{
    public partial class RoboFinPage : ContentPage
    {
        public RoboFinPage()
        {
            InitializeComponent();

            logInButton.Clicked += async (sender, e) => {

                await Navigation.PushAsync(new logInPage());
            };

            signUpButton.Clicked += async (sender, e) => {

                await Navigation.PushAsync(new signupPage());
            };

        }

    }
}
