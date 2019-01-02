using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>()
            { "Carotte", "Oignons" , "Pomme de terre" , "Salade" , "Tomate"};
            foreach (string product in shopping)
                Console.WriteLine(product);
        }
    }
}
