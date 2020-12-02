using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Rest
{
	public partial class Form3 : Form
	{
		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");
		public Form3()
		{
			InitializeComponent();
		}

		private void btnActualizar3_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarProveedores", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registroprov", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvProveedor.DataSource = tabla;

			ora.Close();
		}

		private void btnCerrar3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnInsertar3_Click(object sender, EventArgs e)
		{

			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("insertarProv", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("nomprov", OracleType.VarChar).Value = txtNombreProv.Text;
				comando.Parameters.Add("apeprov", OracleType.VarChar).Value = txtApellidoProv.Text;
				comando.Parameters.Add("fonoprov", OracleType.Number).Value = Convert.ToInt32(txtFonoProv.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Proveedor Ingresado");
			}
			catch (Exception)
			{

				MessageBox.Show("Los datos ingresados no son correctos o ya existen");
			}
			ora.Close();

			


		}

		private void btnActualizarProv_Click(object sender, EventArgs e)
		{


			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("actualizarProv", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idpr", OracleType.Number).Value = Convert.ToInt32(txtIDProv.Text);
				comando.Parameters.Add("nompr", OracleType.VarChar).Value = txtActNomProv.Text;
				comando.Parameters.Add("apepr", OracleType.VarChar).Value = txtActApeProv.Text;
				comando.Parameters.Add("fonopr", OracleType.Number).Value = Convert.ToInt32(txtActFonoProv.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("PROVEEDOR ACTUALIZADO");
			}
			catch (Exception)
			{

				MessageBox.Show("Los datos ingresados no son correctos");
			}
			ora.Close();

			


		}

		private void btnEliminarProv_Click(object sender, EventArgs e)
		{

			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("eliminarProv", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idpro", OracleType.Number).Value = Convert.ToInt32(txtEliminarProv.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("PROVEEDOR ELIMINADO");
			}
			catch (Exception)
			{

				MessageBox.Show("La id ingresada no existe");
			}
			ora.Close();
			
		}

		private void btnEmpleado3_Click(object sender, EventArgs e)
		{
			Form formulario = new Form1();
			formulario.Show();
			this.Close();
		}

		private void btnProductos3_Click(object sender, EventArgs e)
		{
			Form formulario = new Form2();
			formulario.Show();
			this.Close();
		}
	}
}
