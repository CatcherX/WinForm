using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; //引入配置文件命名空间；          

namespace DataBaseOperate
{
    /// <summary>
    /// 数据库操作类，包含了对数据库操作的方法；
    /// </summary>
    public class DataBaseOperaClass
    {
        /// <summary>
        /// 执行SQL语句，以获取相应的数据表
        /// </summary>
        /// <param name="SQLString">要执行的SQL语句</param>
        /// <returns>执行SQL语句后要返回的数据表</returns>
        
        public DataTable ShowTable(string SQLString)  //定义非静态方法,调用时需要先new一对象.
        {
            SqlConnection objConn = new SqlConnection();

            //为了使不同数据库都可以使用这个类库，改用配置文件字符串：
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                #region SQLConnectionString

            // objConn.ConnectionString = "Data Source=.\\SQLExpress;Database=StuManageSystem_2008;Integrated Security=SSPI";

            // objConn.ConnectionString = "Data Source=(Local);Initial Catalog=StuManageSystem_2008;Integrated Security=True";
            //objConn.ConnectionString = "SERVER = (local);Database=StuManageSystem;Integrated Security=SSPI"; 
            #endregion
            
                objConn.Open();
                string cmdtxt = SQLString;
         
            SqlDataAdapter objAdapter = new SqlDataAdapter(cmdtxt, objConn);
            DataSet objDataSet = new DataSet();

            objAdapter.Fill(objDataSet);
            objConn.Close();
            
            return (objDataSet.Tables[0]);
        }

        #region 参数化处理：
        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="SqlString">执行获取数据表的SQL语句</param>
        /// <param name="parms">参数</param>
        /// <returns>返回数据表</returns>
        public DataTable ShowTable(string SqlString,SqlParameter[] parms) 
        {
            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            objConn.Open();

            string cmdtxt = SqlString;

            SqlDataAdapter objAdapter = new SqlDataAdapter(cmdtxt, objConn);//用DataAdapet接收查询到的结果
            objAdapter.SelectCommand.Parameters.Clear();

            if (parms != null)
            {
                objAdapter.SelectCommand.Parameters.AddRange(parms);
            }

            DataSet objDataSet = new DataSet();//建立一个数据集，用来保存dataAdapter获取到的数据

            objAdapter.Fill(objDataSet);//把Adapter获取到的数据放到objDataSet中
            objConn.Close();

            return (objDataSet.Tables[0]);//返回DataSet数据集的第一个表；
        }
        #endregion













        #region 三种方式返回值
        //第一种：
        //把一个获取数据集的方法写在类中:用【return】返回值！
        public DataSet GetDataSet(string SQLString)
        {
            SqlConnection objConn=new SqlConnection();      //new 一个连接对象;
            
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            objConn.Open();

            //创建command对象,获取数据库表的信息:
            string cmdtxt=SQLString;
            SqlCommand objComm2=new SqlCommand(cmdtxt,objConn);

            SqlDataAdapter objAdapter =new SqlDataAdapter(objComm2);

            DataSet objDataSet=new DataSet();

            //执行SQL语句,将执行的结果填充到DataSet中:
            objAdapter.Fill(objDataSet);
            objConn.Close();

            return (objDataSet);
        }

        

        //Through the parameter return value:

        //第二种：使用【out】关键字返回值：
        //public void GetDataSet(string SqlString,out DataSet objDataSet)
        //{
        //    SqlConnection objConn=new SqlConnection();
        //    objConn.ConnectionString = "SERVER = (local);Database=StuManageSystem;Integrated Security=SSPI";
        //    objConn.Open();

        //    //创建command对象，获取数据表信息：
        //    String cmdtxt = SqlString;
        //    SqlCommand objcomm2 = new SqlCommand(cmdtxt,objConn);

        //    SqlDataAdapter objAdapter = new SqlDataAdapter(objcomm2);

        //    objDataSet = new DataSet();

