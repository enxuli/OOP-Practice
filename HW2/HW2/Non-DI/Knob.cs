using System;
namespace HW2.NonDI
{
    public class Knob
    {
        public Knob()
        {
        }

        public virtual bool Open(Opener opener)
        {
            return false;
        }

        public virtual Keyhold Keyhold
        { get; }
    }
}
