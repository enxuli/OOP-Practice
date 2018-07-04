using System;
namespace HW2.DI
{
    public interface IKnobDI
    {
        IKeyholdDI Keyhold { get; }
        Boolean PwdOpen(string pwd);
    }
}
