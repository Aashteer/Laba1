using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Laba1.Tests
{
    [TestClass]
    public class TestSmartphone
    {
        // Test for constructor with parameters
        [TestMethod]
        public void Smartphone_Constructor_WithParameters_CorrectlyInitializesProperties()
        {
            // Arrange
            string expectedBrand = "BrandX";
            string expectedModel = "ModelY";
            float expectedPrice = 150.0f;
            int expectedYear = 2022;
            int expectedBatteryCapacity = 4000;

            // Act
            Smartphone smartphone = new Smartphone(expectedBrand, expectedModel, expectedPrice, expectedYear, expectedBatteryCapacity);

            // Assert
            Assert.AreEqual(expectedBrand, smartphone.GetBrand(), "The brand was not initialized correctly.");
            Assert.AreEqual(expectedModel, smartphone.GetModel(), "The model was not initialized correctly.");
            Assert.AreEqual(expectedPrice, smartphone.GetPrice(), "The price was not initialized correctly.");
            Assert.AreEqual(expectedYear, smartphone.GetYear(), "The year was not initialized correctly.");
            Assert.AreEqual(expectedBatteryCapacity, smartphone.GetBatteryCapacity(), "The battery capacity was not initialized correctly.");
        }

        // Test for Get and Set methods of Battery Capacity
        [TestMethod]
        public void Smartphone_SetGetBatteryCapacity_WorkCorrectly()
        {
            // Arrange
            Smartphone smartphone = new Smartphone("BrandX", "ModelY", 150.0f, 2022, 4000);
            int newBatteryCapacity = 5000;

            // Act
            smartphone.SetBatteryCapacity(newBatteryCapacity);

            // Assert
            Assert.AreEqual(newBatteryCapacity, smartphone.GetBatteryCapacity(), "The battery capacity was not updated correctly.");
        }

        // Test for PrintInfo method (overridden from Device)
        [TestMethod]
        public void Smartphone_PrintInfo_PrintsCorrectInformation()
        {
            // Arrange
            Smartphone smartphone = new Smartphone("BrandX", "ModelY", 150.0f, 2022, 4000);

            // Redirect console output to a StringWriter to capture the printed information
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                smartphone.PrintInfo();

                // Assert
                string expectedOutput = "Brand: BrandX\nModel: ModelY\nPrice: 150\nYear: 2022\nBatteryCapacity: 4000 mAh\n";
                string actualOutput = sw.ToString().Replace("\r\n", "\n"); // Normalize line endings

                Assert.AreEqual(expectedOutput, actualOutput, "The printed information does not match the expected output.");
            }
        }
    }
}

