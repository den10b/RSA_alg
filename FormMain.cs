using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elgamal_encryption;

namespace Elgamal_encryption
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonPrimelGenerate_Click(object sender, EventArgs e)
        {

            FormDischargeSelection FormDischargeSelection = new FormDischargeSelection();
            FormDischargeSelection.Show();
            
        }

        unsafe static int Random()
        {
            int x;
            int* ptr = &x;
            int lastNumber = (int)ptr % 10;
            return lastNumber < 0 ? -lastNumber : lastNumber;
        }

        static long[] GenerateNumbers()
        {
            int randomValue = Random();

            long m = 6075,
                a = 106,
                c = 1283,
                x = 7 * randomValue;

            Console.WriteLine($" m = {m},a = {a}, x = {x} ");

            long[] numbers = new long[30];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = x = (a * x + c) % m;
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }

            Array.Sort(numbers);

            return numbers;
        }

        static void isPrime(long[] array)
        {
            int i, j, p;
            Console.Write("All Prime List:");
            for (i = 0; i < array.Length; i++)
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
                    MessageBox.Show($"{array[i]}", "Test");
                }
            }
        }

    }
}
