namespace Rest
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLogUsuario = new System.Windows.Forms.TextBox();
			this.txtLogContrasena = new System.Windows.Forms.TextBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(237, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(403, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sistema de Administracion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(257, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "Restaurant SIGLO XXI";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.Location = new System.Drawing.Point(74, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "USUARIO:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label5.Location = new System.Drawing.Point(74, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "CONTRASEÑA:";
			// 
			// txtLogUsuario
			// 
			this.txtLogUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtLogUsuario.Location = new System.Drawing.Point(79, 195);
			this.txtLogUsuario.Name = "txtLogUsuario";
			this.txtLogUsuario.Size = new System.Drawing.Size(264, 21);
			this.txtLogUsuario.TabIndex = 5;
			// 
			// txtLogContrasena
			// 
			this.txtLogContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtLogContrasena.Location = new System.Drawing.Point(79, 314);
			this.txtLogContrasena.Name = "txtLogContrasena";
			this.txtLogContrasena.Size = new System.Drawing.Size(264, 21);
			this.txtLogContrasena.TabIndex = 6;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(146, 404);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(135, 38);
			this.btnIngresar.TabIndex = 7;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Location = new System.Drawing.Point(467, 331);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 183);
			this.panel1.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Location = new System.Drawing.Point(467, 153);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(439, 172);
			this.panel2.TabIndex = 9;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(918, 526);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.txtLogContrasena);
			this.Controls.Add(this.txtLogUsuario);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form6";
			this.Text = "Form6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLogUsuario;
		private System.Windows.Forms.TextBox txtLogContrasena;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}