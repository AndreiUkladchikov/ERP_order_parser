using Domain.Models;

namespace Helpers.Parsers
{
    public interface IParser
    {
        OrderDetails Parse(byte[] data);
    }
}
