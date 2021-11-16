using System;

namespace EmployeeManagementSystem
{
    class Employee
    {
        int hoursWorked;
        int hourlyWage;
        int receivedWage;
        public Employee(string firstName, string lastName, int hourlyWage)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            this.hourlyWage = (hourlyWage > 0) ? hourlyWage : 0;
            this.hoursWorked = 0;
            this.receivedWage = 0;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string Name
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public int HourlyWage 
        {
            get { return hourlyWage; }
            set
            {
                hourlyWage = (value > 0) ? value : 0;
            }
        }

        public string RegisterWorkHours(int workHours)
        {
            this.hoursWorked += workHours;
            return String.Format("The employee {0} performed work for {1} hours so far.", Name, this.hoursWorked);
        }

        public int CalculateWage()
        {
            return hourlyWage * hoursWorked;
        }
        public string Pay()
        {
            int currentWage = this.CalculateWage();
            receivedWage += currentWage;
            string returnString = String.Format("The employee {0} got paid for {1} hours of work with {2} dollars. He/she got {3} dollars so far.", Name, hoursWorked, currentWage, receivedWage);
            hoursWorked = 0;
            return returnString;
        }
    }
}
