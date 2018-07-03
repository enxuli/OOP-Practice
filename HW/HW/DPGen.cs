using System;
using Zenject;
namespace HW
{
    public class DPGen : IAlgoSettable
    {

        public IDPTable DPTableGenerator(IDPTable table)
        {
            int i, j, k;
            for (k = 2; k < table.LengthOf(1); k++)
                for (i = 2; i < table.LengthOf(0); i++)
                {
                    table[i, k] = i;
                    for (j = 1; j < i; j++)
                    {
                        int min = table[j - 1, k - 1] > table[i - j, k] ? table[j - 1, k - 1] + 1 : table[i - j, k] + 1;
                        table[i, k] = min < table[i, k] ? min : table[i, k];
                    }
                }
            return table;
        }

    }
}
