using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest
{
	public partial class Form5 : Form
	{
		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");
		public Form5()
		{
			InitializeComponent();
		}

		private void btnActualizarProd5_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarProductos", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registrop", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvProducto5.DataSource = tabla;

			ora.Close();
		}

		private void btnInsertarProd5_Click(object sender, EventArgs e)
		{
			

			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("insertarProducto", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("nombreProducto", OracleType.VarChar).Value = txtNomProd5.Text;
				comando.Parameters.Add("stockProducto", OracleType.Number).Value = Convert.ToInt32(txtStockProd5.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Producto insertado");
			}
			catch (Exception ex)
			{

				MessageBox.Show("Los datos ingresados no son correctos o ya existen");
			}
			ora.Close();
		}

		private void btnGuardar5_Click(object sender, EventArgs e)
		{
			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("actualizarProducto", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idproducto", OracleType.Number).Value = Convert.ToInt32(txtAtcId5.Text);
				comando.Parameters.Add("stockprod", OracleType.Number).Value = Convert.ToInt32(txtActStock5.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Producto Actualizado");


			}
			catch (Exception)
			{

				MessageBox.Show("Los datos ingresados no son correctos");
			}
			ora.Close();
		}

		private void btnEliminarProd5_Click(object sender, EventArgs e)
		{
			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("eliminarProducto", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idproducto", OracleType.Number).Value = Convert.ToInt32(txtEliminarProd5.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Producto Eliminado");

			}
			catch (Exception)
			{

				MessageBox.Show("La id ingresada no existe");
			}
			ora.Close();
		}

		private void btnActualizarProv5_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarProveedores", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registroprov", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvProveedores5.DataSource = tabla;

			ora.Close();
		}

		private void btnVolver5_Click(object sender, EventArgs e)
		{
			Form formulario = new Form1();
			formulario.Show();
			this.Close();
		}
	}
}
