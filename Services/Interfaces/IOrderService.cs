using DTO;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(OrderDTO orderDTO);
    }
}
