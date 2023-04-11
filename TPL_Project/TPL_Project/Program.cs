using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Project
{
    public class Program
    {
        public static void Show(int id , int sleep)
        {
            Console.WriteLine("The task {0} performing now ",id);

            Thread.Sleep(sleep);

            Console.WriteLine("The task {0} Completed now",id);
                
        }
        public static void Add100times()
        {
            int a = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //     a += i;
            //    Console.WriteLine("Your Addition"+ a);
            //    Thread.Sleep(1000);
            //}
            Parallel.For(0, 20, i => {
                a += i;

                Console.WriteLine("Your Addition {0}",a);
                Thread.Sleep(1000);
            
            }); // By using Parallel for instead of For loop it will double the speed of execution by using parallel execution. it will use the optimum utilization of all the cores.
        }
        public static void Main()
        {
            //Thread thread = new Thread(() => ShowMilliontimes(1,1500));
            //thread.Start();
            //Thread thread1 = new Thread(() => ShowMilliontimes(2, 2500));
            //thread1.Start();
            //Thread thread2 = new Thread(() => ShowMilliontimes(3, 2000));
            //thread2.Start();

           // THE MAJOR DIFFERENCE BETWEEN TASK AND THREAD IS THREAD USE TIME SLICING IT RUN FUCTION ON TIME BASE 
           // TASK RUN FUNCTION PARALLEL WAY MEAN IT USE THE OPTIMUM UTILIZATION OF ALL THE CORE.


            //Task T1 = new Task(() => Show(1, 1500));
            //T1.Start();
            //Task T2 = new Task(() => Show(2, 2500));
            //T2.Start();
            //Task T3 = new Task(() => Show(3, 2000));
            //T3.Start();
            Task T1 = Task.Factory.StartNew(() => Show(1, 1500));
            Task T2 = Task.Factory.StartNew(() => Show(2, 2000));
            Task T3 = Task.Factory.StartNew(() => Show(3, 2500));

            //Add100times();
            int a = 40;

            a = 44;

            a = 55;
            Console.WriteLine(a);
            
            Console.ReadLine();
            }
    }
}
