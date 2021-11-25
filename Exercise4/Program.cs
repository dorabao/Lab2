using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrix is a N * N 2D array
            Spiral s = new Spiral();
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 8, 7 }};
            s.SpiralArr(matrix);
            Console.ReadKey();
        }
    }
}
