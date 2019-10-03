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
            if (cmbEscuela.SelectedItem != null)
            {
                alumno.school = cmbEscuela.SelectedItem.ToString();
            }
            if (cmbCurso.SelectedItem != null)
            {
                alumno.course = cmbCurso.SelectedItem.ToString();
            }
            alumno.nota = "";
            if (validarCampos())
            {
                if (Users.registrar(alumno))
                {
                    MessageBox.Show("Registro de nuevo usuario con éxito", "Usuario creado");
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("El DNI ya se encuentra registrado", "ERROR");
                }
                
            }
            
        }
        //control de campos
        private Boolean validarCampos() 
        {
            if (string.IsNullOrEmpty(txtNombreApellido.Text) || string.IsNullOrEmpty(txtPassword.Text)) 
            {
                MessageBox.Show("Todos los campos deben estar completos", "REGISTRO");
                return false;
            }
            if (cmbEscuela.SelectedItem == null) 
            {
                MessageBox.Show("El campo Escuela o Curso está vacio", "Registro");
                return false;
            }
            if (txtDni.TextLength != 8)
            {
                MessageBox.Show("El Dni Debe Tener 8 digitos","REGISTRO");
                return false;
            }
            return true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
             // Verificar que la tecla presionada no sea de control u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
