using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day04
    {
        public static void Day4A()
        {
            List<string> list = File.ReadAllLines("2022_4a.txt").ToList();

            int fit = 0;
            foreach (string s in list)
            {
                bool match = false;
                string[] sSPlit = s.Split(',');

                string[] first = sSPlit[0].ToString().Split('-');
                string[] second = sSPlit[1].ToString().Split('-');

                int start1 = int.Parse(first[0].ToString());
                int stop1 = int.Parse(first[1].ToString());

                int start2 = int.Parse(second[0].ToString());
                int stop2 = int.Parse(second[1].ToString());

                if (start1 >= start2 && stop1 <= stop2)
                {
                    fit++;
                    match = true;

                }
                if (start2 >= start1 && stop2 <= stop1 && match == false)
                {
                    fit++;
                }


            }

            MessageBox.Show("double pairs: " + fit.ToString());
        }

        public static void Day4B()
        {
            List<string> list = File.ReadAllLines("2022_4a.txt").ToList();
            int match = 0;


            foreach (string s in list)
            {
                bool overlap = false;
                string[] sSPlit = s.Split(',');

                string[] first = sSPlit[0].ToString().Split('-');
                string[] second = sSPlit[1].ToString().Split('-');

                int start2 = int.Parse(second[0].ToString());
                int stop2 = int.Parse(second[1].ToString());

                for (int i = int.Parse(first[0].ToString()); i < int.Parse(first[1].ToString()) + 1; i++)
                {
                    if (i >= start2 && i <= stop2)
                    {
                        overlap = true;
                    }
                }

                if (overlap == true) { match++; };

            }
            MessageBox.Show("Matching number count = " + match.ToString());


        }
        

    }
}
