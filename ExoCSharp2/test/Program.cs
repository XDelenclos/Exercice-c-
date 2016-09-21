using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] tab = {"123", "456", "789", "963", "852"};
            char c = '3';
            int i = Convert.ToInt32(c.ToString());


            Console.WriteLine(tab[c-48]);
        }
    }
}
