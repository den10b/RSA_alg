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
    public partial class FormRecipient : Form
    {
        public FormRecipient()
        {
            InitializeComponent();
        }

        private ulong pr1 = 1;
        private ulong pr2 = 1;
        private ulong n;
        uint state0 = 1;
        uint state1 = 2;

        //Значения ключей алгоритма
        private ulong p; // Параметр открытого ключа
        private ulong g; // Параметр открытого ключа
        private ulong y; // Параметр открытого ключа
        private ulong x; // Параметр закрытого ключа

        uint rand()
        {
            uint s1 = state0;
            uint s0 = state1;
            state0 = s0;
            s1 ^= s1 << 23;
            s1 ^= s1 >> 17;
            s1 ^= s0;
            s1 ^= s0 >> 26;
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


        ulong power(ulong a, ulong b, ulong n) // a^b mod n - возведение a в степень b по модулю n
        {
            ulong tmp = a;
            ulong sum = tmp;
            for (ulong i = 1; i < b; i++)
            {
                for (ulong j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

        ulong mul(ulong a, ulong b, ulong n) // a*b mod n - умножение a на b по модулю n
        {
            ulong sum = 0;
            for (ulong i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }





        private void buttonPrimeGenerate_Click_1(object sender, EventArgs e)
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
            this.n = tpr1 * tpr2;

            labelOpenKeyPValue.Text = pr2.ToString();

        }

        private void buttonPublicKeyGenrated_Click_1(object sender, EventArgs e)
        {
            if (labelOpenKeyPValue.Text == "")
            {
                MessageBox.Show("Сначала сгенерируйте простое число P", "Error");
            }
            else
            {
                p = ulong.Parse(labelOpenKeyPValue.Text);
                g = p / 2 - (rand() % 6);
                x = p / (rand() % 10 + 1);
                y = power(g, x, p);
                if (x == 1 || x == 0)
                {
                    x += (rand() % 10) + 1;
                }
                else if (x == p)
                {
                    x -= 1;
                }
                if (g == 0) g++;
                if (y == 0) y++;
                labelXValue.Text = x.ToString();

                labelOpenKeyGValue.Text = g.ToString();
                labelOpenKeyYValue.Text = y.ToString();


            }

        }

        private void buttonSendOpenKey_Click_1(object sender, EventArgs e)
        {
            if (labelOpenKeyPValue.Text != "label2")
            {
                Program.FMain.labelOpenKeyPValue.Text = p.ToString();
                Program.FMain.labelOpenKeyGValue.Text = g.ToString();
                Program.FMain.labelOpenKeyYValue.Text = y.ToString();
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте открытый ключ", "Error");
            }

        }

        private void buttonRetrieve_Click_1(object sender, EventArgs e)
        {
            richTextDataRecipient.Text = Program.FMain.richTextData.Text;
            Program.FMain.richTextData.Text = "";
        }

        private void buttonMessageDecrypt_Click_1(object sender, EventArgs e)
        {
            ulong p = ulong.Parse(labelOpenKeyPValue.Text);
            ulong x = ulong.Parse(labelXValue.Text);

            int flag = 0;


            if (richTextDataRecipient.Text != "")
            {
                string[] strA = richTextDataRecipient.Text.Split(' ');
                
                richTextDataRecipient.Text = "";
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        ulong ai = 0;
                        ulong bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            // ai * 10, 710
                            ai = ai * 10 + (ulong)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (ulong)(b[j] - 48);

                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            ulong deM = mul(bi, power(ai, p - 1 - x, p), p);
                            MessageBox.Show($"ai = {ai}");
                            MessageBox.Show($"deM = {deM}");
                            char m = (char)deM;

                            richTextDataRecipient.Text = richTextDataRecipient.Text + m;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не зашифровали текст", "Error");
            }

        }
    }
}
