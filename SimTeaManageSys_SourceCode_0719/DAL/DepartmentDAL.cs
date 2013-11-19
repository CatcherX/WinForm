using System.Data;
using DataBaseOperate;
using Model;


namespace DAL
{
    public class DepartmentDAL
    {
        DataBaseOperaClass objDataBaseOperaClass = new DataBaseOperaClass();
        //DepartmentModel objDepartmentModel = new DepartmentModel();

        //ShowTable
        public DataTable ShowDepartment()
        {
            string SqlString = "Select * From Department";
            return objDataBaseOperaClass.ShowTable(SqlString);
        }


        //Add:
        public bool AddDepartment(DepartmentModel objDepartmentModel )
        {
            string SqlString = "insert into Department values('" + objDepartmentModel.DeptNum + "','" + objDepartmentModel.DeptName + "','" + objDepartmentModel.SchNum + "')";

            if (objDataBaseOperaClass.GetExecute(SqlString))
                return (true);
            else
                return (false);
        }

        //Update:
        public bool UpdateDepartment(DepartmentModel objDepartmentModel)
        { 
            string SqlString="Update Department Set SchNum='"+objDepartmentModel.SchNum+"',DeptNum='"+objDepartmentModel.DeptNum+"',DeptName='"+objDepartmentModel.DeptName+"'where DeptNum='"+objDepartmentModel.DeptNum+"'";

            if (objDataBaseOperaClass.GetExecute(SqlString))
                return (true);
            else
                return (false);
        }
             

        //Delete:
        public bool DelDepatment(DepartmentModel objDepartmentModel)
        {
            string SqlString = "Delete From Department Where DeptNum='" + objDepartmentModel.DeptNum + "'";

            if (objDataBaseOperaClass.GetExecute(SqlString))
                return (true);
            else
                return (false);
        }

        //Search:
        public DataTable SearchDeptment(DepartmentModel objDepartmentModel)
        {
            string SqlString = "Select * From Department Where DeptName='"+objDepartmentModel.DeptName+"'";

            return objDataBaseOperaClass.ShowTable(SqlString);
        }







    }
}
