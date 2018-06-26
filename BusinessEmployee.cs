using System;

namespace Mod2_Lab1
{
    // Have Business Employee Class inherit from Employee Class
    class BusinessEmployee : Employee
    {
        // Create double var called bonusBudget + assign initial value of 1000
        public double bonusBudget = 1000;

        // Calls on base-class, the Employee Class constructor base(name, 50000)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(String name) : base(name, 50000)
        {
        }

        // Return the toString() method, which = employee ID num + name & prints bonus budget
        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
