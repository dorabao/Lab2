using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] a)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in a)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else 
                {
                    dict[num] = dict[num] + 1;    
                }
            }
            int count = 0;
            int target = 0;
            foreach (KeyValuePair<int, int> entry in dict)
            {
                if (entry.Value > count)
                {
                    count = entry.Value;
                    target = entry.Key;
                }
            }
            return target;
        }
    }
}
