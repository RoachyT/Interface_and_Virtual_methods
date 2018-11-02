using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_virtual_method
{
    class Square : Shape
    {
        public double Side{ get; set; }
        public Square()
        {
            Side = 0;
        }
        public Square(double side)
        {
            Side = side;
        }

        public override string Draw()
        {
            return $"Hi, I am a Square";
        }

        public double GetArea(double side)
        {
            return side * side;
        }
    }
}
