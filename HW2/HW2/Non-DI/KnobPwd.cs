using System;
namespace HW2.NonDI
{
    public class KnobPwd : Knob
    {
        protected string _pwd;

        public KnobPwd()
        {
        }

        public override bool Open( Opener opener)
        {
            if (opener.Pwd == _pwd) return true;
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
