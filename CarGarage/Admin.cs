namespace CarGarage;

public class Admin
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }


    // public Admin(int id, string name, string password)
    // {
    //     this.Id = id;
    //     this.Name = name;
    //     this.Password = password;
    // }
    public static void AdminMenu()
    {
        Console.WriteLine("Welcome Admin");
    }
}
