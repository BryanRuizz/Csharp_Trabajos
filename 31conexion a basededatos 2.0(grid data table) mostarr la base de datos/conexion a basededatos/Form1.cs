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
           
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NAME= textBox1.Text;
            string LASTNAME= textBox2.Text;


            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "INSERT INTO STUDENT VALUES ('" + NAME + "','" + LASTNAME + "');";
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 
            // SI TOMA LA CONSULTA Y LA VARCON... ES LA DIRECCION
            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra

            //******************************************************


            VARCONECCION.Open();            //  PARA NUEVAS CONSULAS O ASI SE TIENE QUE ABRIR UNA NUEVA CONECCION NI QUE FUERA UNA ODBC CONECCION DIRECTAN, AQUI SE CIERRA  
            //QUERTY1 = "SELECT * FROM STUDENT ORDER BY ID_STUDENT DESC";

            QUERTY1 = "SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT ORDER BY ID_STUDENT DESC";

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

        private void button2_Click(object sender, EventArgs e)
        {

            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NUM= textBox3.Text;

            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "DELETE STUDENT WHERE ID_STUDENT = "+NUM+"";
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra

            //*******************************************************************

            VARCONECCION.Open();            //  PARA NUEVAS CONSULAS O ASI SE TIENE QUE ABRIR UNA NUEVA CONECCION NI QUE FUERA UNA ODBC CONECCION DIRECTAN, AQUI SE CIERRA  
            //QUERTY1 = "SELECT * FROM STUDENT ORDER BY ID_STUDENT DESC";

            QUERTY1 = "SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT ORDER BY ID_STUDENT DESC";

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

        private void button3_Click(object sender, EventArgs e)
        {
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc
              string NAME= textBox1.Text;
            string LASTNAME= textBox2.Text;
            string NUM = textBox3.Text;

            VARCONECCION.Open(); // abre nuestra conexion
            QUERTY1 =  "UPDATE STUDENT SET NAME = '"+NAME+"', [LASTNAME]='"+LASTNAME+"' WHERE ID_STUDENT = "+NUM+" ";
            //UPDATE STUDENT SET NAME = 'VIC', [LASTNAME]='SOLIS' WHERE ID_STUDENT = 11 ;
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);  //ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();    // lo ejecuta 



            VARCONECCION.Close();      //la cierra

            //*************************************************************************
            VARCONECCION.Open();            //  PARA NUEVAS CONSULAS O ASI SE TIENE QUE ABRIR UNA NUEVA CONECCION NI QUE FUERA UNA ODBC CONECCION DIRECTAN, AQUI SE CIERRA  
            //QUERTY1 = "SELECT * FROM STUDENT ORDER BY ID_STUDENT DESC";

            QUERTY1 = "SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT ORDER BY ID_STUDENT DESC";

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
        //DELETE STUDENT WHERE ID_STUDENT = id(num) sql





        // las variables globales son un reiusgo de seguridad informatica

        // odbc es una conexion permanente entra la cpnexion de una pc y un servidor   open db conexion por ello se creo la cadena de conexion 
        //manda una solisitud para  conectarse    SqlConnection varconection = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
        //todo lo que uses tu se llama front end y el server se llama backend, si el server y el host estan en la mimsa pc se le conoce como localhost
        //firewall en cuenta por la conexion no local 

        // robo de informacion aun con la pc apagada por el disco magnetico ?
        
        //source fuente 
        //el data table es un arreglo (no lo vas a ver) es un source, incluye los titulos de las columnas, lo que hacemos es llenar un data table y lo pegamos el una grid con el metodo bind
        //

    }
}
