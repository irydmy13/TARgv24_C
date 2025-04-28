using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class _3_osa_ylesanned
    {
        static void Main(string[] args)
        {
            ArvudeRuudud();

            PositiivsedJaNegatiivsed();

            OpilastegaMangimine();

            OstaElevantAra();

            ArvamiseMang();
        }

        // Задание 9: Arvude Ruudud 
        static void ArvudeRuudud()
        {
            Console.WriteLine("\n--- Arvude Ruudud ---");

            int[] arvud = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine("For-tsükkel (ruudud):");
            for (int i = 0; i < arvud.Length; i++)
            {
                int ruut = arvud[i] * arvud[i];
                Console.WriteLine($"{arvud[i]} ruut on {ruut}");
            }

            Console.WriteLine("\nForeach-tsükkel (kahekordsed väärtused):");
            foreach (int arv in arvud)
            {
                int kahekordne = arv * 2;
                Console.WriteLine($"{arv} kahekordne on {kahekordne}");
            }

            Console.WriteLine("\nWhile-tsükkel (jagub 3-ga):");
            int nr = 0;
            int jagubKolmega = 0;

            while (nr < arvud.Length)
            {
                if (arvud[nr] % 3 == 0)
                {
                    jagubKolmega++;
                }
                nr++;
            }

            Console.WriteLine($"Arve, mis jaguvad 3-ga: {jagubKolmega}");
        }

        // Задание 10: Positiivsed ja Negatiivsed
        static void PositiivsedJaNegatiivsed()
        {
            Console.WriteLine("\n--- Positiivsed ja Negatiivsed ---");

            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;

            foreach (int arv in arvud)
            {
                if (arv > 0)
                {
                    positiivsed++;
                }
                else if (arv < 0)
                {
                    negatiivsed++;
                }
                else
                {
                    nullid++;
                }
            }

            Console.WriteLine($"Positiivseid arve: {positiivsed}");
            Console.WriteLine($"Negatiivseid arve: {negatiivsed}");
            Console.WriteLine($"Nulle: {nullid}");
        }

        // Задание 8: Õpilastega Mängimine
        static void OpilastegaMangimine()
        {
            Console.WriteLine("\n--- Õpilastega Mängimine ---");

            string[] nimed = { "Anna", "Britt", "Carl", "Diana", "Evert", "Fred", "Gustav", "Hanna", "Iris", "Joonas" };

            // Asendame kolmanda ja kuuenda
            nimed[2] = "Kati";
            nimed[5] = "Mati";

            Console.WriteLine("\nWhile-tsükkel (nimed A-ga):");
            int i = 0;
            while (i < nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }

            Console.WriteLine("\nFor-tsükkel (nimed ja indeksid):");
            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"{j}: {nimed[j]}");
            }

            Console.WriteLine("\nForeach-tsükkel (väikeste tähtedega nimed):");
            foreach (var nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }

            Console.WriteLine("\nDo-while-tsükkel (kuni Mati):");
            int k = 0;
            do
            {
                Console.WriteLine($"Tere, {nimed[k]}!");
                k++;
            } while (k < nimed.Length && nimed[k - 1] != "Mati");
        }

        // Задание 4: "Osta elevant ära!"
        static void OstaElevantAra()
        {
            Console.WriteLine("\n--- Osta Elevant Ära ---");

            List<string> sisestused = new List<string>();
            string fraas = "Osta elevant ära!";
            string märksõna = "elevant";

            string sisend = "";

            while (sisend != märksõna)
            {
                Console.WriteLine(fraas);
                sisend = Console.ReadLine();
                sisestused.Add(sisend);
            }

            Console.WriteLine("\nSisestused:");
            foreach (string vastus in sisestused)
            {
                Console.WriteLine(vastus);
            }
        }

        // Задание 5: Arvamise Mäng
        static void ArvamiseMang()
        {
            Console.WriteLine("\n--- Arvamise Mäng ---");

            Random rnd = new Random();
            bool uuesti = true;

            while (uuesti)
            {
                int arvutiArv = rnd.Next(1, 101);
                int katseteArv = 5;
                bool võit = false;

                Console.WriteLine("Arva ära arv, vahemikus 1 kuni 100. Sul on 5 katset!");

                for (int i = 0; i < katseteArv; i++)
                {
                    Console.Write($"Sisesta oma arv (katse {i + 1}): ");
                    int pakkumine = int.Parse(Console.ReadLine());

                    if (pakkumine == arvutiArv)
                    {
                        Console.WriteLine("Õige! Sa võitsid!");
                        võit = true;
                        break;
                    }
                    else if (pakkumine < arvutiArv)
                    {
                        Console.WriteLine("Liiga väike!");
                    }
                    else
                    {
                        Console.WriteLine("Liiga suur!");
                    }
                }

                if (!võit)
                {
                    Console.WriteLine($"Kaotasid! Õige arv oli {arvutiArv}.");
                }

                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                string vastus = Console.ReadLine();
                if (vastus.ToLower() != "jah")
                {
                    uuesti = false;
                }
            }
        }
    }
}
