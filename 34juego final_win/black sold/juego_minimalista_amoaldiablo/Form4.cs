using System;
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

namespace juego_minimalista_amoaldiablo
{
    public partial class Form4 : Form
    {
        int sum = 0;
        public Form4()
        {
            InitializeComponent();
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon666'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NAME = textBox1.Text;
            string scores = label3.Text;


            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "INSERT INTO juego VALUES ('" + NAME + "','" + scores + "');";
           
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 
            // SI TOMA LA CONSULTA Y LA VARCON... ES LA DIRECCION
            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra

            //******************************************************


            VARCONECCION.Open();            //  PARA NUEVAS CONSULAS O ASI SE TIENE QUE ABRIR UNA NUEVA CONECCION NI QUE FUERA UNA ODBC CONECCION DIRECTAN, AQUI SE CIERRA  
            //QUERTY1 = "SELECT * FROM STUDENT ORDER BY ID_STUDENT DESC";

            QUERTY1 = "SELECT id,nombre,score as vidas FROM juego order by id desc ";

            //SI QUEREMOS "PRESENTAR" LOS ATRIBUTOS CON OTROS NAMES PODEMOS USAR /* AS */ EN LA CONSULTA PARA CAMIBAR EN LA GRID NOMAS 
            //SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT    ASI 

            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);
            cuadritodecomandos.ExecuteNonQuery();

            SqlDataAdapter ADAPTADOR = new SqlDataAdapter(cuadritodecomandos);                // AQUI SE GUARDA COMO EL JASON ASI LARGO(TODA NUETRA TABLA POR EL SELECT)
            DataTable DATATABLE = new DataTable();                //SOLO DECLARAMOS UNA VAR DE TIPO TABLA O VA A SER EL FOERMATO TIPO TABLA PARA PODER PEGARLO A UNA GRID
            ADAPTADOR.Fill(DATATABLE);                // PEGAMOS EL ADAPTADOR (OSEA LA CADENA DE JASON AQUI) Y CON EL FILL LO LLENAMOS EN EL FORMATO TABLE DE DATATABLE PARA PODER PONERLO EN LA GRID
            g1.DataSource = DATATABLE;              //Y AQUI LLENAMOS LA GRID CON EL FORMATO DATATABLE YA LLENO 

            // ADAPTADOR.Update(DATATABLE);          // Y SE SUPONE QUE AQUI LA ACTUALIZA
            // YA NO USAMOS UN BIND PARA QUE LO `PUEGE PASA DIRECTO ANTES SI SE TENIA QUE USAR UN PEGADOR QUE ERA LA VARIABLE DEL BIND O BILDING O ALGO ASI
            VARCONECCION.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            sum = Form3.vidas + Form2.vidas;
           // label3.Text = Form3.vidas+Form2.vidas.ToString();
          label3.Text = sum.ToString();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Restart();
          
        }
    }
}
