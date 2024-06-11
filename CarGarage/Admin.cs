namespace CarGarage;

public class Admin
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }

    // public void AdminAuth()
    // {
    //     Console.WriteLine("Enter Your Name: ");
    //     string? name = Console.ReadLine();
    //     string? password;
    //     if (name == this.Name)
    //     {
    //         Console.WriteLine("Welcome {0} you are recognized as an Admin", name);
    //         Console.WriteLine("Enter Your Password: ");
    //         password = Console.ReadLine();
    //         if (password == this.Password)
    //         {
    //             AdminMenu(name);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No Admin Found with the Name {0}", name);
    //         return;
    //     }
    // }
    // public static void AdminMenu(string? name)
    // {
    //     Console.WriteLine("Welcome {0}", name);
    // }
}
