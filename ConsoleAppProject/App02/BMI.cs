using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public double weight, height, bmi;
        public double kilograms;
        public int stones;
        public double pounds;
        public int feet;
        public double inches;
        public double metres;
        public string choice;
        public void run()
        {
            OutputHeading();
            choice = DisplayMenu(" Pick which units you would like to work with: ");
            if (choice == "1")
            {
                GetImperialWeight();
                GetImperialHeight();
                GetImperialBMI();
                Console.Write(Math.Round(bmi,2));
            }
            if (choice == "2")
            {
                GetMetricWeight();
                GetMetricHeight();
                GetMetricBMI();
                Console.Write(Math.Round(bmi, 2));
            }

        }

        private void GetImperialBMI()
        {
            //BMI = (weight in pounds) x 703 / (height in inches)2
            pounds = (stones * 14) + pounds;
            inches = (feet * 12) + inches;
            bmi = (((pounds) * 703)) / ((inches) * (inches));
        }

        private void GetMetricBMI()
        {
            //BMI = (weight in kg) / (height in metres)2
            bmi = (kilograms / (metres * metres));
        }


        private static string DisplayMenu(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(" 1. Imperial Units");
            Console.WriteLine(" 2. Metric Units");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void GetImperialWeight()
        {
            
            Console.Write("Enter weight in stones: ");
            while (!int.TryParse(Console.ReadLine(), out stones) || stones < 0)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number for stones.");
                Console.Write("Enter weight in stones: ");
            }

            Console.WriteLine("Enter weight in pounds: ");
            while (!double.TryParse(Console.ReadLine(), out pounds) || pounds < 0 || pounds >= 14)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number less than 14 for pounds.");
                Console.Write("Enter weight in pounds: ");
            }

            
        }

        private void GetImperialHeight()
        {
            
            Console.Write("Enter height in feet: ");
            while (!int.TryParse(Console.ReadLine(), out feet) || feet < 0)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number for feet.");
                Console.Write("Enter height in feet: ");
            }

            Console.WriteLine("Enter height in inches: ");
            while (!double.TryParse(Console.ReadLine(), out inches) || inches < 0 || inches >= 12)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number less than 12 for inches.");
                Console.Write("Enter height in inches: ");
            }

            
        }

        private void GetMetricWeight()
        {
            
            Console.Write("Enter weight in Kilograms: ");
            while (!double.TryParse(Console.ReadLine(), out kilograms) || kilograms < 1)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write("Enter weight in Kilograms: ");
            }
            //return kilograms;
        }

        private void GetMetricHeight()
        {
           
            Console.Write("Enter Height in Metres: ");
            while (!double.TryParse(Console.ReadLine(), out metres) || metres < 1)
            {
                DisplayErrorMessage("Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write("Enter Height in Metres: ");
            }
            //return metres;

        }

        static void DisplayErrorMessage(string message)
        {
            Console.WriteLine(message);
        }


        private void OutputHeading()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" -------------------------");
            Console.WriteLine("      BMI Calculator      ");
            Console.WriteLine("      By Kaleem Shah      ");
            Console.WriteLine(" -------------------------");
            Console.WriteLine(" ");
        }

    }

}
