using System;
using System.Collections.Generic;
using System.Text;

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

        public void RegisterWorkHourForEmployee(string selectedEmployeeName, int hoursWorked)
        {
            Employee selectedEmployee = SelectEmployeeByName(selectedEmployeeName);
            selectedEmployee.RegisterWorkHours(hoursWorked);
        }

        public int CalculateWageForEmployee(string selectedEmployeeName)
        {
            Employee selectEmployee = SelectEmployeeByName(selectedEmployeeName);
            return selectEmployee.CalculateWage();
        }

        public void PayEmployee(string selectedEmployeeName)
        {
            Employee selectedEmployee = SelectEmployeeByName(selectedEmployeeName);
            selectedEmployee.Pay();
        }
    }
}
