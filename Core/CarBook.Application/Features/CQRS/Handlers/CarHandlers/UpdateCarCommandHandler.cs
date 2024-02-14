using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.BrandID = command.BrandID;
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Fuel = command.Fuel;
            values.Transmission = command.Transmission;
            values.Seat = command.Seat;
            values.Model = command.Model;
            values.Km = command.Km;
            values.Luggage = command.Luggage;
            await _repository.UpdateAsync(values);
        }
    }
}