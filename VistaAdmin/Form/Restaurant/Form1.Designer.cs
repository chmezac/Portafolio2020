namespace Restaurant
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApePat = new System.Windows.Forms.TextBox();
			this.txtApeMat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
			this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtId = new System.Windows.Forms.ToolStripTextBox();
			this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "ID Numero";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(204, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(207, 150);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 10;
			// 
			// txtApePat
			// 
			this.txtApePat.Location = new System.Drawing.Point(38, 254);
			this.txtApePat.Name = "txtApePat";
			this.txtApePat.Size = new System.Drawing.Size(100, 20);
			this.txtApePat.TabIndex = 11;
			// 
			// txtApeMat
			// 
			this.txtApeMat.Location = new System.Drawing.Point(207, 253);
			this.txtApeMat.Name = "txtApeMat";
			this.txtApeMat.Size = new System.Drawing.Size(100, 20);
			this.txtApeMat.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Apellido Paterno";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(207, 225);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Apellido Materno";
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(131, 314);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 15;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtId,
            this.tsbBuscar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(347, 25);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// tsbNuevo
			// 
			this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
			this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNuevo.Name = "tsbNuevo";
			this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
			this.tsbNuevo.Text = "Nuevo";
			this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click_1);
			// 
			// tsbGuardar
			// 
			this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
			this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGuardar.Name = "tsbGuardar";
			this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
			this.tsbGuardar.Text = "toolStripButton2";
			this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
			// 
			// tsbCancelar
			// 
			this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
			this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCancelar.Name = "tsbCancelar";
			this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
			this.tsbCancelar.Text = "toolStripButton3";
			this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
			// 
			// tsbEliminar
			// 
			this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
			this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEliminar.Name = "tsbEliminar";
			this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
			this.tsbEliminar.Text = "toolStripButton4";
			this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
			this.toolStripLabel1.Text = "Buscar Por ID:";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbBuscar
			// 
			this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
			this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBuscar.Name = "tsbBuscar";
			this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
			this.tsbBuscar.Text = "toolStripButton5";
			this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 365);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtApeMat);
			this.Controls.Add(this.txtApePat);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtId;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
    }
}

