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
    public partial class Form1 : Form
    
{
        SoundPlayer menuu = new SoundPlayer(Application.StartupPath + @"\prro\menuu.wav"); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(1);

            if (progressBar1.Value == 10)
            {
                label2.Text = "10 %";
                label3.Text = "ready? ";
            }
            if (progressBar1.Value == 20)
            {
                label2.Text = "20 %";
                label3.Text = "every thing is going to be ready ";
            }
            if (progressBar1.Value == 30)
            {
                label2.Text = "30 %";
                label3.Text = "preparing the game ";
            }
            if (progressBar1.Value == 40)
            {
                label2.Text = "40 %";
                label3.Text = "charging texturas like in maicraft  ";
            }
            if (progressBar1.Value == 50)
            {
                label2.Text = "50 %";
                label3.Text = "preparing characters ";
            }
            if (progressBar1.Value == 60)
            {
                label2.Text = "60 %";
                label3.Text = " please wait ";
            }
            if (progressBar1.Value == 70)
            {
                label2.Text = "70 %";
                label3.Text = "there goes this papu ";
            }
            if (progressBar1.Value == 80)
            {
                label2.Text = "80 %";
                label3.Text = "oh yea dude ";
            }
            if (progressBar1.Value == 90)
            {
                label2.Text = "90 %";
                label3.Text = "almost finish this ";
                label2.Text = "100 %";
            }
            if (progressBar1.Value == 100)
            {
                menuu.Stop();
                //label2.Text = "100 %";
                label3.Text = "READY!! ";
                Form2 form2 = new Form2();
                
              //  this.Hide();
                timer1.Stop();
                form2.Show();
                
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer menuu = new SoundPlayer(Application.StartupPath + @"\prro\menuu.wav"); ;
            menuu.Play();
            label3.Text = "hello";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
