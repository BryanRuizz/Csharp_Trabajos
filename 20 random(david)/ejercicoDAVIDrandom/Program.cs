using System;

namespace ejercicoDAVIDrandom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string [,] grupo = new string[4, 12];
            Random ale = new Random();
            string r,res = "";



            grupo[0, 0] = "bryan";
            grupo[0, 1] = "bin";
            grupo[0, 2] = "andrea";
            grupo[0, 3] = "juan";
            grupo[0, 4] = "jesus";
            grupo[0, 5] = "ernesto";
            grupo[0, 6] = "salamanca";
            grupo[0, 7] = "daniel";
            grupo[0, 8] = "maria";
            grupo[0, 9] = "yessica"; 
            grupo[0, 10] = "magda";
            grupo[0,11] = "rubi";

            grupo[1, 0] = "goku";
            grupo[1, 1] = "bulma";
            grupo[1, 2] = "kakaroto";
            grupo[1, 3] = "gohan";
            grupo[1, 4] = "bryan";
            grupo[1, 5] = "roshi";
            grupo[1, 6] = "yayirobe";
            grupo[1, 7] = "trunks";
            grupo[1, 8] = "vegeta";
            grupo[1, 9] = "pam";
            grupo[1, 10] = "goten";
            grupo[1, 11] = "milk";

            grupo[2, 0] = "makoto";
            grupo[2, 1] = "nagano";
            grupo[2, 2] = "junkook";
            grupo[2, 3] = "mia";
            grupo[2, 4] = "eva";
            grupo[2, 5] = "wody";
            grupo[2, 6] = "buzz";
            grupo[2, 7] = "andy";
            grupo[2, 8] = "locso";
            grupo[2, 9] = "imelda";
            grupo[2, 10] = "inuyashiki";
            grupo[2, 11] = "riuuu";

            grupo[3, 0] = "rietzu";
            grupo[3, 1] = "saitama";
            grupo[3, 2] = "genos";
            grupo[3, 3] = "gogetzu";
            grupo[3, 4] = "rias";
            grupo[3, 5] = "naruto";
            grupo[3, 6] = "tsunade";
            grupo[3, 7] = "jiraya";
            grupo[3, 8] = "sasuke";
            grupo[3, 9] = "sakura";
            grupo[3, 10] = "hinata";
            grupo[3, 11] = "ino";

            Console.WriteLine("de que grupo desea elegir  son 4 grupos el 1, 2, 3, 4");
            Convert.ToInt32( r) = Console.ReadLine();

            if (r == 1)
            {
                r = 0;
            }
            if (r == 1)
            {
                r = 2;
            }

            if (r == 2)
            {
                r = 3;
            }
            if (r == 3)
            {
                r = 4;
            }

            for (int j = 0; j < 4; j++)
            {

                for (int p = 0; p < 12; p++)
                {
                    res = ale.Next(0,12 );
                    
                    grupo[r, j] = res;
                    


                }
                Console.WriteLine(res);

            }










        }
    }
}
