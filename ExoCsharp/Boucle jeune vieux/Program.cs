using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_jeune_vieux
{
    class Program
    {
        static void Main()
        {
            int i, age, Nbvieux, Nbmoyen, Nbjeune;


            i = 0;
            age = 0;
            Nbmoyen = 0;
            Nbvieux = 0;
            Nbjeune = 0;
            while (age != 100)
            {
                Console.WriteLine("Saisissez un âge :");
                age = Convert.ToInt16(Console.ReadLine());
                if ( age <20)
                {
                    Nbjeune++;
                }
                if ( age >= 20 & age<= 40)
                {
                    Nbmoyen++;
                }
                if (age> 40)
                {
                    Nbvieux++;
                }                        
            }
            Console.WriteLine(" il y a " + Nbjeune + " jeune(s)" + " , " + Nbmoyen + " d'age moyen et " + Nbvieux + " vieux.");
            Console.ReadLine();
        }
    }
}
