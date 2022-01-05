using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MatrixBuilder
    {
        public List<List<int>> BuildMatrix(int n)
        {
            var result = new List<List<int>>();
            var temporaryArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                temporaryArray[i] = new int[n];
                result.Add(new List<int>());
            }

            int counter = 1;
            int startColumn = 0;
            int endColumn = n - 1;
            int startRow = 0;
            int endRow = n - 1;

            while (startColumn <= endColumn && startRow <= endRow)
            {
                for (int i = startColumn; i <= endColumn; i++)
                {
                    temporaryArray[startRow][i] = counter;
                    counter++;
                }
                startRow++;

                for (int i = startRow; i <= endRow; i++)
                {
                    temporaryArray[i][endColumn] = counter;
                    counter++;
                }
                endColumn--;

                for (int i = endColumn; i >= startColumn; i--)
                {
                    temporaryArray[endRow][i] = counter;
                    counter++;
                }
                endRow--;

                for (int i = endRow; i >= startRow; i--)
                {
                    temporaryArray[i][startColumn] = counter;
                    counter++;
                }
                startColumn++;
            }

            for (int i = 0; i < temporaryArray.Length; i++)
            {
                result[i].AddRange(temporaryArray[i]);
            }

            return result;
        }
    }
}