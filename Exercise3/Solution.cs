using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Solution
    {
        public int solution(int a, int b)
        {
            int counter = 0;
            if (a < 0 && b < 0)
            {
                return counter;
            }
            int left = a < 0 ? 0 : a;
            int right = b;
            for (int i = left; i <= right; i++)
            {
                for (int j = 0; j <= right / 2; j++)
                { 
                    if (i == j * j) 
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
