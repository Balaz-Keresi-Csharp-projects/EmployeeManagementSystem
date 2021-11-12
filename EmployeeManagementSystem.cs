using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeManagementSystem
    {
        // Idea: It is posible to refactor the availableActions dictinoary to create a class. That way the logic to select and parse the actions can be removed to EmployeeManagementSystem
        List<Employee> employees = new List<Employee>();

        private Dictionary<string, string> availableActions;
        public EmployeeManagementSystem()
        {
            availableActions = new Dictionary<string, string>();
            availableActions.Add("1", "List all of the employees in the system");
            availableActions.Add("2", "Report some hours of work for the employee");
            availableActions.Add("3", "Calculate the wage of an employee");
            availableActions.Add("4", "Pay the wage for the employee");
            availableActions.Add("5", "List all of the available actions");
            availableActions.Add("Q", "Exit");

            employees.Add(new Employee("Jovan", "Andric"));
            employees.Add(new Employee("Milica", "Komosar"));
            employees.Add(new Employee("Aneta", "Derkovic"));
            employees.Add(new Employee("John", "Smith"));
        }
        public void Activate()
        {
            Console.WriteLine(ListAvailableActions());
            bool exit = false;
            while (!exit)
            {
                Console.Write("Chose your action: ");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine(ListAllEmployees());
                        break;
                    case "5":
                        Console.WriteLine(ListAvailableActions());
                        break;
                    case "Q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, the instruction {0} is not defined", action);
                        break;
                }
            }
        }

        public String ListAvailableActions()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine("The Employee Management System allows you to do the next operations:");
            foreach(var action in availableActions)
            {
                outputString.AppendLine(String.Format("\t{0}. {1}", action.Key, action.Value));
            }

            return outputString.ToString();
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

    }
}
