using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabelo
{
    class Program
    {
        static string ColorIn(string TxT, string couleurtxt)
        {
            ConsoleColor color;
            Enum.TryParse(couleurtxt, out color);
            Console.ForegroundColor = color;
            Console.Write(TxT);
            return TxT;
        }

        static int LongTxT(string[] Txt)
        {
            int NbCarac = 0; // nbre de caractères de la chaine
            int Size = 0; // nbre max de caractères dans les chaines            
            foreach (string Phrase in Txt)
            {
                NbCarac = Phrase.Length;
                if (Size < NbCarac)
                {
                    Size = NbCarac;
                }
            }
            return Size;
        }
        //
        static void Multiples()
        {
            int Chiffre, Multiplicateur, i;
            int TailleTxT = 0;
            Chiffre = GetInteger("Saisissez votre chiffre :");
            Multiplicateur = GetInteger("Saisissez votre multiplicateur :");

            String Txt = "Table de multiplication de " + Chiffre + " par les " + Multiplicateur + " premiers chiffres.";
            TailleTxT = Txt.Length;
            Console.WriteLine(Txt);

            Console.WriteLine(Repetition('\u2550', TailleTxT));
            i = 1;
            while (i <= Multiplicateur)
            {
                Console.WriteLine("{0} * " + Chiffre + " = {1}", i, i * Chiffre);
                i++;
            }
        }
        static void Somme_Moyenne(out int somme, out int moyenne)
        {
            int boucle;
            int i = 0;
            boucle = GetInteger("Combien souhaitez vous entrer de valeur? ");

            somme = 0;
            while (i != boucle)
            {
                somme = somme + GetInteger("Saisissez un chiffre :");
                i++;
            }
            moyenne = somme / boucle;
        }

        static void Nombre_caractère(out string Lettre, out int NbLettre)
        {

            string Phrase;
            int i;

            Phrase = GetString("Entrez une phrase : ");
            Lettre = GetString("Quelle lettre souhaitez vous compter ? ");
            NbLettre = 0;
            i = 0;
            while (i < Phrase.Length)
            {
                if (Lettre.IndexOf(Phrase.Substring(i, 1)) != -1)
                {
                    NbLettre++;
                }
                i++;
            }

        }
        static int Nombre_voyelle()
        {
            string Voyelle = "aeiouyAEIOUYéèàäâêëïîôùöò";
            string Phrase, c;
            int NbLettre;


            Phrase = GetString("Saisie de la phrase :");
            NbLettre = 0;

            for (int i = 0; i < Phrase.Length; i++)
            {
                c = Phrase.Substring(i, 1);
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
        static string Repetition(char C, int Longueur)
        /* génération 
        des lignes */
        {
            string Caracteres = new string(C, Longueur);
            return Caracteres;
        }
        static string GetString(string Phrase)
        {
            Console.WriteLine(Phrase);
            string PhraseLu = Console.ReadLine();
            return PhraseLu;
        }
        static int GetInteger(string Phrase)
        {
            ColorIn(Phrase, ConsoleColor.DarkGray);
            Console.WriteLine();
            int NombreLu = Convert.ToInt32(Console.ReadLine());
            return NombreLu;
        }
        static int Choix()
        {
            int UserChoice = GetInteger("Saisissez votre choix :");

            return UserChoice;
        }
        static void Menu(string[] titre)
        {

            int count = 0;
            foreach (string phrase in titre)
            {
                ColorIn(Convert.ToString(count), ConsoleColor.Red);

                ColorIn(" - ", ConsoleColor.Green);
                ColorIn((phrase), ConsoleColor.DarkGray);
                count++;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

            /*UserChoice=
            GetInteger("Entrez votre option : ");
            string choix = Console.ReadLine();
*/
        }
        /* static void AfficheTab(char[] tablo)
         {
             foreach (char sign in tablo)
             {
                 Console.WriteLine(sign);
             }
             Console.WriteLine();
         }*/
        static void Main(string[] args)
        {
            //ColorIn("ttt", ConsoleColor.White);               

            // Tableau des caractères du cadre
            char[][] contour = new char[7][];
            contour[0] = new char[] { '\u250c' /* ┌ */, '\u2554' /* ╔ */, '\u2553' /* ╓ */, '\u2552' /* ╒ */}; // angle sup gauche
            contour[1] = new char[] { '\u2510' /* ┐ */, '\u2557' /* ╗ */, '\u2556' /* ╖ */, '\u2555' /* ╕ */}; // angle sup droit
            contour[2] = new char[] { '\u2514' /* └ */, '\u255a' /* ╚ */, '\u2559' /* ╙ */, '\u2558' /* ╘ */}; // angle inf gauche
            contour[3] = new char[] { '\u2518' /* ┘ */, '\u255d' /* ╝ */, '\u255c' /* ╜ */, '\u255b' /* ╛ */}; // angle inf droit
            contour[4] = new char[] { '\u2500' /* ─ */, '\u2550' /* ═ */}; // horizontal
            contour[5] = new char[] { '\u2560' /* ╠ */, '\u255f' /* ╟ */, '\u2562' /* ╢ */, '\u2563' /* ╣ */, '\u251c' /* ├ */, '\u2524' /* ┤ */, '\u2561' /* ╡ */, '\u255e' /* ╞ */}; // 8 vertical intersection
            contour[6] = new char[] { '\u2551' /* ║ */, '\u2502' /* │ */, }; // 2 vertical 



            // Tableau des menus
            string[] option = { "", "Choix du tableau.", "Choix des couleurs." };
            string[] titre = { "Option.", "Multiples.", "Somme et Moyenne.", "Recherche du nombre de voyelle.", "Recherche du nombre des caractères suivants." };

            // Init variable import
            //  static void LongTxT(string[] Txt, out int Size )                   
            Console.WriteLine(contour[0][0] + Repetition(contour[4][0], LongTxT(titre) + 5) + contour[1][0]);
            /*
            // choix du menu selection du cadre
            switch (Choix())
            {
                case 1:
                    string cas0 = "000000451";
                    break;
                case 2:
                    string cas1 = "333311671";
                    break;
                case 3:
                    string cas2 = "333301451";
                    break;
                case 4:
                    string cas3 = "000001671";
                    break;
                case 5:
                    string cas4 = "222200120";
                    break;
                case 6:
                    string cas5 = "111110120";
                    break;
                case 7:
                    string cas6 = "111111030";
                    break;
                case 8:
                    string cas7 = "222201030";
                    break;
                default:
                    Console.WriteLine("Sélection non valide, retour au menu principal");
                    Menu(titre);
                    break;
            }



            // choix du menu option
            switch (Choix())
            {
                case 1:
                   // Option();
                    break;
                case 2:
                   // ColorIn();
                    break;
                default:
                    Console.WriteLine("Sélection non valide, retour au menu principal");
                    Menu(titre);
                    break;
            }
            */

            // Menu principal
            Menu(titre);
            switch (Choix())
            {
                case 0:
                    //Option();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine(contour[0][0] + Repetition(contour[4][0], LongTxT(titre) + 5) + contour[1][0]);
                    Multiples();
                    Console.ReadLine();
                    Menu(titre);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(contour[0][0] + Repetition(contour[4][0], LongTxT(titre) + 5) + contour[1][0]);
                    int somme = 0;
                    int moyenne = 0;
                    Somme_Moyenne(out somme, out moyenne);
                    Console.WriteLine("La somme de vos valeurs est de : " + somme + " et la moyenne de : " + moyenne);
                    Console.ReadLine();
                    Menu(titre);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine(contour[0][0] + Repetition(contour[4][0], LongTxT(titre) + 5) + contour[1][0]);
                    Console.WriteLine("il y a " + Nombre_voyelle() + " voyelle(s) dans votre phrase. ");
                    Console.ReadLine();
                    Menu(titre);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine(contour[0][0] + Repetition(contour[4][0], LongTxT(titre) + 5) + contour[1][0]);
                    int nblettre = 0;
                    string Lettre = "";
                    Nombre_caractère(out Lettre, out nblettre);
                    Console.WriteLine("il y a " + nblettre + " fois la lettre " + Lettre + "  dans votre phrase");
                    Console.ReadLine();
                    Menu(titre);
                    break;

                default:
                    Console.Clear();
                    Menu(titre);
                    break;

            }
        }
    }
}
