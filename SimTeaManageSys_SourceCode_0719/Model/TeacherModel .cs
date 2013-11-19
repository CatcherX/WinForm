
namespace Model
{
    public class TeacherModel 
    {   
       
               #region 教师编号
        private string _TeaNum;
        public string TeaNum
        {
            get
            {
                return _TeaNum;
            }
            set
            {
                _TeaNum = value;
            }
        }
        #endregion

               #region 教师姓名
        private string _TeaName;
        public string TeaName
        {
            get
            {
                return _TeaName;
            }
            set
            {
                _TeaName = value;
            }
        }
        #endregion

               #region 教师性别
        private string _TeaSex;
        public string TeaSex
        {
            get
            {
                return _TeaSex;
            }
            set
            {
                _TeaSex = value;
            }
        }
        #endregion

               #region 教师电话
        private string _TeaPhone;
        public string TeaPhone
        {
            get
            {
                return _TeaPhone;
            }
            set
            {
                _TeaPhone = value;
            }
        }
        #endregion

               #region 教师地址
        private string _TeaAddress;
        public string TeaAdress
        {
            get
            {
                return _TeaAddress;
            }
            set
            {
                _TeaAddress = value;
            }
        }
        #endregion

               #region 职称
                    private string _TeaTitle;
                    public string TeaTitle
                    {
                        get
                        {
                            return _TeaTitle;
                        }
                        set
                        {
                            _TeaTitle = value;
                        }
                    }
            #endregion


    }
}
