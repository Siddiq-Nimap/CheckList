using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Calculations
    {
        public void Calculator()
        {
            Console.WriteLine("No Calculation Occured Please pass Numeric Parameters ");
        }
        public void Calculator(int a, int b)
        {
            Console.WriteLine("Your Addition Value for two numbers is {0}",a +b);
        }
        public void Calculator(params int[] NumberList)
        {
            int Result = 0;
            foreach (var item in NumberList)
            {
                Result += item;
            }
            Console.WriteLine("Your Addition Value of Vairable Numbers is {0}",Result);
        }
        public static void Main(string[] args)
        {
            Calculations Obj = new Calculations();

            Obj.Calculator();
            Obj.Calculator(23,24);
            Obj.Calculator(23,23,234,23,23,23,22);

     
        }
    }
}
