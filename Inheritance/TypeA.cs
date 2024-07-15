using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP2.Inheritance
{
    internal class TypeA
    {
        public int A{ get; set; }
    }

    public void Fun01()
    {

        Console.WriteLine("I am Base [Parent] ");

    }

    public virtual void Fun02()
    {

        Console.WriteLine($"A: {A}");

    }


}
