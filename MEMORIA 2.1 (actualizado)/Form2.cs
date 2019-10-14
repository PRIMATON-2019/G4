using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORIA_2._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BordesRedondeados.BordeRedondo(btnJugar);
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            FormM Juego = new FormM();
            Juego.Show();
            this.Hide();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtJugador_Enter(object sender, EventArgs e)
        {
            if (txtJugador.Text == "Ingrese su nombre")
            {
                txtJugador.Text = "";
            }
        }

        private void TxtJugador_Leave(object sender, EventArgs e)
        {
            if (txtJugador.Text == "")
            {
                txtJugador.Text = "Ingrese su nombre";
            }
        }
    }
}
