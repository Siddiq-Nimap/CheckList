using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculations
    {
            public Calculations()
            {
                Console.WriteLine("This is Default constructor!!!");
            }

            public Calculations(int a)
            {
                 a++;
                Console.WriteLine("Your Value has been incremented by {0}", a);
            }
            public Calculations(int a, int b)
            {
                Console.WriteLine("Your Addition Value is {0}", a + b);
            }
            public Calculations(params int[] ListNumber)
            {
                int result = 0;
                foreach (var item in ListNumber)
                {
                    result += item;
                }
                Console.WriteLine("Your Addition Value of Number List is {0}", result);
            }
            public static void Main(string[] args)
            {
                Calculations Obj = new Calculations();
                Calculations Obj1 = new Calculations(100);
                Calculations Obj2 = new Calculations(100, 100);
                Calculations Obj3 = new Calculations(100, 100, 100, 100, 100, 100);
            }
        }
    
}
