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
	public partial class Form4 : Form
	{

		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");
		public Form4()
		{
			InitializeComponent();
		}

		private void btnActualizar4_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarProductos", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registrop", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvProducto4.DataSource = tabla;

			ora.Close();
		}

		private void btnActualizar41_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarPedidoPlato", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvPedidoPlato.DataSource = tabla;
			ora.Close();

		}

		private void btnVolver4_Click(object sender, EventArgs e)
		{
			Form formulario = new Form1();
			formulario.Show();
			this.Close();
		}
	}
}
