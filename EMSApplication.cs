using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EMSApplication
    {
        EmployeeManagementSystem employeeManagementSystem;
        Dictionary<string, string> availableActions;
        public EMSApplication()
        {
            employeeManagementSystem = new EmployeeManagementSystem();

            availableActions = new Dictionary<string, string>();
            availableActions.Add("1", "List all of the employees in the system");
            availableActions.Add("2", "Register some hours of work for the employee");
            availableActions.Add("3", "Calculate the wage of an employee");
            availableActions.Add("4", "Pay the wage for the employee");
            availableActions.Add("5", "List all of the available actions");
            availableActions.Add("Q", "Exit");
        }
        
        public void PresentWelcomeScreen()
        {
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("*** The aim of this software is to realise a command line Employee Management System.                              ***");
            Console.WriteLine("*** This project is ment for practicing C# object oriented features and may not sufficient for professional usage. ***");
            Console.WriteLine("*** The idea of this porject comes from the Pluralsight course: Introduction to the C# Type System by Gill Cleeren ***");
            Console.WriteLine("*** Check out the course for yourself:                                                                             ***");
            Console.WriteLine("*** \thttps://app.pluralsight.com/library/courses/introduction-c-sharp-type-sysyem/table-of-contents               ***");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine();
        }

        public void ListAvailableActions()
        {
            Console.WriteLine("The Employee Management System allows you to do the next operations:");
            foreach (var action in availableActions)
            {
                Console.WriteLine(String.Format("\t{0}. {1}", action.Key, action.Value));
            }
        }

        public void CallApplicationMenu()
        {
            ListAvailableActions();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.Write("Chose your action: ");
                string action = Console.ReadLine();
                string selectedEmployee;
                switch (action)
                {
                    case "1":
                        Console.WriteLine(employeeManagementSystem.ListAllEmployees());
                        break;
                    case "2":
                        employeeManagementSystem.RegisterWorkHourForEmployee();
                        break;
                    case "3":
                        Console.Write("Type the name of the Employee, whom you want to calculate the wage: ");
                        selectedEmployee = Console.ReadLine();
                        employeeManagementSystem.CalculateWageForEmployee(selectedEmployee);
                        break;
                    case "4":
                        Console.Write("Type the name of the Employee, whom you want to pay the wage: ");
                        selectedEmployee = Console.ReadLine();
                        employeeManagementSystem.PayEmployee(selectedEmployee);
                        break;
                    case "5":
                        ListAvailableActions();
                        break;
                    case "Q":
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, the instruction {0} is not defined", action);
                        break;
                }
            }
        }
    }
}
