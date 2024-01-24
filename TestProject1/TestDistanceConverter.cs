using ConsoleAppProject.App01;
namespace ConsoleApps.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMilesToFeet2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 10560;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestFeetToMiles1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestFeetToMiles2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 10560;
            converter.CalculateDistance();

            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMilesToMetres1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 1609.34;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01); // Allowing a small tolerance due to potential floating-point precision issues
        }

        [TestMethod]
        public void TestMilesToMetres2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 3218.68;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }

        [TestMethod]
        public void TestMetresToMiles1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 1609.34;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }

        [TestMethod]
        public void TestMetresToMiles2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 3218.69;
            converter.CalculateDistance();

            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }

        [TestMethod]
        public void TestMetresToFeet1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 3.28084;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.00001);
        }

        [TestMethod]
        public void TestMetresToFeet2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 6.56168;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.00001);
        }

        [TestMethod]
        public void TestFeetToMetres1()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 3.28084;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.00001);
        }

        [TestMethod]
        public void TestFeetToMetres2()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 6.56168;
            converter.CalculateDistance();

            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.00001);
        }

    }
}