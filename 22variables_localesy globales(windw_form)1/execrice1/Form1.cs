using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execrice1
{
    public partial class Form1 : Form
    {
        public Form1() //solo se ejectuta una vez
        {
            InitializeComponent();// aqui es cuando empieza a construir todos los objetos ( aparti de aqui abajo)
        }

        private void Form1_Load(object sender, EventArgs e)    // se puede ejecutar varias veces
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BRYAN ANDRES SANTILLAN RUIZ");
            button1.Width = 10;
            button1.Height = 10;
            //este en dado caso de que en la propiedad lo pusieras invisible xd o visivel false
            //button1.Visible = true;
            
            //button2.Height = 10;
            //para cambiar el nombre en tiempo de ejecucuion
            button2.Text ="NUMERO UNO"; //solo se cambia su nombre
        }
    }
}
