using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string firstName { get; }
        public string lastName { get; }
        public string Name
        {
            get { return String.Format("{0} {1}", firstName, lastName); }
        }
    }
}
