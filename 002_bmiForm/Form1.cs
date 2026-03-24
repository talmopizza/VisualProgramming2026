using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // button1을 클릭했을 때 실행되는 이벤트 처리
        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);

            h /= 100; // m 단위 환산
            double bmi = w / (h * h);

            // .ToString()은 문자열로 바꾸어 준다 *항상 바꿔주기
            //lblBMI.Text = "BMI = " + bmi.ToString();
            // 컨트롤.속성
            lblBMI.Text = string.Format("{0:F1}", bmi); // {0:F1} 뒤에 나오는 n번째 변수:소수점 첫째자리까지 표시
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
