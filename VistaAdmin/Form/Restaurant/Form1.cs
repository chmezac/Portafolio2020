using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class Form1 : Form
    {


        //Conexión con BBDD
        string connectionString = @"Server=.\sqlexpress;Database=Empleados;Trusted_Connection=True;";
        bool nuevo;
        

        public Form1()
        {
            InitializeComponent();
        }

        //CARGA DE FORMULARIO Y ESTADO DE ELEMENTOS
        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtApePat.Enabled = false;
            txtApeMat.Enabled = false;
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }


        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            //CARGA EL ESTADO PARA EL BOTON NUEVO
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtApePat.Enabled = true;
            txtApeMat.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //INSERCION DE DATOS
            if (nuevo)
            {
                string sql = "INSERT INTO EMPLEADO (NomPrimEmp,ApePrimEmp,ApeSecEmp)" + "VALUES ('" + txtNombre.Text + "', '" + txtApePat.Text + "' , '" + txtApeMat.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("REGISTRO INGRESADO CORRECTAMENTE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                finally
                {
                    //CERRAR CONEXION
                    con.Close();
                }
            }

            else
            {
                //ACTUALIZACION DEL REGISTRO EN BASE DE DATOS
                string sql = "UPDATE EMPLEADO SET NomPrimEmp='" + txtNombre.Text + "', ApePrimEmp='" + txtApePat.Text + "'," + "ApeSecEmp='" + txtApeMat.Text + "' WHERE IdEmp=" + txtId.Text + "";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("REGISTRO ACTUALIZADO CORRECTAMENTE MASTER!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                finally
                {
                    //CIERRO CONEXION
                    con.Close();
                }
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtApePat.Enabled = false;
            txtApeMat.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtApePat.Enabled = false;
            txtApeMat.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //SE PROICEDE A ELIMINAR SEGUN ID
            string sql = "DELETE FROM EMPLEADO WHERE IdEmp=" + txtId;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();



            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtApePat.Enabled = false;
            txtApeMat.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            //SE PROCEDE A BUSCAR EN BASE A LA ID
            string sql = "SELECT * FROM EMPLEADO WHERE IdEmp=" + txtId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();




            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    txtId.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApePat.Enabled = true;
                    txtApeMat.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtApePat.Text = reader[2].ToString();
                    txtApeMat.Text = reader[3].ToString();
                    nuevo = false;
                }

                else
                    MessageBox.Show("NINGUN REGISTRO ENCONTRADO CON EL ID INGRESADO");
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            txtId.Text = "";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
