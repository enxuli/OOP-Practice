using System;
namespace HW2.DI
{
    public class HouseFactory :IHouseFactory
    {
        public HouseDI BuildHouse()
        {
            return new HouseDI();
        }
    }
}
