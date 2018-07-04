using System;
namespace HW2.NonDI
{
    public class Door
    {
        protected Knob _knob;
        protected KnobPwd _knobPwd;

        public Door()
        {
        }

        public void IntsallKnob ( Knob knob)
        {
            _knob = knob;

        }
        public void IntsallKnob( KnobPwd knobPwd)
        {
            _knobPwd = knobPwd;

        }

        public Knob Knob
        {
            get
            {
                return _knob;
            }

        }
        public KnobPwd KnobPwd
        {
            get
            {
                return _knobPwd;
            }

        }

    }
}
