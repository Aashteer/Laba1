using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Laba1.Tests
{
    [TestClass]
    public class TestSmartphone
    {
        
        [TestMethod]
        public void Smartphone_Constructor_WithParameters_CorrectlyInitializesProperties()
        {
            
            string expectedBrand = "BrandX";
            string expectedModel = "ModelY";
            float expectedPrice = 150.0f;
            int expectedYear = 2022;
            int expectedBatteryCapacity = 4000;

           
            Smartphone smartphone = new Smartphone(expectedBrand, expectedModel, expectedPrice, expectedYear, expectedBatteryCapacity);

           
            Assert.AreEqual(expectedBrand, smartphone.GetBrand(), "The brand was not initialized correctly.");
            Assert.AreEqual(expectedModel, smartphone.GetModel(), "The model was not initialized correctly.");
            Assert.AreEqual(expectedPrice, smartphone.GetPrice(), "The price was not initialized correctly.");
            Assert.AreEqual(expectedYear, smartphone.GetYear(), "The year was not initialized correctly.");
            Assert.AreEqual(expectedBatteryCapacity, smartphone.GetBatteryCapacity(), "The battery capacity was not initialized correctly.");
        }

       
        [TestMethod]
        public void Smartphone_SetGetBatteryCapacity_WorkCorrectly()
        {
           
            Smartphone smartphone = new Smartphone("BrandX", "ModelY", 150.0f, 2022, 4000);
            int newBatteryCapacity = 5000;

            
            smartphone.SetBatteryCapacity(newBatteryCapacity);

           
            Assert.AreEqual(newBatteryCapacity, smartphone.GetBatteryCapacity(), "The battery capacity was not updated correctly.");
        }

      
        [TestMethod]
        public void Smartphone_PrintInfo_PrintsCorrectInformation()
        {
            
            Smartphone smartphone = new Smartphone("BrandX", "ModelY", 150.0f, 2022, 4000);

            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                
                smartphone.PrintInfo();

                
                string expectedOutput = "Brand: BrandX\nModel: ModelY\nPrice: 150\nYear: 2022\nBatteryCapacity: 4000 mAh\n";
                string actualOutput = sw.ToString().Replace("\r\n", "\n");

                Assert.AreEqual(expectedOutput, actualOutput, "The printed information does not match the expected output.");
            }
        }
    }
}

