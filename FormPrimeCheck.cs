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
    public partial class FormPrimeCheck : Form
    {
  
        public FormPrimeCheck()
        {
            InitializeComponent();
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            int num_check = Int32.Parse(comboBoxNumberCheck.Text);
            if (checkBoxDivisTest.Checked)
            {
                if (Trial_Division(num_check))
                {
                    richTextBoxResult.Text = $"Число {num_check} является простым";
                }
                else
                {
                    richTextBoxResult.Text = $"Число {num_check} является составным\nПервый делитель {Index_Trial_Division(num_check)}";
                }
                
            }
            else if (checkBoxAKS.Checked)
            {
                if (num_check <= 100)
                {
                    if (Trila_AKS(num_check))
                    {
                        richTextBoxResult.Text = $"Число {num_check} является простым";
                    }
                    else
                    {
                        richTextBoxResult.Text = $"Число {num_check} является составным";
                    }
                }
                else
                {
                    MessageBox.Show("Введите число, меньше 100", "Error");
                }
                

            }
        }

        private bool Trial_Division(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        private int Index_Trial_Division(int n)
        {
            if (n <= 1) return 1;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return i;
            return 0;
        }

        //AKS
        static long[] c = new long[100];

        //Сoefficient calculation
        static void coef(int n)
        {
            c[0] = 1;

            for (int i = 0; i < n; c[0] = -c[0], i++)
            {
                c[1 + i] = 1;

                for (int j = i; j > 0; j--)
                    c[j] = c[j - 1] - c[j];
            }
        }

        static bool Trila_AKS(int n)
        {

            coef(n);

            c[0]++;
            c[n]--;

            int i = n;
            while ((i--) > 0 && c[i] % n == 0) ;

            return i < 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
