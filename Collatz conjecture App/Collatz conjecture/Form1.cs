using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collatz_conjecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Processing(object sender, EventArgs e)
        {
            int inputValue = Convert.ToInt32(Input.Text);
            int counterTimes = 0;
            while(inputValue != 1)
            {
                if(inputValue % 2 == 0)
                {
                    inputValue = inputValue / 2;
                    counterTimes++;
                }
                else
                {
                    inputValue = (inputValue * 3) + 1;
                    counterTimes++;
                }
            }

            output.Text = Convert.ToString(counterTimes);
        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
