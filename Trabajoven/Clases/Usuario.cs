using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajoven.Clases
{
    public class Usuario
    {
        private string region;
        private string ciudad;
        private string telefonoFijo;
        private string telefonoMovil;
        private string direccion;
        private string email;
        private string contrasenia;

        public Usuario()
        {
        }


        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string TelefonoMovil
        {
            get { return telefonoMovil; }
            set { telefonoMovil = value; }
        }

        public string TelefonoFijo
        {
            get { return telefonoFijo; }
            set { telefonoFijo = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public void CrearUsuario() { }
        public void ModificarUsuario() { }
        public void DesactivarUsuario() { }
        public void BuscarOferta() { }




    }
}