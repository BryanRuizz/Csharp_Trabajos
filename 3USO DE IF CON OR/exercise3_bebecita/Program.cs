using System;

namespace exercise3_bebecita
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            int num1;

            
            Console.WriteLine("escribir un numero del 1 al 10");

            num1 = Convert.ToInt32(Console.ReadLine());

            //num1 guardada el numero

            if (num1 == 1 || num1 == 2 || num1 == 3 || num1 == 4 || num1 == 5 || num1 == 6 || num1 == 7 || num1 == 8 || num1 == 9)
            {

                if (num1 == 1)
                {

                    Console.WriteLine("number one ");//


                }

                if (num1 == 2)


                {

                    Console.WriteLine("number dos ");//


                }

                if (num1 == 3)

                {

                    Console.WriteLine("number tres");//


                }


                if (num1 == 4)

                {

                    Console.WriteLine("number cuatro ");//


                }

                if (num1 == 5)


                {

                    Console.WriteLine("number cinco");//


                }

                if (num1 == 6)




                {

                    Console.WriteLine("number seis ");//


                }
                if (num1 == 7)


                {

                    Console.WriteLine("number siete ");//


                }

                if (num1 == 8)



                {

                    Console.WriteLine("number ocho ");//


                }

                if (num1 == 9)


                {

                    Console.WriteLine("number nueve ");//


                }
                if (num1 == 10)


                {

                    Console.WriteLine("number dies ");//


                }

            }
            else
            {
                Console.WriteLine("NO ES UN NUMERO");
            }





            Console.ReadLine();
        }
    }
}
