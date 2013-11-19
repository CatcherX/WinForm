
namespace Model
{
    public class StudentModel
    {
        #region 学生学号
        private string _StuNum;
        public string StuNum
        {
            get
            {
                return _StuNum;
            }
            set
            {
                _StuNum = value;
            }
        }
        #endregion

        #region 学生姓名
        private string _StuName;
        public string StuName
        {
            get
            {
                return _StuName;
            }
            set
            {
                _StuName = value;
            }
        }
        #endregion

        #region 学生性别
        private string _StuSex;
        public string StuSex
        {
            get
            {
                return _StuSex;
            }
            set
            {
                _StuSex = value;
            }
        }
        #endregion

        #region 政治背景
        private string _Policity;
        public string Policity
        {
            get
            {
                return _Policity;
            }
            set
            {
                _Policity = value;
            }
        }
        #endregion

        #region 出生日期
        private string _Birthday;
        public string Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                _Birthday = value;
            }
        }
        #endregion

        #region 爱好
        private string _Favor;
        public string Favor
        {
            get
            {
                return _Favor;
            }
            set
            {
                _Favor = value;
            }
        }
        #endregion

        #region 学生综合分
        private string _StuScore;
        public string StuScore
        {
            get
            {
                return _StuScore;
            }
            set
            {
                _StuScore = value;
            }
        }
        #endregion

        #region 学生评价
        private string _Meno;
        public string Meno
        {
            get
            {
                return _Meno;
            }
            set
            {
                _Meno = value;
            }
        }
        #endregion

        #region 班级号
        private string _ClaNum;
        public string ClaNum
        {
            get
            {
                return _ClaNum;
            }
            set
            {
                _ClaNum = value;
            }
        }
        #endregion

        #region 班级名称
        private string _ClaName;
        public string ClaName
        {
            get { return _ClaName; }
            set { _ClaName = value;}
        }

        #endregion

        #region 联系号码
        private string _Phone;
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        #endregion

        #region 联系地址
        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        #endregion

    }
}
