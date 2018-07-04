using System;
namespace HW2.NonDI
{
    public class Knob
    {
        protected Keyhold _keyhold;

        public Knob()
        {
        }

        public Keyhold InstallKeyhold()
        {
            _keyhold = new Keyhold();

            return _keyhold;
        }

        public Keyhold Keyhold
        {
            get
            {
                return _keyhold;
            }

        }
    }
}
