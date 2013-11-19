
namespace Model
{
    public class LoginUserModel
    {
        private string _UserID, _UserRole, _UserPw, _LoginCount;

        public string UserId
        {
            get {return _UserID;}
            set {_UserID=value;}
        }


        public string UserRole
        {
            get { return _UserRole; }
            set { _UserRole = value;}
        }

        public string UserPw
        {
            get { return _UserPw; }
            set { _UserPw = value;}
        }


        public string LoginCount
        {
            get { return _LoginCount; }
            set { _LoginCount = value;}
        
        }



    }
}
