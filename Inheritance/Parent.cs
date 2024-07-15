using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP2.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From Parent");
        }

        public void Fun02()
        {
            Console.WriteLine($"X: {X}");
        }

        //public Parent()
        //{ 
        //}

        // CONSTRUCTOR
        public Parent(int x)
        {
            X = x;
        }
    }
}
