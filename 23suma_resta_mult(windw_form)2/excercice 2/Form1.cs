using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excercice_2
{
    public partial class Form1 : Form
    {
        // para que pueda usar las variables sin tener que declraarlas cada vez se ponen aquiarribda del public 
        //se construyen y se destruyen hasta que cierras  el programa 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, x2, resultado; // locals variables 
            x1 = Convert.ToInt32(textBox1.Text);
            x2 = Convert.ToInt32(textBox2.Text);
            resultado = x1 + x2;
            textBox3.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resta_Click(object sender, EventArgs e)
        {
            int x1, x2, resultado;
            x1 = Convert.ToInt32(textBox1.Text);
            x2 = Convert.ToInt32(textBox2.Text);
            resultado = x1 - x2;
            textBox3.Text = resultado.ToString();
            //la practica es de variables y locales 
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            int x1, x2, resultado;
            x1 = Convert.ToInt32(textBox1.Text);
            x2 = Convert.ToInt32(textBox2.Text);
            resultado = x1 * x2;
            textBox3.Text = resultado.ToString();
            sumarnumeros.Width = 40;
            this.BackColor = Color.Purple;

        }
    }
}
