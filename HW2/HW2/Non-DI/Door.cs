using System;
namespace HW2.NonDI
{
    public class Door
    {
        protected Knob _knob;

        public Door()
        {
        }

        public Knob IntsallKnob()
        {
            _knob = new Knob();

            return _knob;
        }
        public Knob Knob
        {
            get
            {
                return _knob;
            }

        }
    }
}
