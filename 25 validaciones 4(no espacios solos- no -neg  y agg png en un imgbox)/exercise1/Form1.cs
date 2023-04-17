using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex= 0;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            switch(comboBox1.SelectedIndex)
            {

                case 0 :
                    pictureBox1.Image = exercise1.Properties.Resources.triangulo;
                    label1.Text = comboBox1.Text;
                    label2.Text = "BASE";
                    label3.Text = "HEIGH";


                    break;


                case 1 :
                    pictureBox1.Image = exercise1.Properties.Resources.cuadradog;
                    label1.Text = comboBox1.Text;
                    label2.Text = "BASE";
                    label3.Text = "HEIGH";


                    break;


                case 2:
                    pictureBox1.Image = exercise1.Properties.Resources.hexagono;

                    label1.Text = comboBox1.Text;
                    label2.Text = "SIDE";
                    label3.Text = "APOTHEMA";



                    break;




            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1, h1, b1, p1;
            string texterros;

            texterros = "";
            if (textBox1.Text == "")// valida que si no escribist datos no te mande error
            {
                texterros += "__error ." + label2 + "invalid__";
                textBox1.BackColor = Color.Red;
            
            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error 
            {
                texterros += "__error ." + label3 + "invalid__";
                textBox2.BackColor = Color.Red;
               
            }

            if (texterros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(texterros);
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                return;
            }
            //***************************************************************************************************************************************
            b1 = Convert.ToDouble(textBox1.Text);
            h1 = Convert.ToDouble(textBox2.Text);
            p1 = Convert.ToDouble(textBox1.Text) * 6; // numero de lados por eso por 6


            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            if (b1 <= 0) 
            {
                textBox1.BackColor = Color.Red;

                texterros+= "__error ." + label2 + "invalid__";
                
            }
            if (h1 <= 0)
            {
                textBox2.BackColor = Color.Red;
                texterros+= "__error ." + label2 + "invalid___";
               
            }
            if (texterros!= "") // cuando entra a un if  por ser - y con mi var texerror se guarda y entra al != y es cuando si no es =  a "" pues manda el message 
            {
                MessageBox.Show(texterros);
                /* textBox1.Text = "";  es para regresar a 0 y colorear blanco
                textBox2.Text = "";
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;*/
                return;
            }
            //*********************************************************************************************************************************************
             switch(comboBox1.SelectedIndex)
            {
                case 0 :
                  
                       
          
            a1 = h1 * b1/2;

            textBox3.Text = a1.ToString();
                    break;
                case 1 :
            
            a1 = h1 * b1;
            textBox3.Text = a1.ToString();
                    break;
                case 2:
           
            h1 = Convert.ToDouble(textBox2.Text);

            a1 = p1*h1/2;

            textBox3.Text = a1.ToString();

                    break;
             }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//este evento es cuando presionas una tecla (cada que preciones letras no las acepte )
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // solo se permite un punto decimal y lo que agregues
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) 
            {
                e.Handled = true;
            }
        }



        // el teclado tiene 3 eventos sobre las teclas 
        // key down, key press, key up
        //cuando precionas la tecla , cuando la dejas precionada, cuando dejas de precionar


        //*********************************************************************************************************
        //enable hace que se solo lectura 
        // el radio button solo te permite uno si pones varios
        // el checkbox puedes convinarlos 


    }
}
