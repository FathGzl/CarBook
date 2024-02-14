namespace CarBook.Application.Features.CQRS.Results.CategoryResult
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}