using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;// y asi se le da valor de default
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            





            string texterros;

            texterros = "";


            if (textBox1.Text == "")// valida que si no escribist datos no te mande error  (este vacio la text box 1 ?
            {

                textBox1.BackColor = Color.Red;

                texterros += "__error ." + label1 + "invalid__";

            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error (el dos esta vacio ?
            {
                textBox2.BackColor = Color.Red;
                texterros += "__error ." + label2 + "invalid__";

            }
            if (textBox3.Text == "")// valida que si no escribist datos no te mande error  (este vacio la text box 1 ?
            {

                textBox3.BackColor = Color.Red;

                texterros += "__error ." + label3 + "invalid__";

            }

            if (textBox4.Text == "")// valida que si no escribist datos no te mande error (el dos esta vacio ?
            {
                textBox4.BackColor = Color.Red;
                texterros += "__error ." + label4 + "invalid__";

            }
            if (textBox5.Text == "")// valida que si no escribist datos no te mande error (el dos esta vacio ?
            {
                textBox5.BackColor = Color.Red;
                texterros += "__error ." + label5 + "invalid__";

            }

            if (texterros != "")  // valida que si no escribist datos no te mande error (si si tenia uno solo entra 
            {
                MessageBox.Show(texterros);
                return;     // regresa el botton hasta atras
            }
            //***************************************************************************************************************que las casillas no esten solas y pintar en rojo

            textBox1.BackColor = Color.White;
            int a, b, c, d, j;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = Convert.ToInt32(textBox4.Text);
            j = Convert.ToInt32(textBox5.Text);

            string error = "";
            if (a>3)
            {
                textBox1.BackColor = Color.DarkRed;
                error += "en n1 _ERROR/";
               
            }
            if (b > 3)
            {
                textBox2.BackColor = Color.DarkRed;
                error += "en n2 _ERROR/";
            }
            if (c > 3)
            {
                textBox3.BackColor = Color.DarkRed;
                error += "en n3 _ERROR/";
            }
            if (d > 3)
            {
                textBox4.BackColor = Color.DarkRed;
                error += "en n4 _ERROR/";
            }
            if (j > 3)
            {
                textBox5.BackColor = Color.DarkRed;
                error += "en n5 _ERROR/";
                
               
            }
            if (error != "")  // valida que si no escribist datos no te mande error (si si tenia uno solo entra 
            {
                MessageBox.Show(error);
                MessageBox.Show("only numbers of 1 to 3");
                

                textBox1.BackColor = Color.White;     //y A LAS LOS TEXTBOX LES REGRSA A BLANCO COMO INICIAL
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;

                return;     // regresa el botton hasta atras
            }

            //*********************************** hasta aqui son validaciones la de arriba es para si pones un 4 o mas no te lo acepte 
            
            string txt1, txt2, txt3, txt4, txt5, txt6,txt7;
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            txt3 = textBox3.Text;
            txt4 = textBox4.Text;
            txt5 = textBox5.Text;
            txt6 = "";
            txt7 = "";
            int add = 0, substract =0;
            
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                    add = a + b + c + d + j;
                     txt6 = "add" ;
                   txt7 = add.ToString();
                   break;
                case 1:
                   substract = a - b - c - d - j;
                   txt6 = "substract";
                   txt7 = substract.ToString();
                    break;
            }

            //***********************************************agg cosas a la grid

           


            g1.Rows.Add(txt1, txt2, txt3, txt4, txt5, txt6,txt7);


            int ac = 0;
            foreach (DataGridViewRow row1 in g1.Rows) //por cada renglon OSEA HACIA ABAJO Y DE LADITO ES COLUMN
            {

               

                ac++;
                label9.Text = ac.ToString();
            }

         






        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') // ESTO ES PARA NO LETRAS SOLO NUMEROS 
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            } 
 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') // ESTO ES PARA NO LETRAS SOLO NUMEROS 
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            } 
 
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') //ESTO ES PARA NO LETRAS SOLO NUMEROS 
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') //ESTO ES PARA NO LETRAS SOLO NUMEROS 
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            } 
 
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') // ESTO ES PARA NO LETRAS SOLO NUMEROS 
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            } 
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row1 in g1.Rows) //por cada renglon 
            {
               foreach (DataGridViewColumn col1 in g1.Columns) //por cada columna
                 {
                     string numero = g1[col1.Index, row1.Index].Value.ToString();    // puesto que el grid es todo string  abajo se iguala a 1 string
                   // si mi txtbox1 tiene one escrito y aparte en el grid string es == a 1
                   // pues entra y segun el combobox2 seleccionado en valor 0 o 1 pues sera el color 

                    // LO QUE TENGA EN TXTBX6 EX. "ONE" APARTE EL == YY A 1 DE LAS DE GRID Y ENTRA DONDE VAYA EL INDEX Y LO PINTA DEL COLOR
                    // SEGUN EL VALOR SELECTED EN COMBOBOX
                     if (textBox6.Text == "one" && numero == "1") 
                     {
                         if (comboBox2.SelectedIndex == 0)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.LightBlue;
                         }
                         if (comboBox2.SelectedIndex == 1)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.DarkRed;
                         }
                     }
                     if (textBox6.Text == "two" && numero == "2")
                     {
                         if (comboBox2.SelectedIndex == 0)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.LightBlue;
                         }
                         if (comboBox2.SelectedIndex == 1)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.DarkRed;
                         }
                     }
                     if (textBox6.Text == "three" && numero == "3")
                     {
                         if (comboBox2.SelectedIndex == 0)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.LightBlue;
                         }
                         if (comboBox2.SelectedIndex == 1)
                         {
                             g1[col1.Index, row1.Index].Style.BackColor = Color.DarkRed;
                         }
                     }
                  
                  
         
                 }
                   
               }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ESTO REGRESA TODOS LOS VALORES A SU INICIAL
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
           
            this.g1.Rows.Clear();   // TAMBIEN EL GRID

            textBox1.BackColor = Color.White;     //y A LAS LOS TEXTBOX LES REGRSA A BLANCO COMO INICIAL
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;

            // LAS COMBO BOX NO POR QUE ESAS LAS DEJO SIEMPRE EN UN VALOR DE DEFAULT HASTA ARRIABA GLOBALES
            //Y INSTRUCCIONES ABAJO

        }
    }
}
// para asignar un valor de default a un combo box se usa   en propiedades dropdownstyle y se cambia a drowdown list 