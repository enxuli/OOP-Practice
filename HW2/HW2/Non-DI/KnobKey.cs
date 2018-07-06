using System;
namespace HW2.NonDI
{
    public class KnobKey : Knob
    {
        protected Keyhold _keyhold;

        public KnobKey()
        {
        }

        public Keyhold InstallKeyhold()
        {
            _keyhold = new Keyhold();

            return _keyhold;
        }

        public override Keyhold Keyhold
        {
            get
            {
                return _keyhold;
            }
        }

        public override bool Open(Opener opener)
        {
            return _keyhold.TurnandOpen(opener.Key);
        }
    }
}
