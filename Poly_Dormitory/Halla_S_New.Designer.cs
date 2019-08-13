namespace Poly_Dormitory
{
    partial class Halla_S_New
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.new_Num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Female = new System.Windows.Forms.RadioButton();
            this.btn_Male = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_1 = new System.Windows.Forms.RadioButton();
            this.btn_2 = new System.Windows.Forms.RadioButton();
            this.new_Class = new System.Windows.Forms.ComboBox();
            this.new_Name = new System.Windows.Forms.TextBox();
            this.new_Room = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hallaStuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyDormiDataSet = new Poly_Dormitory.PolyDormiDataSet();
            this.halla_StuTableAdapter = new Poly_Dormitory.PolyDormiDataSetTableAdapters.Halla_StuTableAdapter();
            this.polyDormiDataSet1 = new Poly_Dormitory.PolyDormiDataSet1();
            this.hallaStuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.halla_StuTableAdapter1 = new Poly_Dormitory.PolyDormiDataSet1TableAdapters.Halla_StuTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hallaStuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDormiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDormiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallaStuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.new_Num);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.new_Class);
            this.panel1.Controls.Add(this.new_Name);
            this.panel1.Controls.Add(this.new_Room);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 377);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "입사 학생 정보";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // new_Num
            // 
            this.new_Num.Location = new System.Drawing.Point(66, 175);
            this.new_Num.Name = "new_Num";
            this.new_Num.Size = new System.Drawing.Size(106, 21);
            this.new_Num.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "학번 :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  yyyy년 MM월 dd일";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 21);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "<<입사날짜>>";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Female);
            this.panel3.Controls.Add(this.btn_Male);
            this.panel3.Location = new System.Drawing.Point(62, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 29);
            this.panel3.TabIndex = 7;
            // 
            // btn_Female
            // 
            this.btn_Female.AutoSize = true;
            this.btn_Female.Location = new System.Drawing.Point(62, 5);
            this.btn_Female.Name = "btn_Female";
            this.btn_Female.Size = new System.Drawing.Size(35, 16);
            this.btn_Female.TabIndex = 8;
            this.btn_Female.TabStop = true;
            this.btn_Female.Text = "여";
            this.btn_Female.UseVisualStyleBackColor = true;
            // 
            // btn_Male
            // 
            this.btn_Male.AutoSize = true;
            this.btn_Male.Location = new System.Drawing.Point(6, 5);
            this.btn_Male.Name = "btn_Male";
            this.btn_Male.Size = new System.Drawing.Size(35, 16);
            this.btn_Male.TabIndex = 7;
            this.btn_Male.TabStop = true;
            this.btn_Male.Text = "남";
            this.btn_Male.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.btn_1);
            this.panel2.Controls.Add(this.btn_2);
            this.panel2.Location = new System.Drawing.Point(64, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 23);
            this.panel2.TabIndex = 5;
            // 
            // btn_1
            // 
            this.btn_1.AutoSize = true;
            this.btn_1.Location = new System.Drawing.Point(4, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(53, 16);
            this.btn_1.TabIndex = 5;
            this.btn_1.TabStop = true;
            this.btn_1.Text = "1학년";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.AutoSize = true;
            this.btn_2.Location = new System.Drawing.Point(60, 2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(53, 16);
            this.btn_2.TabIndex = 5;
            this.btn_2.TabStop = true;
            this.btn_2.Text = "2학년";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // new_Class
            // 
            this.new_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_Class.FormattingEnabled = true;
            this.new_Class.Items.AddRange(new object[] {
            "금형디자인",
            "기계시스템",
            "메카트로닉스",
            "산업설비자동화",
            "자동차",
            "전기에너지시스템",
            "컴퓨터정보",
            "정보통신",
            "디지털방송",
            "산업디자인",
            "신소재승용",
            "건축설계"});
            this.new_Class.Location = new System.Drawing.Point(66, 140);
            this.new_Class.Name = "new_Class";
            this.new_Class.Size = new System.Drawing.Size(107, 20);
            this.new_Class.TabIndex = 3;
            // 
            // new_Name
            // 
            this.new_Name.Location = new System.Drawing.Point(66, 104);
            this.new_Name.Name = "new_Name";
            this.new_Name.Size = new System.Drawing.Size(106, 21);
            this.new_Name.TabIndex = 2;
            // 
            // new_Room
            // 
            this.new_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_Room.FormattingEnabled = true;
            this.new_Room.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410"});
            this.new_Room.Location = new System.Drawing.Point(66, 70);
            this.new_Room.Name = "new_Room";
            this.new_Room.Size = new System.Drawing.Size(107, 20);
            this.new_Room.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "학년 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "학과 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "호실 :";
            // 
            // hallaStuBindingSource
            // 
            this.hallaStuBindingSource.DataMember = "Halla_Stu";
            this.hallaStuBindingSource.DataSource = this.polyDormiDataSet;
            // 
            // polyDormiDataSet
            // 
            this.polyDormiDataSet.DataSetName = "PolyDormiDataSet";
            this.polyDormiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // halla_StuTableAdapter
            // 
            this.halla_StuTableAdapter.ClearBeforeFill = true;
            // 
            // polyDormiDataSet1
            // 
            this.polyDormiDataSet1.DataSetName = "PolyDormiDataSet1";
            this.polyDormiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallaStuBindingSource1
            // 
            this.hallaStuBindingSource1.DataMember = "Halla_Stu";
            this.hallaStuBindingSource1.DataSource = this.polyDormiDataSet1;
            // 
            // halla_StuTableAdapter1
            // 
            this.halla_StuTableAdapter1.ClearBeforeFill = true;
            // 
            // Halla_S_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 401);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Halla_S_New";
            this.Text = "한라관_입사";
            this.Load += new System.EventHandler(this.Halla_S_New_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hallaStuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDormiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDormiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallaStuBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox new_Class;
        private System.Windows.Forms.TextBox new_Name;
        private System.Windows.Forms.ComboBox new_Room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton btn_Female;
        private System.Windows.Forms.RadioButton btn_Male;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btn_1;
        private System.Windows.Forms.RadioButton btn_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PolyDormiDataSet polyDormiDataSet;
        private System.Windows.Forms.BindingSource hallaStuBindingSource;
        private PolyDormiDataSetTableAdapters.Halla_StuTableAdapter halla_StuTableAdapter;
        private PolyDormiDataSet1 polyDormiDataSet1;
        private System.Windows.Forms.BindingSource hallaStuBindingSource1;
        private PolyDormiDataSet1TableAdapters.Halla_StuTableAdapter halla_StuTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox new_Num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}