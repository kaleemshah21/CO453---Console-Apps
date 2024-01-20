﻿using System;
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
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

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
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        public void run()
        {
            ConvertDistance();
        }

        private void ConvertDistance()
        {

            OutputHeading();
            //FromUnit = SelectUnit("\n Please select the from distance unit: ");
            //ToUnit = SelectUnit("\n Please select the to distance unit: ");

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

            //changed from FEET, to DistanceUnits.Feet from enum class
            Console.WriteLine();
            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Metres}");
            Console.WriteLine($" 3. {DistanceUnits.Miles}");
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
        //changed from e.g. FEET, to DistanceUnits.Feet from enum class
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = Math.Round(FromDistance * FEET_IN_MILES, 2);
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = Math.Round(FromDistance * METRES_IN_MILES, 2);
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = Math.Round(FromDistance / FEET_IN_MILES, 2);
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = Math.Round(FromDistance / FEET_IN_METRES, 2);
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = Math.Round(FromDistance / METRES_IN_MILES, 2);
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = Math.Round(FromDistance * FEET_IN_METRES, 2);
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
