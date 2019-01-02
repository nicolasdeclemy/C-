using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double AB, BC, CA;
            Console.WriteLine("valeur de BC");
            double.TryParse(Console.ReadLine(), out BC);
            Console.WriteLine("valeur de CA");
            double.TryParse(Console.ReadLine(), out CA);
            AB = Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(CA, 2));
            Console.WriteLine("jdj " + AB);
            Console.ReadKey();
        }
    }
}
