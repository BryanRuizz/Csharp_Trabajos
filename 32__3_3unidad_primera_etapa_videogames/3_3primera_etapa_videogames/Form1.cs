using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3primera_etapa_videogames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // si la presion es en la tecla s
            if (e.KeyCode == Keys.S) 
            {// se actualiza la location en nuevo punto  de x y Y
                pictureBox1.Location = new Point (pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            
            }
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);

            }
            if (e.KeyCode == Keys.D)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10 , pictureBox1.Location.Y );

            }
            if (e.KeyCode == Keys.A)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X -10, pictureBox1.Location.Y );

            }

            label3.Text =pictureBox1.Location.X.ToString();
            label4.Text = pictureBox1.Location.Y.ToString();

            if (pictureBox1.Location.X == 100) 
            {
                MessageBox.Show("oh yea prro ");
            }

            this.Width = 500;
        }
    }
}
// la propiedad location te indica donde empiezo a dibujar un objeto (plano carteciuano invertido) evento keypress

//el keyypress es mas para objetos que te dejan escribir en ellos 

//keydown es para objetos que no te dejan escribir     
