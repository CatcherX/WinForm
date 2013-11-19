using System.Data;
using DataBaseOperate;


namespace DAL
{
    /// <summary>
    /// 类，获取数据库指定表的列，用于给窗体下拉控件Combox使用：
    /// </summary>
    public class GetTableColumnDAL
    {
        DataBaseOperaClass objDataBaseOperaClass = new DataBaseOperaClass();
        string SqlString;
        DataTable objDataTable;

                #region SchNum
                    public string[] GetSchNum()
                    {
                         SqlString = "Select SchNum as 学校代码,SchName as 学校名称 From School";

                        objDataTable = objDataBaseOperaClass.ShowTable(SqlString);//这里不能再实例化！
                        string[] SchNum = new string[objDataTable.Rows.Count];   //后半句怎样理解？即new ...


                        for (int i = 0; i < objDataTable.Rows.Count; i++)
                            SchNum[i] = objDataTable.Rows[i][0].ToString();
                        
                        return SchNum;
                    }
                #endregion

                #region SchName
                    public string[] GetSchName()
                    {
                         SqlString = "Select SchNum as 学校代码,SchName as 学校名称 From School";

                        objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                        string[] SchName = new string[objDataTable.Rows.Count];

                        for (int i = 0; i < objDataTable.Rows.Count; i++)
                            SchName[i] = objDataTable.Rows[i][1].ToString();

                        return SchName;
                    }
                #endregion

                    #region DeptNum

                        public string[] GetDeptNum()
                        {
                             SqlString = "Select DeptNum as  系部编号,DeptName as 每部名称 From Department";

                             objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                            string[] DeptNum = new string[objDataTable.Rows.Count];

                            for (int i = 0; i < objDataTable.Rows.Count; i++)
                                DeptNum[i] = objDataTable.Rows[i][0].ToString();
                            return DeptNum;
                        }

                    #endregion


                    #region DeptName
                        public string[] GetDeptName()
                        {
                             SqlString = "Select DeptNum as  系部编号,DeptName as 每部名称 From Department";
                             objDataTable = objDataBaseOperaClass.ShowTable(SqlString);

                            string[] DeptName = new string[objDataTable.Rows.Count];
                            for (int i = 0; i < objDataTable.Rows.Count; i++)
                                DeptName[i] = objDataTable.Rows[i][1].ToString();
                            return DeptName;
                        }
                    #endregion
                 
                    #region ProNum
                        public string[] GetProNum()
                        {
                             SqlString = "Select ProNum as 专业编号, ProName as 专业名称 From Profession";
                             objDataTable=objDataBaseOperaClass.ShowTable(SqlString);
                            string[] ProNum = new string[objDataTable.Rows.Count];
                            for (int i = 0; i < objDataTable.Rows.Count; i++)
                                ProNum[i] = objDataTable.Rows[i][0].ToString();
                            return ProNum;
                        }
                    #endregion

                    #region ProName
                        public string[] GetProName()
                        {
                             SqlString = "Select ProNum as 专业编号, ProName as 专业名称 From Profession";
                             objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                            string[] ProName=new string[objDataTable.Rows.Count];
                            for (int i = 0; i < objDataTable.Rows.Count; i++)
                                ProName[i] = objDataTable.Rows[i][1].ToString();
                            return ProName;
                        }
                    #endregion

                    #region ClaNum
                        public string[] GetClaNum()
                        {
                             SqlString = "Select ClaNum as 班级编号 , ClaName as 班级名称 From Class";
                             objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                            string[] ClaNum = new string[objDataTable.Rows.Count];
                            for (int i = 0; i < objDataTable.Rows.Count; i++)
                                ClaNum[i] = objDataTable.Rows[i][0].ToString();
                            return ClaNum;
                        }

                    #endregion

                    #region ClaName
                    public string[] GetClaName()
                {
                     SqlString = "Select ClaNum as 班级编号 , ClaName as 班级名称 From Class";
                     objDataTable = objDataBaseOperaClass.ShowTable(SqlString);

                    string[] ClaName = new string[objDataTable.Rows.Count];
                    for (int i = 0; i < objDataTable.Rows.Count; i++)
                        ClaName[i] = objDataTable.Rows[i][1].ToString();
                    return (ClaName);
                }
                #endregion

                #region CourseNum
                public string[] GetCourseNum()
                {

                     SqlString = "select CourseNum,CourseName as 课程编号 from Course";

                     objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                     string[] CourseIds = new string[objDataTable.Rows.Count];
                     for (int i = 0; i < objDataTable.Rows.Count; i++)
                         CourseIds[i] = objDataTable.Rows[i][0].ToString();   //0代表列数  

                    return (CourseIds);
                }
                #endregion

                #region CourseName
                public string[] GetCourseName()
                {
                     SqlString = "select CourseNum,CourseName as 课程名称 From Course";


                    objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                    string[] CourseName = new string[objDataTable.Rows.Count];
                    for (int i = 0; i < objDataTable.Rows.Count; i++)
                        CourseName[i] = objDataTable.Rows[i][1].ToString();   //1代表第2列

                    return (CourseName);
                }
                #endregion

                #region StuNum

                /// <summary>
                /// 获取学生表的学号列，给Combox控件使用。
                /// </summary>
                /// <returns>返回一个字符串数组</returns>
                public string[] GetStuNum()
                {
                     SqlString = "Select StuNum,StuName as 学号 From Student";



                     objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                     string[] StuNum = new string[objDataTable.Rows.Count];
                     for (int i = 0; i < objDataTable.Rows.Count; i++)         //从获得的列中的第一行开始，逐行把值给数组
                         StuNum[i] = objDataTable.Rows[i][0].ToString();
                    return (StuNum);

                }
                #endregion
        
                #region StuName
                /// <summary>
                /// 获取学生表的姓名列
                /// </summary>
                /// <returns>返回学生列字段</returns>
                public string[] GetStuName()
                {
                     SqlString = "Select StuNum,StuName as 姓名 From Student";
                    
                     objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                    string[] StuName = new string[objDataTable.Rows.Count];
                    for (int i = 0; i < objDataTable.Rows.Count; i++)
                        StuName[i] = objDataTable.Rows[i][1].ToString();
                    return (StuName);
                }
        
            #endregion

                #region GetScore
                 public string[] GetScore()
                {
                     SqlString = "Select Score AS 成绩 From SelCourse";

                     objDataTable = objDataBaseOperaClass.ShowTable(SqlString);
                     string[] CourseIds = new string[objDataTable.Rows.Count];
                     for (int i = 0; i < objDataTable.Rows.Count; i++)
                         CourseIds[i] = objDataTable.Rows[i][0].ToString();   //0代表列数  

                    return (CourseIds);
                }
              #endregion
    }
}
