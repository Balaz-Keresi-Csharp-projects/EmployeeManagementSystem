using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("*** The aim of this software is to realise a command line Employee Management System.                              ***");
            Console.WriteLine("*** This project is ment for practicing C# object oriented features and may not sufficient for professional usage. ***");
            Console.WriteLine("*** The idea of this porject comes from the Pluralsight course: Introduction to the C# Type System by Gill Cleeren ***");
            Console.WriteLine("*** Check out the course for yourself:                                                                             ***");
            Console.WriteLine("*** \thttps://app.pluralsight.com/library/courses/introduction-c-sharp-type-sysyem/table-of-contents               ***");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine();

            EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();

            employeeManagementSystem.Activate();
            
        }
    }
}
