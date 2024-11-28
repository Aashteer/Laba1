using System;

namespace Laba1
{

    public class Smartphone : Device
    {

        private int batteryCapacity;

        public Smartphone(string brand, string model, float price, int year, int batteryCapacity)
        : base(brand, model, price, year)
        {


            this.batteryCapacity = batteryCapacity;
        }

        public int GetBatteryCapacity() { return this.batteryCapacity; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"BatteryCapacity: {GetBatteryCapacity() + " mAh"}");
        }

        public void SetBatteryCapacity(int batteryCapacity) { this.batteryCapacity = batteryCapacity; }
    }
}