namespace UI
{
    partial class frmStuMain
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
            this.StuMenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.StuScore = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchSelCoure = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchScore = new System.Windows.Forms.ToolStripMenuItem();
            this.StuSearchInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStuSelScore = new System.Windows.Forms.ToolStripMenuItem();
            this.StuWebEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.frmStuWebCommetn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeLoginRole = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpFeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLoginUserId = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTime = new System.Windows.Forms.Label();
            this.SystemTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StuMenuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuMenuStrip2
            // 
            this.StuMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuScore,
            this.MenuStuSelScore,
            this.StuWebEvaluation,
            this.frmStuWebCommetn,
            this.btnChangeLoginRole,
            this.frmMainHelp});
            this.StuMenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.StuMenuStrip2.Name = "StuMenuStrip2";
            this.StuMenuStrip2.Size = new System.Drawing.Size(976, 25);
            this.StuMenuStrip2.TabIndex = 14;
            this.StuMenuStrip2.Text = "menuStrip2";
            // 
            // StuScore
            // 
            this.StuScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuSearchSelCoure,
            this.StuSearchScore,
            this.StuSearchInfo,
            this.btnExit});
            this.StuScore.Name = "StuScore";
            this.StuScore.Size = new System.Drawing.Size(68, 21);
            this.StuScore.Text = "查询服务";
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
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 22);
            this.btnExit.Text = "退出(&E)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MenuStuSelScore
            // 
            this.MenuStuSelScore.Name = "MenuStuSelScore";
            this.MenuStuSelScore.Size = new System.Drawing.Size(44, 21);
            this.MenuStuSelScore.Text = "选课";
            this.MenuStuSelScore.Click += new System.EventHandler(this.MenuStuSelScore_Click);
            // 
            // StuWebEvaluation
            // 
            this.StuWebEvaluation.Name = "StuWebEvaluation";
            this.StuWebEvaluation.Size = new System.Drawing.Size(68, 21);
            this.StuWebEvaluation.Text = "网上评教";
            this.StuWebEvaluation.Click += new System.EventHandler(this.StuWebEvaluation_Click);
            // 
            // frmStuWebCommetn
            // 
            this.frmStuWebCommetn.Name = "frmStuWebCommetn";
            this.frmStuWebCommetn.Size = new System.Drawing.Size(68, 21);
            this.frmStuWebCommetn.Text = "网上留言";
            this.frmStuWebCommetn.Click += new System.EventHandler(this.frmStuWebCommetn_Click);
            // 
            // btnChangeLoginRole
            // 
            this.btnChangeLoginRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangeLoginRole.Name = "btnChangeLoginRole";
            this.btnChangeLoginRole.Size = new System.Drawing.Size(92, 21);
            this.btnChangeLoginRole.Text = "切换登录身份";
            this.btnChangeLoginRole.Click += new System.EventHandler(this.btnChangeLoginRole_Click);
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
            this.HelpCheckUpdate.Click += new System.EventHandler(this.HelpCheckUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWelcome,
            this.toolLoginUserId});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
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
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(650, 522);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(95, 12);
            this.lbTime.TabIndex = 18;
            this.lbTime.Text = "系统当前时间为:";
            // 
            // SystemTime
            // 
            this.SystemTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SystemTime.AutoSize = true;
            this.SystemTime.Location = new System.Drawing.Point(766, 522);
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.Size = new System.Drawing.Size(65, 12);
            this.SystemTime.TabIndex = 17;
            this.SystemTime.Text = "SystemTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmStuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 539);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.SystemTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StuMenuStrip2);
            this.IsMdiContainer = true;
            this.Name = "frmStuMain";
            this.Text = "《简易教务管理系统》_Beta_【测试版】_【登录身份：学生】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStuMain_FormClosing);
            this.Load += new System.EventHandler(this.frmStuMain_Load);
            this.StuMenuStrip2.ResumeLayout(false);
            this.StuMenuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StuMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem StuScore;
        private System.Windows.Forms.ToolStripMenuItem StuSearchSelCoure;
        private System.Windows.Forms.ToolStripMenuItem StuSearchScore;
        private System.Windows.Forms.ToolStripMenuItem StuSearchInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuStuSelScore;
        private System.Windows.Forms.ToolStripMenuItem StuWebEvaluation;
        private System.Windows.Forms.ToolStripMenuItem frmStuWebCommetn;
        private System.Windows.Forms.ToolStripMenuItem btnChangeLoginRole;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label SystemTime;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripStatusLabel toolWelcome;
        private System.Windows.Forms.ToolStripStatusLabel toolLoginUserId;
        private System.Windows.Forms.ToolStripMenuItem frmMainHelp;
        private System.Windows.Forms.ToolStripMenuItem HelpInstructions;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStripMenuItem HelpFeedBack;
        private System.Windows.Forms.ToolStripMenuItem HelpCheckUpdate;
        private System.Windows.Forms.Timer timer1;
    }
}