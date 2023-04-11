using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class StopTheWatch
    {
        static DateTime TimeStart;
        static DateTime TimeStop;

        public static void Begin(DateTime Start)
        {
            TimeStart = Start;
            
            Console.WriteLine("Your Time has started");
        }
        public static void End(DateTime Stop)
        {
            TimeStop = Stop;
            Console.WriteLine("Your time has been Stoped {0} ",TimeGap());
            
        }
        
        public static string TimeGap()
        {
            return (TimeStop - TimeStart).ToString();
            
        }

        public static void Main()
        {
            StopTheWatch obj = new StopTheWatch();

            while (true)
            {
                Console.WriteLine("Please Enter S for start , T for Stop , E for exit the program");
                ConsoleKeyInfo Ckey = Console.ReadKey(false);
                if (Ckey.Key == ConsoleKey.E)
                {
                    Console.WriteLine("E key was pressed programm exited");
                    return;
                }
                else if (Ckey.Key == ConsoleKey.S)
                {
                    Begin(DateTime.Now);
                }
                else if (Ckey.Key == ConsoleKey.T)
                {
                    End(DateTime.Now);
                }
                else
                {
                    Console.WriteLine("Please Enter valid Key to start");
                }
            }

        }
    }
}
