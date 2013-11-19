using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class CourseInfo:CentralUse
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        //创建全局对象，减少代码冗余：
            CourseBLL objCourseBLL = new CourseBLL();

            CourseModel objCourseModel = new CourseModel();

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCourseInfo();
        }
     
        public DataTable ShowCourseInfo()
        {
            CourseBLL objCourseBLL = new CourseBLL();
            dgvshow.DataSource = objCourseBLL.ShowCourse();

            DataTable objDataTable = objCourseBLL.ShowCourse();     //给课程表调用：
            return objDataTable;

        }

            #region //
        //private void Add_Click(object sender, EventArgs e)
        //{
        //    //string SqlString = "INSERT INTO Course(CourseNum,CourseName,Credit,ProOrPub,NeedOrOpt) VALUES('" + CourseNum.Text + "',CourseName='" + CourseName.Text + "',Credit='" + Credit.Text + "',ProOrPob='" + ProOrPub.Text + "',NeedOrOpt='" + NeedOrOpt.Text + "')";
        //    //sql objDataBase = new sql();
        //    //if (objDataBase.GetExecute(SqlString) == true)
        //    //{ MessageBox.Show("数据添加成功"); }
        //    //else
        //    //{ MessageBox.Show("数据添加失败"); }


        //    //SqlCommand objSqlCommand = new SqlCommand();
        //    //objSqlCommand.CommandType= CommandType.StoredProcedure;
        //    //objSqlCommand.CommandText = "inCourse";
        //    //objSqlCommand.Parameters.Add("@CourseNum", SqlDbType.NChar, 10);
        //    //objSqlCommand.Parameters["@CourseNum"].Value = CourseNum.Text;
        //    //objSqlCommand.Parameters.Add("@CourseName", SqlDbType.NChar, 10);
        //    //objSqlCommand.Parameters["@CourseName"].Value = CourseName.Text;
        //    //objSqlCommand.Parameters.Add("@Credit", SqlDbType.NChar, 10);
        //    //objSqlCommand.Parameters["@Credit"].Value = Credit.Text;
        //    //objSqlCommand.Parameters.Add("@ProOrPub", SqlDbType.NChar, 10);
        //    //objSqlCommand.Parameters["@ProOrPub"].Value = ProOrPub.Text;
        //    //objSqlCommand.Parameters.Add("@NeedOrOpt", SqlDbType.NChar, 10);
        //    //objSqlCommand.Parameters["@NeedOrOpt"].Value = NeedOrOpt.Text;
        //    //sql objDataBase = new sql();
        //    //if (objDataBase.GetExecute(objSqlCommand))
        //    //MessageBox.Show("添加成功");
        //    //else
        //    //MessageBox.Show("添加失败");

        //    //CourseBLLClass objCourseBLL = new CourseBLLClass();
        //    //if (objCourseBLL.AddCourse(CourseNum.Text, CourseName.Text, Credit.Text, ProOrPub.Text, NeedOrOpt.Text) == true)
        //    //MessageBox.Show("数据添加成功");
        //    //else
        //    //MessageBox.Show("数据添加失败");
        //    //dgvshow.DataSource = objCourseBLL.ShowCourse();

        //    CourseModel objCourse = new CourseModel();
        //    objCourse.CourseNum = txtCourseNum.Text;
        //    objCourse.CourseName = txtCourseName.Text;
        //    objCourse.Credit = txtCredit.Text;
        //    objCourse.ProOrPub = txtProOrPub.Text;
        //    objCourse.NeedOrOpt = txtNeedOrOpt.Text;
        //    string OutString = "课程编号：" + objCourse.CourseNum + "\n";
        //    OutString = "课程名称：" + objCourse.CourseName + "\n";
        //    OutString = "学分：" + objCourse.Credit + "\n";
        //    OutString = "公共专业：" + objCourse.ProOrPub + "\n";
        //    OutString = "必修选修：" + objCourse.NeedOrOpt + "\n";
        //    MessageBox.Show(OutString, "课程信息");



        //    showDGV();
        //    //create procedure[dbo].[insertCourse]
        //    //@CourseNum nchar(10),
        //    //@CourseName nchar(10),
        //    //@Credit nchar(10),
        //    //@ProOrPub nchar(10),
        //    //@NeedOrOpt nchar(10)
        //    //as
        //    //begin
        //    // insert into
        //    //Course(CourseNum,CourseName,Credit,ProOrPub,NeedOrOpt)
        //    //values(@CourseNum,@CourseName,@Credit,@ProOrPub,@NeedOrOpt)
        //    //end
        //} 
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            
            ShowCourseInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 使用实体类在各层传递数据：

            if (txtCourseNum.Text == "" || txtCourseName.Text == "")
            {
                MessageBox.Show("课程编号、课程名称都不能为空！\n 请重新输入！");
            }
            else
            {
                objCourseModel.CourseNum = txtCourseNum.Text;
                objCourseModel.CourseName = txtCourseName.Text;
                objCourseModel.Credit = txtCredit.Text;
                objCourseModel.DeptNum = txtNeedOrOpt.Text;
                objCourseModel.ProOrPub = txtProOrPub.Text;
                objCourseModel.NeedOrOpt = txtNeedOrOpt.Text;
                objCourseModel.DeptNum = cmbDeptNum.Text;
                objCourseModel.DeptName = cmbDeptName.Text;

                if (objCourseBLL.AddCourse(objCourseModel) == true)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                    MessageBox.Show("添加失败！");
            }
            #endregion
            ShowCourseInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region 使用实体类在各层传递数据
            
            if (txtCourseNum.Text == "")
            {
                MessageBox.Show("课程编号不能为空！\n 请重新输入！");
            }
            else
            {
                objCourseModel.CourseName = txtCourseName.Text;
                objCourseModel.CourseNum = txtCourseNum.Text;
                objCourseModel.Credit = txtCredit.Text;
                objCourseModel.DeptNum = txtNeedOrOpt.Text;
                objCourseModel.ProOrPub = txtProOrPub.Text;
                objCourseModel.NeedOrOpt = txtNeedOrOpt.Text;
                objCourseModel.DeptNum = cmbDeptNum.Text;

                if (objCourseBLL.ChangeCourse(objCourseModel)==true)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败！");
            }
            #endregion
            
            
            ShowCourseInfo();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (txtCourseNum.Text == "")
            {
                MessageBox.Show("课程号不能为空！\n 请重新输入！");
            }
            else
            {
                CourseBLL objCourseBLL = new CourseBLL();
                CourseModel objCourseModel = new CourseModel();

                objCourseModel.CourseNum = txtCourseNum.Text;

                if (objCourseBLL.DelCourse(objCourseModel) == true)
                {
                    MessageBox.Show("成功删除！!");
                }
                else
                {
                    MessageBox.Show("删除失败!");
                }

                ShowCourseInfo();
            }
        }


        private void dgvshow_Click(object sender, EventArgs e)
        {
            int CurrentRow = dgvshow.CurrentRow.Index;
            txtCourseNum.Text = dgvshow[0, CurrentRow].Value.ToString();
            txtCourseName.Text = dgvshow[1, CurrentRow].Value.ToString();
            txtCredit.Text = dgvshow[2, CurrentRow].Value.ToString();
            txtProOrPub.Text = dgvshow[3, CurrentRow].Value.ToString();
            txtNeedOrOpt.Text = dgvshow[4, CurrentRow].Value.ToString();
            cmbDeptNum.Text = dgvshow[5, CurrentRow].Value.ToString();
            cmbDeptName.Text = dgvshow[6, CurrentRow].Value.ToString();
        }       
 
    }
}
