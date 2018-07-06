using System;
using Zenject;
namespace HW2.DI
{
    public class DoorKeyDI : DoorDI,IDoorKeyDI
    {
        
        protected IKnobDI _knob;

        public DoorKeyDI(IKnobDI knob)
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
