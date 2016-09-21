using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static string GetString(string Phrase)
        {
            Console.WriteLine(Phrase);
            string PhraseLu = Console.ReadLine();
            return PhraseLu;
        }

        static char GetChar(string Phrase)
        {
            string PhraseLu = "";
            while (PhraseLu.Length < 1)
            {
                try
                {
                    Console.WriteLine(Phrase);
                    PhraseLu = Console.ReadLine();
                }

                catch (Exception)
                {
                    Console.WriteLine("Erreur de caractère");
                }
                finally
                { }
            }
            return PhraseLu[0];
        }
        static void pendu(int erreur)
        {
            switch (erreur)
            {
                case 1:
                    Console.WriteLine("_");
                    break;
                case 2:
                    Console.WriteLine("__");
                    break;
                case 3:
                    Console.WriteLine("___");
                    break;
                case 4:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    break;
                case 5:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    break;
                case 6:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine("  |");
                    break;
                case 7:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|");
                    break;
                case 8:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|-");
                    break;
                case 9:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|-");
                    Console.WriteLine("  | ");
                    break;
                case 10:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|-");
                    Console.WriteLine("  | ");
                    Console.WriteLine(" / ");
                    break;
                case 11:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|-");
                    Console.WriteLine("  | ");
                    Console.WriteLine(" / \\");
                    break;
                case 12:
                    Console.WriteLine("___");
                    Console.WriteLine("  | ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("  O");
                    Console.WriteLine(" -|-");
                    Console.WriteLine("  | ");
                    Console.WriteLine(" / \\");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vous êtes : ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" /\\/\\/\\/\\");
                    Console.WriteLine("<        >");
                    Console.WriteLine("< MORT!! >");
                    Console.WriteLine("<        >");
                    Console.WriteLine(" \\/\\/\\/\\/");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        static void Main(string[] args)
        {
            string Patern = "^[a-z]+$";
            string MotSecret = "";
            do
            {
                MotSecret = GetString("Entrez un mot secret");
                Console.Clear();
            } while (!Regex.IsMatch(MotSecret, Patern));
            int erreur = 0;

            StringBuilder MotConstruit = new StringBuilder(MotSecret);
            string ListeLettre = "";


            for (int i = 0; i < MotSecret.Length; i++)
            {
                MotConstruit[i] = '_';
            }
            while (MotSecret != Convert.ToString(MotConstruit) & erreur < 12)
            {
                bool error = false;
                char LettreTappees = GetChar("Entrez une lettre:");
                for (int i = 0; i < MotSecret.Count(); i++)
                {
                    if (LettreTappees == MotSecret[i])
                    {
                        MotConstruit[i] = LettreTappees;

                        if (erreur >= 0 & LettreTappees == MotSecret[i])
                        {
                            erreur--;
                        }
                    }

                    else
                    {
                        error = true;
                        Console.Clear();
                    }
                }
                if (error)
                {
                    ListeLettre += LettreTappees;
                    erreur++;
                }
                pendu(erreur);
                Console.WriteLine();
                Console.WriteLine(ListeLettre);
                Console.WriteLine();
                Console.WriteLine(MotConstruit);
                Console.WriteLine();
                Console.WriteLine("Nombre d'erreur : " + erreur + " /12, try harder.");

            }
            if (erreur == 12)
            {
                Console.WriteLine();
                Console.WriteLine("You Loose !");
                Console.ReadLine();
            }
            else
            { Console.WriteLine("Well Done!"); }
            Console.ReadLine();
        }
    }
}


