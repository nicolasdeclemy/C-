using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3C
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String sexe;
            Console.WriteLine("Quel est votre age?");

            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Votre sexe: homme ou femme");
            sexe = Console.ReadLine();//ENTRER VOTRE SEXE
            if (age < 18 && sexe == "femme")
            {
                Console.WriteLine("vous êtes majeure et vous êtes une femme");
            }
            else if (age >= 18 && sexe == "homme")
            {
                Console.WriteLine("vous êtes majeur et vous êtes un homme");
            }
            else if (age > 0 && sexe == "femme")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure");
            }
            else if (age > 0 && sexe == "homme")
            {
                Console.WriteLine("vous etes une homme et vous êtes mineur");
            }
            else
            {
                Console.WriteLine("erreur");
            }
            
        



        }
    }
}
