namespace SimStuManageSys
{
    partial class TeacherInfo
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
            this.btnModify = new System.Windows.Forms.Button();
            this.cbxTeaSex = new System.Windows.Forms.ComboBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TeaSex = new System.Windows.Forms.Label();
            this.txtTeaAddress = new System.Windows.Forms.TextBox();
            this.txtTeaNum = new System.Windows.Forms.TextBox();
            this.txtTeaPhone = new System.Windows.Forms.TextBox();
            this.txtTeaTitle = new System.Windows.Forms.TextBox();
            this.TeaName = new System.Windows.Forms.Label();
            this.TeaTitle = new System.Windows.Forms.Label();
            this.TeaPhone = new System.Windows.Forms.Label();
            this.TeaAdress = new System.Windows.Forms.Label();
            this.TeaNum = new System.Windows.Forms.Label();
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(561, 59);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cbxTeaSex
            // 
            this.cbxTeaSex.FormattingEnabled = true;
            this.cbxTeaSex.Location = new System.Drawing.Point(318, 48);
            this.cbxTeaSex.Name = "cbxTeaSex";
            this.cbxTeaSex.Size = new System.Drawing.Size(114, 20);
            this.cbxTeaSex.TabIndex = 1;
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(109, 86);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(100, 21);
            this.txtTeaName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(461, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TeaSex
            // 
            this.TeaSex.AutoSize = true;
            this.TeaSex.Location = new System.Drawing.Point(259, 51);
            this.TeaSex.Name = "TeaSex";
            this.TeaSex.Size = new System.Drawing.Size(29, 12);
            this.TeaSex.TabIndex = 4;
            this.TeaSex.Text = "性别";
            // 
            // txtTeaAddress
            // 
            this.txtTeaAddress.Location = new System.Drawing.Point(109, 124);
            this.txtTeaAddress.Name = "txtTeaAddress";
            this.txtTeaAddress.Size = new System.Drawing.Size(100, 21);
            this.txtTeaAddress.TabIndex = 5;
            // 
            // txtTeaNum
            // 
            this.txtTeaNum.Location = new System.Drawing.Point(109, 47);
            this.txtTeaNum.Name = "txtTeaNum";
            this.txtTeaNum.Size = new System.Drawing.Size(100, 21);
            this.txtTeaNum.TabIndex = 6;
            // 
            // txtTeaPhone
            // 
            this.txtTeaPhone.Location = new System.Drawing.Point(318, 80);
            this.txtTeaPhone.Name = "txtTeaPhone";
            this.txtTeaPhone.Size = new System.Drawing.Size(114, 21);
            this.txtTeaPhone.TabIndex = 7;
            // 
            // txtTeaTitle
            // 
            this.txtTeaTitle.Location = new System.Drawing.Point(318, 124);
            this.txtTeaTitle.Name = "txtTeaTitle";
            this.txtTeaTitle.Size = new System.Drawing.Size(114, 21);
            this.txtTeaTitle.TabIndex = 8;
            // 
            // TeaName
            // 
            this.TeaName.AutoSize = true;
            this.TeaName.Location = new System.Drawing.Point(53, 89);
            this.TeaName.Name = "TeaName";
            this.TeaName.Size = new System.Drawing.Size(29, 12);
            this.TeaName.TabIndex = 9;
            this.TeaName.Text = "姓名";
            // 
            // TeaTitle
            // 
            this.TeaTitle.AutoSize = true;
            this.TeaTitle.Location = new System.Drawing.Point(259, 127);
            this.TeaTitle.Name = "TeaTitle";
            this.TeaTitle.Size = new System.Drawing.Size(29, 12);
            this.TeaTitle.TabIndex = 10;
            this.TeaTitle.Text = "职称";
            // 
            // TeaPhone
            // 
            this.TeaPhone.AutoSize = true;
            this.TeaPhone.Location = new System.Drawing.Point(259, 89);
            this.TeaPhone.Name = "TeaPhone";
            this.TeaPhone.Size = new System.Drawing.Size(53, 12);
            this.TeaPhone.TabIndex = 11;
            this.TeaPhone.Text = "联系电话";
            // 
            // TeaAdress
            // 
            this.TeaAdress.AutoSize = true;
            this.TeaAdress.Location = new System.Drawing.Point(53, 127);
            this.TeaAdress.Name = "TeaAdress";
            this.TeaAdress.Size = new System.Drawing.Size(29, 12);
            this.TeaAdress.TabIndex = 12;
            this.TeaAdress.Text = "地址";
            // 
            // TeaNum
            // 
            this.TeaNum.AutoSize = true;
            this.TeaNum.Location = new System.Drawing.Point(53, 51);
            this.TeaNum.Name = "TeaNum";
            this.TeaNum.Size = new System.Drawing.Size(29, 12);
            this.TeaNum.TabIndex = 13;
            this.TeaNum.Text = "工号";
            // 
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Location = new System.Drawing.Point(37, 187);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.RowTemplate.Height = 23;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(616, 280);
            this.dgvTeacherInfo.TabIndex = 14;
            this.dgvTeacherInfo.Click += new System.EventHandler(this.dgvTeacherInfo_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(461, 111);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(561, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 485);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvTeacherInfo);
            this.Controls.Add(this.TeaNum);
            this.Controls.Add(this.TeaAdress);
            this.Controls.Add(this.TeaPhone);
            this.Controls.Add(this.TeaTitle);
            this.Controls.Add(this.TeaName);
            this.Controls.Add(this.txtTeaTitle);
            this.Controls.Add(this.txtTeaPhone);
            this.Controls.Add(this.txtTeaNum);
            this.Controls.Add(this.txtTeaAddress);
            this.Controls.Add(this.TeaSex);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTeaName);
            this.Controls.Add(this.cbxTeaSex);
            this.Controls.Add(this.btnModify);
            this.Name = "TeacherInfo";
            this.Text = "教师信息";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox cbxTeaSex;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label TeaSex;
        private System.Windows.Forms.TextBox txtTeaAddress;
        private System.Windows.Forms.TextBox txtTeaNum;
        private System.Windows.Forms.TextBox txtTeaPhone;
        private System.Windows.Forms.TextBox txtTeaTitle;
        private System.Windows.Forms.Label TeaName;
        private System.Windows.Forms.Label TeaTitle;
        private System.Windows.Forms.Label TeaPhone;
        private System.Windows.Forms.Label TeaAdress;
        private System.Windows.Forms.Label TeaNum;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;

        //public System.EventHandler TeacherInfo_Load { get; set; }
    }
}