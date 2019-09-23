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
    public partial class Form2 : Form
    {
        // mantiene la referencia al objeto de donde se arrastra la imagen
        object ImagenOrigen; 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;

        }

        public void PresionarMouse(object sender, MouseEventArgs e)
        {
            // Objeto de origen de la imagen
            PictureBox pic = (PictureBox)sender;
            ImagenOrigen = sender;

            if (e.Button == MouseButtons.Left)// si se presiono el click izquierdo del mouse
            {
                if (pic.Image != null)// si lo que presiono no es nulo
                {
                    pic.DoDragDrop(pic.Image, DragDropEffects.Move); // hacer efecto
                }
            }
        }

        public void ArrastrarMouse(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) // si tiene datos
            {
                e.Effect = DragDropEffects.Move; // efecto de moverse
            }
            else
            {
                e.Effect = DragDropEffects.None;// sin efecto
            }
        }

        public void SoltandoArrastre(object sender, DragEventArgs e)//llegado de lo q arrastre
        {
            PictureBox pic = (PictureBox)sender; // imagen que llego
            PictureBox org = (PictureBox)ImagenOrigen; // direccion de donde viene la imagen

            if (pic.Name != org.Name) // si el nombre es distinto
            {
                pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap); // carga la imagen
                org.Image = null; // quita la imagen del origen
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PresionarMouse(sender, e);
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PresionarMouse(sender, e);
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            ArrastrarMouse(sender, e);
        }

        private void PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            ArrastrarMouse(sender, e);
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            SoltandoArrastre(sender, e);
        }

        private void PictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            SoltandoArrastre(sender, e);
        }
    }
}
