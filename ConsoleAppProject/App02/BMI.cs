﻿using ConsoleAppProject.App01;
using System;
using System.Text;
using System.Xml.Serialization;

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
    /// Kaleem Shah v0.3
    /// </author>
    public class BMI
    {
        /// <summary>
        /// declaring variables, some with getters
        /// and setters so that the Web App can access
        /// the variables.
        /// </summary>
        public double weight, height;
        public double Bmi { get; set; }
        public double Kilograms { get; set; }
        public int Stones { get; set; }
        public double Pounds { get; set; }
        public int Feet { get; set; }
        public double Inches { get; set; }
        public double Metres { get; set; }

        public int choice;
        public string BMImessage;


        /// <summary>
        /// declares constants for the upper bounds
        /// of the BMI classes, to be used later
        /// to display the users BMI class.
        /// </summary>
        const double Underweight = 18.5;
        const double Normal = 24.9;
        const double Overweight = 29.9;
        const double ObeseCI = 34.9;
        const double ObeseCII = 39.9;
       


        public void run()
        {
            /*main method of program, calls OutputHeading()
             to output the program header, it then calls the
            DisplayMenu method which displays the menu and 
            asks the user to enter a choice, the choice is then
            validated and returned.
            if the choice is 1, then it calls methods to calculate
            the bmi, which is then outputted as well as the BAME 
            message, the same for choice 2 except the methods are
            different.*/

            /*string[] choices = {
                $"Imperial Units",
                $"Metric Units"   
            };*/
            string[] choices =
            {
                Metrics.Imperial.ToString(),
                Metrics.Metric.ToString()
            };

            ConsoleHelper.OutputHeading("BMI Calculator");
            int choice = ConsoleHelper.SelectChoice(choices, " Pick which units you would like to work with: ");
            

            if (choice == 1)
            {
                ProcessInput(GetImperialWeight, GetImperialHeight, GetImperialBMI);  
            }
            if (choice == 2)
            {
                ProcessInput(GetMetricWeight, GetMetricHeight, GetMetricBMI);
            }

            Console.WriteLine(GetBMIMessage());
            Console.WriteLine(DisplayBAMEMessage());

        }

        /*method to call different methods based on the method 
          that is passed through, changed to reduce code
          duplication.*/
        void ProcessInput(Action getWeight, Action getHeight, Action getBMI)
        {
            getWeight();
            getHeight();
            getBMI();
        }

        /*calculates bmi with imperial units*/
        public void GetImperialBMI()
        {
            //BMI = (weight in pounds) x 703 / (height in inches)2
            Pounds = (Stones * 14) + Pounds;
            Inches = (Feet * 12) + Inches;
            Bmi = Math.Round((((Pounds) * 703)) / ((Inches) * (Inches)),2);
        }

        /*calculates bmi with metric units*/
        public void GetMetricBMI()
        {
            //BMI = (weight in kg) / (height in metres)2
            Bmi = Math.Round((Kilograms / (Metres * Metres)),2);
        }

        //returns the BAME message
        public string DisplayBAMEMessage()
        {
            string bameMessage = ("\n if you are Black, Asian or other minority ethnic groups, " +
                " you have a higher risk, Adults at 23.0 or more are at increased risk," +
                " Adults at 27.5 or more are at high risk.");
            return bameMessage;
        }

        /*prompts user to enter weight in stone and pounds,
         it then validates the input with a while loop and 
        sets the variables to the input if valid.*/
        private void GetImperialWeight()
        {
            int StoneInput;
            double PoundsInput;
            
            Console.Write(" Enter weight in stones: ");
            while (!int.TryParse(Console.ReadLine(), out StoneInput) || StoneInput < 4 || StoneInput > 100)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number for stones.");
                Console.Write(" Enter weight in stones: ");
            }
            Stones = StoneInput;

            Console.Write(" Enter weight in pounds: ");
            while (!double.TryParse(Console.ReadLine(), out PoundsInput) || PoundsInput < 0 || PoundsInput >= 14)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number less than 14 for pounds.");
                Console.Write(" Enter weight in pounds: ");
            }
            Pounds = PoundsInput;
  
        }

        /*creates a StringBuilder message and appends the
         relevant prompt to the message depending on the
        bmi index that has been calculated, it is then
        returns the message as a string.*/
        public string GetBMIMessage()
        {
            StringBuilder message = new StringBuilder();
            string[] categories = { "Underweight", "Normal", "Overweight", "Obese Class 1", "Obese Class 2", "Obese Class 3" };
            double[] thresholds = { Underweight, Normal, Overweight, ObeseCI, ObeseCII, double.MaxValue };

            int index = Array.FindIndex(thresholds, t => Bmi < t);

            message.Append($" Your BMI is {Bmi:0.00}, You are {categories[index]}");

            return message.ToString();


            
        }

        /*prompts the user to enter height in feet and inches
         it then validates the inputs and then sets the
        corresponding variables to the user input once 
        validated*/
        private void GetImperialHeight()
        {
            double InchesInput;
            int FeetInput;

            Console.Write(" Enter height in feet: ");
            while (!int.TryParse(Console.ReadLine(), out FeetInput) || FeetInput < 2 || FeetInput > 9)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number for feet.");
                Console.Write(" Enter height in feet: ");
            }
            Feet = FeetInput;

            Console.Write(" Enter height in inches: ");
            while (!double.TryParse(Console.ReadLine(), out InchesInput) || InchesInput < 0 || InchesInput >= 12)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number less than 12 for inches.");
                Console.Write(" Enter height in inches: ");
                
            }
            Inches = InchesInput;

        }

        /*prompts the user to enter weight in kilograms,
         it then validates the input and then sets the
        corresponding variables to the user input once 
        validated*/
        private void GetMetricWeight()
        {
            double KilogramsInput;
            
            Console.Write(" Enter weight in Kilograms: ");
            while (!double.TryParse(Console.ReadLine(), out KilogramsInput) || KilogramsInput < 10 || KilogramsInput > 1000)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write(" Enter weight in Kilograms: ");
            }
            Kilograms = KilogramsInput;
        }

        /*prompts the user to enter metric height in metres,
         it then validates the input and then sets the
        corresponding variables to the user input once 
        validated*/
        private void GetMetricHeight()
        {
            double MetresInput;
           
            Console.Write(" Enter Height in Metres: ");
            while (!double.TryParse(Console.ReadLine(), out MetresInput) || MetresInput < 1 || MetresInput > 10)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid positive number for Kilograms.");
                Console.Write(" Enter Height in Metres: ");
            }
            Metres = MetresInput;

        }

        public Metrics Metrics
        {
            get => default;
            set
            {
            }
        }
    }

}
