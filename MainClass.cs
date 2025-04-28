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



            Isik isik1 = new Isik("Juku", 65, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "98765432101";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();

            int i;
            string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
            string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };
            Console.WriteLine("-----for++Massiv-------");
            Isik[] isikud = FunktsioonideClass_2osa.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }

            Console.WriteLine("-----for--List-------");
            List<Isik> isikud2 = FunktsioonideClass_2osa.Isikud2(nimed.Length, nimed, aadressid);

            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }



            Console.WriteLine("-----while-------");
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("-----do-------");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);


            // I.osa Andmetüübd, If, Case, Random, Alamfunktsioonid

            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere! Hea Päev! Привет!"); 
            int a = 0;
            string tekst = "Python";
            char taht= 'A';
            Console.WriteLine("Double arv: ");
            double arv = Convert.ToDouble(Console.ReadLine());
            //double.TryParse(Console.ReadLine(), out double arv)
            Console.WriteLine("Float arv: ");
            float arv1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n"+tekst);
            Console.WriteLine("Tere!\n {0}",tekst);
            FinktsioonideClass_1osa.Juku(tekst);
            Console.Write("Arv 2: ");
            int arv2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            arv1=FinktsioonideClass_1osa.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);
            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a=rnd.Next(1,7);
            Console.WriteLine(a);
            tekst=FinktsioonideClass_1osa.Nadala_paev(a);
            Console.WriteLine(tekst);*/
            Console.ReadKey();
        }

    }

}