using System;
using CarGarage.Models;
using CarGarage.Services;

namespace CarGarage.UI;

public class AdminInterface : IUserInterface
{
    private readonly Admin admin;
    private readonly IGarage garage;

    public AdminInterface(Admin admin, IGarage garage)
    {
        this.admin = admin;
        this.garage = garage;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {admin.Username}");
            Console.WriteLine("1. Show all cars");
            Console.WriteLine("2. Add a car");
            Console.WriteLine("3. Update a car");
            Console.WriteLine("4. Remove a car");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAllCars();
                    break;
                case "2":
                    AddCar();
                    break;
                case "3":
                    UpdateCar();
                    break;
                case "4":
                    RemoveCar();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void ShowAllCars()
    {
        var cars = garage.GetAllCars();
        if (cars.Count == 0)
        {
            Console.WriteLine("No cars available.");
        }
        else
        {
            Console.WriteLine("Available cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }

    private void AddCar()
    {
        Console.Write("Enter brand: ");
        var brand = Console.ReadLine();
        Console.Write("Enter model: ");
        var model = Console.ReadLine();
        Console.Write("Enter year: ");
        var year = int.Parse(Console.ReadLine());
        Console.Write("Enter color: ");
        var color = Console.ReadLine();

        var car = new Car(brand, model, year, color);
        garage.AddCar(car);

        Console.WriteLine("Car added successfully. Press any key to return to the menu.");
        Console.ReadKey();
    }

    private void UpdateCar()
    {
        Console.Write("Enter car index to update: ");
        var index = int.Parse(Console.ReadLine());

        Console.Write("Enter new brand: ");
        var brand = Console.ReadLine();
        Console.Write("Enter new model: ");
        var model = Console.ReadLine();
        Console.Write("Enter new year: ");
        var year = int.Parse(Console.ReadLine());
        Console.Write("Enter new color: ");
        var color = Console.ReadLine();

        var car = new Car(brand, model, year, color);
        garage.UpdateCar(index, car);

        Console.WriteLine("Car updated successfully. Press any key to return to the menu.");
        Console.ReadKey();
    }

    private void RemoveCar()
    {
        Console.Write("Enter car index to remove: ");
        var index = int.Parse(Console.ReadLine());
        garage.RemoveCar(index);
        Console.WriteLine("Car removed successfully. Press any key to return to the menu.");
        Console.ReadKey();
    }
}
