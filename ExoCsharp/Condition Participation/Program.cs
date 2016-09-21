using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Participation
{
    class Program
    {
        static void Main()
        {
            string Statut;
            string NbEnfant;
            string salaire;
            double numsalaire;
            double Particip;
            double Enfant;


            // Version
            Console.WriteLine("***********Calculateur de participation v1, 11/07/2016**************");
            Console.WriteLine();
            // Saisie utilisateur
            Console.WriteLine("Quel est votre salaire ?");
            salaire = Console.ReadLine();
            numsalaire = Convert.ToDouble(salaire);
            Console.WriteLine("Quel est votre statut marital ?");
            Console.WriteLine("'M' pour Marié, 'C' pour Célibataire");
            Statut = Console.ReadLine();
            Console.WriteLine("Combien avez vous d'enfant?");
            NbEnfant = Console.ReadLine();
            Enfant = Convert.ToDouble(NbEnfant);
            // Conditions d'attribution de la participation
            if ((Statut == "C") & (numsalaire <= 1200))
            {
                Particip = 20 + (Enfant * 10) + 10;
                if (Particip > 50)
                {
                    Particip = 50;
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
            }
            else if ((Statut == "C") & (numsalaire > 1200))
            {
                Particip = 20 + (Enfant * 10);
                if (Particip > 50)
                {
                    Particip = 50;
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
            }
            else if ((Statut == "M") & (numsalaire <= 1200))
            {
                Particip = 25 + (Enfant * 10) + 10;
                if (Particip > 50)
                {
                    Particip = 50;
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
            }
            else if ((Statut == "M") & (numsalaire > 1200))
            {
                Particip = 25 + (Enfant * 10);
                if (Particip > 50)
                {
                    Particip = 50;
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("votre participation est de :" + Particip + "%");
                    Console.ReadLine();
                }
            }
                Console.ReadLine();

        }
    }
}
   
        

