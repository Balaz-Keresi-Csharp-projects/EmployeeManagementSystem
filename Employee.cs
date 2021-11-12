using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        int workHours;
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            this.workHours = 0;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string Name
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        
        public string RegisterWorkHours(int workHours)
        {
            this.workHours += workHours;
            return String.Format("The employee {0} performed work for {1} hours so far.", Name, this.workHours);
        }
    }
}
