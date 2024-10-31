
using System;

namespace Laba1
{

    public class Device
    {
        protected string brand;
        protected string model;
        protected float price;
        protected int year;

        public Device(string brand, string model, float price, int year)
        {


            this.brand = brand;
            this.model = model;
            this.price = price;
            this.year = year;
        }

        public Device()
        {

            this.brand = "Brand: ";
            this.model = "Model; ";
            this.price = 0.0f;
            this.year = 0;
        }

        public string GetBrand() { return this.brand; }
        public string GetModel() { return this.model; }
        public float GetPrice() { return this.price; }
        public int GetYear() { return this.year; }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Brand: {GetBrand()}");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: {GetPrice()}");
            Console.WriteLine($"Year: {GetYear()}");

        }

        public void SetBrand(string brand) { this.brand = brand; }
        public void SetModel(string model) { this.model = model; }
        public void SetPrice(float price) { this.price = price; }
        public void SetYear(int year) { this.year = year; }
    }
}