using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_Somme_entier_inférieur_a_N
{
    class Program
    {
        static void Main()
        {
            //note de version 
            Console.WriteLine("***************Somme des entier inférieur à N******************");
            Console.WriteLine();
            double i;
            string sti;
            Console.WriteLine();
            Console.WriteLine("Saisissez un chiffre : ");
            sti = Console.ReadLine();
            i = Convert.ToDouble(sti);
            while (i != 0)
            {
                Console.WriteLine("{0} = {1}", i-1, ((i / 2) * (i + 1))-i);
                i--;

            }
                //Console.WriteLine("{i}", (i / 2) * (i + 1));
                Console.ReadLine();
            
        }

    }
}
