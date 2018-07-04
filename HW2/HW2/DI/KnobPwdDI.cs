using System;
using Zenject;

namespace HW2.DI
{
    public class KnobPwdDI : IKnobDI
    {
        [Inject]
        protected string _pwd;

        public KnobPwdDI()
        {
            
        }

        public IKeyholdDI Keyhold => throw new NotImplementedException();

        public Boolean PwdOpen(string pwd)
        {
            if (pwd == _pwd) return true;
            else return false;
                
        }
    }
}
