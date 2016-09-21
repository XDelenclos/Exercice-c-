using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
      class Program
    {
        static void Multiples()
        {
            int X, N, i;
                     
            X = GetInteger();
            Console.WriteLine();            
            N = Convert.ToInt16(GetInteger());
            Console.WriteLine();

            Console.WriteLine("Table de multiplication de " + X + " par les " + N + " premiers chiffres.");
            Console.WriteLine("=============================================================");
            i = 1;
            while (i <= N)
            {
                Console.WriteLine("{0} * " + X + " = {1}", i, i * X);
                i++;
            }
        }
        static void Somme_Moyenne(out int somme, out int moyenne)
        {
            int boucle;
            int i= 0;
            Console.WriteLine("Combien souhaitez vous entrer de valeur? ");
            boucle = Convert.ToInt32(Console.ReadLine());
            somme = 0;
            while (i != boucle)
            {                
                somme = somme + GetInteger();
                i++;
            }
            moyenne = somme / boucle;
        }

        static void Nombre_caractère(out string lettre, out int NbLettre)
        {

            string phrase;
            int i;

            Console.WriteLine("Entrez une phrase : ");
            phrase = Console.ReadLine();
            Console.WriteLine("Quelle lettre souhaitez vous compter ? ");
            lettre = Console.ReadLine();
            NbLettre = 0;
            i = 0;
            while (i < phrase.Length)
            {
                if (lettre.IndexOf(phrase.Substring(i, 1)) != -1)
                {
                    NbLettre++;
                }
                i++;
            }
        
            return;
        }
        static int Nombre_caractère2()
        {
            string Voyelle = "aeiouyAEIOUYéèàäâêëïîôùöò";
            string phrase, c;
            int NbLettre;


            phrase = GetString();
            NbLettre = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                c = phrase.Substring(i, 1);
                for (int o = 0; o < Voyelle.Length; o++)
                {
                    if (c == Voyelle.Substring(o, 1))
                    {
                        NbLettre++;
                    }
                }
            }
            return NbLettre;
        }
        static String GetString()
        {
            Console.WriteLine("Entrez une phrase : ");
            string phrase = Console.ReadLine();
            return phrase;
        }
        static int GetInteger()
        {
            Console.WriteLine("Entrez un chiffre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            return nombre;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("1- Multiples");
            Console.WriteLine("2- Somme et moyenne");
            Console.WriteLine("3- Recherche du nombre de voyelle");
            Console.WriteLine("4- Recherche du nombre des caractères suivants");
            Console.WriteLine("Entrez votre option : ");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                Multiples();
                Console.ReadLine();
            }
            if (choix == "2")
            {
                int somme = 0;
                int moyenne = 0;
                Somme_Moyenne(out somme, out moyenne);
                Console.ReadLine();
            }
            if (choix == "3")
            {
                Console.WriteLine("il y a " + Nombre_caractère2() + " voyelle(s) dans votre phrase. ");
                Console.ReadLine();
            }
            if (choix == "4")
            {
                int nblettre=0;
                string Lettre="";
                Nombre_caractère(out Lettre, out nblettre);
                Console.WriteLine("il y a " + nblettre + " fois la lettre " + Lettre + "  dans votre phrase");
                Console.ReadLine();

            }
        }
    }
}
