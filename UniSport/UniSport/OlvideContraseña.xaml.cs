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
	public partial class OlvideContraseña : ContentPage
	{
		public OlvideContraseña ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}