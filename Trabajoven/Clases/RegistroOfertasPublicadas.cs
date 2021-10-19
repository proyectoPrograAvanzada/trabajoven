using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajoven.Clases;

namespace Trabajoven.Clases
{
    public class RegistroOfertasPublicadas
    {
        private string titulo;
        private string descripcion;
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
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

    }
}