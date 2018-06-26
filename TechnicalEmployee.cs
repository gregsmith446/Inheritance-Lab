using System;
namespace Mod2_Lab1
{
    // inherit from Employee Class
    class TechnicalEmployee : Employee
    {
        // create int var and assign initial value to 5
        public int successfulCheckIns = 5;

        // Calls on base-class, the Employee Class constructor base(name, 75000)
        // Sets baseSalary to 75000 for all TechnicalEmployee objects
        public TechnicalEmployee(String name) : base(name, 75000)
        {
        }

        // method returns the toString() method, which is the employee's ID num + name
        // then prints the # of successful check ins employee has had
        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
