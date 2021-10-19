using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajoven.Clases
{
    public class RegistroPostulacion
    {
        private string fecha;
        private string empresa;
        private string tituloOferta;

        public string TituloOferta
        {
            get { return tituloOferta; }
            set { tituloOferta = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}