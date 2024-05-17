using Domain.Models;
using DTO;

namespace Helpers.Mappers
{
    public static class OrderMapper
    {
        public static Order Map(OrderDTO dto)
        {
            return new Order
            {
                ClientId = dto.ClientId,
                Date = dto.Date,
            };
        }
    }
}
