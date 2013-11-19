using System.Data;
using System.Data.SqlClient;
using DataBaseOperate;
using Model;



namespace DAL
{
    public class ClassDAL
    {
        
        //添加班级信息
        //public bool AddClass(ClassModel objClassModel)
        //{
        ////string Sqlstring = "insert into Class(ClaNum,ClaName,DeptNum,ProNum) values('"+objClassModel.ClaNum+"','"+objClassModel.ClaName+  "','"+ objClassModel.DeptNum +"','"+ objClassModel.ProNum +"')";

        //    string SqlString = "Insert into V_ClassInfo (班级编号,班级名称,专业编号,系部编号) Values('" + objClassModel.ClaNum + "','" + objClassModel.ClaName + "','" + objClassModel.ProNum + "','" + objClassModel.DeptNum + "')";
 
        //DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //if (objDataBase.GetExecute(SqlString))
        //    return (true);
        //else
        //    return (false);
        //}

        #region 参数化SQL
        public bool AddClass(ClassModel objClassModel)
        {
            string SqlString = "Insert into V_ClassInfo (班级编号,班级名称,专业编号,系部编号) Values(@ClaNum,@ClaName,@ProNum,@DeptNum)";

            SqlParameter[] parms ={
                                    new SqlParameter("@ClaNum",objClassModel.ClaNum),
                                    new SqlParameter("@ClaName",objClassModel.ClaName),
                                    new SqlParameter("@ProNum",objClassModel.ProNum),
                                    new SqlParameter("@DeptNum",objClassModel.DeptNum)
                                 };
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(SqlString,parms))
                return (true);
            else
                return (false);
        }
        #endregion



       
        //修改班级信息
        public bool ChangeClass(ClassModel objClassModel)
        {
            //string Sqlstring;
            //Sqlstring = "update Class set ClaNum ='" + objClassModel.ClaNum + "',ClaName ='" + objClassModel.ClaName + "',DeptNum ='" + objClassModel.DeptNum + "',ProNum ='" + objClassModel.ProNum + "' where ClaNum ='"+objClassModel.ClaNum+"'";

            string SqlString="Update V_ClassInfo set 班级编号='"+objClassModel.ClaNum+"',班级名称='"+objClassModel.ClaName+"',专业编号='"+objClassModel.ProNum+"',系部编号='"+objClassModel.DeptNum+"'where 班级编号='"+objClassModel.ClaNum+"'";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();


            if (objDataBase.GetExecute(SqlString))
                return (true);
            else
                return (false);

        }


     
        //删除班级信息
        public bool DeleteClass(ClassModel objClassModel)
        {
            string Sqlstring = "delete from Class where ClaNum = '" + objClassModel.ClaNum + "'";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(Sqlstring))
                return (true);
            else
                return (false);
        }


      
        //任务14
        //获取所有班级信息
        public DataTable ShowClass()
        {
            //string Sqlstring = "select ClaNum AS 班级号,ClaName AS 班级名,DeptNum AS 系别编号,ProNum AS 专业编号 from dbo.Class";

            string SqlString = "Select * From V_ClassInfo";
            
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable objDataTable = objDataBase.ShowTable(SqlString);

            return (objDataTable);
        }


       
        //查找班级信息

        public bool SearchClass(ClassModel objClassModel)
        {
            string Sqlstring = "select * from Class where ClaNum ='" + objClassModel.ClaNum+ "'";


            DataBaseOperaClass objDataBaseOperaClass = new DataBaseOperaClass();

            if (objDataBaseOperaClass.GetDataSet(Sqlstring).Tables[0].Rows.Count > 0)
                return (true);
            else
                return (false);
        }





    }
}
