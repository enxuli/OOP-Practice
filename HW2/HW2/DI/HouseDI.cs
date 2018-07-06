using System;
namespace HW2.DI
{
    public class HouseDI : IHouseDI
    {
        public HouseDI()
        {
        }

        public virtual IDoorDI Door { get; }

    }
}
