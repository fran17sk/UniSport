using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace UniSport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OlvideContraseña : ContentPage
	{
		public OlvideContraseña ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btncode_Clicked(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Placeholder = "Por favor ingrese mail";
            }
            else
            {
                btncode.Text = "Procesando....";
                EnviarMailRecPassword email = new EnviarMailRecPassword();
                int numero = email.Enviar(mail.Text, "");
                Navigation.PushAsync(new ConfirmarCodigo(mail.Text, numero));
                btncode.Text = "Enviado";
                
            }
        }

        private async void btncancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btncancel_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}