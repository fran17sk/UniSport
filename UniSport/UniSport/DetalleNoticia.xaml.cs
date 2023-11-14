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
	public partial class DetalleNoticia : ContentPage
	{
        public DetalleNoticia()
        {
            InitializeComponent();

            // Enlazar los datos de la noticia seleccionada para mostrar el título, la imagen y los párrafos de la noticia
            
        }
    }
}