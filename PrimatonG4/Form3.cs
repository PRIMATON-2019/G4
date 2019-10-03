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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = txtNombreApellido.Text;
            alumno.password = txtPassword.Text;
            alumno.documento = txtDni.Text;
            alumno.school = cmbEscuela.SelectedItem.ToString();
            alumno.course = cmbCurso.SelectedItem.ToString();
            alumno.nota = "";
            if (validarCampos()) 
            {
                Users.registrar(alumno);
                this.Hide();
            }
            
        }

        private Boolean validarCampos() 
        {
            if (txtDni.TextLength != 8)
            {
                MessageBox.Show("El DnI Debe Tener 8 digitos");
                return false;
            }
            return true;
        }
    }
}
