using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Multiples(int Cadre, string CouleurTxt)
    {
        int Chiffre, Multiplicateur, i;
        Chiffre = GetInteger("Saisissez votre chiffre :", CouleurTxt);
        Multiplicateur = GetInteger("Saisissez votre multiplicateur :", CouleurTxt);

        string[] Enonce = { Convert.ToString("Vous souhaitez multiplier " + Chiffre + " par " + Multiplicateur + " :") };
        string[] BdPage = new string[Multiplicateur];
        i = 1;
        while (i <= Multiplicateur)
        {
            BdPage[(i-1)] = (Chiffre + " x " + i + " = " + Convert.ToString(Chiffre * i));
            i++;
        }

        Console.Clear();
        Faire1tablo("Table de Multiplication", BdPage, Enonce, Cadre, CouleurTxt);
    }
    static void Somme_Moyenne(int Cadre, string CouleurTxt)
    {
        string[] Enonce = { "Vous avez choisi de calculer la somme et la moyenne des valeurs suivantes :", "" };
       
        int i = 0;
        int boucle = GetInteger("Combien souhaitez vous entrer de valeur? ", CouleurTxt);
        int[] TabTemp = new int[boucle];
        int somme = 0;
        int saisie = 0;
        while (i != boucle)
        {
            saisie = GetInteger("Saisissez un chiffre :", CouleurTxt);
            TabTemp[i] = saisie;
            somme = somme + TabTemp[i];
            i++;
        }

        foreach (int val in TabTemp)
        { Enonce[1] += (val + " "); }

        int moyenne = somme / boucle;
        string[] BdPage = { Convert.ToString("La somme de vos valeurs est de : " + somme + " et la moyenne est de : " + moyenne) };
        Console.Clear();

        Faire1tablo("Somme et Moyenne.",BdPage ,Enonce, Cadre, CouleurTxt);

    }

    static void NbCaractere(int Cadre, string CouleurTxt)
    {
        string Phrase = GetString("Entrez une phrase : ", CouleurTxt);
        char Lettre = Convert.ToChar(GetString("Quelle lettre souhaitez vous compter ? ", CouleurTxt));
        int NbLettre = 0;
        string[] Enonce = { "Vous avez choisi de rechercher", "La lettre : " +Lettre, "Dans le texte : "+Phrase };
        

        foreach (char lettre in Phrase)
        {
            if (Lettre == lettre)
            { NbLettre++; }
        }
        string[] BdPage = { "Il y a " + NbLettre + " fois", "la lettre " + Lettre , "dans le texte : " + Phrase };

        Console.Clear();
        Faire1tablo("Nombre de caractère.", BdPage, Enonce, Cadre, CouleurTxt);


    }
    static int NbVoyelle(string CouleurTxt)
    {
        string Voyelle = "aeiouyAEIOUYéèàäâêëïîôùöò";
        string Phrase, c;
        int NbLettre;


        Phrase = GetString("Saisie de la phrase :", CouleurTxt);
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
    {
        string Caracteres = new string(C, Longueur);
        return Caracteres;
    }
    static string GetString(string Phrase, string CouleurTxt)
    {
        ColorIn(Phrase, CouleurTxt);
        string PhraseLu = Console.ReadLine();
        return PhraseLu;
    }
    static int GetInteger(string Phrase, string CouleurTxt)
    {
        ColorIn(Phrase, CouleurTxt);
        Console.WriteLine();
        int NombreLu = Convert.ToInt32(Console.ReadLine());
        return NombreLu;
    }
    static string ColorIn(string TxT, string CouleurTxt)//System.ConsoleColor c
    {
        ConsoleColor color;

        Enum.TryParse(CouleurTxt, out color);
        Console.ForegroundColor = color;
        Console.Write(TxT);
        return TxT;
    }
    static int LongMax(string[] Txt)
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
    /*static void CalculEspace()
    {

    }*/
    static int Faire1Choix(string CouleurTxt)
    {
        int UserChoice = GetInteger("Saisissez votre choix :", CouleurTxt);
        return UserChoice;
    }
    static int MaxDe(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
    static int LongTxt(string Ligne)
    {
        int Size = 0;
        return Size;
    }
    static void Faire1tablo(string Titre, string[] BdPage, string[] TxtAfficher, int Cadre, string CouleurTxt)
    {

        char[][] Contour = new char[4][];
        Contour[0] = new char[] { '\u250c' /* ┌ */, '\u2500' /* ─ */, '\u2510' /* ┐ */, '\u2502' /* │ */, '\u2514' /* └ */, '\u2518' /* ┘ */, '\u251c' /* ├ */, '\u2524' /* ┤ */};
        Contour[1] = new char[] { '\u2553' /* ╓ */, '\u2500' /* ─ */, '\u2556' /* ╖ */, '\u2551' /* ║ */, '\u2559' /* ╙ */, '\u255c' /* ╜ */, '\u255f' /* ╟ */, '\u2562' /* ╢ */};
        Contour[2] = new char[] { '\u2554' /* ╔ */, '\u2550' /* ═ */, '\u2557' /* ╗ */, '\u2551' /* ║ */, '\u255a' /* ╚ */, '\u255d' /* ╝ */, '\u2560' /* ╠ */, '\u2563' /* ╣ */}; // angle inf gauche
        Contour[3] = new char[] { '\u2552' /* ╒ */, '\u2550' /* ═ */, '\u2555' /* ╕ */, '\u2502' /* │ */, '\u2558' /* ╘ */, '\u255b' /* ╛ */, '\u255e' /* ╞ */, '\u2561' /* ╡ */}; // angle inf droit

        //Centrage Titre
        int EspaceMax = MaxDe((LongMax(TxtAfficher)), (LongMax(BdPage)));

        int EspaceAvantTitre = (( EspaceMax - Titre.Length + 2) / 2);
        int EspaceApresTitre =  EspaceMax - EspaceAvantTitre - Titre.Length +2;
        
        //Centrage Bas de page
        int EspaceAvantBdP = ((EspaceMax - BdPage.Length + 2) / 2);
        int EspaceApresBdP = EspaceMax - EspaceAvantBdP - BdPage.Length + 2;
                
        // 1ère ligne du Cadre
        ColorIn(
            Convert.ToString(Contour[Convert.ToInt32(Cadre)][0])
            + (Convert.ToString(Repetition(Contour[Convert.ToInt32(Cadre)][1], LongMax(TxtAfficher) + 2))
            + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][2])))
            , CouleurTxt
        );
        Console.WriteLine();

        // Affichage du Titre
        ColorIn(
            Convert.ToString(Contour[Convert.ToInt32(Cadre)][3])
            + (Repetition(' ', (EspaceAvantTitre))
            + Titre
            + (Repetition(' ', (EspaceApresTitre))
            + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][3]))))
            , CouleurTxt
        );
        Console.WriteLine();

        //Affichage intersection
        ColorIn(
            Convert.ToString(Contour[Convert.ToInt32(Cadre)][6])
            + (Convert.ToString(Repetition(Contour[Convert.ToInt32(Cadre)][1], LongMax(TxtAfficher) + 2))
            + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][7])))
            , CouleurTxt
        );
        Console.WriteLine();

        // Affichage du Contenu
        foreach (string ligne in TxtAfficher)
        {
            ColorIn(
                Convert.ToString(Contour[Convert.ToInt32(Cadre)][3])
                + " "
                + ligne
                + (Repetition(' ', (LongMax(TxtAfficher) - ligne.Length))
                + " "
                + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][3])))
                , CouleurTxt
            );
            Console.WriteLine();
        }

        //Affichage intersection
        ColorIn(
            Convert.ToString(Contour[Convert.ToInt32(Cadre)][6])
            + (Convert.ToString(Repetition(Contour[Convert.ToInt32(Cadre)][1], LongMax(TxtAfficher) + 2))
            + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][7])))
            , CouleurTxt
        );
        Console.WriteLine();

        //Affichage bas de page
        foreach (string ligne in BdPage)
        {
            ColorIn(
                Convert.ToString(Contour[Convert.ToInt32(Cadre)][3])
                + (Repetition(' ', EspaceAvantBdP)
                + " "
                + ligne
                + " "
                + (Repetition(' ', (EspaceApresBdP))
                + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][3]))))
                , CouleurTxt
            );
            Console.WriteLine();
        }
    
        // Dernière ligne du Cadre
        ColorIn(
            Convert.ToString(Contour[Convert.ToInt32(Cadre)][4])
            + (Convert.ToString(Repetition(Contour[Convert.ToInt32(Cadre)][1], LongMax(TxtAfficher) + 2))
            + (Convert.ToString(Contour[Convert.ToInt32(Cadre)][5])))
            , CouleurTxt
        );
        Console.WriteLine();
    }

    static void MenuPrincipal(int Cadre, string CouleurTxt)
    {
        int UserChoice = 0;
        string[] Contenu = { "1. Option.", "2. Multiples.", "3. Somme et Moyenne.", "4. Recherche du nombre de voyelle.", "5. Recherche du nombre des caractères suivants." };
        string[] BdPage = { "V1.0 Menu\u00a9" };
        Faire1tablo("Menu Principal", BdPage , Contenu, Cadre, CouleurTxt);
        UserChoice = Faire1Choix(CouleurTxt);
        switch (UserChoice)
        {
            case 1:
                Console.Clear();
                Option(Cadre, CouleurTxt);
                break;
            case 2:
                Console.Clear();
                Multiples(Cadre, CouleurTxt);
                break;
            case 3:
                Console.Clear();
                Somme_Moyenne(Cadre, CouleurTxt);
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                NbVoyelle(CouleurTxt);
                break;
            case 5:
                Console.Clear();
                NbCaractere(Cadre, CouleurTxt);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Saisie invalide, veuillez recommencer");
                MenuPrincipal(Cadre, CouleurTxt);
                break;
        }
    }

    static void Option(int Cadre, string CouleurTxt)
    {
        int UserChoice = 0;
        string[] ContenuOption = { "1. Paramètrage de la Couleur", "2. Choix du Cadre" };
        string[] BdPage = { "V1.0 Menu\u00a9" };
        Faire1tablo("Option Générale.", BdPage, ContenuOption, Cadre, CouleurTxt);
        UserChoice = Faire1Choix(CouleurTxt);
        //  switch (UserChoice)
        {
            //case 1:
        }

    }
    static void Main()
    {
        //Valeur par défaut

        string CouleurTxt = "White";
        int SelectionDuCadre = 0;
        MenuPrincipal(SelectionDuCadre, CouleurTxt);/*
        string[] Couleur = { "White", "Green", "DarkGray", "Red" };
        string[] Titre = { "Menu Principal", "Option", "Multiples", "Somme et Moyenne.", "Recherche du nombre de voyelle.", "Recherche du nombre des caractères suivants." };

        int Choix;


        int ColorTxt = 0;

        Console.WriteLine("Choix du Cadre");
        Choix = Faire1Choix();

        switch (Choix)
        {
            case 1:
                SelectionDuCadre = 0;
                break;
            case 2:
                SelectionDuCadre = 1;
                break;
            case 3:
                SelectionDuCadre = 2;
                break;
            case 4:
                SelectionDuCadre = 3;
                break;
            default:
                Console.WriteLine("Sélection non valide, retour au menu principal");
                break;
        }


        Console.WriteLine("Choix de la couleur:");
        Choix = Faire1Choix();

        switch (Choix)
        {
            case 0:
                ColorTxt = 0;
                break;
            case 1:
                ColorTxt = 1;
                break;
            case 2:
                ColorTxt = 2;
                break;
            case 3:
                ColorTxt = 3;
                break;
            default:
                ColorTxt = 0;
                break;
        }

        Faire1tablo("Somme et Moyenne", "/u2666 V1.0 Menu /u169 /u2666", Contenu, SelectionDuCadre, Couleur[ColorTxt]);*/
    }


}