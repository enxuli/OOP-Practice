using System;
using Zenject;

namespace HW2.DI
{
    public class HousePwdDI : IHousePwdDI
    {
        protected IDoorPwdDI _door;

        public HousePwdDI(IDoorPwdDI door)
        {
            _door = door;
        }

        public IDoorPwdDI Door
        {
            get
            {
                return _door;
            }
        }
    }
}
