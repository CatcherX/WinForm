namespace UI
{
    partial class ClassInfo
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbClaName = new System.Windows.Forms.ComboBox();
            this.cmbClaNum = new System.Windows.Forms.ComboBox();
            this.cmbDeptNum = new System.Windows.Forms.ComboBox();
            this.cmbProNum = new System.Windows.Forms.ComboBox();
            this.cmbProName = new System.Windows.Forms.ComboBox();
            this.cmbDeptName = new System.Windows.Forms.ComboBox();
            this.lbProNum = new System.Windows.Forms.Label();
            this.lbDeptNum = new System.Windows.Forms.Label();
            this.lbClassNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(25, 20);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowTemplate.Height = 23;
            this.dgvClass.Size = new System.Drawing.Size(576, 167);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.Click += new System.EventHandler(this.dgvClass_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(475, 88);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 32);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(566, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClass);
            this.groupBox1.Location = new System.Drawing.Point(23, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(475, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(517, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(188, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "系部名称、专业名称不用输入！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "待+设置选择改变事件，当选中名称后，自动触发编辑文本框，获取相应的字段即可";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbClaName);
            this.groupBox2.Controls.Add(this.cmbClaNum);
            this.groupBox2.Controls.Add(this.cmbDeptNum);
            this.groupBox2.Controls.Add(this.cmbProNum);
            this.groupBox2.Controls.Add(this.cmbProName);
            this.groupBox2.Controls.Add(this.cmbDeptName);
            this.groupBox2.Controls.Add(this.lbProNum);
            this.groupBox2.Controls.Add(this.lbDeptNum);
            this.groupBox2.Controls.Add(this.lbClassNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbClass);
            this.groupBox2.Location = new System.Drawing.Point(10, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 184);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑内容";
            // 
            // cmbClaName
            // 
            this.cmbClaName.FormattingEnabled = true;
            this.cmbClaName.Location = new System.Drawing.Point(306, 30);
            this.cmbClaName.Name = "cmbClaName";
            this.cmbClaName.Size = new System.Drawing.Size(121, 20);
            this.cmbClaName.TabIndex = 22;
            this.cmbClaName.SelectedIndexChanged += new System.EventHandler(this.cmbClaName_SelectedIndexChanged);
            // 
            // cmbClaNum
            // 
            this.cmbClaNum.FormattingEnabled = true;
            this.cmbClaNum.Location = new System.Drawing.Point(93, 31);
            this.cmbClaNum.Name = "cmbClaNum";
            this.cmbClaNum.Size = new System.Drawing.Size(121, 20);
            this.cmbClaNum.TabIndex = 24;
            this.cmbClaNum.SelectedIndexChanged += new System.EventHandler(this.cmbClaNum_SelectedIndexChanged);
            // 
            // cmbDeptNum
            // 
            this.cmbDeptNum.FormattingEnabled = true;
            this.cmbDeptNum.Location = new System.Drawing.Point(93, 79);
            this.cmbDeptNum.Name = "cmbDeptNum";
            this.cmbDeptNum.Size = new System.Drawing.Size(121, 20);
            this.cmbDeptNum.TabIndex = 23;
            this.cmbDeptNum.SelectedIndexChanged += new System.EventHandler(this.cmbDeptNum_SelectedIndexChanged);
            // 
            // cmbProNum
            // 
            this.cmbProNum.FormattingEnabled = true;
            this.cmbProNum.Location = new System.Drawing.Point(93, 135);
            this.cmbProNum.Name = "cmbProNum";
            this.cmbProNum.Size = new System.Drawing.Size(121, 20);
            this.cmbProNum.TabIndex = 25;
            this.cmbProNum.SelectedIndexChanged += new System.EventHandler(this.cmbProNum_SelectedIndexChanged);
            // 
            // cmbProName
            // 
            this.cmbProName.FormattingEnabled = true;
            this.cmbProName.Location = new System.Drawing.Point(306, 135);
            this.cmbProName.Name = "cmbProName";
            this.cmbProName.Size = new System.Drawing.Size(121, 20);
            this.cmbProName.TabIndex = 27;
            this.cmbProName.SelectedIndexChanged += new System.EventHandler(this.cmbProName_SelectedIndexChanged);
            // 
            // cmbDeptName
            // 
            this.cmbDeptName.FormattingEnabled = true;
            this.cmbDeptName.Location = new System.Drawing.Point(306, 79);
            this.cmbDeptName.Name = "cmbDeptName";
            this.cmbDeptName.Size = new System.Drawing.Size(121, 20);
            this.cmbDeptName.TabIndex = 26;
            this.cmbDeptName.SelectedIndexChanged += new System.EventHandler(this.cmbDeptName_SelectedIndexChanged);
            // 
            // lbProNum
            // 
            this.lbProNum.AutoSize = true;
            this.lbProNum.Location = new System.Drawing.Point(32, 138);
            this.lbProNum.Name = "lbProNum";
            this.lbProNum.Size = new System.Drawing.Size(65, 12);
            this.lbProNum.TabIndex = 21;
            this.lbProNum.Text = "专业编号：";
            // 
            // lbDeptNum
            // 
            this.lbDeptNum.AutoSize = true;
            this.lbDeptNum.Location = new System.Drawing.Point(32, 82);
            this.lbDeptNum.Name = "lbDeptNum";
            this.lbDeptNum.Size = new System.Drawing.Size(65, 12);
            this.lbDeptNum.TabIndex = 20;
            this.lbDeptNum.Text = "系别编号：";
            // 
            // lbClassNum
            // 
            this.lbClassNum.AutoSize = true;
            this.lbClassNum.Location = new System.Drawing.Point(32, 33);
            this.lbClassNum.Name = "lbClassNum";
            this.lbClassNum.Size = new System.Drawing.Size(53, 12);
            this.lbClassNum.TabIndex = 19;
            this.lbClassNum.Text = "班级号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "专业名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "系部名称";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(247, 38);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(53, 12);
            this.lbClass.TabIndex = 18;
            this.lbClass.Text = "班  级：";
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Name = "ClassInfo";
            this.Text = "班级信息";
            this.Load += new System.EventHandler(this.classinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbClaName;
        private System.Windows.Forms.ComboBox cmbClaNum;
        private System.Windows.Forms.ComboBox cmbDeptNum;
        private System.Windows.Forms.ComboBox cmbProNum;
        private System.Windows.Forms.ComboBox cmbProName;
        private System.Windows.Forms.ComboBox cmbDeptName;
        private System.Windows.Forms.Label lbProNum;
        private System.Windows.Forms.Label lbDeptNum;
        private System.Windows.Forms.Label lbClassNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClass;
    }
}

