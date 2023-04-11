using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Every Animal Make Sound");
            
        }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Makes Meow Sound");
            //base.Sound();  Redirect to Base Class method.
        }
        
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dogs Makes Bow Sound");
        }
    }    
    public class Lion : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Lion Makes Roar Sound");
        }
    }

    public class Program
    {
        
        public static void Main()
        {
            Lion obj = new Lion();
            obj.Sound(); // it will call its method no difference as compare to method hiding concept.

            Console.WriteLine("-------------");

            Animal obj1 = new Lion();
            obj.Sound(); // By taking Reference Variable as base class it still call the overided method.
        }
    }
}
