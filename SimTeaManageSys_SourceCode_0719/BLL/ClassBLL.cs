using System.Data;
using System.Windows.Forms;
using DAL;
using Model;

namespace BLL
{
    public class ClassBLL
    {
        
        //添加班级信息的业务逻辑
        public bool AddClass(ClassModel objClassModel)
        {
            ClassDAL objClass1DAL = new ClassDAL();
           
            if (objClass1DAL.SearchClass(objClassModel)==true)
            {
               MessageBox.Show("班级已有，谢绝添加");
               return (false);
            }
            else
            {
               return (objClass1DAL.AddClass(objClassModel));
            }
        }
                
       
        //修改班级信息的业务逻辑

        public bool ChangeClass(ClassModel objClassModel)
       {
           ClassDAL objClass1DAL = new ClassDAL();
           return (objClass1DAL.ChangeClass(objClassModel));
        }
    
        //任务14
        //删除班级信息的业务逻辑
        public bool DeleteClass(ClassModel objClassModel)
        {
            ClassDAL objClass1DAL = new ClassDAL();
            
            return (objClass1DAL.DeleteClass(objClassModel));

        }


        //获取班级信息的业务逻辑
        public DataTable ShowClass()
        {
            ClassDAL objClass1DAL = new ClassDAL();
            return (objClass1DAL.ShowClass());
        }


        public bool SearchClass(ClassModel objClassModel)
        {
            ClassDAL objClass1DAL = new ClassDAL();   
            return (objClass1DAL.SearchClass(objClassModel));
        }


      
    }
}
