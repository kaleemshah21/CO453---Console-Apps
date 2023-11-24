using System;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Kaleem version 0.3
    /// </author>
    public class DistanceConverter
    {
        //feet to miles, miles to metres
        private double miles;
        private double feet;
        private double metres;

        private string fromUnit;
        private string toUnit;

        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public void run()
        {
            MilesToFeet();
            FeetToMiles();
            MilesToMetres();
        }

        private void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles: ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        private void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            miles = InputDistance("Please enter the number of feet: ");
            
            CalculateMiles();

            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        private void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles: ");
            
            CalculateMetres();

            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        /// 


        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void OutputDistance(Double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($"{fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }


        private void OutputHeading(string prompt)
        {
            Console.WriteLine(" ");
            Console.WriteLine("   -------------------------");
            Console.WriteLine("      Converting Distance   ");
            Console.WriteLine("        By Kaleem Shah      ");
            Console.WriteLine("   -------------------------");
            Console.WriteLine(" ");
            Console.WriteLine(prompt);
            Console.WriteLine(" ");
        }
    }
}
