using ModeloLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Alumno nuevoAlumno = new Alumno();
        Principal principal = new Principal();

        public Form3()
        {
            InitializeComponent();
        }
        Principal instanciaPrincipal = new Principal();

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            nuevoAlumno = new Alumno();
            nuevoAlumno.Nombre = txtboxNombreAlumno.Text;
            nuevoAlumno.Email = txtboxEmailAlumno.Text;
            nuevoAlumno.Direccion = txtboxDireccionAlumno.Text;
            nuevoAlumno.tarjetaCredito = txtboxTarjetaAlumno.Text;
            nuevoAlumno.Telefono = txtboxTelefonoAlumno.Text;
            nuevoAlumno.DNI = txtboxDNIAlumno.Text;
            nuevoAlumno.idAlumno = int.Parse(txtboxIDAlumno.Text);

            principal = new Principal();
            List<Alumno> miLista = instanciaPrincipal.ValidarAlumno();
            principal.RellenarListas();
            principal.AltaAlumno(nuevoAlumno);
            Form2 fmr = new Form2();
            fmr.Show();
            this.Hide();
        }
    }
}
