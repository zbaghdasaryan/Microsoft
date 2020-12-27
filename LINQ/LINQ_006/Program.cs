using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_006
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
            new Employee{FirstName = "B", LastName = "Byan", Nationality = "Armenia" },
            new Employee{FirstName = "C", LastName = "Cyan", Nationality = "Armenia" },
            new Employee{FirstName = "D", LastName = "Dyan", Nationality = "Russia" },
            new Employee{FirstName = "E", LastName = "Eyan", Nationality = "India" },
            new Employee{FirstName = "F", LastName = "Fyan", Nationality = "Iatly" },
            };

            var query = from emp in employees
                        orderby emp.Nationality ascending, emp.LastName descending, emp.FirstName ascending
                        select emp;

            foreach (var person in query)
            {
                Console.WriteLine("{0}, \t{1}, \t{2}", person.FirstName, person.LastName, person.Nationality);
            }

            Console.ReadKey();
        }
    } 
}
