using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_Nombre_premier
{
    class Program
    {
        static void Main()
        {
            //note de version 
            Console.WriteLine("****** Nombre Premier V1.0 , 12/07/2016 ******");
            Console.WriteLine();
            int num1;

            Console.WriteLine("entrer un nombre:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
               Console.WriteLine(num1 + " Est un chiffre premier");
               Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " n'est pas un chiffre premier");
                        Console.ReadLine();
                        return;
                    }

                }
                Console.WriteLine(num1 + " est un chiffre premier");
                Console.ReadLine();
            }
         
        }
     }
}

