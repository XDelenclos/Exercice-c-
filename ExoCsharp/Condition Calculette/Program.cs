using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Calculette
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            string StrA;
            string StrB;
            string Opérateur;

            //Version
            Console.WriteLine("Calculette avec opérateur V1.0, 11/07/2016");
            Console.WriteLine();
            // Saisie utilisateur
            Console.WriteLine("Saisissez votre première valuer : ");
            StrA = Console.ReadLine();
            Console.WriteLine("Saisissez votre seconde valeur : ");
            StrB = Console.ReadLine();
            Console.WriteLine("Quel opérateur souhaitez vous utiliser ?");
            Opérateur = Console.ReadLine();
            a = Convert.ToInt32(StrA);
            b = Convert.ToInt32(StrB);
            if (Opérateur == "/")
            {
                if (b == 0) 
                {
                    Console.WriteLine("Division impossible par 0");
                }    
                else 
                {
                    Console.WriteLine(a / b);
                }
            }
            else if (Opérateur == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (Opérateur == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (Opérateur == "+")
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("Opérateur inconnu");
            }

            Console.ReadLine();
        

        }
    }
}

