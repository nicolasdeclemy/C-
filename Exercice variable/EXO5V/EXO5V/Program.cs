﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5V
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstname;
            Console.WriteLine("Renseigner le nom");
            name = Console.ReadLine();
            Console.WriteLine("Renseigner le prenom");
            firstname = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + " " + firstname + " nous sommes le " + DateTime.Now.Month + "" + DateTime.Now.Year + " comment allez-vous ? ");
            Console.ReadKey();
        }
    }
}
