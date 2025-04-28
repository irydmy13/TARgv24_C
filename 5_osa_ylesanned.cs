using System;
using System.Collections.Generic;

namespace TARgv24_C
{
    internal class _5_osa_ylesanned
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Vali ülesanne:");
            Console.WriteLine("1 – Kalorite kalkulaator");
            Console.WriteLine("5 – Arvude massiivi statistika");
            Console.WriteLine("6 – Lemmikloomade register");

            string valik = Console.ReadLine();

            if (valik == "1")
                KaloriteKalkulaator();
            else if (valik == "5")
                ArvudeStatistika();
            else if (valik == "6")
                LemmikloomadeRegister();
            else
                Console.WriteLine("Tundmatu valik.");
        }

        // Ülesanne 1: Kalorite kalkulaator
        static void KaloriteKalkulaator()
        {
            Console.WriteLine("\n--- Kalorite kalkulaator ---");

            List<Toode> tooted = new List<Toode>();
            tooted.Add(new Toode("Õun", 52));
            tooted.Add(new Toode("Banaan", 89));
            tooted.Add(new Toode("Riis", 130));
            tooted.Add(new Toode("Kana", 165));
            tooted.Add(new Toode("Šokolaad", 546));

            Console.Write("Sisesta oma nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Sisesta vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Console.Write("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine();

            Console.Write("Sisesta pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());

            Console.Write("Sisesta kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());

            Console.Write("Sisesta aktiivsustase (1.2 - 1.9): ");
            double aktiivsus = double.Parse(Console.ReadLine());

            Inimene inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
            double vajadus = inimene.ArvutaKalorid();

            Console.WriteLine($"\n{nimi}, sinu päevane kalorivajadus on: {vajadus:F0} kcal\n");

            Console.WriteLine("Soovituslik kogus toodetest (grammides):");
            foreach (Toode t in tooted)
            {
                double kogus = vajadus / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
            }
        }

        // Ülesanne 5: Arvude massiivi statistika
        static void ArvudeStatistika()
        {
            Console.WriteLine("\n--- Arvude Massiivi Statistika ---");

            Console.WriteLine("Sisesta arvud (eralda tühikuga):");
            string sisend = Console.ReadLine();
            string[] osad = sisend.Split(' ');

            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = double.Parse(osad[i]);
            }

            double summa = 0;
            double maksimum = arvud[0];
            double miinimum = arvud[0];

            foreach (double arv in arvud)
            {
                summa += arv;
                if (arv > maksimum) maksimum = arv;
                if (arv < miinimum) miinimum = arv;
            }

            double keskmine = summa / arvud.Length;

            Console.WriteLine($"\nKokku: {summa:F2}");
            Console.WriteLine($"Keskmine: {keskmine:F2}");
            Console.WriteLine($"Maksimum: {maksimum:F2}");
            Console.WriteLine($"Miinimum: {miinimum:F2}");

            int suuremad = 0;
            foreach (double arv in arvud)
            {
                if (arv > keskmine)
                    suuremad++;
            }

            Console.WriteLine($"Arve, mis on keskmisest suuremad: {suuremad}");

            Console.WriteLine("\nSorteeritud arvud:");
            Array.Sort(arvud);
            foreach (var arv in arvud)
            {
                Console.Write(arv + " ");
            }
            Console.WriteLine();
        }

        // Ülesanne 6: Lemmikloomade register
        static void LemmikloomadeRegister()
        {
            Console.WriteLine("\n--- Lemmikloomade Register ---");

            List<Lemmikloom> loomad = new List<Lemmikloom>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nSisesta {i + 1}. looma andmed:");
                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();
                Console.Write("Liik (nt kass, koer): ");
                string liik = Console.ReadLine();
                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                loomad.Add(new Lemmikloom(nimi, liik, vanus));
            }

            Console.WriteLine("\nKõik kassid:");
            foreach (var loom in loomad)
            {
                if (loom.Liik.ToLower() == "kass")
                    Console.WriteLine($"{loom.Nimi}, {loom.Vanus} aastat");
            }

            double vanusteSumma = 0;
            int loendur = 0;
            foreach (var loom in loomad)
            {
                vanusteSumma += loom.Vanus;
                loendur++;
            }
            double keskmineVanus = vanusteSumma / loendur;
            Console.WriteLine($"\nKeskmine vanus: {keskmineVanus:F2} aastat");

            Lemmikloom vanim = loomad[0];
            foreach (var loom in loomad)
            {
                if (loom.Vanus > vanim.Vanus)
                    vanim = loom;
            }
            Console.WriteLine($"Vanim loom: {vanim.Nimi}, {vanim.Vanus} aastat");

            Console.Write("\nSisesta looma nimi otsimiseks: ");
            string otsitav = Console.ReadLine();

            bool leitud = false;
            foreach (var loom in loomad)
            {
                if (loom.Nimi.ToLower() == otsitav.ToLower())
                {
                    Console.WriteLine($"Leitud: {loom.Nimi}, {loom.Liik}, {loom.Vanus} aastat");
                    leitud = true;
                    break;
                }
            }
            if (!leitud)
                Console.WriteLine("Looma ei leitud.");
        }
    }

    // Klassid (Toode, Inimene, Lemmikloom)

    class Toode
    {
        public string Nimi;
        public double Kalorid100g;

        public Toode(string nimi, double kalorid)
        {
            Nimi = nimi;
            Kalorid100g = kalorid;
        }
    }

    class Inimene
    {
        public string Nimi;
        public int Vanus;
        public string Sugu;
        public double Pikkus;
        public double Kaal;
        public double AktiivsusTase;

        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsusTase)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu.ToLower();
            Pikkus = pikkus;
            Kaal = kaal;
            AktiivsusTase = aktiivsusTase;
        }

        public double ArvutaKalorid()
        {
            if (Sugu == "mees")
                return (66.47 + (13.75 * Kaal) + (5.003 * Pikkus) - (6.755 * Vanus)) * AktiivsusTase;
            else
                return (655.1 + (9.563 * Kaal) + (1.850 * Pikkus) - (4.676 * Vanus)) * AktiivsusTase;
        }
    }

    class Lemmikloom
    {
        public string Nimi;
        public string Liik;
        public int Vanus;

        public Lemmikloom(string nimi, string liik, int vanus)
        {
            Nimi = nimi;
            Liik = liik;
            Vanus = vanus;
        }
    }
}
