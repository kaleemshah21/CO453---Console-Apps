using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum {  get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Kaleem", "John", "Husnain",
                "Sarah", "Emily", "Raj",
                "Carlos", "Amina", "Yuki",
                "Liam"
            };

            ///creates a grade profile of length for all the grades
            ///as the num of grades.A in the enum class
            ///is 5 so +1 is 6 so can get all 6 grades,
            ///it then sets an array of length of the
            ///students.

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        /*Input a mark between 0-100 for
         each student and store it in the 
         Marks array*/
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /*List all the students and displays
         their name and current mark*/
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /*Converts a student mark to a grade 
         from F which is a fail to A which 
         is first class*/
        public Grades ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
        }

        /*Calculates and displays the min,
         max and mean mark for all the 
         students*/
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

    }
}
