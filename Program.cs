using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            EMSApplication application = new EMSApplication();
            application.PresentWelcomeScreen();
            application.CallApplicationMenu();
        }
    }
}
