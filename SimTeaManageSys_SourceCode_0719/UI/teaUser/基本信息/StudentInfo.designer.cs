namespace SimStuManageSys
{
    partial class StudentInfo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.cbxSearchName = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFavor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClaNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtStuScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.cbxStuSex = new System.Windows.Forms.ComboBox();
            this.txtPolicity = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(648, 214);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 12);
            this.label24.TabIndex = 101;
            this.label24.Text = "搜索条件:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 23);
            this.btnSearch.TabIndex = 100;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(425, 13);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(44, 23);
            this.btnModify.TabIndex = 104;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // cbxSearchName
            // 
            this.cbxSearchName.FormattingEnabled = true;
            this.cbxSearchName.Items.AddRange(new object[] {
            "学生学号",
            "学生姓名"});
            this.cbxSearchName.Location = new System.Drawing.Point(65, 15);
            this.cbxSearchName.Name = "cbxSearchName";
            this.cbxSearchName.Size = new System.Drawing.Size(103, 20);
            this.cbxSearchName.TabIndex = 103;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(174, 13);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(195, 21);
            this.txtSearchValue.TabIndex = 102;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(475, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(44, 23);
            this.btnDel.TabIndex = 105;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 23);
            this.btnClear.TabIndex = 106;
            this.btnClear.Text = "显示";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFavor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtClaNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtStuScore);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtBirthday);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labSex);
            this.groupBox1.Controls.Add(this.cbxStuSex);
            this.groupBox1.Controls.Add(this.txtPolicity);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.txtStuNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 183);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 58;
            this.label2.Text = "班级:";
            // 
            // txtFavor
            // 
            this.txtFavor.Location = new System.Drawing.Point(298, 92);
            this.txtFavor.MaxLength = 20;
            this.txtFavor.Name = "txtFavor";
            this.txtFavor.Size = new System.Drawing.Size(119, 21);
            this.txtFavor.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 55;
            this.label7.Text = "性  别:";
            // 
            // txtClaNum
            // 
            this.txtClaNum.Location = new System.Drawing.Point(75, 124);
            this.txtClaNum.MaxLength = 20;
            this.txtClaNum.Name = "txtClaNum";
            this.txtClaNum.Size = new System.Drawing.Size(119, 21);
            this.txtClaNum.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 55;
            this.label3.Text = "学生姓名:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(598, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 23);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtStuScore
            // 
            this.txtStuScore.Location = new System.Drawing.Point(526, 55);
            this.txtStuScore.MaxLength = 200;
            this.txtStuScore.Name = "txtStuScore";
            this.txtStuScore.Size = new System.Drawing.Size(119, 21);
            this.txtStuScore.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(552, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "爱好:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "综合分:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(260, 127);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(385, 21);
            this.txtAddress.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, -68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "联系地址:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "联系地址:";
            // 
            // txtMono
            // 
            this.txtMono.Location = new System.Drawing.Point(526, 90);
            this.txtMono.MaxLength = 20;
            this.txtMono.Name = "txtMono";
            this.txtMono.Size = new System.Drawing.Size(119, 21);
            this.txtMono.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "评价:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(526, 24);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 21);
            this.txtPhone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "联系电话:";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(298, 58);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(119, 21);
            this.dtBirthday.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "出生日期:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, -67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "身份证号:";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(233, 28);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(59, 12);
            this.labSex.TabIndex = 3;
            this.labSex.Text = "政治面目:";
            // 
            // cbxStuSex
            // 
            this.cbxStuSex.FormattingEnabled = true;
            this.cbxStuSex.IntegralHeight = false;
            this.cbxStuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxStuSex.Location = new System.Drawing.Point(75, 88);
            this.cbxStuSex.Name = "cbxStuSex";
            this.cbxStuSex.Size = new System.Drawing.Size(119, 20);
            this.cbxStuSex.TabIndex = 2;
            // 
            // txtPolicity
            // 
            this.txtPolicity.Location = new System.Drawing.Point(298, 24);
            this.txtPolicity.MaxLength = 20;
            this.txtPolicity.Name = "txtPolicity";
            this.txtPolicity.Size = new System.Drawing.Size(119, 21);
            this.txtPolicity.TabIndex = 1;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(75, 58);
            this.txtStuName.MaxLength = 20;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(119, 21);
            this.txtStuName.TabIndex = 1;
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(75, 28);
            this.txtStuNum.MaxLength = 20;
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(119, 21);
            this.txtStuNum.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-70, -62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "会员ID:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(16, 33);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "学生学号:";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cbxSearchName);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentInfo";
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox cbxSearchName;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFavor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtStuScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.ComboBox cbxStuSex;
        private System.Windows.Forms.TextBox txtPolicity;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaNum;
    }
}

