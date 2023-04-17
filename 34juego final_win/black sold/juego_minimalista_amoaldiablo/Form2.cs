using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace juego_minimalista_amoaldiablo
{
   
    public partial class Form2 : Form
    {
        SoundPlayer lala = new SoundPlayer(Application.StartupPath + @"\prro\lele.wav"); 
        Image[] sprites = new Image[12];
        bool izq, der, salto;
        int alto = 28, gravedad;
        Point nolaterales;
        //Point puntocero;
            string direccion = "derecha";
        int contmovimiento = 0;
        int contadortimer = 0;
       internal static int vidas = 3;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            //************************************************************
           if (e.KeyCode == Keys.D)
                {
                    if (direccion == "izquierda")
                    {
                        direccion = "derecha";
                        for (int i = 0; i < 12; i++)
                        {
                            sprites[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }

                    }

                    der = true;
                     l.Image = sprites[0];
                }

           if (e.KeyCode == Keys.A)
           {
               if (direccion == "derecha")
               {
                   direccion = "izquierda";
                   for (int i = 0; i < 12; i++)
                   {
                       sprites[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                   }

               }
               izq = true;
           }
                  

            //VALIDA QUE SOLO DE UN SALTO OSEA QUE CAIGA Y PUEDA SALTAR AGAIN 


            if (salto != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    salto = true;
                    gravedad = alto;
                }
            }

            label3.Text = l.Location.X.ToString();
            label4.Text = vidas.ToString();
            //**********************************************
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                der = false;
                l.Image = sprites[0];
            }
            if (e.KeyCode == Keys.A)
            {
                izq = false;
                l.Image = sprites[0];
            }
        }

        public Form2()
        {

            InitializeComponent();
            //  puntocero.X = 7;
            //puntocero.Y = 
            vidas = 3;
           
            sprites[0] = juego_minimalista_amoaldiablo.Properties.Resources.goku1;
            sprites[1] = juego_minimalista_amoaldiablo.Properties.Resources.goku2;
            sprites[2] = juego_minimalista_amoaldiablo.Properties.Resources.goku3;
            sprites[3] = juego_minimalista_amoaldiablo.Properties.Resources.goku4;
            sprites[4] = juego_minimalista_amoaldiablo.Properties.Resources.goku5;
            sprites[5] = juego_minimalista_amoaldiablo.Properties.Resources.goku6;
            sprites[6] = juego_minimalista_amoaldiablo.Properties.Resources.goku7;
            sprites[7] = juego_minimalista_amoaldiablo.Properties.Resources.goku8;
            sprites[8] = juego_minimalista_amoaldiablo.Properties.Resources.goku9;
            sprites[9] = juego_minimalista_amoaldiablo.Properties.Resources.goku10;
            sprites[10] = juego_minimalista_amoaldiablo.Properties.Resources.goku11;
            sprites[11] = juego_minimalista_amoaldiablo.Properties.Resources.goku12;

            l.Image = sprites[1];
        }
        private void movimiento()
        {
            l.Image = sprites[contmovimiento];
            if (contadortimer % 2 == 0)
            {
                contmovimiento++;
            }



            if (contmovimiento == 12)
            {
                contmovimiento = 0;
            }
            contadortimer++;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (l.Bounds.IntersectsWith(suelo.Bounds))
            {
                vidas--;
                if (vidas == 2)
                {
                    l.Left = 7;
                    l.Top = 450;

                }
                if (vidas == 1) 
                {
                    l.Left = 7;
                    l.Top = 450;
                    
                }
                if (vidas == 0)
                {
                    timer1.Stop();
               
                    this.Close();
                    
            
                }
                
            }
            if (l.Bounds.IntersectsWith(picos.Bounds))
            {
                vidas--;
                if (vidas == 2)
                {
                    l.Left = 7;
                    l.Top = 450;

                }
                if (vidas == 1)
                {
                    l.Left = 7;
                    l.Top = 450;

                }
                if (vidas == 0)
                {
                    timer1.Stop();

                    this.Close();


                }

            }
            //*****
          
            //****************************************
            if (der == true)
            {
                l.Left += 5;
                movimiento();
            }
            if (izq == true)
            {
                l.Left -= 5;
                movimiento();
            }
            if (salto == true)// si salto es = a verdad mi objeto [(ñe)es mi cuadrito negro ].top (lo mas altohacia abajo)
            {//            recuerda que se invierte -=  y es como la caida de menos un pizel hasta llegar a su piso base 
                l.Top -= gravedad;//subeybaja
                gravedad -= 2;
            }
            //*******************************************************************************************************************
            if (l.Top + l.Height >= this.Height)// validamos el piso y el cuadrito recordando que se construye de la ezquina izquierda
            {
                l.Top = this.Height - l.Height;
                salto = false;
            }
            else//nose
            {
                l.Top += 5;//baja
            }

            //*******************************************************************************************
            nolaterales = l.Location;

            if (l.Location.X + l.Width > this.Width)
                nolaterales.X = this.Width - l.Width;
            else if (l.Location.X < 0)
                nolaterales.X = 0;

            if (l.Location.Y + l.Height > this.Height)
                nolaterales.Y = this.Height - l.Height;
            else if (l.Location.Y < 0)
                nolaterales.Y = 0;

            if (l.Location != nolaterales)
            {
                l.Location = nolaterales;
            }
            else
            {
                l.Top += 5;

            }//no sale de la forma 

            //*************************************************
            if (l.Left + l.Width - 1 > roca.Left && l.Left + l.Width + 5 < roca.Left + roca.Width + l.Width
                 && l.Top + l.Height >= roca.Top && l.Top < roca.Top)
            {
                l.Top = roca.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(roca.Bounds) && l.Right >= roca.Left && l.Left <= roca.Right)
            {
                salto = false;

            }
            
           //*********************************************ramas

            if (l.Left + l.Width - 1 > rama1.Left && l.Left + l.Width + 5 < rama1.Left + rama1.Width + l.Width
                && l.Top + l.Height >= rama1.Top && l.Top < rama1.Top) 
           {
               l.Top = rama1.Location.Y - l.Height;
               gravedad = 0;
               salto = false;
            }
            if (l.Bounds.IntersectsWith(rama1.Bounds) && l.Right >= rama1.Left && l.Left <= rama1.Right) 
            {
                salto = false;
            
            }
            //****rama2
            if (l.Left + l.Width - 1 > rama2.Left && l.Left + l.Width + 5 < rama2.Left + rama2.Width + l.Width
               && l.Top + l.Height >= rama2.Top && l.Top < rama2.Top)
            {
                l.Top = rama2.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(rama2.Bounds) && l.Right >= rama2.Left && l.Left <= rama2.Right)
            {
                salto = false;

            }
            //****rama3
            if (l.Left + l.Width - 1 > rama3.Left && l.Left + l.Width + 5 < rama3.Left + rama3.Width + l.Width
               && l.Top + l.Height >= rama3.Top && l.Top < rama3.Top)
            {
                l.Top = rama3.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(rama3.Bounds) && l.Right >= rama3.Left && l.Left <= rama3.Right)
            {
                salto = false;

            }
            //****rama4
            if (l.Left + l.Width - 1 > rama4.Left && l.Left + l.Width + 5 < rama4.Left + rama4.Width + l.Width
               && l.Top + l.Height >= rama4.Top && l.Top < rama4.Top)
            {
                l.Top = rama4.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(rama4.Bounds) && l.Right >= rama4.Left && l.Left <= rama4.Right)
            {
                salto = false;

            }
            //****rama5
            if (l.Left + l.Width - 1 > rama5.Left && l.Left + l.Width + 5 < rama5.Left + rama5.Width + l.Width
               && l.Top + l.Height >= rama5.Top && l.Top < rama5.Top)
            {
                l.Top = rama5.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(rama5.Bounds) && l.Right >= rama5.Left && l.Left <= rama5.Right)
            {
                salto = false;

            }
            //****sacate
            if (l.Left + l.Width - 1 > sacate.Left && l.Left + l.Width + 5 < sacate.Left + sacate.Width + l.Width
               && l.Top + l.Height >= sacate.Top && l.Top < sacate.Top)
            {
                l.Top = sacate.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(sacate.Bounds) && l.Right >= sacate.Left && l.Left <= sacate.Right)
            {
                salto = false;

            }
           //***tronco1
            if (l.Left + l.Width - 1 > tronco1.Left && l.Left + l.Width + 5 < tronco1.Left + tronco1.Width + l.Width
               && l.Top + l.Height >= tronco1.Top && l.Top < tronco1.Top)
            {
                l.Top = tronco1.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(tronco1.Bounds) && l.Right >= tronco1.Left && l.Left <= tronco1.Right)
            {
                salto = false;

            }
        //**tronco2
            if (l.Left + l.Width - 1 > tronco2.Left && l.Left + l.Width + 5 < tronco2.Left + tronco2.Width + l.Width
             && l.Top + l.Height >= tronco2.Top && l.Top < tronco2.Top)
            {
                l.Top = tronco2.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(tronco2.Bounds) && l.Right >= tronco2.Left && l.Left <= tronco2.Right)
            {
                salto = false;

            }
            //****nube

            if (l.Left + l.Width - 1 > nube1.Left && l.Left + l.Width + 5 < nube1.Left + nube1.Width + l.Width
             && l.Top + l.Height >= nube1.Top && l.Top < nube1.Top)
            {
                l.Top = nube1.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(nube1.Bounds) && l.Right >= nube1.Left && l.Left <= nube1.Right)
            {
                salto = false;

            }
            //****nube2

            if (l.Left + l.Width - 1 > nube2.Left && l.Left + l.Width + 5 < nube2.Left + nube2.Width + l.Width
             && l.Top + l.Height >= nube2.Top && l.Top < nube2.Top)
            {
                l.Top = nube2.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(nube2.Bounds) && l.Right >= nube2.Left && l.Left <= nube2.Right)
            {
                salto = false;

            }
            //****piso
            if (l.Left + l.Width - 1 > piso.Left && l.Left + l.Width + 5 < piso.Left + piso.Width + l.Width
        && l.Top + l.Height >= piso.Top && l.Top < piso.Top)
            {
                l.Top = piso.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(piso.Bounds) && l.Right >= piso.Left && l.Left <= piso.Right)
            {
                salto = false;

            }
            //****tronco3
            if (l.Left + l.Width - 1 > tronco3.Left && l.Left + l.Width + 5 < tronco3.Left + tronco3.Width + l.Width
        && l.Top + l.Height >= tronco3.Top && l.Top < tronco3.Top)
            {
                l.Top = tronco3.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(tronco3.Bounds) && l.Right >= tronco3.Left && l.Left <= tronco3.Right)
            {
                salto = false;

            }
            //****puente
            if (l.Left + l.Width - 1 > puente.Left && l.Left + l.Width + 5 < puente.Left + puente.Width + l.Width
        && l.Top + l.Height >= puente.Top && l.Top < puente.Top)
            {
                l.Top = puente.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(puente.Bounds) && l.Right >= puente.Left && l.Left <= puente.Right)
            {
                salto = false;

            }
            //****tronco4
            if (l.Left + l.Width - 1 > tronco4.Left && l.Left + l.Width + 5 < tronco4.Left + tronco4.Width + l.Width
        && l.Top + l.Height >= tronco4.Top && l.Top < tronco4.Top)
            {
                l.Top = tronco4.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(tronco4.Bounds) && l.Right >= tronco4.Left && l.Left <= tronco4.Right)
            {
                salto = false;

            }
            //****trozo
            if (l.Left + l.Width - 1 > trozo.Left && l.Left + l.Width + 5 < trozo.Left + trozo.Width + l.Width
        && l.Top + l.Height >= trozo.Top && l.Top < trozo.Top)
            {
                l.Top = trozo.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(trozo.Bounds) && l.Right >= trozo.Left && l.Left <= trozo.Right)
            {
                salto = false;

            }
            //****pisofinal
            if (l.Left + l.Width - 1 > PISOFINAL.Left && l.Left + l.Width + 5 < PISOFINAL.Left + PISOFINAL.Width + l.Width
        && l.Top + l.Height >= PISOFINAL.Top && l.Top < PISOFINAL.Top)
            {
                l.Top = PISOFINAL.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(PISOFINAL.Bounds) && l.Right >= PISOFINAL.Left && l.Left <= PISOFINAL.Right)
            {
                salto = false;

            }
          /*  if (l.Bounds.IntersectsWith(picos.Bounds) )
            {
                timer1.Stop();
                MessageBox.Show("valio queso");
            }*/

            if (l.Bounds.IntersectsWith(negro.Bounds))
            {
                Form3 form3 = new Form3();
            //  lala.Stop();
                 this.Hide();
                timer1.Stop();
                form3.Show();
             //   MessageBox.Show("u win");
                
               
               
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer lala = new SoundPlayer(Application.StartupPath + @"\prro\lele.wav"); ;
        lala.Play();
            timer1.Start();
        }

        private void pantalla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picos_Click(object sender, EventArgs e)
        {

        }

        private void tronco1_Click(object sender, EventArgs e)
        {

        }
    }
}
