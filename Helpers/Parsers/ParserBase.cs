using Domain.Models;

namespace Helpers.Parsers
{
    public abstract class ParserBase
    {
        public virtual OrderDetails Parse(byte[] data)
        {
            return new OrderDetails();
        }
    }
}
