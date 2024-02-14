namespace CarBook.Domain.Entities
{
    public class CarDesription
    {
        public int CarDesriptionID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
    }
}