
namespace Model
{
    public class StuWebEvalModel
    {
        
        private string _StuNum, _TeaNum, _TeaPoint, _StuEvalTxt, _EvalCheck, _term;

        public string StuNum
        {
            get { return _StuNum; }
            set { _StuNum = value;}
        }

        public string TeaNum
        {
            get { return _TeaNum; }
            set { _TeaNum = value; }
        }

        public string TeaPoint
        {
            get { return _TeaPoint; }
            set { _TeaPoint = value;}
        }

        public string StuEvalTxt
        {
            get { return _StuEvalTxt; }
            set { _StuEvalTxt = value; }
        }

        public string EvalCheck
        {
            get { return _EvalCheck; }
            set { _EvalCheck = value; }
        }

        public string term
        {
            get { return _term;  }
            set { _term = value; }
        }

    }
}
