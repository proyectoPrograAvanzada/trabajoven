using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajoven.Clases
{
    public class RegistroPostulantes
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string correo;
        private string telefono;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

    }
}