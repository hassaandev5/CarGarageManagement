namespace CarGarage;

public class Admin
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }

    // public List<Car>? Cars { get; set; }

    public Admin(int id, string? name, string? password /* List<Car>? cars */)
    {
        Id = id;
        Name = name;
        Password = password;
        // Cars = cars;
    }

    public static void AdminMenu()
    {
        int adminChoice;
        do
        {
        Console.WriteLine("-------------Admin Menu-------------");
        Console.WriteLine("1. Show all cars");
        Console.WriteLine("2. Add a car");
        Console.WriteLine("3. Remove a car");
        Console.WriteLine("4. Update a car");
        Console.WriteLine("5. Exit");
        adminChoice = Convert.ToInt32(Console.ReadLine());

        switch (adminChoice)
        {
            case 1:
                // Console.WriteLine("Select a brand:");
                // foreach (var car in Program.listCars)
                // {
                //     Console.WriteLine($"{car.Brand}");
                // }
                // string carBrand = Console.ReadLine();
                // Console.WriteLine("");
                // foreach (var car in Program.listCars)
                // {
                //     if (car.Brand == carBrand)
                //     {
                //         Console.WriteLine($"Brand: {car.Brand} | Model: {car.Model} | Year: {car.Year} | Color: {car.Color}");
                //     }
                // }
                break;
            case 2:
                // RemoveCarMenu();
                break;
            case 3:
                // UpdateCarMenu();
                break;
            case 4:
                // ShowAllCarsMenu();
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        } while (adminChoice != 5);
    }
}
