namespace Rest
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConectar = new System.Windows.Forms.Button();
			this.dgvPersonas = new System.Windows.Forms.DataGridView();
			this.btnCargar = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtActCont = new System.Windows.Forms.TextBox();
			this.txtActNom = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.txtElimId = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnProductos = new System.Windows.Forms.Button();
			this.btnProveedor = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnCocina = new System.Windows.Forms.Button();
			this.btnBodega = new System.Windows.Forms.Button();
			this.btnFinanzas = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConectar
			// 
			this.btnConectar.Location = new System.Drawing.Point(23, 31);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(75, 23);
			this.btnConectar.TabIndex = 0;
			this.btnConectar.Text = "CONECTAR";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// dgvPersonas
			// 
			this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPersonas.Location = new System.Drawing.Point(23, 111);
			this.dgvPersonas.Name = "dgvPersonas";
			this.dgvPersonas.Size = new System.Drawing.Size(339, 181);
			this.dgvPersonas.TabIndex = 1;
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(286, 78);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(75, 23);
			this.btnCargar.TabIndex = 2;
			this.btnCargar.Text = "CARGAR";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(242, 323);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(75, 23);
			this.btnInsertar.TabIndex = 3;
			this.btnInsertar.Text = "INSERTAR";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(118, 311);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 4;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(118, 340);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(100, 20);
			this.txtContrasena.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtActCont);
			this.panel1.Controls.Add(this.txtActNom);
			this.panel1.Controls.Add(this.txtId);
			this.panel1.Controls.Add(this.btnActualizar);
			this.panel1.Location = new System.Drawing.Point(394, 111);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 181);
			this.panel1.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(68, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "Ingrese ID de la persona";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(68, 115);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Ingrese nueva contraseña";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(68, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Ingrese nuevo nombre";
			// 
			// txtActCont
			// 
			this.txtActCont.Location = new System.Drawing.Point(205, 108);
			this.txtActCont.Name = "txtActCont";
			this.txtActCont.Size = new System.Drawing.Size(100, 20);
			this.txtActCont.TabIndex = 7;
			// 
			// txtActNom
			// 
			this.txtActNom.Location = new System.Drawing.Point(205, 66);
			this.txtActNom.Name = "txtActNom";
			this.txtActNom.Size = new System.Drawing.Size(100, 20);
			this.txtActNom.TabIndex = 2;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(205, 25);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 1;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(122, 146);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(100, 23);
			this.btnActualizar.TabIndex = 0;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(429, 73);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(258, 32);
			this.label1.TabIndex = 7;
			this.label1.Text = "Actualizar datos mediante ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(37, 73);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(243, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "Información de los empleados";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.UseCompatibleTextRendering = true;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(23, 309);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(89, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Nombre:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.UseCompatibleTextRendering = true;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(23, 337);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(89, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Contraseña:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.UseCompatibleTextRendering = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightCoral;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtElimId);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Location = new System.Drawing.Point(763, 111);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(301, 181);
			this.panel2.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Ingrese Id a Eliminar";
			// 
			// txtElimId
			// 
			this.txtElimId.Location = new System.Drawing.Point(155, 29);
			this.txtElimId.Name = "txtElimId";
			this.txtElimId.Size = new System.Drawing.Size(100, 20);
			this.txtElimId.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(119, 131);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 0;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(783, 73);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(258, 32);
			this.label5.TabIndex = 12;
			this.label5.Text = "Eliminar datos mediante ID";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.UseCompatibleTextRendering = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.label10.Location = new System.Drawing.Point(309, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(501, 26);
			this.label10.TabIndex = 13;
			this.label10.Text = "ADMINISTRACION DE DATOS DE EMPLEADOS";
			// 
			// btnProductos
			// 
			this.btnProductos.Location = new System.Drawing.Point(1027, 415);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(105, 23);
			this.btnProductos.TabIndex = 14;
			this.btnProductos.Text = "PRODUCTOS";
			this.btnProductos.UseVisualStyleBackColor = true;
			this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
			// 
			// btnProveedor
			// 
			this.btnProveedor.Location = new System.Drawing.Point(913, 415);
			this.btnProveedor.Name = "btnProveedor";
			this.btnProveedor.Size = new System.Drawing.Size(105, 23);
			this.btnProveedor.TabIndex = 15;
			this.btnProveedor.Text = "PROVEEDORES";
			this.btnProveedor.UseVisualStyleBackColor = true;
			this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Crimson;
			this.btnCerrar.Location = new System.Drawing.Point(1057, 14);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 16;
			this.btnCerrar.Text = "CERRAR";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnCocina
			// 
			this.btnCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
			this.btnCocina.Location = new System.Drawing.Point(763, 415);
			this.btnCocina.Name = "btnCocina";
			this.btnCocina.Size = new System.Drawing.Size(95, 23);
			this.btnCocina.TabIndex = 17;
			this.btnCocina.Text = "Adm Cocina";
			this.btnCocina.UseVisualStyleBackColor = true;
			this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
			// 
			// btnBodega
			// 
			this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
			this.btnBodega.Location = new System.Drawing.Point(662, 415);
			this.btnBodega.Name = "btnBodega";
			this.btnBodega.Size = new System.Drawing.Size(95, 23);
			this.btnBodega.TabIndex = 18;
			this.btnBodega.Text = "Adm Bodega";
			this.btnBodega.UseVisualStyleBackColor = true;
			this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
			// 
			// btnFinanzas
			// 
			this.btnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
			this.btnFinanzas.Location = new System.Drawing.Point(516, 415);
			this.btnFinanzas.Name = "btnFinanzas";
			this.btnFinanzas.Size = new System.Drawing.Size(105, 23);
			this.btnFinanzas.TabIndex = 19;
			this.btnFinanzas.Text = "Adm Finanzas";
			this.btnFinanzas.UseVisualStyleBackColor = true;
			this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 450);
			this.Controls.Add(this.btnFinanzas);
			this.Controls.Add(this.btnBodega);
			this.Controls.Add(this.btnCocina);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnProveedor);
			this.Controls.Add(this.btnProductos);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.btnCargar);
			this.Controls.Add(this.dgvPersonas);
			this.Controls.Add(this.btnConectar);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.DataGridView dgvPersonas;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtActCont;
		private System.Windows.Forms.TextBox txtActNom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtElimId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnProductos;
		private System.Windows.Forms.Button btnProveedor;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnCocina;
		private System.Windows.Forms.Button btnBodega;
		private System.Windows.Forms.Button btnFinanzas;
	}
}

