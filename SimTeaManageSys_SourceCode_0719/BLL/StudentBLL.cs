using System.Data;
using Model;
using studentDAL;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL objStudentDAL = new StudentDAL();
        
        public DataTable ShowStuInfo()
        {
            return (objStudentDAL.ShowStuInfo());
        }

        public bool InsertStudent(StudentModel objstudentClass1)
        {
            return (objStudentDAL.InsertStudent(objstudentClass1));
        }

        public bool UpdateStudent(StudentModel objStudentModel)
        {
            return (objStudentDAL.Updatestudent(objStudentModel));
        }

        public bool DeleteStudent(string StuNum)
        {
            StudentDAL objstudentDALClss = new StudentDAL();
            return (objStudentDAL.DelStudent(StuNum));
        }

        public DataTable SearchStuInfo(StudentModel objStudentModel)
        {
            return (objStudentDAL.SearchStuInfo(objStudentModel));
        }

        public DataTable LoginUserSearchStuInfo(LoginUserModel objLoginUserModel)
        {
            return (objStudentDAL.LoginUserSearchStuInfo(objLoginUserModel));
        }

    }
}
