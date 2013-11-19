namespace UI
{
    partial class frmVipAllInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVipAllInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbSchInfo = new System.Windows.Forms.RadioButton();
            this.gpbInfor = new System.Windows.Forms.GroupBox();
            this.rdbWebCommetn = new System.Windows.Forms.RadioButton();
            this.gpbChoice = new System.Windows.Forms.GroupBox();
            this.rdbTeachingInfo = new System.Windows.Forms.RadioButton();
            this.rdbLoginUserInfo = new System.Windows.Forms.RadioButton();
            this.rdbClassInofo = new System.Windows.Forms.RadioButton();
            this.rdbProfession = new System.Windows.Forms.RadioButton();
            this.rdbDeptInfo = new System.Windows.Forms.RadioButton();
            this.rdbStuWebEval = new System.Windows.Forms.RadioButton();
            this.rdbCourseInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintTeacherInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintStudentInfo = new System.Windows.Forms.RadioButton();
            this.rdbPrintManager = new System.Windows.Forms.RadioButton();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExportText = new System.Windows.Forms.Button();
            this.Printer = new System.Windows.Forms.Button();
            this.gpbAction = new System.Windows.Forms.GroupBox();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbInfor.SuspendLayout();
            this.gpbChoice.SuspendLayout();
            this.gpbAction.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdbSchInfo
            // 
            this.rdbSchInfo.AutoSize = true;
            this.rdbSchInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbSchInfo.Location = new System.Drawing.Point(49, 40);
            this.rdbSchInfo.Name = "rdbSchInfo";
            this.rdbSchInfo.Size = new System.Drawing.Size(111, 20);
            this.rdbSchInfo.TabIndex = 2;
            this.rdbSchInfo.TabStop = true;
            this.rdbSchInfo.Text = "校区信息表";
            this.rdbSchInfo.UseVisualStyleBackColor = true;
            this.rdbSchInfo.Click += new System.EventHandler(this.rdbSchInfo_Click);
            // 
            // gpbInfor
            // 
            this.gpbInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInfor.Controls.Add(this.dataGridView1);
            this.gpbInfor.Location = new System.Drawing.Point(79, 294);
            this.gpbInfor.Name = "gpbInfor";
            this.gpbInfor.Size = new System.Drawing.Size(1132, 320);
            this.gpbInfor.TabIndex = 14;
            this.gpbInfor.TabStop = false;
            this.gpbInfor.Text = "数据表信息：";
            // 
            // rdbWebCommetn
            // 
            this.rdbWebCommetn.AutoSize = true;
            this.rdbWebCommetn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbWebCommetn.Location = new System.Drawing.Point(544, 169);
            this.rdbWebCommetn.Name = "rdbWebCommetn";
            this.rdbWebCommetn.Size = new System.Drawing.Size(128, 20);
            this.rdbWebCommetn.TabIndex = 1;
            this.rdbWebCommetn.TabStop = true;
            this.rdbWebCommetn.Text = "网上留言情况";
            this.rdbWebCommetn.UseVisualStyleBackColor = true;
            this.rdbWebCommetn.Click += new System.EventHandler(this.rdbWebCommetn_Click);
            // 
            // gpbChoice
            // 
            this.gpbChoice.Controls.Add(this.rdbTeachingInfo);
            this.gpbChoice.Controls.Add(this.rdbLoginUserInfo);
            this.gpbChoice.Controls.Add(this.rdbClassInofo);
            this.gpbChoice.Controls.Add(this.rdbProfession);
            this.gpbChoice.Controls.Add(this.rdbDeptInfo);
            this.gpbChoice.Controls.Add(this.rdbSchInfo);
            this.gpbChoice.Controls.Add(this.rdbStuWebEval);
            this.gpbChoice.Controls.Add(this.rdbWebCommetn);
            this.gpbChoice.Controls.Add(this.rdbCourseInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintTeacherInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintStudentInfo);
            this.gpbChoice.Controls.Add(this.rdbPrintManager);
            this.gpbChoice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbChoice.Location = new System.Drawing.Point(77, 33);
            this.gpbChoice.Name = "gpbChoice";
            this.gpbChoice.Size = new System.Drawing.Size(778, 216);
            this.gpbChoice.TabIndex = 12;
            this.gpbChoice.TabStop = false;
            this.gpbChoice.Text = "选择要查看的内容:";
            // 
            // rdbTeachingInfo
            // 
            this.rdbTeachingInfo.AutoSize = true;
            this.rdbTeachingInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbTeachingInfo.Location = new System.Drawing.Point(544, 82);
            this.rdbTeachingInfo.Name = "rdbTeachingInfo";
            this.rdbTeachingInfo.Size = new System.Drawing.Size(128, 20);
            this.rdbTeachingInfo.TabIndex = 4;
            this.rdbTeachingInfo.TabStop = true;
            this.rdbTeachingInfo.Text = "授课信息表：";
            this.rdbTeachingInfo.UseVisualStyleBackColor = true;
            this.rdbTeachingInfo.Click += new System.EventHandler(this.rdbTeachingInfo_Click);
            // 
            // rdbLoginUserInfo
            // 
            this.rdbLoginUserInfo.AutoSize = true;
            this.rdbLoginUserInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbLoginUserInfo.Location = new System.Drawing.Point(270, 169);
            this.rdbLoginUserInfo.Name = "rdbLoginUserInfo";
            this.rdbLoginUserInfo.Size = new System.Drawing.Size(145, 20);
            this.rdbLoginUserInfo.TabIndex = 3;
            this.rdbLoginUserInfo.TabStop = true;
            this.rdbLoginUserInfo.Text = "登录用户信息表";
            this.rdbLoginUserInfo.UseVisualStyleBackColor = true;
            this.rdbLoginUserInfo.Click += new System.EventHandler(this.rdbLoginUserInfo_Click);
            // 
            // rdbClassInofo
            // 
            this.rdbClassInofo.AutoSize = true;
            this.rdbClassInofo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClassInofo.Location = new System.Drawing.Point(49, 169);
            this.rdbClassInofo.Name = "rdbClassInofo";
            this.rdbClassInofo.Size = new System.Drawing.Size(111, 20);
            this.rdbClassInofo.TabIndex = 2;
            this.rdbClassInofo.TabStop = true;
            this.rdbClassInofo.Text = "班级信息表";
            this.rdbClassInofo.UseVisualStyleBackColor = true;
            this.rdbClassInofo.Click += new System.EventHandler(this.rdbClassInofo_Click);
            // 
            // rdbProfession
            // 
            this.rdbProfession.AutoSize = true;
            this.rdbProfession.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbProfession.Location = new System.Drawing.Point(49, 124);
            this.rdbProfession.Name = "rdbProfession";
            this.rdbProfession.Size = new System.Drawing.Size(111, 20);
            this.rdbProfession.TabIndex = 2;
            this.rdbProfession.TabStop = true;
            this.rdbProfession.Text = "专业信息表";
            this.rdbProfession.UseVisualStyleBackColor = true;
            this.rdbProfession.Click += new System.EventHandler(this.rdbProfession_Click);
            // 
            // rdbDeptInfo
            // 
            this.rdbDeptInfo.AutoSize = true;
            this.rdbDeptInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbDeptInfo.Location = new System.Drawing.Point(49, 82);
            this.rdbDeptInfo.Name = "rdbDeptInfo";
            this.rdbDeptInfo.Size = new System.Drawing.Size(111, 20);
            this.rdbDeptInfo.TabIndex = 2;
            this.rdbDeptInfo.TabStop = true;
            this.rdbDeptInfo.Text = "系部信息表";
            this.rdbDeptInfo.UseVisualStyleBackColor = true;
            this.rdbDeptInfo.Click += new System.EventHandler(this.rdbDeptInfo_Click);
            // 
            // rdbStuWebEval
            // 
            this.rdbStuWebEval.AutoSize = true;
            this.rdbStuWebEval.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbStuWebEval.Location = new System.Drawing.Point(544, 124);
            this.rdbStuWebEval.Name = "rdbStuWebEval";
            this.rdbStuWebEval.Size = new System.Drawing.Size(128, 20);
            this.rdbStuWebEval.TabIndex = 1;
            this.rdbStuWebEval.TabStop = true;
            this.rdbStuWebEval.Text = "网上评教情况";
            this.rdbStuWebEval.UseVisualStyleBackColor = true;
            this.rdbStuWebEval.Click += new System.EventHandler(this.rdbStuWebEval_Click);
            // 
            // rdbCourseInfo
            // 
            this.rdbCourseInfo.AutoSize = true;
            this.rdbCourseInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbCourseInfo.Location = new System.Drawing.Point(544, 40);
            this.rdbCourseInfo.Name = "rdbCourseInfo";
            this.rdbCourseInfo.Size = new System.Drawing.Size(111, 20);
            this.rdbCourseInfo.TabIndex = 0;
            this.rdbCourseInfo.TabStop = true;
            this.rdbCourseInfo.Text = "课程信息表";
            this.rdbCourseInfo.UseVisualStyleBackColor = true;
            this.rdbCourseInfo.Click += new System.EventHandler(this.rdbCourseInfo_Click);
            // 
            // rdbPrintTeacherInfo
            // 
            this.rdbPrintTeacherInfo.AutoSize = true;
            this.rdbPrintTeacherInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintTeacherInfo.Location = new System.Drawing.Point(270, 82);
            this.rdbPrintTeacherInfo.Name = "rdbPrintTeacherInfo";
            this.rdbPrintTeacherInfo.Size = new System.Drawing.Size(111, 20);
            this.rdbPrintTeacherInfo.TabIndex = 0;
            this.rdbPrintTeacherInfo.TabStop = true;
            this.rdbPrintTeacherInfo.Text = "教师信息表";
            this.rdbPrintTeacherInfo.UseVisualStyleBackColor = true;
            this.rdbPrintTeacherInfo.Click += new System.EventHandler(this.rdbPrintTeacherInfo_Click);
            // 
            // rdbPrintStudentInfo
            // 
            this.rdbPrintStudentInfo.AutoSize = true;
            this.rdbPrintStudentInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintStudentInfo.Location = new System.Drawing.Point(270, 124);
            this.rdbPrintStudentInfo.Name = "rdbPrintStudentInfo";
            this.rdbPrintStudentInfo.Size = new System.Drawing.Size(111, 20);
            this.rdbPrintStudentInfo.TabIndex = 0;
            this.rdbPrintStudentInfo.TabStop = true;
            this.rdbPrintStudentInfo.Text = "学生信息表";
            this.rdbPrintStudentInfo.UseVisualStyleBackColor = true;
            
            this.rdbPrintStudentInfo.Click += new System.EventHandler(this.rdbPrintStudentInfo_Click);
            // 
            // rdbPrintManager
            // 
            this.rdbPrintManager.AutoSize = true;
            this.rdbPrintManager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbPrintManager.Location = new System.Drawing.Point(270, 38);
            this.rdbPrintManager.Name = "rdbPrintManager";
            this.rdbPrintManager.Size = new System.Drawing.Size(128, 20);
            this.rdbPrintManager.TabIndex = 0;
            this.rdbPrintManager.TabStop = true;
            this.rdbPrintManager.Text = "管理员信息表";
            this.rdbPrintManager.UseVisualStyleBackColor = true;
            this.rdbPrintManager.Click += new System.EventHandler(this.rdbPrintManager_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(62, 34);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 51);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "导出为EXCEL表格格式";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(80, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(62, 94);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(130, 42);
            this.btnExportText.TabIndex = 5;
            this.btnExportText.Text = "导出为TXT文本格式";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // Printer
            // 
            this.Printer.BackColor = System.Drawing.Color.SkyBlue;
            this.Printer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Printer.BackgroundImage")));
            this.Printer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printer.Location = new System.Drawing.Point(1144, 189);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(48, 48);
            this.Printer.TabIndex = 15;
            this.Printer.UseVisualStyleBackColor = false;
            // 
            // gpbAction
            // 
            this.gpbAction.Controls.Add(this.btnExportText);
            this.gpbAction.Controls.Add(this.btnExit);
            this.gpbAction.Controls.Add(this.btnExportExcel);
            this.gpbAction.Location = new System.Drawing.Point(875, 48);
            this.gpbAction.Name = "gpbAction";
            this.gpbAction.Size = new System.Drawing.Size(232, 201);
            this.gpbAction.TabIndex = 13;
            this.gpbAction.TabStop = false;
            this.gpbAction.Text = "执行操作:";
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChangeRole.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangeRole.Location = new System.Drawing.Point(1125, 33);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(123, 58);
            this.btnChangeRole.TabIndex = 16;
            this.btnChangeRole.Text = "切换登录身份";
            this.btnChangeRole.UseVisualStyleBackColor = false;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1305, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel1.Text = "欢迎尊敬的领导莅临教务";
            // 
            // frmVipAllInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1305, 637);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.gpbInfor);
            this.Controls.Add(this.gpbChoice);
            this.Controls.Add(this.Printer);
            this.Controls.Add(this.gpbAction);
            this.Name = "frmVipAllInfo";
            this.Text = "当前登录身份：【学院领导】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVipAllInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbInfor.ResumeLayout(false);
            this.gpbChoice.ResumeLayout(false);
            this.gpbChoice.PerformLayout();
            this.gpbAction.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbSchInfo;
        private System.Windows.Forms.GroupBox gpbInfor;
        private System.Windows.Forms.RadioButton rdbWebCommetn;
        private System.Windows.Forms.GroupBox gpbChoice;
        private System.Windows.Forms.RadioButton rdbStuWebEval;
        private System.Windows.Forms.RadioButton rdbCourseInfo;
        private System.Windows.Forms.RadioButton rdbPrintTeacherInfo;
        private System.Windows.Forms.RadioButton rdbPrintStudentInfo;
        private System.Windows.Forms.RadioButton rdbPrintManager;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button Printer;
        private System.Windows.Forms.GroupBox gpbAction;
        private System.Windows.Forms.RadioButton rdbTeachingInfo;
        private System.Windows.Forms.RadioButton rdbLoginUserInfo;
        private System.Windows.Forms.RadioButton rdbClassInofo;
        private System.Windows.Forms.RadioButton rdbProfession;
        private System.Windows.Forms.RadioButton rdbDeptInfo;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}