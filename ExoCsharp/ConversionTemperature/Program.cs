using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTemperature
{
    class Program
    {
        static void Main()
        {
        double F;  // Farenheit
        double C;  // Celsius
        String StrF;  //Variable saisie

            // Numéro de version et fonctionnalité
            Console.WriteLine("                             ****Conversion de Température (V1.0, 07 / 07 / 16) ****");
            Console.WriteLine();
            // Demande de saisie de valeur
            Console.WriteLine("  Quelle est la température que vous souhaitez convertir ? ");
            StrF = Console.ReadLine();
            F = Convert.ToDouble(StrF);
            Console.WriteLine();
            // Conversion avec pour calcul :  C = (5/9)(F-32)
            C = (F-32)*5/9;
            // Affichage du résultat
            Console.WriteLine("  La conversion de : " + F + "° Farenheit, donne : ", C + " ° Celsius");
            Console.ReadLine();

        }

    }
}
