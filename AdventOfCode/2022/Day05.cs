using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdventOfCode
{
    internal class Day05
    {
        public static void Day5A()
        {
            List<string> row1 = new List<string>(new string[] { "T", "D", "W", "Z", "V", "P" });
            List<string> row2 = new List<string>(new string[] { "L", "S", "W", "V", "F", "J", "D" });
            List<string> row3 = new List<string>(new string[] { "Z", "M", "L", "S", "V", "T", "B", "H" });
            List<string> row4 = new List<string>(new string[] { "R", "S", "J" });
            List<string> row5 = new List<string>(new string[] { "C", "Z", "B", "G", "F", "M", "L", "W" });
            List<string> row6 = new List<string>(new string[] { "Q", "W", "V", "H", "Z", "R", "G", "B" });
            List<string> row7 = new List<string>(new string[] { "V", "J", "P", "C", "B", "D", "N" });
            List<string> row8 = new List<string>(new string[] { "P", "T", "B", "Q" });
            List<string> row9 = new List<string>(new string[] { "H", "G", "Z", "R", "C" });

            List<string> list = File.ReadAllLines("2022_5a.txt").ToList();


            foreach (string action in list)
            {
                List<string> boxes = new List<string>();
                string[] move = action.Split(' ');

                int count = int.Parse(move[1]);
                int from = int.Parse(move[3]);
                int to = int.Parse(move[5]);


                switch (from)
                {
                    case 1:
                        int c1 = row1.Count;

                        for (int i1 = c1; i1 > c1 - count; i1--)
                        {
                            boxes.Add(row1[i1 - 1]);
                            row1.RemoveAt(i1 - 1);
                        }
                        break;

                    case 2:
                        int c2 = row2.Count;

                        for (int i2 = c2; i2 > c2 - count; i2--)
                        {
                            boxes.Add(row2[i2 - 1]);
                            row2.RemoveAt(i2 - 1);
                        }
                        break;
                    case 3:
                        int c3 = row3.Count;

                        for (int i3 = c3; i3 > c3 - count; i3--)
                        {
                            boxes.Add(row3[i3 - 1]);
                            row3.RemoveAt(i3 - 1);
                        }
                        break;
                    case 4:
                        int c4 = row4.Count;

                        for (int i4 = c4; i4 > c4 - count; i4--)
                        {
                            boxes.Add(row4[i4 - 1]);
                            row4.RemoveAt(i4 - 1);
                        }
                        break;
                    case 5:
                        int c5 = row5.Count;

                        for (int i5 = c5; i5 > c5 - count; i5--)
                        {
                            boxes.Add(row5[i5 - 1]);
                            row5.RemoveAt(i5 - 1);
                        }
                        break;
                    case 6:
                        int c6 = row6.Count;

                        for (int i6 = c6; i6 > c6 - count; i6--)
                        {
                            boxes.Add(row6[i6 - 1]);
                            row6.RemoveAt(i6 - 1);
                        }
                        break;
                    case 7:
                        int c7 = row7.Count;

                        for (int i7 = c7; i7 > c7 - count; i7--)
                        {
                            boxes.Add(row7[i7 - 1]);
                            row7.RemoveAt(i7 - 1);
                        }
                        break;
                    case 8:
                        int c8 = row8.Count;

                        for (int i8 = c8; i8 > c8 - count; i8--)
                        {
                            boxes.Add(row8[i8 - 1]);
                            row8.RemoveAt(i8 - 1);
                        }
                        break;
                    case 9:
                        int c9 = row9.Count;

                        for (int i9 = c9; i9 > c9 - count; i9--)
                        {
                            boxes.Add(row9[i9 - 1]);
                            row9.RemoveAt(i9 - 1);
                        }
                        break;

                }

                switch (to)
                {
                    case 1:

                        foreach (string b in boxes)
                        {
                            row1.Add(b);
                        }
                        break;
                    case 2:

                        foreach (string b in boxes)
                        {
                            row2.Add(b);
                        }
                        break;
                    case 3:

                        foreach (string b in boxes)
                        {
                            row3.Add(b);
                        }
                        break;
                    case 4:
                        foreach (string b in boxes)
                        {
                            row4.Add(b);
                        }
                        break;
                    case 5:
                        foreach (string b in boxes)
                        {
                            row5.Add(b);
                        }
                        break;
                    case 6:
                        foreach (string b in boxes)
                        {
                            row6.Add(b);
                        }
                        break;
                    case 7:
                        foreach (string b in boxes)
                        {
                            row7.Add(b);
                        }
                        break;
                    case 8:
                        foreach (string b in boxes)
                        {
                            row8.Add(b);
                        }
                        break;
                    case 9:
                        foreach (string b in boxes)
                        {
                            row9.Add(b);
                        }
                        break;
                }
                boxes.Clear();

            }

            MessageBox.Show("the code= " + row1[row1.Count - 1] + row2[row2.Count - 1] + row3[row3.Count - 1] + row4[row4.Count - 1] + row5[row5.Count - 1] + row6[row6.Count - 1] + row7[row7.Count - 1] + row8[row8.Count - 1] + row9[row9.Count - 1]);

        }

        public static void Day5B()
        {
            List<string> row1 = new List<string>(new string[] { "T", "D", "W", "Z", "V", "P" });
            List<string> row2 = new List<string>(new string[] { "L", "S", "W", "V", "F", "J", "D" });
            List<string> row3 = new List<string>(new string[] { "Z", "M", "L", "S", "V", "T", "B", "H" });
            List<string> row4 = new List<string>(new string[] { "R", "S", "J" });
            List<string> row5 = new List<string>(new string[] { "C", "Z", "B", "G", "F", "M", "L", "W" });
            List<string> row6 = new List<string>(new string[] { "Q", "W", "V", "H", "Z", "R", "G", "B" });
            List<string> row7 = new List<string>(new string[] { "V", "J", "P", "C", "B", "D", "N" });
            List<string> row8 = new List<string>(new string[] { "P", "T", "B", "Q" });
            List<string> row9 = new List<string>(new string[] { "H", "G", "Z", "R", "C" });
            List<string> list = File.ReadAllLines("2022_5a.txt").ToList();


            foreach (string action in list)
            {
                List<string> boxes = new List<string>();
                string[] move = action.Split(' ');

                int count = int.Parse(move[1]);
                int from = int.Parse(move[3]);
                int to = int.Parse(move[5]);


                switch (from)
                {
                    case 1:
                        int c1 = row1.Count;

                        for (int i1 = c1 - count; i1 < c1; i1++)
                        {
                            boxes.Add(row1[i1]);
                        }
                        for (int i1 = c1; i1 > c1 - count; i1--)
                        {
                            row1.RemoveAt(i1 - 1);
                        }
                        break;

                    case 2:
                        int c2 = row2.Count;

                        for (int i2 = c2 - count; i2 < c2; i2++)
                        {
                            boxes.Add(row2[i2]);
                        }
                        for (int i2 = c2; i2 > c2 - count; i2--)
                        {
                            row2.RemoveAt(i2 - 1);
                        }
                        break;
                    case 3:
                        int c3 = row3.Count;

                        for (int i3 = c3 - count; i3 < c3; i3++)
                        {
                            boxes.Add(row3[i3]);
                        }
                        for (int i3 = c3; i3 > c3 - count; i3--)
                        {
                            row3.RemoveAt(i3 - 1);
                        }
                        break;
                    case 4:
                        int c4 = row4.Count;

                        for (int i4 = c4 - count; i4 < c4; i4++)
                        {
                            boxes.Add(row4[i4]);
                        }
                        for (int i4 = c4; i4 > c4 - count; i4--)
                        {
                            row4.RemoveAt(i4 - 1);
                        }
                        break;
                    case 5:
                        int c5 = row5.Count;

                        for (int i5 = c5 - count; i5 < c5; i5++)
                        {
                            boxes.Add(row5[i5]);
                        }
                        for (int i5 = c5; i5 > c5 - count; i5--)
                        {
                            row5.RemoveAt(i5 - 1);
                        }
                        break;
                    case 6:
                        int c6 = row6.Count;

                        for (int i6 = c6 - count; i6 < c6; i6++)
                        {
                            boxes.Add(row6[i6]);
                        }
                        for (int i6 = c6; i6 > c6 - count; i6--)
                        {
                            row6.RemoveAt(i6 - 1);
                        }
                        break;
                    case 7:
                        int c7 = row7.Count;

                        for (int i7 = c7 - count; i7 < c7; i7++)
                        {
                            boxes.Add(row7[i7]);
                        }
                        for (int i7 = c7; i7 > c7 - count; i7--)
                        {
                            row7.RemoveAt(i7 - 1);
                        }
                        break;
                    case 8:
                        int c8 = row8.Count;

                        for (int i8 = c8 - count; i8 < c8; i8++)
                        {
                            boxes.Add(row8[i8]);
                        }
                        for (int i8 = c8; i8 > c8 - count; i8--)
                        {
                            row8.RemoveAt(i8 - 1);
                        }
                        break;
                    case 9:
                        int c9 = row9.Count;

                        for (int i9 = c9 - count; i9 < c9; i9++)
                        {
                            boxes.Add(row9[i9]);

                        }
                        for (int i9 = c9; i9 > c9 - count; i9--)
                        {
                            row9.RemoveAt(i9 - 1);
                        }
                        break;

                }

                switch (to)
                {
                    case 1:

                        foreach (string b in boxes)
                        {
                            row1.Add(b);
                        }
                        break;
                    case 2:

                        foreach (string b in boxes)
                        {
                            row2.Add(b);
                        }
                        break;
                    case 3:

                        foreach (string b in boxes)
                        {
                            row3.Add(b);
                        }
                        break;
                    case 4:
                        foreach (string b in boxes)
                        {
                            row4.Add(b);
                        }
                        break;
                    case 5:
                        foreach (string b in boxes)
                        {
                            row5.Add(b);
                        }
                        break;
                    case 6:
                        foreach (string b in boxes)
                        {
                            row6.Add(b);
                        }
                        break;
                    case 7:
                        foreach (string b in boxes)
                        {
                            row7.Add(b);
                        }
                        break;
                    case 8:
                        foreach (string b in boxes)
                        {
                            row8.Add(b);
                        }
                        break;
                    case 9:
                        foreach (string b in boxes)
                        {
                            row9.Add(b);
                        }
                        break;
                }
                boxes.Clear();

            }

            MessageBox.Show("the code= " + row1[row1.Count - 1] + row2[row2.Count - 1] + row3[row3.Count - 1] + row4[row4.Count - 1] + row5[row5.Count - 1] + row6[row6.Count - 1] + row7[row7.Count - 1] + row8[row8.Count - 1] + row9[row9.Count - 1]);
        }

    }
}
