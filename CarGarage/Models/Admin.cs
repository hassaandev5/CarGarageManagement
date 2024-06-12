namespace CarGarage.Models;

public class Admin
{
    public string Username { get; private set; }
    private string password;

    public Admin(string username, string password)
    {
        Username = username;
        this.password = password;
    }

    public bool Authenticate(string password)
    {
        return this.password == password;
    }
}

