using System;
using Zenject;

namespace HW2.DI
{
    public class KnobKeyDI : KnobDI
    {
        [Inject]
        protected IKeyholdDI _keyhold;

        public KnobKeyDI()
        {
        }

        public override IKeyholdDI Keyhold
        {
            get
            {
                return _keyhold;
            }

        }
        public override bool Open(IOpener opener)
        {
            return _keyhold.TurnandOpen(opener.Key);
        }


    }
}
