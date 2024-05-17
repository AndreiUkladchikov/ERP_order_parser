namespace Domain.Models
{
    public class OrderDetails
    {
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// Other Properties
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
