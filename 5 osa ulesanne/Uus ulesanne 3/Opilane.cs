using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C._5_osa_ulesanne._Uus_ulesanne_3
{
    internal class Opilane
    {
        public string Nimi;                        // имя ученика
        public List<int> Hinded = new List<int>(); // список оценок

        public double ArvutaKeskmine()             // расчёт средней оценки
        {
            int summa = 0;
            foreach (int hinne in Hinded)
            {
                summa += hinne;
            }
            return (double)summa / Hinded.Count;
        }
    }
}
    
