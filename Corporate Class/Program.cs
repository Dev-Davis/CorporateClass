using System;
using System.Collections.Generic;

namespace Corporate_Class
{
   
    class Program
    {
        public static List<Employee> CodeOrDieEmployee { get; private set; }

        static void Main(string[] args)
        {
            Company CodeOrDie = new Company();

            Employee ron = new Employee();
            ron.firstName = "Ron";
            ron.lastName = "Jenkins";
            ron.startDate = "02-31-07";

            Employee janice = new Employee();
            janice.firstName = "Janice";
            janice.lastName = "Wilkerson";
            janice.startDate = "03-19-12";

            Employee david = new Employee();
            david.firstName = "David";
            david.lastName = "Ransom";
            david.startDate = "09-31-19";

            List<Employee> CodOrDieEmployee = new List<Employee>();

            CodOrDieEmployee.Add(ron);
            CodOrDieEmployee.Add(janice);
            CodOrDieEmployee.Add(david);

            CodeOrDie.employees = CodeOrDieEmployee;

            foreach (var em in CodOrDieEmployee)
            {
                Console.WriteLine(em.firstName);
                Console.WriteLine(em.lastName);
                Console.WriteLine(em.startDate);
            }
        }

    }
}
