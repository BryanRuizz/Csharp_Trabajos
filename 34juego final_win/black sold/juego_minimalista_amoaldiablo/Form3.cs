using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_minimalista_amoaldiablo
{
    public partial class Form3 : Form
    {
        
        Image[] sprites = new Image[12];
        bool izq, der, salto;
        int alto = 33, gravedad;
        int x = 0;
        int y = 0;
        int xx = 0;
        int yy= 0;
        int w = 0;
        int z = 0;
        int a = 0;
        int b = 0;
        Point nolaterales;
        string direccion = "derecha";
        int contmovimiento = 0;
        int contadortimer = 0;
        //  int contavidas = 2;
        //  bool item = true;
        // Form2 = new int(vi);
        internal static int vidas = 3;
        public Form3()
        {
            InitializeComponent();
            label3.Text = vidas.ToString();
            x =  muerte.Location.X;
           y = muerte.Location.Y;
            xx = final.Location.X;
            yy = final.Location.Y;
            w = suelodemuerte.Location.X;
            z = suelodemuerte.Location.Y;
            a = l.Location.X;
            b = l.Location.Y;

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
            if (contadortimer % 4 == 0)
            {
                contmovimiento++;
            }



            if (contmovimiento == 12)
            {
                contmovimiento = 0;
            }
            contadortimer++;

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = vidas.ToString();
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
            if (l.Top + l.Height >= this.Height)// validamos el piso y el cuadrito recordando que se construye de la ezquina izquierda
            {
                l.Top = this.Height - l.Height;
                salto = false;
            }
            else//nose
            {
                l.Top += 5;//baja
            }
            //*******************************************************************************************************************
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
            //**********************************
        
            if (l.Left + l.Width - 1 > plataforma1.Left && l.Left + l.Width + 5 < plataforma1.Left + plataforma1.Width + l.Width
                && l.Top + l.Height >= plataforma1.Top && l.Top < plataforma1.Top)
            {
                l.Top = plataforma1.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma1.Bounds) && l.Right >= plataforma1.Left && l.Left <= plataforma1.Right)
            {
                salto = false;

            }

            if (l.Left + l.Width - 1 > plataforma2.Left && l.Left + l.Width + 5 < plataforma2.Left + plataforma2.Width + l.Width
                && l.Top + l.Height >= plataforma2.Top && l.Top < plataforma2.Top)
            {
                l.Top = plataforma2.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma2.Bounds) && l.Right >= plataforma2.Left && l.Left <= plataforma2.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma3.Left && l.Left + l.Width + 5 < plataforma3.Left + plataforma3.Width + l.Width
              && l.Top + l.Height >= plataforma3.Top && l.Top < plataforma3.Top)
            {
                l.Top = plataforma3.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
                suelodemuerte.Location = new Point(w, z);
                label4.Visible = true;
                label4.Text = "si caes moriras";
            }
            if (l.Bounds.IntersectsWith(plataforma3.Bounds) && l.Right >= plataforma3.Left && l.Left <= plataforma3.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma4.Left && l.Left + l.Width + 5 < plataforma4.Left + plataforma4.Width + l.Width
            && l.Top + l.Height >= plataforma4.Top && l.Top < plataforma4.Top)
            {
                l.Top = plataforma4.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma4.Bounds) && l.Right >= plataforma4.Left && l.Left <= plataforma4.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma5.Left && l.Left + l.Width + 5 < plataforma5.Left + plataforma5.Width + l.Width
           && l.Top + l.Height >= plataforma5.Top && l.Top < plataforma5.Top)
            {
                l.Top = plataforma5.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma5.Bounds) && l.Right >= plataforma5.Left && l.Left <= plataforma5.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma6.Left && l.Left + l.Width + 5 < plataforma6.Left + plataforma6.Width + l.Width
        && l.Top + l.Height >= plataforma6.Top && l.Top < plataforma6.Top)
            {
                l.Top = plataforma6.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma6.Bounds) && l.Right >= plataforma6.Left && l.Left <= plataforma6.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma7.Left && l.Left + l.Width + 5 < plataforma7.Left + plataforma7.Width + l.Width
     && l.Top + l.Height >= plataforma7.Top && l.Top < plataforma7.Top)
            {
                l.Top = plataforma7.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma7.Bounds) && l.Right >= plataforma7.Left && l.Left <= plataforma7.Right)
            {
                salto = false;

            }
            if (l.Left + l.Width - 1 > plataforma8.Left && l.Left + l.Width + 5 < plataforma8.Left + plataforma8.Width + l.Width
   && l.Top + l.Height >= plataforma8.Top && l.Top < plataforma8.Top)
            {
                l.Top = plataforma8.Location.Y - l.Height;
                gravedad = 0;
                salto = false;
            }
            if (l.Bounds.IntersectsWith(plataforma8.Bounds) && l.Right >= plataforma8.Left && l.Left <= plataforma8.Right)
            {
                salto = false;

            }
            if (l.Bounds.IntersectsWith(pseudofinal.Bounds))
            {

                label4.Visible = false;
                this.Controls.Remove(this.plataforma1);
                this.Controls.Remove(this.plataforma2);
                this.Controls.Remove(this.plataforma3);
                this.Controls.Remove(this.plataforma4);
                this.Controls.Remove(this.plataforma5);
                this.Controls.Remove(this.plataforma6);
                this.Controls.Remove(this.plataforma7);
                this.Controls.Remove(this.pseudofinal);

                label1.Text = "jump ";
                plataforma1.Left = 0;
                plataforma2.Left = 0;
                plataforma3.Left = 0;
                plataforma4.Left = 0;
                plataforma5.Left = 0;
                plataforma6.Left = 0;
                plataforma7.Left = 0;

                muerte.Location = new Point(x, y);
                // muerte.BackColor = Color.Red;
                final.Location = new Point(xx,yy);
            
             
            }
            if (l.Bounds.IntersectsWith(muerte.Bounds))
            {
                muerte.Image = juego_minimalista_amoaldiablo.Properties.Resources.gokumuerto;
                System.Threading.Thread.Sleep(100);
                this.Controls.Remove(this.l);

            }
            if (l.Bounds.IntersectsWith(final.Bounds))
            {
             

                Form4 form4 = new Form4();
               
                this.Hide();
                timer1.Stop();
                MessageBox.Show("u win");
                form4.Show();
               
            }
            if (l.Bounds.IntersectsWith(suelodemuerte.Bounds))
            {
              
                vidas--;
                if (vidas == 2)
                {
                    l.Left = 7;
                    l.Top = 450;
                    l.Location = new Point(a, b);
                }
                if (vidas == 1)
                {
                    l.Left = 7;
                    l.Top = 450;
                    l.Location = new Point(a, b);
                }
                if (vidas == 0)
                {
                    timer1.Stop();

                    this.Close();


                }

            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            suelodemuerte.Location = new Point(-600, -600);
           // label3.Text = vidas.ToString();
            muerte.Location =new Point(-555,-555);
            final.Location = new Point(-544,-655);
            timer1.Start();
            label4.Visible = false;

        }
    }
}
