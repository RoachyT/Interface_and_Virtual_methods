using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_virtual_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine(square.Draw());
            Console.WriteLine($"My area is {square.GetArea(9)}!");
        }

        //SOLID
        //each class only does 1 thing. shape defines draw, square gets the area. 
        // seems pretty solid to me. if the interface was used it would be a little better since interface 
        // would define what needs to be done and could be applicable with other shapes.
        //with Square we can add new functionality without changing the code to shape 

    }
}
