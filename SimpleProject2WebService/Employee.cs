using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleProject2WebService
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Manager { get; set; }
        public string Department { get; set; }

        public Employee()
        {
            FirstName = "";
            LastName = "";
            Position = "";
            Manager = "";
            Department = "";

        }

        public Employee(string firstName, string lastName, string postion, string manager, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = postion;
            Manager = manager;
            Department = department;
        }
        public override string ToString()
        {
            return "Employee: " + FirstName + " " + LastName + ", " + Position + ", " + Manager + " " + Department;
        }
    }
}