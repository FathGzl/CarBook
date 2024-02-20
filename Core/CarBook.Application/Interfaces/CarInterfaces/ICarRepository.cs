using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GerCarsListWithBrands();
        List<Car> GerLast5CarsListWithBrands();
    }
}