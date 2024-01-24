using ConsoleAppProject.App02;
using System;
namespace ConsoleApps.Test
{
    [TestClass]
    public class TestBmi
    {
        [TestMethod]
        public void TestBMIMetric1()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.625;
            bmi.Kilograms = 45.5;
            bmi.GetMetricBMI();
            double expectedIndex = 17.23;
            Assert.AreEqual(expectedIndex, bmi.Bmi);

            
        }

        [TestMethod]
        public void TestBMIMetric2()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.625;
            bmi.Kilograms = 47.1;
            bmi.GetMetricBMI();
            double expectedIndex = 17.84;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric3()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.75;
            bmi.Kilograms = 60.0;
            bmi.GetMetricBMI();
            double expectedIndex = 19.59;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric4()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.80;
            bmi.Kilograms = 70.0;
            bmi.GetMetricBMI();
            double expectedIndex = 21.60;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric5()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.65;
            bmi.Kilograms = 55.0;
            bmi.GetMetricBMI();
            double expectedIndex = 20.20;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric6()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.70;
            bmi.Kilograms = 80.0;
            bmi.GetMetricBMI();
            double expectedIndex = 27.68;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric7()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.55;
            bmi.Kilograms = 50.0;
            bmi.GetMetricBMI();
            double expectedIndex = 20.81;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric8()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.90;
            bmi.Kilograms = 85.0;
            bmi.GetMetricBMI();
            double expectedIndex = 23.55;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric9()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.60;
            bmi.Kilograms = 65.0;
            bmi.GetMetricBMI();
            double expectedIndex = 25.39;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric10()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.85;
            bmi.Kilograms = 75.0;
            bmi.GetMetricBMI();
            double expectedIndex = 21.91;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric11()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.68;
            bmi.Kilograms = 58.0;
            bmi.GetMetricBMI();
            double expectedIndex = 20.55;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIMetric12()
        {
            BMI bmi = new BMI();
            bmi.Metres = 1.95;
            bmi.Kilograms = 90.0;
            bmi.GetMetricBMI();
            double expectedIndex = 23.67;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        // Imperial Tests
        [TestMethod]
        public void TestBMIImperial1()
        {
            BMI bmi = new BMI();
            bmi.Stones = 7;
            bmi.Pounds = 10;
            bmi.Feet = 5;
            bmi.Inches = 8;
            bmi.GetImperialBMI();
            double expectedIndex = 16.42;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial2()
        {
            BMI bmi = new BMI();
            bmi.Stones = 8;
            bmi.Pounds = 0;
            bmi.Feet = 6;
            bmi.Inches = 0;
            bmi.GetImperialBMI();
            double expectedIndex = 15.19;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial3()
        {
            BMI bmi = new BMI();
            bmi.Stones = 10;
            bmi.Pounds = 5;
            bmi.Feet = 5;
            bmi.Inches = 10;
            bmi.GetImperialBMI();
            double expectedIndex = 20.80;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial4()
        {
            BMI bmi = new BMI();
            bmi.Stones = 12;
            bmi.Pounds = 8;
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.GetImperialBMI();
            double expectedIndex = 22.59;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial5()
        {
            BMI bmi = new BMI();
            bmi.Stones = 14;
            bmi.Pounds = 0;
            bmi.Feet = 5;
            bmi.Inches = 5;
            bmi.GetImperialBMI();
            double expectedIndex = 32.61;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial6()
        {
            BMI bmi = new BMI();
            bmi.Stones = 9;
            bmi.Pounds = 12;
            bmi.Feet = 5;
            bmi.Inches = 11;
            bmi.GetImperialBMI();
            double expectedIndex = 19.24;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial7()
        {
            BMI bmi = new BMI();
            bmi.Stones = 11;
            bmi.Pounds = 5;
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.GetImperialBMI();
            double expectedIndex = 19.87;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial8()
        {
            BMI bmi = new BMI();
            bmi.Stones = 13;
            bmi.Pounds = 9;
            bmi.Feet = 5;
            bmi.Inches = 9;
            bmi.GetImperialBMI();
            double expectedIndex = 28.20;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial9()
        {
            BMI bmi = new BMI();
            bmi.Stones = 8;
            bmi.Pounds = 14;
            bmi.Feet = 5;
            bmi.Inches = 6;
            bmi.GetImperialBMI();
            double expectedIndex = 20.33;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial10()
        {
            BMI bmi = new BMI();
            bmi.Stones = 15;
            bmi.Pounds = 3;
            bmi.Feet = 6;
            bmi.Inches = 0;
            bmi.GetImperialBMI();
            double expectedIndex = 28.88;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial11()
        {
            BMI bmi = new BMI();
            bmi.Stones = 10;
            bmi.Pounds = 0;
            bmi.Feet = 5;
            bmi.Inches = 3;
            bmi.GetImperialBMI();
            double expectedIndex = 24.80;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

        [TestMethod]
        public void TestBMIImperial12()
        {
            BMI bmi = new BMI();
            bmi.Stones = 16;
            bmi.Pounds = 6;
            bmi.Feet = 6;
            bmi.Inches = 6;
            bmi.GetImperialBMI();
            double expectedIndex = 26.58;
            Assert.AreEqual(expectedIndex, bmi.Bmi);
        }

    }
}