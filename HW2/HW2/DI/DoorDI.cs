using System;
using Zenject;

namespace HW2.DI
{
    public class DoorDI : IDoorDI
    {
        [Inject]
        protected IKnobDI _knob;

        public DoorDI()
        {
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
