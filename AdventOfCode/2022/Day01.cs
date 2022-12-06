using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day01
    {
        public static void Day1A()
        {
            long elfno = 0;
            long elfCounter = 1;
            long Calories = 0;
            long caloriesCounter = 0;


            long Top1Calories = 0;
            long Top2Calories = 0;
            long Top3Calories = 0;

            long top1Elf = 0;
            long top2Elf = 0;
            long top3Elf = 0;



            string[] a1_2002 = System.IO.File.ReadAllLines("2022_1a.txt");

            foreach (string elf in a1_2002)
            {

                if (elf != string.Empty)
                {
                    caloriesCounter += long.Parse(elf);
                }
                else
                {
                    if (caloriesCounter > Calories)
                    {
                        Calories = caloriesCounter;
                        elfno = elfCounter;
                    }

                    if (caloriesCounter > Top1Calories)
                    {
                        Top3Calories = Top2Calories;
                        Top2Calories = Top1Calories;
                        Top1Calories = caloriesCounter;

                        top3Elf = top2Elf;
                        top2Elf = top1Elf;
                        top1Elf = elfCounter;
                    }
                    else if (caloriesCounter > Top2Calories && caloriesCounter <= Top1Calories)
                    {

                        Top3Calories = Top2Calories;
                        Top2Calories = caloriesCounter;

                        top3Elf = top2Elf;
                        top2Elf = elfCounter;

                    }
                    else if (caloriesCounter > Top3Calories && caloriesCounter <= Top2Calories)
                    {

                        Top3Calories = caloriesCounter;
                        top3Elf = elfCounter;
                    }


                    caloriesCounter = 0;
                    elfCounter++;
                }

            }

            MessageBox.Show("Elf number: " + elfno.ToString() + " is carrying " + Calories.ToString() + " Calories");

            long totaltop3 = Top1Calories + Top2Calories + Top3Calories;

            MessageBox.Show("The sum Calories of the top3 Elf is: " + totaltop3.ToString());
        }

        public static void Day1B()
        {
          
        }

    }
}
