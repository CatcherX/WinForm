using System;
using System.Data.SqlClient;//SqlDataReader 要用到的
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class SelCourse : CentralUse //继承窗体（用于窗口居中）
    {
        /// <summary>
        /// c#winform编程 窗体之间传递参数问题总结 - 独孤雨个人博客 - 51CTO技术博客
        ///http://ccj188.blog.51cto.com/447493/192591/
        /// </summary>
        public static string strTrans ="更新时间"+DateTime.Now.ToString();

        
        //创建委托类型：
        public delegate void DelegateRefresh(object sender, MyEventArg e);
        //创建事件：
        public event DelegateRefresh EventRefersh;
    

        public SelCourse()
        {
            InitializeComponent();
        }

        LoginUIBLL objLoginUIBLL = new LoginUIBLL();
        LoginUserModel objLoginUserModel = new LoginUserModel();
        ScoreSearchBLL objScoreSearchBLL = new ScoreSearchBLL();
        SqlDataReader SqlRead;




        //刷新网格：★改为按当前登录用户来显示选课信息：
        private void ShowCurrentLoginUserInfo()
        {

            #region 使用SQL语句刷新表格的方法，已注释。改到三层架构的数据访问层了。
            //    string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分,Score AS 成绩 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum";

        //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();
        //    dgvSelCourse.DataSource = objDataBase.ShowTable(SqlString);
            //

            #endregion

            //SelCourseBLL objSelCourseBLL = new SelCourseBLL();
            //dgvSelCourse.DataSource = objSelCourseBLL.ShowSelCourse();

            #region 按学号查找已经选课的学生的选课信息：
            //★★进行查找前，先清空表格内容：
            cbxCourseNum.Text = "";
            dgvSelCourse.DataSource = 0;

            SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
            SelCourseModel objSelCourseModel = new SelCourseModel();

            objSelCourseModel.StuNum = txtStuNum.Text;

            dgvSelCourse.DataSource = objSelCourseBLLClass.CheckStuSeletCourseResult(objSelCourseModel);

            #endregion

        }
        
        //添加字段名到comboBox控件中：
        private void ShowComboBox()
        {
            #region 添加字段名到comboBox控件中：
                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
                
            
            //限制学生身份登录的权限，只能够给当前登录身份的学生进行选课！
                //string[] StuNum = objSelCourseBLLClass.GetStuNum();
                //txtStuNum.Items.AddRange(StuNum);
            
                //string[] CourseIds = objSelCourseBLLClass.GetCourseNum();
                //cbxCourseNum.Items.AddRange(CourseIds);
                string[] GetCourseId = objSelCourseBLLClass.GetCourseId();
                cbxCourseNum.Items.AddRange(GetCourseId);


                string[] CourseName = objSelCourseBLLClass.GetCourseName();
                cbxCourseName.Items.AddRange(CourseName);
            #endregion
        }

            #region 课程编号、姓名下拉表选择改变触发事件：
                private void cbxCourseNum_SelectedIndexChanged(object sender, EventArgs e)
                {
                    cbxCourseName.SelectedIndex = cbxCourseNum.SelectedIndex;
                }

                private void cbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
                {
                    cbxCourseNum.SelectedIndex = cbxCourseName.SelectedIndex;
                } 
            #endregion


        private void SelCourse_Load(object sender, EventArgs e)
        {
            //将“成绩查询”窗体中的RefreshDataGridView()注册为事件处理程序。
            foreach (Form objForm in this.MdiParent.MdiChildren)
            {
                if (objForm is StuScoreSearch)
                {
                    StuScoreSearch objStuScoreSearch = (StuScoreSearch)objForm;
                    this.EventRefersh += new DelegateRefresh(objStuScoreSearch.RefreshDataGridView);
                }
            }
            
            //RefreshTable();
                ShowComboBox();

                SqlRead = objLoginUIBLL.LoginUserRead();
                if (SqlRead.Read())
                {
                    objLoginUserModel.UserId = SqlRead["UserId"].ToString();
                }
               
                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();

                SelCourseModel objSelCourseModel = new SelCourseModel();

               
                //objSelCourseModel.StuNum = txtStuNum.Text;

                //★★用当前登录的用户编号作为选课的学号！
                objSelCourseModel.StuNum = objLoginUserModel.UserId;

                //txtStuNum.Text = objLoginUserModel.UserId;
                txtStuNum.Text = objLoginUserModel.UserId;

                ShowCurrentLoginUserInfo();

        }
        
        //单击网格，显示结果在文本框：
        private void dgvSelCourse_Click(object sender, EventArgs e)
        {
            SelCourseModel objSelCourseClass = new SelCourseModel();
            int CurrentRow = dgvSelCourse.CurrentRow.Index;
            cbxCourseNum.Text = dgvSelCourse[4, CurrentRow].Value.ToString();    //这个作为修改课程的条件
        }

        //清空方法：
        private void Reset()
        {
            //txtStuNum.Text = "";
            //txtStuNum.Text = "";
            //txtStuName.Text = "";
            //txtClassName.Text="";
            cbxCourseNum.Text = "";
          //  cbxScore.Text = "";
            
        }

        //清空调用：
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //添加：
        private void btnSelOk_Click(object sender, EventArgs e)
        {
            #region 使用数组作为参数，已注释。
            //private void btnSelOk_Click(object sender, EventArgs e)
            //{
            //    #region 使用Sql语句添加,已注释，改到三层架构的数据访问层了。
            //    //string SqlString = "Insert into SelCourse(StuNum,CourseNum,Score) Values('" + txtStuNum.Text + "','" + cbxCourseNum.Text + "','" + cbxScore.Text + "')";

            //    ////objSqlCommand.CommandText = Sqlstring;
            //    ////objSqlCommand.Connection = objConn;

            //    //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    //if (objDataBase.GetExecute(SqlString) == true)
            //    //{ MessageBox.Show("选课成功!"); }
            //    //else
            //    //{ MessageBox.Show("选课失败!"); }
            //    #endregion

            //    if (txtStuNum.Text == "")
            //    {
            //        MessageBox.Show("学号不能为空！\n 请重新输入！");
            //    }
            //    else 
            //    {
            //        SelCourseBLLClass objSelCourseBLLClass = new SelCourseBLLClass();
            //        #region 已注释掉，改为使用数组作为参数
            //      //  if (objSelCourseBLLClass.SelOk(txtStuNum.Text, cbxCourseNum.Text, cbxScore.Text) == true) 
            //        #endregion
            //        string[] SelCourse=new string[3];
            //        SelCourse[0]=txtStuNum.Text;
            //        SelCourse[1]=cbxCourseNum.Text;
            //        SelCourse[2]=cbxScore.Text;

            //        if(objSelCourseBLLClass.SelOk(SelCourse)==true)
            //        {
            //            MessageBox.Show("选课成功！");
            //        }
            //        else
            //            MessageBox.Show("选课失败！");
            //    }


            //    RefreshTable();
            //} 
            #endregion

            #region 使用实体类在各层传递数据：
            //if (txtStuNum.Text == "")
            if (txtStuNum.Text == "" || cbxCourseNum.Text == "")
            {
                MessageBox.Show("学号、课程号都不能为空！\n 请重新输入！");
            }
            else
            {
                SqlRead = objLoginUIBLL.LoginUserRead();
                if (SqlRead.Read())
                {
                    objLoginUserModel.UserId = SqlRead["UserId"].ToString();
                }

                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
                SelCourseModel objSelCourseModel = new SelCourseModel();

                //objSelCourseModel.StuNum = txtStuNum.Text;

                //★★用当前登录的用户编号作为选课的学号！
                objSelCourseModel.StuNum = objLoginUserModel.UserId;

                objSelCourseModel.CourseNum = cbxCourseNum.Text;
                objSelCourseModel.CourseName = cbxCourseName.Text;
                //int CurrentRow = dgvSelCourse.CurrentRow.Index;
                //objSelCourseModel.CourseName = dgvSelCourse[3, CurrentRow].Value.ToString();    //这个作为修改课程的条件

                if (objSelCourseBLLClass.SelOk(objSelCourseModel) == true)
                {
                    MessageBox.Show("选课成功！");
                }
                else
                    MessageBox.Show("选课失败！");
                ShowCurrentLoginUserInfo();
            }
            #endregion

            //触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            #region 触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            if (this.EventRefersh == null)
            {
                foreach (Form objForm in this.MdiParent.MdiChildren)
                {
                    if (objForm is StuScoreSearch)
                    {
                        StuScoreSearch objStuScoreSearch = (StuScoreSearch)objForm;
                        this.EventRefersh += new DelegateRefresh(objStuScoreSearch.RefreshDataGridView);
                    }
                }
            }
            if (this.EventRefersh != null)
            {
                this.EventRefersh(this, null);
            }
            #endregion
        }
 

        //修改
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            #region 使用数组作为参数，已注释。
            //private void btnUpdate_Click_1(object sender, EventArgs e)
            //{
            //    #region 使用SQL语句修改，已注释，改到三层架构的数据访问层了。
            //    //int CurrentRow = dgvSelCourse.CurrentRow.Index;
            //    //string StuNum = dgvSelCourse[0, CurrentRow].Value.ToString();

            //    //string SqlString = "Update SelCourse Set StuNum='" + txtStuNum.Text + "',CourseNum='" + cbxCourseNum.Text + "',Score='" + cbxScore.Text + "' where StuNum='" + StuNum + "'";
            //    ////objSqlCommand.CommandText = SqlString;
            //    ////objSqlCommand.Connection = objConn;

            //    //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    //if (objDataBase.GetExecute(SqlString) == true)
            //    //{ MessageBox.Show("修改成功!"); }
            //    //else
            //    //{ MessageBox.Show("修改失败!"); } 
            //    #endregion

            //    if (txtStuNum.Text == "")
            //    {
            //        MessageBox.Show("学号不能为空！\n 请重新输入！");
            //    }
            //    else
            //    {
            //        SelCourseBLLClass objSelCourseBLLClass = new SelCourseBLLClass();

            //        #region 已注释掉，改为使用数组作为参数
            //        //if (objSelCourseBLLClass.Update(txtStuNum.Text, cbxScore.Text, cbxCourseNum.Text) == true)
            //        #endregion

            //        string[] SelCourse = new string[3];
            //        SelCourse[0] = txtStuNum.Text;
            //        SelCourse[1] = cbxCourseNum.Text;
            //        SelCourse[2] = cbxScore.Text;

            //        if (objSelCourseBLLClass.Update(SelCourse) == true)
            //        {
            //            MessageBox.Show("修改成功!");
            //        }
            //        else
            //        { MessageBox.Show("修改失败!"); }
            //    }

            //    RefreshTable();
            //} 
            #endregion

            #region 使用实体类在各层传递数据
            //if (txtStuNum.Text == "")
            if(txtStuNum.Text=="")
            {
                MessageBox.Show("学号不能为空！\n 请重新输入！");
            }
            else
            {
                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
                SelCourseModel objSelCourseClass = new SelCourseModel();

                //objSelCourseClass.StuNum = txtStuNum.Text;
                objSelCourseClass.StuNum = txtStuNum.Text;              //修改条件，必须要再加一个条件，否则，改一个它就会全部被修改
                objSelCourseClass.CourseNum = cbxCourseNum.Text;     
                

     //objSelCourseClass.CourseName = cbxCourseName.Text;       //这个也要作为修改条件，但由于点击表格后，会发生变化，造成可能修改失败，要改进！  已解决，见下一行：
        //这个【objSelCourseClass.CourseName】作为修改条件，不能因点击网格了而发生变化！所以文本内容不再赋值给实体类了，由点击网络后赋值给实体类！

                //objSelCourseClass.Score = cbxScore.Text;

                int CurrentRow = dgvSelCourse.CurrentRow.Index;

                objSelCourseClass.CourseName = dgvSelCourse[3, CurrentRow].Value.ToString();    //这个作为修改课程的条件




                if (objSelCourseBLLClass.Update(objSelCourseClass) == true)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败！");
            }
            #endregion

            ShowCurrentLoginUserInfo();


            //触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            #region 触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            if (this.EventRefersh == null)
            {
                foreach (Form objForm in this.MdiParent.MdiChildren)
                {
                    if (objForm is StuScoreSearch)
                    {
                        StuScoreSearch objStuScoreSearch = (StuScoreSearch)objForm;
                        this.EventRefersh += new DelegateRefresh(objStuScoreSearch.RefreshDataGridView);
                    }
                }
            }
            if (this.EventRefersh != null)
            {
                this.EventRefersh(this, null);
            }
            #endregion
        }
   

        //删除：
        private void btnCancelSel_Click(object sender, EventArgs e)
        {
            strTrans ="更新时间"+DateTime.Now.ToString();


            #region 使用SQL语句删除，已注释，改到三层架构的数据访问层了。
            //    //int CurrentRow = dgvSelCourse.CurrentRow.Index;
            //    //string StuNum = dgvSelCourse[0, CurrentRow].Value.ToString();

            //    //string SqlString = "delete from SelCourse where StuNum='" + StuNum + "'";

            //    ////objSqlCommand.CommandText = SqlString;
            //    ////objSqlCommand.Connection = objConn;

            //    //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    //if (objDataBase.GetExecute(SqlString) == true)
            //    //{ MessageBox.Show("退选成功!"); }
            //    //else
            //    //{ MessageBox.Show("退选失败!"); } 
            //    #endregion

            //    if (txtStuNum.Text == "")
            //    {
            //        MessageBox.Show("学号不能为空！\n 请重新输入！");
            //    }
            //    else
            //    {

            //        SelCourseBLLClass objSelCourseBLLClass = new SelCourseBLLClass();
            //        if (objSelCourseBLLClass.CancelSel(txtStuNum.Text) == true)
            //        {
            //            MessageBox.Show("已退选!");
            //        }
            //        else
            //        {
            //            MessageBox.Show("退选失败!");
            //        }
            //    }

            //    RefreshTable();
            //} 
            #endregion

            #region 使用实体类在各层传递数据
            //if (txtStuNum.Text == "")
            if (txtStuNum.Text == "")
            {
                MessageBox.Show("学号不能为空！\n 请重新输入！");
            }
            else
            {
                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
                SelCourseModel objSelCourseClass = new SelCourseModel();

                //objSelCourseClass.StuNum = txtStuNum.Text;
                objSelCourseClass.StuNum = txtStuNum.Text;
                objSelCourseClass.CourseNum = cbxCourseNum.Text;

                if (objSelCourseBLLClass.CancelSel(objSelCourseClass) == true)
                {
                    MessageBox.Show("已退选!");
                }
                else
                {
                    MessageBox.Show("退选失败!");
                }
            }
        #endregion

            ShowCurrentLoginUserInfo();


            //触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            #region 触发事件，即执行“显示成绩窗体中”的RefreshDataGridView()的代码
            if (this.EventRefersh == null)
            {
                foreach (Form objForm in this.MdiParent.MdiChildren)
                {
                    if (objForm is StuScoreSearch)
                    {
                        StuScoreSearch objStuScoreSearch = (StuScoreSearch)objForm;
                        this.EventRefersh += new DelegateRefresh(objStuScoreSearch.RefreshDataGridView);
                    }
                }
            }
            if (this.EventRefersh != null)
            {
                //e.Name = "test";
                this.EventRefersh(this, null);
            }
            #endregion

        }


        //读取model的字段，属性，把输入的文本框内容显示在消息框中：
        private void btnShowInput_Click(object sender, EventArgs e)
        {
            #region 调用实体类的构造函数显示编辑框内容
            SelCourseModel objSelCourseClass = new SelCourseModel();

            //objSelCourseClass.StuNum = txtStuNum.Text;
            objSelCourseClass.StuNum = (string)txtStuNum.Text;
            objSelCourseClass.CourseNum = cbxCourseNum.Text;
            objSelCourseClass.CourseName = cbxCourseName.Text;
            // objSelCourseClass.Score = cbxScore.Text;

            string OutString = "学号：" + objSelCourseClass.StuNum + "\n";
            OutString += "课程编号:" + objSelCourseClass.CourseNum + "\n";
            //OutString += "科目成绩:" + objSelCourseClass.Score + "\n";
            OutString += "课程名称：" + objSelCourseClass.CourseName + "\n";

            MessageBox.Show(OutString, "选课信息"); 
            #endregion
        }


        //查找：
        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region 按学号查找已经选课的学生的选课信息：
            //★★进行查找前，先清空表格内容：
            cbxCourseNum.Text = "";
            dgvSelCourse.DataSource = 0;

            SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
            SelCourseModel objSelCourseModel = new SelCourseModel();

            objSelCourseModel.StuNum = txtStuNum.Text;

            dgvSelCourse.DataSource = objSelCourseBLLClass.CheckStuSeletCourseResult(objSelCourseModel);


            #endregion
        }

       
    }

    public class MyEventArg : EventArgs
    {
        public string Name { get; set; }
    }


}
