using System;

namespace CONTADOR_NEGATIVO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int cont;
            string word;
            Console.WriteLine("ESCRIBE UNA PALABRA ");
            word = Console.ReadLine();

            cont = word.Length;
            string otra = "";
            while (cont> 0)
            
            {




                 //                        hola
                 //                       4-1=3 = hol, corta  "a"
                 //                       3-1=2 = ho, corta "l"
                otra = otra+ word.Substring(cont - 1, 1) ;
               





                cont--;
            }


            Console.WriteLine(otra);
            Console.ReadKey();
        }
    }
}
