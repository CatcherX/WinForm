using System;
using System.Data;
using System.Windows.Forms;
using DataBaseOperate;
using DataBaseOperate2;
using Model;


namespace DAL
{
                        

    public class SchoolDAL    //这里开关要增加公有访问修饰符：public，以便能够在其它类中调用它；
    {
        //添加
        public bool AddSchool(SchoolModel objSchoolModel)
        {
            #region 使用实体类在各层之间传递数据
                
     string SqlString = "insert into School values ('"+objSchoolModel.SchNum+"','"+ objSchoolModel.SchName+"')";
            
                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                if (objDataBase.GetExecute(SqlString))
                     return (true);
                else
                     return (false);

            #endregion

       }
          

         //修改：
        public bool Update(SchoolModel objSchoolModel)
        {
            #region 使用实体类在各层
    string SqlString = "Update School Set SchNum='" +objSchoolModel.SchNum + "',SchName='" + objSchoolModel.SchName +"'where SchNum='"+objSchoolModel.SchNum+"'";

                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

              
                    if (objDataBase.GetExecute(SqlString))
                        return (true);
                    else
                        return (false);
              

            #endregion
        } 
     

        //删除：
            #region 使用实体类在各层之间传递数据

            public bool DelSchool(SchoolModel objSchoolModel)
            {
                    
                string SqlString = "delete from School where SchNum='" + objSchoolModel.SchNum + "'";
                DataBaseOperaClass objDataBase = new DataBaseOperaClass();
                    
                try
                    {
                        if (objDataBase.GetExecute(SqlString))
                            return (true);
                        else
                            return (false);
                    }
                catch (Exception e1)
                    {
                        MessageBox.Show("该学校有数据！\n不能删除！\n删除前请先清空学校下属的所有内容！"+e1);
                        return (false);
                    }

             

            }
            #endregion


            public DataTable ShowSchoolInfo()
            {

                    string SqlString = "Select SchNum AS 学校代码, SchName AS 校区 From School";

                    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                    DataTable objDataTalbe = objDataBase.GetDataSet(SqlString).Tables[0];
                    return (objDataTalbe);
          
            } 
          

            //获取表格数据给下拉字段使用：
             public string[] GetSchNum()
             {
                string SqlString = "Select SchNum AS 学校代码, SchName AS 校区 From School";

                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                DataTable objTable = objDataBase.ShowTable(SqlString);
                string[] SchNum = new string[objTable.Rows.Count];
                for (int i = 0; i < objTable.Rows.Count; i++)
                    SchNum[i] = objTable.Rows[i][0].ToString();
                return (SchNum);
             }

              


            #region 返回查找结果
              public DataTable SearchSchool(SchoolModel objSchoolMolel)
                {
                    string SqlString = "Select SchNum AS 学校代码, SchName AS 校区 From School";

                    DataBaseOperateClass2 objDataBase = new DataBaseOperateClass2();

                    DataTable objDataTable;

                    return objDataTable = objDataBase.ShowTable(SqlString);
                }
            #endregion
    }

}
