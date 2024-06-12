using System;
using CarGarage.Services;

namespace CarGarage.UI;

public class ViewerInterface : IUserInterface
{
    private readonly IGarage garage;

    public ViewerInterface(IGarage garage)
    {
        this.garage = garage;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Show all cars");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAllCars();
                    break;
                case "2":
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
}
