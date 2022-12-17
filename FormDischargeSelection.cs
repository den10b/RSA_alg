using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elgamal_encryption
{
    public partial class FormDischargeSelection : Form
    {
        public FormDischargeSelection()
        {
            InitializeComponent();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStartGenerating_Click(object sender, EventArgs e)
        {
            Close();
            if (radioButton1.Checked)
            {
                isPrime(GenerateNumbers(10,2,9,7));
            }
            else if (radioButton2.Checked){
                Program.FMain.richTextData.Text = "2Button";
            }
            else if (radioButton3.Checked)
            {
                Program.FMain.richTextData.Text = "3Button";
            }
            else if (radioButton4.Checked)
            {
                Program.FMain.richTextData.Text = "4Button";
            }
            else if (radioButton5.Checked)
            {
                Program.FMain.richTextData.Text = "5Button";
            }
        }

        unsafe static int Random()
        {
            int x;
            int* ptr = &x;
            int lastNumber = (int)ptr % 10;
            return lastNumber < 0 ? -lastNumber : lastNumber;
        }

        static long[] GenerateNumbers(long m, long a, long c, long x)
        {
            int randomValue = Random() % 4;

            long[] numbers = new long[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = x = (a * x + c) % m;
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }

            return numbers;
        }

        static void isPrime(long[] array)
        {
            int j, p;
            for (int i = 0; i < array.Length; i++)
            {
                j = 2;
                p = 1;
                while (j * j < array[i])
                {
                    if (array[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    Program.FMain.richTextData.Text = array[i].ToString();
                }
            }
        }
    }
}
