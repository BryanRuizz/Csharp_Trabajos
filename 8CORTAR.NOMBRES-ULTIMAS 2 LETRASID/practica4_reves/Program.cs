using System;

namespace practica4_reves
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string resp = "si", nombrecompleto, letra, clave=" ",ultimo;//DECLARAS
            int numerodeletras, cont = 0;//MIS CONTADORES Y LOS LEGTHS XD NUMLETRAS PARA SABER EL NUEMRO DE LETRAS Y LAS VECES QUE PASRA POR EL WHILE


            while (resp == "si")
            {
                Console.WriteLine("captura tu nombre completo");

                nombrecompleto = Console.ReadLine();// AQUI ASIGNAS VALOR


                numerodeletras = nombrecompleto.Length;//USAR EL LEGTH PARA SABER CUATAS LETRAS TIENE

                //MI CONTAADOR = 0  && NUMERO DE LETRAS PUES LAS LETRAS DE LLA PALABRAS QUE PUSE
                while (cont < numerodeletras)
                {//MI STRING SERA IGUAL AL NOMC DE CONTADOR EN LO QUE VAYA PARA CORTAR SOLO UNO
                    letra = nombrecompleto.Substring(cont, 1);
                    //NOMV= BRYAN EX
                    //EJEMPLO        (CONT = 1 , 1)
                    // HASTA AQUI LLEVAMOS B Y DESPUES R 
                



                    cont = cont + 1;// CONTADOR INCREMENTA

     

                    if (letra == " ")//SI LETRA QUE ES NOMC LLEGA A TENER " "(ESPACIO)
                    {    
                                                                  //123,45(corta dos y quita 3 )
                        //GUARA MAS COMO LETRA PER DIFERENTE   EX   BRYAN
                        clave =clave+nombrecompleto.Substring(cont - 3, 2);

                       
                    }


                }                       //12,34,5
                //MAS PARA GUARDAR        BRYAN
                ultimo = nombrecompleto.Substring(cont-2 , 2);



                 clave= clave +ultimo;
                Console.WriteLine("su clave es :"+clave);


                Console.WriteLine("desea repetir el programa?");
                resp = Console.ReadLine();


            }















        }
    }
}
