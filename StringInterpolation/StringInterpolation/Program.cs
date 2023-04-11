using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{

    public class Program
    {
        public void Add(Char a , char b)
        {
            Console.WriteLine("Your Addition Value for " + a + "and" + b + "Is " + a+b);
            Console.WriteLine("This is addition is Performed By string Concatination\n");
        }
        public void Add(string a , string b)
        {
            Console.WriteLine("This is Addition is Performed by String Formating");
            Console.WriteLine("Your Addition Value for {0} and {1} Is {2}\n",a,b,a+b);
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("This Addition is Performed by string Interpolation");
            Console.WriteLine($"Your Addition Value for {a} and {b} Is {a+b}\n");
        }

        public static void Main()
        {
            Program Obj  = new Program();
            Obj.Add('A', 'B');
            Obj.Add("Siddiq","Shaikh");
            Obj.Add(23, 23); //  In String Interpolation we Directly call the variable value inside the string.String Interpolation is very organize and readable.

            Console.WriteLine("-----------------------------");
            
            string Desc = "Siddiq Shaikh";
            Stopwatch st1 = new Stopwatch();
            st1.Start();
            for (int i = 0; i < 1000; i++) // In This case Due to Immutable of string it will continuously create a new memory location.
            {
                Desc = Desc + i;
            }
            st1.Stop();

            Console.WriteLine("-----------------------------");

            StringBuilder builder = new StringBuilder();

            builder.Append("Siddiq Shaikh");
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < 1000; i++) // In this case Due to Mutable of stringbuilder it will not create new memory loaction it will modify the string in the same memory location.
            {
                builder.Append(i);
            }
            st.Stop();
            Console.WriteLine("-----------------------------");
                    
            Console.WriteLine("Time Occur While Appending string {0}",st1.ElapsedMilliseconds);
            Console.WriteLine("Time Occur While Appending stringBuilder {0}",st.ElapsedMilliseconds);





        }
    }
}
