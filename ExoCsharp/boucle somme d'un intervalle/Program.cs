using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle_somme_d_un_intervalle
{
    class Program
    {
        static void Main()
        {
            double N1, N2;
            string Stn1, Stn2;

            //Note de Version
            Console.WriteLine("*****************Somme d'un intervalle V1.0 , 12/07/2016****************");
            Console.WriteLine();
            Console.WriteLine("Saisissez un chiffre : ");
            Stn1 = Console.ReadLine();
            N1 = Convert.ToDouble(Stn1);
            Console.WriteLine("Saisissez un second chiffre : ");
            Stn2 = Console.ReadLine();
            N2 = Convert.ToDouble(Stn2);

            if (N1 > N2)
            {
                while (N1 != N2)
                {
                    Console.WriteLine("{0} = {1}", N1 - 1, ((N1 / 2) * (N1 + 1)) - N1);
                    N1--;
                }
                Console.ReadLine();
            }
           
            if (N1 < N2)
            {
                while (N1 != N2)
                {
                    Console.WriteLine("{0} = {1}", N1 + 1, ((N1 / 2) * (N1 + 1)) + N1);
                    N1++;
                }
                Console.ReadLine();
            }                      
        }
    }
}
