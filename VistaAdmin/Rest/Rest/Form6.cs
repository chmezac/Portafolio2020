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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("SELECT * FROM PERSONA WHERE NOMBRE =:nombre AND CONTRASENA = :contra", ora);

			comando.Parameters.AddWithValue(":nombre", txtLogUsuario.Text);
			comando.Parameters.AddWithValue(":contra", txtLogContrasena.Text);

			OracleDataReader lector = comando.ExecuteReader();

			if(lector.Read())
			{
				Form1 Formulario = new Form1();
				ora.Close();

				Formulario.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("No se pudo ingresar, datos incorrectos");
				ora.Close();
			}
		}
	}
}
