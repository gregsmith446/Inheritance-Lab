using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object called employee1
            var employee1 = new Employee("Greggo", 2000);
            // Instantiates TechnicalEmployee Object called employee2
            var employee2 = new TechnicalEmployee("Craigory");
            // Instantiates BusinessEmployee Object called employee3
            var employee3 = new BusinessEmployee("Jerimiah");

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
