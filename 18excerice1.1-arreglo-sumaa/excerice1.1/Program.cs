using System;

namespace excerice1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // sumar todos los numeros - o = a 3 del sig array

            int [,] num = new int[6, 6]; // lo guardamos manual en el arreglo segun como lo indico el teacher
            int res = 0;
            int  cont = 0;

            num[0, 0] = 4;
            num[0, 1] = 10;
            num[0, 2] = 15;
            num[0, 3] = 3;
            num[0, 4] = 4;
            num[0, 5] = 1;
            num[1, 0] = 10;
            num[1, 1] = 0;
            num[1, 2] = -2;
            num[1, 3] = 4;
            num[1, 4] = 8;
            num[1, 5] = -10;
            num[2, 0] = 21;
            num[2, 1] = 5;
            num[2, 2] = 10;
            num[2, 3] = 3;
            num[2, 4] = 7;
            num[2, 5] = 3;
            num[3, 0] = 3;
            num[3, 1] = 2;
            num[3, 2] = 2;
            num[3, 3] = 3;
            num[3, 4] = 21;
            num[3, 5] = 99;
            num[4, 0] = 33;
            num[4, 1] = -1000;
            num[4, 2] = 45;
            num[4, 3] = 69;
            num[4, 4] = 88;
            num[4, 5] = -4;
            num[5, 0] = 150;
            num[5, 1] = 1;
            num[5, 2] = 54;
            num[5, 3] = 0;
            num[5, 4] = -2;
            num[5, 5] = 44;

            // para no hardcorearlo lo puse en un ciclo para mostarlo todo(2da parte mustra como hacerlo todo desde dos ciclos)

            for (int p = 0; p < 6 ;p++)
            {
                Console.WriteLine(num[0, p].ToString() + "  "+ num[1, p].ToString()+ "  " + num[2, p].ToString() + "  "+ num[3, p].ToString() + "  "+ num[4, p].ToString() + "  "+ num[5, p].ToString());




            }


            Console.WriteLine(" "); //solo separa

            //para hacer la suma segun la indicacion de <= 3 cualquier numero que cumpla la caracteristica



            while (cont < 6) 
            {
                if (num[0, cont] <= 3)   //si mi parte del array del 0,0 a 0,5 tiene un num <=3 lo guardara  y lo ira sumando 
                {
                    res = num[0, cont]+ res;


                }


                if (num[1, cont] <= 3)
                {
                    res = num[1, cont]+ res;

                   
                }

                if (num[2, cont] <= 3)
                {
                    res = num[2, cont]+ res;


                }

                if (num[3, cont] <= 3)
                {
                    res = num[3, cont]+ res;

                   
                }

                if (num[4, cont] <= 3)
                {
                    res = num[4, cont]+ res;


                }

                if (num[5, cont] <= 3)
                {
                    res = num[5, cont] +res;

                   
                }

                cont++; // solo aumenta mis cont para que vaya cambiando mi if == de 0,cont = a lo que vaya cont 

            }

            Console.WriteLine(res);//muetra res







        }
    }
}
