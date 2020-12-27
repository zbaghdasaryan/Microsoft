using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_001
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "A",
                    LastName = "Ayan",
                    Salary = 350000,
                    StartDate = DateTime.Parse("12/3/2000")
                },

                new Employee
                {
                    FirstName = "B",
                    LastName = "Byan",
                    Salary = 250000,
                    StartDate = DateTime.Parse("11/1/2005")
                },
                new Employee
                {
                    FirstName = "C",
                    LastName = "Cyan",
                    Salary = 330000,
                    StartDate = DateTime.Parse("5/11/2001")
                },
                new Employee
                {
                    FirstName = "D",
                    LastName = "Dyan",
                    Salary = 550000,
                    StartDate = DateTime.Parse("1/1/1995")
                },
            };

            var query = from employee in employees
                        where employee.Salary > 250000
                        orderby employee.LastName, employee.FirstName
                        select new
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName
                        };
            Console.WriteLine("highly paid employees");

            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }

            Console.ReadKey();
        }
    }
}
