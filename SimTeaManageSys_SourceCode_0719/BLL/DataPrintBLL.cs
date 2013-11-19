using System.Data;

namespace BLL
{
    public class DataPrintBLL
    {
            DataPrintDAL objDataPrint = new DataPrintDAL();

            public DataTable SchoolInfo()
            {
                return (objDataPrint.SchollInfo());
            }
        
            public DataTable  PrintStuInfo()
            {
                return (objDataPrint.PrintStuInfo());
            }

            public DataTable PrintAdminInfo()
            {
                return (objDataPrint.PrintAdminInfo());
            }

            public DataTable PrintCourseInfo()
            {
                return (objDataPrint.PrintCourseInfo());
            }

            public DataTable PrintTeaInfo()
            {
                return (objDataPrint.PrintTeaInfo());
            }

            public DataTable PrintClassScore()
            {
                return (objDataPrint.PrintClassScore());
            }


    }
}
