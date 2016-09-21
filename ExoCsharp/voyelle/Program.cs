using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesbloucles_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string donne;
            int longueur, nbvoyelle;
            nbvoyelle = 0;
            string voyelle = "aeiouyAEIOUY";
            Console.WriteLine("entrez un mot");
            donne = Console.ReadLine();
            longueur = donne.Length;

            for (int i = 0; i < longueur; i++)
            {
                if (voyelle.IndexOf(donne.Substring(i, 1)) != -1)
                {
                    nbvoyelle++;
                }
            }
            Console.WriteLine("il y a = " + nbvoyelle + " voyelles dans le mot");
            Console.ReadLine();
        }
    }
}