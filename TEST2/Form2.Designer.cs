namespace TEST2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headlabel = new System.Windows.Forms.Label();
            this.contentlabel1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.contentlabel2 = new System.Windows.Forms.Label();
            this.restTime = new System.Windows.Forms.Label();
            this.nextproblem = new System.Windows.Forms.Button();
            this.anstextBox = new System.Windows.Forms.TextBox();
            this.problem = new System.Windows.Forms.Label();
            this.contentlabel3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formula = new System.Windows.Forms.Label();
            this.ending2 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.CheckBox();
            this.s2 = new System.Windows.Forms.CheckBox();
            this.s3 = new System.Windows.Forms.CheckBox();
            this.s4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totaltimetextBox = new System.Windows.Forms.NumericUpDown();
            this.contentlabel5 = new System.Windows.Forms.Label();
            this.low_line = new System.Windows.Forms.NumericUpDown();
            this.high_line = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.totaltimetextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_line)).BeginInit();
            this.SuspendLayout();
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headlabel.Location = new System.Drawing.Point(13, 162);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(153, 30);
            this.headlabel.TabIndex = 0;
            this.headlabel.Text = "答题时间:";
            // 
            // contentlabel1
            // 
            this.contentlabel1.AutoSize = true;
            this.contentlabel1.Font = new System.Drawing.Font("长城宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentlabel1.ForeColor = System.Drawing.Color.Red;
            this.contentlabel1.Location = new System.Drawing.Point(282, 152);
            this.contentlabel1.Name = "contentlabel1";
            this.contentlabel1.Size = new System.Drawing.Size(58, 40);
            this.contentlabel1.TabIndex = 2;
            this.contentlabel1.Text = "秒";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.Red;
            this.start.Location = new System.Drawing.Point(724, 141);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(177, 69);
            this.start.TabIndex = 3;
            this.start.Text = "开始答题";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // contentlabel2
            // 
            this.contentlabel2.AutoSize = true;
            this.contentlabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentlabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.contentlabel2.Location = new System.Drawing.Point(62, 256);
            this.contentlabel2.Name = "contentlabel2";
            this.contentlabel2.Size = new System.Drawing.Size(140, 33);
            this.contentlabel2.TabIndex = 4;
            this.contentlabel2.Text = "已答数目：";
            // 
            // restTime
            // 
            this.restTime.AutoSize = true;
            this.restTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.restTime.ForeColor = System.Drawing.Color.Coral;
            this.restTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restTime.Location = new System.Drawing.Point(541, 256);
            this.restTime.Name = "restTime";
            this.restTime.Size = new System.Drawing.Size(172, 33);
            this.restTime.TabIndex = 6;
            this.restTime.Text = "剩余时间： 秒";
            this.restTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextproblem
            // 
            this.nextproblem.Enabled = false;
            this.nextproblem.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextproblem.ForeColor = System.Drawing.Color.Navy;
            this.nextproblem.Location = new System.Drawing.Point(809, 351);
            this.nextproblem.Name = "nextproblem";
            this.nextproblem.Size = new System.Drawing.Size(92, 133);
            this.nextproblem.TabIndex = 8;
            this.nextproblem.Text = "下一题";
            this.nextproblem.UseVisualStyleBackColor = true;
            this.nextproblem.Click += new System.EventHandler(this.nextproblem_Click);
            // 
            // anstextBox
            // 
            this.anstextBox.Enabled = false;
            this.anstextBox.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anstextBox.Location = new System.Drawing.Point(547, 397);
            this.anstextBox.Name = "anstextBox";
            this.anstextBox.Size = new System.Drawing.Size(200, 50);
            this.anstextBox.TabIndex = 9;
            this.anstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anstextBox_KeyPress);
            // 
            // problem
            // 
            this.problem.AutoSize = true;
            this.problem.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold);
            this.problem.Location = new System.Drawing.Point(61, 278);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(0, 38);
            this.problem.TabIndex = 10;
            // 
            // contentlabel3
            // 
            this.contentlabel3.AutoSize = true;
            this.contentlabel3.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentlabel3.ForeColor = System.Drawing.Color.Red;
            this.contentlabel3.Location = new System.Drawing.Point(542, 366);
            this.contentlabel3.Name = "contentlabel3";
            this.contentlabel3.Size = new System.Drawing.Size(0, 28);
            this.contentlabel3.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formula
            // 
            this.formula.AllowDrop = true;
            this.formula.AutoSize = true;
            this.formula.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formula.Location = new System.Drawing.Point(59, 397);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(0, 50);
            this.formula.TabIndex = 13;
            // 
            // ending2
            // 
            this.ending2.AutoSize = true;
            this.ending2.Font = new System.Drawing.Font("长城宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ending2.ForeColor = System.Drawing.Color.Red;
            this.ending2.Location = new System.Drawing.Point(63, 537);
            this.ending2.Name = "ending2";
            this.ending2.Size = new System.Drawing.Size(0, 38);
            this.ending2.TabIndex = 17;
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Checked = true;
            this.s1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.s1.Location = new System.Drawing.Point(724, 12);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(64, 32);
            this.s1.TabIndex = 18;
            this.s1.Text = "➕";
            this.s1.UseVisualStyleBackColor = true;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s2.Location = new System.Drawing.Point(816, 12);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(64, 32);
            this.s2.TabIndex = 19;
            this.s2.Text = "➖";
            this.s2.UseVisualStyleBackColor = true;
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s3.Location = new System.Drawing.Point(724, 66);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(64, 32);
            this.s3.TabIndex = 20;
            this.s3.Text = "✖";
            this.s3.UseVisualStyleBackColor = true;
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.s4.Location = new System.Drawing.Point(816, 66);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(64, 32);
            this.s4.TabIndex = 21;
            this.s4.Text = "➗";
            this.s4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(542, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "运算范围:";
            // 
            // totaltimetextBox
            // 
            this.totaltimetextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totaltimetextBox.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totaltimetextBox.Location = new System.Drawing.Point(156, 156);
            this.totaltimetextBox.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.totaltimetextBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.totaltimetextBox.Name = "totaltimetextBox";
            this.totaltimetextBox.Size = new System.Drawing.Size(120, 42);
            this.totaltimetextBox.TabIndex = 23;
            this.totaltimetextBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // contentlabel5
            // 
            this.contentlabel5.AutoSize = true;
            this.contentlabel5.Font = new System.Drawing.Font("长城宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentlabel5.Location = new System.Drawing.Point(13, 49);
            this.contentlabel5.Name = "contentlabel5";
            this.contentlabel5.Size = new System.Drawing.Size(137, 30);
            this.contentlabel5.TabIndex = 24;
            this.contentlabel5.Text = "出题范围";
            // 
            // low_line
            // 
            this.low_line.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.low_line.Location = new System.Drawing.Point(156, 42);
            this.low_line.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.low_line.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.low_line.Name = "low_line";
            this.low_line.Size = new System.Drawing.Size(152, 42);
            this.low_line.TabIndex = 25;
            this.low_line.Value = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.low_line.ValueChanged += new System.EventHandler(this.low_line_ValueChanged);
            // 
            // high_line
            // 
            this.high_line.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.high_line.Location = new System.Drawing.Point(386, 42);
            this.high_line.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.high_line.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.high_line.Name = "high_line";
            this.high_line.Size = new System.Drawing.Size(132, 42);
            this.high_line.TabIndex = 26;
            this.high_line.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.high_line.ValueChanged += new System.EventHandler(this.high_line_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("长城宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(314, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 70);
            this.label2.TabIndex = 27;
            this.label2.Text = "~";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 292);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(920, 304);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 596);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.high_line);
            this.Controls.Add(this.low_line);
            this.Controls.Add(this.contentlabel5);
            this.Controls.Add(this.totaltimetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.ending2);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.contentlabel3);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.anstextBox);
            this.Controls.Add(this.nextproblem);
            this.Controls.Add(this.restTime);
            this.Controls.Add(this.contentlabel2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.contentlabel1);
            this.Controls.Add(this.headlabel);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "测试答题速度";
            ((System.ComponentModel.ISupportInitialize)(this.totaltimetextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label contentlabel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label contentlabel2;
        private System.Windows.Forms.Label restTime;
        private System.Windows.Forms.Button nextproblem;
        private System.Windows.Forms.TextBox anstextBox;
        private System.Windows.Forms.Label problem;
        private System.Windows.Forms.Label contentlabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.Label ending2;
        private System.Windows.Forms.CheckBox s1;
        private System.Windows.Forms.CheckBox s2;
        private System.Windows.Forms.CheckBox s3;
        private System.Windows.Forms.CheckBox s4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown totaltimetextBox;
        private System.Windows.Forms.Label contentlabel5;
        private System.Windows.Forms.NumericUpDown low_line;
        private System.Windows.Forms.NumericUpDown high_line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
    }
}