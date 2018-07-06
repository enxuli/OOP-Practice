using System;
using Zenject;
namespace HW2.DI
{
    public class DoorKeyDI : IDoorKeyDI
    {
        
        protected IKnobDI _knob;

        public DoorKeyDI(IKnobDI knob)
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
