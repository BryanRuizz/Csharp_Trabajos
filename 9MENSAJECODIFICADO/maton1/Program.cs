using System;

namespace MENSAJECODIFICADO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string msndecodificado;
            string msncodificado, letras;
            int contador, numerodeletras;

            Console.WriteLine("ESCRIBE UN MENSAJE *DECODIFICADO*");
            msndecodificado = Console.ReadLine();
            numerodeletras = msndecodificado.Length;
            contador = 0;
            msncodificado = "";
            while(contador< numerodeletras)
            {
                letras = msndecodificado.Substring(contador, 1);
                if (letras == "A")
                {
                    msncodificado += "Y";
                }
                if (letras == "B")
                {
                    msncodificado +=  "Z";
                }

                if (letras == "C")
                {
                    msncodificado += "A";
                }

                if (letras == "D")
                {
                    msncodificado +=  "B";
                }

                if (letras == "E")
                {
                    msncodificado +=  "C";
                }
                if (letras == "F")
                {
                    msncodificado +=  "D";
                }
                if (letras == "G")
                {
                    msncodificado +=  "F";
                }
                if (letras == "H")
                {
                    msncodificado +=  "G";
                }
                if (letras == "I")
                {
                    msncodificado +=  "H";
                }

                if (letras == "J")
                {
                    msncodificado +=  "I";
                }

                if (letras == "K")
                {
                    msncodificado +=  "J";
                }

                if (letras == "L")
                {
                    msncodificado +=  "K";
                }
                if (letras == "M")
                {
                    msncodificado +=  "L";
                }

                if (letras == "N")
                {
                    msncodificado +=  "M";
                }

                if (letras == "Ñ")
                {
                    msncodificado +=  "N";
                }

                if (letras == "O")
                {
                    msncodificado +=  "Ñ";
                }

                if (letras == "P")
                {
                    msncodificado +=  "O";
                }
               

                if (letras == "Q")
                {
                    msncodificado +=  "P";
                }
                if (letras == "R")
                {
                    msncodificado +=  "Q";
                }
                if (letras == "S")
                {
                    msncodificado +=  "R";
                }

                if (letras == "T")
                {
                    msncodificado +=  "S";
                }
                if (letras == "V")
                {
                    msncodificado +=  "T";
                }
                if (letras == "W")
                {
                    msncodificado +=  "U";
                }
                if (letras == "X")
                {
                    msncodificado +=  "V";
                }

                if (letras == "Y")
                {
                    msncodificado +=  "W";
                }

                if (letras == "Z")
                {
                    msncodificado +=  "X";
                }

               





                contador++;
            }
            Console.WriteLine("EL MENSAJE CODIFICADO FUE :");
            Console.WriteLine(msncodificado);


            Console.ReadKey();
        }

    }
}
