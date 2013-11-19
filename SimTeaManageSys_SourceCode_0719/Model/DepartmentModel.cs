

namespace Model
{
     public   class DepartmentModel
    {
         private string _SchNum, _DeptNum, _DeptName;

         public string SchNum
         { 
            get {return _SchNum;}
            set {_SchNum=value;}
         }

         public string DeptNum
         { 
            get{return _DeptNum;}
            set{_DeptNum=value;}
         }


         public string DeptName
         {
            get { return _DeptName; }
             set { _DeptName = value; }
         }
    }
}
