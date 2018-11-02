using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_virtual_method
{
    class Shape
    {

        public Shape()
        {
        }

        public virtual string Draw()
        {
            return $"Hi, I am a shape";
        }
    }
}
