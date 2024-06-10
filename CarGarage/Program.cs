namespace CarGarage;

class Program
{
    static void Main(string[] args)
    {
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
                Admin admin = new Admin();
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
