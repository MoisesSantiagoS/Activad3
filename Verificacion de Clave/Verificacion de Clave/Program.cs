using System;

namespace Verificacion_de_Clave
{
    class Program
    {
        static void Main(string[] args)
        {
            byte K, SW;
            string clave;
            SW = 0; K = 0;

            do
            {
                Console.Write("Digite su clave: "); clave = Console.ReadLine();
                if ((clave.ToUpper() == "ARIEL"))
                {
                    SW = 1;
                }
                else
                {
                    K++;
                }
            } while (((K < 3) & (SW == 0)));

            if (SW == 1)
            {
                Console.WriteLine("Bienvenido " + clave);
            }
            else
            {
                Console.WriteLine("Oportunidades Terminadas");

            }
        }
    }
}
