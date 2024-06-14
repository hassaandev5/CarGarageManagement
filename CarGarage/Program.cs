using CarGarage.Models;
using CarGarage.Services;
using CarGarage.UI;

namespace CarGarage;

class Program
{
    static void Main(string[] args)
    {
        var garage = new Garage();
        var admins = new List<Admin>
        {
            new Admin("admin1", "password1"),
            new Admin("admin2", "password2")
        };
        var stockCars = new List<Car>
        {
            new Car("Honda", "civic", 2019, "white", 24000),
            new Car("Honda", "civic", 2019, "silver", 20000),
            new Car("Toyota", "corolla", 2020, "red", 23000),
            new Car("Toyota", "camry", 2021, "black", 28000),
            new Car("Ford", "mustang", 2022, "blue", 30000),
            new Car("Ford", "focus", 2023, "green", 25000),
            new Car("Ford", "chita", 2023, "yellow", 22000),
        };

        foreach (var car in stockCars)
        {
            garage.AddCar(car);
        }

        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the garage management app");
            Console.WriteLine("1. Enter as Admin");
            Console.WriteLine("2. Enter as Viewer/User");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdminLogin(admins, garage);
                    break;
                case "2":
                    var viewerInterface = new ViewerInterface(garage);
                    viewerInterface.ShowMenu();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AdminLogin(List<Admin> admins, IGarage garage)
    {
        Console.Write("Enter username: ");
        var username = Console.ReadLine();
        Console.Write("Enter password: ");
        var password = Console.ReadLine();

        var admin = admins.Find(a => a.Username == username && a.Authenticate(password));

        if (admin != null)
        {
            var adminInterface = new AdminInterface(admin, garage);
            adminInterface.ShowMenu();
        }
        else
        {
            Console.WriteLine("Invalid credentials. Press any key to return to main menu.");
            Console.ReadKey();
        }
    }
}
