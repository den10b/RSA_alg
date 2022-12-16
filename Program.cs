using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elgamal_encryption
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            MessageBox.Show($"{Random()}, Random_Digit ");
            MessageBox.Show($"{GenerateNumbers()}, Generate_Primal_Number ");
        }

        unsafe static int Random()
        {
            int x;
            int* ptr = &x;
            int lastNumber = (int)ptr % 10;
            return lastNumber < 0 ? -lastNumber : lastNumber;
        }

        static int[] GenerateNumbers()
        {
            int m = 6075,
                a = 106,
                c = 1283,
                x = 6075;

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = x = (a * x + c) % m;
            }

            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            return numbers;
        }
    }
}
