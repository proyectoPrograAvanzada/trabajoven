using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajoven.Clases
{
    public class PublicacionDeOferta
    {
        private int idPublicacion;
        private string titulo;
        private string descripcion;
        private string fechaPublicacion;

        public string FechaPublicacion
        {
            get { return fechaPublicacion; }
            set { fechaPublicacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int IdPublicacion
        {
            get { return idPublicacion; }
            set { idPublicacion = value; }
        }

    }
}