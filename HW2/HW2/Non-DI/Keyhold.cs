using System;
namespace HW2.NonDI
{
    public class Keyhold
    {
        protected int _idx;

        public Keyhold()
        {
        }

        public Boolean TurnandOpen(Key key)
        {
            if (key.Index == _idx) return true;
            else return false;
            
        }
        public int Index
        {
            get
            {
                return _idx;
            }
            set
            {
                _idx = value;
            }
        }
    }
}
