using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] titre = { "Multiples.", "Somme et Moyenne.", "Recherche du nombre de voyelle.", "Recherche du nombre des caractères suivants.", "Paramètres" };
            long[] nbcarac = new long[titre.Length];
            string[] cadreh = { "_", "-", "+", "*", "#", "~", "¤", "<", ">" }; //9
            string[] cadrev = { "/", @"\", "|", "+", "*", "#", "!", ":", "§", "<", ">", " " }; //12
            Console.WriteLine("FontStyle.Bold : {0}", (int)FontStyle.Bold);
            String ligne = new String(Convert.ToChar(cadreh[0]), 4);
            Console.WriteLine(ligne);
            Console.ReadLine();
        }
    }
}
