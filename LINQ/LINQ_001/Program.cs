using System;
using System.Collections.Generic;
using System.Linq;

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
                    FirstName = "D",
                    LastName = "Dyan",
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
                    FirstName = "A",
                    LastName = "Ayan",
                    Salary = 330000,
                    StartDate = DateTime.Parse("5/11/2001")
                },
                new Employee
                {
                    FirstName = "C",
                    LastName = "Cyan",
                    Salary = 550000,
                    StartDate = DateTime.Parse("1/1/1995")
                },
                 new Employee
                {
                    FirstName = "Ab",
                    LastName = "Ayan",
                    Salary = 340000,
                    StartDate = DateTime.Parse("5/11/2001")
                },
                  new Employee
                {
                    FirstName = "Cb",
                    LastName = "Cbyan",
                    Salary = 600000,
                    StartDate = DateTime.Parse("1/1/1997")
                },
            };

            var query1 = from employee in employees
                         where employee.Salary > 320000
                         orderby employee.LastName, employee.FirstName

                         //ananymous type
                         select new
                         {
                             LastName = employee.LastName,
                             FirstName = employee.FirstName
                         };

            //query using extension methodes
            var query2 = employees.
                         Where(emp => emp.Salary > 320000).
                         OrderBy(emp => emp.LastName).
                         OrderBy(emp => emp.FirstName).
                         Select(emp => new
                         {
                             LastName = emp.LastName,
                             FirstName = emp.FirstName
                         });

            //query using static methodes
            var query3 = Enumerable.Select(
                         Enumerable.OrderBy(
                         Enumerable.OrderBy(
                         Enumerable.Where(
                         employees, emp => emp.Salary > 320000),
                         emp => emp.LastName),
                         emp => emp.FirstName),
                         emp => new { LastName = emp.LastName, FirstName = emp.FirstName });


            Console.WriteLine("highly paid employees");

            foreach (var item in query1)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }

            Console.WriteLine(new string('-', 30));
            foreach (var item in query2)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }

            Console.WriteLine(new string('-', 30));
            foreach (var item in query3)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
            Console.ReadKey();
        }
    }
}
