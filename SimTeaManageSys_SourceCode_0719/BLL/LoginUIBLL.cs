using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;

namespace BLL
{
    public class LoginUIBLL
    {
        LoginUIDAL objLoginUIDAL = new LoginUIDAL();

        
        
        
        public SqlDataReader LoginUserRead()
        {
            return (objLoginUIDAL.LoginuserRead());
        }
        
        //按条件从数据库读取内容
        public SqlDataReader LoginUserRead(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.LoginUserRead(objLoginUserModel));
        }


        
        public DataTable GetTable()
        {
            return (objLoginUIDAL.GetTable());
        }

        public DataSet GetTable(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.GetTable(objLoginUserModel));
        }

        //Add;
        public bool AddLoginUser(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.AddLoginUser(objLoginUserModel));
        }

        //Update:
        public bool UpdatLoginUser(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.UpdateLoginUser(objLoginUserModel));
        }
        
        //Del:
        public bool DelLoginUser(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.DelLoginUser(objLoginUserModel));
        }
        
        //Search:
        public DataTable SearchLoginUser(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.SearchLoginUser(objLoginUserModel));
        }

        //Change LoginUser States
        public bool UpdateLoginUserStates(LoginUserModel objLoginUserModel)
        {
            return (objLoginUIDAL.UpdateLoginUserStateOpen(objLoginUserModel));
        }


        public bool UpdateLoginUserStateClose( )
        {
            return (objLoginUIDAL.UpdateLoginUserStateClose());
        }
             

    }
}
