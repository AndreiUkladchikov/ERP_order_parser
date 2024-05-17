using DTO;
using Services.Interfaces;
using System.Text.Json;

namespace Services
{
    public class MessageReceiver
    {
        private readonly IOrderService _orderService;
        public MessageReceiver(IOrderService orderService) 
        {
            _orderService = orderService;
        }

        protected void HandleMessage(string message)
        {
            OrderDTO order = JsonSerializer.Deserialize<OrderDTO>(message);

            _orderService.CreateOrder(order);
        }
    }
}
