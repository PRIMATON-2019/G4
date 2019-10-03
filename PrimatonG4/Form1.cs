using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PrimatonG4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            var loginDni = txtDni.Text;
            var loginClave = txtContrasenia.Text;
            var encontrado = Users.login(loginDni, loginClave);
            if(encontrado != null) 
            {
                Form2 Juego = new Form2();
                Juego.Show();
            }
            else 
            {
                MessageBox.Show("Controla de haber ingresado bien tu DNI o tu contraseña");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro Registrarse = new frmRegistro();
            this.Hide();
            Registrarse.ShowDialog();
            this.Show();
        }
    }
}
