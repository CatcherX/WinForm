using System;
using System.Data;
using System.Windows.Forms;
using DataBaseOperate;
using Model;

namespace DAL
{
    public class TeacherDAl
    {

        public bool AddTeacher(TeacherModel objTeacherModel)
        {
            string Sqlstring = "INSERT INTO Teacher(TeaNum,TeaName,TeaSex,TeaAdress,TeaPhone,TeaTitle)VALUES ('" + objTeacherModel.TeaNum + "','" + objTeacherModel.TeaName
      + "','" + objTeacherModel.TeaSex + "','" + objTeacherModel.TeaAdress + "','" + objTeacherModel.TeaPhone + "','" + objTeacherModel.TeaTitle + "')";
           
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            try
            {
                if (objDataBase.GetExecute(Sqlstring))
                    return (true);
                else
                    return (false);
            }
            catch (Exception e1)
            {
                MessageBox.Show("教师工号不能重复\n请检查输入内容！" + e1);
                return (false);
            }

        }
       
        public bool UpdateTea(TeacherModel objTeacherModel)
        {
            string SQLString;
            SQLString = "UPDATE Teacher SET TeaName='" + objTeacherModel.TeaName + "',TeaSex='" + objTeacherModel.TeaSex + "'";
            SQLString += ",TeaPhone='" + objTeacherModel.TeaPhone + "',TeaAdress='" + objTeacherModel.TeaAdress + "'";
            SQLString += ",TeaTitle='" + objTeacherModel.TeaTitle + "',TeaNum='" + objTeacherModel.TeaNum + "' where TeaNum='" + objTeacherModel.TeaNum + "'";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(SQLString))
                return (true);
            else
                return (false);
        }

        //删除教师员工
        public bool DeleteTeacher(TeacherModel objTeacherModel)
        {
            string SqlString = "delete FROM Teacher WHERE TeaNum='" + objTeacherModel.TeaNum + "' ";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            return (objDataBase.GetExecute(SqlString));
        }
          
        //获取教师员工
        public DataTable ShowTeacher()
        {
            string SqlString = "Select TeaNum AS 工号,TeaName AS 姓名,TeaSex AS 性别, TeaAdress AS 联系地址,TeaPhone AS 联系电话,TeaTitle AS 职称,TeaProField AS 专业方向 From dbo.Teacher";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable ObjDataTable = objDataBase.GetDataSet(SqlString).Tables[0];
            return (ObjDataTable);
        }
          
        
        //查找教师员工
        public bool SearchTeacher(TeacherModel objTeacherModel)
        {
            string SqlString = "SELECT *FROM Teacher  where TeaName='" + objTeacherModel.TeaName + "'";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

           if  (objDataBase.GetDataSet(SqlString ).Tables[0].Rows.Count >0)
               return (true);
           else
               return (false);
        }

        //返回查找结果：
        public DataTable SearchTea(TeacherModel objTeacherModel)
        {
            string SqlString = "Select TeaNum AS 工号,TeaName AS 姓名,TeaSex AS 性别, TeaAdress AS 联系地址,TeaPhone AS 联系电话,TeaTitle AS 职称,TeaProField AS 专业方向 From dbo.Teacher Where TeaNum='"+objTeacherModel.TeaNum+"'";

            DataBaseOperaClass objDataBaseOperaClass=new DataBaseOperaClass();
            DataTable objDataTable = objDataBaseOperaClass.GetDataSet(SqlString).Tables[0];
            
            return (objDataTable);
        }


    }
}
