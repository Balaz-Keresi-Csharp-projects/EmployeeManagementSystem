using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeManagementSystem
    {
        List<Employee> employees = new List<Employee>();

        private Dictionary<string, string> availableActions;
        public EmployeeManagementSystem()
        {
            employees.Add(new Employee("Jovan", "Andric", 10));
            employees.Add(new Employee("Milica", "Komosar", 20));
            employees.Add(new Employee("Silene", "Oliveria", 15));
            employees.Add(new Employee("John", "Smith", 20));
        }
        
        public String ListAllEmployees()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine();
            outputString.AppendLine("The Employees managed by the System:");
            foreach (var employee in employees)
            {
                outputString.AppendLine(String.Format("\t{0}", employee.Name));
            }

            return outputString.ToString();
        }

        public Employee SelectEmployeeByName(string selectedEmployeeName)
        {
            return employees.Find(condition => condition.Name.Equals(selectedEmployeeName));
        }

        public void RegisterWorkHourForEmployee()
        {
            Console.Write("Type the name of employee, for which you want to register the work hours. Type 'ret' if you want to return to the main menu. ");
            string selectedEmployeeName = Console.ReadLine();
            Employee selectedEmployee = SelectEmployeeByName(selectedEmployeeName);

            try
            {
                Console.Write("How much hours did {0} work? ", selectedEmployee.Name);
                int workHours = Int32.Parse(Console.ReadLine());
                Console.WriteLine(selectedEmployee.RegisterWorkHours(workHours));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Worker with name: '{0}' does not exist in the database", selectedEmployeeName);
            }
            catch (FormatException)
            {
                Console.WriteLine("Number of work hours should be an integer parmaeter");
            }
        }

        public void CalculateWageForEmployee(string selectedEmployeeName)
        {
            Employee selectEmployee = SelectEmployeeByName(selectedEmployeeName);
            int wage = selectEmployee.CalculateWage();
            Console.WriteLine("The expected wage of employee {0} will be {1}", selectedEmployeeName, wage);
        }

        public void PayEmployee(string selectedEmployeeName)
        {
            Employee selectedEmployee = SelectEmployeeByName(selectedEmployeeName);
            Console.WriteLine(selectedEmployee.Pay());
        }
    }
}
