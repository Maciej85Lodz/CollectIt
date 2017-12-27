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
            var emploeesByDeparment = new Dictionary<string, List<Employee>>();

            emploeesByDeparment.Add("SoftwareDeveloper", 
                new List<Employee>() { new Employee { Name = "Maciej" } });
            //...
            emploeesByDeparment["SoftwareDeveloper"].Add(new Employee { Name = "Maciej" });


            foreach (var item in emploeesByDeparment)
            {
                foreach (var employee in item.Value)
                    Console.WriteLine(employee.Name);
                    Console.ReadLine();
            }


        }
    } 
}

