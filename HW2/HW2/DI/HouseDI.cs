using System;
using Zenject;

namespace HW2.DI
{
    public class HouseDI:IHouseDI
    {
        [Inject]
        protected IDoorDI _door;

        public HouseDI()
        {
        }

        public IDoorDI Door
        {
            get
            {
                return _door;
            }
        }
    }
}
