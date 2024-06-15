using System;
using CarGarage.Services;
using CarGarage.Models;

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
                Console.WriteLine("2. Book a car");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAllCars();
                        PauseForUser();
                        break;
                    case "2":
                        BookCar();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ShowAllCars(out List<Car> carsList, out Dictionary<int, Car> carIndexMapping, bool displayIndices = false)
        {
            carsList = garage.GetAllCars();
            carIndexMapping = new Dictionary<int, Car>();

            if (carsList.Count == 0)
            {
                Console.WriteLine("No cars available.");
            }
            else
            {
                for (int i = 0; i < carsList.Count; i++)
                {
                    var indexDisplay = displayIndices ? $"{i}: " : string.Empty;
                    Console.WriteLine($"{indexDisplay}{carsList[i]}");
                    carIndexMapping[i] = carsList[i];
                }
            }
        }

        private void BookCar()
        {
            Console.Clear();
            ShowAllCars( out var cars, out var carIndexMapping, displayIndices: true);

            if (cars.Count == 0)
            {
                Console.WriteLine("No cars available to book.");
                PauseForUser();
                return;
            }

            Console.Write("Enter the index of the car to book or type 'abort' to cancel: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "abort") return;

            if (int.TryParse(input, out int index) && carIndexMapping.ContainsKey(index))
            {
                var carToBook = carIndexMapping[index];
                if (carToBook.Booked)
                {
                    Console.WriteLine("This car is already booked. Please choose a different car.");
                }
                else
                {
                    var carIndexInGarage = cars.IndexOf(carToBook);
                    garage.BookCar(carIndexInGarage);
                    Console.WriteLine("Car booked successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
            PauseForUser();
        }

        private void PauseForUser()
        {
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void ShowAllCars(bool displayIndices = false)
        {
            ShowAllCars(out _, out _, displayIndices);
        }
    }