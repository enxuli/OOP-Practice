using System;
using Zenject;
namespace HW
{
    public class DPTableFactory : IDPTableFactory
    {
        [Inject]
        IFloorCountable _building;

        [Inject]
        IIphoneCountable _iphone;

        public DPTable CreateMargin(DPTable table)
        {
            int n = _building.FloorNum();
            int m = _iphone.Num();
            table._table = new int[n + 1, m + 1];
            int i;
            for (i = 1; i < n + 1; i++)
            {
                table._table[i, 1] = i;
            }
            for (i = 1; i < m + 1; i++)
            {
                table._table[1, i] = 1;
            }
            return table;
        }

    }
}
