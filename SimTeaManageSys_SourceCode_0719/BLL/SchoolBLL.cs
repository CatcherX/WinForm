using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class SchoolBLL
    {
        SchoolDAL objSchoolDAL = new SchoolDAL();

        
        
        //刷新网格：
            public DataTable ShowSchoolInfo()
            {
                return (objSchoolDAL.ShowSchoolInfo());
            }

        

        #region 读取数据库表中的列字段到下拉表：
            public string[] GetSchNum()
            {
                string[] SchNum = objSchoolDAL.GetSchNum();
                return (SchNum);
            }
        #endregion

            


        //add:
            public bool AddSchool(SchoolModel objSchoolModel)
            {
                SchoolDAL objSchoolDAL = new SchoolDAL();
                return objSchoolDAL.AddSchool(objSchoolModel);
            }

        //Update:
            public bool UpdateSchool(SchoolModel objSchoolModel)
            {
                SchoolDAL objSchoolDAL = new SchoolDAL();
                return objSchoolDAL.Update(objSchoolModel);
            }
        
        //Delete:
            public bool delSchool(SchoolModel objSchoolModel)
            {
                SchoolDAL objSchoolDAL = new SchoolDAL();
                return objSchoolDAL.DelSchool(objSchoolModel);
            
            }


















    }
}
