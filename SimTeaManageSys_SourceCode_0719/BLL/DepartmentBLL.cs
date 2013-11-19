using System.Data;
using DAL;
using Model;

namespace BLL
{
    
    public class DepartmentBLL
    {
        DepartmentDAL objDepartmentDAL = new DepartmentDAL();
        //DepartmentModel objDepartmentModel = new DepartmentModel();

        //ShowTable
        public DataTable ShowDeptment()
        {
            return objDepartmentDAL.ShowDepartment();
        }

        //Add
        public bool AddDeptment(DepartmentModel objDepartmentModel)
        {
            return objDepartmentDAL.AddDepartment(objDepartmentModel);
        }

        //Updatae:
        public bool UpdateDeptment(DepartmentModel objDepartmentModel)
        {
            return objDepartmentDAL.UpdateDepartment(objDepartmentModel);
        }

        //Delete:
        public bool DelDeptment(DepartmentModel objDepartmentModel)
        {
            return objDepartmentDAL.DelDepatment(objDepartmentModel);
        }

        //Search:

        public DataTable SearchDeptment(DepartmentModel objDepartmentModel)
        {
            return objDepartmentDAL.SearchDeptment(objDepartmentModel);
        }



    }
}
