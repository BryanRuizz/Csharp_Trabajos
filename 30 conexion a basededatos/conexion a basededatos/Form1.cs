using System; // dlls
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  // para usar la base de datos 
using System.Data.Sql;
using System.Data.SqlClient;

namespace conexion_a_basededatos
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla studnt  en mi basede datos utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NAME= textBox1.Text;
            string LASTNAME= textBox2.Text;


            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "INSERT INTO STUDENT VALUES ('" + NAME + "','" + LASTNAME + "');";
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NUM= textBox3.Text;

            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "DELETE STUDENT WHERE ID_STUDENT = "+NUM+"";
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra




        }






        // las variables globales son un reiusgo de seguridad informatica

        // odbc es una conexion permanente entra la cpnexion de una pc y un servidor   open db conexion por ello se creo la cadena de conexion 
        //manda una solisitud para  conectarse    SqlConnection varconection = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
        //todo lo que uses tu se llama front end y el server se llama backend, si el server y el host estan en la mimsa pc se le conoce como localhost
        //firewall en cuenta por la conexion no local 

        // robo de informacion aun con la pc apagada por el disco magnetico ?
        //

    }
}
