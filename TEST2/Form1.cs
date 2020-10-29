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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void start1_Click(object sender, EventArgs e)
        {
            String mes= "";
            int choice = 0;
            if(!numTest.Checked && !timeTest.Checked)
            {
                mes = "你尚未进行任何选择";
            }
            else
            {
                if(timeTest.Checked)
                {
                    mes += "测试答题正确率！";
                    choice = 2;
                }
                else
                {
                    mes += "测试答题速度！";
                    choice = 1;
                }
                DialogResult dr =MessageBox.Show(mes, "你选择的答题模式是：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr != DialogResult.OK)
                {
                    return;
                }
            }
            switch (choice)
            {
                case 1:
                    Form2 frm2 = new Form2();
                    //this.Hide();
                    frm2.Show();
                    break;
                case 2:
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    break;
            }
            //this.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == 13)
            {
                start1_Click(sender, e);
            }
        }

        private void start1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                start1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
            //tim
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            date_time.Text = dt.ToString();
        }
    }
}
