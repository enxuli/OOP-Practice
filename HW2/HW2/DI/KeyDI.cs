using System;
using Zenject;
namespace HW2.DI
{
    public class KeyDI : IKeyDI
    {
        [Inject]
        protected int _idx;

        public int Index
        {
            get
            {
                return _idx;
            }
                
        }
    }
}
