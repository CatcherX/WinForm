using System.Data;
using System.Data.SqlClient;
using DataBaseOperate;
using DataBaseOperate2; //引入命名空间，使用继承DataBaseOperaClass后扩展的获取数据行的方法；
using IDAL;
using Model;

namespace DAL
{
    /// <summary>
    /// //数据访问层的添加（选课），修改，删除（退选），查找代码：
    /// </summary>
    
    public class SelCourseDAL:ISelCourseDAL    //这里开关要增加公有访问修饰符：public，以便能够在其它类中调用它；
    {
        //添加（选课）代码：
            #region 使用字符串作参数，已注释掉，改为使用数组作为参数
            //public bool SelOk(string StuNum, string CourseNum, string Score)
            //{
            //    string SqlString = "Insert into SelCourse(StuNum,CourseNum,Score) Values('" + StuNum + "','" + CourseNum + "','" + Score + "')";

            //    //objSqlCommand.CommandText = Sqlstring;
            //    //objSqlCommand.Connection = objConn;

            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    if (objDataBase.GetExecute(SqlString))
            //        return (true);
            //    else
            //        return (false);
            //} 
            #endregion

            #region 使用数组作为参数,已注释！
                //public bool SelOk(string[] SelCourse)
                //{
                //    string SqlString = "Insert into SelCourse(StuNum,CourseNum,Score) Values('" + SelCourse[0] + "','" + SelCourse[1] + "','" + SelCourse[2] + "')";

                //    //objSqlCommand.CommandText = Sqlstring;
                //    //objSqlCommand.Connection = objConn;

                //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                //    if (objDataBase.GetExecute(SqlString))
                //        return (true);
                //    else
                //        return (false);
                //}
            #endregion
        
            #region 使用实体类在各层之间传递数据//
            //public bool SelOk(SelCourseModel objSelCourseModel)
            //{
            //    string SqlString = "Insert into SelCourse(StuNum,CourseNum,Score) Values('" + objSelCourseModel.StuNum + "','" + objSelCourseModel.CourseNum + "','" + objSelCourseModel.Score + "')";


            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    if (objDataBase.GetExecute(SqlString))
            //        return (true);
            //    else
            //        return (false);
            //}
            #endregion

            #region 【参数化sql】
            public bool SelOk(SelCourseModel objSelCourseModel)
            {
                string SqlString = "Insert into SelCourse(StuNum,CourseNum) Values(@StuNum ,@CourseNum)";
                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                SqlParameter[] parms = {
                                                new SqlParameter("@StuNum", objSelCourseModel.StuNum),
                                                new SqlParameter("@CourseNum",objSelCourseModel.CourseNum),
                                                //new SqlParameter("@Score",objSelCourseModel.Score)
                                        };

                if (objDataBase.GetExecute(SqlString, parms))
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }
        #endregion

         //修改：
            #region 使用字符串作参数、已注释掉，改为使用参数数组
        //public bool Update(string StuNum, string Score, string CourseNum)
        //{
        //    string SqlString = "Update SelCourse Set StuNum='" + StuNum + "',Score='" + Score + "',CourseNum='" + CourseNum + "' where StuNum='" + StuNum + "'";

        //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //    if (objDataBase.GetExecute(SqlString))
        //        return (true);
        //    else
        //        return (false);
      //  } 
        #endregion

            #region 使用参数数组作为参数,已注释
            //public bool Update(params string[] SelCorse)
            //{
            //    #region  已注释掉，改为使用参数数组
            //    //string SqlString = "Update SelCourse Set StuNum='" + StuNum + "',Score='" + Score + "',CourseNum='" + CourseNum + "' where StuNum='" + StuNum + "'"; 
            //    #endregion

            //    string SqlString = "Update SelCourse Set StuNum='" + SelCorse[0] + "',CourseNum='" + SelCorse[1] + "',Score='" + SelCorse[2] + "' where StuNum='" + SelCorse[0] + "'";

            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    if (objDataBase.GetExecute(SqlString))
            //        return (true);
            //    else
            //        return (false);
            //} 
            #endregion

