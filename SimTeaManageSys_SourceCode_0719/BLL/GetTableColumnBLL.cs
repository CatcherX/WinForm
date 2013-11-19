using DAL;


namespace BLL
{
    
    /// <summary>
    /// 获取数据表的列，给表示层的下拉控件combox使用，业务逻辑层
    /// </summary>
    public class GetTableColumnBLL
    {
        GetTableColumnDAL objGetTableColumnDAL = new GetTableColumnDAL();

        public string[] GetSchNum()
        {
            string[] SchNum = objGetTableColumnDAL.GetSchNum();
            return SchNum;
        }

        public string[] GetSchName()
        {
            string[] SchName = objGetTableColumnDAL.GetSchName();
            return SchName;
        }

        public string[] GetDeptNum()
        {
            string[] DeptNum = objGetTableColumnDAL.GetDeptNum();
            return DeptNum;
        }

        public string[] GetDeptName()
        {
            string[] DeptName = objGetTableColumnDAL.GetDeptName();
            return DeptName;
        }


        public string[] GetProNum()
        {
            string[] ProNum = objGetTableColumnDAL.GetProNum();
            return ProNum;
        }
        public string[] GetProName()
        {
            string[] ProName = objGetTableColumnDAL.GetProName();
            return ProName;
        }
        
        public string[] GetClaNum()
        {
            string[] ClaNum = objGetTableColumnDAL.GetClaNum();
            return ClaNum;
        }
        
        public string[] GetClaName()
        {
            string[] ClaName = objGetTableColumnDAL.GetClaName();
            return ClaName;
        }

        public string[] GetCourseNum()
        {
            string[] CourseNum = objGetTableColumnDAL.GetCourseNum();
            return CourseNum;
        }

        public string[] GetCourseName()
        {
            string[] CourseName = objGetTableColumnDAL.GetCourseName();
            return CourseName;
        }

        public string[] GetScore()
        {
            string[] Score = objGetTableColumnDAL.GetScore();
            return Score;
        }


        /// <summary> 学生
        /// 逻辑层，获取学生表的下拉列
        /// </summary>
        /// <returns></returns>
        public string[] GetStuNum()
        { 
            string[] StuNum = objGetTableColumnDAL.GetStuNum();
            return   StuNum;
        }
       public string[] GetStuName()
        {
            string[] StuName = objGetTableColumnDAL.GetStuName();
            return   StuName;
        }




    }
}
