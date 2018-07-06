using System;
using Zenject;
namespace HW2.DI
{
    public class HouseKeyDI : HouseDI, IHouseKeyDI
    {
        protected IDoorDI _door;

        public HouseKeyDI(IDoorDI door)
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
