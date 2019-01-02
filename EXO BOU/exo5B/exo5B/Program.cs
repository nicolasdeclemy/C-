using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            
            for (int indice = 0; indice < week.Length; indice++)//signe inférieur car sa démarre à Zéro
            {//Quand on connait pas la taille du tableau on utilise week.Length
                Console.WriteLine(week[indice]);
            }
        }
    }
}
