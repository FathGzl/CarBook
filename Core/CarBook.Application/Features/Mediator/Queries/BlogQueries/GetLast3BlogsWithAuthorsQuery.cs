using CarBook.Application.Features.Mediator.Results.BlogResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        public Task Handle(List<GetLast3BlogsWithAuthorsQueryResult> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
