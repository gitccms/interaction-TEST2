namespace TEST2
{
    partial class Form3
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.startbutton = new System.Windows.Forms.Button();
            this.contentlabel1 = new System.Windows.Forms.Label();
            this.contentlabel2 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.contentlabel3 = new System.Windows.Forms.Label();
            this.low_line = new System.Windows.Forms.NumericUpDown();
            this.high_line = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s4 = new System.Windows.Forms.CheckBox();
            this.s3 = new System.Windows.Forms.CheckBox();
            this.s2 = new System.Windows.Forms.CheckBox();
            this.s1 = new System.Windows.Forms.CheckBox();
            this.anstextBox = new System.Windows.Forms.TextBox();
            this.nextproblem = new System.Windows.Forms.Button();
            this.content_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.low_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_line)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 321);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(920, 275);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // startbutton
            // 
            this.startbutton.AutoEllipsis = true;
            this.startbutton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.startbutton.ForeColor = System.Drawing.Color.Red;
            this.startbutton.Location = new System.Drawing.Point(720, 173);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(188, 90);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "开始/结束";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // contentlabel1
            // 
            this.contentlabel1.AutoSize = true;
            this.contentlabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.contentlabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.contentlabel1.Location = new System.Drawing.Point(34, 139);
            this.contentlabel1.Name = "contentlabel1";
            this.contentlabel1.Size = new System.Drawing.Size(140, 33);
            this.contentlabel1.TabIndex = 2;
            this.contentlabel1.Text = "已答数目：";
            // 
            // contentlabel2
            // 
            this.contentlabel2.AutoSize = true;
            this.contentlabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.contentlabel2.ForeColor = System.Drawing.Color.Goldenrod;
            this.contentlabel2.Location = new System.Drawing.Point(34, 230);
            this.contentlabel2.Name = "contentlabel2";
            this.contentlabel2.Size = new System.Drawing.Size(115, 33);
            this.contentlabel2.TabIndex = 3;
            this.contentlabel2.Text = "正确率：";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formula.Location = new System.Drawing.Point(25, 459);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(0, 50);
            this.formula.TabIndex = 4;
            // 
            // contentlabel3
            // 
            this.contentlabel3.AutoSize = true;
            this.contentlabel3.Font = new System.Drawing.Font("长城宋体", 18F, System.Drawing.FontStyle.Bold);
            this.contentlabel3.Location = new System.Drawing.Point(12, 26);
            this.contentlabel3.Name = "contentlabel3";
            this.contentlabel3.Size = new System.Drawing.Size(137, 30);
            this.contentlabel3.TabIndex = 5;
            this.contentlabel3.Text = "出题范围";
            // 
            // low_line
            // 
            this.low_line.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.low_line.Location = new System.Drawing.Point(163, 22);
            this.low_line.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.low_line.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.low_line.Name = "low_line";
            this.low_line.Size = new System.Drawing.Size(152, 42);
            this.low_line.TabIndex = 6;
            this.low_line.Value = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.low_line.ValueChanged += new System.EventHandler(this.low_line_ValueChanged);
            // 
            // high_line
            // 
            this.high_line.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.high_line.Location = new System.Drawing.Point(393, 21);
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
            this.high_line.Size = new System.Drawing.Size(142, 42);
            this.high_line.TabIndex = 7;
            this.high_line.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.high_line.ValueChanged += new System.EventHandler(this.high_line_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(321, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("长城宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(560, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "运算范围";
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.s4.Location = new System.Drawing.Point(831, 71);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(64, 32);
            this.s4.TabIndex = 25;
            this.s4.Text = "➗";
            this.s4.UseVisualStyleBackColor = true;
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s3.Location = new System.Drawing.Point(728, 71);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(64, 32);
            this.s3.TabIndex = 24;
            this.s3.Text = "✖";
            this.s3.UseVisualStyleBackColor = true;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.s2.Location = new System.Drawing.Point(831, 25);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(64, 32);
            this.s2.TabIndex = 23;
            this.s2.Text = "➖";
            this.s2.UseVisualStyleBackColor = true;
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Checked = true;
            this.s1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.s1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.s1.Location = new System.Drawing.Point(728, 26);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(64, 32);
            this.s1.TabIndex = 22;
            this.s1.Text = "➕";
            this.s1.UseVisualStyleBackColor = true;
            // 
            // anstextBox
            // 
            this.anstextBox.Enabled = false;
            this.anstextBox.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anstextBox.Location = new System.Drawing.Point(456, 459);
            this.anstextBox.Name = "anstextBox";
            this.anstextBox.Size = new System.Drawing.Size(241, 50);
            this.anstextBox.TabIndex = 27;
            this.anstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anstextBox_KeyPress);
            // 
            // nextproblem
            // 
            this.nextproblem.Enabled = false;
            this.nextproblem.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextproblem.ForeColor = System.Drawing.Color.Navy;
            this.nextproblem.Location = new System.Drawing.Point(720, 435);
            this.nextproblem.Name = "nextproblem";
            this.nextproblem.Size = new System.Drawing.Size(188, 90);
            this.nextproblem.TabIndex = 26;
            this.nextproblem.Text = "下一题";
            this.nextproblem.UseVisualStyleBackColor = true;
            this.nextproblem.Click += new System.EventHandler(this.nextproblem_Click_1);
            // 
            // content_message
            // 
            this.content_message.AutoSize = true;
            this.content_message.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content_message.ForeColor = System.Drawing.Color.Red;
            this.content_message.Location = new System.Drawing.Point(417, 341);
            this.content_message.Name = "content_message";
            this.content_message.Size = new System.Drawing.Size(0, 28);
            this.content_message.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 596);
            this.Controls.Add(this.content_message);
            this.Controls.Add(this.anstextBox);
            this.Controls.Add(this.nextproblem);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.high_line);
            this.Controls.Add(this.low_line);
            this.Controls.Add(this.contentlabel3);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.contentlabel2);
            this.Controls.Add(this.contentlabel1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.splitter1);
            this.Name = "Form3";
            this.Text = "测试正确率";
            ((System.ComponentModel.ISupportInitialize)(this.low_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label contentlabel1;
        private System.Windows.Forms.Label contentlabel2;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.Label contentlabel3;
        private System.Windows.Forms.NumericUpDown low_line;
        private System.Windows.Forms.NumericUpDown high_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox s4;
        private System.Windows.Forms.CheckBox s3;
        private System.Windows.Forms.CheckBox s2;
        private System.Windows.Forms.CheckBox s1;
        private System.Windows.Forms.TextBox anstextBox;
        private System.Windows.Forms.Button nextproblem;
        private System.Windows.Forms.Label content_message;
    }
}