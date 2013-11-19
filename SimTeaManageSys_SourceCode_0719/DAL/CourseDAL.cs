using System.Data;
using DataBaseOperate;
using DataBaseOperate2;
using Model;

namespace DAL
{
    public class CourseDAL
    {   //添加课程
        #region //
        //public bool AddCourse(string CourseNum, string CourseName, string Credit, string ProOrPub, string NeedOrOpt)
        //{
        //    string SqlString = "INSERT INTO Course(CourseNum,CourseName,Credit,ProOrPub,NeedOrOpt) VALUES('" + CourseNum + "','" + CourseName + "','" + Credit + "','" + ProOrPub + "','" + NeedOrOpt + "')";

        //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //    if (objDataBase.GetExecute(SqlString))
        //        return (true);
        //    else
        //        return (false);

        //} 
        #endregion
        public bool AddCourse( CourseModel objCourseModel)
        {

            #region 使用实体类在各层之间传递数据

            string SqlString = "Insert into Course(CourseNum,CourseName,Credit,ProOrPub,NeedOrOpt,DeptNum) values('" + objCourseModel.CourseNum + "','" + objCourseModel.CourseName + "','" + objCourseModel.Credit + "','" + objCourseModel.ProOrPub + "','" + objCourseModel.DeptNum + "','"+objCourseModel.DeptNum+"')";


            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(SqlString))
                return (true);
            else
                return (false);

            #endregion
        }



        //修改课程
        public bool ChangeCourse(CourseModel objCourseModel)
        {
            #region //
            //public bool ChangeCourse(string Course, string CourseNum, string CourseName, string Credit, string ProOrPub, string NeedOrOpt)
            //{
            //    string SQLString;
            //    SQLString = "update Course set CourseNum='" + CourseNum + "',CourseName='" + CourseName + "'";
            //    SQLString += ",Credit='" + Credit + "',ProOrPub='" + ProOrPub + "'";
            //    SQLString += ",NeedOrOpt='" + NeedOrOpt + "'where CourseNum='" + Course + "'";
            //    DataBaseOperateClass objDataBase = new DataBaseOperateClass();
            //    if (objDataBase.GetExecute(SQLString))
            //        return (true);
            //    else
            //        return (false);
            //} 
            #endregion

             #region 使用实体类在各层之间传递数据

              string SQLString;
    SQLString = "update Course set CourseNum='" + objCourseModel.CourseNum + "',CourseName='" + objCourseModel.CourseName + "',Credit='" + objCourseModel.Credit + "',ProOrPub='" + objCourseModel.ProOrPub + "',NeedOrOpt='" + objCourseModel.NeedOrOpt + "',DeptNum='"+ objCourseModel.DeptNum+"' where CourseNum='" + objCourseModel.CourseNum + "'";

                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                if (objDataBase.GetExecute(SQLString))
                    return (true);
                else
                    return (false);

            #endregion
        }

        
        //删除课程
        public bool DeletCourse(CourseModel objCourseModel )
        {
            string SqlString = "DELETE FROM Course WHERE CourseNum='" + objCourseModel.CourseNum + "'";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();
            return (objDataBase.GetExecute(SqlString));
        }
        
        //获取所有课程：
        public DataTable ShowCourse()
        {
            string SqlString = "select CourseNum as 课程号,CourseName as 课程名称,Credit AS 学分,ProOrPub as 范围,NeedOrOpt  AS  类型 ,Course.DeptNum AS 系编号, Department.DeptName as 系别 from  Course join Department on Course.DeptNum=Department.DeptNum order by CourseNum desc";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable objDataTable = objDataBase.GetDataSet(SqlString).Tables[0];
            return (objDataTable);

        }

        //查找课程
        public bool SearchCoursebool(CourseModel objCourseModel)
        {
            string SqlString = "Select * from Course where CourseNum='" + objCourseModel.CourseNum + "'";

            DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();

            if (objDataBaseOperateClass2.GetDataRow(SqlString) != null)
                return (true);
            else
                return (false);
        }


        //返回结果：
        public DataTable SearchCourse(CourseModel objCourseModel)
        {
            string SqlString = "Select * from Course where CourseNum='" + objCourseModel.CourseNum + "'";
            
      DataBaseOperateClass2 objDataBaseOperateClass2=new DataBaseOperateClass2();
            
            DataTable objDataTable;

            return objDataTable = objDataTable = objDataBaseOperateClass2.ShowTable(SqlString);
        }
    }
}
