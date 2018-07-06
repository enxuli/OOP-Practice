using System;
using Zenject;

namespace HW2.DI
{
    public class KnobPwdDI : KnobDI
    {
        [Inject]
        protected string _pwd;

        public KnobPwdDI()
        {
            
        }

        public override bool Open(IOpener opener)
        {
            if (opener.Pwd == _pwd) return true;
            else return false;
                
        }
    }
}
