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
using System.Drawing.Printing;
using System.Drawing;

namespace Rest
{
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD=123; USER ID = proy;");

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarMovcaja", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvMostrarMovCaja.DataSource = tabla;

			ora.Close();


		}

		private void btnMostrar2_Click(object sender, EventArgs e)
		{
			ora.Open();
			OracleCommand comando = new OracleCommand("seleccionarHistorialMov", ora);
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvHistorialMov.DataSource = tabla;

			ora.Close();
		}

		private void btnImprimir1_Click(object sender, EventArgs e)
		{
			PrintDocument doc = new PrintDocument();
			doc.DefaultPageSettings.Landscape = true;
			doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

			PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
			((Form)ppd).WindowState = FormWindowState.Maximized;

			doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
			{
				const int DGV_ALTO = 35;
				int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

				foreach (DataGridViewColumn col in dgvMostrarMovCaja.Columns)
				{
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 8, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+15;

					if(col.Index < dgvMostrarMovCaja.ColumnCount-1 )
					{
						ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvMostrarMovCaja.RowCount - 1) * DGV_ALTO);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right + left, 3);
				top += 43;

				foreach (DataGridViewRow row in dgvMostrarMovCaja.Rows)
				{
					if (row.Index == dgvMostrarMovCaja.RowCount - 1) break;
					left = ep.MarginBounds.Left;
					foreach (DataGridViewCell cell in row.Cells)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 8), Brushes.Black, left, top + 4);
						left += cell.OwningColumn.Width+15;
					}
					top += DGV_ALTO;
					ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

				}


			};
			ppd.ShowDialog();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			ExportarDatos(dgvMostrarMovCaja);
		}

		public void ExportarDatos(DataGridView datalistado)
		{
			Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

			exportarexcel.Application.Workbooks.Add(true);

			int indicecolumna = 0;

			foreach (DataGridViewColumn column in datalistado.Columns)
			{
				indicecolumna++;

				exportarexcel.Cells[1, indicecolumna] = column.Name;
			}

			int indicefila = 0;
			foreach (DataGridViewRow row in datalistado.Rows)
			{
				indicefila++;
				indicecolumna = 0;
				foreach (DataGridViewColumn column in datalistado.Columns)
				{
					indicecolumna++;
					exportarexcel.Cells[indicefila + 1, indicecolumna] = row.Cells[column.Name].Value;
				}
			}

			exportarexcel.Visible = true;

		}

		private void btnExcel2_Click(object sender, EventArgs e)
		{
			ExportarDatos(dgvHistorialMov);
		}

		private void btnImprimir2_Click(object sender, EventArgs e)
		{
			PrintDocument doc = new PrintDocument();
			doc.DefaultPageSettings.Landscape = true;
			doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

			PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
			((Form)ppd).WindowState = FormWindowState.Maximized;

			doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
			{
				const int DGV_ALTO = 35;
				int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

				foreach (DataGridViewColumn col in dgvHistorialMov.Columns)
				{
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 8, FontStyle.Bold), Brushes.DeepSkyBlue, left+1, top);
					left += col.Width+15;

					if (col.Index < dgvHistorialMov.ColumnCount - 1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvHistorialMov.RowCount - 1) * DGV_ALTO);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right + left, 3);
				top += 43;

				foreach (DataGridViewRow row in dgvHistorialMov.Rows)
				{
					if (row.Index == dgvHistorialMov.RowCount - 1) break;
					left = ep.MarginBounds.Left;
					foreach (DataGridViewCell cell in row.Cells)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 8), Brushes.Black, left+1, top + 4);
						left += cell.OwningColumn.Width+15;
					}
					top += DGV_ALTO;
					ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

				}


			};
			ppd.ShowDialog();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			Form formulario = new Form1();
			formulario.Show();
			this.Close();
		}
	}
}
