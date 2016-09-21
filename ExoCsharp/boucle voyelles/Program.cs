using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle_voyelles
{
    class Program
    {
        static void Main()
        {
            string Voyelle = "aeiouyAEIOUY";
            string Mot;
            int NbVoyelle, i;


            // Note de version
            Console.WriteLine("****** Nombre de voyelles V1.0 , 12/07/2016 ******");
            Console.WriteLine();
            Console.WriteLine("Entrez un mot : ");
            Mot = Console.ReadLine();
            NbVoyelle = 0;
            i = 0;
            while (i <= Mot.Length)
            {
                if((Voyelle.IndexOf(Mot.Substring(i,1))) != -1)
                {
                    NbVoyelle =NbVoyelle +1;
                }
             i++;  
            }
            Console.WriteLine("il y a "+ NbVoyelle+ " dans " + Mot);
            Console.ReadLine();

        }
    }
} 
