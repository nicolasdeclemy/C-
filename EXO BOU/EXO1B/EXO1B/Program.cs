using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO1B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;// on crée une variable
            while (i < 10)// dans la parenthese c'est la valeur qu'on veut afficher le message
            {
                Console.WriteLine("Bonjour je ne suis q'un simple message");//dans la parenthese c'est le message
                i++;// on  incrémente i

                Console.ReadKey();
            }
        }
    }
}
