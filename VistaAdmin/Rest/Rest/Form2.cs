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
	public partial class Form2 : Form
	{
		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");
		public Form2()
		{
			InitializeComponent();
		}

		private void btnCerrar2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnActualizar2_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarProductos", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registrop", OracleType.Cursor).Direction= ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvProducto.DataSource = tabla;

			ora.Close();
		}

		private void btnEmpleado2_Click(object sender, EventArgs e)
		{
			Form formulario = new Form1();
			formulario.Show();
			this.Close();
		}

		private void btnProveedor2_Click(object sender, EventArgs e)
		{
			Form formulario = new Form3();
			formulario.Show();
			this.Close();
		}
	}
}
