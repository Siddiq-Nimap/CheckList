using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStack
{
    public class Program
    {
        public static void Main()
        {
            // stack stores the data in LIFO format and it comes in both generic and non generic

            Stack store = new Stack();

            store.Push("Ahmed Ahsaan Shaikh");
            store.Push(22);
            store.Push("Programmer");
            store.Push(992299229);
            store.Push(2200000);

            foreach (var item in store) // will give all the element of the stack in LIFO format
            {
            Console.WriteLine(item);
            }

            Console.WriteLine("Cloning the stack Store in Store 2 and printing");

            Stack Store2 = (Stack)store.Clone(); 

            Console.WriteLine(Store2.Peek()); // Return the First element of Second clone stack

            Console.WriteLine("Using Pop to get First element with removing");
            Console.WriteLine(store.Pop()); // Return First Element with removing.


            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("After Removing First element with pop");
            foreach (var item in store) // will give all the element of the stack in LIFO format
            {
                Console.WriteLine(item);
            }
            store.Clear();






        }
    }
}
