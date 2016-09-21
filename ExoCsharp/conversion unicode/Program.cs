using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_unicode
{
    class Program
    {
        static void Main()
        {

            string Unico;
            int test;
            byte utf8byte;
            string LettrUni;
            // Numéro de version et fonctionnalité
            Console.WriteLine("                   ****CONVERSION code unicode (V1.0, 11 / 07 / 16) ****");
            Console.WriteLine();
            Console.WriteLine("Entrer un chiffre à convertir: ");
            Console.WriteLine();
            Unico = Console.ReadLine();
            test = Convert.ToInt32(Unico);
            utf8byte = Convert.ToByte(test);
            LettrUni = Encoding.Unicode.GetString(utf8byte);
            Console.Write("le caractère correspondant est le : " + LettrUni);
            Console.ReadLine();

        }
    }
}
