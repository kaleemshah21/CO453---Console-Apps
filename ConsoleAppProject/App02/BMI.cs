using ConsoleAppProject.App01;
using System;
using System.Text;

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
        public string BMImessage;

        const double Underweight = 18.5;
        const double Normal = 24.9;
        const double Overweight = 29.9;
        const double ObeseCI = 34.9;
        const double ObeseCII = 39.9;
        const double ObeseCIII = 40;

        /* Underweight< 18.50
         Normal	18.5 - 24.9
         Overweight	25.0 - 29.9
         Obese Class I	30.0 - 34.9
         Obese Class II	35.0 - 39.9
         Obese Class III	>= 40.0*/

        public void run()
        {
            OutputHeading();
            choice = DisplayMenu(" Pick which units you would like to work with: ");
            if (choice == "1")
            {
                GetImperialWeight();
                GetImperialHeight();
                GetImperialBMI();
                BMImessage = GetBMIMessage();
                Console.WriteLine(BMImessage);
                //Console.Write(Math.Round(bmi,2));
            }
            if (choice == "2")
            {
                GetMetricWeight();
                GetMetricHeight();
                GetMetricBMI();
                BMImessage = GetBMIMessage();
                Console.WriteLine(BMImessage);
                //Console.Write(Math.Round(bmi, 2));
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

        public string GetBMIMessage()
        {
            StringBuilder message = new StringBuilder();
            if (bmi < Underweight)
            {
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are underweight");
            }
            else if (bmi < Normal)
            {
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are normal");
            }
            else if(bmi < Overweight){
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are overweight");
            }
            else if (bmi < ObeseCI)
            {
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are Obese Class 1");
            }
            else if (bmi < ObeseCII)
            {
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are Obese Class 2");
            }
            else
            {
                message.Append($" Your BMI is {bmi:0.00}," +
                    $"You are Obese Class 3");
            }
            return message.ToString();
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
