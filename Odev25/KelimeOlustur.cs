using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Odev25
{
    class KelimeOlustur
    {
        private List<string> gecici = new List<string>();
        private List<string> giris = new List<string>();
        private List<string> Kelimeler = new List<string>();
        private List<Tuple<List<string>, char, int, Boolean>> NonTerminal;
        private StringBuilder temp = new StringBuilder();
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();


        public KelimeOlustur(String Alfabe, String CFG)
        {
            NonTerminalOlusturucu olustur = new NonTerminalOlusturucu();

            foreach (var i in CFG)
            {
                if (i != '|' && i != '>' && i != '-' && i != 'S' && !Alfabe.Contains(i.ToString()))
                {
                    return;
                }
            }

            gecici = CFG.Split(',').ToList<string>();
            giris = gecici[0].Trim().Remove(0, 4).Split('|').ToList<string>();

            NonTerminal = olustur.Oku(gecici);
        }

        public List<string> Dil_Agaci()
        {
            int x = 0;
            while (x < giris.Count)
            {
                gecici.Clear();
                gecici = PossibleWords(giris[x]);
                Kelimeler.AddRange(gecici);
                x++;
            }

            return Kelimeler;
        }

        public List<string> PossibleWords(string a)
        {
            int x = 0, flag = 0;
            bool BOOL = false;
            List<string> mainList = new List<string>();

            foreach (char c in a)
                if (c >= 65 && c <= 90)
                    BOOL = true;

            //------------------- Eğer Verilen String te NON TERMİNAL varsa ------------------------
            if (BOOL)
            {

                int sayi = 0;
                //---------------------- Yukarıda oluşan dizide X lerin yerine kümeden eleman seçip koy -----------------------------
                while (sayi < 2000)
                {
                    foreach (char c in a)
                    {
                        if (c >= 65 && c <= 90)
                            dondur(c);

                        if (c >= 97 && c <= 122)
                            temp.Append(c);
                    }


                    foreach (string y in mainList)
                    {
                        if (y == temp.ToString())
                            flag = 1;
                    }

                    if (flag == 0)
                    {
                        mainList.Add(temp.ToString());
                        x++;
                    }

                    flag = 0;
                    sayi++;
                    temp.Clear();
                }
            }
            else
                mainList.Add(a);

            return mainList;
        }

        public void dondur(char a)
        {
            string z = "";
            foreach (Tuple<List<string>, char, int, Boolean> l in NonTerminal)
                if (a == l.Item2)
                {
                    z = l.Item1[elemanSec(0, l.Item1.Count)];
                    if (z[0] >= 65 && z[0] <= 90)
                        dondur(z[0]);

                    else
                        temp.Append(z);
                }
        }

        public int elemanSec(int min, int max)
        {
            lock (syncLock)
                return random.Next(min, max);
        }
    }
}