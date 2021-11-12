using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeManagementSystem
    {
        private Dictionary<string, string> availableActions;
        public EmployeeManagementSystem()
        {
            availableActions = new Dictionary<string, string>();
            availableActions.Add("1", "List all of the employees in the system");
            availableActions.Add("2", "Report some hours of work for the employee");
            availableActions.Add("3", "Calculate the wage of an employee");
            availableActions.Add("4", "Pay the wage for the employee");
            availableActions.Add("5", "Relist all of the available functions");
            availableActions.Add("Exit", "Exit");
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
                    case "Exit":
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
                Console.WriteLine("\t{0}. {1}", action.Key, action.Value);
            }

            return outputString.ToString();
        }

    }
}
