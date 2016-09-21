using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Age
{
    class Program
    {
        static void Main()
        {
            int Age;
            int Annee;
            int Resultat;
            String AgeStr;
            String DateTest;
            
            // Numéro de version et fonctionnalité
            Console.WriteLine("                   ****Parité (V1.0, 11 / 07 / 16) ****");
            Console.WriteLine();
            // demande saisie utilisateur
            Console.Write(" Saisissez votre année de naissance : ");
            AgeStr = Console.ReadLine();
            Age = Convert.ToInt32(AgeStr);
            DateTest = DateTime.Now.ToString("yyyy");
            //Console.WriteLine(DateTest);
            Annee = Convert.ToInt32(DateTest);
            Resultat = (Annee - Age);
            if (Resultat > 18)
            {
                Console.WriteLine("Vous êtes Majeur");
                if (Resultat > 70)
                {
                    Console.WriteLine("Et Vous êtes un dinosaure !!!");
                }
            }
            else
            { Console.WriteLine("Vous êtes Mineur"); }
            Console.ReadLine();
        }
    }
}
