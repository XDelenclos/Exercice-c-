using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle_Multiples
{
    class Program
    {
        static void Main()
        {
            int X, N, i;

            //Note de version
            Console.WriteLine("****** Multiples V1.0 , 12/07/2016 ******");
            Console.WriteLine();

            Console.WriteLine("Saisissez un chiffre : ");
            X = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Saisissez un chiffre : ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Table de multiplication de " + X + " par les "+ N +" premiers chiffres.");
            Console.WriteLine("=============================================================");
            i = 1;
            while (i <= N)
            {
                Console.WriteLine("{0} * " + X + " = {1}", i, i * X);
                i++;
            }
            // Affichage persistant
            Console.ReadLine();

        }
    }
}
