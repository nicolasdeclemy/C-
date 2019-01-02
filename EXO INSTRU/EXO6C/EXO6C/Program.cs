using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO6C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renseigner le mois pour en connaître la saison : ");
            String month = Console.ReadLine();

            switch (month)
            {
                case "Janvier":
                    Console.WriteLine("C'est l'hiver !");
                    break;
                case "Fevrier":
                    Console.WriteLine("Cest l'hiver !");
                    break;
                case " Mars":
                    Console.WriteLine("C'est le Printemps !");
                    break;
                case "Avril":
                    Console.WriteLine("C'est le printemps !");
                    break;
                case " Mai":
                    Console.WriteLine("C'est le printemps !");
                    break;
                case "Juin":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "Juillet":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "Aout":
                    Console.WriteLine("C'est l'été !");
                    break;
                case "Septembre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "Octobre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "Novembre":
                    Console.WriteLine("C'est l'automne !");
                    break;
                case "Decembre":
                    Console.WriteLine("C'est l'hiver !");
                    break;
                default: //si aucun des cas ne correspond, on execute le default.
                    Console.WriteLine("Le mois renseigné n'existe pas");
                    break;
               
            }
        }
    }
}
