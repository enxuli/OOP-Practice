using System;
namespace HW2.DI
{
    public class KnobDI : IKnobDI
    {
        public KnobDI()
        {
        }
        public virtual bool Open(IOpener opener)
        {
            return false;
        }

        public virtual IKeyholdDI Keyhold
        { get; }

    }
}
