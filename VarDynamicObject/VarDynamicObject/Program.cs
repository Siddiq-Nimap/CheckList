using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDynamicObject
{
    public class Employee
    {
        public  void Show()
        {
            
            Console.WriteLine("This is Show Method of base class");
        }
    }

    public class Program:Employee
    {
        public new void  Show()
        {
            base.Show();
            //Console.WriteLine("This is Show Method of Derived Class");
        }
        public /*var*/ dynamic Show(/*var*/ dynamic a) // we cannot give the var as paramaters  Var but can give the params as dynamic. 
        {
            int b = 1;
            var c = 332;
            return c;
        }
        public static void Main()
        { 

            var a = 55;
            var b = "Siddiq"; // Var can store differnt data types and it checks on the compile time. 

            /*a = "Siddiq"*/;// overHere Var is a Value type it cannot change when it is assign.


            dynamic ab = 44;
            ab = "Siddiq Shaikh"; //We can reassign the value to dynamic because of its reference type. 
            Console.WriteLine(ab.GetType()); // Properties are disabled while using dynamic type due to it checks the value at run time.

            object sd = 22; // Basically Object type is a parent class for all data types it accept all the data types. 
            sd = 22; // Because it is a reference type in nature






            
        }
    }
}
