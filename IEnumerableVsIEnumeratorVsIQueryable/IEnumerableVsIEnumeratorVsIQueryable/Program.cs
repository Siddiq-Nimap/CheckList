using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIEnumeratorVsIQueryable
{

    public class Program
    {
        public static void Enumerables(IEnumerable<string> Manager)
        {
            Console.WriteLine("Printing Ienumerable second method");
            foreach (var item in Manager)
            {
                Console.WriteLine(item);
            }
        }
        public static void Enumerators(IEnumerator<string> Manager)
        {
            Console.WriteLine("Printing Ienumerator Second Method");
            while (Manager.MoveNext())
            {
                Console.WriteLine(Manager.Current.ToString());
            }
        }

        static void Main(string[] args)
        {
            List<string> ManagerList = new List<string>()
        {
            "Siddiq Shakikh",
            "Zahid Shaikh",
            "Arbaz Sayyed",
            "Salman Abbas",
            "Arif Khan",
            "Tauhid Quresh",
            "Asjad Shaikh",
            "Faizan Shaikh"
        };

            IEnumerable<string> enumerable = ManagerList;

            Console.WriteLine("Printing ienumerable");
            foreach (var item in enumerable)
            {
                if (item == "Salman Abbas")
                {
                    Enumerables(ManagerList);
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Printing IEnumerator");
            IEnumerator<string> enumerator = ManagerList.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
                if (enumerator.Current == "Salman Abbas")
                {

                    Enumerators(enumerator);
                }
            }
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }
    }
}
