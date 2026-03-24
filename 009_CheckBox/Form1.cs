using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checkbox는 주로 배열을 사용한다
            //foreach C/C#에서 많이 쓰이는 반복문

            string checkStates = "";
            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            foreach (var item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n"
                    , item.Text, item.Checked);
            }
            MessageBox.Show(checkStates, "checkStates");
            string summary = string.Format("좋아하는 과일은 : ");
            foreach (var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + " ";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
