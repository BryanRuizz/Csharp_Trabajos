using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCERCISE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texterros;

            texterros = "";
            if (textBox1.Text == "")// valida que si no escribist datos no te mande error
            {
                texterros += "__error ." + label1 + "invalid__";
                textBox1.BackColor = Color.Red;

            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error 
            {
                texterros += "__error ." + label2 + "invalid__";
                textBox2.BackColor = Color.Red;

            }
            if (textBox3.Text == "")// valida que si no escribist datos no te mande error
            {
                texterros += "__error ." + label3 + "invalid__";
                textBox3.BackColor = Color.Red;

            }

            if (textBox4.Text == "")// valida que si no escribist datos no te mande error 
            {
                texterros += "__error ." + label4 + "invalid__";
                textBox4.BackColor = Color.Red;

            }
            if (textBox5.Text == "")// valida que si no escribist datos no te mande error 
            {
                texterros += "__error ." + label5 + "invalid__";
                textBox5.BackColor = Color.Red;

            }
            if (texterros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(texterros);
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                
                return;
            }
            //*********************************************************************************** espacios vacios
            double cal1, cal2, cal3, ave1,ave;

            // para la grid la grid es stringo obviii
            string txt1, txt2, txt3, txt4, txt5, txt6;
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            txt3 = textBox3.Text;
            txt4 = textBox4.Text;
            txt5 = textBox5.Text;

            ave1 = (Convert.ToDouble(txt3) + Convert.ToDouble(txt4) + Convert.ToDouble(txt5)) / 3;
            txt6 = ave1.ToString();
            //agregar renglones al data grid uno    para mostrar los datos como una tabla 
                g1.Rows.Add(txt1, txt2,txt3,txt4,txt5,txt6);
            //si quiers agg una table es en la esquinita y add y ahi tambien en remove se borran tablas 



            // variable compuesta 
            // va de  ladito uno , uno 
                Double ac1=0;
                foreach (DataGridViewRow row1 in g1.Rows) //por cada renglon   - ROW
                //                                                                                                  -  THIS IS OTHER ROW ORIZONTAL
                {
                    //foreach (DataGridViewColumn col1 in g1.Columns) //por cada columna    ||  COLUM || COLUM VERTICAL
                   // {
                        cal1 = Convert.ToDouble(g1[2, row1.Index].Value);
                        if (cal1 < 80) 
                        {
                            g1[2, row1.Index].Style.BackColor = Color.Red;                        
                        }
                        cal2 = Convert.ToDouble(g1[3, row1.Index].Value);
                        if (cal2 < 80)
                        {
                            g1[3, row1.Index].Style.BackColor = Color.Red;
                        }
                        cal3 = Convert.ToDouble(g1[4, row1.Index].Value);
                        if (cal3 < 80)
                        {
                            g1[4, row1.Index].Style.BackColor = Color.Red;
                        }
                        ave = Convert.ToDouble(g1[5, row1.Index].Value);
                        if (ave < 80)
                        {
                            g1[5, row1.Index].Style.BackColor = Color.Red;

                        }

                    ac1 += ave = Convert.ToDouble(g1[5, row1.Index].Value);// Y ASI SE ACUMULA DENTRO DEL GRID



            }


               label7.Text = ac1.ToString();    // HERE I ONLY SHOW THE AVERAGE OF THE  CUARTER JEJE
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }//las clases son los objetos  y en esta ide usan constructores a travez de la clase 
}// la clase son como planos para crear el boton
