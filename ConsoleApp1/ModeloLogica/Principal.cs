using ModeloLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLogica
{
    public class Principal
    {
        List<Alumno> ListaAlumno = new List<Alumno>();
        public void AltaAlumno(Alumno NuevoAlumno)
        {
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.DNI = NuevoAlumno.DNI;
            nuevoAlumno.Nombre = NuevoAlumno.Nombre;
            nuevoAlumno.Email = NuevoAlumno.Email;
            nuevoAlumno.Telefono = NuevoAlumno.Telefono;
            nuevoAlumno.Direccion = NuevoAlumno.Direccion;
            nuevoAlumno.idAlumno = NuevoAlumno.idAlumno;
            nuevoAlumno.tarjetaCredito = NuevoAlumno.tarjetaCredito;
            ListaAlumno.Add(nuevoAlumno);
            InstanciaPersistenciadedatos.GuardarArchivoAlumno(ListaAlumno);
        }
        public void BajaAlumno(int idAlumno)
        {
            Alumno nuevoAlumno = new Alumno();
            var alumnoEliminado = ListaAlumno.Find(x => idAlumno == x.idAlumno);
            ListaAlumno.Remove(alumnoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoAlumno(ListaAlumno);
        }
        public void ModificarAlumno(Alumno NuevoAlumno)
        {
            var alumnoModificado = ListaAlumno.Find(x => NuevoAlumno.idAlumno == x.idAlumno);
            alumnoModificado.DNI = alumnoModificado.DNI;
            alumnoModificado.Nombre = alumnoModificado.Nombre;
            alumnoModificado.Email = alumnoModificado.Email;
            alumnoModificado.Telefono = alumnoModificado.Telefono;
            alumnoModificado.Direccion = alumnoModificado.Direccion;
            alumnoModificado.idAlumno = alumnoModificado.idAlumno;
            alumnoModificado.tarjetaCredito = alumnoModificado.tarjetaCredito;
            ListaAlumno.Add(alumnoModificado);
            var alumnoEliminado = ListaAlumno.Find(x => NuevoAlumno.idAlumno == x.idAlumno);
            ListaAlumno.Remove(alumnoModificado);
            ListaAlumno.Add(alumnoModificado);
            InstanciaPersistenciadedatos.GuardarArchivoAlumno(ListaAlumno);
        }






        List<Profesor> ListaProfesor = new List<Profesor>();
        public void AltaProfesor(Profesor NuevoProfesor)
        {
            Profesor nuevoProfesor = new Profesor();
            nuevoProfesor.DNI = nuevoProfesor.DNI;
            nuevoProfesor.Nombre = nuevoProfesor.Nombre;
            nuevoProfesor.Email = nuevoProfesor.Email;
            nuevoProfesor.Telefono = nuevoProfesor.Telefono;
            nuevoProfesor.Direccion = nuevoProfesor.Direccion;
            nuevoProfesor.ID_Empleado = nuevoProfesor.ID_Empleado;
            nuevoProfesor.Curriculum = nuevoProfesor.Curriculum;
            ListaProfesor.Add(nuevoProfesor);
            InstanciaPersistenciadedatos.GuardarArchivoProfesor(ListaProfesor);
        }
        public void BajaProfesor(int ID_Empleado)
        {
            Profesor nuevoProfesor = new Profesor();
            var profesorEliminado = ListaProfesor.Find(x => ID_Empleado == x.ID_Empleado);
            ListaProfesor.Remove(profesorEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoProfesor(ListaProfesor);
        }
        public void ModificarProfesor(Profesor NuevoProfesor)
        {
            var profesorModificado = ListaProfesor.Find(x => NuevoProfesor.ID_Empleado == x.ID_Empleado);
            profesorModificado.DNI = profesorModificado.DNI;
            profesorModificado.Nombre = profesorModificado.Nombre;
            profesorModificado.Email = profesorModificado.Email;
            profesorModificado.Telefono = profesorModificado.Telefono;
            profesorModificado.Direccion = profesorModificado.Direccion;
            profesorModificado.ID_Empleado = profesorModificado.ID_Empleado;
            profesorModificado.Curriculum = profesorModificado.Curriculum;
            ListaProfesor.Add(profesorModificado);
            var profesorEliminado = ListaProfesor.Find(x => NuevoProfesor.ID_Empleado == x.ID_Empleado);
            ListaProfesor.Remove(profesorModificado);
            ListaProfesor.Add(profesorModificado);
            InstanciaPersistenciadedatos.GuardarArchivoProfesor(ListaProfesor);
        }




        List<Curso> ListaCurso = new List<Curso>();
        public void AltaCurso(Curso NuevoCurso)
        {
            Curso nuevoCurso = new Curso();
            nuevoCurso.ID_Curso = nuevoCurso.ID_Curso;
            nuevoCurso.Nombre = nuevoCurso.Nombre;
            nuevoCurso.Temario = nuevoCurso.Temario;
            ListaCurso.Add(nuevoCurso);
            InstanciaPersistenciadedatos.GuardarArchivoCurso(ListaCurso);
        }
        public void BajaCurso(int ID_Curso)
        {
            Curso nuevoCurso = new Curso();
            var cursoEliminado = ListaCurso.Find(x => ID_Curso == x.ID_Curso);
            ListaCurso.Remove(cursoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoCurso(ListaCurso);
        }
        public void ModificarCurso(Curso NuevoCurso)
        {
            var cursoModificado = ListaCurso.Find(x => NuevoCurso.ID_Curso == x.ID_Curso);
            cursoModificado.ID_Curso = cursoModificado.ID_Curso;
            cursoModificado.Nombre = cursoModificado.Nombre;
            cursoModificado.Temario = cursoModificado.Temario;
            ListaCurso.Add(cursoModificado);
            var cursoEliminado = ListaCurso.Find(x => NuevoCurso.ID_Curso == x.ID_Curso);
            ListaCurso.Remove(cursoModificado);
            ListaCurso.Add(cursoModificado);
            InstanciaPersistenciadedatos.GuardarArchivoCurso(ListaCurso);
        }

        Persistenciadedatos InstanciaPersistenciadedatos = new Persistenciadedatos();
        public void RellenarListas()
        {
            ListaAlumno = InstanciaPersistenciadedatos.LeerArchivoAlumno();
            ListaProfesor = InstanciaPersistenciadedatos.LeerArchivoProfesor();
            ListaCurso = InstanciaPersistenciadedatos.LeerArchivoCurso();
        }
        public List<Alumno> ValidarAlumno()
        {
            ListaAlumno = InstanciaPersistenciadedatos.LeerArchivoAlumno();
            if (ListaAlumno == null)
            {
                List<Alumno> NuevaListaAlumno = new List<Alumno>();
                return NuevaListaAlumno;
            }
            else
            {
                return ListaAlumno;
            }
        }
        public List<Profesor> ValidarProfesor()
        {
            ListaProfesor = InstanciaPersistenciadedatos.LeerArchivoProfesor();
            if (ListaProfesor == null)
            {
                List<Profesor> NuevaListaProfesor = new List<Profesor>();
                return NuevaListaProfesor;
            }
            else
            {
                return ListaProfesor;
            }
        }
        public List<Curso> ValidarCurso()
        {
            ListaCurso = InstanciaPersistenciadedatos.LeerArchivoCurso();
            if (ListaCurso == null)
            {
                List<Curso> NuevaListaCurso = new List<Curso>();
                return NuevaListaCurso;
            }
            else
            {
                return ListaCurso;
            }
        }
    }
}
