using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace PrimatonG4
{
    public class Users
    {
        private static Alumno alumnoLogueado = null;

        private static string pathRegistros = "registros.xml";

        #region EVENTOS
        public static bool registrar (Alumno alumno)
        {
            if (!File.Exists(pathRegistros))
            {
                using(var tw = new StreamWriter(pathRegistros, true))
                {
                    tw.WriteLine("<Alumnos>");
                    tw.WriteLine("</Alumnos>");
                }
            }
                    //comprobamos que el dni no este registrado
            XmlDocument alumnos = new XmlDocument();
            alumnos.Load(pathRegistros);
            var consulta = "//Alumno[(dni = '" + alumno.documento + "')]";
            var resultado = alumnos.SelectSingleNode(consulta);
            if (resultado != null) {
                return false;
            }

            var documentoAlumnos = new XmlDocument();
            documentoAlumnos.Load(pathRegistros);
            // Necesitamos agregar un nuevo alumno
            var xmlPadre = documentoAlumnos.SelectSingleNode("Alumnos");
            XmlNode nuevoAlumno = documentoAlumnos.CreateElement("Alumno"); 
            // Agregar nodo nombre
            XmlNode nodoNombre = documentoAlumnos.CreateElement("nombre");
            nodoNombre.InnerText = alumno.nombre;
            nuevoAlumno.AppendChild(nodoNombre);
            // Agregar nodo dni
            XmlNode nodoDni = documentoAlumnos.CreateElement("dni");
            nodoDni.InnerText = alumno.documento;
            nuevoAlumno.AppendChild(nodoDni);
              // Agregar nodo nota
             XmlNode nodoNota = documentoAlumnos.CreateElement("calificacion");
            nodoNota.InnerText = alumno.nota;
            nuevoAlumno.AppendChild(nodoNota);        
            // Agregar nodo escuela
            XmlNode nodoEscuela = documentoAlumnos.CreateElement("escuela");
            nodoEscuela.InnerText = alumno.school;
            nuevoAlumno.AppendChild(nodoEscuela);
            // Agregar nodo curso
            XmlNode nodoCurso = documentoAlumnos.CreateElement("curso");
            nodoCurso.InnerText = alumno.course;
            nuevoAlumno.AppendChild(nodoCurso);
            // Agregar nodo contrasenia
            XmlNode nodoContrasenia = documentoAlumnos.CreateElement("contrasenia");
            nodoContrasenia.InnerText = alumno.password;
            nuevoAlumno.AppendChild(nodoContrasenia);
            // Guardamos el nuevo nodo
            xmlPadre.AppendChild(nuevoAlumno);
            // Salvamos los cambios
            documentoAlumnos.Save(pathRegistros);
            return true;
        }

      public static Alumno obtenerAlumnoLoguead() 
        {
            return alumnoLogueado;
        }

        public static Alumno login (string dni, string clave) 
        {
            if (!File.Exists(pathRegistros))
            {
                return null;
            }
            Alumno alumnoEncontrado = null;
            XmlDocument alumnos = new XmlDocument();
            alumnos.Load(pathRegistros);
            var consulta = "//Alumno[(dni = '" + dni +"') and (contrasenia = '" + clave + "')]";
            var resultado = alumnos.SelectSingleNode(consulta);
            if (resultado != null) 
            {
                alumnoEncontrado = new Alumno();
                alumnoEncontrado.nombre = resultado.SelectSingleNode("nombre").InnerText;
                alumnoEncontrado.documento = resultado.SelectSingleNode("dni").InnerText;
                alumnoEncontrado.nota = resultado.SelectSingleNode("calificacion").InnerText;
                alumnoEncontrado.school = resultado.SelectSingleNode("escuela").InnerText;
                alumnoEncontrado.course = resultado.SelectSingleNode("curso").InnerText;
                alumnoLogueado = alumnoEncontrado;
            }
            return alumnoEncontrado;
        }

        #endregion
    }
}
