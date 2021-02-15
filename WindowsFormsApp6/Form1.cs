using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private int[] tablero;
        private int[] puestos;
        private int[] estados;
        private int contadorClick = 0;
        private int primeraFoto = 0;
        private int segundaFoto = 0;
        private int primer_clic = 0;
        private int segundo_clic = 0;

        public Form1()
        {
            InitializeComponent();
            tablero = new int[16];
            for (int i=0; i<16;i++)
            {
                tablero[i] = 0;
            }
            puestos = new int[8];
            for (int i=0;i<8;i++)
            {
                puestos[i] = 0;
            }
            estados = new int[16];
            for (int i=0;i<16;i++)
            {
                estados[i] = 0;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Funcion que se ejecuta antes de salir el formulario por 
        // la pantalla.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Voy a establecer la imagen de los picturebox
            // con una imagen por defecto "defecto.jpg";
            for (int i=0;i<16;i++)
            {
                por_defecto(i);
            }
            groupBox1.Enabled = false;
        }

        
        private void por_defecto(int numero)
        {
            switch (numero)
            {
                case 0:
                    {
                        pictureBox1.ImageLocation = "../../img/portada.jpg";
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 1:
                    {
                        pictureBox2.ImageLocation = "../../img/portada.jpg";
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 2:
                    {
                        pictureBox3.ImageLocation = "../../img/portada.jpg";
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 3:
                    {
                        pictureBox4.ImageLocation = "../../img/portada.jpg";
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 4:
                    {
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox5.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 5:
                    {
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox6.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 6:
                    {
                        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox7.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 7:
                    {
                        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox8.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 8:
                    {
                        pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox9.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 9:
                    {
                        pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox10.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 10:
                    {
                        pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox11.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 11:
                    {
                        pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox12.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 12:
                    {
                        pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox13.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 13:
                    {
                        pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox14.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 14:
                    {
                        pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox15.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
                case 15:
                    {
                        pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox16.ImageLocation = "../../img/portada.jpg";
                        break;
                    }
            }
        }
        
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Rellenar el array con numeros entre el 1 y 8 pero con la 
            // condicion de que solo pueden aparecer 2 veces cada número.
            int contador = 0;
            bool salir = false;
            Random aleatorios = new Random(System.DateTime.Now.Millisecond);
            int numero = 0;
            int contador1 = 0;
            do
            {
                salir = false;
                do
                {
                    numero = aleatorios.Next(0, 8);
                    if (puestos[numero]<2)
                    {
                        //Puedo insertarlo.
                        puestos[numero]++;
                        tablero[contador1] = numero;
                        contador1++;
                        salir = true;
                    }

                } while (!salir);
                contador++;
            } while (contador != 16);
            groupBox1.Enabled = true;
        }

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
                {
                    if (estados[i] == 1)
                    {
                        por_defecto(i);
                       
                }
            }
            
                timer1.Stop();
            //MessageBox.Show(contadorClick.ToString());

        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            if (tablero[primer_clic] == tablero[segundo_clic])
            {
                estados[primer_clic] = -1;
                estados[primer_clic] = -1;


            }else if (tablero[primer_clic] != tablero[primer_clic])
            {
                por_defecto(primer_clic);
                por_defecto(segundo_clic);
                estados[primer_clic] = 0;
                estados[primer_clic] = 0;
            }
            //MessageBox.Show(contadorClick.ToString());

            contadorClick = 0;
            timer2.Stop();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void poner_imagen(PictureBox p, int [] t,int n)
        {
            switch (t[n])
            {
                case 0:
                    {
                        p.ImageLocation = "../../Img/1.jpg";
                        break;
                    }
                case 1:
                    {
                        p.ImageLocation = "../../Img/2.jpg";
                        break;
                    }
                case 2:
                    {
                        p.ImageLocation = "../../Img/3.jpg";
                        break;
                    }
                case 3:
                    {
                        p.ImageLocation = "../../Img/4.jpg";
                        break;
                    }
                case 4:
                    {
                        p.ImageLocation = "../../Img/5.jpg";
                        break;
                    }
                case 5:
                    {
                        p.ImageLocation = "../../Img/6.jpg";
                        break;
                    }
                case 6:
                    {
                        p.ImageLocation = "../../Img/7.jpg";
                        break;
                    }
                case 7:
                    {
                        p.ImageLocation = "../../Img/8.jpg";
                        break;
                    }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (estados[0]==0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[0] = 1;
                poner_imagen(pictureBox1, tablero,0);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(0);
                estados[0] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[0];
                primer_clic = 0;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[0];
                segundo_clic = 0;
                timer2.Start();
            }
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (estados[1] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[1] = 1;
                poner_imagen(pictureBox2, tablero,1);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(1);
                estados[1] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[1];
                primer_clic = 1;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[1];
                segundo_clic = 1;
                timer2.Start();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (estados[2] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[2] = 1;
                poner_imagen(pictureBox3, tablero,2);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(2);
                estados[2] = 0;
            }

            if (contadorClick == 1)
            {
                primeraFoto = tablero[2];
                primer_clic = 2;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[2];
                segundo_clic = 2;
                timer2.Start();
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (estados[3] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[3] = 1;
                poner_imagen(pictureBox4, tablero,3);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(3);
                estados[3] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[3];
                primer_clic = 3;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[3];
                segundo_clic = 3;
                timer2.Start();
            }
        }

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (estados[4] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[4] = 1;
                poner_imagen(pictureBox5, tablero, 4);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(4);
                estados[4] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[4];
                primer_clic = 4;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[4];
                segundo_clic = 4;
                timer2.Start();
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (estados[5] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[5] = 1;
                poner_imagen(pictureBox6, tablero, 5);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(5);
                estados[5] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[5];
                primer_clic =5;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[5];
                segundo_clic = 5;              // **********hasta aqui sumar uno al primer y segundo clic*************************************************
                timer2.Start();
            }


        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (estados[6] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[6] = 1;
                poner_imagen(pictureBox7, tablero, 6);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(6);
                estados[6] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[6];
                primer_clic = 7;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[6];
                segundo_clic = 7;
                timer2.Start();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (estados[7] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[7] = 1;
                poner_imagen(pictureBox8, tablero, 7);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(7);
                estados[7] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[7];
                primer_clic = 8;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[7];
                segundo_clic = 8;
                timer2.Start();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (estados[8] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[8] = 1;
                poner_imagen(pictureBox9, tablero,8);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(8);
                estados[8] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[8];
                primer_clic = 9;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[8];
                segundo_clic = 9;
                timer2.Start();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (estados[9] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[9] = 1;
                poner_imagen(pictureBox10, tablero,9);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(9);
                estados[9] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[9];     
                primer_clic = 10;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[9];
                segundo_clic = 10;
                timer2.Start();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (estados[10] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[10] = 1;
                poner_imagen(pictureBox11, tablero,10);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(10);
                estados[10] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[10];
                primer_clic = 11;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[10];
                segundo_clic = 11;
                timer2.Start();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (estados[11] == 0)
            {
                //El picture está tapado hay que cargar imagen.7
                contadorClick++;
                estados[11] = 1;
                poner_imagen(pictureBox12, tablero, 11);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(11);
                estados[11] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[11];
                primer_clic = 12;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[11];
                segundo_clic = 12;
                timer2.Start();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (estados[12] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[12] = 1;
                poner_imagen(pictureBox13, tablero, 12);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(12);
                estados[12] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[12];
                primer_clic = 13;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[12];
                segundo_clic = 13;
                timer2.Start();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (estados[13] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[13] = 1;
                poner_imagen(pictureBox14, tablero, 13);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(13);
                estados[13] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[13];
                primer_clic = 14;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[13];
                segundo_clic = 14;
                timer2.Start();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (estados[14] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[14] = 1;
                poner_imagen(pictureBox15, tablero, 14);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(14);
                estados[14] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[14];
                primer_clic = 15;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[14];
                segundo_clic = 15;
                timer2.Start();
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (estados[15] == 0)
            {
                //El picture está tapado hay que cargar imagen.
                contadorClick++;
                estados[15] = 1;
                poner_imagen(pictureBox16, tablero, 15);
            }
            else
            {
                //El picture está mostrando imagen hay que taparlo
                por_defecto(15);
                estados[15] = 0;
            }
            if (contadorClick == 1)
            {
                primeraFoto = tablero[15];
                primer_clic = 16;
                timer1.Start();
            }
            else if (contadorClick == 2)
            {
                segundaFoto = tablero[15];
                segundo_clic = 16;
                timer2.Start();
            }
        }

       
    }
}
