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
      
        DateTime DateDuJour = DateTime.Today;
        string DateNaissance;
        Console.WriteLine("Entre votre date de naissance (format jour/mois/année) :");
            DateNaissance = Console.ReadLine();
        
            TimeSpan ts = DateDuJour - Convert.ToDateTime(DateNaissance);

            int Majorite = 18;
        double TestMajorite = ts.Days / 365.25;
            if (TestMajorite >= Majorite)
            {
                Console.WriteLine("Vous êtes Majeur");
            }
            else
                Console.WriteLine("Vous n'êtes pas Majeur, reviens quand tu auras du poil au menton!");
           
            Console.ReadLine();
 
        }
    }
}
