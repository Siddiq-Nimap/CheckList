using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASYNCvsAWAIT
{
    public class Program
    {
        public static async void Run()
        {
            Stopwatch st = new Stopwatch();

            st.Start();
            await Task.Run(()=> Execution(1, 5000));
            // Because of new thread and parallel execution of task This line is printing first 
            // to wait this line and print after the execution we use Async and await keyword
            st.Stop();
            Console.WriteLine($"Your execution Time{st.ElapsedMilliseconds}");

        }
        public static  void Execution(int id , int sleep)
        {
            
            Console.WriteLine("Your Program {0} Started Successfully",id);
            Thread.Sleep(sleep);
            Console.WriteLine("Your Program {0} Completed Successfully",id);
            
        }
        public static void Main()
        {
             Run();

           Console.ReadLine();

        }
    }
}
