namespace Turbokart.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}
