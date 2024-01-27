using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /*changes length of box depending on length of title*/
        public static void OutputHeading(string title)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" =================================================");

            int titleLength = title.Length;
            int padding = (50 - titleLength) / 2; // Assuming a total line length of 50 characters

            Console.WriteLine($"{new string(' ', padding)}{title}{new string(' ', padding)}");
            Console.WriteLine("                 By Kaleem Shah                   ");
            Console.WriteLine(" =================================================");
            Console.WriteLine(" ");
        }

        public static int SelectChoice(string[] choices, string prompt)
        {
            int choiceNo = 0;
            int menuChoice;

            //displays all the choices in list
            foreach(string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"  {choiceNo}. {choice}");
            }
            Console.Write("\n \n" + prompt);

            //takes the users input as a choice, error checks it and returns it
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1  || menuChoice > choiceNo)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid choice.");
                Console.Write(prompt);
            }
            return menuChoice;
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string DisplayMessage(string message)
        {
            Console.Write(message);
            return (Console.ReadLine());
        }


    }
}
