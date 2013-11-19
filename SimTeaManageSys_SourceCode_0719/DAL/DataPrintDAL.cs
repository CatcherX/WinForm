using System.Data;
using DataBaseOperate2;

namespace BLL
{
    public class DataPrintDAL
    {
        //SqlExcuClass objExcuClass = new SqlExcuClass();
        DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();


        string SqlString;

        public DataTable SchollInfo()
        {
            SqlString = "Select * from V_SchoolInfo";
            return objDataBaseOperateClass2.ShowTable(SqlString);
        }



        public DataTable PrintStuInfo()
        {
            SqlString = "select StuNum AS 学号,StuName AS 学生姓名,StuSex AS 性别,Policity AS 政治面目,Favor AS 爱好,StuScore AS 总分,Meno AS 评价,Class.ClaName AS 班级,Department.DeptName AS 系别,Phone AS 联系电话,Address AS 联系地址 from dbo.Student join Class on Student.ClaNum=Class.ClaNum join Department on Class.DeptNum=Department.DeptNum";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        public DataTable PrintAdminInfo()
        {
            SqlString = "Select * From Admin";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        public DataTable PrintCourseInfo()
        {
            SqlString = "select CourseNum as 课程号,CourseName as 课程名称,Credit AS 学分,ProOrPub as 专业或公共,NeedOrOpt AS  类型 ,Department.DeptName as 系别 from dbo.Course join Department on Course.DeptNum=Department.DeptNum";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        //打印教师信息表：
        public DataTable PrintTeaInfo()
        {
            SqlString = "Select TeaNum AS 工号,TeaName AS 姓名,TeaSex AS 性别, TeaAdress AS 联系地址,TeaPhone AS 联系电话,TeaTitle AS 职称,TeaProField AS 专业方向 From dbo.Teacher";

            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        //打印班级成绩表：
        public DataTable PrintClassScore()
        {
            SqlString = "Select * From dbo.V_ClassScoreSearch";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

    }
}
