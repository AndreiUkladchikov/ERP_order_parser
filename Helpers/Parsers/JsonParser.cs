using Domain.Models;

namespace Helpers.Parsers
{
    public class JsonParser : ParserBase, IParser
    {
        public override OrderDetails Parse(byte[] data)
        {
            return base.Parse(data);
        }
    }
}
