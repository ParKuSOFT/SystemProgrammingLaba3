using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgrammingLaba3
{
    internal class SortedClass
    {
        public void InsertionSortColumn(int[,] array, int beg, int end)
        {
            int rows = array.GetLength(0);
            for (int col = beg; col < end; col += 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    int key = array[i, col];
                    int k = i - 1;
                    while (k >= 0 && array[k, col] > key)
                    {
                        array[k + 1, col] = array[k, col];
                        k--;
                    }
                    array[k + 1, col] = key;
                }
            }
        }
    }
}
