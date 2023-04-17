using System;

namespace MENSAJEDECODIFICADO
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
            while (contador < numerodeletras)
            {
                letras = msndecodificado.Substring(contador, 1);
                if (letras == "Y")
                {
                    msncodificado += "A";
                }
                if (letras == "Z")
                {
                    msncodificado += "B";
                }

                if (letras == "A")
                {
                    msncodificado += "C";
                }

                if (letras == "B")
                {
                    msncodificado += "D";
                }

                if (letras == "C")
                {
                    msncodificado += "E";
                }
                if (letras == "D")
                {
                    msncodificado += "F";
                }
                if (letras == "E")
                {
                    msncodificado += "G";
                }
                if (letras == "F")
                {
                    msncodificado += "H";
                }
                if (letras == "G")
                {
                    msncodificado += "I";
                }

                if (letras == "H")
                {
                    msncodificado += "J";
                }

                if (letras == "I")
                {
                    msncodificado += "K";
                }

                if (letras == "J")
                {
                    msncodificado += "L";
                }
                if (letras == "K")
                {
                    msncodificado += "M";
                }

                if (letras == "L")
                {
                    msncodificado += "N";
                }

                if (letras == "M")
                {
                    msncodificado += "Ñ";
                }

                if (letras == "N")
                {
                    msncodificado += "O";
                }

                if (letras == "Ñ")
                {
                    msncodificado += "P";
                }


                if (letras == "O")
                {
                    msncodificado += "Q";
                }
                if (letras == "P")
                {
                    msncodificado += "R";
                }
                if (letras == "Q")
                {
                    msncodificado += "S";
                }

                if (letras == "R")
                {
                    msncodificado += "T";
                }
                if (letras == "S")
                {
                    msncodificado += "U";
                }
                if (letras == "T")
                {
                    msncodificado += "V";
                }
                if (letras == "U")
                {
                    msncodificado += "W";
                }

                if (letras == "V")
                {
                    msncodificado += "X";
                }

                if (letras == "W")
                {
                    msncodificado += "Y";
                }







                contador++;
            }
            Console.WriteLine("EL MENSAJE CODIFICADO FUE :");
            Console.WriteLine(msncodificado);


        }

        }
    }
}
