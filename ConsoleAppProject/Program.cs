using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Kaleem Shah 24/11/2023
    /// </summary>
    public static class Program
    {
        public static BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            int choice;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2022-2023");
            choice = DisplayMenu(" Pick which app you would like to use: ");

            /*if statements to different menu options*/
            if (choice == 1) 
            {
                DistanceConverter converter = new DistanceConverter();
                converter.run();
            }
            else if (choice == 2)
            {
                BMI bmiCalculator = new BMI();
                bmiCalculator.run();
            }
            else if (choice == 3)
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }

        }

        /*displays the menu and asks for user input,
         it then validates the input and returns the
        choice*/
        private static int DisplayMenu(string prompt)
        {
            Console.WriteLine(" ┌─────────────────────────────────┐ ");
            Console.WriteLine(" │ Applications                    │ ");
            Console.WriteLine(" │                                 │ ");
            Console.WriteLine(" │ 1. App01                        │ ");
            Console.WriteLine(" │ 2. App02                        │ ");
            Console.WriteLine(" │ 2. App03 (not yet implemented)  │ ");
            Console.WriteLine(" │ 2. App04 (not yet implemented)  │ ");
            Console.WriteLine(" │ 2. App05 (not yet implemented)  │ ");
            Console.WriteLine(" └─────────────────────────────────┘ ");
            Console.WriteLine("                                     ");

            int menuChoice;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice > 3 || menuChoice < 1)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid choice.");
                Console.Write(prompt);
            }
            return menuChoice;
        }

        /*method to then Display a message that is
         passed through*/
        static void DisplayErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        /*outputs the heading of the program*/
        
    }
}
