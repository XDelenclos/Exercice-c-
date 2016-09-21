using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Remise
{
    class Program
    {
        static void Main()
        {
        Double PU;
        Double QTECOM;
        Double PAP;
        Double PORT;
        Double REMISE;
        Double TOT;
        string StPU;
        string StQTE;

            // Note de version
            Console.WriteLine("**********Calculateur de remise & frais de port V1.0, 11/07/2016***************");
            Console.WriteLine();
            // Saisie utilisateur
            Console.WriteLine("Saisissez le Prix de votre article : ");
            StPU = Console.ReadLine();
            Console.WriteLine("Saisissez votre Quantité : ");
            StQTE = Console.ReadLine();
            PU = Convert.ToDouble(StPU);
            QTECOM = Convert.ToDouble(StQTE);
            // Calcul du total de la commande
            TOT = PU * QTECOM;
            PORT = (TOT * 0.02);
            // Condition
            if (TOT > 500)
            {
                PORT = 0;
                REMISE = (TOT * 0.1);
                Console.WriteLine("Prix unitire : " + PU + "E");
                Console.WriteLine("Quantité : " + QTECOM);
                Console.WriteLine("Frais de Port : " + PORT + "E");
                Console.WriteLine("Remise : " + REMISE + "E");
                // Calcul du nouveau total
                PAP = ((PU * QTECOM) - REMISE);
                Console.WriteLine("Le total de votre commande est de : " + PAP + "E");
            }
            else if (TOT > 200 & TOT <= 500)
            {

                REMISE = (TOT * 0.1);
                if (PORT < 6)
                {
                    PORT = 6;
                    Console.WriteLine("Prix unitire : " + PU + "E");
                    Console.WriteLine("Quantité : " + QTECOM);
                    Console.WriteLine("Frais de Port : " + PORT + "E");
                    Console.WriteLine("Remise : " + REMISE + "E");
                    // Calcul du nouveau total
                    PAP = ((PU * QTECOM) - REMISE) + PORT;
                    Console.WriteLine("Le total de votre commande est de : " + PAP + "E");
                }
                else
                {
                    Console.WriteLine("Prix unitire : " + PU + "E");
                    Console.WriteLine("Quantité : " + QTECOM);
                    Console.WriteLine("Frais de Port : " + PORT + "E");
                    Console.WriteLine("Remise : " + REMISE + "E");
                    // Calcul du nouveau total
                    PAP = ((PU * QTECOM) - REMISE) + PORT;
                    Console.WriteLine("Le total de votre commande est de : " + PAP + "E");

                }
            }
            else if  (TOT >= 100 && TOT <= 200)
            {
                    REMISE = (TOT * 0.05);
                    if (PORT < 6)
                    {
                        PORT = 6;
                        Console.WriteLine("Prix unitire : " + PU + "E");
                        Console.WriteLine("Quantité : " + QTECOM);
                        Console.WriteLine("Frais de Port : " + PORT + "E");
                        Console.WriteLine("Remise : " + REMISE + "E");
                        // Calcul du nouveau total
                        PAP = ((PU * QTECOM) - REMISE) + PORT;
                        Console.WriteLine("Le total de votre commande est de : " + PAP + "E");
                    }
                    else
                    {
                        Console.WriteLine("Prix unitire : " + PU + "E");
                        Console.WriteLine("Quantité : " + QTECOM);
                        Console.WriteLine("Frais de Port : " + PORT + "E");
                        Console.WriteLine("Remise : " + REMISE + "E");
                        // Calcul du nouveau total
                        PAP = ((PU * QTECOM) - REMISE) + PORT;
                        Console.WriteLine("Le total de votre commande est de : " + PAP + "E");
                    }
             }         
             else if (TOT < 100)
             {
                    PORT = 6;
                    REMISE = 0;
                    Console.WriteLine("Prix unitire : " + PU + "E");
                    Console.WriteLine("Quantité : " + QTECOM);
                    Console.WriteLine("Frais de Port : " + PORT + "E");
                    Console.WriteLine("Votre remise de "+  ": " + REMISE + "E");
                    // Calcul du nouveau total
                    PAP = ((PU * QTECOM) - REMISE) + PORT;
                    Console.WriteLine("Le total de votre commande est de : " + PAP + "E");
            }
            
            Console.ReadLine();
        }
    }
}
