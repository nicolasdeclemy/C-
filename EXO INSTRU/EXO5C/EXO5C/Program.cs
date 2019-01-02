using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5C
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NameValueCollection();
            fujita.Add("F0", "Dégâts légers");
            fujita.Add("F1", "Dégâts modérés");
            fujita.Add("F2", "Dégâts Importants");
            fujita.Add("F3", "Dégâts Considérables");
            fujita.Add("F4", "Dégâts Dévastateurs");
            fujita.Add("F5", "Dégâts Incroyables");

            Console.WriteLine("Renseigner le type d'une tornade");
            String F = Console.ReadLine();
            Console.WriteLine(fujita["F1"]);

        }
    }
}
