using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_de_bases
{
    class Program
    {
        static void Main(string[] args)
        {
            double Bin = 0;    
            Console.WriteLine("Entrez un nombre en base 2 :");
            String Saisie = Console.ReadLine();
            int nbr = Convert.ToInt32(Saisie);
            int lg = Saisie.Length-1;
            //Console.WriteLine(nbr);
            foreach (char item in Saisie)
            {
                
                    Bin += Convert.ToInt32(Convert.ToString(item)) *(Math.Pow(2,lg));
                    lg--;
                
            }
            Console.WriteLine(Bin);
            Console.ReadLine();
        }
    }
}
