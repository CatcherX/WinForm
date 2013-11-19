using System.Data;
using Model;


namespace IDAL
{
    public interface ISelCourseDAL
    {

        //添加
        bool SelOk(SelCourseModel objSelCourseModel);
        
        //修改
        bool Update(SelCourseModel objSelCourseClass);
        
        //删除
        bool CancelSel(SelCourseModel objSelCourseClass);
        
        //获取所有
        DataTable ShowTableSelCourse();

        //查找：
        DataTable CheckStuSelectCourseResult(SelCourseModel objSelCourseModel);




    }
}
