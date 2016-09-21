using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_Moyenne
{
    class Program
    {
        static void Main()
        {
            double somme, moyenne, division, i;
           
            //Note de version
            Console.WriteLine("****** Somme & Moyenne ******");
            Console.WriteLine();

            division = 0;
            somme = 0;
            i = 1;
            while ( i != 0)
            {
                Console.WriteLine("Saisissez un chiffre : ");              
                i = Convert.ToDouble(Console.ReadLine());
                somme = somme + i;
                division++;
                          
            }
            moyenne = somme / (division-1);
            Console.WriteLine("La somme est de : " + somme + " et la moyenne est de : " + moyenne);
            Console.ReadLine();
           
        }
    }
}
