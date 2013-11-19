
namespace Model
{
    public class SelCourseModel
    {
      #region 属性声明
        #region 选课表学号
            private string _StuNum;
            public string StuNum
            {
                get { return _StuNum;}
                set { _StuNum=value; }
            }
        #endregion

        #region 课程编号
            private string _CourseNum;
            public string CourseNum
            {
                get { return _CourseNum; }
                set { _CourseNum = value; }
            }
        #endregion

        #region 课程名称
                private string _CourseName;
                public string CourseName
                {
                    get { return _CourseName; }
                    set { _CourseName = value;}
                }
            #endregion

        #region 科目成绩
            private string _Score;
            public string Score
             {
                    get { return _Score; }
                    set { _Score = value; }
             }
            #endregion

       
      #endregion

      #region 选课实体类构造函数
        /// <summary>
        /// 选课实体类构造函数
        /// </summary>
        /// <param name="StuNum">选课表学号</param>
        /// <param name="CourseNum">课程编号</param>
        /// <param name="Score">科目成绩</param>
        public SelCourseModel(string StuNum,string CourseNum,string Score)
        {
            _StuNum = StuNum;
            _CourseNum = CourseNum;
            _Score = Score;
            _CourseName = CourseName;
        }
        #endregion

        //#region 属性声明：
        //public string StuNum;
        //public string CourseNum;
        //public string Score; 
        //#endregion

        //没参数方法重载：
        public SelCourseModel()
        { 
        
        }
   
       

    }
}
