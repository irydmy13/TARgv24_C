using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class FunktsioonideClass
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;

            Console.Write("Sisesta tehe (+, -, *, /): ");
            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "+": kalkulaator = arv1 + arv2; break;
                case "-": kalkulaator = arv1 - arv2; break;
                case "*": kalkulaator = arv1 * arv2; break;
                case "/":
                    if (arv2 != 0)
                        kalkulaator = (float)arv1 / arv2;
                    else
                        Console.WriteLine("Nulliga jagamine pole lubatud!");
                    break;
                default:
                    Console.WriteLine("Tundmatu tehe!");
                    break;
            }

            return kalkulaator;
        }
    }
}
