using System;

namespace Mod2_Lab1
{
    public class Employee
    {
        // 3 private member variables:
        // employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // Public properties
        // 1.) Name
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        // 2.) Base Salary
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }

        // 3.) Employee ID
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        // Employee Constructor 
        public Employee(String name, double baseSalary);
        {
            this.name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++; //ID # counter
        }

        // method to return the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // method to return the employee's name
        public String getName()
        {
            return this.Name;
        }

        public int getEmployeeID()
        {
            return this.ID;
        }

        // method to return employee ID + Name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        // method to return employee's ID + Name + confirm employee is in system 
        public virtual String employeeStatus()
        {
            return toString() + " is in the company's system";
        }

        // Create integer var, "employeeCount" + assigns value to 1
        private static int employeeCount = 1;
    }
}
