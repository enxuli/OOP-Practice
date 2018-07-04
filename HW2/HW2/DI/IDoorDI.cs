using System;
namespace HW2.DI
{
    public interface IDoorDI
    {
        IKnobDI Knob { get; }
    }
}
