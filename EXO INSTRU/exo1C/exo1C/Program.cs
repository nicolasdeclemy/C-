using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy;//créer une variable booléenne Rainy et lui attribuer les valeurs vrai/faux
            bool.TryParse(Console.ReadLine(), out rainy);
                if(rainy == true)
            {
                Console.WriteLine("Bonjour,il ne pleut pas aujourd'hui, bonne journée");

            }
            else
                Console.WriteLine("Bonjour, il pleut aujourd'hui, vous devriez prendre votre parapluie");
        }
}
