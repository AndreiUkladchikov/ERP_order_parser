﻿using Domain.Models;

namespace Helpers.Parsers
{
    public class CsvParser : ParserBase, IParser
    {
        public override OrderDetails Parse(byte[] data)
        {
            return base.Parse(data);
        }
    }
}
