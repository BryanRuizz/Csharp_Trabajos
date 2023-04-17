using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_2_part
{
    public partial class Form1 : Form
    {

        bool izq, der, salto;
        int alto = 20, gravedad;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();  //inicia 
            timer2.Start();  //inicia 
            timer3.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  
        {
            if (e.KeyCode == Keys.D)//movimiento derecho
            {
                der = true;
            }
            if (e.KeyCode == Keys.A)// movimiento izquierdo 
            {
                izq = true;
            }
            //VALIDA QUE SOLO DE UN SALTO OSEA QUE CAIGA Y PUEDA SALTAR AGAIN 
        //    if (salto != true)
           // {
                if (e.KeyCode == Keys.Space)
                {
                    salto = true;
                    gravedad = alto;
                }
            //}
            //movimiento izq y der 
            label7.Text = elmo.Location.X.ToString();
            label8.Text = elmo.Location.Y.ToString();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                der = false;
            }
            if (e.KeyCode == Keys.A)
            {
                izq = false;
            }
            //cuando dejas de presionar las teclas izq y der 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //1er para k tope  -  para que pase la mitad y pueda sobre saltarlo no lim - pueda saltarlo por arriba 
            if (elmo.Right>bloque1.Left && elmo.Bottom>bloque1.Top && elmo.Left<bloque1.Right-elmo.Width/2) 
            {
                der = false;//no avanza por el 
          
           }

            if (elmo.Left< bloque1.Right && elmo.Bottom > bloque1.Top && elmo.Right > bloque1.Left - elmo.Width / 2)
            {
                izq = false;

            }

          
            //********************************************************************
            // para que se siga moviendo
            if (der == true)
            {
                elmo.Left += 5;
            }
            if (izq == true)
            {
                elmo.Left -= 5;
            }
            if (salto == true)// si salto es = a verdad mi objeto [(ñe)es mi cuadrito negro ].top (lo mas altohacia abajo)
            {//            recuerda que se invierte -=  y es como la caida de menos un pizel hasta llegar a su piso base 
                elmo.Top -= gravedad;//subeybaja
                gravedad -= 1;
            }

            //*******************************************************************************************************************
            //top es el fondo + la altura >= altura de panel(pantalla) que seria vdd por que la ezquina izq en corner es 0,0 

            if (elmo.Top + elmo.Height >= pantalla.Height)// validamos el piso y el cuadrito recordando que se construye de la ezquina izquierda
            {
                elmo.Top = pantalla.Height - elmo.Height;// para que se quede en la misma linea y no caiga mas abajo
                // fondo de cuadrito = altura de panel (su altura) - altura de cuadrito para que nose vaya mas abajo
                salto = false;// valida que siga saltando en panel 
            }
            else//nose
            {
                elmo.Top += 5;//baja
            }

            //*******************************************************************************************

            if (elmo.Right-1>bloque1.Left
                &&elmo.Right+5 <bloque1.Right+elmo.Width
                &&elmo.Top+elmo.Height>=bloque1.Top && elmo.Top<bloque1.Top)
            {

                elmo.Top = pantalla.Height - bloque1.Height-elmo.Height;
                gravedad = 0;
                salto = false;

            }








            if (elmo.Left + elmo.Width >= pantalla.Width)
            {
                elmo.Left = pantalla.Width - elmo.Width;
                izq = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
      
        {
             bloque1.Left += 10;

           if (bloque1.Left + bloque1.Width >= pantalla.Width) 
            {
                bloque1.Left = pantalla.Width - bloque1.Width;
                timer2.Stop();
                timer3.Start();
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bloque1.Left -= 10;
            if (bloque1.Location.X <= 0)
            {
                
                timer3.Stop();
                timer2.Start();
            }
        }





    }
}
//panel _ propiedad dock en fill 

//bordes por propiedad (para luego)
//

