using System.Data;
using DAL;
using Model;


namespace BLL
{
    public class TeachingBLL
    {
        //添加班级信息的业务逻辑
        public bool AddClass(TeachingModel objTeachingModel)
        {
            
            TeachingDAL objTeachingDAL = new TeachingDAL();

            return (objTeachingDAL.AddTeachingTask(objTeachingModel));
           
        }

        //获取班级信息的业务逻辑
        public DataTable ShowTeachingInfo()
        {
            TeachingDAL objTeachingDAL = new TeachingDAL();
            return (objTeachingDAL.ShowTeaching());
        }




    }
}
