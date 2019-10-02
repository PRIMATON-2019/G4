using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form2 Juego = new Form2();
            Juego.Show();
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