            #region 使用实体类在各层之间传递数据  //
   //     public bool Update(SelCourseModel objSelCourseClass)
   //         {
   //             //string SqlString = "Update SelCourse Set StuNum='" + objSelCourseClass.StuNum + "',CourseNum='" + objSelCourseClass.CourseNum + "',Score='" + objSelCourseClass.Score + "' where StuNum='" + objSelCourseClass.StuNum + "'AND CourseName='" + objSelCourseClass.CourseName + "' ";

   //         //由于选课表的字段太少，搜索条件不能用，所以改用搜索视图的方式，好处：可以从另外一个表的字段修改基表的内容！

   //string SqlString = "Update V_SelCourse set 课程编号='"+objSelCourseClass.CourseNum+"' Where 学号='" + objSelCourseClass.StuNum + "' AND 所选课程='" + objSelCourseClass.CourseName + "'";
   //             DataBaseOperaClass objDataBase = new DataBaseOperaClass();

   //             if (objDataBase.GetExecute(SqlString))
   //                 return (true);
   //             else
   //                 return (false);
   //         } 
            #endregion

            #region 参数化
                public bool Update(SelCourseModel objSelCourseClass)
                {
                    string SqlString  = "Update V_SelCourse set 课程编号='" + objSelCourseClass.CourseNum + "'";
                           SqlString +=" Where 学号=@StuNum AND 所选课程=@CourseName";

                    SqlParameter[] parms ={
                                            new SqlParameter("@StuNum",objSelCourseClass.StuNum),
                                            new SqlParameter("@CourseName",objSelCourseClass.CourseName)
                                          };

                    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                    if (objDataBase.GetExecute(SqlString,parms))
                        return (true);
                    else
                        return (false);
                } 
            #endregion

               //成绩录入：
        //public bool InputScore(SelCourseModel objSelCourseModel)
        //{
        //    string SqlString = "Update SelCourse Set Score='" + objSelCourseModel.Score + "' where StuNum='" + objSelCourseModel.StuNum + "'AND CourseNum='" + objSelCourseModel.CourseNum + "' ";



        //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

        //    if (objDataBase.GetExecute(SqlString))
        //        return (true);
        //    else
        //        return (false);
            
        //}

             //删除：

               #region 参数化：
                    public bool InputScore(SelCourseModel objSelCourseModel)
                    {
                      string SqlString = "Update SelCourse Set Score=@Score where StuNum=@StuNum AND CourseNum=@CourseNum";
                      SqlParameter[] parms ={
                                                new SqlParameter("@Score",objSelCourseModel.Score),
                                                new SqlParameter("@StuNum",objSelCourseModel.StuNum),
                                                new SqlParameter("@CourseNum",objSelCourseModel.CourseNum)
                                             };
                     DataBaseOperaClass objDataBase = new DataBaseOperaClass();
                        
                        if (objDataBase.GetExecute(SqlString,parms))
                            return (true);
                        else
                            return (false);
                    }
                #endregion

            #region 使用参数数组作为参数,已注释

            //删除(退选)：
            ////public bool CancelSel(string StuNum, string CourseNum, string Score)

            //public bool CancelSel(string StuNum)
            //{
            //    string SqlString = "delete from SelCourse where StuNum='" + StuNum + "'";

            //    //objSqlCommand.CommandText = SqlString;
            //    //objSqlCommand.Connection = objConn;

            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    if (objDataBase.GetExecute(SqlString))
            //        return (true);
            //    else
            //        return (false);
            //} 
            #endregion

            #region 使用实体类在各层之间传递数据
            //public bool CancelSel(SelCourseModel objSelCourseClass)
            //{
            //    string SqlString = "delete from SelCourse where StuNum='" + objSelCourseClass.StuNum + "' AND CourseNum='"+objSelCourseClass.CourseNum+"' ";

            //    //objSqlCommand.CommandText = SqlString;
            //    //objSqlCommand.Connection = objConn;

