using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class ScoreSearchBLL
    {
      

        ScoreSearchDAL objScoreSearchDAL = new ScoreSearchDAL();
    

        //查找：
        #region 查找及返回查找结果：
        //查找方法：
        public bool SearchSeledCourseStu(SelCourseModel objSelCourseModel)
        {
            SelCourseDAL objSelCourseDALClass = new SelCourseDAL();
            return (objSelCourseDALClass.CheckSeledCourseStu(objSelCourseModel));

        }

        
        public DataTable ScoreSearch(ClassModel objClassModel )
        {
            return (objScoreSearchDAL.ScoreSearch(objClassModel));
        }     
        #endregion

        public DataTable ScoreStuSearch(LoginUserModel objLoginUserModel)
        {
            return (objScoreSearchDAL.ScoreStuSearch(objLoginUserModel));
        }





    
    }
}
