using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Globalization;

namespace Laba1.Tests
{
    [TestClass]
    public class TestEbook
    {
        // Test for constructor and GetScreenSize method
        [TestMethod]
        public void Ebook_Constructor_GetScreenSize_ReturnsCorrectValue()
        {
            // Arrange
            string expectedBrand = "BrandX";
            string expectedModel = "ModelY";
            float expectedPrice = 150.0f;
            int expectedYear = 2022;
            float expectedScreenSize = 6.5f;

            // Act
            Ebook ebook = new Ebook(expectedBrand, expectedModel, expectedPrice, expectedYear, expectedScreenSize);
            float actualScreenSize = ebook.GetScreenSize();

            // Assert
            Assert.AreEqual(expectedScreenSize, actualScreenSize, "The screen size does not match the expected value.");
        }

        // Test for SetScreenSize method
        [TestMethod]
        public void Ebook_SetScreenSize_ChangesValueCorrectly()
        {
            // Arrange
            Ebook ebook = new Ebook("BrandX", "ModelY", 150.0f, 2022, 6.5f);
            float newScreenSize = 7.0f;

            // Act
            ebook.SetScreenSize(newScreenSize);
            float actualScreenSize = ebook.GetScreenSize();

            // Assert
            Assert.AreEqual(newScreenSize, actualScreenSize, "The screen size was not updated correctly.");
        }

        // Test for PrintInfo method
        [TestMethod]
        public void Ebook_PrintInfo_PrintsCorrectInfo()
        {
            // Arrange
            Ebook ebook = new Ebook("BrandX", "ModelY", 150.0f, 2022, 6.5f);

            // Сохраняем текущую локализацию
            var originalCulture = System.Threading.Thread.CurrentThread.CurrentCulture;

            try
            {
                // Устанавливаем локализацию с точкой в качестве разделителя
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                // Redirect console output to a StringWriter to capture the printed information
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    ebook.PrintInfo();

                    // Assert
                    string expectedOutput = "Brand: BrandX\nModel: ModelY\nPrice: 150\nYear: 2022\nScreenSize: 6.5 дюйм\n";
                    string actualOutput = sw.ToString().Replace("\r\n", "\n"); // Handle line endings

                    Assert.AreEqual(expectedOutput, actualOutput, "The printed information does not match the expected output.");
                }
            }
            finally
            {
                // Восстанавливаем оригинальную локализацию
                System.Threading.Thread.CurrentThread.CurrentCulture = originalCulture;
            }
        }
    }
}
