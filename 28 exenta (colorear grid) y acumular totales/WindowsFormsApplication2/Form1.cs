using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//primero las validaciuones no espacios vacios y no num en el 1textbox
            string texterros;

            texterros = "";
            if (comboBox1.Text == "")// valida que si no escribist datos no te mande error 
            {
                texterros += "__error ." + label2 + "invalid__";
               

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

           
            if (texterros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(texterros);
                MessageBox.Show("favor de completar cada campo !gracias¡");
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                

                return;
            }
            //***********************************************************************************************
            double acumtt = 0;
            double rojo = 0,azul=0;
            double sub1=0,desc=0,total=0;
            string txt1, txt2, txt3,txt4,txt5,txt6;
            txt1 = comboBox1.Text;
            txt2 = textBox2.Text;
            txt3 = textBox3.Text;
            sub1 = (Convert.ToDouble(txt2) * Convert.ToDouble(txt3));
            txt4 = sub1.ToString();
            txt5 = "0";
            if (checkBox1.Checked == true)
            {
                desc = (sub1 * .20);
                total = sub1 - desc;
                txt5 = "20"  ;
            }
            if (checkBox1.Checked == false)
            {
                total = sub1;
                txt5 = "0";
            }
            
            txt6 = total.ToString();
           


            //label4.Text = txt6;     //   el txt4 motrara el subtotal 1 o total con cheked
           
            g1.Rows.Add(txt1, txt2, txt3, txt4, txt5, txt6);

            
            foreach (DataGridViewRow row1 in g1.Rows) //por cada renglon 
            {
                rojo = Convert.ToDouble(g1[4, row1.Index].Value);
                if (rojo>0)
                {
                    g1[4, row1.Index].Style.BackColor = Color.Red;
                   
                }
                azul = Convert.ToDouble(g1[5, row1.Index].Value);
                if (azul > 0) 
                {
                    acumtt += azul;
                }
            
            }

            label4.Text = acumtt.ToString();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            this.g1.Rows.Clear();
            label4.Text = "";
        }
    }
}
