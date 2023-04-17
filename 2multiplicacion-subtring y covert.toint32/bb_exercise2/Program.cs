using System;

namespace bb_exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           


            int w1, w2; // son numeros 
            String x1, x2;//son strings 

            x1 = "escribir un numero del 1 alo 10"; //asignamos

            Console.WriteLine("bryan andres santillan ruiz "); //strings

            Console.WriteLine(x1); //asignamos para que nos muetre la de arriba 

            w1 = Convert.ToInt32(Console.ReadLine());// espera a leer y capturar la varcovert.toint32

            Console.WriteLine("el  numero que escribiste fue: " + w1.ToString()); //muetra el resultado y lo covierte a string para poder mostrarlo en el writeline

            int num1, num2;
            String z1, z2;
            Console.WriteLine("now write a num  1 to 3 ");
           

            num2 = Convert.ToInt32(Console.ReadLine());
            num1 = w1 * num2;
            Console.WriteLine("el  numero que escribiste para multiplicar fue : " + num1.ToString());//es lo mismo solo que ahora hace la multiplicacion





        }
    }
}
