using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP2.Inheritance
{
    internal class Child : Parent
    {
        public int Y { get; set; }
        

        // CLR
        // EXTERNAL CONSTRUCTOR Chaining
        public Child(int x, int y) : base(x) 
        {
            Y = y;
        }

    }
}
