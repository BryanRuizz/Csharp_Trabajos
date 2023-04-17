using System;

namespace practica1
{
    class MainClass
    {
        public static void Main(string[] args)

        {

            //empieza declara 
            String numrom;// declaramos 

            // termina declarar


            Console.WriteLine("BIENVENIDO AL PROGRAMA PARA SUMAR NUMEROS ROMANOS ");

            Console.WriteLine("CAPTURA UN NUMERO DEL I AL X ");



            numrom = Console.ReadLine();//aqui se lo asignas el valor


            Console.WriteLine(numrom);//aqui lo lee
            // AQUI AREMOS VALIDACION DE DATOS DELI AL X

            // RECUERDA && ESTO ES AND Y || ESTO ES OR  PUT IT WITH THE TECLAS ALT GR AND 4 AND ALT GR 1 


            if (numrom == "I" || numrom == "II" || numrom == "III" || numrom == "IV" || numrom == "V" || numrom == "VI" || numrom == "VII" || numrom == "VIII" || numrom == "IX" || numrom == "X")
            // tarea hacerlo de las dos formas y hacer las suma de los dos numeros

            {
                if (numrom == "I")
                {
                    Console.WriteLine("EL NUMERO I ES UN NUMERO ROMANO Y CORRESPONDE AL 1 ARABIGO");
                }


                if (numrom == "II")
                {

                    Console.WriteLine("EL NUMERO II ES UN NUMERO ROMANO Y CORRESPONDE AL 2 ARABIGO");

                }
                if (numrom == "III")
                {

                    Console.WriteLine("EL NUMERO III ES UN NUMERO ROMANO Y CORRESPONDE AL 3 ARABIGO");

                }
                if (numrom == "IV")
                {

                    Console.WriteLine("EL NUMERO IV ES UN NUMERO ROMANO Y CORRESPONDE AL 4 ARABIGO");

                }
                if (numrom == "V")
                {

                    Console.WriteLine("EL NUMERO VI ES UN NUMERO ROMANO Y CORRESPONDE AL 5 ARABIGO");

                }
                if (numrom == "VI")
                {

                    Console.WriteLine("EL NUMERO VII ES UN NUMERO ROMANO Y CORRESPONDE AL 6 ARABIGO");

                }
                if (numrom == "VII")
                {

                    Console.WriteLine("EL NUMERO VIII ES UN NUMERO ROMANO Y CORRESPONDE AL 7 ARABIGO");

                }
                if (numrom == "VIII")
                {

                    Console.WriteLine("EL NUMERO IX ES UN NUMERO ROMANO Y CORRESPONDE AL 8 ARABIGO");

                }
                if (numrom == "IX")
                {

                    Console.WriteLine("EL NUMERO X ES UN NUMERO ROMANO Y CORRESPONDE AL 9 ARABIGO");

                }
                if (numrom == "X")
                {

                    Console.WriteLine("EL NUMERO I ES UN NUMERO ROMANO Y CORRESPONDE AL 10 ARABIGO");
                }
            }
        

            else
            {
              Console.WriteLine(numrom + "NO ES NUMERO ROMANO DEL I AL X");

            }







            }
        }
    }
 






