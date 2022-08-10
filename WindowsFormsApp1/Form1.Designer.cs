
namespace WindowsFormsApp1
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
            this.btnAbrirChrome = new System.Windows.Forms.Button();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion1 = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Registro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirChrome
            // 
            this.btnAbrirChrome.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirChrome.Name = "btnAbrirChrome";
            this.btnAbrirChrome.Size = new System.Drawing.Size(130, 39);
            this.btnAbrirChrome.TabIndex = 0;
            this.btnAbrirChrome.Text = "Abrir Chrome";
            this.btnAbrirChrome.UseVisualStyleBackColor = true;
            this.btnAbrirChrome.Click += new System.EventHandler(this.btnAbrirChrome_Click);
            // 
            // btnNavegar
            // 
            this.btnNavegar.Location = new System.Drawing.Point(12, 57);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(130, 39);
            this.btnNavegar.TabIndex = 1;
            this.btnNavegar.Text = "Navegar";
            this.btnNavegar.UseVisualStyleBackColor = true;
            this.btnNavegar.Click += new System.EventHandler(this.btnNavegar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(18, 106);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 20);
            this.txtcontrasena.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(18, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(18, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(5, 132);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(130, 39);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtDireccion1
            // 
            this.txtDireccion1.Location = new System.Drawing.Point(18, 71);
            this.txtDireccion1.Name = "txtDireccion1";
            this.txtDireccion1.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion1.TabIndex = 9;
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.txtNombre);
            this.Registro.Controls.Add(this.txtcontrasena);
            this.Registro.Controls.Add(this.txtUsuario);
            this.Registro.Controls.Add(this.txtApellido);
            this.Registro.Controls.Add(this.btnRegistro);
            this.Registro.Location = new System.Drawing.Point(12, 114);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(141, 188);
            this.Registro.TabIndex = 10;
            this.Registro.TabStop = false;
            this.Registro.Text = "Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.txtDireccion2);
            this.groupBox1.Controls.Add(this.txtDireccion1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texbox";
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Location = new System.Drawing.Point(18, 97);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion2.TabIndex = 10;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(6, 123);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(130, 39);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.btnNavegar);
            this.Controls.Add(this.btnAbrirChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirChrome;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion1;
        private System.Windows.Forms.GroupBox Registro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtDireccion2;
    }
}

