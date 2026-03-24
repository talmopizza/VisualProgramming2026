using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_tempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void F_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtC.Text);
            double f = (c * 1.8) + 32; // c * 9.0 / 5 + 32
            
            txtF.Text = f.ToString("F1"); // F1은 소숫점 및 한자리까지 표시한다
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            double f = double.Parse(txtF.Text);
            double c = (f - 32) / 1.8; // (f - 32) * 5 / 9.0

            txtC.Text = c.ToString("F1");
        }
    }
}
