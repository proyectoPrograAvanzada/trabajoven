using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajoven.Clases;

namespace Trabajoven.Clases
{
    public class Persona : Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string rut;
        private char sexo;
        private string estudios;
        private string ocupacion;

        public Persona()
        {
        }

        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }

        public string Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public void PostularAOfertas() { }
        public void EnviarCurriculum() { }




    }
}