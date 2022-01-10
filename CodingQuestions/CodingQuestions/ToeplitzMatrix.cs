using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[, ] matrix)
        {
            int numDiag = matrix.GetLength(0);
            int numDiag2 = matrix.GetLength(1) - 1;

            for (int k = 0; k < numDiag; k++)
            {
                //int j = 0;
                int item = matrix[k, 0];
                for (int i = k, j=0; i < matrix.GetLength(0); i++, j++)
                {
                    Console.Write(matrix[i, j] + "    ");
                    if(matrix[i, j] != item)
                    {
                        return false;
                    }
                }
                Console.WriteLine("\n");
            }

            // symmetric matrix
            for (int k = 0; k < numDiag2; k++)
            {
                int item = matrix[0, k+1];
                for (int i = 0, j = k+1; i < matrix.GetLength(0) && (j < matrix.GetLength(1)); i++, j++)
                {
                    Console.Write(matrix[i, j] + "    ");
                    if(matrix[i, j] != item) { return false; }
                }
                Console.WriteLine("\n");
            }

            return true;
        }
    }
}
