using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			

			Form6 main = new Form6();
			main.FormClosed += MainFOrm_Closed;
			main.Show();
			Application.Run();
		}

		private static void MainFOrm_Closed(object sender, FormClosedEventArgs e)
		{
			((Form)sender).FormClosed -= MainFOrm_Closed;

			if (Application.OpenForms.Count == 0)
			{
				Application.ExitThread();
			}
			else
			{
				Application.OpenForms[0].FormClosed += MainFOrm_Closed;
			}
		}
	}
}
