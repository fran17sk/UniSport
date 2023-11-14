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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private async void btnNoticias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Noticias());
        }

        private async void btnEventos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eventos());
        }

    }


}