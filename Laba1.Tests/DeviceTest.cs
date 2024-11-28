using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Laba1.Tests
{
    [TestClass]
    public class TestDevice
    {
        // Test for constructor with parameters
        [TestMethod]
        public void Device_Constructor_WithParameters_CorrectlyInitializesProperties()
        {
            // Arrange
            string expectedBrand = "BrandX";
            string expectedModel = "ModelY";
            float expectedPrice = 150.0f;
            int expectedYear = 2022;

            // Act
            Device device = new Device(expectedBrand, expectedModel, expectedPrice, expectedYear);

            // Assert
            Assert.AreEqual(expectedBrand, device.GetBrand(), "The brand was not initialized correctly.");
            Assert.AreEqual(expectedModel, device.GetModel(), "The model was not initialized correctly.");
            Assert.AreEqual(expectedPrice, device.GetPrice(), "The price was not initialized correctly.");
            Assert.AreEqual(expectedYear, device.GetYear(), "The year was not initialized correctly.");
        }

        // Test for default constructor
        [TestMethod]
        public void Device_Constructor_Default_SetsDefaultValues()
        {
            // Act
            Device device = new Device();

            // Assert
            Assert.AreEqual("Brand: ", device.GetBrand(), "The default brand is incorrect.");
            Assert.AreEqual("Model; ", device.GetModel(), "The default model is incorrect.");
            Assert.AreEqual(0.0f, device.GetPrice(), "The default price is incorrect.");
            Assert.AreEqual(0, device.GetYear(), "The default year is incorrect.");
        }

        // Test for Get and Set methods
        [TestMethod]
        public void Device_SetGetMethods_WorkCorrectly()
        {
            // Arrange
            Device device = new Device();
            string newBrand = "NewBrand";
            string newModel = "NewModel";
            float newPrice = 199.99f;
            int newYear = 2025;

            // Act
            device.SetBrand(newBrand);
            device.SetModel(newModel);
            device.SetPrice(newPrice);
            device.SetYear(newYear);

            // Assert
            Assert.AreEqual(newBrand, device.GetBrand(), "The brand was not updated correctly.");
            Assert.AreEqual(newModel, device.GetModel(), "The model was not updated correctly.");
            Assert.AreEqual(newPrice, device.GetPrice(), "The price was not updated correctly.");
            Assert.AreEqual(newYear, device.GetYear(), "The year was not updated correctly.");
        }

        // Test for PrintInfo method
        [TestMethod]
        public void Device_PrintInfo_PrintsCorrectInformation()
        {
            // Arrange
            Device device = new Device("BrandX", "ModelY", 150.0f, 2022);

            // Redirect console output to a StringWriter to capture the printed information
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                device.PrintInfo();

                // Assert
                string expectedOutput = "Brand: BrandX\nModel: ModelY\nPrice: 150\nYear: 2022\n";
                string actualOutput = sw.ToString().Replace("\r\n", "\n"); // Normalize line endings

                Assert.AreEqual(expectedOutput, actualOutput, "The printed information does not match the expected output.");
            }
        }
    }
}
