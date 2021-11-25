using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the left boundary");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give the right boundary");
            int b = Convert.ToInt32(Console.ReadLine());
            Solution s = new Solution();
            Console.WriteLine($"The number of perfect squares in between is: {s.solution(a, b)}");
        }
    }
}
