using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box a = new Box();
            Box b = new Box();

            a.setLength(1.0);
            a.setBreadth(2.0);
            a.setHeight(3.0);

            b.setLength(4.0);
            b.setBreadth(5.0);
            b.setHeight(6.0);

            Console.WriteLine($"Volume of Box1: {a.getVolume()}");
            Console.WriteLine($"Volume of Box1: {b.getVolume()}");

            Box c = a + b;
            Console.WriteLine($"Volume of Box1: {c.getVolume()}");
        }
    }
}
