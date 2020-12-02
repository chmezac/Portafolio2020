namespace Rest
{
	partial class Form7
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprimir1 = new System.Windows.Forms.Button();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.dgvMostrarMovCaja = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnImprimir2 = new System.Windows.Forms.Button();
			this.btnMostrar2 = new System.Windows.Forms.Button();
			this.dgvHistorialMov = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnExcel2 = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMovCaja)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMov)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExcel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnImprimir1);
			this.panel1.Controls.Add(this.btnMostrar);
			this.panel1.Controls.Add(this.dgvMostrarMovCaja);
			this.panel1.Location = new System.Drawing.Point(127, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 426);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(158, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Movimientos de Caja";
			// 
			// btnImprimir1
			// 
			this.btnImprimir1.Location = new System.Drawing.Point(372, 379);
			this.btnImprimir1.Name = "btnImprimir1";
			this.btnImprimir1.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir1.TabIndex = 4;
			this.btnImprimir1.Text = "IMPRIMIR";
			this.btnImprimir1.UseVisualStyleBackColor = true;
			this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(172, 356);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar.TabIndex = 1;
			this.btnMostrar.Text = "MOSTRAR";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// dgvMostrarMovCaja
			// 
			this.dgvMostrarMovCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMostrarMovCaja.Location = new System.Drawing.Point(16, 41);
			this.dgvMostrarMovCaja.Name = "dgvMostrarMovCaja";
			this.dgvMostrarMovCaja.Size = new System.Drawing.Size(411, 286);
			this.dgvMostrarMovCaja.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnExcel2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnImprimir2);
			this.panel2.Controls.Add(this.btnMostrar2);
			this.panel2.Controls.Add(this.dgvHistorialMov);
			this.panel2.Location = new System.Drawing.Point(650, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(452, 426);
			this.panel2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.Location = new System.Drawing.Point(146, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Historial de Ingresos y Gastos";
			// 
			// btnImprimir2
			// 
			this.btnImprimir2.Location = new System.Drawing.Point(374, 379);
			this.btnImprimir2.Name = "btnImprimir2";
			this.btnImprimir2.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir2.TabIndex = 3;
			this.btnImprimir2.Text = "IMPRIMIR";
			this.btnImprimir2.UseVisualStyleBackColor = true;
			this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
			// 
			// btnMostrar2
			// 
			this.btnMostrar2.Location = new System.Drawing.Point(195, 356);
			this.btnMostrar2.Name = "btnMostrar2";
			this.btnMostrar2.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar2.TabIndex = 2;
			this.btnMostrar2.Text = "MOSTRAR";
			this.btnMostrar2.UseVisualStyleBackColor = true;
			this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
			// 
			// dgvHistorialMov
			// 
			this.dgvHistorialMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorialMov.Location = new System.Drawing.Point(23, 41);
			this.dgvHistorialMov.Name = "dgvHistorialMov";
			this.dgvHistorialMov.Size = new System.Drawing.Size(404, 286);
			this.dgvHistorialMov.TabIndex = 1;
			// 
			// btnExcel
			// 
			this.btnExcel.BackColor = System.Drawing.Color.YellowGreen;
			this.btnExcel.Location = new System.Drawing.Point(372, 350);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(75, 23);
			this.btnExcel.TabIndex = 6;
			this.btnExcel.Text = "EXCEL";
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnExcel2
			// 
			this.btnExcel2.BackColor = System.Drawing.Color.YellowGreen;
			this.btnExcel2.Location = new System.Drawing.Point(374, 350);
			this.btnExcel2.Name = "btnExcel2";
			this.btnExcel2.Size = new System.Drawing.Size(75, 23);
			this.btnExcel2.TabIndex = 7;
			this.btnExcel2.Text = "EXCEL";
			this.btnExcel2.UseVisualStyleBackColor = false;
			this.btnExcel2.Click += new System.EventHandler(this.btnExcel2_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(12, 12);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(75, 23);
			this.btnVolver.TabIndex = 2;
			this.btnVolver.Text = "VOLVER";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 450);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form7";
			this.Text = "Form7";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMovCaja)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMov)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImprimir1;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.DataGridView dgvMostrarMovCaja;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnImprimir2;
		private System.Windows.Forms.Button btnMostrar2;
		private System.Windows.Forms.DataGridView dgvHistorialMov;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button btnExcel2;
		private System.Windows.Forms.Button btnVolver;
	}
}