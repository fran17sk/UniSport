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
       
        public string NewsImageUrl { get; set; }
        public ICommand ImageTappedCommand { get; set; }
        public ObservableCollection<NoticiaModel> NewsCollection { get; set; }
        public Noticias()
        {
            InitializeComponent();

            // Populate NewsCollection with news items
            NewsCollection = new ObservableCollection<NoticiaModel>
        {
            new NoticiaModel
            {
                NoticiaTitulo = "Noticia 1",
                NoticiaDescripcion = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                NoticiaImagen = "https://picsum.photos/200/300",
                NoticiaUrl = "https://www.example.com/news1"
            },
            new NoticiaModel
            {
                NoticiaTitulo = "Noticia 2",
                NoticiaDescripcion = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                NoticiaImagen = "https://picsum.photos/200/300",
                NoticiaUrl = "https://www.example.com/news1"
            },
            new NoticiaModel
            {
                NoticiaTitulo = "Noticia 3",
                NoticiaDescripcion = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                NoticiaImagen = "https://picsum.photos/200/300",
                NoticiaUrl = "https://www.example.com/news1"
            },

            // Add more news items as needed
        };

            BindingContext = this;
        }

    }
}