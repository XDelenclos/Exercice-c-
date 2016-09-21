using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_mini_maxi
{
    class Program
    {
        static void Main()
        {
            double min, max, i;

            //Note de version
            Console.WriteLine("****** Mini & Maxi V1.0 , 12/07/2016 ******");
            Console.WriteLine();

            min = 0;
            max = 0;
            i = 1;
            while (i != 0)
            {
                Console.WriteLine("Saisissez un chiffre : ");
                i = Convert.ToDouble(Console.ReadLine());
                if (i > max)
                {
                    max = i;
                }
                else if (min < max & i!= 0)
                {
                    min = i;
                }
             }
                Console.WriteLine("La valeur maximale est de : " + max + " et la valeur minimale est de : " + min);
                Console.ReadLine();
            
        }
    }
}

