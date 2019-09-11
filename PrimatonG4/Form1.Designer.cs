namespace PrimatonG4
{
    partial class Form1
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
            this.panelGradiente1 = new PrimatonG4.PanelGradiente();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblTituloExtra = new System.Windows.Forms.Label();
            this.panelGradiente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Teal;
            this.panelGradiente1.Controls.Add(this.lblTituloExtra);
            this.panelGradiente1.Controls.Add(this.btnJugar);
            this.panelGradiente1.Controls.Add(this.e);
            this.panelGradiente1.Controls.Add(this.txtNombre);
            this.panelGradiente1.Controls.Add(this.lblApellido);
            this.panelGradiente1.Controls.Add(this.lblNombre);
            this.panelGradiente1.Controls.Add(this.lblTitulo);
            this.panelGradiente1.Controls.Add(this.lblExit);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(470, 520);
            this.panelGradiente1.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(429, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(29, 31);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(96, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo del Programa";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(43, 238);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(43, 276);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(95, 25);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 244);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(144, 282);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(100, 20);
            this.e.TabIndex = 5;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(158, 370);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(125, 38);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // lblTituloExtra
            // 
            this.lblTituloExtra.AutoSize = true;
            this.lblTituloExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExtra.Location = new System.Drawing.Point(43, 119);
            this.lblTituloExtra.Name = "lblTituloExtra";
            this.lblTituloExtra.Size = new System.Drawing.Size(357, 29);
            this.lblTituloExtra.TabIndex = 7;
            this.lblTituloExtra.Text = "informacion adicional o subtitulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 520);
            this.Controls.Add(this.panelGradiente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego Didactico Sierras de Cordoba";
            this.panelGradiente1.ResumeLayout(false);
            this.panelGradiente1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelGradiente panelGradiente1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloExtra;
    }
}

