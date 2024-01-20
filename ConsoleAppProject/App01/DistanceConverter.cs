using System;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to choose the
    /// units they want to convert from {fromUnit}
    /// and the units they want to convert to {toUnit}
    /// it will then ask them to enter the {fromDistance}
    /// and then calculate the conversion, it will then
    /// output the converted number on screen.
    /// </summary>
    /// <author>
    /// Kaleem version 0.6
    /// </author>

    public class DistanceConverter
    {
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        public void run()
        {
            ConvertDistance();
        }

        private void ConvertDistance()
        {

            OutputHeading();
            FromUnit = SelectUnit("\n Please select the from distance unit: ");
            ToUnit = SelectUnit("\n Please select the to distance unit: ");

            Console.WriteLine($" Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Enter the number of {FromUnit}: ");

            CalculateDistance();

            OutputDistance();
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        public void CalculateDistance()
        {
            if(FromUnit == MILES &&  ToUnit == FEET)
            {
                ToDistance = Math.Round(FromDistance * FEET_IN_MILES,2);
            }
            else if(FromUnit == FEET && ToUnit == MILES) 
            {
                ToDistance = Math.Round(FromDistance / FEET_IN_MILES,2);
            }
            else if(FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = Math.Round(FromDistance / FEET_IN_METRES, 2);
            }
            else if(FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = Math.Round(FromDistance * FEET_IN_METRES,2);
            }
            else if(FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = Math.Round(FromDistance * METRES_IN_MILES,2);
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = Math.Round(FromDistance / METRES_IN_MILES, 2);
            }
            else if (FromUnit == ToUnit)
            {
                ToDistance = FromDistance;
            }

        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit} is {ToDistance} {ToUnit}");
        }


        private void OutputHeading()
        {
            Console.WriteLine(" ");
            Console.WriteLine("   -------------------------");
            Console.WriteLine("      Converting Distance   ");
            Console.WriteLine("        By Kaleem Shah      ");
            Console.WriteLine("   -------------------------");
            Console.WriteLine(" ");
        }
    }
}
