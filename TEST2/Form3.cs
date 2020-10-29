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
    public partial class Form3 : Form
    {
        int check_number=0,sign_index;
        Char[] signs = new char [4];
        int ans_num,correct_num;
        int x, y, ans;
        int low, high;
        bool flag = false;
        Random rnd = new Random();

        private void low_line_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(high_line.Value) <= Convert.ToInt32(low_line.Value))
                high_line.Value = Convert.ToInt32(low_line.Value) + 1;
        }

        private void high_line_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(high_line.Value) <= Convert.ToInt32(low_line.Value))
                low_line.Value = Convert.ToInt32(high_line.Value) - 1;
        }

        private void nextproblem_Click_1(object sender, EventArgs e)
        {
            content_message.Text = "";
            if (anstextBox.Text == "")
            {
                content_message.Text = "答案不能为空!";
                return;
            }
            if (ans.ToString() == anstextBox.Text)
            {
                correct_num++;
            }
            ans_num++;
            content_message.Text = "";
            contentlabel1.Text = string.Format("已答数目：{0:D}", ans_num);
            anstextBox.Clear();
            anstextBox.Focus();
            new_problem();
        }

        private void anstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            content_message.Text = "";
            if ((int)e.KeyChar == 13)
            {
                nextproblem_Click_1(sender, e);
            }
        }


        public Form3()
        {
            InitializeComponent();
        }
        private void new_problem()
        {
            x = rnd.Next(low, high);
            y = rnd.Next(low, high);
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
        private void rate_of_correct()
        {
            //(ans_num == 0) ? ans_num : 2;
            if(ans_num == 0)
            {
                correct_num = 0;
                ans_num = 1;
            }
            contentlabel2.Text = string.Format("正确率：{0:P1}",((float)correct_num)/((float)ans_num));
            formula.Text = "";
            s1.Enabled = true;
            s2.Enabled = true;
            s3.Enabled = true;
            s4.Enabled = true;
            low_line.Enabled = true;
            high_line.Enabled = true;
            anstextBox.Enabled = false;
            nextproblem.Enabled = false;
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            if(flag == true )
            {
                flag = false;
                rate_of_correct();
                return;
            }
            if(!s1.Checked && !s2.Checked && !s3.Checked && !s4.Checked)
            {
                content_message.Text = "还未进行答题范围的选择";
                return;
            }
            flag = true;
            contentlabel1.Text = "已答数目：";
            contentlabel2.Text = "正确率：";
            sign_index = 0;
            check_number = 0;
            ans_num = 0;

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
            s1.Enabled = false;
            s2.Enabled = false;
            s3.Enabled = false;
            s4.Enabled = false;
            low_line.Enabled = false;
            high_line.Enabled = false;
            low = Convert.ToInt32(low_line.Value);
            high = Convert.ToInt32(high_line.Value);
            anstextBox.Enabled = true;
            nextproblem.Enabled = true;
            anstextBox.Focus();
            ans_num = 0;
            correct_num = 0;
            check_number = 0;
            low_line.Enabled = false;
            high_line.Enabled = false;
            low = Convert.ToInt32(low_line.Value);
            high = Convert.ToInt32(high_line.Value);
            anstextBox.Enabled = true;
            nextproblem.Enabled = true;
            new_problem();
        }
    }
}
