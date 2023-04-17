using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
     
        int uni1 = 0, uni2 = 0, uni3 = 0, uni4 = 0, uni5 = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            int u1, u2, u3, u4, u5;
            int prom;
            string nom, apellido;
            u1 = Convert.ToInt32(textBox3.Text);
            u2 = Convert.ToInt32(textBox4.Text);
            u3 = Convert.ToInt32(textBox5.Text);
            u4 = Convert.ToInt32(textBox6.Text);
            u5 = Convert.ToInt32(textBox7.Text);

            prom = (u1 + u2 + u3 + u4 + u5) / 5;

            //textBox8.Text = prom.ToString();

            nom = textBox1.Text;

            //textBox8.Text = nom;

            apellido = textBox2.Text;

           // textBox8.Text = "el alumno "+ nom+" "+ apellido +" "+"tiene de resultado :"+ prom;
           if (prom >= 90)
           {
               textBox8.BackColor = Color.Green;
               textBox8.Text = "EL ALUMNO " + nom + " " + apellido + " " + "TIENE DE PROMEDIO :" + prom;
           }

           if (prom >=80 && prom <90)
           {
               textBox8.BackColor = Color.Yellow;
               textBox8.Text = "EL ALUMNO " + nom + " " + apellido + " " + "TIENE DE PROMEDIO :" + prom;
           }
           if(prom < 80)
            {
                textBox8.BackColor = Color.Red;
                textBox8.Text = "EL ALUMNO " + nom + " " + apellido + " " + " TIENE DE PROMEDIO :" + prom;
            }

           this.BackColor = Color.Blue;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox8.BackColor = Color.White;
            this.BackColor = Color.White;
        }
    }
}
