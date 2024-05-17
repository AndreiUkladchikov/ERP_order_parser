using Domain.Models;

namespace Helpers.Parsers
{
    public class XmlParser : ParserBase, IParser
    {
        public override OrderDetails Parse(byte[] data)
        {
            return base.Parse(data);
        }
    }
}
