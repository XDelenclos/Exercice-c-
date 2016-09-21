using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paye_ton_string
{
    class Program
    {
        static void Main()
        {
            // Create a Unicode String with 5 Greek Alpha characters
            String szGreekAlpha = new String('\u0391', 5);
            // Create a Unicode String with a Greek Omega character
            String szGreekOmega = new String(new char[] { '\u03A9', '\u03A9', '\u03A9' }, 2, 1);

            String szGreekLetters = String.Concat(szGreekOmega, szGreekAlpha, szGreekOmega.Clone());

            // Examine the result
            Console.WriteLine(szGreekLetters);

            // The first index of Alpha
            int ialpha = szGreekLetters.IndexOf('\u0391');
            // The last index of Omega
            int iomega = szGreekLetters.LastIndexOf('\u03A9');

            Console.WriteLine("The Greek letter Alpha first appears at index " + ialpha +
                " and Omega last appears at index " + iomega + " in this String.");
            Console.ReadLine();
                

        }
    }
}
