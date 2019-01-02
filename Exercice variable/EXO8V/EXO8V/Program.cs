using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO8V
{
    class Program
    {
        static void Main(string[] args)
        {
            double rayon = 0;
            Console.WriteLine("le rayon est de ");
            double.TryParse(Console.ReadLine(), out rayon);
            Console.WriteLine(" le rayon du cercle de " + " a un périmétre de " + (2 * Math.PI * rayon));
            Console.WriteLine(" le rayon du cercle de " + rayon + " a une surface de " (Math.Pow(rayon, 2)));


        }
    }
}
