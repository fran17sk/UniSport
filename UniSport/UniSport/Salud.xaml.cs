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
    public partial class Salud : ContentPage
    {
        public Salud()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); 
        }
    }
}