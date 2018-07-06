using System;
using Zenject;

namespace HW2.DI
{
    public class DoorPwdDI : DoorDI,IDoorPwdDI
    {
        protected IKnobDI _knob;

        public DoorPwdDI(IKnobDI knob)
        {
            _knob = knob;
        }

        public override IKnobDI Knob
        {
            get
            {
                return _knob;
            }

        }

    }
}
