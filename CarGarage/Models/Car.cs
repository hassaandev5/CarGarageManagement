namespace CarGarage.Models;

public class Car
{
    // public int Price { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(/*int price */string brand, string model, int year, string color)
    {
        // Price = price;
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
    }

    public override string ToString()
    {
        return $"{Year} {Brand} {Model} ({Color})";
    }
}
