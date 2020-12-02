namespace Rest
{
	partial class Form5
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnInsertarProd5 = new System.Windows.Forms.Button();
			this.txtStockProd5 = new System.Windows.Forms.TextBox();
			this.txtNomProd5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnEliminarProd5 = new System.Windows.Forms.Button();
			this.txtEliminarProd5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnGuardar5 = new System.Windows.Forms.Button();
			this.txtActStock5 = new System.Windows.Forms.TextBox();
			this.txtAtcId5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnActualizarProd5 = new System.Windows.Forms.Button();
			this.dgvProducto5 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnActualizarProv5 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvProveedores5 = new System.Windows.Forms.DataGridView();
			this.btnVolver5 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto5)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(478, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(461, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Módulo de Administración de Bodega";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnInsertarProd5);
			this.panel1.Controls.Add(this.txtStockProd5);
			this.panel1.Controls.Add(this.txtNomProd5);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.btnActualizarProd5);
			this.panel1.Controls.Add(this.dgvProducto5);
			this.panel1.Location = new System.Drawing.Point(33, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(866, 378);
			this.panel1.TabIndex = 1;
			// 
			// btnInsertarProd5
			// 
			this.btnInsertarProd5.Location = new System.Drawing.Point(195, 337);
			this.btnInsertarProd5.Name = "btnInsertarProd5";
			this.btnInsertarProd5.Size = new System.Drawing.Size(88, 23);
			this.btnInsertarProd5.TabIndex = 9;
			this.btnInsertarProd5.Text = "INSERTAR";
			this.btnInsertarProd5.UseVisualStyleBackColor = true;
			this.btnInsertarProd5.Click += new System.EventHandler(this.btnInsertarProd5_Click);
			// 
			// txtStockProd5
			// 
			this.txtStockProd5.Location = new System.Drawing.Point(169, 296);
			this.txtStockProd5.Name = "txtStockProd5";
			this.txtStockProd5.Size = new System.Drawing.Size(100, 20);
			this.txtStockProd5.TabIndex = 8;
			// 
			// txtNomProd5
			// 
			this.txtNomProd5.Location = new System.Drawing.Point(169, 253);
			this.txtNomProd5.Name = "txtNomProd5";
			this.txtNomProd5.Size = new System.Drawing.Size(100, 20);
			this.txtNomProd5.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(18, 260);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Ingrese nuevo nombre";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Ingrese nuevo stock";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.LightCoral;
			this.panel4.Controls.Add(this.btnEliminarProd5);
			this.panel4.Controls.Add(this.txtEliminarProd5);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(494, 238);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(350, 122);
			this.panel4.TabIndex = 4;
			// 
			// btnEliminarProd5
			// 
			this.btnEliminarProd5.Location = new System.Drawing.Point(139, 84);
			this.btnEliminarProd5.Name = "btnEliminarProd5";
			this.btnEliminarProd5.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarProd5.TabIndex = 2;
			this.btnEliminarProd5.Text = "ELIMINAR";
			this.btnEliminarProd5.UseVisualStyleBackColor = true;
			this.btnEliminarProd5.Click += new System.EventHandler(this.btnEliminarProd5_Click);
			// 
			// txtEliminarProd5
			// 
			this.txtEliminarProd5.Location = new System.Drawing.Point(192, 38);
			this.txtEliminarProd5.Name = "txtEliminarProd5";
			this.txtEliminarProd5.Size = new System.Drawing.Size(100, 20);
			this.txtEliminarProd5.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ingrese id a eliminar";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel3.Controls.Add(this.btnGuardar5);
			this.panel3.Controls.Add(this.txtActStock5);
			this.panel3.Controls.Add(this.txtAtcId5);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(494, 24);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(350, 183);
			this.panel3.TabIndex = 3;
			// 
			// btnGuardar5
			// 
			this.btnGuardar5.Location = new System.Drawing.Point(129, 143);
			this.btnGuardar5.Name = "btnGuardar5";
			this.btnGuardar5.Size = new System.Drawing.Size(85, 23);
			this.btnGuardar5.TabIndex = 4;
			this.btnGuardar5.Text = "ACTUALIZAR";
			this.btnGuardar5.UseVisualStyleBackColor = true;
			this.btnGuardar5.Click += new System.EventHandler(this.btnGuardar5_Click);
			// 
			// txtActStock5
			// 
			this.txtActStock5.Location = new System.Drawing.Point(203, 70);
			this.txtActStock5.Name = "txtActStock5";
			this.txtActStock5.Size = new System.Drawing.Size(100, 20);
			this.txtActStock5.TabIndex = 3;
			// 
			// txtAtcId5
			// 
			this.txtAtcId5.Location = new System.Drawing.Point(203, 33);
			this.txtAtcId5.Name = "txtAtcId5";
			this.txtAtcId5.Size = new System.Drawing.Size(100, 20);
			this.txtAtcId5.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ingrese nuevo stock";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ingrese Id del producto";
			// 
			// btnActualizarProd5
			// 
			this.btnActualizarProd5.Location = new System.Drawing.Point(195, 213);
			this.btnActualizarProd5.Name = "btnActualizarProd5";
			this.btnActualizarProd5.Size = new System.Drawing.Size(88, 23);
			this.btnActualizarProd5.TabIndex = 2;
			this.btnActualizarProd5.Text = "ACTUALIZAR";
			this.btnActualizarProd5.UseVisualStyleBackColor = true;
			this.btnActualizarProd5.Click += new System.EventHandler(this.btnActualizarProd5_Click);
			// 
			// dgvProducto5
			// 
			this.dgvProducto5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducto5.Location = new System.Drawing.Point(21, 24);
			this.dgvProducto5.Name = "dgvProducto5";
			this.dgvProducto5.Size = new System.Drawing.Size(452, 183);
			this.dgvProducto5.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label2.Location = new System.Drawing.Point(352, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Producto";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnActualizarProv5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dgvProveedores5);
			this.panel2.Location = new System.Drawing.Point(918, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(458, 309);
			this.panel2.TabIndex = 2;
			// 
			// btnActualizarProv5
			// 
			this.btnActualizarProv5.Location = new System.Drawing.Point(193, 213);
			this.btnActualizarProv5.Name = "btnActualizarProv5";
			this.btnActualizarProv5.Size = new System.Drawing.Size(91, 23);
			this.btnActualizarProv5.TabIndex = 3;
			this.btnActualizarProv5.Text = "ACTUALIZAR";
			this.btnActualizarProv5.UseVisualStyleBackColor = true;
			this.btnActualizarProv5.Click += new System.EventHandler(this.btnActualizarProv5_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(189, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Proveedor";
			// 
			// dgvProveedores5
			// 
			this.dgvProveedores5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProveedores5.Location = new System.Drawing.Point(26, 57);
			this.dgvProveedores5.Name = "dgvProveedores5";
			this.dgvProveedores5.Size = new System.Drawing.Size(410, 150);
			this.dgvProveedores5.TabIndex = 0;
			// 
			// btnVolver5
			// 
			this.btnVolver5.Location = new System.Drawing.Point(12, 12);
			this.btnVolver5.Name = "btnVolver5";
			this.btnVolver5.Size = new System.Drawing.Size(88, 23);
			this.btnVolver5.TabIndex = 3;
			this.btnVolver5.Text = "VOLVER";
			this.btnVolver5.UseVisualStyleBackColor = true;
			this.btnVolver5.Click += new System.EventHandler(this.btnVolver5_Click);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1399, 520);
			this.Controls.Add(this.btnVolver5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "Form5";
			this.Text = "Form5";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto5)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvProducto5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvProveedores5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnActualizarProd5;
		private System.Windows.Forms.Button btnActualizarProv5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardar5;
		private System.Windows.Forms.TextBox txtActStock5;
		private System.Windows.Forms.TextBox txtAtcId5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnEliminarProd5;
		private System.Windows.Forms.TextBox txtEliminarProd5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnInsertarProd5;
		private System.Windows.Forms.TextBox txtStockProd5;
		private System.Windows.Forms.TextBox txtNomProd5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnVolver5;
	}
}