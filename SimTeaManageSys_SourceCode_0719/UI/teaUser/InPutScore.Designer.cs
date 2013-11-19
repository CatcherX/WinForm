namespace UI
{
    partial class InPutScore
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
            this.dgvSelCourse = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowInput = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.cbxScore = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCourseNum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCourseName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStuName = new System.Windows.Forms.ComboBox();
            this.cbxStuNum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelCourse)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSelCourse
            // 
            this.dgvSelCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelCourse.Location = new System.Drawing.Point(6, 20);
            this.dgvSelCourse.Name = "dgvSelCourse";
            this.dgvSelCourse.RowTemplate.Height = 23;
            this.dgvSelCourse.Size = new System.Drawing.Size(675, 170);
            this.dgvSelCourse.TabIndex = 0;
            this.dgvSelCourse.Click += new System.EventHandler(this.dgvSelCourse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowInput);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Location = new System.Drawing.Point(121, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 121);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnShowInput
            // 
            this.btnShowInput.Location = new System.Drawing.Point(11, 90);
            this.btnShowInput.Name = "btnShowInput";
            this.btnShowInput.Size = new System.Drawing.Size(75, 23);
            this.btnShowInput.TabIndex = 27;
            this.btnShowInput.Text = "显示(&S)";
            this.btnShowInput.UseVisualStyleBackColor = true;
            this.btnShowInput.Click += new System.EventHandler(this.btnShowInput_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(11, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnInput);
            this.groupBox4.Location = new System.Drawing.Point(12, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(94, 121);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(12, 20);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // cbxScore
            // 
            this.cbxScore.FormattingEnabled = true;
            this.cbxScore.Location = new System.Drawing.Point(67, 95);
            this.cbxScore.Name = "cbxScore";
            this.cbxScore.Size = new System.Drawing.Size(121, 20);
            this.cbxScore.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSelCourse);
            this.groupBox2.Location = new System.Drawing.Point(21, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 201);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息预览";
            // 
            // cbxCourseNum
            // 
            this.cbxCourseNum.FormattingEnabled = true;
            this.cbxCourseNum.Location = new System.Drawing.Point(278, 55);
            this.cbxCourseNum.Name = "cbxCourseNum";
            this.cbxCourseNum.Size = new System.Drawing.Size(121, 20);
            this.cbxCourseNum.TabIndex = 22;
            this.cbxCourseNum.SelectedIndexChanged += new System.EventHandler(this.cbxCourseNum_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCourseName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbStuName);
            this.groupBox1.Controls.Add(this.cbxStuNum);
            this.groupBox1.Controls.Add(this.cbxScore);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxCourseNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑框";
            // 
            // cbxCourseName
            // 
            this.cbxCourseName.FormattingEnabled = true;
            this.cbxCourseName.Location = new System.Drawing.Point(278, 20);
            this.cbxCourseName.Name = "cbxCourseName";
            this.cbxCourseName.Size = new System.Drawing.Size(121, 20);
            this.cbxCourseName.TabIndex = 29;
            this.cbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cbxCourseName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "课程名称";
            // 
            // cmbStuName
            // 
            this.cmbStuName.FormattingEnabled = true;
            this.cmbStuName.Location = new System.Drawing.Point(67, 55);
            this.cmbStuName.Name = "cmbStuName";
            this.cmbStuName.Size = new System.Drawing.Size(121, 20);
            this.cmbStuName.TabIndex = 27;
            this.cmbStuName.SelectedIndexChanged += new System.EventHandler(this.cmbStuName_SelectedIndexChanged);
            // 
            // cbxStuNum
            // 
            this.cbxStuNum.FormattingEnabled = true;
            this.cbxStuNum.Location = new System.Drawing.Point(67, 25);
            this.cbxStuNum.Name = "cbxStuNum";
            this.cbxStuNum.Size = new System.Drawing.Size(121, 20);
            this.cbxStuNum.TabIndex = 27;
            this.cbxStuNum.SelectedIndexChanged += new System.EventHandler(this.cbxStuNum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "学生姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "课程编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "成绩";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(454, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 151);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "操作区";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "目前，这里只能够查找到已经选课了的学生，所以\r\n学号与课程课程名称都必须先录入。";
            // 
            // InPutScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InPutScore";
            this.Text = "成绩录入";
            this.Load += new System.EventHandler(this.InPutScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelCourse)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox cbxScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCourseNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowInput;
        private System.Windows.Forms.ComboBox cbxStuNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStuName;
        private System.Windows.Forms.Label label7;
    }
}