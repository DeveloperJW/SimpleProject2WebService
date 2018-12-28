using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleProject2WebService
{
    public class EmployeeList
    {
        public List<Employee> employeeList { get; set; }
        public EmployeeList()
        {
            employeeList = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }


        public override string ToString()
        {
            return "Employee List: there are "+employeeList.ToArray().Length+" employees in the list.";
        }

    }
}

