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
            // voy  a llamar a la clase de persitsencia par que me devuelva la lista de alumnos 
            List<Alumno> miLista = instanciaPrincipal.ValidarAlumno();
            // ahor que tengo  la lista, se la tiro a la grilla para que la muestre
            dg_Alumno.DataSource = miLista;
            dg_Alumno.Refresh();

        }



        private void dg_Profesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_Alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            fmr.Show();
        }

        private void botonGuardarGrilla_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.idAlumno = 1;
            alumno.tarjetaCredito = "2123718";
            alumno.Direccion = "sunchales";
            alumno.Email = "dou@dou.com";
            alumno.DNI = "43433433";
            alumno.Nombre = "Eduardo";
            instanciaPrincipal.AltaAlumno(alumno);
        }

        private void botonModificarAlumno_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4();
            fmr.Show();
        }
    }
}
