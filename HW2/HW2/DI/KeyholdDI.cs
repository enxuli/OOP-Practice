using System;
using Zenject;

namespace HW2.DI
{
    public class KeyholdDI : IKeyholdDI
    {
        [Inject]
        protected int _idx;

        public KeyholdDI()
        {
        }

        public Boolean TurnandOpen(IKeyDI key)
        {
            if (key.Index == _idx) return true;
            else return false;

        }

        public int Index
        {
            get
            {
                return _idx;
            }
        }

    }
}
