using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class lettre
    {
        public string letter { get; set; }
        public int NbLettre { get; set; }
    }
    class Program
    {
        static void Multiples()
        {

        }
        static void Somme_Moyenne()
        {

        }
        
        static int Nombre_caractère(lettre let)
        {
            
            string phrase;
            //int NbLettre, i;

            Console.WriteLine("Entrez une phrase : ");
            phrase = Console.ReadLine();
            Console.WriteLine("Quelle lettre souhaitez vous compter ? ");
            let.letter = Console.ReadLine();
            let.NbLettre = 0;
            int i = 0;
            while (i < phrase.Length)
            {
                if (let.letter.IndexOf(phrase.Substring(i, 1)) != -1)
                {
                    let.NbLettre++;
                }
                i++;
            }
            return let.NbLettre;        }
        static int Nombre_caractère2( )
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
        static void Main(string[] args,lettre let)
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
                Somme_Moyenne();
                Console.ReadLine();
            }
            if (choix == "3")
            {
                Console.WriteLine("il y a " + Nombre_caractère2() + " voyelle(s) dans votre phrase. ");
                Console.ReadLine();
            }
            if (choix == "4")
            {
                Console.WriteLine("il y a " + let.NbLettre + " fois la lettre " + let.letter + "  dans votre phrase");
                Console.ReadLine();
               
            }
        }
    }
}
