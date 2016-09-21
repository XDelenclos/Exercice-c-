using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majorité
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieprenom; //réponse utilisateur
            string[] tabprenom;  //création du tableau
            tabprenom = new string[20] { "sebastien", "aurélien", "cindy", "gaetan", "christophe", "xavier", "arnaud", "quentin", "malik", "clement", "manu", "mathieu", "françois", "régis", "scarlett", "mégane", "camille", "amandine", "jean", "paul" };
            //affichage du tableau
            foreach (string element in tabprenom)
            {
                System.Console.Write(element+", ");
            }
            Console.WriteLine();
            //interrogation utilisateur
            Console.WriteLine("Saisissez un prénom d'un membre de la formation");
            saisieprenom = Console.ReadLine();
            //Recherche de la position du nom
            int position = -1;
            for (int i = 0; i < tabprenom.Length; i++)
            {
                if (tabprenom[i] == saisieprenom)
                {
                    position = i;
                }
            }
            //Début du tri
            if (position != -1)
            {
                Console.WriteLine("Trouvé en position " + position);
                for (int i = position; i < tabprenom.Length - 1; i++)
                {
                    tabprenom[i] = tabprenom[(i + 1)];                
                }
                tabprenom[(tabprenom.Length - 1)] = "";
                Console.ReadLine();
            }
            foreach (string element in tabprenom)
            {
                System.Console.Write(element + ", ");
            }
            Console.ReadLine();
        }
    }
}
