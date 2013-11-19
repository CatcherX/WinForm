namespace UI
{
    partial class SelCourse
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowInput = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancelSel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSelCourse = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.cbxCourseName = new System.Windows.Forms.ComboBox();
            this.cbxCourseNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelCourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(315, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 173);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "操作区";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnSelOk);
            this.groupBox4.Location = new System.Drawing.Point(35, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 141);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSelOk
            // 
            this.btnSelOk.Location = new System.Drawing.Point(6, 29);
            this.btnSelOk.Name = "btnSelOk";
            this.btnSelOk.Size = new System.Drawing.Size(75, 23);
            this.btnSelOk.TabIndex = 3;
            this.btnSelOk.Text = "选课";
            this.btnSelOk.UseVisualStyleBackColor = true;
            this.btnSelOk.Click += new System.EventHandler(this.btnSelOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowInput);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnCancelSel);
            this.groupBox3.Location = new System.Drawing.Point(158, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 138);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // btnShowInput
            // 
            this.btnShowInput.Location = new System.Drawing.Point(13, 98);
            this.btnShowInput.Name = "btnShowInput";
            this.btnShowInput.Size = new System.Drawing.Size(75, 23);
            this.btnShowInput.TabIndex = 26;
            this.btnShowInput.Text = "显示(&S)";
            this.btnShowInput.UseVisualStyleBackColor = true;
            this.btnShowInput.Click += new System.EventHandler(this.btnShowInput_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancelSel
            // 
            this.btnCancelSel.Location = new System.Drawing.Point(13, 26);
            this.btnCancelSel.Name = "btnCancelSel";
            this.btnCancelSel.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSel.TabIndex = 0;
            this.btnCancelSel.Text = "退选";
            this.btnCancelSel.UseVisualStyleBackColor = true;
            this.btnCancelSel.Click += new System.EventHandler(this.btnCancelSel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSelCourse);
            this.groupBox2.Location = new System.Drawing.Point(20, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 232);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息预览";
            // 
            // dgvSelCourse
            // 
            this.dgvSelCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelCourse.Location = new System.Drawing.Point(11, 19);
            this.dgvSelCourse.Name = "dgvSelCourse";
            this.dgvSelCourse.RowTemplate.Height = 23;
            this.dgvSelCourse.Size = new System.Drawing.Size(543, 206);
            this.dgvSelCourse.TabIndex = 0;
            this.dgvSelCourse.Click += new System.EventHandler(this.dgvSelCourse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStuNum);
            this.groupBox1.Controls.Add(this.cbxCourseName);
            this.groupBox1.Controls.Add(this.cbxCourseNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 173);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑框";
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(100, 46);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.ReadOnly = true;
            this.txtStuNum.Size = new System.Drawing.Size(121, 21);
            this.txtStuNum.TabIndex = 28;
            // 
            // cbxCourseName
            // 
            this.cbxCourseName.FormattingEnabled = true;
            this.cbxCourseName.Location = new System.Drawing.Point(100, 115);
            this.cbxCourseName.Name = "cbxCourseName";
            this.cbxCourseName.Size = new System.Drawing.Size(121, 20);
            this.cbxCourseName.TabIndex = 27;
            this.cbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cbxCourseName_SelectedIndexChanged);
            // 
            // cbxCourseNum
            // 
            this.cbxCourseNum.FormattingEnabled = true;
            this.cbxCourseNum.Location = new System.Drawing.Point(100, 79);
            this.cbxCourseNum.Name = "cbxCourseNum";
            this.cbxCourseNum.Size = new System.Drawing.Size(121, 20);
            this.cbxCourseNum.TabIndex = 22;
            this.cbxCourseNum.SelectedIndexChanged += new System.EventHandler(this.cbxCourseNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "课程名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "课程编号";
            // 
            // SelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 429);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelCourse";
            this.Text = "学生选课";
            this.Load += new System.EventHandler(this.SelCourse_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelCourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCourseNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSelCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelSel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelOk;
        private System.Windows.Forms.Button btnShowInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStuNum;
    }
}