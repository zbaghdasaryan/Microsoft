using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_005
{
    public class EmployeeID
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<EmployeeID>
            {
            new EmployeeID{Id="11", Name="A Ayan" },
            new EmployeeID{Id="22", Name="B Byan" },
            new EmployeeID{Id="33", Name="C Cyan" },
            new EmployeeID{Id="44", Name="D Dyan" },
            new EmployeeID{Id="44", Name="E Eyan" },
            new EmployeeID{Id="11", Name="F Fyan" },
            };

            var empNationality = new List<EmployeeNationality>
            {
            new EmployeeNationality{Id="11", Nationality="Armenia" },
            new EmployeeNationality{Id="22", Nationality="Russia" },
            new EmployeeNationality{Id="33", Nationality="America" },
            };

            var query = from emp in employees
                        join n in empNationality
                        on emp.Id equals n.Id
                        orderby n.Nationality ascending //ascending, descending
                        select new
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Nationality = n.Nationality
                        };

            foreach (var person in query)
            {
                Console.WriteLine("{0}, {1}, {2}", person.Id, person.Name, person.Nationality);
            }

            Console.ReadKey();
        }
    }
}
