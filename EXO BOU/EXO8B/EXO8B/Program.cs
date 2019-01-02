using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO8B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = new int[20];// On déclare le tableau int de taille 20
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = i + 1; // on entre les entiers dans le tableau
            }
            foreach (int pair in pairs)
            {
                if (pair %2 == 0)// on vérifie si le reste du quotient des int par 2 est nul
                {
                    Console.WriteLine(pair);
                }
            }
            Console.ReadKey();

        }
    }
}
