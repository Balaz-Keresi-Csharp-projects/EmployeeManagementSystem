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

        public void RegisterWorkHours(int workHours)
        {
            this.hoursWorked += workHours;
            Console.WriteLine("The employee {0} performed work for {1} hours so far.", Name, this.hoursWorked);
            /* We see, that this method for Employee class uses Console to perform operations. This should not be mixed with the operations, which are done on the UserInterface class.
             * The UserInterface class is responsible to communicate with the user.
             * Here the Console works as a placeholder. The messages ensure that, we did some useful work and the method was called from outside. It is not needed to refactor.
             * Similarly, this method may operate with the database or something else.
             */
        }

        public int CalculateWage()
        {
            return hourlyWage * hoursWorked;
        }
        public void Pay()
        {
            int currentWage = this.CalculateWage();
            receivedWage += currentWage;
            Console.WriteLine("The employee {0} got paid for {1} hours of work with {2} dollars. He/she got {3} dollars so far.", Name, hoursWorked, currentWage, receivedWage);
            hoursWorked = 0;
            /* We see, that this method for Employee class uses Console to perform operations. This should not be mixed with the operations, which are done on the UserInterface class.
             * The UserInterface class is responsible to communicate with the user.
             * Here the Console works as a placeholder. The messages ensure that, we did some useful work and the method was called from outside. It is not needed to refactor.
             * Similarly, this method may operate with the database or something else.
             */
        }
    }
}
