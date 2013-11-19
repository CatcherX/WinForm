using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class InPutScore : CentralUse //继承窗体（用于窗口居中）
    {
        public InPutScore()
        {
            InitializeComponent();
        }

        //刷新网格：
        private void RefreshTable()
        {

            #region 使用SQL语句刷新表格的方法，已注释。改到三层架构的数据访问层了。
            //    string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分,Score AS 成绩 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum";

            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();
            //    dgvSelCourse.DataSource = objDataBase.ShowTable(SqlString);
            //

            #endregion
            
            SelCourseBLL objSelCourseBLL = new SelCourseBLL();
            dgvSelCourse.DataSource = objSelCourseBLL.ShowSelCourse();
        }

        //添加字段名到comboBox控件的下拉框中：
        private void ShowComboBox()
        {
              #region 添加字段名到comboBox控件中：

                GetTableColumnBLL objGetTableColumnBLL = new GetTableColumnBLL();

                string[] StuNum = objGetTableColumnBLL.GetStuNum();
                cbxStuNum.Items.AddRange(StuNum);
                
                string[] StuName = objGetTableColumnBLL.GetStuName();
                cmbStuName.Items.AddRange(StuName);

                string[] GetCourseId = objGetTableColumnBLL.GetCourseNum();
                cbxCourseNum.Items.AddRange(GetCourseId);

                string[] CourseName = objGetTableColumnBLL.GetCourseName();
                cbxCourseName.Items.AddRange(CourseName);

                string[] Score = objGetTableColumnBLL.GetScore();
                cbxScore.Items.AddRange(Score);
            #endregion
        }

              #region 课程编号、姓名下拉表选择改变触发事件：

		    //是用户当选中的的索引发生变化时候触发的事件
            private void cbxStuNum_SelectedIndexChanged(object sender, EventArgs e)
            {
                cmbStuName.SelectedIndex = cbxStuNum.SelectedIndex;
            }

            private void cmbStuName_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbxStuNum.SelectedIndex = cmbStuName.SelectedIndex;
            }
        
        
        
        
        
            private void cbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbxCourseNum.SelectedIndex = cbxCourseName.SelectedIndex;

            }

            private void cbxCourseNum_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbxCourseName.SelectedIndex = cbxCourseNum.SelectedIndex;
            } 

            


        #endregion

              #region //清空方法及调用：
        private void Reset()
        {
            cbxStuNum.Text = "";
            //txtStuName.Text = "";
            //txtClassName.Text="";
            cbxCourseNum.Text = "";
            cbxScore.Text = "";
            dgvSelCourse.DataSource = 0;
        }

        //重置：
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        } 
        #endregion


              #region 单击表格显示结果在文本框：

      //有异常：
		private void dgvSelCourse_Click(object sender, EventArgs e)
        {
          try 
	    {	     
            int CurrentRow = dgvSelCourse.CurrentRow.Index;
            cbxStuNum.Text = dgvSelCourse[0, CurrentRow].Value.ToString();
            //txtClassName.Text = dgvSelCourse[1, CurrentRow].Value.ToString();
            //txtStuName.Text = dgvSelCourse[2, CurrentRow].Value.ToString();
            cbxCourseNum.Text = dgvSelCourse[4, CurrentRow].Value.ToString();
            cbxScore.Text = dgvSelCourse[6, CurrentRow].Value.ToString();
        }
            catch (Exception)
                 {
                     
                 }
	    }
	
        #endregion
      
        //窗口载入时：
        private void InPutScore_Load(object sender, EventArgs e)
        {
            RefreshTable();
            ShowComboBox();//调用//添加字段名到comboBox控件的下拉框中的方法;
        }
        
        
        //添加：（成绩录入）
        private void btnInput_Click(object sender, EventArgs e)
        {
            #region 使用实体类在各层传递数据:
                
            #region 成绩录入
                        if (cbxStuNum.Text == "")
                        {
                              MessageBox.Show("学号、课程编号、成绩都不能为空！\n 请重新输入！");
                     
                        }
                        else
                        {
                            SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();

                            SelCourseModel objSelCourseModel = new SelCourseModel();

                            objSelCourseModel.StuNum = cbxStuNum.Text;
                            objSelCourseModel.CourseNum = cbxCourseNum.Text;
                            objSelCourseModel.Score = cbxScore.Text;

                            if (objSelCourseBLLClass.InputScore(objSelCourseModel) == true) //由于与修改的逻辑相同，所以这里与修改所调用的方法是相同的
                            {
                                MessageBox.Show("成绩录入成功！");
                            }
                            else
                                MessageBox.Show("成绩录入失败！\n 该学生未进行选课");
                        }

                  #endregion

            #endregion

            RefreshTable();
        }
 

        //修改
           #region 使用数组作为参数，已注释。
        //private void btnUpdate_Click_1(object sender, EventArgs e)
        //{
        //    #region 使用SQL语句修改，已注释，改到三层架构的数据访问层了。
        //    //int CurrentRow = dgvSelCourse.CurrentRow.Index;
        //    //string StuNum = dgvSelCourse[0, CurrentRow].Value.ToString();

        //    //string SqlString = "Update SelCourse Set StuNum='" + cbxStuNum.Text + "',CourseNum='" + cbxCourseNum.Text + "',Score='" + cbxScore.Text + "' where StuNum='" + StuNum + "'";
        //    ////objSqlCommand.CommandText = SqlString;
        //    ////objSqlCommand.Connection = objConn;

        //    //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //    //if (objDataBase.GetExecute(SqlString) == true)
        //    //{ MessageBox.Show("修改成功!"); }
        //    //else
        //    //{ MessageBox.Show("修改失败!"); } 
        //    #endregion

        //    if (cbxStuNum.Text == "")
        //    {
        //        MessageBox.Show("学号不能为空！\n 请重新输入！");
        //    }
        //    else
        //    {
        //        SelCourseBLLClass objSelCourseBLLClass = new SelCourseBLLClass();

        //        #region 已注释掉，改为使用数组作为参数
        //        //if (objSelCourseBLLClass.Update(cbxStuNum.Text, cbxScore.Text, cbxCourseNum.Text) == true)
        //        #endregion

        //        string[] SelCourse = new string[3];
        //        SelCourse[0] = cbxStuNum.Text;
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

           #region  使用实体类在各层传递数据：
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            #region 已经注释
            //if (cbxStuNum.Text == "")
            //{
            //    MessageBox.Show("学号不能为空！\n 请重新输入！");
            //}
            //else
            //{
            //    SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();

            //    SelCourseModel objSelCourseModel = new SelCourseModel();


            //    objSelCourseModel.StuNum = cbxStuNum.Text;          //修改条件
            //    objSelCourseModel.CourseName = cbxCourseName.Text;  //修改条件


            //    objSelCourseModel.CourseNum = cbxCourseNum.Text;    //目标内容
            //    objSelCourseModel.Score = cbxScore.Text;            //目标内容 
            #endregion
               
            if (cbxStuNum.Text == "")
             {
                  MessageBox.Show("学号、课程编号、成绩都不能为空！\n 请重新输入！");
                     
             }
            else
            {
                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();

                SelCourseModel objSelCourseModel = new SelCourseModel();

                objSelCourseModel.StuNum = cbxStuNum.Text;
                objSelCourseModel.CourseNum = cbxCourseNum.Text;
                objSelCourseModel.Score = cbxScore.Text;

              // if (objSelCourseBLLClass.Update(objSelCourseModel) == true)
            if (objSelCourseBLLClass.InputScore(objSelCourseModel) == true) 
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败！");
            }

            RefreshTable();
        }
        #endregion


        //删除：
        private void btnDel_Click(object sender, EventArgs e)
        {
            #region 使用SQL语句删除，已注释，改到三层架构的数据访问层了。
            //int CurrentRow = dgvSelCourse.CurrentRow.Index;
            //string StuNum = dgvSelCourse[0, CurrentRow].Value.ToString();

            //string SqlString = "delete from SelCourse where StuNum='" + StuNum + "'";

            ////objSqlCommand.CommandText = SqlString;
            ////objSqlCommand.Connection = objConn;

            //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //if (objDataBase.GetExecute(SqlString) == true)
            //{ MessageBox.Show("退选成功!"); }
            //else
            //{ MessageBox.Show("退选失败!"); } 
            #endregion

            #region  使用实体类在各层传递数据
            if (cbxStuNum.Text == "")
            {
                MessageBox.Show("学号不能为空！\n 请重新输入！");
            }
            else
            {

                SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
                SelCourseModel objSelCourseModel = new SelCourseModel();

                objSelCourseModel.StuNum = cbxStuNum.Text;

                if (objSelCourseBLLClass.CancelSel(objSelCourseModel) == true)
                {
                    MessageBox.Show("删除成功！!");
                }
                else
                {
                    MessageBox.Show("删除失败!");
                }
            } 

            #endregion

            RefreshTable();
        }

         //查找
        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region 按学号查找已经选课的学生
            //★★进行查找前，先清空表格内容：
            cbxCourseNum.Text = "";
            dgvSelCourse.DataSource = 0;

            SelCourseBLL objSelCourseBLLClass = new SelCourseBLL();
            SelCourseModel objSelCourseModel = new SelCourseModel();

            objSelCourseModel.StuNum = cbxStuNum.Text;
            objSelCourseModel.CourseName = cbxCourseName.Text;

            if (objSelCourseBLLClass.SearchSeledCourseStu(objSelCourseModel) == true)
            {
                MessageBox.Show("数据已找到！\n请查阅！!");
                dgvSelCourse.DataSource = objSelCourseBLLClass.CheckStuSeletCourseResult(objSelCourseModel);
            }

      //▲▲▲数据查找到后，怎样接收到数据表格中？★★要在逻辑层、数据访问层定义一个返回类型为：DataTable的方法吗？怎样定义？
            //已经定义了了返回类型为bool的方法。那么应该用方法重载实现么？上面这样写好不好？

            // dgvSelCourse.DataSource=objSelCourseBLLClass.SearchSeledCourseStu();
            else
            {
                MessageBox.Show("查找完毕，没有找到相关数据。\n请检查搜索条件！\n 该学生可能还没进行选课!");
            }
            #endregion
        }

        //调用实体类的构造函数显示编辑框内容
        private void btnShowInput_Click(object sender, EventArgs e)
        {
            #region 调用实体类的构造函数显示编辑框内容
            //调用系统默认的无参构造函数：
            //SelCourseClass objSelCourseClass = new SelCourseClass();

            //调用Model实体类的构造函数：
            SelCourseModel objSelCourseModel = new SelCourseModel(cbxStuNum.Text, cbxCourseNum.Text, cbxScore.Text);

            objSelCourseModel.StuNum = cbxStuNum.Text;
            objSelCourseModel.CourseName = cbxCourseName.Text;
            objSelCourseModel.CourseNum = cbxCourseNum.Text;
            objSelCourseModel.Score = cbxScore.Text;

            string OutString = "学号：" + objSelCourseModel.StuNum + "\n";
            OutString += "课程编号:" + objSelCourseModel.CourseNum + "\n";
            OutString += "课程名称：" + objSelCourseModel.CourseName + "\n";
            OutString += "科目成绩:" + objSelCourseModel.Score + "\n";
            

            MessageBox.Show(OutString, "成绩信息");
            #endregion
        }

        

       
    }
}
