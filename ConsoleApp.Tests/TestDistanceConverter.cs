using ConsoleAppProject.App01;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.ConvertDistance();

            double expectedDistance = 5280;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}