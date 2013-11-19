using System;
using System.Data;
using System.Windows.Forms;
using DataBaseOperate;
using DataBaseOperate2;
using Model;

namespace studentDAL
{
    public class StudentDAL
    {
        //刷新表格：
        #region 刷新表格
        //public DataTable ShowTableSelCourse()
        //{
        //    #region 刷新
        //    string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分,Score AS 成绩 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum";

        //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //    DataTable objDataTalbe = objDataBase.GetDataSet(SqlString).Tables[0];
        //    return (objDataTalbe);
        //}
        #endregion

        DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();



        public DataTable ShowStuInfo()
        {
            string SqlString = "Select * From V_Student_All_Info";
            
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable objDataTable = objDataBase.ShowTable(SqlString);
            return (objDataTable);
        }

        //Add:
        public bool InsertStudent(StudentModel objStudentModel)
        {
//string SqlString ="Insert into Student(StuNum,StuName,StuSex,Policity,Birthday,Favor,StuScore,Meno,ClaNum,Phone,Address) Values('"+objStudentModel.StuNum+"','"+objStudentModel.StuName+"','"+objStudentModel.StuSex+"','"+objStudentModel.Policity+"','"+objStudentModel.Birthday+"','"+objStudentModel.Favor+"','"+objStudentModel.StuScore+"','"+objStudentModel.Meno+"','"+objStudentModel.ClaNum+"','"+objStudentModel.Phone+"','"+objStudentModel.Address+"')";


            string SqlString = "Insert into V_Student_All_Info(学号,学生姓名,性别,出生日期,政治面目,班级编号,爱好,综合分,评价,联系电话,联系地址) Values('" + objStudentModel.StuNum + "','" + objStudentModel.StuName + "','" + objStudentModel.StuSex + "','" + objStudentModel.Birthday + "','" + objStudentModel.Policity + "','" + objStudentModel.ClaNum + "','" + objStudentModel.Favor + "','" + objStudentModel.StuScore + "','" + objStudentModel.Meno + "','" + objStudentModel.Phone + "','" + objStudentModel.Address + "')";

            try
            {
                if (objDataBaseOperateClass2.GetExecute(SqlString))
                    return (true);
                else
                    return (false);
            }
            catch(Exception e1)
            {
                MessageBox.Show("学号不能重复。\n请检查后再添加。"+e1);
                return (false);
            }

        }

        //Update:
        public bool Updatestudent(StudentModel objStudentModel)
        {
            //StuNum='"+objStudentModel.StuNum+"',
            string SqlString;
            //SqlString = "update  dbo.Student set StuName='"+objStudentModel.StuName+"',StuSex='"+objStudentModel.StuSex+"',Policity='"+objStudentModel.Policity+"',Birthday='"+objStudentModel.Birthday+"',Favor='"+objStudentModel.Favor+"',StuScore='"+objStudentModel.StuScore+"',Meno='"+objStudentModel.Meno+"',ClaNum='"+objStudentModel.ClaNum+"',Phone='"+objStudentModel.Phone+"',Address='"+objStudentModel.Address+"' where StuNum='"+objStudentModel.StuNum+"'";

            SqlString = "update V_Student_All_Info set 学号='" + objStudentModel.StuNum + "',学生姓名='" + objStudentModel.StuName + "',性别='" + objStudentModel.StuSex + "',出生日期='" + objStudentModel.Birthday + "',政治面目='" + objStudentModel.Policity + "',班级编号='" + objStudentModel.ClaNum + "',爱好='" + objStudentModel.Favor + "',综合分='" + objStudentModel.StuScore + "',评价='" + objStudentModel.Meno + "',联系电话='" + objStudentModel.Phone + "',联系地址='" + objStudentModel.Address + "'where 学号='"+objStudentModel.StuNum+"'";


            try
            {
                if (objDataBaseOperateClass2.GetExecute(SqlString))
                    return (true);
                else
                    return (false);
            }

            catch (Exception e1)
            {
                MessageBox.Show("错误信息"+e1);
                return (false);
            }


        }

        //Del:
        public bool DelStudent(string StuNum)
        {
            string SqlString = "delete from student where StuNum='" + StuNum + "'";
            return (objDataBaseOperateClass2.GetExecute(SqlString));
        }
      
        //Search:
     public DataTable SearchStuInfo(StudentModel objStudentModel)
    {
         //string SqlString = "Select * From Student Where StuNum='" + objStudentModel.StuNum + "'";       
        
        // string SqlString = "Select * From V_Student_All_Info where 班级='11应用嵌入式班'";
   string SqlString = "Select * From V_Student_All_Info where 学号='"+objStudentModel.StuNum+"'or 学生姓名='"+objStudentModel.StuName+"'or 班级='"+objStudentModel.ClaName+"'";

         return (objDataBaseOperateClass2.ShowTable(SqlString));
    }


        //按当前登录的身份来查找
     public DataTable LoginUserSearchStuInfo(LoginUserModel objLoginUserModel)
     {
         string SqlString = "Select * From Student Where StuNum='"+objLoginUserModel.UserId + "'"; 
         return (objDataBaseOperateClass2.ShowTable(SqlString));
     }



    }
}
