using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main()
        {
            //Déclaration de variable
            string StrCalc1;
            string StrCalc2;
            Double Calc1;
            Double Calc2;
            double Resultat;

             //Numéro de version et fonctionnalité
            Console.WriteLine("                             ****Calculatrice (V1.0, 08 / 07 / 16) ****");
            Console.WriteLine();
            
            // Etape 1 : lecture de la premiere saisie
            Console.WriteLine("     Entrer votre 1ere valeur : ");
            StrCalc1 = Console.ReadLine();
            Console.WriteLine();
            // Etape 2 : lecture de la deuxième saisie
            Console.WriteLine("     Entrer votre 2eme valeur : ");
            StrCalc2 = Console.ReadLine();
            Console.WriteLine();
            // Etape 3 : Conversion des données
            Calc1 = Convert.ToDouble(StrCalc1);
            Calc2 = Convert.ToDouble(StrCalc2);
            // Etape 4 : Calcul
            Resultat = Calc1 / Calc2;
            Console.WriteLine("Le résultat de  " + Calc1 + " : "  + Calc2 +" est : ");
            Console.WriteLine();
            Console.WriteLine( Resultat);
            Console.ReadLine();

            
         
        }
    }
}
