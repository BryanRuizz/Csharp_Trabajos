using System;

namespace practica2
{
    class MainClass
    {
        public static void Main(string[] args)

        {

            String respuesta = "SI";//aqui damos el si para ingresar al while

            while (respuesta == "SI" || respuesta == "si")  //para repetir el programa 
            {


             String let1, corte ;//let es la palabra que cortaremos la que el user ingresa y el corte lo comvertiremos a int
             int cort1;//donde iniciara el corte pero no la inicializamos por que el user lo hara
                int cort2, loong;//segundo corte y loong de longitude del alrgo de la palabra
                



             Console.WriteLine("ESCRIBE UNA PALABRA ");//pregunta para el user
                let1 = Console.ReadLine();//pone el su respuesta mira bien en string si pusiera un num usamos int


                loong = let1.Length;//el length es para contar las letras del la palabra


                Console.WriteLine("la palabra  " + let1 + "  tiene una longitud de : "+  loong.ToString() +  "caracteres. ");//loong en tostring para poder mostrarlo en writeline


               

             Console.WriteLine("¿EN QUE LUGAR INICIO A CORTAR ? ");
                cort1 = Convert.ToInt32(Console.ReadLine());//convert.toint32 para poder leer un numero y convertirlo a entero

             Console.WriteLine("¿EN QUE LUGAR termino el corte  A CORTAR ? ");
                cort2 = Convert.ToInt32(Console.ReadLine());//igual que corte 1


                corte = let1.Substring(cort1, cort2); // aqui se hace el corte con las dos int y ayuda del substring (inicio y cuantos corta) 

                Console.WriteLine(corte);// solo lo muestra en una var de tipo string







                Console.WriteLine("¿DESEAS REPETIR EL PROGRAMA SI O NO?");//parte final del while
             respuesta = Console.ReadLine();// solo lee respuesta si o SI
            }


        }
    }
}
