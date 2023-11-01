using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniSport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfirmarCodigo : ContentPage
	{
		public ConfirmarCodigo (string correo,int num)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnverificar_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnreenviar_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void btncancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PopAsync();
        }
    }
}