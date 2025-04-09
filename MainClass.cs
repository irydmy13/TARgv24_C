using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Tervitus ja Juku
            Console.Write("Mis on sinu nimi? ");
            string nimi = Console.ReadLine();
            Console.WriteLine(FunktsioonideClass.Tervita(nimi));
            Console.WriteLine(FunktsioonideClass.KontrolliJuku(nimi));

            // 2. Naabrid
            Console.Write("Sisesta esimene nimi: ");
            string naaber1 = Console.ReadLine();
            Console.Write("Sisesta teine nimi: ");
            string naaber2 = Console.ReadLine();
            Console.WriteLine(FunktsioonideClass.Naabrid(naaber1, naaber2));

            // 3. Ruumi pindala ja remont
            Console.Write("Sisesta toa pikkus meetrites: ");
            float pikkus = float.Parse(Console.ReadLine());
            Console.Write("Sisesta toa laius meetrites: ");
            float laius = float.Parse(Console.ReadLine());
            float pindala = FunktsioonideClass.ArvutaPindala(pikkus, laius);
            Console.WriteLine("Pindala: " + pindala + " m2");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string remont = Console.ReadLine().ToLower();
            if (remont == "jah")
            {
                Console.Write("Ruutmeetri hind (€): ");
                float hind = float.Parse(Console.ReadLine());
                float maksumus = FunktsioonideClass.ArvutaRemont(pindala, hind);
                Console.WriteLine("Remondi kogumaksumus: " + maksumus + " €");
            }

            // 4. Soodushind
            Console.Write("Sisesta algne hind (€): ");
            float hindOrig = float.Parse(Console.ReadLine());
            Console.WriteLine("Soodushind (30%): " + FunktsioonideClass.ArvutaSoodushind(hindOrig) + " €");

            // 5. Temperatuur
            Console.Write("Sisesta toatemperatuur: ");
            float temp = float.Parse(Console.ReadLine());
            Console.WriteLine(FunktsioonideClass.KontrolliTemperatuuri(temp));

            // 6. Pikkus
            Console.Write("Sisesta oma pikkus (cm): ");
            int pikkusCm = int.Parse(Console.ReadLine());
            Console.WriteLine(FunktsioonideClass.KontrolliPikkust(pikkusCm));

            // 7. Pikkus ja sugu
            Console.Write("Sisesta sugu (m/f): ");
            string sugu = Console.ReadLine().ToLower();
            Console.WriteLine(FunktsioonideClass.KontrolliPikkustSugu(pikkusCm, sugu));

            // 8. Ostukorv
            Console.Write("Kas soovid piima? (jah/ei): ");
            bool piim = Console.ReadLine().ToLower() == "jah";

            Console.Write("Kas soovid saia? (jah/ei): ");
            bool sai = Console.ReadLine().ToLower() == "jah";

            Console.Write("Kas soovid leiba? (jah/ei): ");
            bool leib = Console.ReadLine().ToLower() == "jah";

            float summa = FunktsioonideClass.ArvutaOstukorv(piim, sai, leib);
            Console.WriteLine("Ostukorvi summa: " + summa + " €");

            Console.ReadKey();
        }
    }
}