using System.Data;
using System.Data.SqlClient;
using DataBaseOperate2;
using Model;


namespace DAL
{
    public class LoginUIDAL
    {
    
  DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();
  string SqlString;



  public SqlDataReader LoginuserRead()//搜索状态为连接的用户：
  {
      SqlString = "Select * From LoginUser Where State='连接'";
      return (objDataBaseOperateClass2.getread(SqlString));
  }


 //这是程序启动后，第一条发送到SQL数据库的语句;容易出现异常，所以这里进行异常捕捉、处理。


      public SqlDataReader LoginUserRead(LoginUserModel objLoginUserModel)
      //根据条件搜索用户名，用于验证用户名与密码、身份是否一致
       {
        SqlString = "Select UserId From LoginUser Where UserId='"+objLoginUserModel.UserId+"' AND UserPw='"+objLoginUserModel.UserPw+"' AND UserRole='"+objLoginUserModel.UserRole+"'";
         //try{
              return (objDataBaseOperateClass2.getread(SqlString));
         #region MyRegion
		   //}
     //   catch (Exception e1)
     //       {
     //           if (MessageBox.Show("登录失败！你是否仔细阅读了使用说明呢？请根据错误消息进行处理。\n是否查看错误消息？", "温馨提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
     //           {
     //             MessageBox.Show("错误消息：" + e1);
     //             //MessageBox.Show("即将返回使用说明窗口！");
     //             MessageBox.Show("再见!如需要登录使用，请重新启动程序，仔细阅读说明后再操作！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
     //             //Application.Exit();   //执行这一句后，为什么不能把整个程序结束呢？还会继续执行。怎样停止？或者改为调用其它窗口也可以。
     //             //Application.ExitThread();
                    
     //           }
     //           else
     //           {
     //               //MessageBox.Show("即将返回使用说明窗口！");
     //MessageBox.Show("再见!如需要登录使用，请重新启动程序，仔细阅读说明后再操作！","温馨提醒",MessageBoxButtons.OK, MessageBoxIcon.Information);
     //               Application.Exit();
     //               ////▲▲▲在类库文件可以调用窗口吗？要加using？加哪个？还是要通过另外一个方法来调用出窗口？
     //           }
     //               SqlDataReader aa=null;
     //               return aa;
                    //return (objDataBaseOperateClass2.getread(SqlString));
     //▲▲▲怎样【不经过数据库】而返回一个空的SqlDataReader类型的变量，当连接不到数据库时，想让它返回一个空的,避免再次异常,
            //文本控件的空值可以表示为:XXX.Text="",那SqlDataReader类型声明的变量如何赋空值？ 
	#endregion
            
            // }
     }
  
 

  public void BaseTale()
  {
      SqlString = "Select UserId as 用户编号,UserRole AS 用户身份, UserPw as 用户密码 ,LoginCount AS 登录次数 From LoginUser Where UserId='admin'";
  }

        //获取数据集：
  public DataTable GetTable()
  {
      //BaseTale();

      SqlString = "Select UserId as 用户编号,UserRole AS 用户身份, UserPw as 用户密码 ,LoginCount AS 登录次数 From LoginUser";
      return (objDataBaseOperateClass2.ShowTable(SqlString));
  }

  public DataSet GetTable(LoginUserModel objLoginUserModel)
  {
      BaseTale();
      SqlString += "Where UserId'" + objLoginUserModel.UserId + "'Or UserRole='"+objLoginUserModel.UserRole+"'Or LoginCount='"+objLoginUserModel.LoginCount+"'";

      return (objDataBaseOperateClass2.GetDataSet(SqlString));
  }

   //Add:
  public bool AddLoginUser(LoginUserModel objLoginUserModel)
  {
      objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(objLoginUserModel.UserId + objLoginUserModel.UserPw);

      SqlString = "Insert into LoginUser(UserId,UserRole,UserPw,LoginCount) Values('" + objLoginUserModel.UserId + "','" + objLoginUserModel.UserRole + "','" + objLoginUserModel.UserPw + "','" + objLoginUserModel.LoginCount + "')";

      return (objDataBaseOperateClass2.GetExecute(SqlString));
  }

    //Update:
  public bool UpdateLoginUser(LoginUserModel objLoginUserModel)
  {
     objLoginUserModel.UserPw = GetMD5.GetMd5.GetMd5_32(objLoginUserModel.UserId + objLoginUserModel.UserPw);

    SqlString ="Update LoginUser Set UserId='"+objLoginUserModel.UserId+"',UserRole='"+objLoginUserModel.UserRole+"',UserPw='"+objLoginUserModel.UserPw+"',LoginCount='"+objLoginUserModel.LoginCount+"'where UserID='"+objLoginUserModel.UserId+"'";

    return (objDataBaseOperateClass2.GetExecute(SqlString));
  
  }

    //Del:
  public bool DelLoginUser(LoginUserModel objLoginUserModel)
  {


    SqlString = "Delete From LoginUser Where UserId='"+objLoginUserModel.UserId+"'";

    return (objDataBaseOperateClass2.GetExecute(SqlString));
  
  }


    //Search:
  public DataTable SearchLoginUser(LoginUserModel objLoginUserModel)
  {
      SqlString = "Select UserId as 用户编号,UserRole AS 用户身份, UserPw as 用户密码 ,LoginCount AS 登录次数 From LoginUser Where UserId='" + objLoginUserModel.UserId + "'Or UserRole='" + objLoginUserModel.UserRole + "'Or LoginCount='" + objLoginUserModel.LoginCount + "'";

      return objDataBaseOperateClass2.ShowTable(SqlString);
  }

    //Changes LoginUser's States Use to Show Login Interface
  public bool UpdateLoginUserStateOpen(LoginUserModel objLoginUserModel)
  {
      SqlString = "Update LoginUser Set State='连接' where UserId='" + objLoginUserModel.UserId + "'";

      return (objDataBaseOperateClass2.GetExecute(SqlString));
  }

        public bool UpdateLoginUserStateClose( )
  {
      SqlString = "Update LoginUser Set State='断开'";

      return (objDataBaseOperateClass2.GetExecute(SqlString));
  
  }






    }
}
