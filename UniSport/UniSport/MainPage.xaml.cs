using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UniSport
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnseepass_Clicked(object sender, EventArgs e)
        {
            if (password.IsPassword == true)
            {
                password.IsPassword = false;
            }
            else
            {
                password.IsPassword = true;
            }
        }

        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio1());


        }

        private async void lblpss_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlvideContraseña());
        }

        private async void btnsingin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewUser());
        }

        private void btnloginface_Clicked(object sender, EventArgs e)
        {

        }

        private void btnlogingoogle_Clicked(object sender, EventArgs e)
        {

        }
    }
}
