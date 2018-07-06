using System;
using Zenject;

namespace HW2.DI
{
    public class HousePwdDI : HouseDI, IHousePwdDI
    {
        protected IDoorDI _door;

        public HousePwdDI(IDoorDI door)
        {
            _door = door;
        }

        public override IDoorDI Door
        {
            get
            {
                return _door;
            }
        }
    }
}
