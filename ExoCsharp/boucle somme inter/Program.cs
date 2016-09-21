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
            double N1, N2, somme;
            string Stn1, Stn2;

            // - Note de Version -
            Console.WriteLine("*****************Somme d'un intervalle V1.0 , 12/07/2016****************");
            Console.WriteLine();
            // - Saisie utilisateurs -
            Console.WriteLine("Saisissez un chiffre : ");
            Stn1 = Console.ReadLine();
            N1 = Convert.ToDouble(Stn1);
            Console.WriteLine("Saisissez un second chiffre : ");
            Stn2 = Console.ReadLine();
            N2 = Convert.ToDouble(Stn2);

            somme = N1;
            // - Condition n°1 -
            if (N1 < N2)
            {
                // - Boucle n°1 -
                while (N1 != N2)
                {
                N1++;
                somme = somme + N1;
                }
                Console.WriteLine("la somme de l'intervalle est de : " + somme);
            }
            // - Condition n°2 -
            if (N1 > N2)
            {
                // - Boucle n°2 -
                while (N1!= N2)
                {
                N1--;
                somme = somme + N1;
                }
                Console.WriteLine("la somme de l'intervalle est de : " + somme);
            }
            Console.ReadLine();  
        }
    }
}
