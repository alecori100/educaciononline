using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
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
        }
        public void BajaAlumno(int idAlumno)
        {
            Alumno nuevoAlumno = new Alumno();
            var alumnoEliminado = ListaAlumno.Find(x => idAlumno == x.idAlumno);
            ListaAlumno.Remove(alumnoEliminado);
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
            var productoEliminado = ListaAlumno.Find(x => NuevoAlumno.idAlumno == x.idAlumno);
            ListaAlumno.Remove(alumnoModificado);
            ListaAlumno.Add(alumnoModificado);
        }

    }
}
