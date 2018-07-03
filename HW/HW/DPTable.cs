using System;
using Zenject;
namespace HW
{
    public class DPTable : IDPTable
    {
        protected int[,] _table;
        protected int _row;
        protected int _column;


        //public DPTable(int row, int column)
        //{
        //    this._row = row;
        //    this._column = column;
        //    this._table = new int[row, column];
        //}

        public int this[int row, int column]
        {
            get
            {
                return _table[row, column];
            }
            set
            {
                this._table[row, column] = value;
            }
        }

        public int LengthOf(int dim)
        {
            return this._table.GetLength(dim);
        }

        public class DPTableFactory : IDPTableFactory
        {
            [Inject]
            IFloorCountable _building;

            [Inject]
            IIphoneCountable _iphone;

            [Inject]
            DPTable _table;

            public DPTable CreateMargin()
            {
                int n = _building.FloorNum();
                int m = _iphone.Num();
                _table._table = new int[n + 1, m + 1];
                int i;
                for (i = 1; i < n + 1; i++)
                {
                    _table._table[i, 1] = i;
                }
                for (i = 1; i < m + 1; i++)
                {
                    _table._table[1, i] = 1;
                }
                return _table;
            }
        }

    }
}
