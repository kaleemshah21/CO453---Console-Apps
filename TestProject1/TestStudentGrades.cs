using ConsoleAppProject.App03;
namespace ConsoleApps.Test
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    [TestClass]
    public class TestStudentGrades
    {
        private int[] statsMarks;
        private readonly StudentGrades converter = new StudentGrades();
        public TestStudentGrades()
        {
            statsMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };
        }
        

        [TestMethod]
        public void Convert0ToGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert39ToGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert40ToGradeD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = converter.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert49ToGradeD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = converter.ConvertToGrade(49);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert50ToGradeC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = converter.ConvertToGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert59ToGradeC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = converter.ConvertToGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert60ToGradeB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = converter.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert69ToGradeB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = converter.ConvertToGrade(69);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert70ToGradeA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = converter.ConvertToGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert100ToGradeA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = converter.ConvertToGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = statsMarks;
            double expectedMean = 55.0;

            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            converter.Marks = statsMarks;
            double expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            converter.Marks = statsMarks;
            double expectedMin = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = statsMarks;

            converter.CalculateGradeProfile();

            converter.CalculateStats();
            bool expectedProfile = ((converter.GradeProfile[0] == 3) &&
                         (converter.GradeProfile[1] == 1) &&
                         (converter.GradeProfile[2] == 1) &&
                         (converter.GradeProfile[3] == 1) &&
                         (converter.GradeProfile[4] == 4));


            Assert.IsTrue(expectedProfile);

        }






    }
}