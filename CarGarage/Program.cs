namespace CarGarage;

class Program
{
    static void Main(string[] args)
    {

        List<Car> listCars = new List<Car>()
        {
            new Car(1, "Honda", "Civic", 2021, "Black"),
            new Car(2, "Toyota", "Camry", 2022, "White"),
            new Car(3, "Nissan", "Altima", 2019, "Blue"),
            new Car(4, "Honda", "Pilot", 2020, "Red"),
            new Car(5, "Toyota", "Avalon", 2018, "Green") ,
            new Car(6, "Nissan", "Sentra", 2017, "Yellow"),
            new Car(7, "Kia", "Sorento", 2016, "Purple"),
            new Car(8, "Honda", "Fit", 2015, "Orange"),
            new Car(9, "Toyota", "86", 2014, "Gray"),
            new Car(10, "Nissan", "GT-R", 2013, "Black"),
            new Car(11, "Kia", "Optima", 2021, "Black"),
            new Car(12, "Honda", "HR-V", 2022, "White"),
            new Car(13, "Nissan", "Micra", 2019, "Blue"),
            new Car(14, "Toyota", "C-HR", 2020, "Red"),
            new Car(15, "Kia", "Sportage", 2018, "Green")
        };

        List<Admin> listAdmins = new List<Admin>()
        {
            new Admin(1, "jhon", "123"),
            new Admin(2, "aurthor", "456")
        };

        int choice;
        do
        {
        Console.WriteLine("-------------Car Garage Management-------------");
        Console.WriteLine("Welcome to the garage management app");

        Console.WriteLine("1. Enter As an Admin");
        Console.WriteLine("2. Enter As a User");
        Console.WriteLine("3. Exit");

        Console.WriteLine("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                // First authorization the admin then bring the admin menu

                // 1. Admin auth
                Console.WriteLine("Enter your name: ");
                string? name = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                string? password = Console.ReadLine();

                Admin? foundPerson = listAdmins.Find(admin => admin.Name == name && admin.Password == password);
                if (foundPerson != null)
                {
                    Console.WriteLine("Welcome {0}", foundPerson.Name);

                    // 2. Admin menu
                    Admin.AdminMenu();

                }
                else
                {
                    Console.WriteLine("Invalid name or password");
                    return;
                }
                // 2. Admin menu


                // admin.AdminMenu();
                break;
            case 2:
                // User user = new User();
                // user.UserMenu();
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        }
        while(choice != 3);
    }
}
