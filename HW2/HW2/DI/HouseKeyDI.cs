using System;
using Zenject;
namespace HW2.DI
{
    public class HouseKeyDI : IHouseKeyDI
    {
        protected IDoorKeyDI _door;

        public HouseKeyDI(IDoorKeyDI door)
        {
            _door = door;
        }

        public IDoorKeyDI Door
        {
            get
            {
                return _door;
            }
        }
    }
}
