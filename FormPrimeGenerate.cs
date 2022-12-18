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
    public partial class FormPrimeGenerate : Form
    {
        public FormPrimeGenerate()
        {
            InitializeComponent();
        }
        private ulong pr1 = 1;
        private ulong pr2 = 1;
        uint state0 = 1;
        uint state1 = 2;
        uint rand()
        {
            uint s1 = state0;
            uint s0 = state1;
            state0 = s0;
            s1 ^= s1 << 21;
            s1 ^= s1 >> 19;
            s1 ^= s0;
            s1 ^= s0 >> 24;
            state1 = s1;
            return (state0 + state1) % 11;
        }

        private ulong pow(ulong n, int s)
        {
            ulong result = 1;
            for (int i = 0; i < s; i++)
                result = result * n;
            return result;
        }
        private void buttonPrimeGenerate_Click(object sender, EventArgs e)
        {
            ulong min = pow((ulong)(rand()), Convert.ToInt32(rand() % 9));
            ulong tpr1 = 1;
            ulong tpr2 = 1;
            for (ulong i = min; ; i++)
            {
                int check1 = -1;
                if ((i % 2) == 0)
                    continue;
                for (ulong j = 3; j < i / 2; j += 2)
                {
                    if (i % j == 0)
                    {
                        check1 = 1;
                        break;
                    }
                }
                if (check1 == -1)
                {
                    if ((tpr1 == 1) && (rand() > 8))
                    {
                        tpr1 = i;
                    }
                    else if ((tpr1 != 1) && (rand() > 9))
                    {
                        tpr2 = i;
                    }
                }
                if ((tpr1 != 1) && (tpr2 != 1))
                {
                    break;
                }
            }
            this.pr1 = tpr1;
            this.pr2 = tpr2;

            labelPValue.Text = pr1.ToString();
            labelP2Value.Text = pr2.ToString();
        }

        private void buttonPrimeCheck_Click(object sender, EventArgs e)
        {
            FormPrimeCheck FormPrimeCheck = new FormPrimeCheck();
            FormPrimeCheck.comboBoxNumberCheck.Items.Add(labelPValue.Text);
            FormPrimeCheck.comboBoxNumberCheck.Items.Add(labelP2Value.Text);
            FormPrimeCheck.Show();
        }
    }
}
