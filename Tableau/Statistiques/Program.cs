using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistiques
{
    class Program
    {
        static void Main(string[] args)
        {           
            int?[] TabNb = new int?[50];
            int? somme= 0, moyenne;
            int? Maxi, Mini;

            for (int i = 0; i < TabNb.Length; i++)
            {
                Console.WriteLine("Entrer un chiffre :");
                string Saisie = Console.ReadLine();
                if (Saisie == "")
                {
                    break;
                }
                TabNb[i] = Convert.ToInt32(Saisie);                
            }
            Maxi=TabNb.Max();
            Mini = TabNb.Min();
            somme = TabNb.Sum();
            moyenne = Convert.ToInt32(TabNb.Average());
           
            Console.WriteLine("Resultat");
            Console.WriteLine("Le Minimun est : "+Mini);
            Console.WriteLine("Le Maximum est : " + Maxi);
            Console.WriteLine("La Moyenne est : " + moyenne);
            Console.ReadLine();
        }
    }
}
