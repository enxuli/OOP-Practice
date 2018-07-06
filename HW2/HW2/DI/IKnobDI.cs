using System;
namespace HW2.DI
{
    public interface IKnobDI
    {
        bool Open(IOpener opener);
        IKeyholdDI Keyhold { get; }
    }
}
