using System;
using Zenject;

namespace HW2.DI
{
    public class KnobDI : IKnobDI
    {
        [Inject]
        protected IKeyholdDI _keyhold;

        public KnobDI()
        {
        }

        public IKeyholdDI Keyhold
        {
            get
            {
                return _keyhold;
            }

        }
    }
}
