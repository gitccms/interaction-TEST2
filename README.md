# 实验二 桌面应用程序的创建

---

## 一、 实验目的和要求

1、掌握桌面应用程序的创建

2、利用一种设计工具完成图形化的用户界面设计

## 二、 实验内容与步骤
        （一）实验内
                利用常用的设计工具完成通用图形用户界面设计，要遵循界面设计的一般原则（一致性、快捷方式、提供错误处理）
                学会使用图标、按钮、屏幕布局、菜单和对话框的设计。

        （二） 实验步骤
                1、编写一个Windows 程序，实现自动出题并判分的功能。功能要求：
                （1）能随机出题（例如，加、减、乘、除）
                通过复选框让用户选择要测试的范围，即加、减、乘、除中哪几个，然后将选择的运算符号存入signs[]，每次出题的时候随机产生两个数字和一个符号

``` c#
        private void new_problem(){        
            x = rnd.Next(low, high);            
            y = rnd.Next(low, high);            
            sign_index = rnd.Next(0, check_number);            
            formula.Text = string.Format("{0:D} {1:C} {2:d} =", x, signs[sign_index], y);            
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
  ```

        （2）能进行答案的判断
```c#
        private void nextproblem_Click_1(object sender, EventArgs e){
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
```        
                

        （3）使用 Timer 控件，显示时间或设置练习时长
```c#
        private void timer1_Tick(object sender, EventArgs e){
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
```                

        （4）其他扩充功能（选做），如难题的判断，得分的计算等等。
        运行截图:












 




















