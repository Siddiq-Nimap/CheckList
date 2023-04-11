using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremetiveVSNon
{
    public class Employee
    {
        public string EmpName;
        public int EmpAge ;
        public int Salary;


    }

    public class Premetive
    {
        public string Name ;
        public int Age;
        public int Salary;


        public void ShowPremetive(string Name , int Age , int Salary)
        {
            Console.WriteLine("Name : {0} \n Age : {1} \n Salary : {2}",Name,Age,Salary);
        }

        public void ShowNonPremetive(Employee Emp)
        {
            Console.WriteLine("Employee Name : {0}\n Employee Age : {1} \n Employee Salary : {2}\n",Emp.EmpName,Emp.EmpAge,Emp.Salary);
        }
        
        
        public static void Main()
        {

            Premetive pre = new Premetive();
            Console.WriteLine("This method is run by premetive data types");
            pre.ShowPremetive("Hamza Shaikh",22,22000); // In Premetive Data type we are passing the value to the method it is predefined.


            Console.WriteLine('--------------------------------------------');
            Console.WriteLine("This method is run by Non Premetive");
            Employee Emp = new Employee();
           
            Emp.EmpName = "Siddiq Shaikh";
            Emp.EmpAge = 22;
            Emp.Salary = 200000;

            pre.ShowNonPremetive(Emp); // Non -Premetive Data Type we are passing the Object Reference to the method it is user defined  

                


        }
    }
}
