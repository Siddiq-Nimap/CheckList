using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVSRef
{
  
    public class Program
    {

       public void Cal(int a)
        {

;            Console.WriteLine("The Increment Value for cal is a"+a++);
        }

        public void Call(out int a)
        {
            a = 0;
;            Console.WriteLine("The Increment Value for cal is a" + a++);
        }
           

        public void Cal(ref int a)
        {
            a = 7;
            Console.WriteLine("The Incerement Value for cal is"
                +a++);
        }

        public static void Main(string[] args)
        {
            Program obj = new Program();
        // REFERENCE TYPE 
            int a = 5;

            obj.Cal(ref a); //8 We cannot pass the variable without initializing in the method as compare to value type it pass the reference of the variable and can affects the original value.

            Console.WriteLine(a); //8
            // VALUE TYPE
            obj.Cal(a);//9   this is a value type  we pass the value and it doesn't Affects the original value.
            Console.WriteLine(a);//8

            
        obj.Call( out a); // We can Initialise the value in method as well as outside the method Major differnce between ref and out
            Console.WriteLine(a);

         

        }

    }
}
