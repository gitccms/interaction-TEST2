namespace TEST2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numTest = new System.Windows.Forms.RadioButton();
            this.HeadTitle = new System.Windows.Forms.Label();
            this.timeTest = new System.Windows.Forms.RadioButton();
            this.start1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numTest
            // 
            this.numTest.AutoSize = true;
            this.numTest.Font = new System.Drawing.Font("宋体", 15F);
            this.numTest.Location = new System.Drawing.Point(154, 211);
            this.numTest.Name = "numTest";
            this.numTest.Size = new System.Drawing.Size(183, 29);
            this.numTest.TabIndex = 0;
            this.numTest.TabStop = true;
            this.numTest.Text = "测试答题速度";
            this.numTest.UseVisualStyleBackColor = true;
            // 
            // HeadTitle
            // 
            this.HeadTitle.AutoSize = true;
            this.HeadTitle.Font = new System.Drawing.Font("长城宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadTitle.Location = new System.Drawing.Point(96, 54);
            this.HeadTitle.Name = "HeadTitle";
            this.HeadTitle.Size = new System.Drawing.Size(527, 70);
            this.HeadTitle.TabIndex = 1;
            this.HeadTitle.Text = "请选择答题模式";
            // 
            // timeTest
            // 
            this.timeTest.AutoSize = true;
            this.timeTest.Font = new System.Drawing.Font("宋体", 15F);
            this.timeTest.Location = new System.Drawing.Point(154, 265);
            this.timeTest.Name = "timeTest";
            this.timeTest.Size = new System.Drawing.Size(158, 29);
            this.timeTest.TabIndex = 1;
            this.timeTest.TabStop = true;
            this.timeTest.Text = "测试正确率";
            this.timeTest.UseVisualStyleBackColor = true;
            // 
            // start1
            // 
            this.start1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start1.ForeColor = System.Drawing.Color.Red;
            this.start1.Location = new System.Drawing.Point(503, 189);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(232, 131);
            this.start1.TabIndex = 2;
            this.start1.Text = "进入答题模式";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            this.start1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.start1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date_time
            // 
            this.date_time.AutoSize = true;
            this.date_time.Location = new System.Drawing.Point(571, 423);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(54, 15);
            this.date_time.TabIndex = 4;
            this.date_time.Text = "2020年";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.timeTest);
            this.Controls.Add(this.HeadTitle);
            this.Controls.Add(this.numTest);
            this.Name = "Form1";
            this.Text = "口算练习";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton numTest;
        private System.Windows.Forms.Label HeadTitle;
        private System.Windows.Forms.RadioButton timeTest;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date_time;
    }
}

