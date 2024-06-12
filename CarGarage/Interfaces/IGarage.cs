using CarGarage.Models;

namespace CarGarage;

public interface IGarage
{
    void AddCar(Car car);
    void UpdateCar(int index, Car car);
    void RemoveCar(int index);
    List<Car> GetAllCars();
    List<Car> GetCarsByBrand(string brand);
}

