using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniSport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleNoticia : ContentPage
	{
        public DetalleNoticia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}