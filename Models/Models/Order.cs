namespace Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime Date {  get; set; }
        public OrderDetails Details { get; set; }
    }
}
