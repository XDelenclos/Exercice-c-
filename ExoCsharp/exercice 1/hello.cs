using System;
using System.Collections.Generic;
using System.Text;
namespace TPCSharp
{
    class Cercle
    {
        static void Main()
          {
          //Declaration de variables. 
          string saisie; // variable recevant la saisie
          double rayon; // rayon
          double perimetre; // périmètre
          double surface;  // surface 

            //Numéro de version et fonctionnalité
            Console.WriteLine("                             ****Périmètre et surface du Cercle (V1.0, 07 / 07 / 16) ****");
            Console.WriteLine();
            Console.WriteLine();
            // Etape 1 : lecture du rayon
            Console.WriteLine("     Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();
            Console.WriteLine();
            // Etape 2 : calcul et affichage du périmètre
            rayon = Convert.ToDouble(saisie);
        //Calcul du perimetre
        perimetre = 2 * Math.PI* rayon;
        //Calcul de la surface 
        surface = Math.PI * (rayon * rayon);
        Console.Write("     Le cercle de rayon " + rayon);
        Console.Write(" a pour périmetre : " + perimetre);
        Console.Write(" et pour surface : " + surface);
        Console.WriteLine();
        // Permet de conserver l'affichage de la console
        Console.ReadLine(); 
        }
    }
}
