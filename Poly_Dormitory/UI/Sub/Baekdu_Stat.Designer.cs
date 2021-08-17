namespace Poly_Dormitory
{
    partial class Baekdu_Stat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Build_View = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Now_View = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Student_View = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.AllClear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 637);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(763, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 14);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "시설 고장/수리 현황";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.Build_View);
            this.panel3.Location = new System.Drawing.Point(746, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 550);
            this.panel3.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "시설 삭제";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Build_View
            // 
            this.Build_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader12,
            this.columnHeader16,
            this.columnHeader15});
            this.Build_View.FullRowSelect = true;
            this.Build_View.HideSelection = false;
            this.Build_View.Location = new System.Drawing.Point(16, 18);
            this.Build_View.Name = "Build_View";
            this.Build_View.Size = new System.Drawing.Size(394, 489);
            this.Build_View.TabIndex = 0;
            this.Build_View.UseCompatibleStateImageBehavior = false;
            this.Build_View.View = System.Windows.Forms.View.Details;
            this.Build_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Build_View_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "층";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "시설 정보";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "수리";
            this.columnHeader7.Width = 39;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "고장 날짜";
            this.columnHeader12.Width = 92;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "~";
            this.columnHeader16.Width = 20;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "수리 날짜";
            this.columnHeader15.Width = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Poly_Dormitory.Properties.Resources.폴리텍_로고;
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Tan;
            this.label13.Font = new System.Drawing.Font("돋움", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(253, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(569, 37);
            this.label13.TabIndex = 21;
            this.label13.Text = "백두관 학생 및 시설 현황";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(34, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(80, 14);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "기숙사 현황";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Now_View);
            this.panel4.Location = new System.Drawing.Point(17, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 405);
            this.panel4.TabIndex = 19;
            // 
            // Now_View
            // 
            this.Now_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11});
            this.Now_View.FullRowSelect = true;
            this.Now_View.HideSelection = false;
            this.Now_View.Location = new System.Drawing.Point(16, 18);
            this.Now_View.Name = "Now_View";
            this.Now_View.Size = new System.Drawing.Size(188, 367);
            this.Now_View.TabIndex = 2;
            this.Now_View.UseCompatibleStateImageBehavior = false;
            this.Now_View.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "호실";
            this.columnHeader4.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "A";
            this.columnHeader5.Width = 63;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "B";
            // 
            // AllClear
            // 
            this.AllClear.Location = new System.Drawing.Point(902, 15);
            this.AllClear.Name = "AllClear";
            this.AllClear.Size = new System.Drawing.Size(103, 37);
            this.AllClear.TabIndex = 16;
            this.AllClear.Text = "데이터 초기화";
            this.AllClear.UseVisualStyleBackColor = true;
            this.AllClear.Click += new System.EventHandler(this.AllClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "나가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(271, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 14);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "입사/퇴사 현황";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Student_View);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(253, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 550);
            this.panel2.TabIndex = 5;
            // 
            // Student_View
            // 
            this.Student_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader10});
            this.Student_View.FullRowSelect = true;
            this.Student_View.HideSelection = false;
            this.Student_View.Location = new System.Drawing.Point(14, 18);
            this.Student_View.Name = "Student_View";
            this.Student_View.Size = new System.Drawing.Size(441, 489);
            this.Student_View.TabIndex = 20;
            this.Student_View.UseCompatibleStateImageBehavior = false;
            this.Student_View.View = System.Windows.Forms.View.Details;
            this.Student_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Student_View_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            this.columnHeader3.Width = 48;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "학번";
            this.columnHeader13.Width = 72;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "학과";
            this.columnHeader14.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "호실";
            this.columnHeader8.Width = 42;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "입사 날짜";
            this.columnHeader9.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "~";
            this.columnHeader2.Width = 23;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "퇴사 날짜";
            this.columnHeader10.Width = 71;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "학생 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Baekdu_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1218, 661);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Baekdu_Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "백두관_현황";
            this.Load += new System.EventHandler(this.Baekdu_Stat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AllClear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView Student_View;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView Now_View;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView Build_View;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}