namespace UI
{
    partial class InputEvalInfo
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
            this.cmbStuNum = new System.Windows.Forms.ComboBox();
            this.cmbTeaNum = new System.Windows.Forms.ComboBox();
            this.cmbTeaName = new System.Windows.Forms.ComboBox();
            this.rdbTerm = new System.Windows.Forms.ComboBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.txtEval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStuNum
            // 
            this.cmbStuNum.FormattingEnabled = true;
            this.cmbStuNum.Location = new System.Drawing.Point(77, 39);
            this.cmbStuNum.Name = "cmbStuNum";
            this.cmbStuNum.Size = new System.Drawing.Size(121, 20);
            this.cmbStuNum.TabIndex = 0;
            // 
            // cmbTeaNum
            // 
            this.cmbTeaNum.FormattingEnabled = true;
            this.cmbTeaNum.Location = new System.Drawing.Point(77, 90);
            this.cmbTeaNum.Name = "cmbTeaNum";
            this.cmbTeaNum.Size = new System.Drawing.Size(121, 20);
            this.cmbTeaNum.TabIndex = 0;
            // 
            // cmbTeaName
            // 
            this.cmbTeaName.FormattingEnabled = true;
            this.cmbTeaName.Location = new System.Drawing.Point(77, 147);
            this.cmbTeaName.Name = "cmbTeaName";
            this.cmbTeaName.Size = new System.Drawing.Size(121, 20);
            this.cmbTeaName.TabIndex = 0;
            // 
            // rdbTerm
            // 
            this.rdbTerm.FormattingEnabled = true;
            this.rdbTerm.Location = new System.Drawing.Point(273, 147);
            this.rdbTerm.Name = "rdbTerm";
            this.rdbTerm.Size = new System.Drawing.Size(121, 20);
            this.rdbTerm.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(473, 53);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNo);
            this.groupBox1.Controls.Add(this.rdbYes);
            this.groupBox1.Controls.Add(this.txtEval);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTeaNum);
            this.groupBox1.Controls.Add(this.cmbStuNum);
            this.groupBox1.Controls.Add(this.rdbTerm);
            this.groupBox1.Controls.Add(this.cmbTeaName);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑框";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(353, 94);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(35, 16);
            this.rdbNo.TabIndex = 6;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "否";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(290, 94);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(35, 16);
            this.rdbYes.TabIndex = 5;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "是";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // txtEval
            // 
            this.txtEval.Location = new System.Drawing.Point(276, 44);
            this.txtEval.Multiline = true;
            this.txtEval.Name = "txtEval";
            this.txtEval.Size = new System.Drawing.Size(118, 21);
            this.txtEval.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "学期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "评价状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "教师姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "评价内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "教师编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "学号";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(473, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(473, 100);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(553, 172);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(24, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 198);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息预览";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(473, 189);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(149, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 36);
            this.label7.TabIndex = 5;
            this.label7.Text = "该窗体功能是新增加的，由于时间原因，还没完成，敬请谅解！\r\n没什么难度，与其它窗体的功能类似。其它窗口功能基本完成！\r\n请先测试其它窗口。";
            // 
            // InputEvalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 469);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnInput);
            this.Name = "InputEvalInfo";
            this.Text = "评教信息录入";
            this.Load += new System.EventHandler(this.InputEvalInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStuNum;
        private System.Windows.Forms.ComboBox cmbTeaNum;
        private System.Windows.Forms.ComboBox cmbTeaName;
        private System.Windows.Forms.ComboBox rdbTerm;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.TextBox txtEval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
    }
}