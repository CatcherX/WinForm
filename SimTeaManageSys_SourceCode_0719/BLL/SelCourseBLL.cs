using System.Data;
using DAL;
using IDAL;
using Model;

namespace BLL
{
    public class SelCourseBLL
    {
        //业务逻辑层：
        
        //刷新网格：
        public DataTable ShowSelCourse()
        {
            //SelCourseDAL objSelCourseDLL = new SelCourseDAL();

            ISelCourseDAL objSelCourseDLL = new SelCourseDAL();
            return (objSelCourseDLL.ShowTableSelCourse());
        }

        public DataTable ShowDepartment()
        {
            SelCourseDAL objSelCourseDAL = new SelCourseDAL();
            return (objSelCourseDAL.ShowDepartment());
        }

        #region 读取数据库表中的列字段到下拉表：

                GetTableColumnBLL objGetTableColumnDAL = new GetTableColumnBLL();
        
                public string[] GetClaName()
                {
                    string[] ClaName = objGetTableColumnDAL.GetClaName();
                        return (ClaName);
                }
                public string[] GetStuNum()
                {
                    string[] StuNum = objGetTableColumnDAL.GetStuNum();
                    return (StuNum);
                }

                public string[] GetCourseId()
                {
                    string[] GetCourseId = objGetTableColumnDAL.GetCourseNum();
                    return (GetCourseId);
                }
        
                public string[] GetCourseName()
                {
                    string[] CourseNames = objGetTableColumnDAL.GetCourseName();
                    return (CourseNames);
                }

              
        
                public string[] GetScore()
                {
                    string[] Score = objGetTableColumnDAL.GetScore();
                    return (Score);

                } 
        #endregion


        //添加：
        #region 使用字符串作为参数，已注释掉，改为使用数组作为参数
            //public bool SelOk(string StuNum, string CourseNum, string Score)
            //{
            //    SelCourseDALClass objSelCourseDALClass = new SelCourseDALClass();
            //    return (objSelCourseDALClass.SelOk(StuNum, CourseNum, Score));
            //} 
        #endregion

        #region 使用数组作为参数,已注释。
        //public bool SelOk(string[] SelCourse)
        //{
        //    SelCourseDALClass objSelCourseDALClass = new SelCourseDALClass();
        //    return (objSelCourseDALClass.SelOk(SelCourse));
        //} 
        #endregion



        //检查是否已经选课了：
                public bool CheckSelect(SelCourseModel objSelCourseModel)
                {
                    SelCourseDAL objSelCourseDAL = new SelCourseDAL();
                    return objSelCourseDAL.CheckSeledCourseStu(objSelCourseModel);
                }


        #region 选课
                //SelCourseModel objSelCourseModel = new SelCourseModel();

                public bool SelOk(SelCourseModel objSelCourseClass)
                {
                    SelCourseDAL objSelCourseDALClass = new SelCourseDAL();
                    //SelCourseModel objSelCourseModel=new SelCourseModel();
                    //if (objSelCourseDALClass.SearchSeledCourseStu(objSelCourseClass) == true)
                    //{
                    //    MessageBox.Show("已经选了该课程,不能重复选择！\n请检查后重新选择", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return (false);
                    //}
                    //else
                    //{
                        return (objSelCourseDALClass.SelOk(objSelCourseClass));
                    //}

                   
                }  
            #endregion

        //修改
        #region 使用字符串作为参数，已注释掉，改为使用数组作为参数
        //public bool Update(string StuNum, string Score, string CourseNum)
            //{
            //    SelCourseDALClass objSelCourseDALClass = new SelCourseDALClass();
            //    return (objSelCourseDALClass.Update(StuNum, Score, CourseNum));
            //}
        #endregion

        #region 使用数组作为参数,已注释。
            //public bool Update(params string[] SelCourse)
            //{
            //    SelCourseDALClass objSelCourseDALClass = new SelCourseDALClass();
            //    return (objSelCourseDALClass.Update(SelCourse));
            //}
        #endregion

        #region 使用实体类在各层之间传递数据
        public bool Update(SelCourseModel objSelCourseClass)
        {
            //SelCourseDAL objSelCourseDALClass = new SelCourseDAL();
            SelCourseDAL objSelCourseDALClass = new SelCourseDAL();
            return (objSelCourseDALClass.Update(objSelCourseClass));
        }
        #endregion

        //成绩录入：
        public bool InputScore(SelCourseModel objSelCourseModel)
        {
            SelCourseDAL objSelCourseDAL = new SelCourseDAL();
            return (objSelCourseDAL.InputScore(objSelCourseModel));
        }

        //删除
        #region 使用参数数组作为参数,已注释
        //public bool CancelSel(string StuNum)
        //{
        //    SelCourseDALClass objSelCourseDALClass = new SelCourseDALClass();
        //    return (objSelCourseDALClass.CancelSel(StuNum));
        //} 
        #endregion

        #region 使用实体类在各层之间传递数据
        public bool CancelSel(SelCourseModel objSelCourseModel)
        {
            //SelCourseDAL objSelCourseDALClass = new SelCourseDAL();

            ISelCourseDAL objSelCourseDALClass = new SelCourseDAL();
            return (objSelCourseDALClass.CancelSel(objSelCourseModel));
        }
        #endregion

        //查找：
        #region 查找及返回查找结果：
        
        //获取学生学号，以便给combox控件使用：
        public bool SearchSeledCourseStu(SelCourseModel objSelCourseModel)
        {
            SelCourseDAL objSelCourseDALClass = new SelCourseDAL();
            return (objSelCourseDALClass.CheckSeledCourseStu(objSelCourseModel));

        }

        //返回查找结果
        public DataTable CheckStuSeletCourseResult(SelCourseModel objSelCourseModel)
        {
            SelCourseDAL objSelCourseDALClass = new SelCourseDAL();

           // ISelCourseDAL objSelCourseDALClass = new SelCourseDAL();

            return (objSelCourseDALClass.CheckStuSelectCourseResult(objSelCourseModel));

        }     
        #endregion
    
    }
}
