using System;
using Zenject;
namespace HW
{
    public class TableFactory : ITableFactory
    {
        [Inject]
        IFloorCountable _building;

        [Inject]
        IIphoneCountable _iphone;

        public TableFactory()
        {
            
        }
        public DPTable GetTable()
        {
            int n = _building.FloorNum();
            int m = _iphone.Num();
            DPTable _table = new DPTable(_building.FloorNum(), _iphone.Num());
            int i;
            for (i = 1; i < n + 1; i++)
            {
                _table[i, 1] = i;
            }
            for (i = 1; i < m + 1; i++)
            {
                _table[1, i] = 1;
            }
            return _table;
            
        }
    }
}
