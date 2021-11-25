using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.WriteLine("please assign the array size:");
            length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("please assign an array value:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution s = new Solution();
            Console.WriteLine($"The value occurs most often is: {s.solution(array)}");
        }
    }
}
