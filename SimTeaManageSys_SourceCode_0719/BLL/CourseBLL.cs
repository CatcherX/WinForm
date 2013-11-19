using System.Data;
using System.Windows.Forms;
using DAL;
using Model;

namespace BLL
{
    public class CourseBLL
    {
        //添加课程的业务逻辑
   

        public bool AddCourse(CourseModel objCourseModel)
        {
            CourseDAL objCourseDAL = new CourseDAL();

            if (objCourseDAL.SearchCoursebool(objCourseModel)==true)
            {
                MessageBox.Show("课程已存在，不能添加");
                return (false);
            }
            else
            { 
                return (objCourseDAL.AddCourse(objCourseModel));
            }

            #region //
            //public bool AddCourse(string CourseNum, string CourseName, string Credit, string ProOrPub, string NeedOrOpt)
            //{
            //    CourseDALClass objCourseDAL = new CourseDALClass();

            //    if (objCourseDAL.SearchCourse(CourseNum) == true)
            //    {
            //        MessageBox.Show("课程已存在，不能添加");
            //        return(false);
            //    }
            //    else
            //    {
            //        return (objCourseDAL.AddCourse(CourseNum,CourseName,Credit,ProOrPub,NeedOrOpt));
            //    }
            //} 
            #endregion

        }


        //修改课程的业务逻辑
        #region //
        //public bool ChangeCourse(string Course, string CourseNum, string CourseName, string Credit, string ProOrPub, string NeedOrOpt)
        //{
        //    CourseDALClass objCourseDAL = new CourseDALClass();
        //    if (objCourseDAL.SearchCourse(CourseNum) == true)
        //    {
        //        MessageBox.Show("课程编号已存在，不能添加");
        //        return (false);
        //    }
        //    else
        //    {
        //        return (objCourseDAL.ChangeCourse(Course, CourseNum, CourseName, Credit, ProOrPub, NeedOrOpt));
        //    }
        //} 
        #endregion

        public bool ChangeCourse(CourseModel objCourseModel)
        {
            CourseDAL objCourseDAL = new CourseDAL();

                return (objCourseDAL.ChangeCourse(objCourseModel));
            
        }



        //删除课程的业务逻辑
        #region //
            //public bool DeleteCourse(string Course)
            //{
            //    CourseDALClass objCourseDAL = new CourseDALClass();
            //    return (objCourseDAL.DeletCourse(Course));
            //} 
        #endregion
        public bool DelCourse(CourseModel objCourseModel)
        {
            CourseDAL objCourseDAL = new CourseDAL();
            return (objCourseDAL.DeletCourse(objCourseModel));
        }



        //获取所有课程的业务逻辑
        public DataTable ShowCourse()
        {
            CourseDAL objCourseDAL = new CourseDAL();
            return (objCourseDAL.ShowCourse());
        }
    }
}
