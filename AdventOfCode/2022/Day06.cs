using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day06
    {
        public static void Day6A()
        {
            int charcounter = 0;
            int matchcounter = 0;
            int firstmatch = 0;

            bool match = false;
            List<string> singlestream = new List<string>();
            string datatastream = File.ReadAllText("2022_6a.txt");

            for (int i = 0; i < datatastream.Length - 1; i++)
            {
                charcounter++;
                string letter = datatastream.Substring(i, 1);

                if (singlestream.Contains(letter)) { match = true; };
                singlestream.Add(letter);
                if (match == true && singlestream.Count > 4)
                {
                    List<string> tmp = new List<string>();

                    if (!tmp.Contains(singlestream[singlestream.Count - 1]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 1]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 2]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 2]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 3]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 3]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 4]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 4]);
                    };

                    if (tmp.Count == 4)
                    {
                        matchcounter++;
                        if (matchcounter == 1) { firstmatch = charcounter; };

                        singlestream.Clear();
                    }
                }
            }
            MessageBox.Show("first match after " + firstmatch.ToString() + " chars");


        }

        public static void Day6B()
        {
            int charcounter = 0;
            int matchcounter = 0;
            int firstmatch = 0;

            bool match = false;
            List<string> singlestream = new List<string>();
            //List<string> datastream = File.ReadAllLines("2022_6a.txt").ToList();
            string datatastream = File.ReadAllText("2022_6a.txt");

            for (int i = 0; i < datatastream.Length - 1; i++)
            {
                charcounter++;
                string letter = datatastream.Substring(i, 1);

                if (singlestream.Contains(letter)) { match = true; };
                singlestream.Add(letter);
                if (match == true && singlestream.Count > 13)
                {
                    List<string> tmp = new List<string>();

                    if (!tmp.Contains(singlestream[singlestream.Count - 1]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 1]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 2]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 2]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 3]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 3]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 4]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 4]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 5]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 5]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 6]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 6]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 7]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 7]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 8]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 8]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 9]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 9]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 10]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 10]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 11]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 11]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 12]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 12]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 13]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 13]);
                    };
                    if (!tmp.Contains(singlestream[singlestream.Count - 14]))
                    {
                        tmp.Add(singlestream[singlestream.Count - 14]);
                    };
                    if (tmp.Count == 14)
                    {
                        matchcounter++;
                        if (matchcounter == 1) { firstmatch = charcounter; };
                        singlestream.Clear();
                    }


                }
            }
            MessageBox.Show("first match after " + firstmatch.ToString() + " chars");

        }

    }
}
