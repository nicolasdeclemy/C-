using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            float size, weight, IMC;
            Console.Write("Quelle est votre poids ?");
            weight = float.Parse(Console.ReadLine());

            Console.Write("Quelle est votre taille ?");
            size = float.Parse(Console.ReadLine());

            IMC = (weight / (size*size));

            if (IMC < 16.5)
            {
                Console.WriteLine("Vous êtes en dénutrition !");
            }
            else if ((IMC > 16.5) && (IMC < 18.5))
            {
                Console.WriteLine("Vous êtes en état de maigreur !");
            }
            else if ((IMC > 18.5) && (IMC < 25))
            {
                Console.WriteLine("Vous êtes de corpulence normale !");
            }
            else if ((IMC > 25) && (IMC < 30))
            {
                Console.WriteLine("Vous êtes en surpoids !");
            }
            else if ((IMC > 30) && (IMC < 35))
            {
                Console.WriteLine("Vous êtes en obésité Modérée !");
            }
            else if ((IMC > 35) && (IMC < 40))
            {
                Console.WriteLine("Vous êtes en obésité sévère !");
            }
            else if ((IMC > 40))
            {
                Console.WriteLine("Vous êtes en obésité morbide ou massive !");
            }
            Console.ReadKey();
        }
    }
}
