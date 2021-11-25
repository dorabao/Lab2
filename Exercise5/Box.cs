using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Box
    {
        private double length = 0;
        private double breadth = 0;
        private double height = 0;

        public double getVolume() 
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public static Box operator+ (Box a, Box b)
        {
            Box c = new Box();
            c.length = a.length + b.length;
            c.breadth = a.breadth + b.breadth;
            c.height = a.height + b.height;
            return c;
        }
    }
}
