using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day03
    {
        public static void Day3A()
        {
            List<string> backpacks = File.ReadAllLines("2022_3a.txt").ToList();
            int bpValue = 0;

            foreach (var backpack in backpacks)
            {

                int items = backpack.ToString().Length;
                int halfitems = items / 2;
                bpValue += Day02.GetBPChars(backpack.Substring(0, halfitems), backpack.Substring(halfitems, halfitems));


            }
            MessageBox.Show("The total value= " + bpValue.ToString());


        }

        public static void Day3B()
        {
            int groupnumber = 1;
            int BackPackvalue = 0;

            List<string> backpacks = File.ReadAllLines("2022_3a.txt").ToList();

            string elf1 = "";
            string elf2 = "";
            string elf3 = "";

            foreach (string backpac in backpacks)
            {
                if (groupnumber == 1)
                {
                    elf1 = backpac;
                    groupnumber++;
                }
                else if (groupnumber == 2)
                {
                    elf2 = backpac;
                    groupnumber++;
                }
                else if (groupnumber == 3)
                {
                    elf3 = backpac;

                    BackPackvalue += Day02.GetBackPackValue(elf1, elf2, elf3);
                    groupnumber = 1;
                }
            }

            MessageBox.Show("The result is: " + BackPackvalue.ToString());
        }

    }
}
