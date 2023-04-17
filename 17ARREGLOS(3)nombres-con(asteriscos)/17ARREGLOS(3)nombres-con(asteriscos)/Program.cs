using System;

namespace _17ARREGLOS_3_nombres_con_asteriscos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int contador = 0;
            string[,] var = new string[5, 6];  // arreglo para el ticket final
            string[] posiciones = new string[4];// ya esta usado para las posiciones de los asterisco 

            
            int acumulador = 0, promedio = 0, promfinal = 0;


            // ciclo para repetirlo
            while (contador < 3)
            {

                string palabra, lxl = "", nom = "", apellido = "", u1 = "", u2 = "", u3 = "";
                int cont = 0, lg = 0, i = 0;

                Console.WriteLine("");




                Console.WriteLine("escribe tu nombre, apellido y calis de la u1, u2, u3 separando datos por * ");
                Console.WriteLine("ej:    bryan andres*santillan ruiz*100*90*80");          // escribir el nombre del user 

                palabra = Console.ReadLine(); // leer
                lg = palabra.Length;



                //el cortador de siempre xd  corta asteriscos
                while (cont < lg)
                {
                    lxl = palabra.Substring(cont, 1);


                    if (lxl == "*")
                    {

                        posiciones[i] = cont.ToString();

                        i++;

                    }

                    cont++;
                }

                /*for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(posiciones[j]);
                }*/


                // de la posicion 0 a la posicion de mi primer asterisco, es posicion se guardo antes del incremento en una temporal(arreglo) para saber donde esta

                nom = palabra.Substring(0, Convert.ToInt32(posiciones[0])); // uso mi posicion 0 de mi arreglo y segun cuantos asteriscos sera el numero de espacio de mi arreglo
                // Console.WriteLine(nom);
                var[contador, 0] = nom;

                // y la posicion 0 llega a 11 
                // 1234567891011           12
                // bryan andres(y llegamos al ->*
                // de 12 hasta el sig * por eso mas 1
                // cuando lo usamos seria *
                // hasta aqui usamos el 0 del arreglo +1 para sqaltar el asterisco
                // y de posicion 1 menos posicion 0 por que agarraria todo pero ya no necesitamos la 0 ya esta arriba y el menos 1 para quitar el asterisco 2
                apellido = palabra.Substring(Convert.ToInt32(posiciones[0]) + 1, Convert.ToInt32(posiciones[1]) - Convert.ToInt32(posiciones[0]) - 1);
                //Console.WriteLine(apellido);
                var[contador, 1] = apellido;    // esto lo guarda en mi arreglo deacuerdo al contador de m while repetidor 


                u1 = palabra.Substring(Convert.ToInt32(posiciones[1]) + 1, Convert.ToInt32(posiciones[2]) - Convert.ToInt32(posiciones[1]) - 1);
                // Console.WriteLine(u1);
                var[contador, 2] = u1;


                u2 = palabra.Substring(Convert.ToInt32(posiciones[2]) + 1, Convert.ToInt32(posiciones[3]) - Convert.ToInt32(posiciones[2]) - 1);
                // Console.WriteLine(u2);
                var[contador, 3] = u2;


                // use mi cont del 2do while por que ahi conto todo y si le restaba la posicion ultima(3) de los asterisco -1 me da los numeors por si son 2 o 3 y asi si no se sale de linea



                u3 = palabra.Substring(Convert.ToInt32(posiciones[3]) + 1, cont - Convert.ToInt32(posiciones[3]) - 1);
                //Console.WriteLine(u3);
                var[contador, 4] = u3;


                promedio = (Convert.ToInt32(u1) + Convert.ToInt32(u2) + Convert.ToInt32(u3)) / 3;  // covierto mis strings de unidades a  int o enteros y los puedo sumar y dividir para un promedio
                //dejaa ver xd
                var[contador, 5] = promedio.ToString();

                Console.WriteLine("su promedio es : " + promedio.ToString());

                acumulador += promedio; // guardo todos los promedios en una acumulacion 
                contador++;

            }



            promfinal = acumulador / 3;
            Console.WriteLine("");



            Console.WriteLine("");



            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("el nombres es   " + var[j, 0] + "       apellido     " + var[j, 1] + " u1 " + Convert.ToInt32(var[j, 2]) + " u2 " + var[j, 3] + " u3 " + var[j, 4] + " y su promedio para esas unidades fue :" + var[j, 5]);
                Console.WriteLine("");

            }

            Console.WriteLine("");

            Console.WriteLine("el promedio de promedios es : " + promfinal);




            Console.ReadKey();
        }
    }
}
