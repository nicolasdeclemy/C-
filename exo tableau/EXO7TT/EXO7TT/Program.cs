using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO7TT
{
    class Program
    {
        enum week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            String[] week = Enum.GetNames(typeof(week));
            //Pour afficher tout les jours, d'où l'utilisation du foreach
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\n");
            //pour mettre à la ligne
            Console.WriteLine(week[4] + "\n");
            //Afficher la valeur en position 4
            
        }
    }
}
