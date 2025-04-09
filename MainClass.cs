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
            Console.WriteLine("Tere! Hea Päev! Привет!");
            // I. osa Andmetüübd, If, Case, Random, Alamfunktsioonid
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4744932749;
            float arv1 = 2;

            // 1. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.
            Console.Write("Mis on sinu nimi? ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Tere, " + nimi + "!");

            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno!");

                try
                {
                    Console.Write("Kui vana sa oled, Juku? ");
                    int vanus = int.Parse(Console.ReadLine());

                    if (vanus <= 0 || vanus > 100)
                        Console.WriteLine("Viga andmetega!");
                    else if (vanus < 6)
                        Console.WriteLine("Pilet: Tasuta");
                    else if (vanus < 15)
                        Console.WriteLine("Pilet: Lastepilet");
                    else if (vanus <= 65)
                        Console.WriteLine("Pilet: Täispilet");
                    else
                        Console.WriteLine("Pilet: Sooduspilet");
                }
                catch
                {
                    Console.WriteLine("Viga!");
                }
            }
            else
            {
                Console.WriteLine("Olen hõivatud!");
            }

            // 2. Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            Console.Write("Sisesta esimene nimi: ");
            string naaber1 = Console.ReadLine();
            Console.Write("Sisesta teine nimi: ");
            string naaber2 = Console.ReadLine();
            Console.WriteLine(naaber1 + " ja " + naaber2 + " on täna sinu naabrid.");

            // 3. Ruumi pindala ja renoveerimise maksumus
            Console.Write("Sisesta toa pikkus meetrites: ");
            float pikkus = float.Parse(Console.ReadLine());
            Console.Write("Sisesta toa laius meetrites: ");
            float laius = float.Parse(Console.ReadLine());
            float pindala = pikkus * laius;
            Console.WriteLine("Põranda pindala on " + pindala + " m2.");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string remont = Console.ReadLine().ToLower();
            if (remont == "jah")
            {
                Console.Write("Kui palju maksab üks ruutmeeter (€): ");
                float hind = float.Parse(Console.ReadLine());
                float maksumus = hind * pindala;
                Console.WriteLine("Põranda vahetus maksab kokku: " + maksumus + " €");
            }

            // 4. Leia 30% hinnasoodustusega hind
            Console.Write("Sisesta algne hind (€): ");
            float origHind = float.Parse(Console.ReadLine());
            float soodushind = origHind * 0.7f;
            Console.WriteLine("Soodushind (30%): " + soodushind + " €");

            // 5. Küsi temperatuur ja teata, kas see on üle 18 kraadi
            Console.Write("Mis on temperatuur toas? ");
            float temp = float.Parse(Console.ReadLine());
            if (temp > 18)
                Console.WriteLine("Tuba on piisavalt soe.");
            else
                Console.WriteLine("Tuba on liiga külm!");

            // 6. Pikkuse järgi hindamine
            Console.Write("Sisesta oma pikkus (cm): ");
            int pikkusCm = int.Parse(Console.ReadLine());
            if (pikkusCm < 160)
                Console.WriteLine("Sa oled lühike.");
            else if (pikkusCm <= 180)
                Console.WriteLine("Keskmine pikkus.");
            else
                Console.WriteLine("Sa oled pikk.");

            // 7. Pikkus ja sugu koos
            Console.Write("Sisesta sugu (m/f): ");
            string sugu = Console.ReadLine().ToLower();

            if (sugu == "m")
            {
                if (pikkusCm < 165)
                    Console.WriteLine("Mees: lühike.");
                else if (pikkusCm <= 185)
                    Console.WriteLine("Mees: keskmine.");
                else
                    Console.WriteLine("Mees: pikk.");
            }
            else if (sugu == "f")
            {
                if (pikkusCm < 155)
                    Console.WriteLine("Naine: lühike.");
                else if (pikkusCm <= 175)
                    Console.WriteLine("Naine: keskmine.");
                else
                    Console.WriteLine("Naine: pikk.");
            }

            // 8. Pood – kas ostab piima, saia, leiba
            float kogusumma = 0;

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah") kogusumma += 1.5f;

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah") kogusumma += 2.0f;

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah") kogusumma += 1.8f;

            Console.WriteLine("Ostukorvi kogusumma: " + kogusumma + " €");

            Console.ReadKey();
        }
    }
}
