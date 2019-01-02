using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO6B
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre"};
            foreach(string day in months )
            {
                Console.WriteLine(day);
            }
        }
    }
}
