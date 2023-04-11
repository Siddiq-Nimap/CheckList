using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate int MyDele(int a, int b);

    public class Employee
    {
        public string EmpName;
        public int EmpAge;
        public int EmpSalary;
    }

    public class Program
    {
                
        public void Add(int a , int b)
        {
            Console.WriteLine($"Your Addition value of this method {a+b}");
        }

        static bool Check(Employee employee)
        {
            return employee.EmpSalary < 100000;
        }

        public static void Main()
        {
            Employee Emp1 = new Employee();
            Employee Emp2 = new Employee();
            Employee Emp3 = new Employee();

            Emp1.EmpName = "Siddiq Shaikh";
            Emp1.EmpAge = 22;
            Emp1.EmpSalary = 220000;

            Emp2.EmpName = "Zahid Shaikh";
            Emp2.EmpAge = 22;
            Emp2.EmpSalary = 120000;

            Emp3.EmpName = "Arbaz Sayyed";
            Emp3.EmpAge = 22;
            Emp3.EmpSalary = 20000;

            List <Employee> list = new List<Employee>();
            list.Add(Emp1);
            list.Add(Emp2);
            list.Add(Emp3);

           var data1 = list.FindAll(model => model.EmpSalary > 100000);
            foreach (var item in data1)
            {
                Console.WriteLine(item.EmpName);
            }


            var data =  list.FindAll(Check);

            foreach (var item in data)
            {
                Console.WriteLine(item.EmpName);

            }

            Program obj = new Program();
            obj.Add(10,20);

            int num = 10;
            int num1 = 20;

            MyDele obj1 = (a, b) => a +  b;

            Func<int,int,int> obj2 = (a,b) => a + b;


            Console.WriteLine("The Addition Value is {0}",obj1.Invoke(num, num1));
            Console.WriteLine("The Addition Value is {0}",obj2.Invoke(20, 30));

            
            
        }
    }
}
