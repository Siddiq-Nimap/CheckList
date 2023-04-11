using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProp
{
    public class Employee
    {
        public string EmpName;
        public int Age;
        public int Salary;
    }

    public class Program
    {
        
        public static void Main()
        {
            List <int> Integers = new List <int>(); // List is Generic Type in Nature

            Integers.Add (1); // adding the number
            Integers.AddRange(new[] { 2, 3, 4, 5, 6 }); // Adding the Array to list 

            foreach (var item in Integers)
            {
                Console.WriteLine(item);
            }

            Integers.Insert(0, 999); // Inserting the the value at Index;
            Integers.Sort(); // Sorting the List
            foreach (var item in Integers)
            {
                Console.WriteLine(item);
            }
            Integers.Remove(999); // Removing the value

            Integers.Clear(); // Clearing all the values from list 
            foreach (var item in Integers)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("New List After Clearing");
            Integers.AddRange(new List<int>{2,3,2,4,5,3}); // Adding New List into existing list

            foreach (var item in Integers)
            {
                Console.WriteLine(item);
            }

            Employee obj = new Employee();
            obj.EmpName = "Rashid Shaikh";
            obj.Salary = 220000;
            obj.Age = 22;
            
            List<Employee> Emp = new List<Employee>(); // We can also pass the non premetive data types in list as shown

            Emp.Add(obj);

            foreach (var item in Emp)
            {
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Salary);
            }

        }
    }
}
