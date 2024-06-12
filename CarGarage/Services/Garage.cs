using System.Collections.Generic;
using CarGarage.Models;

namespace CarGarage.Services;

public class Garage : IGarage
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void UpdateCar(int index, Car car)
    {
        if (index >= 0 && index < cars.Count)
        {
            cars[index] = car;
        }
    }

    public void RemoveCar(int index)
    {
        if (index >= 0 && index < cars.Count)
        {
            cars.RemoveAt(index);
        }
    }

    public List<Car> GetAllCars()
    {
        return new List<Car>(cars);
    }

    public List<Car> GetCarsByBrand(string brand)
    {
        return cars.FindAll(c => c.Brand.Equals(brand, System.StringComparison.OrdinalIgnoreCase));
    }
}
