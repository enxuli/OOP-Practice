using System;
namespace HW2.DI
{
    public interface IDoorKeyDI
    {
        IKnobDI Knob { get; }
    }
}
