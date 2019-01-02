using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_V
{
    class Program
    {
        static void Main(string[] args)
        {
            int devinelenombre = new Random().Next(1, 50);
            int nombreDeCoups = 0;
            bool trouve = false;
            Console.WriteLine("Veuillez saisir un nombre compris entre 1 et 50");
            while (!trouve)
            {
                string saisie = Console.ReadLine();
                int ValeurSaisie;
                if (int.TryParse(saisie, out ValeurSaisie))
                {
                    if (ValeurSaisie == devinelenombre)
                    trouve = true;
                    else
                    {
                     if (ValeurSaisie < devinelenombre)
                            Console.WriteLine("C'est trop petit, Rééssaye!!!");
                        else
                        Console.WriteLine("C'est trop grand, Réeesaye!!!");

                    }
                    nombreDeCoups++;
                }
                else
                {
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer");
                }
            }  Console.WriteLine(" Vous avez trouvé BRAVO " + nombreDeCoups + "coups");

        }
    }
}
