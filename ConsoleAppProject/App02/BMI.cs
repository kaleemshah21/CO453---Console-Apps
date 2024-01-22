using ConsoleAppProject.App01;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// this app asks the user to choose between imperial
    /// or metric units, it then asks the user to enter 
    /// their weight and height, which then calculates
    /// their bmi index, this is then used to find their
    /// bmi message of underweight, normal, overweight etc
    /// it then outputs the BAME message.
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public double weight, height;
        public double Bmi { get; set; }
        public double Kilograms { get; set; }
        public int Stones { get; set; }
        public double Pounds { get; set; }
        public int Feet { get; set; }
        public double Inches { get; set; }
        public double Metres { get; set; }

        public string choice;
        public string BMImessage;

        const double Underweight = 18.5;
        const double Normal = 24.9;
        const double Overweight = 29.9;
        const double ObeseCI = 34.9;
        const double ObeseCII = 39.9;
       


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
                string bameMessage = DisplayBAMEMessage();
                Console.WriteLine(bameMessage);
                //Console.Write(Math.Round(bmi,2));
            }
            if (choice == "2")
            {
                GetMetricWeight();
                GetMetricHeight();
                GetMetricBMI();
                BMImessage = GetBMIMessage();
                Console.WriteLine(BMImessage);
                string bameMessage = DisplayBAMEMessage();
                Console.WriteLine(bameMessage);
                //Console.Write(Math.Round(bmi, 2));
            }

        }

        public void GetImperialBMI()
        {
            //BMI = (weight in pounds) x 703 / (height in inches)2
            Pounds = (Stones * 14) + Pounds;
            Inches = (Feet * 12) + Inches;
            Bmi = (((Pounds) * 703)) / ((Inches) * (Inches));
        }

        public void GetMetricBMI()
        {
            //BMI = (weight in kg) / (height in metres)2
            Bmi = (Kilograms / (Metres * Metres));
        }

        public string DisplayBAMEMessage()
        {
            string bameMessage = ("\n if you are Black, Asian or other minority ethnic groups, " +
                " you have a higher risk, Adults at 23.0 or more are at increased risk," +
                " Adults at 27.5 or more are at high risk.");
            return bameMessage;
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
            int StoneInput;
            double PoundsInput;
            
            Console.Write(" Enter weight in stones: ");
            while (!int.TryParse(Console.ReadLine(), out StoneInput) || StoneInput < 0)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number for stones.");
                Console.Write(" Enter weight in stones: ");
            }
            Stones = StoneInput;

            Console.Write(" Enter weight in pounds: ");
            while (!double.TryParse(Console.ReadLine(), out PoundsInput) || PoundsInput < 0 || PoundsInput >= 14)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number less than 14 for pounds.");
                Console.Write(" Enter weight in pounds: ");
            }
            Pounds = PoundsInput;

            
        }

        public string GetBMIMessage()
        {
            StringBuilder message = new StringBuilder();
            if (Bmi < Underweight)
            {
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are underweight");
            }
            else if (Bmi < Normal)
            {
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are normal");
            }
            else if(Bmi < Overweight){
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are overweight");
            }
            else if (Bmi < ObeseCI)
            {
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are Obese Class 1");
            }
            else if (Bmi < ObeseCII)
            {
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are Obese Class 2");
            }
            else
            {
                message.Append($" Your BMI is {Bmi:0.00}," +
                    $"You are Obese Class 3");
            }
            return message.ToString();
        }
        private void GetImperialHeight()
        {
            double InchesInput;
            int FeetInput;

            Console.Write(" Enter height in feet: ");
            while (!int.TryParse(Console.ReadLine(), out FeetInput) || FeetInput < 0)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number for feet.");
                Console.Write(" Enter height in feet: ");
            }
            Feet = FeetInput;

            Console.Write(" Enter height in inches: ");
            while (!double.TryParse(Console.ReadLine(), out InchesInput) || InchesInput < 0 || InchesInput >= 12)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number less than 12 for inches.");
                Console.Write(" Enter height in inches: ");
                
            }
            Inches = InchesInput;

        }

        private void GetMetricWeight()
        {
            double KilogramsInput;
            
            Console.Write(" Enter weight in Kilograms: ");
            while (!double.TryParse(Console.ReadLine(), out KilogramsInput) || KilogramsInput < 1)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write(" Enter weight in Kilograms: ");
            }
            Kilograms = KilogramsInput;
        }

        private void GetMetricHeight()
        {
            double MetresInput;
           
            Console.Write(" Enter Height in Metres: ");
            while (!double.TryParse(Console.ReadLine(), out MetresInput) || MetresInput < 1)
            {
                DisplayErrorMessage(" Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write(" Enter Height in Metres: ");
            }
            Metres = MetresInput;

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
