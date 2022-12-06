using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day02
    {
        public static string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static void Day2A()
        {
            int score = 0;

            string[] a2_2002 = System.IO.File.ReadAllLines("2022_2a.txt");

            foreach (string game in a2_2002)
            {
                string elf = game.Substring(0, 1);
                string me = game.Substring(2, 1);

                if (elf == "A" && me == "X") //tie
                {
                    score += (3 + 1);
                }
                else if (elf == "A" && me == "Y") //win
                {
                    score += (6 + 2);
                }
                else if (elf == "A" && me == "Z") //lost
                {
                    score += (0 + 3);
                }
                else if (elf == "B" && me == "X") //Loss
                {
                    score += (0 + 1);
                }
                else if (elf == "B" && me == "Y") //tie
                {
                    score += (3 + 2);
                }
                else if (elf == "B" && me == "Z") //win                
                {
                    score += (6 + 3);
                }
                else if (elf == "C" && me == "X") //win                
                {
                    score += (6 + 1);
                }
                else if (elf == "C" && me == "Y") //lost                
                {
                    score += (0 + 2);
                }
                else if (elf == "C" && me == "Z") //tie               
                {
                    score += (3 + 3);
                }
            }

            MessageBox.Show("My score = " + score.ToString());
        }



        public static void Day2B()
        {
            int score = 0;

            List<string> list = File.ReadAllLines("2022_2a.txt").ToList();

            string[] a2_2002 = File.ReadAllLines("2022_2a.txt");

            foreach (string game in a2_2002)
            {
                string elf = game.Substring(0, 1);
                string me = game.Substring(2, 1);

                if (elf == "A" && me == "X") //lose
                {
                    score += (0 + 3); //rock vs scissors
                }
                else if (elf == "A" && me == "Y") //tie
                {
                    score += (3 + 1); //rock vs rock
                }
                else if (elf == "A" && me == "Z") //winn
                {
                    score += (6 + 2); //rock vs paper
                }
                else if (elf == "B" && me == "X") //Lose
                {
                    score += (0 + 1);  // paper vs rock
                }
                else if (elf == "B" && me == "Y") //tie
                {
                    score += (3 + 2); // paper vs paper
                }
                else if (elf == "B" && me == "Z") //win                
                {
                    score += (6 + 3);  //paper vs scissors
                }
                else if (elf == "C" && me == "X") //lose                
                {
                    score += (0 + 2);  // scissors vs paper
                }
                else if (elf == "C" && me == "Y") //tie               
                {
                    score += (3 + 3); //scissors vs scissors
                }
                else if (elf == "C" && me == "Z") //win               
                {
                    score += (6 + 1);   //scissors vs rock
                }
            }

            MessageBox.Show("My score = " + score.ToString());
        }

        public static int GetBPChars(string firstHalf, string secondhalf)
        {
            int bpsum = 0;

            for (int f = 0; f < firstHalf.Length; f++)
            {
                for (int s = 0; s < secondhalf.Length; s++)
                {
                    if (firstHalf.Substring(f, 1) == secondhalf.Substring(s, 1))
                    {
                        return returnlettervalue(firstHalf.Substring(f, 1));
                    }

                }
            }
            return bpsum;
        }
        public static  int returnlettervalue(string letter)
        {
            int lettervalue = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letter == letters.Substring(i, 1))
                {
                    lettervalue = i;
                }
            }
            return lettervalue + 1;
        }

        public static int GetBackPackValue(string elf1, string elf2, string elf3)
        {
            string letter = "";

            for (int i1 = 0; i1 < elf1.Length; i1++)
            {
                for (int i2 = 0; i2 < elf2.Length; i2++)
                {
                    if (elf1.Substring(i1, 1) == elf2.Substring(i2, 1))
                    {
                        for (int i3 = 0; i3 < elf3.Length; i3++)
                        {
                            if (elf2.Substring(i2, 1) == elf3.Substring(i3, 1))
                            {
                                letter = elf1.Substring(i1, 1);
                            }
                        }
                    }
                }
            }
            return returnlettervalue(letter);
        }


    }
}
