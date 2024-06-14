namespace CarGarage.Models;

public class Car
{
    // public int Price { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public bool Booked { get; set; }

    public Car(/*int price */string brand, string model, int year, string color, decimal price)
    {
        // Price = price;
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
        Booked = false;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} ({Year}) - {Color} - ${Price} - {(Booked ? "Booked" : "Available")}";
    }
}
