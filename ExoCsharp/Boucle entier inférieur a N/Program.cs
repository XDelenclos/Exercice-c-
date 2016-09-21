using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_entier_inférieur_a_N
{
    class Program
    {
        static void Main()
        {
            int i;
            string sti;
            Console.WriteLine("N décroissant");
            Console.WriteLine("Saisissez un chiffre : ");
            sti = Console.ReadLine();
            i = Convert.ToInt32(sti);
            while (i != -1)
            {
                Console.WriteLine("{0}", i);
                i--;
                
            }
            Console.ReadLine();

        }
    }
}
