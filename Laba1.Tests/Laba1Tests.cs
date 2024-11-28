using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Globalization;

namespace Laba1.Tests
{
    [TestClass]
    public class TestEbook
    {
        
        [TestMethod]
        public void Ebook_Constructor_GetScreenSize_ReturnsCorrectValue()
        {
           
            string expectedBrand = "BrandX";
            string expectedModel = "ModelY";
            float expectedPrice = 150.0f;
            int expectedYear = 2022;
            float expectedScreenSize = 6.5f;

           
            Ebook ebook = new Ebook(expectedBrand, expectedModel, expectedPrice, expectedYear, expectedScreenSize);
            float actualScreenSize = ebook.GetScreenSize();

            
            Assert.AreEqual(expectedScreenSize, actualScreenSize, "The screen size does not match the expected value.");
        }

       
        [TestMethod]
        public void Ebook_SetScreenSize_ChangesValueCorrectly()
        {
           
            Ebook ebook = new Ebook("BrandX", "ModelY", 150.0f, 2022, 6.5f);
            float newScreenSize = 7.0f;

            
            ebook.SetScreenSize(newScreenSize);
            float actualScreenSize = ebook.GetScreenSize();

            
            Assert.AreEqual(newScreenSize, actualScreenSize, "The screen size was not updated correctly.");
        }

        
        [TestMethod]
        public void Ebook_PrintInfo_PrintsCorrectInfo()
        {
            
            Ebook ebook = new Ebook("BrandX", "ModelY", 150.0f, 2022, 6.5f);

            
            var originalCulture = System.Threading.Thread.CurrentThread.CurrentCulture;

            try
            {
               
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

               
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                   
                    ebook.PrintInfo();

                    
                    string expectedOutput = "Brand: BrandX\nModel: ModelY\nPrice: 150\nYear: 2022\nScreenSize: 6.5 дюйм\n";
                    string actualOutput = sw.ToString().Replace("\r\n", "\n"); 

                    Assert.AreEqual(expectedOutput, actualOutput, "The printed information does not match the expected output.");
                }
            }
            finally
            {
                
                System.Threading.Thread.CurrentThread.CurrentCulture = originalCulture;
            }
        }
    }
}
