using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un chiffre : ");
            int Saisie = Convert.ToInt32(Console.ReadLine());
            string bin = Convert.ToString(Saisie, 2); 
            Console.WriteLine(bin);
            Console.ReadLine(); 
            
        }
    }
}
