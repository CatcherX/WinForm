using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataBaseOperate;

namespace DataBaseOperate2
{
    /// <summary>
    /// 连接数据库的类库
    /// </summary>
    public class DataBaseOperateClass2 : DataBaseOperaClass  //继承已经封装好的类库并进行扩展：增加一个获取数据行的方法：
    {
        #region 执行SQL语句，以获取相应数据行
                /// <summary>
                /// 执行SQL语句，以获取相应数据行
                /// </summary>
                /// <param name="SQLString">要执行的SQL语句</param>
                /// <returns>执行sql语句得到的数据行</returns>
                public DataRow GetDataRow(string SQLString)
                {
                    SqlConnection objConn = new SqlConnection();
                    objConn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    objConn.Open();
                    string cmdtxt = SQLString;

                    SqlCommand objComm2 = new SqlCommand(cmdtxt, objConn);

                    SqlDataAdapter objAdapter = new SqlDataAdapter(objComm2);
                    DataSet objDataSet = new DataSet();

                    objAdapter.Fill(objDataSet);
                    objConn.Close();

                    if (objDataSet.Tables[0].Rows.Count > 0)
                        return (objDataSet.Tables[0].Rows[0]);
                    else
                        return (null);

                }
        #endregion


       #region 执行SQL语句，以获取相应数据行【参数化sql语句】
                /// <summary>
                /// 执行SQL语句，以获取相应数据行【参数化sql语句】
                /// </summary>
                /// <param name="SqlString">要执行的SQL语句</param>
                /// <param name="parms">参数组</param>
                /// <returns>执行sql语句得到的数据行</returns>
                public DataRow GetDataRow(string SqlString,SqlParameter[] parms)
                {
                    SqlConnection objConn = new SqlConnection();
                    objConn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    objConn.Open();
                    string cmdtxt = SqlString;

                    SqlCommand objComm2 = new SqlCommand(cmdtxt, objConn);
                    objComm2.Parameters.Clear();

                    if (parms != null)
                        objComm2.Parameters.AddRange(parms);

                    SqlDataAdapter objAdapter = new SqlDataAdapter(objComm2);
                    DataSet objDataSet = new DataSet();

                    objAdapter.Fill(objDataSet);
                    objConn.Close();

                    if (objDataSet.Tables[0].Rows.Count > 0)
                        return (objDataSet.Tables[0].Rows[0]);
                    else
                        return (null);

                }
                #endregion

    }
}
