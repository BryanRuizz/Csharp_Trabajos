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

namespace DBPROGRA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //funcion_rutina();    // para cargar la grid con la base de datos desde el inicio con mi funcion rutina
        }

        private void funcion_rutina()
        {
            g1.Columns.Clear();// para limpiarla en cada ejecucion que se use si no crea y crea columnas fantsma y da a fallos

            // para re100 inicie la forma me mustre la databse 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand();
            string QUERTY1;
            VARCONECCION.Open();
            QUERTY1 = "SELECT ID AS CODIGO, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT ORDER BY ID DESC";
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);
            cuadritodecomandos.ExecuteNonQuery();

            SqlDataAdapter ADAPTADOR = new SqlDataAdapter(cuadritodecomandos);             // llena el adaptador con lo datos de select*... y los saca como jason (saca atributos y registros)
            DataTable DATATABLE = new DataTable();            // lo transforma a tipo table  es como un formato
            ADAPTADOR.Fill(DATATABLE);                //se llena el datatabel con el adapter y asi se hace una tipo tabla y se llena para mostar los datos de la base de datos
            g1.DataSource = DATATABLE;                      // lo vinculamos con el gridview muestra la tabla ya hecha en el 

            VARCONECCION.Close();                   // pos cierra la conección 
            //*****************************************************

            DataGridViewImageColumn ic = new DataGridViewImageColumn();            // columna temporal solo existe aqui
            ic.HeaderText = "UPDATE";                   // nombre texto
            ic.Image = null;                                     // valor de la img
            ic.Name = "UPDATE";                                                    // yea nigga
            ic.Width = 100;                                                      // ancho
            ic.ImageLayout = DataGridViewImageCellLayout.Stretch;                                             //que se acomode al espacio
            g1.Columns.Add(ic);                                                                 // añadimos la columna a la grid
            foreach (DataGridViewRow row in g1.Rows)                                         //añadimos a cada renglon mi imagen a cada celda pero solo enn la celda 3
            {
                DataGridViewImageCell cell = row.Cells[3] as DataGridViewImageCell;
                cell.Value = DBPROGRA.Properties.Resources.LAPIZ;
            }
           //**************************************************************

            DataGridViewImageColumn ics = new DataGridViewImageColumn();     // añadimos esta funcion especial solo para imagenes para la grid
            ics.HeaderText = "TRASH";                                                         // titulo
            ics.Image = null;                                                                                 // valor inicial 
            ics.Name = "TRASH";                                                                    // nombre 
            ics.Width = 100;                                                                            // ancho 
            ics.ImageLayout = DataGridViewImageCellLayout.Stretch;              // darle el tamaño de ajustarse al cuadrito
            g1.Columns.Add(ics);                                                                       // lo añadimos a la grid 
            foreach (DataGridViewRow row in g1.Rows)                                            // corre de inicio a finale por renglones y añade a cada uno la imagen en la celda 4 
            {
                DataGridViewImageCell cell = row.Cells[4] as DataGridViewImageCell;
                cell.Value = DBPROGRA.Properties.Resources.TRASH;
            }


            //*************************************
           /* DataGridViewImageColumn ic = new DataGridViewImageColumn();
            ic.HeaderText = "SEL";
            ic.Image = null;
            ic.Name = "3E9";
            ic.Width = 100;
            g1.Columns.Add(ic);
            foreach (DataGridViewRow row in g1.Rows)
            {
                DataGridViewImageCell cell = row.Cells[3] as DataGridViewImageCell;
                cell.Value = DBPROGRA.Properties.Resources.LAPIZ;
            }*/


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string textoerros;

            textoerros = "";
            if (textBox1.Text == "")// valida que si no escribist datos no te mande error
            {
                textoerros += "__error .___" + label1 + "___invalid___";
                textBox1.BackColor = Color.Red;

            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error 
            {
                textoerros += "__error .__" + label2 + "____invalid__";
                textBox2.BackColor = Color.Red;

            }

            if (textoerros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(textoerros);

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                return;
            }


            //********************************************************************************
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NAME = textBox1.Text;
            string LASTNAME = textBox2.Text;


            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "INSERT INTO STUDENT VALUES ('" + NAME + "','" + LASTNAME + "');";
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 
            // SI TOMA LA CONSULTA Y LA VARCON... ES LA DIRECCION
            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra

            //******************************************************


            funcion_rutina();

           

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// sera celda evento  clic dentro de la grid 
            int CLICKROW, CLICKCOL;  // dos variablos para guardar la posicion
            CLICKCOL = e.ColumnIndex;                 //columnas
            CLICKROW = e.RowIndex;                        // renglones
          //  MessageBox.Show(e.ColumnIndex+"------"+e.RowIndex);

            if (CLICKCOL == 3)              // columna numero 3 si no no y si si
            {
                textBox1.Text = g1.Rows[CLICKROW].Cells[1].Value.ToString();                // regressa los valores donde tocas pñor ejemplo su nom y ap en donde corresponde su tbox
                textBox2.Text = g1.Rows[CLICKROW].Cells[2].Value.ToString();
                textBox3.Text = g1.Rows[CLICKROW].Cells[0].Value.ToString();
            }

            if (CLICKCOL == 4)    // es como ejecutar un delete por toque en el mismoo evento 
            {
                //mensaje interactivo
                if (MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR?", "ABUSADO CON TU MAMA", MessageBoxButtons.YesNo) == DialogResult.Yes)        // mensaje si si o si no 
                {
                    //*** AI TUVIERA LA CONECCION GLOBAL NO TENDRIA QUE ESCRIBIRLA PERO ES MAMADA DE SEGURIDAD


                    SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon'");
                    SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand();
                    string QUERTY1;
                    VARCONECCION.Open();
                    QUERTY1 = "DELETE STUDENT WHERE ID = " + g1.Rows[CLICKROW].Cells[0].Value.ToString();            // selecion de id segun el toque y lo guarda en la var y d elas celda 0 por que ahi estan las id

                    cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);
                    cuadritodecomandos.ExecuteNonQuery();
                    VARCONECCION.Close();

                    //***
                    funcion_rutina();
                }
                else
                {
                    MessageBox.Show("a bueno chinga tu madre");
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoerros;

            textoerros = "";
            if (textBox1.Text == "")// valida que si no escribist datos no te mande error
            {
                textoerros += "__error .___" + label1 + "___invalid___";
                textBox1.BackColor = Color.Red;

            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error 
            {
                textoerros += "__error .__" + label2 + "____invalid__";
                textBox2.BackColor = Color.Red;

            }

            if (textoerros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(textoerros);

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                return;
            }
            //*********************************************************

            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc

            string NUM = textBox3.Text;

            VARCONECCION.Open(); // abre nuestra conexion

            //QUERTY1 = "INSERT INTO STUDENT VALUES ('VIC','SOLIS');";                                                                                                                                                    

            QUERTY1 = "DELETE STUDENT WHERE ID = " + NUM + "";
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);//ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();// lo ejecuta 



            VARCONECCION.Close(); //la cierra

            //*******************************************************************

            funcion_rutina();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textoerros;

            textoerros = "";
            if (textBox1.Text == "")// valida que si no escribist datos no te mande error
            {
                textoerros += "__error .___" + label1 + "___invalid___";
                textBox1.BackColor = Color.Red;

            }

            if (textBox2.Text == "")// valida que si no escribist datos no te mande error 
            {
                textoerros += "__error .__" + label2 + "____invalid__";
                textBox2.BackColor = Color.Red;

            }

            if (textoerros != "")// valida que si no escribist datos no te mande error 
            {
                MessageBox.Show(textoerros);

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                return;
            }
            //*******************************************************************
            //una variable de conexion                                     // coneccion a la base de datos de sql con mi tabla utld y el acceso id y su passorwd a mi user    // cadena de conexion 
            SqlConnection VARCONECCION = new SqlConnection(@"DATA SOURCE=LAPTOP-JVC8LH3R\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=bryan; PASSWORD='soychingon'");
            SqlCommand cuadritodecomandos = VARCONECCION.CreateCommand(); // crea el cuadro de comandos de sql   donde van los comandos 
            string QUERTY1;// es la variable dodne insertaremos los comandos de insert etc
            string NAME = textBox1.Text;
            string LASTNAME = textBox2.Text;
            string NUM = textBox3.Text;

            VARCONECCION.Open(); // abre nuestra conexion
            QUERTY1 = "UPDATE STUDENT SET NAME = '" + NAME + "', [LASTNAME]='" + LASTNAME + "' WHERE ID = " + NUM + " ";
            //UPDATE STUDENT SET NAME = 'VIC', [LASTNAME]='SOLIS' WHERE ID_STUDENT = 11 ;
            textBox4.Text = QUERTY1;
            cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);  //ejecuta el querty en la parte de mi catalogo de mi tabla 

            cuadritodecomandos.ExecuteNonQuery();    // lo ejecuta 



            VARCONECCION.Close();      //la cierra

            //*************************************************************************
            funcion_rutina();   // LO MANDO LLAMAR

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funcion_rutina();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}

// las variables globales son un reiusgo de seguridad informatica

// odbc es una conexion permanente entra la cpnexion de una pc y un servidor   open db conexion por ello se creo la cadena de conexion 
//manda una solisitud para  conectarse    SqlConnection varconection = new SqlConnection(@"DATA SOURCE=WIN-EP6C536R5JC\SQLEXPRESS;INITIAL CATALOG=UTLD; USER ID=sa; PASSWORD='soychingon'");
//todo lo que uses tu se llama front end y el server se llama backend, si el server y el host estan en la mimsa pc se le conoce como localhost
//firewall en cuenta por la conexion no local 

// robo de informacion aun con la pc apagada por el disco magnetico ?

//source fuente 
//el data table es un arreglo (no lo vas a ver) es un source, incluye los titulos de las columnas, lo que hacemos es llenar un data table y lo pegamos el una grid con el metodo bind

//concepto 

// funcion rutina o subproceso o subrutina

//PARA NO VOLVER A ESCRIBIR TANTO CODIGO SE PONE UN PRIVATE VOID HASTA ARRIBA Y PONES EL CODIGO AHI Y LO PUEDES MANDAR LLAMAR PARA NO PONER TRANTO CODIGO 
/* VARCONECCION.Open();            //  PARA NUEVAS CONSULAS O ASI SE TIENE QUE ABRIR UNA NUEVA CONECCION NI QUE FUERA UNA ODBC CONECCION DIRECTAN, AQUI SE CIERRA  
   //QUERTY1 = "SELECT * FROM STUDENT ORDER BY ID_STUDENT DESC";

   QUERTY1 = "SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT ORDER BY ID_STUDENT DESC";

   //SI QUEREMOS "PRESENTAR" LOS ATRIBUTOS CON OTROS NAMES PODEMOS USAR /* AS  EN LA CONSULTA PARA CAMIBAR EN LA GRID NOMAS 
   //SELECT ID_STUDENT AS ID, NAME AS NOMBRE, LASTNAME AS APELLIDO FROM STUDENT    ASI 

   cuadritodecomandos = new SqlCommand(QUERTY1, VARCONECCION);
   cuadritodecomandos.ExecuteNonQuery();

   SqlDataAdapter ADAPTADOR = new SqlDataAdapter(cuadritodecomandos);                // AQUI SE GUARDA COMO EL JASON ASI LARGO(TODA NUETRA TABLA POR EL SELECT)
   DataTable DATATABLE = new DataTable();                //SOLO DECLARAMOS UNA VAR DE TIPO TABLA O VA A SER EL FOERMATO TIPO TABLA PARA PODER PEGARLO A UNA GRID
   ADAPTADOR.Fill(DATATABLE);                // PEGAMOS EL ADAPTADOR (OSEA LA CADENA DE JASON AQUI) Y CON EL FILL LO LLENAMOS EN EL FORMATO TABLE DE DATATABLE PARA PODER PONERLO EN LA GRID
   g1.DataSource = DATATABLE;              //Y AQUI LLENAMOS LA GRID CON EL FORMATO DATATABLE YA LLENO 

  // ADAPTADOR.Update(DATATABLE);          // Y SE SUPONE QUE AQUI LA ACTUALIZA
   // YA NO USAMOS UN BIND PARA QUE LO `PUEGE PASA DIRECTO ANTES SI SE TENIA QUE USAR UN PEGADOR QUE ERA LA VARIABLE DEL BIND O BILDING O ALGO ASI
   VARCONECCION.Close();    */