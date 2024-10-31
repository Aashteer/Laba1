using System;
using System.Collections.Generic;

namespace Laba1
{

    class Program
    {

        static void Main()
        {

            List<Device> devices = new List<Device>();
            int mainChoice, deviceChoice, year, batteryCapacity;
            float price, screenSize;
            string brand, model;

            while (true)
            {
                Console.WriteLine("1 - Добавить новое устройство");
                Console.WriteLine("2 - Вывести список устройств");
                Console.WriteLine("3 - Завершить работу программы");
                Console.WriteLine("Выберите действие: ");
                mainChoice = Convert.ToInt32(Console.ReadLine());

                if (mainChoice == 3)
                {
                    break; // Выход из программы
                }

                Device newDevice = null;

                if (mainChoice == 1)
                {
                    Console.WriteLine("Выберите тип объекта для создания (1 - Device, 2 - Smartphone, 3 - Электронная книга): ");
                    deviceChoice = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите бренд: ");
                    brand = Console.ReadLine();
                    Console.WriteLine("Введите модель: ");
                    model = Console.ReadLine();
                    Console.WriteLine("Введите цену: ");
                    price = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введите год: ");
                    year = Convert.ToInt32(Console.ReadLine());

                    switch (deviceChoice)
                    {
                        case 1:
                            newDevice = new Device(brand, model, price, year);
                            break;
                        case 2:
                            Console.WriteLine("Введите ёмкость батареи: ");
                            batteryCapacity = int.Parse(Console.ReadLine());
                            newDevice = new Smartphone(brand, model, price, year, batteryCapacity);
                            break;
                        case 3:
                            Console.WriteLine("Введите размер экрана: ");
                            screenSize = Convert.ToInt32(Console.ReadLine());
                            newDevice = new Ebook(brand, model, price, year, screenSize);
                            break;
                    }

                    devices.Add(newDevice);
                }
                else if (mainChoice == 2)
                {
                    Console.WriteLine("Список устройств: ");
                    foreach (Device device in devices)
                    {
                        device.PrintInfo();
                    }
                }
            }

            devices.Clear();
        }
    }
}

