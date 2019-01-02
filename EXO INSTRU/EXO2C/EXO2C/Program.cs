using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2C
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (age < 18 && age > 0)// Vérifier que l'âge renseigné est entre 0 et 17
            {
                Console.WriteLine(" vous êtes donc mineur");
            }
            else if (age >= 18)
            {
                Console.WriteLine("vous êtes majeur");
            }
            else//on gere le cas où la saisie est incorrect
            {
                Console.WriteLine("Je ne suis pas un robot");
            }
        }
    }
}
