﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3V
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Entrez la valeur de a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Entrez la valeur de b");
            int.TryParse(Console.ReadLine(), out b);
            b++;
            Console.WriteLine("le résultat de l'opération est " + (a + 33) / b);
            Console.ReadKey();

        }
    }
}
