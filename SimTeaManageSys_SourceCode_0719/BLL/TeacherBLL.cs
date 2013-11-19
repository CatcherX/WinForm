using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class TeacherBLL
    {
             public DataTable ShowTeacher()
            {
               TeacherDAl objTeacherDALClss = new TeacherDAl();
                return (objTeacherDALClss.ShowTeacher ());
            }

          

             public bool AddTeacher(TeacherModel objTeacherModel)
            {
            
                TeacherDAl objTeacherDAL = new TeacherDAl();

                return (objTeacherDAL.AddTeacher(objTeacherModel));

    
            }

             public bool UpdateTea(TeacherModel objTeacherModel)
            {
                TeacherDAl objTeacherDAL = new TeacherDAl();

                return (objTeacherDAL.UpdateTea(objTeacherModel));

            }


             public bool DeleteTeacher(TeacherModel objTeacherModel)
             {
                 TeacherDAl objTeacherDAl = new TeacherDAl();
                 return (objTeacherDAl.DeleteTeacher(objTeacherModel));
             }


             public DataTable SearchTea(TeacherModel objTeacherModel)
             { 
                TeacherDAl objTeacherDAl=new TeacherDAl();
                 return(objTeacherDAl.SearchTea(objTeacherModel));
             }

    }
        
}

