using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee { Name = "Scott"},
                new Employee { Name = "Alex"},
                new Employee { Name = "Maciej"},
                new Employee { Name = "Wojciech"},
                new Employee { Name = "Natalia"},
                new Employee { Name = "Marysia"}
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            for (int i = 0; i< employee.Lenght; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
            
        }
    }
}
