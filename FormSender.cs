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
    public partial class FormSender : Form
    {
        FormPrimeCheck FormPrimeCheck = new FormPrimeCheck();
        public FormSender()
        {
            InitializeComponent();
        }

        private ulong pr1 = 1;
        private ulong pr2 = 1;
        private ulong n;
        uint state0 = 1;
        uint state1 = 2;
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
        private void buttonPrimelGenerate_Click(object sender, EventArgs e)
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

            labelPValue.Text = pr1.ToString();
            labelP2Value.Text = pr2.ToString();
            labelNValue.Text = n.ToString();

        }

        
        private void buttonPrimeCheck_Click(object sender, EventArgs e)
        {

            FormPrimeCheck FormPrimeCheck = new FormPrimeCheck();
            FormPrimeCheck.comboBoxNumberCheck.Items.Add(labelPValue.Text);
            FormPrimeCheck.comboBoxNumberCheck.Items.Add(labelP2Value.Text);
            FormPrimeCheck.Show();
        }

        private void FormSender_Load(object sender, EventArgs e)
        {
            FormRecipient formRecipient = new FormRecipient();
            formRecipient.Show();
        }

        private ulong Change_Generate_Num()
        {
            ulong min = pow((ulong)(rand()), Convert.ToInt32(rand() % 9));
            ulong tpr1 = 1;
            ulong tpr2 = 2;
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
            return tpr1;

        }

        public static bool IsCoprime(ulong num1, ulong num2)
        {
            if (num1 == num2)
            {
                return num1 == 1;
            }
            else
            {
                if (num1 > num2)
                {
                    return IsCoprime(num1 - num2, num2);
                }
                else
                {
                    return IsCoprime(num2 - num1, num1);
                }
            }
        }
        private void buttonPrivateKeyGenerate_Click(object sender, EventArgs e)
        {
            ulong p = ulong.Parse(labelOpenKeyPValue.Text);

            ulong k = Change_Generate_Num();
            while (k > p - 1)
            {
                k = Change_Generate_Num();
            }
            while (!IsCoprime(k, p - 1))
            {
                k = Change_Generate_Num() % (p - 1);
            }

            labelKValue.Text = k.ToString();


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

        private void buttonMessageCrypt_Click(object sender, EventArgs e)
        {
            FormRecipient formRecipient = new FormRecipient();
            ulong p = ulong.Parse(labelOpenKeyPValue.Text);
            ulong g = ulong.Parse(labelOpenKeyGValue.Text);
            ulong y = ulong.Parse(labelOpenKeyYValue.Text);
            if (labelKValue.Text != "")
            {
                ulong k = ulong.Parse(labelKValue.Text);
                string text = richTextData.Text;
                if (richTextData.Text != "")
                {
                    richTextData.Text = "";
                    char[] temp = new char[text.Length - 1];
                    temp = text.ToCharArray();
                    for (int i = 0; i <= text.Length - 1; i++)
                    {
                        ulong m = (ulong)temp[i];
                        if (m > 0)
                        {
                            ulong a = power(g, k, p);
                            ulong b = mul(power(y, k, p), m, p);
                            richTextData.Text = richTextData.Text + a + " " + b + " ";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите текст", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Сначала сформируйте закрытый ключ", "Error");
            }
            
        }

        private void buttonSendToRec_Click(object sender, EventArgs e)
        {

            

            /*FormSender form1 = new FormSender(this);
            string bebra = "zxc";
            form1.labelOpenKeyP.Text = "lol";
            form1.richTextData.Text = "lol";*/
            //richTextDataRecipient.Text = "LOLOL";
        }
    }
}
