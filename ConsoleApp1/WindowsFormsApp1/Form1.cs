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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
        private bool validarUsuario(string nombre, string contraseña)
        {
            return (nombre == "Matias") && (contraseña == "cacho");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Length > 0)
            {
                // ARREGLAR if (validarUsuario(textUsuario.Text.Trim(), textContraseña.Text.Trim)));


                MessageBox.Show("Hola, esta por ingresar al sistema señor:" + textUsuario.Text);
            }

            else
            {
                MessageBox.Show("pone algo en el usuario invesil");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
