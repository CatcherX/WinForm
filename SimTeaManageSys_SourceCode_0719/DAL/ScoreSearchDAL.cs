using System.Data;
using DataBaseOperate2; //引入命名空间，使用继承DataBaseOperaClass后扩展的获取数据行的方法；
using Model;

namespace DAL
{
    /// <summary>
    /// //成绩查询
    /// </summary>
    
    public class ScoreSearchDAL
    {
         
            string SqlString = "Select * From V_ClassScoreSearch";


              /// <summary>
                    /// 返回查找结果，按班级或学号查找：教师用。
                    /// </summary>
                    /// <param name="objClassModel"></param>
            /// <returns>返回查找结果，按班级或学号查找：教师用。</returns>
            #region 返回查找结果，按班级或学号查找：教师用。
            public DataTable ScoreSearch(ClassModel objClassModel)
            {
                 SqlString += " Where 班级='"+ objClassModel.ClaName+"'Or 学号='"+objClassModel.StuNum+"'";

                DataBaseOperateClass2 objDataBase = new DataBaseOperateClass2();

                DataTable objDataTable;

                return objDataTable = objDataBase.ShowTable(SqlString);
            }
            #endregion


            #region 按学生查找，以当前登录身份查找：学生使用：
            public DataTable ScoreStuSearch(LoginUserModel objLoginUserModel)
            { 
                string SqlStringStu="Select SelCourse.StuNum AS 学号,StuName AS 姓名 ,CourseName As 课程,SelCourse.Score AS 成绩 From SelCourse Join Student on Student.StuNum=SelCourse.StuNum join Course on Course.CourseNum=SelCourse.CourseNum Where SelCourse.StuNum='"+objLoginUserModel.UserId+"'";

                DataBaseOperateClass2 objDataBaseOperate2 = new DataBaseOperateClass2();

                DataTable objDataTable;
                
                return objDataTable = objDataBaseOperate2.ShowTable(SqlStringStu);
            
            }

        #endregion

    }

}
