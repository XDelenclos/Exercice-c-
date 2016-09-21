using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void CompteLettre()
        {
            string lettre;
            string phrase;
            int NbLettre, i;

            Console.WriteLine("Entrez une phrase : ");
            phrase = Console.ReadLine();
            Console.WriteLine("Quelle lettre souhaitez vous compter ? ");
            lettre = Console.ReadLine();
            NbLettre = 0;
            i = 0;
            while (i < phrase.Length)
            {
                if (lettre == phrase.Substring(i, 1))
                {
                    NbLettre++;
                }
                i++;
            }
            Console.WriteLine("il y a " + NbLettre + " fois la lettre " + lettre.ToUpper() + "  dans votre phrase");
            Console.ReadLine();
        }
        static void Main()
        {
            // Note de version
            Console.WriteLine("****** Nombre de lettre dans la phrase V1.0 , 25/07/2016 ******");
            Console.WriteLine();
            CompteLettre();
            Console.ReadLine();
        }
    }
}
