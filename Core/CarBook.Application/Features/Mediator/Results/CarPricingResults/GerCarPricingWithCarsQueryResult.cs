namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GerCarPricingWithCarsQueryResult
    {
        public int CarID { get; set; }
        public int CarPricingID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Amount { get; set; }
    }
}
