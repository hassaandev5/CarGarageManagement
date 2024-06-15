using CarGarage.Models;

namespace CarGarage.Interfaces;

public interface IGarage
{
    void AddCar(Car car);
    void UpdateCar(int index, Car car);
    void RemoveCar(int index);
    void BookCar(int index);
    List<Car> GetAllCars();
    List<Car> GetCarsByBrand(string brand);
}

