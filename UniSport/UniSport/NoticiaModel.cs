using System;
using System.Collections.Generic;
using System.Text;

namespace UniSport
{
    public class NoticiaModel
    {
        public int IdModel {  get; set; }
        public string NoticiaTitulo { get; set; }
        public string NoticiaDescripcion { get; set; }
        public string NoticiaImagen { get; set; }
        public string NoticiaUrl { get; set; }
    }
}