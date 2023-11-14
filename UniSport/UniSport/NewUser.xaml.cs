using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniSport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewUser : ContentPage
    {
        public NewUser()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btncancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btncrear_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmacionMail(mail.Text));
        }

        private void btnseesecondpass_Clicked(object sender, EventArgs e)
        {
            if (secondpassword.IsPassword == true)
            {
                secondpassword.IsPassword = false;
            }
            else
            {
                secondpassword.IsPassword = true;
            }
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
    }
}