using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp__Condition
{
    class Program
    {
        static void Main()
        {
            string a;
            int Calc;
            int Reste;

            // Numéro de version et fonctionnalité
            Console.WriteLine("                   ****Parité (V1.0, 11 / 07 / 16) ****");
            Console.WriteLine();
            // demande saisie utilisateur
            Console.Write(" Saisissez une valeur : ");
            a = Console.ReadLine();
            Calc = Convert.ToInt32(a);
            Reste = Calc % 2;
            if (Reste == 0)
            {
                Console.WriteLine("Votre chiffre est pair");
            }
           else
            {
            Console.WriteLine("Votre chffre est impair");
            }
            Console.ReadLine();
            
            
        }
    }
}
