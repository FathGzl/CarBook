namespace CarBook.Application.Features.Mediator.Results.PricingResults
{
    public class GetAuthorByIdQueryResult
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}