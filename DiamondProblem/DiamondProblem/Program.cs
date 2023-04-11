using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is Base Class method");
        }
    }
    public class B:A
    {
        public override void Print()
        {
            Console.WriteLine("This is Derived Class Method B");
        }
    }
    public class C:A
    {
        public override void Print()
        {
            Console.WriteLine("This is Deried Class Method C");
        }
    }

    public class Program:B,C // First we Cannot Create the Multiple class inheritance in C# 
    {   
        // It is called Diamond Problem. in this there is an amiguity that which derived class method will invoke
    }
}
