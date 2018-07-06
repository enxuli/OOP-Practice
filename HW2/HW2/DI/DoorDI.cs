using System;
namespace HW2.DI
{
    public class DoorDI:IDoorDI
    {
        public DoorDI()
        {
        }
        public virtual IKnobDI Knob { get; }
    }
}
