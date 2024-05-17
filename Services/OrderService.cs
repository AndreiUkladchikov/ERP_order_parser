using Domain.Models;
using DTO;
using Helpers.Mappers;
using Helpers.Parsers;
using Services.Interfaces;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IAuthProvider _authProvider;
        
        public OrderService(IAuthProvider authProvider) 
        {
            _authProvider = authProvider;
        }

        public void CreateOrder(OrderDTO orderDTO)
        {
            Order order = OrderMapper.Map(orderDTO);

            if (order.ClientId is null)
            {
                order.ClientId = !string.IsNullOrEmpty(orderDTO.Email)
                    ? _authProvider.GetClientIdByEmail(orderDTO.Email)
                    : _authProvider.GetClientIdByTelegram(orderDTO.TelegramId);
            }

            IParser parser = ParserBuilder.CreateParser(orderDTO.FileType);

            order.Details = parser.Parse(orderDTO.Data);

            ///
            /// Put order into ERP 
            /// 
        }
    }
}
