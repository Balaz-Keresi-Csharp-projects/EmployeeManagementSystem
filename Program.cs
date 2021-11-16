using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            userInterface.PresentWelcomeScreen();
            userInterface.CallApplicationMenu();
        }
    }
}
