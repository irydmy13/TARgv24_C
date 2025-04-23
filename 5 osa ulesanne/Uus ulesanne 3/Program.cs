using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C._5_osa_ulesanne._Uus_ulesanne_3
{
    internal class Program
    {
        static void Main()
        {
            List<Opilane> õpilased = new List<Opilane>();

            for (int i = 0; i < 3; i++)
            {
                Opilane o = new Opilane();

                Console.Write("Sisesta õpilase nimi: ");
                o.Nimi = Console.ReadLine();

                Console.WriteLine("Sisesta 3 hinnet:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Hinne: ");
                    int hinne = int.Parse(Console.ReadLine());
                    o.Hinded.Add(hinne);
                }

                õpilased.Add(o);
            }

            Console.WriteLine("\n--- Õpilaste keskmised hinded ---");

            double maxKeskmine = 0;
            string parim = "";

            foreach (Opilane o in õpilased)
            {
                double keskmine = o.ArvutaKeskmine();
                Console.WriteLine($"{o.Nimi} – keskmine hinne: {keskmine:F2}");

                if (keskmine > maxKeskmine)
                {
                    maxKeskmine = keskmine;
                    parim = o.Nimi;
                }
            }

            Console.WriteLine($"\nParim õpilane on: {parim} keskmise hindega {maxKeskmine:F2}");
        }
    }
}


