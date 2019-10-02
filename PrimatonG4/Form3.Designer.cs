namespace PrimatonG4
{
    partial class frmRegistro
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
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblEscuela = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.cmbEscuela = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º"});
            this.cmbCurso.Location = new System.Drawing.Point(256, 200);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(253, 175);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(96, 13);
            this.lblCurso.TabIndex = 24;
            this.lblCurso.Text = "¿A que curso vas?";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Location = new System.Drawing.Point(37, 175);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(82, 13);
            this.lblEscuela.TabIndex = 23;
            this.lblEscuela.Text = "Elige tu escuela";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 13);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Escribí la Contraseña";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 76);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(104, 13);
            this.lblDni.TabIndex = 21;
            this.lblDni.Text = "Ahora escribí tu DNI";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(35, 35);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(140, 13);
            this.lblNombreApellido.TabIndex = 20;
            this.lblNombreApellido.Text = "Escribí tu Nombre y Apellido";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(216, 278);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 19;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(186, 69);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(261, 20);
            this.txtDni.TabIndex = 17;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(186, 28);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(261, 20);
            this.txtNombreApellido.TabIndex = 16;
            // 
            // cmbEscuela
            // 
            this.cmbEscuela.FormattingEnabled = true;
            this.cmbEscuela.Items.AddRange(new object[] {
            "Santiago Derqui",
            "Mariano Moreno"});
            this.cmbEscuela.Location = new System.Drawing.Point(38, 201);
            this.cmbEscuela.Name = "cmbEscuela";
            this.cmbEscuela.Size = new System.Drawing.Size(185, 21);
            this.cmbEscuela.TabIndex = 15;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 398);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblEscuela);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.cmbEscuela);
            this.Name = "frmRegistro";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblEscuela;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.ComboBox cmbEscuela;
    }
}