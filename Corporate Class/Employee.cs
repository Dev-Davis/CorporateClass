using System;

namespace Corporate_Class
{
    public class Employee
    {
        public string name;
        public string jobTitle;
        public DateTime dateTime;

        public Employee(string name, string jobTitle, DateTime dateTime)
        {
            this.name = name;
            this.jobTitle = jobTitle;
            this.dateTime = dateTime;
        }
    }
}