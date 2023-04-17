using System;

namespace elRELOJ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //RELOJ 24/60 ARREGLO LLENAR DINAMICO  23,59


           // int[,] reloj = new int[25, 59];


            for (int i = 00; i < 25; i++)
            {

                for (int p = 0; p < 60; p++)
                {
                    for (int k = 0; k < 60; k++)
                    {


                        Console.WriteLine(i + ":" + p + ":" + k);
                        Console.WriteLine("h   ,   min   ,   seg  ");
                        Console.WriteLine(" ");





                    }




                }
            }

           





        }
    }
}
