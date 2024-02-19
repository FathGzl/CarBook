using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GerCarsListWithBramds();
        List<Car> GerLast5CarsListWithBramds();

    }
}