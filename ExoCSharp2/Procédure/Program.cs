using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    class Table_Multiplication
    {
        //déclaration de la fonction
        static void Multi(int n, int m)
        {
            
            int resultat,i;

            for (i = 1; i <= n; i++) // boucle, i = multiplicateur
            {
                resultat = i * m;
                Console.WriteLine("{0} x {1} = {2}", i, m, resultat);
            }

        }   
        //programme principal
        static void Main()
        {
            int m, n;

            Console.WriteLine("Quel est votre chiffre :"); // m chiffre à multiplier
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusqu'à combien voulez vous le multiplier :"); // n = multiplicateur (référence à i )
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("table de multiplication de "+m);

            Multi(n,m);

            Console.ReadLine();

        }
              
    }
}
























/*  static int Multiplication(int n, int m)
        {
            int resultat;
           while (n <= 10)
            {
                resultat = n * m;
                Console.WriteLine("{0} x {1} = {2}", n, m, resultat);
                n++;
            }
            return resultat = n * m;
        }
        static void Main()
        {
           Multiplication(1, 7);
           Console.ReadLine();*/
