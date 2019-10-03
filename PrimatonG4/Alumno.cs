using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimatonG4
{
    public class Alumno
    {
        #region PROPIEDADES
        private string nombreApellido;
        private string contrasenia;
        private string escuela;
        private string curso;
        private string dni;
        private string calificacion;
        #endregion

        #region METODOS
        public string nombre
        {
           get { return nombreApellido; }
           set { nombreApellido = value; }
        }

        public string password 
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string school 
        {
            get { return escuela; }
            set { escuela = value; }
        }

        public string course 
        {
            get { return curso; }
            set { curso = value; }
        }

        public string documento 
        {
            get { return dni;}
            set { dni = value; }
        }

        public string nota 
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        #endregion
    }
}