        //    objAdapter.Fill(objDataSet);
        //    objConn.Close();
        //}

        //第三种：使用【引用类型】返回值：
        public SqlDataReader getread(string SQLString)  
        {
            
            string cmdtxt = SQLString;

            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            objConn.Open();
            SqlCommand sqlcom = new SqlCommand(SQLString, objConn);
            SqlDataReader sqldr = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqldr;
        }
        #endregion




        //给comboBox控件调用用到的方法：
        public static SqlDataReader getread(string SQLString, SqlParameter[] parms)
        {
            string cmdtxt = SQLString;

            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            objConn.Open();
            SqlCommand sqlcom = new SqlCommand(SQLString, objConn);
            try
            {
                if (parms != null)
                    sqlcom.Parameters.AddRange(parms);
                SqlDataReader sqldr = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                sqlcom.Parameters.Clear();
                sqlcom.Dispose();
                return sqldr;
            }
            catch
            {
                objConn.Close();
                throw;
            }
        }

        //使用引用类型返回数据集：      //★★★★★重载！
        public void GetDataSet(String SqlString, DataSet objDataSet)
        {
            SqlConnection objConn = new SqlConnection();

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            objConn.Open();

            String cmdtxt = SqlString;
            SqlCommand objcomm2 = new SqlCommand(cmdtxt, objConn);

            SqlDataAdapter objAdapter = new SqlDataAdapter(objcomm2);

            //objDataSet = new DataSet();       //很模糊。。。。  解决
            //执行SQL语句，将结果填充到DataSet中：
            objAdapter.Fill(objDataSet);
            objConn.Close();
        }
        /*
         SqlConnection sqlconn = getsqlconn();
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlconn);
            sqlcom.Parameters.Clear();
            if (parms != null)
                sqlcom.Parameters.AddRange(parms); //这个语句一定要，陈老师的程序中少了这个语句
            //sqlcom.Parameters.Clear();
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            sqlconn.Close();
         */
        public bool GetExecute(string SqlString)
        {
            SqlConnection objConn = new SqlConnection();
            
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); 
            
            objConn.Open();

            SqlCommand objSqlCommand = new SqlCommand();
            objSqlCommand.CommandText = SqlString; //接收字符串
            objSqlCommand.Connection = objConn;

            if (objSqlCommand.ExecuteNonQuery() > 0)
            { objConn.Close(); return (true); }
            else
            { objConn.Close(); return (false); }
        }
        
        
        //把添加、删除、修改三段代码抽象成执行Command对象的方法：【参数化SQL语句】
        public bool GetExecute(string SqlString, SqlParameter[] parms) //该方法用来执行SQL语句
        {
            SqlConnection objConn = new SqlConnection();

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            objConn.Open();
            SqlCommand objSqlCommand = new SqlCommand(SqlString,objConn);
            objSqlCommand.Parameters.Clear();
            if (parms != null)
                objSqlCommand.Parameters.AddRange(parms);

            //objSqlCommand.CommandText = SqlString; //接收字符串
            //objSqlCommand.Connection = objConn;

            if (objSqlCommand.ExecuteNonQuery() > 0)
            { objConn.Close(); return (true); }
            else
            { objConn.Close(); return (false); }
        }


        /// <summary>
        /// //方法重载：执行存储过程：
        /// </summary>
        /// <param name="objSqlCommand"></param>
        /// <returns>//方法重载：执行存储过程：</returns>
        public bool GetExecute(SqlCommand objSqlCommand)
        {
            SqlConnection objConn = new SqlConnection();

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            objConn.Open();

            objSqlCommand.Connection = objConn;

            bool result = true;


            //★★异常捕捉：添加学生出错的异常处理：

            try
            {
                if (objSqlCommand.ExecuteNonQuery() > 0)
                { objConn.Close(); }
                else
                { objConn.Close(); result = false; }
            }
            catch (SystemException e) 
            {

                MessageBox.Show(e.Message);  
            }
            return result;

        }
    }

}


