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
            //II. osa Kordused, Massivid, Listid, Klassid
            List<string> sonad = FunktsioonideClass_2osa.Sõnad();
            foreach (var item in sonad)
            {
                Console.WriteLine(item);
            }

            Isik isik1  = new Isik("Juku", 65, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "98765432101";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();        
            
         
            int i;

            string[] nimed = new string[10] {"Juku", "Mari", "Kati", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi", "Jana"};
            string[] aadressid = new string[10] {"Tallinn", "Tartu", "Parnu", "Narva", "Kohtla-Jarve", "Vijandi", "Rakvere", "Paide", "Johvi", "Kuressaare" };
            Console.WriteLine("------ for++Massiv ------");
            Isik[] isikud = FunktsioonideClass_2osa.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }

           
            Console.WriteLine("------ for--List ------");
            List<Isik> isikud2 = FunktsioonideClass_2osa.Isikud2(nimed.Length, nimed, aadressid);

            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }


            Console.WriteLine("------ while ------");
            while (i>=0)
            {
                Console.WriteLine(i);
                i--;

            }
            Console.WriteLine("------ do ------");
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();

            }
            while (key.Key!=ConsoleKey.Backspace);




            //Console.OutputEncoding = Encoding.UTF8;

            //// 1. Tervitus ja Juku
            //Console.Write("Mis on sinu nimi? ");
            //string nimi = Console.ReadLine();
            //Console.WriteLine(FunktsioonideClass_1osa.Tervita(nimi));
            //Console.WriteLine(FunktsioonideClass_1osa.KontrolliJuku(nimi));

            //// 2. Naabrid
            //Console.Write("Sisesta esimene nimi: ");
            //string naaber1 = Console.ReadLine();
            //Console.Write("Sisesta teine nimi: ");
            //string naaber2 = Console.ReadLine();
            //Console.WriteLine(FunktsioonideClass_1osa.Naabrid(naaber1, naaber2));

            //// 3. Ruumi pindala ja remont
            //Console.Write("Sisesta toa pikkus meetrites: ");
            //float pikkus = float.Parse(Console.ReadLine());
            //Console.Write("Sisesta toa laius meetrites: ");
            //float laius = float.Parse(Console.ReadLine());
            //float pindala = FunktsioonideClass_1osa.ArvutaPindala(pikkus, laius);
            //Console.WriteLine("Pindala: " + pindala + " m2");

            //Console.Write("Kas soovid remonti teha? (jah/ei): ");
            //string remont = Console.ReadLine().ToLower();
            //if (remont == "jah")
            //{
            //    Console.Write("Ruutmeetri hind (€): ");
            //    float hind = float.Parse(Console.ReadLine());
            //    float maksumus = FunktsioonideClass_1osa.ArvutaRemont(pindala, hind);
            //    Console.WriteLine("Remondi kogumaksumus: " + maksumus + " €");
            //}

            //// 4. Soodushind
            //Console.Write("Sisesta algne hind (€): ");
            //float hindOrig = float.Parse(Console.ReadLine());
            //Console.WriteLine("Soodushind (30%): " + FunktsioonideClass_1osa.ArvutaSoodushind(hindOrig) + " €");

            //// 5. Temperatuur
            //Console.Write("Sisesta toatemperatuur: ");
            //float temp = float.Parse(Console.ReadLine());
            //Console.WriteLine(FunktsioonideClass_1osa.KontrolliTemperatuuri(temp));

            //// 6. Pikkus
            //Console.Write("Sisesta oma pikkus (cm): ");
            //int pikkusCm = int.Parse(Console.ReadLine());
            //Console.WriteLine(FunktsioonideClass_1osa.KontrolliPikkust(pikkusCm));

            //// 7. Pikkus ja sugu
            //Console.Write("Sisesta sugu (m/f): ");
            //string sugu = Console.ReadLine().ToLower();
            //Console.WriteLine(FunktsioonideClass_1osa.KontrolliPikkustSugu(pikkusCm, sugu));

            //// 8. Ostukorv
            //Console.Write("Kas soovid piima? (jah/ei): ");
            //bool piim = Console.ReadLine().ToLower() == "jah";

            //Console.Write("Kas soovid saia? (jah/ei): ");
            //bool sai = Console.ReadLine().ToLower() == "jah";

            //Console.Write("Kas soovid leiba? (jah/ei): ");
            //bool leib = Console.ReadLine().ToLower() == "jah";

            //float summa = FunktsioonideClass_1osa.ArvutaOstukorv(piim, sai, leib);
            //Console.WriteLine("Ostukorvi summa: " + summa + " €");

            //Console.ReadKey();
        }
    }
}