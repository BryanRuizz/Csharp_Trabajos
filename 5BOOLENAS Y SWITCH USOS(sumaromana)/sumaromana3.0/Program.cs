using System;

namespace sumaromana3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String respuesta = "SI";

            while (respuesta == "SI" || respuesta == "si")  //para repetir el programa 
            {

                //empieza declara 
                String numrom;// declaramos 

                String num2, res;

                int numa1;
                int numa2; int resulatdo;
                numa1 = 0;
                numa2 = 0;



                bool erro = false;
                // termina declarar


                Console.WriteLine("BIENVENIDO AL PROGRAMA PARA SUMAR NUMEROS ROMANOS ");
                Console.WriteLine("CAPTURA UN NUMERO DEL I AL X ");






                numrom = Console.ReadLine();//aqui se lo asignas el valor


                Console.WriteLine(numrom);//aqui lo lee
                                          // AQUI AREMOS VALIDACION DE DATOS DELI AL X

                // RECUERDA && ESTO ES AND Y || ESTO ES OR  PUT IT WITH THE TECLAS ALT GR AND 4 AND ALT GR 1 

                switch (numrom)

                {
                    case "I":

                        Console.WriteLine(numrom + " EL NUMERO I CORRESPONDE AL 1 ARABVIGO");
                        numa1 = 1;
                        break;
                    case "II":

                        Console.WriteLine(numrom + " EL NUMERO II CORRESPONDE AL 2 ARABVIGO");
                        numa1 = 2;
                        break;

                    case "III":

                        Console.WriteLine(numrom + " EL NUMERO III CORRESPONDE AL 3 ARABVIGO");
                        numa1 = 3;
                        break;
                    case "IV":

                        Console.WriteLine(numrom + " EL NUMERO IV CORRESPONDE AL 4 ARABVIGO");
                        numa1 = 4;
                        break;



                    case "V":

                        Console.WriteLine(numrom + " EL NUMERO V CORRESPONDE AL 5 ARABVIGO");
                        numa1 = 5;
                        break;
                    case "VI":

                        Console.WriteLine(numrom + " EL NUMERO VI CORRESPONDE AL 6 ARABVIGO");
                        numa1 = 6;
                        break;

                    case "VII":

                        Console.WriteLine(numrom + " EL NUMERO VII CORRESPONDE AL 7 ARABVIGO");
                        numa1 = 7;
                        break;
                    case "VIII":

                        Console.WriteLine(numrom + " EL NUMERO VIII CORRESPONDE AL 8 ARABVIGO");
                        numa1 = 8;
                        break;

                    case "IX":

                        Console.WriteLine(numrom + " EL NUMERO IX CORRESPONDE AL 9 ARABVIGO");
                        numa1 = 9;
                        break;
                    case "X":

                        Console.WriteLine(numrom + " EL NUMERO X CORRESPONDE AL 10 ARABVIGO");
                        numa1 = 10;
                        break;


                    default:
                        Console.WriteLine(numrom + "    NO ES NUMERO DEL I AL X");
                        numa1 = 0;
                        erro = true;
                        break;

                }




                Console.WriteLine("CAPTURA EL SEGUNDO NUMERO");

                Console.WriteLine("CAPTURA UN NUMERO DEL I AL X ");






                num2 = Console.ReadLine();//aqui se lo asignas el valor


                Console.WriteLine(num2);//aqui lo lee
                                        // AQUI AREMOS VALIDACION DE DATOS DELI AL X

                // RECUERDA && ESTO ES AND Y || ESTO ES OR  PUT IT WITH THE TECLAS ALT GR AND 4 AND ALT GR 1 

                switch (num2)

                {
                    case "I":

                        Console.WriteLine(num2 + " EL NUMERO I CORRESPONDE AL 1 ARABVIGO");
                        numa2 = 1;
                        break;
                    case "II":

                        Console.WriteLine(num2 + " EL NUMERO II CORRESPONDE AL 2 ARABVIGO");
                        numa2 = 2;
                        break;

                    case "III":

                        Console.WriteLine(num2 + " EL NUMERO III CORRESPONDE AL 3 ARABVIGO");
                        numa2 = 3;
                        break;
                    case "IV":

                        Console.WriteLine(num2 + " EL NUMERO IV CORRESPONDE AL 4 ARABVIGO");
                        numa2 = 4;
                        break;



                    case "V":

                        Console.WriteLine(num2 + " EL NUMERO V CORRESPONDE AL 5 ARABVIGO");
                        numa2 = 5;
                        break;
                    case "VI":

                        Console.WriteLine(num2 + " EL NUMERO VI CORRESPONDE AL 6 ARABVIGO");
                        numa2 = 6;
                        break;

                    case "VII":

                        Console.WriteLine(num2 + " EL NUMERO VII CORRESPONDE AL 7 ARABVIGO");
                        numa2 = 7;
                        break;
                    case "VIII":

                        Console.WriteLine(num2 + " EL NUMERO VIII CORRESPONDE AL 8 ARABVIGO");
                        numa2 = 8;
                        break;

                    case "IX":

                        Console.WriteLine(num2 + " EL NUMERO IX CORRESPONDE AL 9 ARABVIGO");
                        numa2 = 9;
                        break;
                    case "X":

                        Console.WriteLine(num2 + " EL NUMERO X CORRESPONDE AL 10 ARABVIGO");
                        numa2 = 10;
                        break;


                    default:
                        Console.WriteLine(num2 + "     " + "NO ES NUMERO DEL I AL X");
                        numa1 = 0;
                        numa2 = 0;
                        erro = true;
                        break;

                }








                {

                    if (erro == true)

                        Console.WriteLine(" NO SE PUEDE CONTINUAR POR ASIGNAR MAL LAS VARIABLES ");





                    else
                    {


                        Console.WriteLine("EL PRIMER NUM ROMANO FUE        :" + numrom + "     Y EL SEGUNDO FUE :   " + num2);
                        res = num2 + numrom;


                        Console.WriteLine("EL RESULTADO FUE : " + res);



                        resulatdo = numa1 + numa2;


                        Console.WriteLine("EL RESULTADO FUE : " + resulatdo.ToString());

                    }

                }







                Console.WriteLine("DESEAS REPETIR EL PROGRAMA ");
                respuesta = Console.ReadLine();
            }
        }
    }
}
