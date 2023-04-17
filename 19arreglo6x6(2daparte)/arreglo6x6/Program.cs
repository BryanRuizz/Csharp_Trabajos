using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo6x6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[6, 6];  // lo guardo en array 
            int res = 0;
            int cont = 0;

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


            // lo mustro con un for with hardcore y el ciclo 
            //con otro ciclo lo uso para hacer para que aparte en cada num ex 0 se meta 6 veces a ese cero i solo aumente el cont = i para que se reinice 
            // Y asi sacar la suma directo 

            for (int i = 0; i<6; i++)
            {

                Console.WriteLine(num[i,0]+"   "+num[i,1]+"    "+num[i, 2] + "   " + "   " + num[i, 3] + "    " + num[i, 4] + "   "+num [i,5]);
                cont = i;
                while (cont < 6)
                {
                    if (num[cont, i]<=3)
                    {
                        res += num[cont, i];
                    }

                    cont++;
                }
            }

            Console.WriteLine(res.ToString());


            Console.ReadKey();
        }
    }
}
