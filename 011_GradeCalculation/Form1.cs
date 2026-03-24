using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_GradeCalculation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double sum = Convert.ToDouble(txtKor.Text) // == double.Parse(txtKor.Text) <== 시험문제
                + Convert.ToDouble(txtMath.Text)
                + Convert.ToDouble(txtEng.Text);

            double avg = sum / 3;

            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString("0.0"); // == "F1"
        }
    }
}
