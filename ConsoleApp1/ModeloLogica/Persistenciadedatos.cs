using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO; 

namespace ModeloLogica
{
    public class Persistenciadedatos
    {
        readonly string RutaListaAlumno = @"C:\Users\Alumno\source\repos\ConsoleApp1\Listas\ListaAlumno.txt";
        readonly string RutaListaProfesor = @"C:\Users\Alumno\source\repos\ConsoleApp1\Listas\ListaProfesor.txt";
        readonly string RutaListaCurso = @"C:\Users\Alumno\source\repos\ConsoleApp1\Listas\ListaCurso.txt";
        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListaAlumno))
            {
                File.Create(RutaListaAlumno).Close();
            }
            if (!File.Exists(RutaListaProfesor))
            {
                File.Create(RutaListaProfesor).Close();
            }
            if (!File.Exists(RutaListaCurso))
            {
                File.Create(RutaListaCurso).Close();
            }
        }
        public List<Alumno> LeerArchivoAlumno()
        {
            string locationFile = RutaListaAlumno;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Alumno> ListaAlumno = JsonConvert.DeserializeObject<List<Alumno>>(content);
                return ListaAlumno;
            }
        }

        public List<Profesor> LeerArchivoProfesor()
        {
            string locationFile = RutaListaProfesor;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Profesor> ListaProfesor = JsonConvert.DeserializeObject<List<Profesor>>(content);
                return ListaProfesor;
            }
        }
        public List<Curso> LeerArchivoCurso()
        {
            string locationFile = RutaListaCurso;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Curso> ListaCurso = JsonConvert.DeserializeObject<List<Curso>>(content);
                return ListaCurso;
            }
        }
        public void GuardarArchivoAlumno(List<Alumno> ListaAlumno)
        {
            string locationFile = RutaListaAlumno;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlumno);
                writer.Write(jsonContent);
            }
        }
        public void GuardarArchivoProfesor(List<Profesor> ListaProfesor)
        {
            string locationFile = RutaListaProfesor;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProfesor);
                writer.Write(jsonContent);
            }
        }
        public void GuardarArchivoCurso(List<Curso> ListaCurso)
        {
            string locationFile = RutaListaCurso;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string JsonContent = JsonConvert.SerializeObject(ListaCurso);
                writer.Write(JsonContent);
            }
        }
    }
}
