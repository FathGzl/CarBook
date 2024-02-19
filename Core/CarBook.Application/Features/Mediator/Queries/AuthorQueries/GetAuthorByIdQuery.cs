using CarBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}