using System;
using System.Collections.Generic;

namespace Algorithms {
    class Employee {

        string name;
        int id;
        string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> EmployeesById = new Dictionary<int, Employee>();
            EmployeesById.Add(employee.id, employee);
            EmployeesById.Add(employee2.id, employee2);
            EmployeesById.Add(employee3.id, employee3);

            //TryGetValue has a "sideeffect"of the fx- out value : out if true
            Employee e;
            if (EmployeesById.TryGetValue(9415, out e))
            {
                Console.WriteLine(e.name + e.department);
            }
            Console.WriteLine("Hello");

            //Hashset is useful to see if something is contianed in a group 
            HashSet<string> productNo = new HashSet<string>();
            productNo.Add("ED879797");
            productNo.Add("RT879TY7");
            productNo.Add("ET876797");

            productNo.Contains("RT879TY7");
            productNo.Contains("hg");
        }
    }
}