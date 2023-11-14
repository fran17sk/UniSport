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
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void btnlogout_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void OnEditarPerfilClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarPerfil());
        }

    }
}