
namespace Model
{
    public class CourseModel
    {

        #region 课程编号
        private string _CourseNum;
        public string CourseNum
        {
            get
            {
                return _CourseNum;
            }
            set
            {
                _CourseNum = value;
            }
        }
        #endregion

        #region 课程名称
        private string _CourseName;
        public string CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                _CourseName = value;
            }
        }
        #endregion

        #region 学分
        private string _Credit;
        public string Credit
        {
            get
            {
                return _Credit;
            }
            set
            {
                _Credit = value;
            }
        }
        #endregion

        #region 公共专业
        private string _ProOrPub;
        public string ProOrPub
        {
            get
            {
                return _ProOrPub;
            }
            set
            {
                _ProOrPub = value;
            }
        }
        #endregion

        #region 必修选修
        private string _NeedOrOpt;
        public string NeedOrOpt
        {
            get
            {
                return _NeedOrOpt;
            }
            set
            {
                _NeedOrOpt = value;
            }
        }
        #endregion


        #region 系名称：
        private string _DeptName;
        public string DeptName
        {
            get
            {
                return _DeptName;
            }
            set
            {
                _DeptName = value;
            }
        }
        #endregion


        #region 系编号 ：
        private string _DeptNum;
        public string DeptNum
        {
            get
            {
                return _DeptNum;
            }
            set
            {
                _DeptNum = value;
            }
        }
        #endregion

    }
}
     
    

