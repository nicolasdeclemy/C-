using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO3T
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            int i = Array.IndexOf(week, "Jeudi"); //Indexoff permet de retrouver l'indice d'un élément dans un tableau, renvoi -1 si l'élément n'existe pas.
            week[i + 1] = "Vendredi";
            foreach (String day in week)
                Console.WriteLine(day);
        }
    }
}
