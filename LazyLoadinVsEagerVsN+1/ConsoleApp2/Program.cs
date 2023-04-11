using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace ConsoleApp2
{
    public class EmployeeContex : DbContext
    {
        public EmployeeContex():base("EmployeeContex")
        {
           
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> managers { get; set; }
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public int EmpSalary { get; set; }
        public virtual ICollection<Manager> managers { get; set; }
    }
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string ManagerName { get; set; }
        


    }

    public class Program
    {
        

        static void Main(string[] args)
        {
            // to avoid N+1 issue we use Eager loading.
            EmployeeContex _context = new EmployeeContex();
            var emp = _context.Employees.Single(q => q.Id == 1); //First query

            foreach(var item in emp.managers) // Second Query  
            {
                Console.WriteLine(item.ManagerName);
            }

            Console.ReadLine();
        }
    }
}
