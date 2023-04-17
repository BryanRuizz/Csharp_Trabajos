using System;

namespace homework2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            String respuesta = "SI";

            while (respuesta == "SI" || respuesta == "si")  //para repetir el programa 
            {



                String let1;
                int cont1 = 0;
                int loong;



                Console.WriteLine("ESCRIBE UNA PALABRA ");
                let1 = Console.ReadLine();


                loong = let1.Length; // es para mostrar el numero de letras que tiene   //contador mas unos es cont ++ 
                Console.WriteLine("la palabra  " + let1 + "    tiene una longitud de : " + loong.ToString() + "caracteres. "); // solo te mustra el numero


                while (cont1 < loong)
                {

                    Console.WriteLine(let1.Substring(cont1, 1));
                    cont1++;//es como el contador = contador +1




                }








                Console.WriteLine("DESEAS REPETIR EL PROGRAMA ");
                respuesta = Console.ReadLine();
            }


        }
    }
}
