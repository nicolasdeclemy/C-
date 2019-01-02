using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do// principe de fonctionnement est simple, on exécute les instructions
            {
                Console.WriteLine("Bonjour, je suis le message N°" + i);
                i++;// on incrémente i
            } while (i < 11);
            

        }
    }
}
