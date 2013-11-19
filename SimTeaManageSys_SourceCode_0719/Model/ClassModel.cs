

namespace Model
{
    public class ClassModel
    {

        private string _ClaNum, claname, deptnum,_DeptName,pronum,_ProName,_StuNum;

       
        public string StuNum
        {
            get { return _StuNum; }
            set { _StuNum = value;}
        }

        public string ClaNum
        {
            get
            { return _ClaNum; }
            set
            { _ClaNum = value; }
        }

        public string ClaName
        {
            get
            { return claname; }
            set
            { claname= value; }
 
        }
        public string DeptNum
        {
            get
            { return deptnum; }
            set
            { deptnum = value; }

        }
        public string ProNum
        {
            get
            { return pronum;}
            set
            { pronum = value; }
        }

        public string ProName
        {
            get { return _ProName; }
            set { _ProName = value;}
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value;}

        }


       
    }
}