            //    DataBaseOperaClass objDataBase = new DataBaseOperaClass();

            //    if (objDataBase.GetExecute(SqlString))
            //        return (true);
            //    else
            //        return (false);
            //}
            #endregion

                #region 参数化
                    public bool CancelSel(SelCourseModel objSelCourseClass)
                    {
              string SqlString = "delete from SelCourse where StuNum=@StuNum AND CourseNum=@CourseNum";
              SqlParameter[] parms ={
                                        new SqlParameter("@StuNum",objSelCourseClass.StuNum),
                                        new SqlParameter("@CourseNum",objSelCourseClass.CourseNum)
                                     };
                        DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                        if (objDataBase.GetExecute(SqlString,parms))
                            return (true);
                        else
                            return (false);
                    }
                #endregion



                    //刷新表格：
            #region 刷新选课、成绩录入表
            public DataTable ShowTableSelCourse()
            {
                
                string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分,Score AS 成绩 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum";

                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                DataTable objDataTalbe = objDataBase.GetDataSet(SqlString).Tables[0];
                return (objDataTalbe);
          
            } 
            #endregion


            #region 刷新系部信息表：
            public DataTable ShowDepartment()
            {
                string SqlString = "select DeptNum AS 系别号,DeptName AS 系别名,department.SchNum AS 校区号,School.SchName AS 学校名称 from dbo.Department join School on Department.SchNum=School.SchNum";

                DataBaseOperaClass objDataBase = new DataBaseOperaClass();

                DataTable objDataTalbe = objDataBase.GetDataSet(SqlString).Tables[0];
                return (objDataTalbe);
            }
            #endregion

            //查找
            #region 查找(返回布尔类型)，使用的是继承并扩展后获取数据行的方法：

            //public bool SearchSeledCourseStu(SelCourseModel objSelCourseModel)
            //{
            //    //string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum Where SelCourse.CourseNum='" + objSelCourseModel.CourseNum + "'";

            //    string SqlString = "Select * From V_SelCourse Where 学号='" + objSelCourseModel.StuNum + "' AND 所选课程='" + objSelCourseModel.CourseName + "'";



            //    DataBaseOperateClass2 objDataBase = new DataBaseOperateClass2();

            //    if (objDataBase.GetDataRow(SqlString) != null)
            //        return (true);
            //    else
            //        return (false);
            //}

            #region 参数化
            public bool CheckSeledCourseStu(SelCourseModel objSelCourseModel)
            {
                string SqlString = "Select * From V_SelCourse Where 学号=@StuNum AND 所选课程=@CourseName";

                SqlParameter[] parms ={
                                        new SqlParameter("@StuNum",objSelCourseModel.StuNum),
                                        new SqlParameter("@CourseName",objSelCourseModel.CourseName)
                                       };

                DataBaseOperateClass2 objDataBase = new DataBaseOperateClass2();

                if (objDataBase.GetDataRow(SqlString,parms) != null)
                    return (true);
                else
                    return (false);
            }
            #endregion


            #endregion

            #region 返回查找结果
            public DataTable CheckStuSelectCourseResult(SelCourseModel objSelCourseModel)
            {
                string SqlString = "select Student.StuNum AS 学号,Class.ClaName AS 班级,StuName AS 姓名,Course.CourseName AS 所选课程,SelCourse.CourseNum AS 课程编号,Credit AS 学分 from Student join Class on Student.ClaNum=Class.ClaNum join SelCourse on Student.StuNum=SelCourse.StuNum join Course on SelCourse.CourseNum=Course.CourseNum Where SelCourse.StuNum=@StuNum";

                SqlParameter[] parms ={
                                        new SqlParameter("@StuNum",objSelCourseModel.StuNum)
                                      };

                DataBaseOperateClass2 objDataBase = new DataBaseOperateClass2();

                DataTable objDataTable;

                return objDataTable = objDataBase.ShowTable(SqlString, parms);
            }
            #endregion
    }

}
