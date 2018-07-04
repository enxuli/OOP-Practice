using System;
using Zenject;

namespace HW2.DI
{
    public class DoorDI : IDoorDI
    {
        protected IKnobDI _knob;

        public DoorDI()
        {
        }

        public void InstallKnob(IKnobDI knob)
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
