using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloLogica;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Principal instanciaPrincipal = new Principal();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            instanciaPrincipal.RellenarListas();
            instanciaPrincipal.ValidarAlumno();
        }



        private void dg_Profesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_Alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.idAlumno = 1;
            alumno.tarjetaCredito = 2123718;
            alumno.Direccion = "sunchales";
            alumno.Email = "dou@dou.com";
            alumno.DNI = 43433433;
            alumno.Nombre = "Eduardo";
            instanciaPrincipal.AltaAlumno(alumno);
        }
    }
}
