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
    public partial class FormSecretKey : Form
    {
        public FormSecretKey()
        {
            InitializeComponent();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void labelNumberGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
