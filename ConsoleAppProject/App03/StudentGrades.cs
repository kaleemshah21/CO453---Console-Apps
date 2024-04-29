using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using ConsoleAppProject.Helpers;

// TODO: webapp database not working, no idea why, ask andrew for help
namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        
        

    //constants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum {  get; set; }
        public int Maximum { get; set; }

        public int choice { get; set; }

        public Grades Grades
        {
            get => default;
            set
            {
            }
        }



        ///creates a grade profile of length for all the grades
        ///as the num of grades.A in the enum class
        ///is 5 so +1 is 6 so can get all 6 grades,
        ///it then sets an array of length of the
        ///students., also creates an array of students
        public StudentGrades()
        {
            Students = new string[]
            {
                "Kaleem", "John", "Husnain",
                "Sarah", "Emily", "Raj",
                "Carlos", "Amina", "Yuki",
                "Liam"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        /*displays choices and allows user to choose a feature,
         it then calls the corresponding method*/
        public void Run()
        {
            string[] choices = {
                $"Input Marks",
                $"Output Marks",
                $"Output Stats",
                $"Output Grade Profile",
                $"Quit"
            };
            do
            {
                ConsoleHelper.OutputHeading("Student Grades");
                choice = ConsoleHelper.SelectChoice(choices, " Pick an option: ");

                if (choice == 1)
                {
                    InputMarks();
                }
                else if(choice == 2)
                {
                    OutputMarks();
                }
                else if (choice == 3)
                {
                    CalculateStats();
                    OutputStats();
                }
                else if (choice == 4)
                {
                    CalculateGradeProfile();
                    OutputGradeProfile();
                }

            } while (choice != 5);
        }

        /*Input a mark between 0-100 for
         each student and store it in the 
         Marks array*/
        public void InputMarks()
        {
            int currentMark;
            Console.WriteLine(" Please enter the marks for each student:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.Write($" Marks for {Students[i]}: ");
                while (!int.TryParse(Console.ReadLine(), out currentMark) || currentMark < 0 || currentMark > 100)
                {
                    ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid mark between 0 and 100.");
                    Console.Write($" Marks for {Students[i]}: ");
                }
                Marks[i] = currentMark;
            }
            Console.WriteLine(" All marks have been inputted");
        }


        /*List all the students and displays
         their name and current mark*/
        public void OutputMarks()
        {
            Console.WriteLine("\n Student Marks and Grades");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < Students.Length; i++)
            {
               
                string student = Students[i];

                int mark = Marks[i];

                Grades grade = ConvertToGrade(mark);

                Console.WriteLine($" {student} - Mark: {mark}, Grade: {grade}");
            }

            Console.WriteLine();
        }

        /*outputs the stats that have been
         calculated by the CalculateStats
         method*/
        public void OutputStats()
        {
            
            Console.WriteLine($" The lowest mark is {Minimum}");
            Console.WriteLine($" The Highest mark is {Maximum}");
            Console.WriteLine($" The average mark is {Mean}");
        }

        /*Converts a student mark to a grade 
         from F which is a fail to A which 
         is first class*/
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

        /*Calculates and displays the min,
         max and mean mark for all the 
         students*/
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;
            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }

        /*calculates the grade profile*/
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /*outputs the grade profile*/
        private void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($" Grade {grade} {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }

    }
}
