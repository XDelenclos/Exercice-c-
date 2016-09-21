using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSION_D_UNE_DUREE
{
    class Program
    {
        static void Main()
        {
        String NbSec;
        int h;
        int m;
        int s;




            // Numéro de version et fonctionnalité
            Console.WriteLine("                   ****CONVERSION D’UNE DUREE EXPRIMEE (V1.0, 08 / 07 / 16) ****");
            Console.WriteLine();
            Console.WriteLine("Entrez le nombre de secondes à convertir en Heure, minute et seconde : ");
            Console.WriteLine();
            NbSec = Console.ReadLine();
            s = Convert.ToInt32(NbSec);
            h = s / 3600;
            s = s % 3600;
            m = s / 60;
            s = s % 60;
            Console.WriteLine("Correspond à : " + h+"H" + m + "," + s);
            Console.ReadLine();
        }
    }
}
