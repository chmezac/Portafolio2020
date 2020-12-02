namespace Rest
{
	partial class Form2
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
			this.label10 = new System.Windows.Forms.Label();
			this.btnCerrar2 = new System.Windows.Forms.Button();
			this.dgvProducto = new System.Windows.Forms.DataGridView();
			this.btnActualizar2 = new System.Windows.Forms.Button();
			this.btnEmpleado2 = new System.Windows.Forms.Button();
			this.btnProveedor2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.label10.Location = new System.Drawing.Point(304, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(503, 26);
			this.label10.TabIndex = 14;
			this.label10.Text = "ADMINISTRACION DE DATOS DE PRODUCTOS";
			// 
			// btnCerrar2
			// 
			this.btnCerrar2.BackColor = System.Drawing.Color.Crimson;
			this.btnCerrar2.Location = new System.Drawing.Point(1018, 43);
			this.btnCerrar2.Name = "btnCerrar2";
			this.btnCerrar2.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar2.TabIndex = 15;
			this.btnCerrar2.Text = "CERRAR";
			this.btnCerrar2.UseVisualStyleBackColor = false;
			this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
			// 
			// dgvProducto
			// 
			this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducto.Location = new System.Drawing.Point(186, 96);
			this.dgvProducto.Name = "dgvProducto";
			this.dgvProducto.Size = new System.Drawing.Size(753, 260);
			this.dgvProducto.TabIndex = 16;
			// 
			// btnActualizar2
			// 
			this.btnActualizar2.Location = new System.Drawing.Point(500, 382);
			this.btnActualizar2.Name = "btnActualizar2";
			this.btnActualizar2.Size = new System.Drawing.Size(123, 28);
			this.btnActualizar2.TabIndex = 17;
			this.btnActualizar2.Text = "ACTUALIZAR";
			this.btnActualizar2.UseVisualStyleBackColor = true;
			this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
			// 
			// btnEmpleado2
			// 
			this.btnEmpleado2.Location = new System.Drawing.Point(1018, 405);
			this.btnEmpleado2.Name = "btnEmpleado2";
			this.btnEmpleado2.Size = new System.Drawing.Size(84, 23);
			this.btnEmpleado2.TabIndex = 18;
			this.btnEmpleado2.Text = "EMPLEADOS";
			this.btnEmpleado2.UseVisualStyleBackColor = true;
			this.btnEmpleado2.Click += new System.EventHandler(this.btnEmpleado2_Click);
			// 
			// btnProveedor2
			// 
			this.btnProveedor2.Location = new System.Drawing.Point(913, 405);
			this.btnProveedor2.Name = "btnProveedor2";
			this.btnProveedor2.Size = new System.Drawing.Size(99, 23);
			this.btnProveedor2.TabIndex = 19;
			this.btnProveedor2.Text = "PROVEEDORES";
			this.btnProveedor2.UseVisualStyleBackColor = true;
			this.btnProveedor2.Click += new System.EventHandler(this.btnProveedor2_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 450);
			this.Controls.Add(this.btnProveedor2);
			this.Controls.Add(this.btnEmpleado2);
			this.Controls.Add(this.btnActualizar2);
			this.Controls.Add(this.dgvProducto);
			this.Controls.Add(this.btnCerrar2);
			this.Controls.Add(this.label10);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnCerrar2;
		private System.Windows.Forms.DataGridView dgvProducto;
		private System.Windows.Forms.Button btnActualizar2;
		private System.Windows.Forms.Button btnEmpleado2;
		private System.Windows.Forms.Button btnProveedor2;
	}
}