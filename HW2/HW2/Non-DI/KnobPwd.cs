using System;
namespace HW2.NonDI
{
    public class KnobPwd
    {
        protected string _pwd;

        public KnobPwd()
        {
        }

        public Boolean PwdOpen( string pwd)
        {
            if (pwd == _pwd) return true;
            else return false;
        }

        public string Pwd
        {
            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
            }
        }
    }
}
