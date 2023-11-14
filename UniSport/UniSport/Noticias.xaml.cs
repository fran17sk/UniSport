using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace UniSport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Noticias : ContentPage

    {

        public ICommand DetalleNoticiaCommand { get; private set; }
        public ObservableCollection<NoticiaModel> NewsCollection { get; set; }
        public Noticias()
        {
            InitializeComponent();

            // Populate NewsCollection with news items
            NewsCollection = new ObservableCollection<NoticiaModel>
        {
            new NoticiaModel
            {
                IdModel = 1,
                NoticiaTitulo = "El gran triunfo de UCASAL en los Juegos Universitarios Argentinos",
                NoticiaDescripcion = "Entre los días 18 y 21 de abril se desarrollaron en Salta los Juegos Universitarios Argentinos (JUAR), región Noa, siendo sede anfitriona la UNSA.\r\n\r\nEn esta edición, los equipos representativos de UCASAL se desempeñaron con éxito en varias disciplinas deportivas.",
                NoticiaImagen = "https://www.ucasal.edu.ar/wp-content/uploads/2023/05/WhatsApp-Image-2023-04-21-at-12.25.56-PM-2-1-copia.jpeg",
                NoticiaUrl = "https://www.example.com/news1"
            },
            new NoticiaModel
            {
                IdModel = 2,
                NoticiaTitulo = "La Universidad suma una nueva cancha de fútbol",
                NoticiaDescripcion = "En el marco de los 60 años, UCASAL continúa sumando espacios de recreación y entretenimiento.",
                NoticiaImagen = "https://www.ucasal.edu.ar/wp-content/uploads/2023/05/IMG_1720-scaled.jpg",
                NoticiaUrl = "https://www.example.com/news1"
            },
            new NoticiaModel
            {
                IdModel = 3,
                NoticiaTitulo = "UCASAL CORRE: Los circuitos más desafiantes llegan en octubre",
                NoticiaDescripcion = "El décimo mes del año estará protagonizado por la segunda edición de UCASALCorre, una propuesta deportiva para toda la familia con fines benéficos ynuevos circuitos con paisajes increíbles",
                NoticiaImagen = "https://us.cdn.eltribuno.com/082023/1693399328214.jpg?cw=600&ch=365",
                NoticiaUrl = "https://www.example.com/news1"
            },


        };

            BindingContext = this;
        }
        private async void btnDetalleNoticia_Clicked(object sender, EventArgs e)

        {
           await Navigation.PushAsync(new DetalleNoticia());
            

        }
       
    }
}