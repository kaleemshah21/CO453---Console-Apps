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
        private readonly StudentGrades
                studentGrades = new StudentGrades();

        [TestMethod]
        public void Convert0ToGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = studentGrades.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }


        

    }
}