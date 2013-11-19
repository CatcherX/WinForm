using System.Data;
using DataBaseOperate;
using Model;

namespace DAL
{
    public class TeachingDAL
    {
        //添加班级信息
        public bool AddTeachingTask(TeachingModel objTeachingModel)
        {
            string Sqlstring = "Insert into Teaching Values('T001','第一学期','c1000')";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(Sqlstring))
                return (true);
            else
                return (false);
        }



        //获取所有班级信息
        public DataTable ShowTeaching()
        {
string Sqlstring = "Select TeaName AS 教师姓名,Semester AS 学期,CourseName AS 授课名称 From Teacher,Teaching,Course Where Teacher.TeaNum=Teaching.TeaNum and Course.CourseNum=Teaching.CourseNum";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable objDataTable = objDataBase.ShowTable(Sqlstring);

            return (objDataTable);
        }

    }
}
