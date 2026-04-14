using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Clock {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("아날로그 시계는 만들지 않았습니다.", "경고");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Enabled = true;
            timer1.Interval = 10; // 1000ms = 1s
            timer1.Tick += Timer1_Tick;

            lblDate.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
            lblDate.ForeColor = Color.DarkOrange;
            lblTime.Font = new Font("맑은 고딕", 32, FontStyle.Bold|FontStyle.Italic);
            lblTime.ForeColor = Color.DarkBlue;
        }

        // 컴퓨터에서 x축은 왼쪽에서 오른쪽으로 y축은 위쪽에서 아래쪽으로 증가 | 레이블의 기준은 왼쪽위
        private void Timer1_Tick(object sender, EventArgs e) { 

            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
            lblTime.Text = DateTime.Now.ToString("tt h:mm:ss.fff");
            // 가운데 정렬 클라이언트 전체 width에서 나누기 2 - 레이블 width 나누기 2 높이도 똑같이
            // +-30을 안해주면 서로 겹쳐서 보이지 않음
            lblDate.Location = new Point(ClientSize.Width / 2 - lblDate.Width / 2,
                ClientSize.Height / 2 - lblDate.Height / 2 - 30);
            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2,
                ClientSize.Height / 2 - lblTime.Height / 2 + 30);
        }

        private void stopGoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (timer1.Enabled == true) {
                timer1.Enabled = false;
            } else {
                timer1.Enabled = true;
            }
        }
    }
}
