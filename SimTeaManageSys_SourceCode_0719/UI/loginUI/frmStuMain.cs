using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class frmStuMain : CentralUse
    {
        public frmStuMain()
        {
            InitializeComponent();
        }

        SqlDataReader SqlRead;
        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();

        private void btnChangeLoginRole_Click(object sender, EventArgs e)
        {
            LoginUI objLoginUI = new LoginUI();
            objLoginUI.Show();
            //this.Close();
            this.Hide();

            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();
            objLoginUserModel.UserId = toolLoginUserId.Text;
            objLoginUIBLL.UpdateLoginUserStateClose();
        }

       

        public void frmStuMain_Load(object sender, EventArgs e)
        {
            toolWelcome.Text = "欢迎登录教务系统！当前登录身份【学生】";

            //LoginUI objLoginUI = new LoginUI();

            //toolLoginUserId.Text = objLoginUI.txtUid.Text;

            //this.toolLoginUserId.ForeColor = Color.DarkOrange;
            //this.Text += toolLoginUserId.Text + "  你好！";

            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read())
            {
                toolLoginUserId.Text = SqlRead["UserId"].ToString();
            }

            this.toolLoginUserId.ForeColor = Color.DarkBlue;

            toolLoginUserId.Text += "   同学，您好！欢迎登录！";

            this.Text += toolLoginUserId.Text;

            //frmStuMainStuNum();
        }

        //public string frmStuMainStuNum()
        //{
        //    string StuMainStuNum = toolLoginUserId.Text;
        //    return StuMainStuNum;
        //}


       
        
        //选课：
        private void MenuStuSelScore_Click(object sender, EventArgs e)
        {
            SelCourse objSelCourse = new SelCourse();
            objSelCourse.MdiParent = this;
            objSelCourse.Show();
        }
        
        //选课查询：
        private void StuSearchSelCoure_Click(object sender, EventArgs e)
        {
            StuCourseSearch objStuCourseSearch = new StuCourseSearch();
            objStuCourseSearch.MdiParent = this;
            objStuCourseSearch.Show();
        }

        //个人成绩查询：
        private void StuSearchScore_Click(object sender, EventArgs e)
        {
            StuScoreSearch objStuScoreSearch = new StuScoreSearch();
            objStuScoreSearch.MdiParent = this;
            objStuScoreSearch.Show();
        }
        //个人信息：
        private void StuSearchInfo_Click(object sender, EventArgs e)
        {
            StuInfo objStuInfo = new StuInfo();
            objStuInfo.MdiParent = this;
            objStuInfo.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎再次使用！");
            this.Close();
        }

        private void frmStuMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();
            objLoginUserModel.UserId = toolLoginUserId.Text;
            objLoginUIBLL.UpdateLoginUserStateClose();

            Application.Exit();


        }

        private void HelpInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("若要正常运行此应用程序，您必须首先安装.NET Framework\n有关如何获取.NET Framework 的适当版本的说明，请与应用程序发行者联系。\n可以通过安装驱动精灵来安装相关组件。\n", "使用环境", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本为公测版，欢迎提出宝贵意见！\n 仅供技术交流、探讨！\n 禁止用于商业用途！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpFeedBack_Click(object sender, EventArgs e)
        {
            frmContactAuthor about1 = new frmContactAuthor();
            about1.MdiParent = this;
            about1.Show();
        }

        private void HelpCheckUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StuWebEvaluation_Click(object sender, EventArgs e)
        {
            StuWebEvaluation objStuWebEvaluation = new StuWebEvaluation();
            objStuWebEvaluation.MdiParent = this;
            objStuWebEvaluation.Show();
            
        }

        private void frmStuWebCommetn_Click(object sender, EventArgs e)
        {
            StuWebComments objStuWebComments = new StuWebComments();
            objStuWebComments.MdiParent = this;
            objStuWebComments.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SystemTime.Text = DateTime.Now.ToString();
        }
    }
}
