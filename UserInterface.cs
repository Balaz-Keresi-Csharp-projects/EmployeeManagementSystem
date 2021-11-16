using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class UserInterface
    {
        EmployeeManagementSystem employeeManagementSystem;
        Dictionary<string, string> availableActions;
        public UserInterface()
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

        public string AskQuestion(string question, bool newline = false)
        {
            Console.Write(question);
            if (newline)
            {
                Console.WriteLine("");
            }
            return Console.ReadLine();
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
                
                switch (action)
                {
                    case "1":
                        ListAllEmployees();
                        break;
                    case "2":
                        RegisterWorkHours();
                        break;
                    case "3":
                        CalculateWageForAnEmployee();
                        break;
                    case "4":
                        PayAnEmployee();
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

        public void ListAllEmployees()
        {
            Console.WriteLine(employeeManagementSystem.ListAllEmployees());
        }

        public void RegisterWorkHours()
        {
            string selectedEmployee = AskQuestion("Type the name of employee, for which you want to register the work hours: ");
            try
            {
                int hoursWorked = Int32.Parse(AskQuestion(String.Format("How much hours did {0} work? ", selectedEmployee)));
                employeeManagementSystem.RegisterWorkHourForEmployee(selectedEmployee, hoursWorked);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Worker with name: '{0}' does not exist in the database", selectedEmployee);
            }
            catch (FormatException)
            {
                Console.WriteLine("Number of work hours should be an integer parmaeter");
            }
        }

        public void CalculateWageForAnEmployee()
        {
            string selectedEmployee  = AskQuestion("The name of the Employee, whom you want to calculate the wage: ");
            int wage = employeeManagementSystem.CalculateWageForEmployee(selectedEmployee);
            Console.WriteLine("The expected wage of employee {0} will be {1}", selectedEmployee, wage);
        }

        public void PayAnEmployee()
        {
            string selectedEmployee = AskQuestion("The name of the Employee, whom you want to pay the wage: ");
            employeeManagementSystem.PayEmployee(selectedEmployee);
        }
    }
}
