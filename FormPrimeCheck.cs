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
            int num_check = 0;
            if (checkBoxDivisTest.Checked)
            {
                num_check = Int32.Parse(comboBoxNumberCheck.Text);
                if (Trial_Division(num_check))
                {
                    richTextBoxResult.Text = $"Число {num_check} является простым";
                }
                else
                {
                    richTextBoxResult.Text = $"Число {num_check} является составным\nПервый делитель {Index_Trial_Division(num_check)}";
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
