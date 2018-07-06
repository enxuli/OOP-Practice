using System;
using Zenject;

namespace HW2.DI
{
    public class DoorPwdDI : IDoorPwdDI
    {
        protected IKnobDI _knob;

        public DoorPwdDI(IKnobDI knob)
        {
            _knob = knob;
        }

        public IKnobDI Knob
        {
            get
            {
                return _knob;
            }

        }

    }
}
