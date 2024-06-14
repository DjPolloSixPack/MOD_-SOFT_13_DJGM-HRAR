using MySql.Data.MySqlClient;
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
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Close();
        }

        private void btnRPGua_Click(object sender, EventArgs e)
        {
            //Capturar los valores de los textbox
            String codigo = txtRPCod.Text;
            String nombre = txtRPNom.Text;
            String descripcion = txtRPDes.Text;
            double precio = double.Parse(txtRPPre.Text);
            int existencias = int.Parse(txtRPExi.Text);

            string sql = "INSERT INTO productos (Codigo, Nombre, Descripcion, Precio, Existencias)" + "VALUES ('" +codigo+ "', '" +nombre+ "', '" +descripcion+ "', '" +precio+ "', '" +existencias+ "')";

            //Instancia a la clase con conexion
            MySqlConnection con = Conexion.conexion();
            con.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro almacenado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al almacenar " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRPBus_Click(object sender, EventArgs e)
        {
            String codigo = txtRPCod.Text;
            MySqlDataReader reader = null;

            String sql = "SELECT IdProductos, Codigo, Nombre, Descripcion, Precio, Existencias FROM productos WHERE Codigo LIKE '" + codigo + "' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();

            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtRPNom.Text = reader.GetString(2);
                        txtRPDes.Text = reader.GetString(3);
                        txtRPPre.Text = reader.GetString(4);
                        txtRPExi.Text = reader.GetString(5);
                        txtRPId.Text = reader.GetString(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros con ese codigo");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnRPMod_Click(object sender, EventArgs e)
        {
            //capturar los valores del los textbox
            String id = txtRPId.Text;
            String codigo = txtRPCod.Text;
            String nombre = txtRPNom.Text;
            String descripcion = txtRPDes.Text;
            double precio = double.Parse(txtRPPre.Text);
            int existencias = int.Parse(txtRPExi.Text);

            string sql = "UPDATE productos SET Codigo='" + codigo + "', Nombre='" + nombre + "' , Descripcion='" + descripcion + "', Precio='" + precio + "', Existencias='" + existencias + "' WHERE IdProductos= '" + id + "'";


            //instancia a la clase de conexion
            MySqlConnection con = Conexion.conexion();
            con.Open();

            try
            {
                //comprobar que se guarda en la BD
                MySqlCommand command = new MySqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Regitro Modificado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnRPEli_Click(object sender, EventArgs e)
        {
            String codigo = txtRPCod.Text;
            MySqlConnection con = Conexion.conexion();
            con.Open();
            String sql = "DELETE FROM productos WHERE Codigo = '" + codigo + "'";

            try
            {
                MySqlCommand command = new MySqlCommand(sql, con);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registro eliminado");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No existe un registro con ese código");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void LimpiarCampos()
        {
            txtRPCod.Text = "";
            txtRPNom.Text = "";
            txtRPDes.Text = "";
            txtRPPre.Text = "";
            txtRPExi.Text = "";
            txtRPId.Text = "";
        }
        private void btnRPLim_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
