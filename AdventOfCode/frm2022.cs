using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode
{
    public partial class frm2022 : Form
    {

        public frm2022()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Day01.Day1A();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Day02.Day2A();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Day02.Day2B();
        }

        private void button4_Click(object sender, EventArgs e) // 3A
        {
            Day03.Day3A();
        }
        private void button5_Click(object sender, EventArgs e) //3B
        {
            Day03.Day3B();
        }
        private void button6_Click(object sender, EventArgs e)  //day 4
        {
            Day04.Day4A();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Day04.Day4B();
        }

        private void bt4A_Click(object sender, EventArgs e)
        {
            Day05.Day5A();
        }

        private void bt4b_Click(object sender, EventArgs e)
        {
           Day05.Day5B();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Day06.Day6A();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Day06.Day6B();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Day07.Day7A();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Day07.Day7B();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Day08.Day8A();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Day08.Day8B();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Day09.Day9A();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Day09.Day9B();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Day10.Day10A();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Day10.Day10B();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Day11.Day11A();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Day11.Day11B();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Day12.Day12A();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Day12.Day12B();
        }
    }
}
