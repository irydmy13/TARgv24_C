using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class FunktsioonideClass
    {
        // Funktsioon tervitamiseks
        public static string Tervita(string nimi)
        {
            return "Tere, " + nimi + "!";
        }

        // Funktsioon kontrollib, kas nimi on "juku" ja tagastab pileti info
        public static string KontrolliJuku(string nimi)
        {
            string vastus = string.Empty;

            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno!");
                try
                {
                    Console.Write("Kui vana sa oled, Juku? ");
                    int vanus = int.Parse(Console.ReadLine());

                    if (vanus <= 0 || vanus > 100)
                        vastus = "Viga!";
                    else if (vanus <= 6)
                        vastus = "Tasuta";
                    else if (vanus <= 14)
                        vastus = "Lastepilet";
                    else if (vanus <= 65)
                        vastus = "Täispilet";
                    else
                        vastus = "Sooduspilet";
                }
                catch
                {
                    vastus = "Viga!";
                }
            }
            else
            {
                vastus = "Olen hõivatud!";
            }

            return vastus;
        }

        // Funktsioon tagastab kahe isiku nimed koos tekstiga
        public static string Naabrid(string n1, string n2)
        {
            return n1 + " ja " + n2 + " on täna sinu naabrid.";
        }

        // Funktsioon arvutab ruumi pindala
        public static float ArvutaPindala(float pikkus, float laius)
        {
            return pikkus * laius;
        }

        // Funktsioon arvutab remondi koguhinna
        public static float ArvutaRemont(float pindala, float m2hind)
        {
            return pindala * m2hind;
        }

        // Funktsioon arvutab 30% allahindlusega hinna
        public static float ArvutaSoodushind(float algneHind)
        {
            return algneHind * 0.7f;
        }

        // Funktsioon hindab temperatuuri (ilma ternary'ta)
        public static string KontrolliTemperatuuri(float temp)
        {
            if (temp > 18)
            {
                return "Tuba on piisavalt soe.";
            }
            else
            {
                return "Tuba on liiga külm!";
            }
        }

        // Funktsioon hindab pikkust
        public static string KontrolliPikkust(int pikkus)
        {
            if (pikkus < 160)
                return "Sa oled lühike.";
            else if (pikkus <= 180)
                return "Keskmine pikkus.";
            else
                return "Sa oled pikk.";
        }

        // Funktsioon hindab pikkust sõltuvalt soost
        public static string KontrolliPikkustSugu(int pikkus, string sugu)
        {
            if (sugu == "m")
            {
                if (pikkus < 165) return "Mees: lühike.";
                else if (pikkus <= 185) return "Mees: keskmine.";
                else return "Mees: pikk.";
            }
            else if (sugu == "f")
            {
                if (pikkus < 155) return "Naine: lühike.";
                else if (pikkus <= 175) return "Naine: keskmine.";
                else return "Naine: pikk.";
            }
            else return "Tundmatu sugu.";
        }

        // Funktsioon arvutab ostukorvi summa
        public static float ArvutaOstukorv(bool piim, bool sai, bool leib)
        {
            float summa = 0;
            if (piim) summa += 1.5f;
            if (sai) summa += 2.0f;
            if (leib) summa += 1.8f;
            return summa;
        }

        // Kalkulaator kahe arvu ja tehtemärgiga
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