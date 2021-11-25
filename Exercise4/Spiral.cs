using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Spiral
    {
        public void SpiralArr(int[,] matrix)
        {
            int range = matrix.GetLength(1) - 1;
            SpiralHelper(matrix, 0, 0, range);
        }

        public void SpiralHelper(int[,] matrix, int x, int y, int range)
        {
            //base case
            if (range < 0)
            {
                return;
            }
            else if(range == 0)
            {
                Console.Write(matrix[x,y]);
            }
            //top
            for (int i = 0; i < range; i++)
            {
                Console.Write(matrix[x, y++]);
            }
            //right
            for (int i = 0; i < range; i++)
            {
                Console.Write(matrix[x++, y]);
            }
            //bottom
            for (int i = 0; i < range; i++)
            {
                Console.Write(matrix[x, y--]);
            }
            //left
            for (int i = 0; i < range; i++)
            {
                Console.Write(matrix[x--, y]);
            }
            SpiralHelper(matrix, x + 1, y + 1, range - 2);
        }
    }
}
