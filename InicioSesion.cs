using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorBB
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = txtISUsu.Text;
            contraseña = txtISCon.Text;
            if (usuario == "Admin" && contraseña == "1234")
            {
                RegistroProducto Principal = new RegistroProducto();
                Principal.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnISSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
