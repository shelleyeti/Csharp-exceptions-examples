using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Company chickenShack = new Company() { Name = "Greasy Pete's Chicken Shack" };
            chickenShack.AddEmployee(new Employee() { FirstName = "Pete", LastName = "Shackleton" });
            chickenShack.AddEmployee(new Employee() { FirstName = "Molly", LastName = "Frycook" });
            chickenShack.AddEmployee(new Employee() { FirstName = "Pat", LastName = "Buttersmith" });


            List<int> employeeIds = new List<int>() { 0, 11, 2 };
            foreach (int id in employeeIds)
            {
                try
                {
                    Employee employee = chickenShack.GetEmployeeById(id);
                    Console.WriteLine($"Employee #{id} is {employee.FirstName} {employee.LastName}.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Employee #{id} was not found in the company.");
                }
            }
        }
    }
}
