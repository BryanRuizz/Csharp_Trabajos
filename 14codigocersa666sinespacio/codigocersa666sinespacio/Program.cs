using System;

namespace codigocersa666sinespacio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] svar1 = new string[27] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","Ñ", "O", "P", "Q","R","S","T","U","V","W","X","Y","Z"};


            //**********************************************************************




            string frase, frasenueva = "";
            string letra = "";
            int clave, desde0;


            Console.WriteLine("ESCRIBE UNA PALABRA CUALQUIERA ");
            frase = Console.ReadLine();

            Console.WriteLine("ESCRIBE UNA CLAVE DEL 1 AL 27");
            clave = Convert.ToInt32(Console.ReadLine());

            int tope = frase.Length;



            //***********************************************************************



            for (int i = 0; i < tope; i++)
            {
                letra = frase.Substring(i, 1); //ME SEPARA LETRA POR LETRA





                //********************************************************************





                for (int j = 0; j < 27 - clave; j++) //IF LETRA == "A"{ LETRACODIFICADA = "G"}
                {
                    if (letra == svar1[j])
                    {
                        frasenueva += svar1[j + clave]; // NO DEBE DE PASAR LAS 27 POSICIONES DEL ARREGLO
                    }
                }





                //**********************************************************************






                for (int j = 27 - clave; j < 27; j++) //HACE QUE DE VUELTA EL ARREGLO
                {
                    if (letra == svar1[j])  //A =25 = X
                    {
                        desde0 = clave - (27 - j);
                        frasenueva += svar1[desde0];
                    }
                }




                //***********************************************************************




            }
            Console.WriteLine(frasenueva);
            Console.ReadKey();
        }
    }
}
