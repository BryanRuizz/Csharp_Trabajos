using System;

namespace codigoCESAR_CIN_ARREGLOS
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, codificar;
            int letras = 0;
            string[] abecedario1 = new string[27];
            //declaracion de arreglo                                      null             0 1 2 3 4 5 6 7 8 9
            string[] abecedario = new string[27];//string [] abecedario = new string[27]{"a","a","a","a","a","a","a","a","a","a","a","a","a","a","a","a","a","a","a"}; tambioen se puede usar asi aqi no se pueden dejar null sollo espacios blancos a menos que pongas directo null
            abecedario[0] = "a";
            abecedario[1] = "b";
            abecedario[2] = "c";
            abecedario[3] = "d";
            abecedario[4] = "e";
            abecedario[5] = "f";
            abecedario[6] = "g";
            abecedario[7] = "h";
            abecedario[8] = "i";
            abecedario[9] = "j";
            abecedario[10] = "k";
            abecedario[11] = "l";
            abecedario[12] = "m";           // cuando solo pongo ej :    i+3 es un valor temporal cuando se iguala i = i+3 el valor si cambia
            abecedario[13] = "n";
            abecedario[14] = "ñ";
            abecedario[15] = "o";
            abecedario[16] = "p";
            abecedario[17] = "q";
            abecedario[18] = "r";
            abecedario[19] = "s";
            abecedario[20] = "t";
            abecedario[21] = "u";
            abecedario[22] = "v";
            abecedario[23] = "w";
            abecedario[24] = "x";
            abecedario[25] = "y";
            abecedario[26] = "z";





            abecedario1[0] = "d";
            abecedario1[1] = "e";
            abecedario1[2] = "f";
            abecedario1[3] = "g";
            abecedario1[4] = "h";
            abecedario1[5] = "i";
            abecedario1[6] = "j";
            abecedario1[7] = "k";
            abecedario1[8] = "l";
            abecedario1[9] = "m";
            abecedario1[10] = "n";
            abecedario1[11] = "ñ";
            abecedario1[12] = "o";           // cuando solo pongo ej :    i+3 es un valor temporal cuando se iguala i = i+3 el valor si cambia
            abecedario1[13] = "p";
            abecedario1[14] = "q";
            abecedario1[15] = "r";
            abecedario1[16] = "s";
            abecedario1[17] = "t";
            abecedario1[18] = "v";
            abecedario1[19] = "u";
            abecedario1[20] = "w";
            abecedario1[21] = "x";
            abecedario1[22] = "y";
            abecedario1[23] = "z";
            abecedario1[24] = "a";
            abecedario1[25] = "b";
            abecedario1[26] = "c";

            //string[] abecedario = new string[27] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a"};  

            Console.WriteLine("escribe una letra en minuscula ");
            palabra = Console.ReadLine();
            letras = palabra.Length;





            for (int i = 0; i < 27; i++)
            {




                if (palabra == abecedario[i])
                {
                    codificar = abecedario1[i];
                    Console.WriteLine("la letra codificada es :" + codificar);

                }


            }
            
            Console.ReadKey();
        }
    }
}
