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
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}: {cars[i]}");
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
        Console.Write("Enter price: ");
        var price = decimal.Parse(Console.ReadLine());

        var car = new Car(brand, model, year, color, price);
        garage.AddCar(car);

        Console.WriteLine("Car added successfully. Press any key to return to the menu.");
        Console.ReadKey();
    }

    private void UpdateCar()
    {
        ShowAllCarsWithIndexes();

        Console.Write("Enter the index of the car to update: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < garage.GetAllCars().Count)
        {
            var car = garage.GetAllCars()[index];
            Console.Write($"Enter new brand ({car.Brand}): ");
            var brand = Console.ReadLine();
            Console.Write($"Enter new model ({car.Model}): ");
            var model = Console.ReadLine();
            Console.Write($"Enter new year ({car.Year}): ");
            var year = int.Parse(Console.ReadLine());
            Console.Write($"Enter new color ({car.Color}): ");
            var color = Console.ReadLine();
            Console.Write($"Enter new price ({car.Price}): ");
            var price = decimal.Parse(Console.ReadLine());

            car.Brand = brand;
            car.Model = model;
            car.Year = year;
            car.Color = color;
            car.Price = price;

            Console.WriteLine("Car updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
        PauseForUser();
    }

    private void RemoveCar()
    {
        ShowAllCarsWithIndexes();

        Console.Write("Enter the index of the car to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < garage.GetAllCars().Count)
        {
            garage.RemoveCar(index);
            Console.WriteLine("Car removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
        PauseForUser();
    }

    private void ShowAllCarsWithIndexes()
    {
        var cars = garage.GetAllCars();
        if (cars.Count == 0)
        {
            Console.WriteLine("No cars available.");
        }
        else
        {
            Console.WriteLine("Available cars:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}: {cars[i]}");
            }
        }
    }

    private void PauseForUser()
    {
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }
}
