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

        

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro Registrarse = new frmRegistro();
            this.Hide();
            Registrarse.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BordesRedondeados.BorderRedondoButton(btnJugar);
        }

        private void TxtJugador_Enter(object sender, EventArgs e)
        {
            if (txtJugador.Text == "JUGADOR")
            {
                txtJugador.Text = "";
            }
        }

        private void TxtJugador_Leave(object sender, EventArgs e)
        {
            if (txtJugador.Text == "")
            {
                txtJugador.Text = "JUGADOR";
            }
        }
    }
}
