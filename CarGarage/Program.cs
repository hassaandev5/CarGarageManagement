namespace CarGarage;

class Program
{
    static void Main(string[] args)
    {
        Admin admin1 = new Admin() { Id = 1, Name = "jhon", Password = "123" };
        Admin admin2 = new Admin() { Id = 2, Name = "aurthor", Password = "456" };
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
                Console.WriteLine("Enter Your Name: ");
                string? name = Console.ReadLine();
                if (name == admin1.Name || name == admin2.Name)
                {
                    
                    Console.WriteLine("Enter Your Password: ");
                    string? password = Console.ReadLine();
                    if (name == admin1.Name && password == admin1.Password || name == admin2.Name && password == admin2.Password)
                    {
                        Console.WriteLine("Welcome {0} you are recognized as an Admin", name);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No Admin Found with the Name {0}", name);
                    return;
                }
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
