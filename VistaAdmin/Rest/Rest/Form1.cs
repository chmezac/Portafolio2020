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
	public partial class Form1 : Form
	{
		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			
			ora.Open();
			MessageBox.Show("Conectado");
			ora.Close();
		}

		private void btnCargar_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarPersonas", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registros", OracleType.Cursor).Direction=ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvPersonas.DataSource = tabla;

			ora.Close();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			try
			{

				ora.Open();
				OracleCommand comando = new OracleCommand("insertar", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
				comando.Parameters.Add("cont", OracleType.VarChar).Value = txtContrasena.Text;
				comando.ExecuteNonQuery();
				MessageBox.Show("Persona insertada");
			}
			catch (Exception)
			{
				MessageBox.Show("Los datos ingresados no son correctos o ya existen");
			}
			ora.Close();
			
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{

			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("actualizar", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtId.Text);
				comando.Parameters.Add("nom", OracleType.VarChar).Value = txtActNom.Text;
				comando.Parameters.Add("cont", OracleType.VarChar).Value = txtActCont.Text;
				comando.ExecuteNonQuery();
				MessageBox.Show("Persona Actualizada");
				
			}
			catch (Exception)
			{
				MessageBox.Show("Los datos ingresados no son correctos");
			}
			ora.Close();

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				ora.Open();
				OracleCommand comando = new OracleCommand("eliminar", ora);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtElimId.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Eliminado");
			}
			catch (Exception)
			{

				MessageBox.Show("La id ingresada no existe");
			}
			ora.Close();
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			Form formulario = new Form2();
			formulario.Show();
			this.Close();

		}

		private void btnProveedor_Click(object sender, EventArgs e)
		{
			Form formulario = new Form3();
			formulario.Show();
			this.Close();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCocina_Click(object sender, EventArgs e)
		{
			Form formulario = new Form4();
			formulario.Show();
			this.Close();
		}

		private void btnBodega_Click(object sender, EventArgs e)
		{
			Form formulario = new Form5();
			formulario.Show();
			this.Close();
		}

		private void btnFinanzas_Click(object sender, EventArgs e)
		{
			Form formulario = new Form7();
			formulario.Show();
			this.Close();
		}
	}
}
