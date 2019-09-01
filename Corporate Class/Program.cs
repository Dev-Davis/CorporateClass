using System;
using System.Collections.Generic;

namespace Corporate_Class
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public List<Employee> employees { get; set; } = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void addEmployee(string name)
        {
            var newEmployee = new Employee(name, "Janitor", DateTime.Today);
            employees.Add(newEmployee);
        }
        // Create a method that allows external code to remove an employee
        public void subEmployee(string name)
        {
            var term = new Employee(name, "Clerk", DateTime.Today);
            employees.Remove(term);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
    
            The constructor will set the value of the public properties
        */
        public Company(string name)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name...");
            var input = Console.ReadLine();
            var company = new Company("cool company");

            company.addEmployee(input);
            for (var i = 0; i < company.employees.Count; i++)
            {
                Console.WriteLine(company.employees[i].name);
            }
        }

    }
}
