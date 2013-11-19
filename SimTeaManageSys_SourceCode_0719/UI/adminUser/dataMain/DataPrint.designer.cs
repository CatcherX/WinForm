namespace UI
{
    partial class DataPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPrint));
            this.gpbChoice = new System.Windows.Forms.GroupBox();
            this.rdbSchInfo = new System.Windows.Forms.RadioButton();
            this.rdbClassScore = new System.Windows.Forms.RadioButton();
            this.rdbStuScore = new System.Windows.Forms.RadioButton();
            this.rdbCourseInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintTeacherInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintStudentInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintManager = new System.Windows.Forms.RadioButton();
            this.gpbAction = new System.Windows.Forms.GroupBox();
            this.btnExportText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.gpbInfor = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Printer = new System.Windows.Forms.Button();
            this.gpbChoice.SuspendLayout();
            this.gpbAction.SuspendLayout();
            this.gpbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbChoice
            // 
            this.gpbChoice.Controls.Add(this.rdbSchInfo);
            this.gpbChoice.Controls.Add(this.rdbClassScore);
            this.gpbChoice.Controls.Add(this.rdbStuScore);
            this.gpbChoice.Controls.Add(this.rdbCourseInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintTeacherInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintStudentInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintManager);
            this.gpbChoice.Location = new System.Drawing.Point(12, 12);
            this.gpbChoice.Name = "gpbChoice";
            this.gpbChoice.Size = new System.Drawing.Size(435, 214);
            this.gpbChoice.TabIndex = 0;
            this.gpbChoice.TabStop = false;
            this.gpbChoice.Text = "选择你要导出的内容:";
            // 
            // rdbSchInfo
            // 
            this.rdbSchInfo.AutoSize = true;
            this.rdbSchInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbSchInfo.Location = new System.Drawing.Point(49, 40);
            this.rdbSchInfo.Name = "rdbSchInfo";
            this.rdbSchInfo.Size = new System.Drawing.Size(122, 23);
            this.rdbSchInfo.TabIndex = 2;
            this.rdbSchInfo.TabStop = true;
            this.rdbSchInfo.Text = "校区信息表";
            this.rdbSchInfo.UseVisualStyleBackColor = true;
            this.rdbSchInfo.Click += new System.EventHandler(this.rdbSchInfo_Click);
            // 
            // rdbClassScore
            // 
            this.rdbClassScore.AutoSize = true;
            this.rdbClassScore.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClassScore.Location = new System.Drawing.Point(229, 157);
            this.rdbClassScore.Name = "rdbClassScore";
            this.rdbClassScore.Size = new System.Drawing.Size(122, 23);
            this.rdbClassScore.TabIndex = 1;
            this.rdbClassScore.TabStop = true;
            this.rdbClassScore.Text = "班级成绩表";
            this.rdbClassScore.UseVisualStyleBackColor = true;
            this.rdbClassScore.Click += new System.EventHandler(this.rdbClassScore_Click);
            // 
            // rdbStuScore
            // 
            this.rdbStuScore.AutoSize = true;
            this.rdbStuScore.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbStuScore.Location = new System.Drawing.Point(229, 121);
            this.rdbStuScore.Name = "rdbStuScore";
            this.rdbStuScore.Size = new System.Drawing.Size(122, 23);
            this.rdbStuScore.TabIndex = 1;
            this.rdbStuScore.TabStop = true;
            this.rdbStuScore.Text = "学生成绩表";
            this.rdbStuScore.UseVisualStyleBackColor = true;
            this.rdbStuScore.Click += new System.EventHandler(this.rdbStuScore_Click);
            // 
            // rdbCourseInfo
            // 
            this.rdbCourseInfo.AutoSize = true;
            this.rdbCourseInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbCourseInfo.Location = new System.Drawing.Point(229, 82);
            this.rdbCourseInfo.Name = "rdbCourseInfo";
            this.rdbCourseInfo.Size = new System.Drawing.Size(122, 23);
            this.rdbCourseInfo.TabIndex = 0;
            this.rdbCourseInfo.TabStop = true;
            this.rdbCourseInfo.Text = "课程信息表";
            this.rdbCourseInfo.UseVisualStyleBackColor = true;
            this.rdbCourseInfo.Click += new System.EventHandler(this.rdbCourseInfo_Click);
            // 
            // rdbPrintTeacherInfo
            // 
            this.rdbPrintTeacherInfo.AutoSize = true;
            this.rdbPrintTeacherInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintTeacherInfo.Location = new System.Drawing.Point(49, 157);
            this.rdbPrintTeacherInfo.Name = "rdbPrintTeacherInfo";
            this.rdbPrintTeacherInfo.Size = new System.Drawing.Size(122, 23);
            this.rdbPrintTeacherInfo.TabIndex = 0;
            this.rdbPrintTeacherInfo.TabStop = true;
            this.rdbPrintTeacherInfo.Text = "教师信息表";
            this.rdbPrintTeacherInfo.UseVisualStyleBackColor = true;
            this.rdbPrintTeacherInfo.Click += new System.EventHandler(this.rdbPrintTeacherInfo_Click);
            // 
            // rdbPrintStudentInfo
            // 
            this.rdbPrintStudentInfo.AutoSize = true;
            this.rdbPrintStudentInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintStudentInfo.Location = new System.Drawing.Point(49, 119);
            this.rdbPrintStudentInfo.Name = "rdbPrintStudentInfo";
            this.rdbPrintStudentInfo.Size = new System.Drawing.Size(122, 23);
            this.rdbPrintStudentInfo.TabIndex = 0;
            this.rdbPrintStudentInfo.TabStop = true;
            this.rdbPrintStudentInfo.Text = "学生信息表";
            this.rdbPrintStudentInfo.UseVisualStyleBackColor = true;
            this.rdbPrintStudentInfo.Click += new System.EventHandler(this.rdbPrintStudentInfo_Click);
            // 
            // rdbPrintManager
            // 
            this.rdbPrintManager.AutoSize = true;
            this.rdbPrintManager.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintManager.Location = new System.Drawing.Point(49, 82);
            this.rdbPrintManager.Name = "rdbPrintManager";
            this.rdbPrintManager.Size = new System.Drawing.Size(141, 23);
            this.rdbPrintManager.TabIndex = 0;
            this.rdbPrintManager.TabStop = true;
            this.rdbPrintManager.Text = "管理员信息表";
            this.rdbPrintManager.UseVisualStyleBackColor = true;
            this.rdbPrintManager.Click += new System.EventHandler(this.rdbPrintManager_Click);
            // 
            // gpbAction
            // 
            this.gpbAction.Controls.Add(this.btnExportText);
            this.gpbAction.Controls.Add(this.btnExit);
            this.gpbAction.Controls.Add(this.btnExportExcel);
            this.gpbAction.Location = new System.Drawing.Point(493, 21);
            this.gpbAction.Name = "gpbAction";
            this.gpbAction.Size = new System.Drawing.Size(155, 205);
            this.gpbAction.TabIndex = 1;
            this.gpbAction.TabStop = false;
            this.gpbAction.Text = "执行操作:";
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(6, 94);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(130, 23);
            this.btnExportText.TabIndex = 5;
            this.btnExportText.Text = "导出为TXT文本格式";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(6, 34);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 23);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "导出为EXCEL表格格式";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // gpbInfor
            // 
            this.gpbInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInfor.Controls.Add(this.dataGridView1);
            this.gpbInfor.Location = new System.Drawing.Point(37, 249);
            this.gpbInfor.Name = "gpbInfor";
            this.gpbInfor.Size = new System.Drawing.Size(685, 240);
            this.gpbInfor.TabIndex = 2;
            this.gpbInfor.TabStop = false;
            this.gpbInfor.Text = "数据表信息：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(664, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // Printer
            // 
            this.Printer.BackColor = System.Drawing.Color.SkyBlue;
            this.Printer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Printer.BackgroundImage")));
            this.Printer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printer.Location = new System.Drawing.Point(654, 156);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(48, 48);
            this.Printer.TabIndex = 11;
            this.Printer.UseVisualStyleBackColor = false;
            // 
            // DataPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 499);
            this.Controls.Add(this.Printer);
            this.Controls.Add(this.gpbInfor);
            this.Controls.Add(this.gpbAction);
            this.Controls.Add(this.gpbChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(674, 500);
            this.Name = "DataPrint";
            this.Text = "数据表导出与打印";
            this.Load += new System.EventHandler(this.DataPrint_Load);
            this.gpbChoice.ResumeLayout(false);
            this.gpbChoice.PerformLayout();
            this.gpbAction.ResumeLayout(false);
            this.gpbInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbChoice;
        private System.Windows.Forms.GroupBox gpbAction;
        private System.Windows.Forms.RadioButton rdbPrintTeacherInfo;
        private System.Windows.Forms.RadioButton rdbPrintStudentInfo;
        private System.Windows.Forms.RadioButton rdbPrintManager;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.GroupBox gpbInfor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Printer;
        private System.Windows.Forms.RadioButton rdbClassScore;
        private System.Windows.Forms.RadioButton rdbStuScore;
        private System.Windows.Forms.RadioButton rdbCourseInfo;
        private System.Windows.Forms.RadioButton rdbSchInfo;
    }
}