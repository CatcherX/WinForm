namespace SimStuManageSys
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
            this.lbClass = new System.Windows.Forms.Label();
            this.txtClaName = new System.Windows.Forms.TextBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbClassNum = new System.Windows.Forms.Label();
            this.txtClaNum = new System.Windows.Forms.TextBox();
            this.lbDeptNum = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDeptNum = new System.Windows.Forms.TextBox();
            this.lbProNum = new System.Windows.Forms.Label();
            this.txtProNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(21, 82);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(53, 12);
            this.lbClass.TabIndex = 1;
            this.lbClass.Text = "班  级：";
            // 
            // txtClaName
            // 
            this.txtClaName.Location = new System.Drawing.Point(82, 79);
            this.txtClaName.Name = "txtClaName";
            this.txtClaName.Size = new System.Drawing.Size(100, 21);
            this.txtClaName.TabIndex = 2;
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(11, 20);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowTemplate.Height = 23;
            this.dgvClass.Size = new System.Drawing.Size(381, 150);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.Click += new System.EventHandler(this.dgvClass_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(246, 171);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbClassNum
            // 
            this.lbClassNum.AutoSize = true;
            this.lbClassNum.Location = new System.Drawing.Point(21, 41);
            this.lbClassNum.Name = "lbClassNum";
            this.lbClassNum.Size = new System.Drawing.Size(53, 12);
            this.lbClassNum.TabIndex = 5;
            this.lbClassNum.Text = "班级号：";
            // 
            // txtClaNum
            // 
            this.txtClaNum.Location = new System.Drawing.Point(82, 38);
            this.txtClaNum.Name = "txtClaNum";
            this.txtClaNum.Size = new System.Drawing.Size(100, 21);
            this.txtClaNum.TabIndex = 6;
            // 
            // lbDeptNum
            // 
            this.lbDeptNum.AutoSize = true;
            this.lbDeptNum.Location = new System.Drawing.Point(21, 127);
            this.lbDeptNum.Name = "lbDeptNum";
            this.lbDeptNum.Size = new System.Drawing.Size(65, 12);
            this.lbDeptNum.TabIndex = 7;
            this.lbDeptNum.Text = "系别编号：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDeptNum
            // 
            this.txtDeptNum.Location = new System.Drawing.Point(82, 122);
            this.txtDeptNum.Name = "txtDeptNum";
            this.txtDeptNum.Size = new System.Drawing.Size(100, 21);
            this.txtDeptNum.TabIndex = 9;
            // 
            // lbProNum
            // 
            this.lbProNum.AutoSize = true;
            this.lbProNum.Location = new System.Drawing.Point(21, 174);
            this.lbProNum.Name = "lbProNum";
            this.lbProNum.Size = new System.Drawing.Size(65, 12);
            this.lbProNum.TabIndex = 10;
            this.lbProNum.Text = "专业编号：";
            // 
            // txtProNum
            // 
            this.txtProNum.Location = new System.Drawing.Point(82, 171);
            this.txtProNum.Name = "txtProNum";
            this.txtProNum.Size = new System.Drawing.Size(100, 21);
            this.txtProNum.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 188);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 412);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProNum);
            this.Controls.Add(this.lbProNum);
            this.Controls.Add(this.txtDeptNum);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbDeptNum);
            this.Controls.Add(this.txtClaNum);
            this.Controls.Add(this.lbClassNum);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtClaName);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.btnSearch);
            this.Name = "ClassInfo";
            this.Text = "班级信息";
            this.Load += new System.EventHandler(this.classinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.TextBox txtClaName;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lbClassNum;
        private System.Windows.Forms.TextBox txtClaNum;
        private System.Windows.Forms.Label lbDeptNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDeptNum;
        private System.Windows.Forms.Label lbProNum;
        private System.Windows.Forms.TextBox txtProNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}

