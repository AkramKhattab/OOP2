using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP2.Inheritance
{
    internal class TypeB : TypeA
    {

        public int B { get; set; }

        // Hide

        // Applying Function Overriding using new Keyword
        // Static Binded method
        // Compiler will be Bind the function call based on reference Type not the Object Type as Compilation Time


        public new void Fun01() // new Virsion
        {

            Console.WriteLine("I am Child");

        }

        // Applying Function Overriding using Override Keyword
        // The inherited Member Must Be Public virtual Methood
        // Dynamic Binded method
        // CLR will bind the function call based on Object Type not the Reference Type
        // RunTime


        public override void Fun02() // using override
        {

            Console.WriteLine($"A: {A}, B:{B}");


        }
}
