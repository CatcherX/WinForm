using System.Data;
using DataBaseOperate;
using Model;

namespace DAL
{
    public class ProfessionDAL
    {
        public DataTable ShowProfession()
        {
            string SqlString = "select ProNum AS 专业号,ProName AS 专业名,Profession.deptNum AS 系别号,Department.DeptName as 系部名称 from dbo.Profession join Department on Profession.deptNum=Department.DeptNum";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            DataTable objDataTable = objDataBase.ShowTable(SqlString);
            return (objDataTable);

        }

        public bool AddProfessin(ProfessionModel objProfessionModel)
        {
            string SqlString = "INSERT INTO Profession(ProNum,ProName,deptNum)VALUES('" + objProfessionModel.ProNum + "','" + objProfessionModel.ProName + "','"+objProfessionModel.DepartNum + "')";


            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(SqlString))
                return (true);
            else
                return (false);
        }

        public bool UpdateProfession(ProfessionModel objProfessionModel)
        {
            string SqlString;

            //专业编号不可以修改，因它这里它用作搜索条件 ProNum='"+objProfessionModel.ProNum +"',
            SqlString = "update  dbo.profession set ProName='"+objProfessionModel.ProName+"',deptNum='"+ objProfessionModel.DepartNum + "' where ProNum='" + objProfessionModel.ProNum + "'";

            DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            if (objDataBase.GetExecute(SqlString))
                return (true);
            else
                return (false);

        }

        public bool DelProfession(ProfessionModel objProfessionModel)
        {
            string SqlString = "delete from profession where ProNum='" + objProfessionModel.ProNum + "'";
            DataBaseOperaClass objDataBase = new DataBaseOperaClass();
            
            //return (objDataBase.GetExecute(SqlString));
            return (objDataBase.GetExecute(SqlString));
        
        }

    }
}
