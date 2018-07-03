using System;
using Zenject;
namespace HW
{
    public class Building : IFloorCountable
    {
        [Inject]
        protected int _floorNum;

        public int FloorNum()
        {
                return _floorNum;
        }
    }
}
