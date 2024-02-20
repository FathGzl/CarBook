using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    internal class GetCarPricingWithCarsQueryHandler : IRequestHandler<GetCarPricingWithCarsQuery, List<GerCarPricingWithCarsQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarsQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GerCarPricingWithCarsQueryResult>> Handle(GetCarPricingWithCarsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithCars();
            return values.Select(x => new GerCarPricingWithCarsQueryResult
            {
                Amount = x.Amount,
                BrandName = x.Car.Brand.Name,
                CarPricingID = x.CarPricingID,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model
            }).ToList();
        }
    }
}
