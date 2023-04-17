using System;

namespace _16_2_ARREGLOS_nomYmostrarlo_alrevez
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] var= new string [10];
            int cont = 0;
            string nombre;



            while (cont < 10)
            {

                Console.WriteLine("ESCRIBE UN NOMBRE ");
                nombre = Console.ReadLine();
                var[cont] = nombre;            // guardo en mi arreglo con el cont inicia en 0 y peus termina en 10 y se sobre escribe



                //aqui mi for entra y te muetra 10 espacios y va mostrandoo nom x nom

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("las posicion del arreglo " + i.ToString() + "contiene " + var[i]);


                }

                cont++;   // incremento
            }
            //si pongo aqui el for solo mostraria los 10 hsta el final 




            Console.WriteLine(" ");



            // me muetra el arreglo alrevez xd el i.tostring me muetsra el valor de la de incremento o decremento 


            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("las posicion del arreglo " + i.ToString() + "contiene " + var[i]);


            }

        }
    }
}
