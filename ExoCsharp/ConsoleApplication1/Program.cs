using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_Magique
{ 
    class Program
    {
        static void Main()
        {
            int i =0 ;
            Random  rnd = new Random();
            int nb= rnd.Next(1, 100);

            //note de version 
            Console.WriteLine("****** Nombre magique V1.0 , 22/07/2016 ******");
            Console.WriteLine();

            

            while (i != nb)
            {
                Console.WriteLine("Entrer un chiffre :");
                i = Convert.ToInt32(Console.ReadLine());
                if (i < nb)
                {
                    Console.WriteLine("plus grand");
                    }
             
                
                if (i > nb)
                {
                    Console.WriteLine(" Plus petit");
                }
            }  
            Console.WriteLine("Bien joué l'ami !");              
            Console.ReadLine();                        
        }
    }
}
