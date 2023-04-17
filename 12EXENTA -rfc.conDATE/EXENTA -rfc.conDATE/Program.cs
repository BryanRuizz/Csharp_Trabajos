using System;

namespace exentacion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String NOMBRECOMPLETO = "";
            string DATE = "";
            string FECCHA, LETRA = "";
            string WORD = "";
            string RFC ="";
            int CONT = 0;
            int CONTA = 0;
            int LARGOLETRA = 0;
            int LOONGLETRA = 0;
            int FECHA2 = 0;



            Console.WriteLine("INGRESA TU NOMBRE Y FECHA DE NACIMIENTO PARA GENERAR RFC");
            Console.WriteLine(" ");
            Console.WriteLine(" INGRESE SU NOMBRE COMPLETO");
            NOMBRECOMPLETO = Console.ReadLine();

            RFC = NOMBRECOMPLETO.Substring(0, 2);
            LARGOLETRA= NOMBRECOMPLETO.Length;
            while (CONT < LARGOLETRA)
            {
                LETRA = NOMBRECOMPLETO.Substring(CONT, 1);
                if (LETRA == " ")
                {
                    RFC = RFC + NOMBRECOMPLETO.Substring(CONT + 1, 1);
                }
                CONT= CONT+1;
            }
            RFC = RFC.Substring(0, 2) + RFC.Substring(-3, 2);

            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO POR FAVOR (DD/MM/AA)");
            DATE = Console.ReadLine();

            RFC = RFC +DATE.Substring(0, 2) + DATE.Substring(3, 2) + DATE.Substring(8, 2);

            while (CONTA < LARGOLETRA)
            {
                LETRA = NOMBRECOMPLETO.Substring(CONTA, 1);
                {
                    WORD = WORD + LETRA;
                    if (LETRA == " ")
                    {
                        LOONGLETRA = WORD.Length - 1;
                        WORD = WORD.Substring(0, LOONGLETRA);
                    }
                }
                CONTA= CONTA+1;
            }
            FECCHA = DATE.Substring(3, 2);
            FECHA2 = Convert.ToInt32(FECCHA);
            RFC =RFC+ WORD.Substring(FECHA2, 1);
            RFC= RFC+ DATE.Substring(6, 2);
            Console.WriteLine("SU RFC ES  : "+RFC);



            Console.ReadKey();
        }
    }
}
