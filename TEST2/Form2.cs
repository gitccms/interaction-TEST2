using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST2
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int ans_num = 0;//答题数目，正确数目
        int x, y, ans,p_ans,sign_index = 0,check_number=0;
        int low, high;
        Char[] signs = new char[4];
        
        int total_seconds,rest_seconds = 0;//剩余秒数

        private void low_line_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(high_line.Value) <= Convert.ToInt32(low_line.Value))
                high_line.Value = Convert.ToInt32(low_line.Value)+1;
        }

        private void high_line_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(high_line.Value) <= Convert.ToInt32(low_line.Value))
                    low_line.Value = Convert.ToInt32(high_line.Value) - 1;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void anstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            contentlabel3.Text = "";
            if((int)e.KeyChar == 13)
            {
                nextproblem_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == 13)
            {
                start_Click(sender,e);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            sign_index = 0;
            check_number = 0;
            ans_num = 0;
            if(!s1.Checked && !s2.Checked && !s3.Checked && !s4.Checked)
            {
                MessageBox.Show("还未进行答题范围的选择");
                return;
            }
            if(totaltimetextBox.Text == "")
            {
                MessageBox.Show("请输入合法答题时间!");
                return;
            }
            if (s1.Checked)
            {
                signs[check_number++] = '➕';
            }
            if (s2.Checked)
            {
                signs[check_number++] = '➖';
            }
            if (s3.Checked)
            {
                signs[check_number++] = '✖';
            }
            if (s4.Checked)
            {
                signs[check_number++] = '➗';
            }
            ending2.Text = "";
            start.Enabled = false;
            s1.Enabled = false;
            s2.Enabled = false;
            s3.Enabled = false;
            s4.Enabled = false;
            totaltimetextBox.Enabled = false;
            low_line.Enabled = false;
            high_line.Enabled = false;
            splitter1.SendToBack();
            low = Convert.ToInt32(low_line.Value);
            high = Convert.ToInt32(high_line.Value);
            total_seconds = rest_seconds = Convert.ToInt32(totaltimetextBox.Text);
            anstextBox.Enabled = true;
            nextproblem.Enabled = true;
            anstextBox.Focus();
            timer1.Start();
            new_problem();
        }
        
        public void new_problem()
        {
            x = rnd.Next(low,high);
            y = rnd.Next(low,high);
            sign_index = rnd.Next(0, check_number);
            formula.Text = string.Format("{0:D}  {1:C}  {2:d}  =", x, signs[sign_index], y);
            switch (signs[sign_index])
            {
                case '➕':
                    ans = x + y;
                    break;
                case '➖':
                    ans = x - y;
                    break;
                case '✖':
                    ans = x * y;
                    break;
                case '➗':
                    ans = x / y;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            restTime.Text = string.Format("剩余时间:{0:D}秒", rest_seconds);
            timer1.Interval = 1000;
            if(rest_seconds == 0)
            {
                timer1.Stop();
                nextproblem.Enabled = false;
                anstextBox.Enabled = false;
                if (ans_num == 0)
                {
                    total_seconds = 0;
                    ans_num = 1;
                }
                ending2.Text = string.Format("答题结束，你的速度:{0:N1}秒/题",((float)total_seconds)/((float)ans_num));
                totaltimetextBox.Enabled = true;
                low_line.Enabled = true;
                high_line.Enabled = true;
                s1.Enabled = true;
                s2.Enabled = true;
                s3.Enabled = true;
                s4.Enabled = true;
                start.Enabled = true;
            }
            rest_seconds--;
        }

        private void nextproblem_Click(object sender, EventArgs e)
        {
            contentlabel3.Text="";
            if(anstextBox.Text == "")
            {
                contentlabel3.Text = "答案不能为空!";
                return;
            }
            if(ans.ToString() != anstextBox.Text)
            {
                contentlabel3.Text = "答案错误！";
                anstextBox.Clear();
                return;
            }
            ans_num++;
            contentlabel3.Text = "";
            contentlabel2.Text = string.Format("已答数目：{0:D}", ans_num);
            anstextBox.Clear();
            anstextBox.Focus();
            new_problem();
        }
    }
}
