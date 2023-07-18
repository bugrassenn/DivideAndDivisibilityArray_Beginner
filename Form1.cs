using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideAndDivisibilityArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = {1, 4, 8, 16, 19, 22, 26, 32, 41, 56};

            // number % 4 == 0 
            // number % 4 == 0 lenght and totals

            foreach (int number in numbers)
            {
                if ( number %4 == 0 )
                {
                    listBox1.Items.Add(number);
                    total += number;
                    counter++;

                }
            }
            TxtTotal.Text = total.ToString();
            TxtPiece.Text = counter.ToString();
        }
    }
}
