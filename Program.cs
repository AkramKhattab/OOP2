using C42_G04_OOP2.Inheritance;
using System.Threading.Channels;

namespace C42_G04_OOP2
{

        internal class Program
        {
            static void Main()
            {
            #region Inheritance
                // Class -> Class
                // Class
                // DRY


                //Child child = new Child(1, 2);
                //Console.WriteLine(child.X); //1
                //Console.WriteLine(child.Y); //2


                //child.X = 12;
                //child.Y = 13;

                //Console.WriteLine(child.X); //12
                //Console.WriteLine(child.Y); //13
                //child.Fun01(); //Fun01 From Parent
                //child.Fun02(); // X : 12



                #endregion

            #region Relationships Between Classes

                //       class Item { }
                //class Order
                //{
                //    public Item Item { get; set; } // Requierd
                //}

                //class Chairs { }
                //class Room
                //{
                //    public Chairs? Chairs { get; set; }
                //}

                //class Product
                //{

                //}

                //class Cart
                //{
                //    public Product Product { get; set; }

                //}

                //1. Inherentance : is a [FulllTimeEmployee is a Employee] [Child is A Parent]
                //2. Aggregation : has a [Order  has Item] [Room Has Wall]
                //  2.1 Composotion: Order Has Item, Room Has a Wall
                //  2.2 Association: Room has Chairs - Cart has Product

                #endregion

            #region Polymorphism

                #region Polymorphism - Methods [Functions] Overloading

                //static int Sum(int X, int Y)
                //{
                //    return X + Y;
                //}


                //static int Sum(double X, double Y)
                //{
                //    return (int)((int)X + Y);

                //}

                //static int Sum(int X, int Y, int Z)
                //{
                //    return X + Y + Z;
                //}




                //Polymorphism - Methods [Functions] Overloading
                // Polymorphism - Methods [Functions] Overriding


                //Console.WriteLine();

                //object 01;
                //    01 = new object();
                //    01 = "Hello";
                //    01 = 1;
                //    01 = 1.4;
                //    01 = 1.4f;
                //    01 = 1.4m;



                //1- Polymorphism - Methods [Functions] Overloading
                // More Than One Functions [Methods] Has The Same Name But with Different Signature
                //[Count - Type - Order] Parameters
                // Struct : Encapsulation - Polymorphism - Methods [Functions] Overloading


                Console.WriteLine(Sum(1, 2));
                Console.WriteLine(Sum(1.2, 2.5));

                int X = 1;


                Sum(1.5, 1.4);
                Sum(1, 2, 3);
                Sum(1, 1.5);









                #endregion

            #region Polymorphism - Methods [Functions] Overriding

            /* More Than Functions Has The Same Name And The Same Signature But with different Behavior [Note : Not in the same scope]
             * 
             * 
             * 
             * */

            //TypeA typeA = new TypeA();
            //typeA.A = 12;

            //typeA.Fun01(); // I am Base [Parent]
            //typeA.Fun02(); // A:12

            //TypeB typeB = new TypeB();

            //typeB.A = 12; // I am Child
            //typeB.B = 13; // A:12

            // Override usnig new Keyword

            //typeB.Fun01(); // I am Child


            // Override using override Keyword
            //typeB.Fun02(); // A:12, B: 13





            #endregion





            #endregion

            #region What is Binding

            // Reference From Parent -> Object from Child

            //TypeA typeA;
            // typeA => Can Refere to object from type "TypeA" Or Any Class Inhireted From TypeA

            //typeA = new TypeA();
            //typeA = new TypeB();

            //typeA.A = 12;
            //typeA.B = 13; // Invalid

            //typeA.Fun01();  // using new keyword     //I am Base [Parent]
            // Static Binding
            // Compiler will be Bind the function call based on reference Type not the Object Type as Compilation Time

            //typeA.Fun02();  // using override keyword     // A: 12, B: 0
            // Dynamic Binding

            // CLR will bind the function call based on Object Type not the Reference Type
            // RunTime

            #endregion

            #region Not Binding

            /* RefernceFromParent -> ObjectFromChild
             * 
             * */

            //TypeA typeA = new TypeB(); // Binding
            //TypeB is TypeA
            // Child is Parent
            //TypeA typeA = new TypeA();
            //TypeB typeB = new TypeB();
            //// Not Binding
            //TypeB typeB = (TypeB)typeA;
            // TypeA is a TypeB
            // Animal = Dong // Binding
            // Dog = (Dog) Animal // not binding

            //object o1 = new object();
            //o1 = 1;
            //o1 = "Ahmed";

            //int X = (int) o1;
            // Object is int

            #endregion

            #region When you need Binding

        //            class Employee
        //{

        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Email { get; set; }

        //    public void Fun01()
        //    {
        //        Console.WriteLine("I Am Employee");
        //    }

        //    public virtual void Fun02()
        //    {
        //        // Salary
        //        Console.WriteLine("");
        //    }

        //    class FullTimeEmployee : Employee
        //    {
        //        public double Salary { get; set; }
        //        // using new KeyWord
        //        // Static Bindid Method
        //        // Compiler will Bind the function call Based on the Reference Type not the object type
        //        public new void Fun01()
        //        {
        //            Console.WriteLine("I Am FullTimeEmployee");
        //        }

        //        // using Override Keyword
        //        // Dynamic Bindind Method
        //        // CLR will bind the function call based on ObjectType Not the ReferenceType in RunTime
        //        public override void Fun02()
        //        {
        //            // Salary
        //            Console.WriteLine(Salary);
        //        }
        //    }

        //    class PartTimeEmployee : Employee
        //    {
        //        public double HourRate { get; set; }
        //        public int NumberOfHours { get; set; }
        //        public override void Fun01()
        //        {
        //            Console.WriteLine("I Am PartTimeEmployee");
        //        }
        //        public override void Fun02()
        //        {
        //            // Salary
        //            Console.WriteLine(HourRate * NumberOfHours);
        //        }
        //    }

        //    static void ProcessEmployee(FullTimeEmployee employee)
        //        {
        //            if (employee is not null)
        //            {
        //                employee.Fun01();
        //                employee.Fun02();
        //            }

        //        }
        //        static void ProcessEmployee(PartTimeEmployee employee)
        //        {
        //            if (employee is not null)
        //            {
        //                employee.Fun01();
        //                employee.Fun02();
        //            }

        //        }


        //        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        //        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
                
        //        //ProcessEmployee(fullTimeEmployee);
        //        ProcessEmployee(partTimeEmployee);
        //        // Passing by Value
        //        //(Copy of the Address(partTimeEmployee))



                #endregion

            }
        }
    }
