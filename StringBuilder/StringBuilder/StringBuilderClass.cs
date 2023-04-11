using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_topic
{
    public class StringBuilderClass
    { 
        public static void Main()
        {
            //String Builder is a class Which is mutable in nature it has various manipulations methods. some are
         StringBuilder builder = new StringBuilder("Hello World"); // initializing the string builder with value

            //you can also write this with following syntax to make a code clean.
            builder.Append("This is string", 1, 4)
                    .Insert(0, "This is Me")
                    .Remove(0, 10)
                    .Replace("Hello World",new string("T")) ;

            // You can also write as following.
            builder.Append("This is string", 1, 4);
            builder.Insert(0, "This is Me");
            builder.Remove(0, 10);
            builder.Replace("Hello World", new string("T"));

            // It helps for maipulation of a string on a same memory location.


            Console.WriteLine(builder);


        }
    }
}
