using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajoven.Clases;

namespace Trabajoven.Clases
{
    public class Empresa : Usuario
    {
        private int idEmpresa;
        private string nombreEmpresa;
        private string representante;
        private string rutEmpresa;
        private string rubro;

        public string Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }


        public string RutEmpresa
        {
            get { return rutEmpresa; }
            set { rutEmpresa = value; }
        }

        public string Representante
        {
            get { return representante; }
            set { representante = value; }
        }

        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }


        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        public void CrearOferta() { }
        public void ModificarOferta() { }
        public void EliminarOferta() { }

    }
}