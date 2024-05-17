using Domain.Constants;
namespace Helpers.Parsers
{
    public static class ParserBuilder
    {
        public static IParser CreateParser(string fileType)
        {
            return fileType switch
            {
                FileTypes.TYPE_CSV => new CsvParser(),
                FileTypes.TYPE_EXCEL => new ExcelParcer(),
                FileTypes.TYPE_XML => new XmlParser(),
                FileTypes.TYPE_JSON => new JsonParser(),
                _ => throw new NotImplementedException("This file type is not supported")
            };
        }
    }
}
