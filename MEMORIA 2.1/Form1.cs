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
		int PrimeraImagen =0;
		public string[] vector = new string[24];
		public FormM()
		{
			InitializeComponent();
		}

		private void FormM_Load(object sender, EventArgs e)
		{
			string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
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
				Ruta = "E:\\PRIMATON\\foto\\I1.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I2.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I3.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I4.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I5.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I6.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I7.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I8.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I9.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I10.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I11.ICO";
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
				Ruta = "E:\\PRIMATON\\foto\\I12.ICO";
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
			string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
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
		private void PbImagen1_Click(object sender, EventArgs e)
		{
			PbImagen1.Image = System.Drawing.Image.FromFile(vector[0]);
			if (Primera =="")
			{
				Primera = vector[0];
				PrimeraImagen = 1;
			}
			else
			{
				Segunda  = vector[0];
				if (Primera == Segunda )
				{
					//son iguales
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen1.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}		

		private void PbImagen2_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen2.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen3_Click(object sender, EventArgs e)
		{
			PbImagen3.Image = System.Drawing.Image.FromFile(vector[2]);
			if(Primera == "")
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen3.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen4_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen4.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen5_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen5.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}


		}

		private void PbImagen6_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen6.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}


		}

		private void PbImagen7_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen7.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}


		}

		private void PbImagen8_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen8.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}


		}

		private void PbImagen9_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen9.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen10_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen10.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen11_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen11.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen12_Click(object sender, EventArgs e)
		{
			PbImagen12.Image = System.Drawing.Image.FromFile(vector[11]);
			if (Primera == "")
			{
				Primera = vector[11];
				PrimeraImagen = 12;
			}
			else
			{
				Segunda = vector[2];
				if (Primera == Segunda)
				{
					//son iguales
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen12.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen13_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen13.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen14_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen14.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen15_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen15.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen16_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen16.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen17_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen17.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen18_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen18.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen19_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen19.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}
		
		private void PbImagen20_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen19.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen21_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen21.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen22_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen22.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen23_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen23.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}

		private void PbImagen24_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					//no son iguales debo girar la foto
					string Ruta = "E:\\PRIMATON\\foto\\2.JPG";
					PbImagen24.Image = System.Drawing.Image.FromFile(Ruta);
					OcultarPrimeraImagen(PrimeraImagen);
				}
				Primera = "";
				Segunda = "";
			}
		}
	}
}
