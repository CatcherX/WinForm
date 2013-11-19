using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class frmAdminMain : CentralUse
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        SqlDataReader SqlRead;



       
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            toolWec.Text = "欢迎使用简易学生管理系统！当前登录身份：【教务员】 ";
            
            //toolLoginUserId.Text = "当前登录身份：【教务员】： ";

            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read())
            { 
                //toolLoginUserId.Text=SqlRead["UserId"].ToString();
                toolUserId.Text = SqlRead["UserId"].ToString();
            }

            toolUserId.Text += "   教务员，您好！欢迎使用！";
            this.toolUserId.ForeColor = Color.Blue;
            this.Text += toolUserId.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  SysTime.Text = DateTime.Now.ToString();
        }

      #region 信息录入：

        private void AdminSchInfoInput_Click(object sender, EventArgs e)
        {
            SchoolInfo objSchoolInfo = new SchoolInfo();
            objSchoolInfo.MdiParent = this;
            objSchoolInfo.Show();
        }

        private void AdminDeptInfoInput_Click(object sender, EventArgs e)
        {
            DepartmentInfo objDepartmentInfo = new DepartmentInfo();
            objDepartmentInfo.MdiParent = this;
            objDepartmentInfo.Show();
        }

        private void AdminProInfoInput_Click(object sender, EventArgs e)
        {
            ProfessionInfo objProfessionInfo = new ProfessionInfo();
            objProfessionInfo.MdiParent = this;
            objProfessionInfo.Show();
        }

        private void AdminClassInfoInput_Click(object sender, EventArgs e)
        {
            ClassInfo objClassInfo = new ClassInfo();
            objClassInfo.MdiParent = this;
            objClassInfo.Show();
        }


        private void StuInfoInPut_Click(object sender, EventArgs e)
        {
            StudentInfo objStudentInfo = new StudentInfo();
            objStudentInfo.MdiParent = this;
            objStudentInfo.Show();
        }

        private void CourseInfoInput_Click(object sender, EventArgs e)
        {
            CourseInfo objCourseInfo = new CourseInfo();
            objCourseInfo.MdiParent = this;
            objCourseInfo.Show();
        }

        private void TeaInfoInput_Click(object sender, EventArgs e)
        {
            TeacherInfo objTeacherInfo = new TeacherInfo();
            objTeacherInfo.MdiParent = this;
            objTeacherInfo.Show();
        }

        private void WebEvalDataInput_Click(object sender, EventArgs e)
        {
            InputEvalInfo objInputEvalInfo = new InputEvalInfo();
            objInputEvalInfo.MdiParent = this;
            objInputEvalInfo.Show();
        }



        #endregion





        private void AdminExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎再次使用！");
            this.Close();
        }

        #region 系统备份
        private void DataBaseBack_Click(object sender, EventArgs e)
        {
            string Server = "Server=(Local);Initial Catalog=StuManageSystem_2008;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(Server);
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SqlConn;
                SqlConn.Open();
                command.CommandText = string.Format("use master backup database {0} to disk ='{1}'", "StuManageSystem_2008", ".\\StuManageSystem_2008.bak");

                command.ExecuteNonQuery();

                command.CommandText = string.Format("use {0}", "StuManageSystem_2008");

                command.ExecuteNonQuery();

                MessageBox.Show("备份成功！\n路径为：\nC:\\Program Files\\Microsoft SQL Server\\MSSQL10_50.MSSQLSERVER\\MSSQL\\Backup", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }
        }

        private void DataBaseRestory_Click(object sender, EventArgs e)
        {
           

            string Server = "Server=(Local);Initial Catalog=StuManageSystem_2008;Integrated Security=True";

            SqlConnection SqlConn = new SqlConnection(Server);

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SqlConn;
                SqlConn.Open();
                command.CommandText = string.Format("use master restore database {0} from disk = '{1}'", "StuManageSystem_2008", ".\\StuManageSystem_2008.bak");

                command.ExecuteNonQuery();
                command.CommandText = string.Format("use{0}", "StuManageSystem_2008");

                command.ExecuteNonQuery();
                MessageBox.Show("数据库还原成功！\n名称为：StuManageSystem_2008", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                SqlConn.Close();
                SqlConn.Dispose();
            }

        } 
        #endregion

        private void AdminSystemUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时没有升级服务！\n请关注。");
        }

        private void LoginUserInfoMange_Click(object sender, EventArgs e)
        {
            
            
        }

        #region LoginUserInfoManage

            private void frmAdminMenuAddLoginUser_Click(object sender, EventArgs e)
            {
                frmAdminMenuAddLoginUser objfrmLoginUserInfoManage = new frmAdminMenuAddLoginUser();
                objfrmLoginUserInfoManage.MdiParent = this;
                objfrmLoginUserInfoManage.Show();
            }

            private void ChangeLoginUserInfo_Click(object sender, EventArgs e)
            {
                ChangeLoginUserInfo objChangeLoginUserInfo = new ChangeLoginUserInfo();
                objChangeLoginUserInfo.MdiParent = this;
                objChangeLoginUserInfo.Show();
            }

            private void DelLoginUserInfo_Click(object sender, EventArgs e)
            {
                DelLoginUser objDelLoginUser = new DelLoginUser();
                objDelLoginUser.MdiParent = this;
                objDelLoginUser.Show();
            }

        #endregion

        private void ChangeLoginRole_Click(object sender, EventArgs e)
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

        



        //关闭前发生与关闭后发生有什么区别？
        private void frmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            //objLoginUserModel.UserId = toolLoginUserId.Text;
            //objLoginUIBLL.UpdateLoginUserStateClose();

            //if (MessageBox.Show("确定要关闭吗？确定将把整个程序关闭，无法使用切换身份功能，取消请点击否。", "温馨提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{ 
            //    //MessageBox.Show("欢迎下次使用！");
            //    Application.Exit(); 
            //}
            //else
            //{
            //    return;
            //}

        }


        private void frmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            objLoginUserModel.UserId = toolLoginUserId.Text;
            objLoginUIBLL.UpdateLoginUserStateClose();

            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
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

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();  //为什么没法生效呢？
        }

       

        
    }
}
