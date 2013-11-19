namespace UI
{
    partial class frmTeaMain
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
            this.TeaMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileResetWinForm = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.frmBaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoSchoolInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoDepartInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoProfessInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoClassInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoCourseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoTeachingInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoTeacherInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoStuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInfoScoreSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainSelCourseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TeaInputScore = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainSysMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MainDataOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpFeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeLoginRole = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SystemTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StuMenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.StuScore = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchSelCoure = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchScore = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStuSelScore = new System.Windows.Forms.ToolStripMenuItem();
            this.网上评教ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网上留言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLoginUserId = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TeaMenuStrip1.SuspendLayout();
            this.StuMenuStrip2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeaMenuStrip1
            // 
            this.TeaMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmMainFile,
            this.frmBaseInfo,
            this.frmMainSelCourseManage,
            this.frmMainSysMain,
            this.frmMainHelp,
            this.btnChangeLoginRole});
            this.TeaMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.TeaMenuStrip1.Name = "TeaMenuStrip1";
            this.TeaMenuStrip1.Size = new System.Drawing.Size(1034, 25);
            this.TeaMenuStrip1.TabIndex = 0;
            this.TeaMenuStrip1.Text = "menuStrip1";
            // 
            // frmMainFile
            // 
            this.frmMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileSave,
            this.FileResetWinForm,
            this.FileExit});
            this.frmMainFile.Name = "frmMainFile";
            this.frmMainFile.Size = new System.Drawing.Size(58, 21);
            this.frmMainFile.Text = "文件(&F)";
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(140, 22);
            this.FileOpen.Text = "打开(&O)";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(140, 22);
            this.FileSave.Text = "保存(&S)";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileResetWinForm
            // 
            this.FileResetWinForm.Name = "FileResetWinForm";
            this.FileResetWinForm.Size = new System.Drawing.Size(140, 22);
            this.FileResetWinForm.Text = "重启窗口(&R)";
            this.FileResetWinForm.Click += new System.EventHandler(this.FileResetWinForm_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(140, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // frmBaseInfo
            // 
            this.frmBaseInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseInfoSchoolInfo,
            this.BaseInfoDepartInfo,
            this.BaseInfoProfessInfo,
            this.BaseInfoClassInfo,
            this.BaseInfoCourseInfo,
            this.BaseInfoTeachingInfo,
            this.BaseInfoTeacherInfo,
            this.BaseInfoStuInfo,
            this.BaseInfoScoreSearch});
            this.frmBaseInfo.Name = "frmBaseInfo";
            this.frmBaseInfo.Size = new System.Drawing.Size(80, 21);
            this.frmBaseInfo.Text = "基本信息(&I)";
            // 
            // BaseInfoSchoolInfo
            // 
            this.BaseInfoSchoolInfo.Name = "BaseInfoSchoolInfo";
            this.BaseInfoSchoolInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoSchoolInfo.Text = "校区信息(&S)";
            this.BaseInfoSchoolInfo.Click += new System.EventHandler(this.BaseInfoSchoolInfo_Click);
            // 
            // BaseInfoDepartInfo
            // 
            this.BaseInfoDepartInfo.Name = "BaseInfoDepartInfo";
            this.BaseInfoDepartInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoDepartInfo.Text = "系部信息(&D)";
            this.BaseInfoDepartInfo.Click += new System.EventHandler(this.BaseInfoDepartInfo_Click);
            // 
            // BaseInfoProfessInfo
            // 
            this.BaseInfoProfessInfo.Name = "BaseInfoProfessInfo";
            this.BaseInfoProfessInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoProfessInfo.Text = "专业信息(&P)";
            this.BaseInfoProfessInfo.Click += new System.EventHandler(this.BaseInfoProfessInfo_Click);
            // 
            // BaseInfoClassInfo
            // 
            this.BaseInfoClassInfo.Name = "BaseInfoClassInfo";
            this.BaseInfoClassInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoClassInfo.Text = "班级信息(&C)";
            this.BaseInfoClassInfo.Click += new System.EventHandler(this.BaseInfoClassInfo_Click);
            // 
            // BaseInfoCourseInfo
            // 
            this.BaseInfoCourseInfo.Name = "BaseInfoCourseInfo";
            this.BaseInfoCourseInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoCourseInfo.Text = "课程信息(&C)";
            this.BaseInfoCourseInfo.Click += new System.EventHandler(this.BaseInfoCourseInfo_Click);
            // 
            // BaseInfoTeachingInfo
            // 
            this.BaseInfoTeachingInfo.Name = "BaseInfoTeachingInfo";
            this.BaseInfoTeachingInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoTeachingInfo.Text = "授课信息(C)";
            this.BaseInfoTeachingInfo.Click += new System.EventHandler(this.BaseInfoTeachingInfo_Click);
            // 
            // BaseInfoTeacherInfo
            // 
            this.BaseInfoTeacherInfo.Name = "BaseInfoTeacherInfo";
            this.BaseInfoTeacherInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoTeacherInfo.Text = "教师信息(&T)";
            this.BaseInfoTeacherInfo.Click += new System.EventHandler(this.BaseInfoTeacherInfo_Click);
            // 
            // BaseInfoStuInfo
            // 
            this.BaseInfoStuInfo.Name = "BaseInfoStuInfo";
            this.BaseInfoStuInfo.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoStuInfo.Text = "学生信息(&S)";
            this.BaseInfoStuInfo.Click += new System.EventHandler(this.BaseInfoStuInfo_Click);
            // 
            // BaseInfoScoreSearch
            // 
            this.BaseInfoScoreSearch.Name = "BaseInfoScoreSearch";
            this.BaseInfoScoreSearch.Size = new System.Drawing.Size(141, 22);
            this.BaseInfoScoreSearch.Text = "成绩查询(&S)";
            this.BaseInfoScoreSearch.Click += new System.EventHandler(this.BaseInfoStuScoreSearch_Click);
            // 
            // frmMainSelCourseManage
            // 
            this.frmMainSelCourseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeaInputScore});
            this.frmMainSelCourseManage.Name = "frmMainSelCourseManage";
            this.frmMainSelCourseManage.Size = new System.Drawing.Size(88, 21);
            this.frmMainSelCourseManage.Text = "选课管理(&M)";
            // 
            // TeaInputScore
            // 
            this.TeaInputScore.Name = "TeaInputScore";
            this.TeaInputScore.Size = new System.Drawing.Size(136, 22);
            this.TeaInputScore.Text = "成绩录入(&I)";
            this.TeaInputScore.Click += new System.EventHandler(this.TeaInputScore_Click);
            // 
            // frmMainSysMain
            // 
            this.frmMainSysMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainDataOutput});
            this.frmMainSysMain.Name = "frmMainSysMain";
            this.frmMainSysMain.Size = new System.Drawing.Size(83, 21);
            this.frmMainSysMain.Text = "数据打印(&S)";
            // 
            // MainDataOutput
            // 
            this.MainDataOutput.Name = "MainDataOutput";
            this.MainDataOutput.Size = new System.Drawing.Size(124, 22);
            this.MainDataOutput.Text = "数据输出";
            this.MainDataOutput.Click += new System.EventHandler(this.MainDataOutput_Click);
            // 
            // frmMainHelp
            // 
            this.frmMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpInstructions,
            this.HelpAbout,
            this.HelpFeedBack,
            this.HelpCheckUpdate});
            this.frmMainHelp.Name = "frmMainHelp";
            this.frmMainHelp.Size = new System.Drawing.Size(61, 21);
            this.frmMainHelp.Text = "帮助(&H)";
            // 
            // HelpInstructions
            // 
            this.HelpInstructions.Name = "HelpInstructions";
            this.HelpInstructions.Size = new System.Drawing.Size(141, 22);
            this.HelpInstructions.Text = "使用说明(&U)";
            this.HelpInstructions.Click += new System.EventHandler(this.HelpInstructions_Click);
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(141, 22);
            this.HelpAbout.Text = "关于(&A)";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // HelpFeedBack
            // 
            this.HelpFeedBack.Name = "HelpFeedBack";
            this.HelpFeedBack.Size = new System.Drawing.Size(141, 22);
            this.HelpFeedBack.Text = "反馈(&K)";
            this.HelpFeedBack.Click += new System.EventHandler(this.HelpFeedBack_Click);
            // 
            // HelpCheckUpdate
            // 
            this.HelpCheckUpdate.Name = "HelpCheckUpdate";
            this.HelpCheckUpdate.Size = new System.Drawing.Size(141, 22);
            this.HelpCheckUpdate.Text = "检查更新(&U)";
            // 
            // btnChangeLoginRole
            // 
            this.btnChangeLoginRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeLoginRole.Name = "btnChangeLoginRole";
            this.btnChangeLoginRole.Size = new System.Drawing.Size(92, 21);
            this.btnChangeLoginRole.Text = "切换登录身份";
            this.btnChangeLoginRole.Click += new System.EventHandler(this.btnChangeLoginRole_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(40, 738);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(131, 12);
            this.lbWelcome.TabIndex = 11;
            this.lbWelcome.Text = "欢迎使用学生管理系统!";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(760, 740);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(95, 12);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "系统当前时间为:";
            // 
            // SystemTime
            // 
            this.SystemTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SystemTime.AutoSize = true;
            this.SystemTime.Location = new System.Drawing.Point(862, 739);
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.Size = new System.Drawing.Size(65, 12);
            this.SystemTime.TabIndex = 9;
            this.SystemTime.Text = "SystemTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StuMenuStrip2
            // 
            this.StuMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuScore,
            this.MenuStuSelScore,
            this.网上评教ToolStripMenuItem,
            this.网上留言ToolStripMenuItem});
            this.StuMenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.StuMenuStrip2.Name = "StuMenuStrip2";
            this.StuMenuStrip2.Size = new System.Drawing.Size(1034, 25);
            this.StuMenuStrip2.TabIndex = 13;
            this.StuMenuStrip2.Text = "menuStrip2";
            this.StuMenuStrip2.Visible = false;
            // 
            // StuScore
            // 
            this.StuScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuSearchCourse,
            this.StuSearchSelCoure,
            this.StuSearchScore,
            this.StuSearchInfo});
            this.StuScore.Name = "StuScore";
            this.StuScore.Size = new System.Drawing.Size(68, 21);
            this.StuScore.Text = "查询服务";
            // 
            // StuSearchCourse
            // 
            this.StuSearchCourse.Name = "StuSearchCourse";
            this.StuSearchCourse.Size = new System.Drawing.Size(124, 22);
            this.StuSearchCourse.Text = "课程表";
            this.StuSearchCourse.Click += new System.EventHandler(this.StuSearchCourse_Click);
            // 
            // StuSearchSelCoure
            // 
            this.StuSearchSelCoure.Name = "StuSearchSelCoure";
            this.StuSearchSelCoure.Size = new System.Drawing.Size(124, 22);
            this.StuSearchSelCoure.Text = "选课表";
            this.StuSearchSelCoure.Click += new System.EventHandler(this.StuSearchSelCoure_Click);
            // 
            // StuSearchScore
            // 
            this.StuSearchScore.Name = "StuSearchScore";
            this.StuSearchScore.Size = new System.Drawing.Size(124, 22);
            this.StuSearchScore.Text = "成绩信息";
            this.StuSearchScore.Click += new System.EventHandler(this.StuSearchScore_Click);
            // 
            // StuSearchInfo
            // 
            this.StuSearchInfo.Name = "StuSearchInfo";
            this.StuSearchInfo.Size = new System.Drawing.Size(124, 22);
            this.StuSearchInfo.Text = "个人信息";
            this.StuSearchInfo.Click += new System.EventHandler(this.StuSearchInfo_Click);
            // 
            // MenuStuSelScore
            // 
            this.MenuStuSelScore.Name = "MenuStuSelScore";
            this.MenuStuSelScore.Size = new System.Drawing.Size(44, 21);
            this.MenuStuSelScore.Text = "选课";
            this.MenuStuSelScore.Click += new System.EventHandler(this.MenuStuSelScore_Click);
            // 
            // 网上评教ToolStripMenuItem
            // 
            this.网上评教ToolStripMenuItem.Name = "网上评教ToolStripMenuItem";
            this.网上评教ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.网上评教ToolStripMenuItem.Text = "网上评教";
            // 
            // 网上留言ToolStripMenuItem
            // 
            this.网上留言ToolStripMenuItem.Name = "网上留言ToolStripMenuItem";
            this.网上留言ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.网上留言ToolStripMenuItem.Text = "网上留言";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWelcome,
            this.toolLoginUserId});
            this.statusStrip2.Location = new System.Drawing.Point(0, 728);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip2.TabIndex = 19;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolWelcome
            // 
            this.toolWelcome.Name = "toolWelcome";
            this.toolWelcome.Size = new System.Drawing.Size(85, 17);
            this.toolWelcome.Text = "toolWelcome";
            // 
            // toolLoginUserId
            // 
            this.toolLoginUserId.Name = "toolLoginUserId";
            this.toolLoginUserId.Size = new System.Drawing.Size(102, 17);
            this.toolLoginUserId.Text = "toolLoginUserId";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 733);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "系统当前时间为:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 733);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            // 
            // frmTeaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.SystemTime);
            this.Controls.Add(this.TeaMenuStrip1);
            this.Controls.Add(this.StuMenuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.TeaMenuStrip1;
            this.Name = "frmTeaMain";
            this.Text = "《简易教务管理系统》_Beta_【测试版】_【登录身份：教师】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeaMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.TeaMenuStrip1.ResumeLayout(false);
            this.TeaMenuStrip1.PerformLayout();
            this.StuMenuStrip2.ResumeLayout(false);
            this.StuMenuStrip2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TeaMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmMainFile;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileResetWinForm;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem frmBaseInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoSchoolInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoDepartInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoProfessInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoClassInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoCourseInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoTeachingInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoTeacherInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoStuInfo;
        private System.Windows.Forms.ToolStripMenuItem BaseInfoScoreSearch;
        private System.Windows.Forms.ToolStripMenuItem frmMainSelCourseManage;
        private System.Windows.Forms.ToolStripMenuItem TeaInputScore;
        private System.Windows.Forms.ToolStripMenuItem frmMainSysMain;
        private System.Windows.Forms.ToolStripMenuItem frmMainHelp;
        private System.Windows.Forms.ToolStripMenuItem HelpInstructions;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStripMenuItem HelpFeedBack;
        private System.Windows.Forms.ToolStripMenuItem HelpCheckUpdate;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label SystemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MainDataOutput;
        private System.Windows.Forms.MenuStrip StuMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem StuScore;
        private System.Windows.Forms.ToolStripMenuItem StuSearchCourse;
        private System.Windows.Forms.ToolStripMenuItem StuSearchSelCoure;
        private System.Windows.Forms.ToolStripMenuItem StuSearchScore;
        private System.Windows.Forms.ToolStripMenuItem StuSearchInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuStuSelScore;
        private System.Windows.Forms.ToolStripMenuItem 网上评教ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网上留言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChangeLoginRole;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolWelcome;
        private System.Windows.Forms.ToolStripStatusLabel toolLoginUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}