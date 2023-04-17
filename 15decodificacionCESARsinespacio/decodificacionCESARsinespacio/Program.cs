using System;

namespace decodificacionCESARsinespacio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abecedario = new string[28] { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string palabra = "";

            int llave = 0;
            string cod = "";
            string letra = "";
            int cont = 0;
            int nl = 0;



            Console.WriteLine("Ingrese una oracion:");
            palabra = Console.ReadLine();
            nl = palabra.Length;


            Console.WriteLine("Ingrese la llave descodificadora(del 1 al 27):");
            llave = Convert.ToInt32(Console.ReadLine());

            while (cont < nl)
            {
                letra = palabra.Substring(cont, 1);


                for (int i = 0; i < 28; i++)
                {

                    if (letra == abecedario[i])
                    {

                        if (i - llave < 1)

                        {
                            cod = cod + abecedario[27 - (llave - i)];

                        }

                        else
                        {
                            cod = cod + abecedario[i - llave];

                        }

                    }




                }
                if (letra == " ")
                {
                    cod = cod + " ";
                }
                cont++;









            }
            Console.WriteLine("su mensaje descodificado es:" + cod);
        }
    }
}
