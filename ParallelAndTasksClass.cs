using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgrammingLaba3
{
    internal class ParallelAndTasksClass
    {
        public void ParallelFunc(int N, int dN, int column, int rows, int[,] array)
        {
            Random rnd = new Random();
            Parallel.For(1, N + 1, new ParallelOptions { MaxDegreeOfParallelism = N }, id =>
            {
                int beg; int end;
                beg = (id - 1) * dN;
                if (id == N)
                {
                    end = column;
                }
                else
                {
                    end = id * dN;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = rnd.Next(20, 41);
                    }
                }
            });
        }
    }
}
