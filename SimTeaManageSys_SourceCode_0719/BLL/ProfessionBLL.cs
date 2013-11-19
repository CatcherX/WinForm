using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class ProfessionBLL
    {
        public DataTable ShowProfession()
        {
            ProfessionDAL objProfessionDALClss = new ProfessionDAL();
            return (objProfessionDALClss.ShowProfession());
        }


        public bool InsertProfession(ProfessionModel objProfessionModel)
        {
            ProfessionDAL objProfessionDAL = new ProfessionDAL();
            return (objProfessionDAL.AddProfessin(objProfessionModel));
        }


        public bool UpdatejProfession(ProfessionModel objProfessionModel)
        {
            ProfessionDAL objProfessionDAL = new ProfessionDAL();
            return (objProfessionDAL.UpdateProfession(objProfessionModel));
        }
   

        public bool DelProfession(ProfessionModel objProfessionModel)
        {
            ProfessionDAL objProfessionDAL = new ProfessionDAL();
            return (objProfessionDAL.DelProfession(objProfessionModel));
            
        }

       
   

      
 }
 }
