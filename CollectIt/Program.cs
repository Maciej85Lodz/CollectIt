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
            var emploeesByName = new Dictionary<string, Employee>();

            emploeesByName.Add("Scott", new Employee { Name = "Scott" });
            emploeesByName.Add("Maciej", new Employee { Name = "Maciej" });
            emploeesByName.Add("Alex", new Employee { Name = "Alex" });

            var scott = emploeesByName["Maciej"];
            foreach(var item in emploeesByName)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name);
                Console.ReadKey();
            }


        }
    } 
}

