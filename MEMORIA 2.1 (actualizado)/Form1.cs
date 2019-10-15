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
    public partial class FormM : Form
    {
        string Primera = "";
        string Segunda = "";
        int PrimeraImagen = 0;
        int SegundaImagen = 0;
        int CuentaFallo = 0;
        int CuentaVictoria = 0;
        public string[] vector = new string[24];
        private bool banGirar = false;


        public FormM()
        {
            InitializeComponent();
        }



        private void FormM_Load(object sender, EventArgs e)
        {

            string Ruta = "C:\\PRIMATON\\foto\\2.JPG";
            PbImagen1.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen2.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen3.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen4.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen5.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen6.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen7.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen8.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen9.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen10.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen11.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen12.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen13.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen14.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen15.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen16.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen17.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen18.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen19.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen20.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen21.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen22.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen23.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen24.Image = System.Drawing.Image.FromFile(Ruta);
            Repartir();

            BordesRedondeados.BordeRedondo(btnSalir);
            lbllntentos.Text = CuentaFallo.ToString();



        }
        private void Repartir()
        {
            for (int i = 0; i < 24; i++)
            {
                vector[i] = "";
            }
            int Contador = 0;
            string Ruta = "";
            Random aleatorio = new Random();
            //cargo la imagen 1
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I1.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I2.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I3.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I4.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I5.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            //FUNCIONA
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I6.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I7.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I8.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I9.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I10.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I11.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }
            Contador = 0;
            while (Contador < 2)
            {
                Ruta = "C:\\PRIMATON\\foto\\I12.ICO";
                int numero = aleatorio.Next(0, 24);
                for (int i = 0; i < 24; i++)
                {
                    if (vector[numero] == "")
                    {
                        vector[numero] = Ruta;
                        Contador = Contador + 1;
                    }
                }
            }

        }

        private void OcultarPrimeraImagen(int indice)
        {
            

            string Ruta = "C:\\PRIMATON\\foto\\2.JPG";
            switch (indice)
            {
                case 1:
                    PbImagen1.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 2:
                    PbImagen2.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 3:
                    PbImagen3.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 4:
                    PbImagen4.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 5:
                    PbImagen5.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 6:
                    PbImagen6.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 7:
                    PbImagen7.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 8:
                    PbImagen8.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 9:
                    PbImagen9.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 10:
                    PbImagen10.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 11:
                    PbImagen11.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 12:
                    PbImagen12.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 13:
                    PbImagen13.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 14:
                    PbImagen14.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 15:
                    PbImagen15.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 16:
                    PbImagen16.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 17:
                    PbImagen17.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 18:
                    PbImagen18.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 19:
                    PbImagen19.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 20:
                    PbImagen20.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 21:
                    PbImagen21.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 22:
                    PbImagen22.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 23:
                    PbImagen23.Image = System.Drawing.Image.FromFile(Ruta);
                    break;
                case 24:
                    PbImagen24.Image = System.Drawing.Image.FromFile(Ruta);
                    break;


            }
        }

        private void RevelarTodas() {
            PbImagen1.Image = System.Drawing.Image.FromFile(vector[0]);
            PbImagen2.Image = System.Drawing.Image.FromFile(vector[1]);
            PbImagen3.Image = System.Drawing.Image.FromFile(vector[2]);
            PbImagen4.Image = System.Drawing.Image.FromFile(vector[3]);
            PbImagen5.Image = System.Drawing.Image.FromFile(vector[4]);
            PbImagen6.Image = System.Drawing.Image.FromFile(vector[5]);
            PbImagen7.Image = System.Drawing.Image.FromFile(vector[6]);
            PbImagen8.Image = System.Drawing.Image.FromFile(vector[7]);
            PbImagen9.Image = System.Drawing.Image.FromFile(vector[8]);
            PbImagen10.Image = System.Drawing.Image.FromFile(vector[9]);
            PbImagen11.Image = System.Drawing.Image.FromFile(vector[10]);
            PbImagen12.Image = System.Drawing.Image.FromFile(vector[11]);
            PbImagen13.Image = System.Drawing.Image.FromFile(vector[12]);
            PbImagen14.Image = System.Drawing.Image.FromFile(vector[13]);
            PbImagen15.Image = System.Drawing.Image.FromFile(vector[14]);
            PbImagen16.Image = System.Drawing.Image.FromFile(vector[15]);
            PbImagen17.Image = System.Drawing.Image.FromFile(vector[16]);
            PbImagen18.Image = System.Drawing.Image.FromFile(vector[17]);
            PbImagen19.Image = System.Drawing.Image.FromFile(vector[18]);
            PbImagen20.Image = System.Drawing.Image.FromFile(vector[19]);
            PbImagen21.Image = System.Drawing.Image.FromFile(vector[20]);
            PbImagen22.Image = System.Drawing.Image.FromFile(vector[21]);
            PbImagen23.Image = System.Drawing.Image.FromFile(vector[22]);
            PbImagen24.Image = System.Drawing.Image.FromFile(vector[23]);


            PbImagen1.Enabled = false;
            PbImagen2.Enabled = false;
            PbImagen3.Enabled = false;
            PbImagen4.Enabled = false;
            PbImagen5.Enabled = false;
            PbImagen6.Enabled = false;
            PbImagen7.Enabled = false;
            PbImagen8.Enabled = false;
            PbImagen9.Enabled = false;
            PbImagen10.Enabled = false;
            PbImagen11.Enabled = false;
            PbImagen12.Enabled = false;
            PbImagen13.Enabled = false;
            PbImagen14.Enabled = false;
            PbImagen15.Enabled = false;
            PbImagen16.Enabled = false;
            PbImagen17.Enabled = false;
            PbImagen18.Enabled = false;
            PbImagen19.Enabled = false;
            PbImagen20.Enabled = false;
            PbImagen21.Enabled = false;
            PbImagen22.Enabled = false;
            PbImagen23.Enabled = false;
            PbImagen24.Enabled = false;

            MessageBox.Show("Perdiste");

        }
        private void PbImagen1_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen1.Image = System.Drawing.Image.FromFile(vector[0]);
            if (Primera == "")
            {
                Primera = vector[0];
                PrimeraImagen = 1;
            }
            else
            {
                Segunda = vector[0];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();

                    SegundaImagen = 1;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";

                }

            }
        }
        private void PbImagen2_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen2.Image = System.Drawing.Image.FromFile(vector[1]);
            if (Primera == "")
            {
                Primera = vector[1];
                PrimeraImagen = 2;
            }
            else
            {
                Segunda = vector[1];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();

                    SegundaImagen = 2;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen3_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen3.Image = System.Drawing.Image.FromFile(vector[2]);
            if (Primera == "")
            {
                Primera = vector[2];
                PrimeraImagen = 3;
            }
            else
            {
                Segunda = vector[2];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 3;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen4_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen4.Image = System.Drawing.Image.FromFile(vector[3]);
            if (Primera == "")
            {
                Primera = vector[3];
                PrimeraImagen = 4;
            }
            else
            {
                Segunda = vector[3];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 4;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen5_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen5.Image = System.Drawing.Image.FromFile(vector[4]);
            if (Primera == "")
            {
                Primera = vector[4];
                PrimeraImagen = 5;
            }
            else
            {
                Segunda = vector[4];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 5;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen6_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen6.Image = System.Drawing.Image.FromFile(vector[5]);
            if (Primera == "")
            {
                Primera = vector[5];
                PrimeraImagen = 6;
            }
            else
            {
                Segunda = vector[5];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 6;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen7_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen7.Image = System.Drawing.Image.FromFile(vector[6]);
            if (Primera == "")
            {
                Primera = vector[6];
                PrimeraImagen = 7;
            }
            else
            {
                Segunda = vector[6];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 7;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen8_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen8.Image = System.Drawing.Image.FromFile(vector[7]);
            if (Primera == "")
            {
                Primera = vector[7];
                PrimeraImagen = 8;
            }
            else
            {
                Segunda = vector[7];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 8;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen9_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen9.Image = System.Drawing.Image.FromFile(vector[8]);
            if (Primera == "")
            {
                Primera = vector[8];
                PrimeraImagen = 9;
            }
            else
            {
                Segunda = vector[8];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 9;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen10_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen10.Image = System.Drawing.Image.FromFile(vector[9]);
            if (Primera == "")
            {
                Primera = vector[9];
                PrimeraImagen = 10;
            }
            else
            {
                Segunda = vector[9];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 10;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen11_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen11.Image = System.Drawing.Image.FromFile(vector[10]);
            if (Primera == "")
            {
                Primera = vector[10];
                PrimeraImagen = 11;
            }
            else
            {
                Segunda = vector[10];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 11;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen12_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen12.Image = System.Drawing.Image.FromFile(vector[11]);
            if (Primera == "")
            {
                Primera = vector[11];
                PrimeraImagen = 12;
            }
            else
            {
                Segunda = vector[11];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 12;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }

        private void PbImagen13_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen13.Image = System.Drawing.Image.FromFile(vector[12]);
            if (Primera == "")
            {
                Primera = vector[12];
                PrimeraImagen = 13;
            }
            else
            {
                Segunda = vector[12];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 13;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen14_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen14.Image = System.Drawing.Image.FromFile(vector[13]);
            if (Primera == "")
            {
                Primera = vector[13];
                PrimeraImagen = 14;
            }
            else
            {
                Segunda = vector[13];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 14;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen15_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen15.Image = System.Drawing.Image.FromFile(vector[14]);
            if (Primera == "")
            {
                Primera = vector[14];
                PrimeraImagen = 15;
            }
            else
            {
                Segunda = vector[14];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 15;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }

        private void PbImagen16_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen16.Image = System.Drawing.Image.FromFile(vector[15]);
            if (Primera == "")
            {
                Primera = vector[15];
                PrimeraImagen = 16;
            }
            else
            {
                Segunda = vector[15];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 16;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }


        private void PbImagen17_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen17.Image = System.Drawing.Image.FromFile(vector[16]);
            if (Primera == "")
            {
                Primera = vector[16];
                PrimeraImagen = 17;
            }
            else
            {
                Segunda = vector[16];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 17;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }

        private void PbImagen18_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen18.Image = System.Drawing.Image.FromFile(vector[17]);
            if (Primera == "")
            {
                Primera = vector[17];
                PrimeraImagen = 18;
            }
            else
            {
                Segunda = vector[17];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 18;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }

        private void PbImagen19_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen19.Image = System.Drawing.Image.FromFile(vector[18]);
            if (Primera == "")
            {
                Primera = vector[18];
                PrimeraImagen = 19;
            }
            else
            {
                Segunda = vector[18];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 19;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen20_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen20.Image = System.Drawing.Image.FromFile(vector[19]);
            if (Primera == "")
            {
                Primera = vector[19];
                PrimeraImagen = 20;
            }
            else
            {
                Segunda = vector[19];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 20;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen21_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen21.Image = System.Drawing.Image.FromFile(vector[20]);
            if (Primera == "")
            {
                Primera = vector[20];
                PrimeraImagen = 21;
            }
            else
            {
                Segunda = vector[20];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 21;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen22_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen22.Image = System.Drawing.Image.FromFile(vector[21]);
            if (Primera == "")
            {
                Primera = vector[21];
                PrimeraImagen = 22;
            }
            else
            {
                Segunda = vector[21];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 22;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen23_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen23.Image = System.Drawing.Image.FromFile(vector[22]);
            if (Primera == "")
            {
                Primera = vector[22];
                PrimeraImagen = 23;
            }
            else
            {
                Segunda = vector[22];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 23;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }
        private void PbImagen24_Click(object sender, EventArgs e)
        {
            if (banGirar)
            {
                OcultarPrimeraImagen(PrimeraImagen);
                OcultarPrimeraImagen(SegundaImagen);
                banGirar = false;
            }
            PbImagen24.Image = System.Drawing.Image.FromFile(vector[23]);
            if (Primera == "")
            {
                Primera = vector[23];
                PrimeraImagen = 24;
            }
            else
            {
                Segunda = vector[23];
                if (Primera == Segunda)
                {

                    //son iguales
                    Primera = "";
                    Segunda = "";
                    CuentaFallo -= 2;
                    CuentaVictoria += 1;
                }
                else
                {
                    CuentaFallo++; if (CuentaFallo == 12) { RevelarTodas(); }
                    lbllntentos.Text = CuentaFallo.ToString();
                    SegundaImagen = 24;
                    banGirar = true;
                    Primera = "";
                    Segunda = "";
                }

            }
        }

        private void Ganador ()
        {
            if (CuentaVictoria == 12)
            {
                MessageBox.Show("Ganador");
            }
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {

            string Ruta = "C:\\PRIMATON\\foto\\2.JPG";
            PbImagen1.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen2.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen3.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen4.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen5.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen6.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen7.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen8.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen9.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen10.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen11.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen12.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen13.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen14.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen15.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen16.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen17.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen18.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen19.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen20.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen21.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen22.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen23.Image = System.Drawing.Image.FromFile(Ruta);
            PbImagen24.Image = System.Drawing.Image.FromFile(Ruta);
            Repartir();

            CuentaFallo = 0;
            CuentaVictoria = 0;
            lbllntentos.Text = "0";

            PbImagen1.Enabled = true;
            PbImagen2.Enabled = true;
            PbImagen3.Enabled = true;
            PbImagen4.Enabled = true;
            PbImagen5.Enabled = true;
            PbImagen6.Enabled = true;
            PbImagen7.Enabled = true;
            PbImagen8.Enabled = true;
            PbImagen9.Enabled = true;
            PbImagen10.Enabled = true;
            PbImagen11.Enabled = true;
            PbImagen12.Enabled = true;
            PbImagen13.Enabled = true;
            PbImagen14.Enabled = true;
            PbImagen15.Enabled = true;
            PbImagen16.Enabled = true;
            PbImagen17.Enabled = true;
            PbImagen18.Enabled = true;
            PbImagen19.Enabled = true;
            PbImagen20.Enabled = true;
            PbImagen21.Enabled = true;
            PbImagen22.Enabled = true;
            PbImagen23.Enabled = true;
            PbImagen24.Enabled = true;


        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
