using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String pw = txtPW.Text;

            if (id == "abcd" && pw == "1234") {
                lblLogin.Text = "로그인 성공";
            } else {
                lblLogin.Text = "로그인 실패";
            }
        }


        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            // 문자를 가릴때 이용
        }
    }
}
