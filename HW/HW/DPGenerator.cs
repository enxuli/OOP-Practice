using System;
namespace HW
{
    public class DPGenerator
    {

        public int[,] DPTableGenerator(int n, int m)
        {
            int[,] table = new int[n + 1, m + 1];
            int i, j, k;
            for (i = 1; i < n + 1; i++)
            {
                table[i, 1] = i;
            }
            for (i = 1; i < m + 1; i++)
            {
                table[1, i] = 1;
            }
            for (k = 2; k < m + 1; k++)
                for (i = 2; i < n + 1; i++)
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
