using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class frmTeaMain : CentralUse
    {
        public frmTeaMain()
        {
            InitializeComponent();
        }

            SqlDataReader SqlRead;
            LoginUIBLL objLoginUIBLL = new LoginUIBLL();
            LoginUserModel objLoginUserModel = new LoginUserModel();
        
            //public delegate void MenuHandle(string role);
            //public event MenuHandle Menuevent;

        #region 处理事件（根据不同的用户，调用不同的菜单控件）的方法：已注释，改到其它窗口了。
            //public void ChangeMenu(string role)
            //{
            //    if (role == "学生")
            //    {
            //        this.MainMenuStrip = StuMenuStrip2;
            //        StuMenuStrip2.Visible = true;
            //        TeaMenuStrip1.Visible = false;
            //        AdminMenuStrip1.Visible = false;
            //    }
            //    if (role == "教务员")
            //    {
            //        this.MainMenuStrip = AdminMenuStrip1;
            //        AdminMenuStrip1.Visible = true;
            //        TeaMenuStrip1.Visible = false;
            //        StuMenuStrip2.Visible = false;
            //    }
            //    if (role == "教师")
            //    {
            //        this.MainMenuStrip = TeaMenuStrip1;
            //        TeaMenuStrip1.Visible = true;
            //        StuMenuStrip2.Visible = false;
            //        AdminMenuStrip1.Visible = false;
            //    }

            //    else 
            //    {
            //        TeaMenuStrip1.Visible = false;
            //        StuMenuStrip2.Visible = false;
            //        AdminMenuStrip1.Visible = false;
            //    }

            //} 
        #endregion

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolWelcome.Text = "欢迎登录教务系统！当前登录身份【教师】";

            SqlRead = objLoginUIBLL.LoginUserRead();

            if (SqlRead.Read())
            {
                toolLoginUserId.Text = SqlRead["UserId"].ToString();
            }

            this.toolLoginUserId.ForeColor = Color.DarkCyan;

            toolLoginUserId.Text += "  老师，您好！欢迎登录教务系统！";

            this.Text += toolLoginUserId.Text;
        }

        #region 基本信息窗口：
         
                 #region 校区信息
                private void BaseInfoSchoolInfo_Click(object sender, EventArgs e)
                {
                    SchoolInfo objSchoolInfo = new SchoolInfo();
                    objSchoolInfo.MdiParent = this;
                    objSchoolInfo.Show();
                }
                #endregion

                 #region 系别信息
                private void BaseInfoDepartInfo_Click(object sender, EventArgs e)
                {

                    DepartmentInfo objDepartmentInfo = new DepartmentInfo();
                    objDepartmentInfo.MdiParent = this;
                    objDepartmentInfo.Show();
                }
                #endregion

                 #region 专业信息
            private void BaseInfoProfessInfo_Click(object sender, EventArgs e)
            {
                ProfessionInfo objProfessionInfo = new ProfessionInfo();
                objProfessionInfo.MdiParent = this;
                objProfessionInfo.Show();
            }
            #endregion

                 #region 班级信息

                    private void BaseInfoClassInfo_Click(object sender, EventArgs e)
                    {
                        ClassInfo objClassInfo = new ClassInfo();
                        objClassInfo.MdiParent = this;
                        objClassInfo.Show();
                    }
            
               #endregion

                 #region 课程信息
                private void BaseInfoCourseInfo_Click(object sender, EventArgs e)
                {
                    CourseInfo objCourseInfo = new CourseInfo();
                    objCourseInfo.MdiParent = this;
                    objCourseInfo.Show();
                }
            #endregion

                 #region 授课信息查询：
                private void BaseInfoTeachingInfo_Click(object sender, EventArgs e)
                {
                    TeachingInfo objTeachingInfo = new TeachingInfo();
                    objTeachingInfo.MdiParent = this;
                    objTeachingInfo.Show();
                } 
                #endregion

                 #region 教师信息：
            private void BaseInfoTeacherInfo_Click(object sender, EventArgs e)
            {
                TeacherInfo objTeacherInfo = new TeacherInfo();
                objTeacherInfo.MdiParent = this;
                objTeacherInfo.Show();
            }
            #endregion

                 #region 学生信息：
                    private void BaseInfoStuInfo_Click(object sender, EventArgs e)
                    {
                        StudentInfo objStudentInfo = new StudentInfo();
                        objStudentInfo.MdiParent = this;
                        objStudentInfo.Show();
                    }
                 #endregion

                 #region 成绩查询
            private void BaseInfoStuScoreSearch_Click(object sender, EventArgs e)
            {
                ClassScoreSearch objClassScoreSearch = new ClassScoreSearch();
                objClassScoreSearch.MdiParent = this;
                objClassScoreSearch.Show();
            }
            #endregion

                 
        #endregion

        #region 选课管理窗口：

            #region //学生选课:
            private void StuSelCourseSign_Click(object sender, EventArgs e)
            {
                SelCourse objSelCourse = new SelCourse();
                objSelCourse.MdiParent = this;
                objSelCourse.Show();
            } 
            #endregion

            #region 录入成绩:
            private void TeaInputScore_Click(object sender, EventArgs e)
            {
                InPutScore objInPutScore = new InPutScore();
                objInPutScore.MdiParent = this;
                objInPutScore.Show();
            }  
            #endregion

         #endregion

        #region 数据输出：

            private void MainDataOutput_Click(object sender, EventArgs e)
            {
                DataPrint objDataPrint = new DataPrint();
                objDataPrint.MdiParent = this;
                objDataPrint.Show();
            }
            
            #endregion

        #region 文件、打开、退出选项卡菜单：
            private void FileExit_Click(object sender, EventArgs e)
            {
                MessageBox.Show("欢迎再次使用！");
                this.Close();//会引发关闭事件中的Application.Exit()方法，结束整个程序。
            }

            private void FileResetWinForm_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("点击后程序将关闭所有本程序窗口并重启", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }

                    LoginUIBLL objLoginUIBLL = new LoginUIBLL();
                    LoginUserModel objLoginUserModel = new LoginUserModel();
                    objLoginUserModel.UserId = toolLoginUserId.Text;
                    objLoginUIBLL.UpdateLoginUserStateClose();

            } 
            #endregion

        #region 事件触发类代码：
            private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
            {
                MessageBox.Show("再见！欢迎再次使用！");
            } 
            #endregion
       
        #region 附件类：
                //时间控件：
                private void timer1_Tick(object sender, EventArgs e)
                {
                    //SystemTime.Text = DateTime.Now.ToString();
                    label2.Text = DateTime.Now.ToString();

                }
            #endregion

        #region 帮助菜单功能集合：
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
        #endregion

        #region 学生用户菜单：
                    private void StuSearchCourse_Click(object sender, EventArgs e)
                    {

                    }

                    private void StuSearchSelCoure_Click(object sender, EventArgs e)
                    {

                    }

                    private void StuSearchScore_Click(object sender, EventArgs e)
                    {

                    }

                    private void StuSearchInfo_Click(object sender, EventArgs e)
                    {

                    }

                    private void MenuStuSelScore_Click(object sender, EventArgs e)
                    {

                    } 
          #endregion

        private void btnChangeLoginRole_Click(object sender, EventArgs e)
            {
                LoginUI objLoginUI = new LoginUI();
                objLoginUI.Show();
                this.Hide();
                //这个要改进，调试时要注意，窗口只是隐藏了，进程还在，最好能达到打开新窗口后，原有窗口可以关闭的同时不影响新窗口的的打开。★★已解决！方法：在关闭窗口的事件中增加Applicatiom.Exit()方法，结束程序


                LoginUIBLL objLoginUIBLL = new LoginUIBLL();
                LoginUserModel objLoginUserModel = new LoginUserModel();
                objLoginUserModel.UserId = toolLoginUserId.Text;
                objLoginUIBLL.UpdateLoginUserStateClose();

            }

        private void frmTeaMain_FormClosing(object sender, FormClosingEventArgs e)
            {
                LoginUIBLL objLoginUIBLL = new LoginUIBLL();
                LoginUserModel objLoginUserModel = new LoginUserModel();
                objLoginUserModel.UserId = toolLoginUserId.Text;

                objLoginUIBLL.UpdateLoginUserStateClose();

                Application.Exit();//关闭整个程序，包括Hide()的。
            }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog
            //openFileDialog1.ShowDialog();

            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

    MessageBox.Show("该功能正在开发中，请稍后再使用！","温馨提醒",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                //MessageBox.Show("xxxx" + openFileDialog1.FileName);
                //foreach (string OneFileName in openFileDialog1.FileNames)
                //    MessageBox.Show("" + OneFileName);
            }
            else
                MessageBox.Show("You Select Cancel Button.");
        }


        private void FileSave_Click(object sender, EventArgs e)
        {

  MessageBox.Show("该功能正在开发中，请稍后再使用！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show("你点击了保存按钮");
            //}

            //else
            //    MessageBox.Show("你选择了取消按钮");
        } 
           
        #region 测试用，已注释
        //private void btnOpen_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Multiselect = true;
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        System.Diagnostics.Process.Start(openFileDialog1.FileName);

        //        MessageBox.Show("xxxx" + openFileDialog1.FileName);

        //        foreach (string OneFileName in openFileDialog1.FileNames)
        //            MessageBox.Show("" + OneFileName);

        //    }
        //    else
        //        MessageBox.Show("You Select Cancel Button.");
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //    {


        //        MessageBox.Show("你点击了保存按钮");
        //    }

        //    else
        //        MessageBox.Show("你选择了取消按钮");
        //}

      

        //private void btnCopy_Click(object sender, EventArgs e)
        //{
            
            
        //    //if(File.Exists("E:\\123.jpg")==true && File.Exists("E:\\123.jpg")==false)
                
            
        //    //Copy:
        //    //File.Copy("E:\\abc.txt", "E:\\123.txt");
        //    //FileInfo objFileInfo = new FileInfo("E:\\abc.txt");
        //    //objFileInfo.CopyTo("E:\\123.jpg");

        //    //File.Move("","");

        //    //Del:
        //   // File.Delete("");

        //    //Create:
        //   // File.Create("");
            
        //    //Directory
        //  //  if(Directory.Exists("E:\\要建立的文件夹")==false)
        //  //  Directory.CreateDirectory("E:\\要建立的文件夹");


        //    //
        //    //string[] Directories = Directory.GetDirectories("C:\\Windows");
        //    //foreach (string OneDirectory in Directories)
        //    //{
        //    //    listBox1.Items.Add(OneDirectory);
        //    //}

        //    //
        //    string[] Files = Directory.GetFiles("C:\\Windows");
        //    foreach (string OneFiles in Files)
        //    {
        //        listBox1.Items.Add(OneFiles);
        //    }



        //}
        #endregion


    }
}
