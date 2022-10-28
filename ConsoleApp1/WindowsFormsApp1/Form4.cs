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
    public partial class Form4 : Form
    {
        Alumno alumnoModificado = new Alumno();
        Principal principal = new Principal();
        public Form4()
        {
            InitializeComponent();
        }
       

        private void botonGuardarMod_Click(object sender, EventArgs e)
        {
            alumnoModificado.Nombre = txtBoxNombreAlumnoMod.Text;
            alumnoModificado.Email = txtBoxEmailAlumnoMod.Text;
            alumnoModificado.Direccion = txtBoxDireccionAlumnoMod.Text;
            alumnoModificado.DNI = txtBoxDNIAlumnoMod.Text;
            alumnoModificado.idAlumno = int.Parse(txtBoxIDAlumnoMod.Text);
            alumnoModificado.tarjetaCredito = txtBoxTarjetaMod.Text;
            alumnoModificado.Telefono = txtBoxTelefonoAlumnoMod.Text;
            principal = new Principal();
            principal.RellenarListas();
            principal.ModificarAlumno(alumnoModificado);

            Form2 fmr = new Form2();
            fmr.Show();
            this.Hide();
        }

    }
}
