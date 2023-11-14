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
    public partial class ConfirmacionMail : ContentPage
    {
        public ConfirmacionMail(string Correo)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            correo.Text = Correo;
        }

        private void btnverificarcodigo_Clicked(object sender, EventArgs e)
        {

        }

        private void btnreenviar_Clicked(object sender, EventArgs e)
        {

        }

        private async void btncancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}