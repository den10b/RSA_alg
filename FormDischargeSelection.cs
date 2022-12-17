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
            Program.FMain.richTextData.Text = "Test";
            Close();
            
        }
    }
}
