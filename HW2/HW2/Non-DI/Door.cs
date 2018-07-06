using System;
namespace HW2.NonDI
{
    public class Door
    {
        protected Knob _knob;

        public Door()
        {
        }

        public void IntsallKnob ( Knob knob)
        {
            _knob = knob;

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
