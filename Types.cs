using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP2
{
    internal class TypeA
    {
        public int A{ get; set; }

        public void Fun01() 
        {
            Console.WriteLine("Fun01 From TypeA");
        }

        public TypeA(int A)
        {
            this.A = A;
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }

        public TypeA(int A)
        {
            this.A = A;
        }
    }


    //--//

    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        public new TypeA(int A)
        {
            this.A = A;
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B} );
        }

        public TypeB(int A, int B) : base(A)
        {
            this.A = A;
        }
    }

    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeC");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
        }

        public TypeC(int A, int B, int C) : base(A, B)
        {
            this.C = C;
        }
    }
}
