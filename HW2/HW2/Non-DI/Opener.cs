using System;
namespace HW2.NonDI
{
    public class Opener
    {
        protected Key _key;

        protected string _pwd;

        public Opener()
        {
        }
        public Key Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
        public string Pwd
        {
            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
            }
        }
    }
}
