using System;

namespace Laba1
{

    public class Ebook : Device
    {

        private float screenSize;

        public Ebook(string brand, string model, float price, int year, float screenSize)
        : base(brand, model, price, year)
        {

            this.screenSize = screenSize;

        }

        public float GetScreenSize() { return this.screenSize; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"ScreenSize: {GetScreenSize() + " дюйм"}");
        }

        public void SetScreenSize(float screenSize) { this.screenSize = screenSize; }
    }
}
