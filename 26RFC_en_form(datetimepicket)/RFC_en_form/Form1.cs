using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFC_en_form
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("seleccionado");
            }
            string fecha = dateTimePicker1.Value.ToShortDateString();//   16/09/1999
            string dia, mes, año;
            dia = fecha.Substring(0, 2);
            mes = fecha.Substring(3, 2);
            año = fecha.Substring(8, 2);


            int cont = 0, loong = 0;
            string name = "", lxl = "", rsolita = "", rfname = "";
            // string name = "", lastn = "",lxl="",rsolita="",rfname="";
            name = textBox1.Text;
            //lastn = textBox2.Text;
            loong = name.Length;
            string namesolito = "";
            rsolita = name.Substring(0, 1);// primer letra de mi name
            while (cont < loong)
            {
                lxl = name.Substring(cont, 1);
               
                if (lxl == " ")
                {
                    rfname = rfname + name.Substring(cont + 1, 1);// va sumando la primera letra de cada nombre 
                    namesolito = namesolito + name.Substring(cont - 1, 1);
                }
                cont++;
            }
            MessageBox.Show(namesolito);
            //label3.Text =rsolita+rfname;********************************hasta here 1 letra de cada name 

            int cont2 = 0, loong2 = 0;
            string lastn2 = "", lxl2 = "", rsolita2 = "", rfname2 = "";
            string namesolito2 = "";

            lastn2 = textBox2.Text;
            loong2 = lastn2.Length;

            rsolita2 = lastn2.Substring(loong2 - 2, 2);
            while (cont2 < loong2)
            {
                lxl2 = lastn2.Substring(cont2, 1);
                if (lxl2 == " ")
                {
                    rfname2 = rfname2 + lastn2.Substring(cont2 - 2, 2);
                    namesolito2 = namesolito2 + lastn2.Substring(cont2 - 1, 1);
                }
                cont2++;
            }     //bryan ruiz      iz an        baaniz 160919
          
            

            label3.Text = rsolita + rfname + rfname2 + rsolita2 + dia + mes + año;
            namesolito = namesolito.Substring(0, 1);//error
            namesolito2 = namesolito2.Substring(0, 1);

            // label4.Text = namesolito2;
            /* rp = rp.Substring(0, 7);
             rpp= rp.Substring(7, 6);
             rfk = rp + rpp;
             label3.Text = rfk;*/

            if (checkBox1.Checked ==true)
            {
                MessageBox.Show("A PAGAR IMPUESTOS TU SOLITO");
                label3.Text = rsolita + rfname + rfname2 + rsolita2 + dia + mes + año+namesolito+namesolito2+mes;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();   
            //checkBox1 HACER QUE VALGA FALSE?
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }

        
    }
}
