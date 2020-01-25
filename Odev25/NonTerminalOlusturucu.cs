using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev25
{
    class NonTerminalOlusturucu
    {
        public List<Tuple<List<string>, char, int, Boolean>> Oku(List<string> gecici)
        {
            var NonTerminaller = new List<Tuple<List<string>, char, int, Boolean>>();
            char NT;
            int count;
            Boolean bol = false;
            List<string> list = new List<string>();

            for (int i = 1; i < gecici.Count; i++)
            {
                bol = false;
                count = 0;
                NT = gecici[i].ElementAt(1);
                list = gecici[i].Trim().Remove(0, 4).Split('|').ToList<string>();

                foreach (string h in list)
                    if (h[0] >= 65 && h[0] <= 90)
                        count++;

                if (count != 0)
                    bol = true;
                NonTerminaller.Add(new Tuple<List<string>, char, int, Boolean>(list, NT, count, bol));
            }

            return NonTerminaller;
        }
    }
}


/*
 *             foreach (Tuple<List<string>, char, int, Boolean> j in NonTerminal)
            {
                //char x = NonTerminal[1].Item2;
                var result = string.Join(" ", j.Item1.ToArray());
                Console.WriteLine("Item 1: " + result + " // Item 2: " + j.Item2 + " // Item 3: " + j.Item3 + " // Item 4: " + j.Item4);
            }
*/