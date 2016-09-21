using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_de_la_moyenne_ponderee
{
    class Program
    {
        static void Main()
        {
        Double NoteDevoir;
        Double NoteEcrite;
        Double NoteTravaux;
        Double MoyennePonderee;
        String StrNoDev;
        String StrNoEc;
        String StrNoTr;

            // Numéro de version et fonctionnalité
            Console.WriteLine("                   **** CALCUL DE LA MOYENNE PONDEREE DES NOTES D’UN ETUDIANT DANS UNE MATIERE (V1.0, 08 / 07 / 16) ****");
            Console.WriteLine();
            // Demande de saisie de valeur
            Console.WriteLine("Indiquez la note du devoir surveillé : ");
            StrNoDev = Console.ReadLine();
            NoteDevoir = Convert.ToDouble(StrNoDev)*3;
            Console.WriteLine();
            Console.WriteLine("Indiquez la note de l'interrogation écrite : ");
            StrNoEc = Console.ReadLine();
            NoteEcrite = Convert.ToDouble(StrNoEc)*2;
            Console.WriteLine();
            Console.WriteLine("Indiquez la note de travaux pratique : ");
            StrNoTr = Console.ReadLine();
            NoteTravaux = Convert.ToDouble(StrNoTr)*1;
            Console.WriteLine();
            // Calcul de la moyenne pondérée
            MoyennePonderee = (NoteDevoir + NoteEcrite + NoteTravaux) / 6;
            Console.WriteLine("La moyenne pondérée est : " + MoyennePonderee);
            Console.ReadLine();
                
        }
    }
}
